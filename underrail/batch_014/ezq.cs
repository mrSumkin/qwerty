using System;
using System.Runtime.CompilerServices;

// Token: 0x02000EE2 RID: 3810
[e79("Arena/StygianExorcistFight")]
public sealed class ezq : ds5
{
	// Token: 0x06004E2C RID: 20012 RVA: 0x0022AD54 File Offset: 0x00228F54
	protected override string abn()
	{
		return "StygianExorcistFightEnd";
	}

	// Token: 0x06004E2D RID: 20013 RVA: 0x0022AD60 File Offset: 0x00228F60
	protected override void abo(cnk A_0, c5x A_1)
	{
		ezq.a a = new ezq.a();
		a.a = A_0;
		btm[] array = new btm[1];
		int num = 0;
		dva dva = new dva(null, null, null, null, null);
		dva.a(new Func<e6d, bool>(a.a));
		array[num] = dva;
		base.a(array);
	}

	// Token: 0x06004E2E RID: 20014 RVA: 0x0022ADA8 File Offset: 0x00228FA8
	protected override void abp(cnk A_0, c5x A_1)
	{
		base.a("Мы в эфире? Я спрашиваю, мы в э...", 3);
		base.a("Кхм... Добро пожаловать на этот фантастический матч, мои дорогие маньяки!", 4);
		base.a("Наши два гладиатора сумеют развлечь всех как на Арене, так и тех, кто смотрит канал «Арена Сегодня»!", 5);
		base.a("Вы любите их обоих, но один из них падёт сегодня в великолепной схватке, которая, без сомнений, запомнится нам надолго!", 5);
	}

	// Token: 0x06004E2F RID: 20015 RVA: 0x0022ADE8 File Offset: 0x00228FE8
	protected override void abq(cnk A_0, c5x A_1)
	{
		object obj = A_0.aqu().r()["playerArenaTitle"];
		base.a(((obj != null) ? obj.ToString() : null) + ", непреклонная машина смерти сразится со...", 4);
		base.a("Стигийским экзорцистом! Он загадочен, он брутален! Эти убийцы готовы развлечь вас, маньяки!", 5);
		base.a("Не будем терять времени, нас ждёт кровопролитие!", 4);
	}

	// Token: 0x02000EE3 RID: 3811
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004E32 RID: 20018 RVA: 0x0022AE5C File Offset: 0x0022905C
		internal bool a(e6d A_0)
		{
			csd a_ = this.a.aqw().g("enemyGladiator");
			c5x c5x = vq.a("creatures\\arena\\StygianExorcist", a_, false);
			if (c5x != null && c5x.h.b != null)
			{
				alf alf = new alf(70000);
				alf.Stacks = 9;
				c5x.h.b.aa().StatusEffects.a(alf, false, false, false);
				c5x.h.b.aa().Cooldowns.a(new cfd[]
				{
					new cfd("Psi.PseudoSpatialProjection", 70000, false, false)
				});
			}
			return true;
		}

		// Token: 0x04001FE0 RID: 8160
		public cnk a;
	}
}
