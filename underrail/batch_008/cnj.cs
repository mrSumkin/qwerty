using System;
using System.Runtime.CompilerServices;

// Token: 0x02000ED9 RID: 3801
[e79("Arena/ChemicalAgentFight")]
public sealed class cnj : ds5
{
	// Token: 0x06004E11 RID: 19985 RVA: 0x0022A6F4 File Offset: 0x002288F4
	protected override string abn()
	{
		return "ChemicalAgentFightEnd";
	}

	// Token: 0x06004E12 RID: 19986 RVA: 0x0022A700 File Offset: 0x00228900
	protected override void abo(cnk A_0, c5x A_1)
	{
		cnj.a a = new cnj.a();
		a.a = A_0;
		btm[] array = new btm[1];
		int num = 0;
		dva dva = new dva(null, null, null, null, null);
		dva.a(new Func<e6d, bool>(a.a));
		array[num] = dva;
		base.a(array);
	}

	// Token: 0x06004E13 RID: 19987 RVA: 0x0022A748 File Offset: 0x00228948
	protected override void abp(cnk A_0, c5x A_1)
	{
		base.a("Мы приносим вам извинения за опоздание, маньяки!", 4);
		base.a("Без долгих разговоров, встречайте: с одной стороны \u0097 наш всеми любимый Химикат и его зверюшки...", 4);
		string str = "А с другой \u0097 ";
		object obj = A_0.aqu().r()["playerArenaTitle"];
		base.a(str + ((obj != null) ? obj.ToString() : null) + ".", 4);
		base.a("Оба гладиатора уже наглядно показали нам, какие они полные маньяки, и я не сомневаюсь \u0097 мы увидим страшную битву!", 5);
	}

	// Token: 0x06004E14 RID: 19988 RVA: 0x0022A7B8 File Offset: 0x002289B8
	protected override void abq(cnk A_0, c5x A_1)
	{
		base.a("Знаете, я думаю, нас ждёт бурная реакция между этими двумя гладиаторами. ::Смеётся.::", 5);
		base.a("Нам покажите вы кровопролитие!", 4);
	}

	// Token: 0x02000EDA RID: 3802
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004E17 RID: 19991 RVA: 0x0022A7E4 File Offset: 0x002289E4
		internal bool a(e6d A_0)
		{
			csd a_ = this.a.aqw().g("enemyGladiator");
			csd[] array = new csd[]
			{
				this.a.aqw().g("sidekick1"),
				this.a.aqw().g("sidekick2")
			};
			vq.a("creatures\\arena\\ChemicalAgent", a_, false);
			foreach (csd a_2 in array)
			{
				c5x c5x = vq.a("creatures\\MutatedDog", a_2, false);
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
			}
			return true;
		}

		// Token: 0x04001FDD RID: 8157
		public cnk a;
	}
}
