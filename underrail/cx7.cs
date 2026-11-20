using System;
using System.Runtime.CompilerServices;

// Token: 0x02000EDF RID: 3807
[e79("Arena/ZapFight")]
public sealed class cx7 : ds5
{
	// Token: 0x06004E23 RID: 20003 RVA: 0x0022AAE8 File Offset: 0x00228CE8
	protected override string abn()
	{
		return "ZapFightEnd";
	}

	// Token: 0x06004E24 RID: 20004 RVA: 0x0022AAF0 File Offset: 0x00228CF0
	protected override void abo(cnk A_0, c5x A_1)
	{
		cx7.a a = new cx7.a();
		a.a = A_0;
		btm[] array = new btm[1];
		int num = 0;
		dva dva = new dva(null, null, null, null, null);
		dva.a(new Func<e6d, bool>(a.a));
		array[num] = dva;
		base.a(array);
	}

	// Token: 0x06004E25 RID: 20005 RVA: 0x0022AB38 File Offset: 0x00228D38
	protected override void abp(cnk A_0, c5x A_1)
	{
		base.a("Ну разве это был не великолепный матч?", 4);
		base.a("Но подождите, это ещё не всё! Наш заключительный матч на сегодня будет поистине шокирующим!", 4);
		base.a("Ну конечно же, перед нами выступит Трах!", 4);
		base.a("Пришедший из Зоны провала, чтобы сеять боль и страдания, и как он в этом прекрасен!", 4);
	}

	// Token: 0x06004E26 RID: 20006 RVA: 0x0022AB78 File Offset: 0x00228D78
	protected override void abq(cnk A_0, c5x A_1)
	{
		base.a("И конечно же, с ним рядом всегда верный плазменный страж!", 4);
		string str = "Но ";
		object obj = A_0.aqu().r()["playerArenaTitle"];
		base.a(str + ((obj != null) ? obj.ToString() : null) + " не лёгкая цель!", 4);
		base.a("Нас ждёт один из тех матчей, которые непременно шокируют вас, дорогие маньяки! Смотрите и наслаждайтесь!", 5);
		string str2 = "Трах! ";
		object obj2 = A_0.aqu().r()["playerArenaTitle"];
		base.a(str2 + ((obj2 != null) ? obj2.ToString() : null) + "! Нам покажите вы кровопролитие!", 4);
	}

	// Token: 0x02000EE0 RID: 3808
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004E29 RID: 20009 RVA: 0x0022AC2C File Offset: 0x00228E2C
		internal bool a(e6d A_0)
		{
			csd a_ = this.a.aqw().g("enemyGladiator");
			csd a_2 = this.a.aqw().g("sidekick1");
			vq.a("creatures\\arena\\Zap", a_, false);
			c5x c5x = vq.a("creatures\\machines\\plasmaSentry", a_2, false);
			if (c5x != null)
			{
				c5x.RemoveAspect<a6p>();
				if (c5x.h.b != null)
				{
					c5x.h.b.g(true);
					c5x.h.b.i(true);
					c5x.h.b.aa().FactionId = asp.eq;
				}
			}
			return true;
		}

		// Token: 0x04001FDF RID: 8159
		public cnk a;
	}
}
