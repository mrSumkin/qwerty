using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules;

// Token: 0x02000ECD RID: 3789
[e79("Arena/BurrowersFight")]
public sealed class dlz : ds5
{
	// Token: 0x06004DEC RID: 19948 RVA: 0x00229FDC File Offset: 0x002281DC
	protected override int abm()
	{
		return 1;
	}

	// Token: 0x06004DED RID: 19949 RVA: 0x00229FE0 File Offset: 0x002281E0
	protected override string abn()
	{
		return "BurrowersFightEnd";
	}

	// Token: 0x06004DEE RID: 19950 RVA: 0x00229FE8 File Offset: 0x002281E8
	protected override void abo(cnk A_0, c5x A_1)
	{
		dlz.a a = new dlz.a();
		a.a = A_0;
		btm[] array = new btm[1];
		int num = 0;
		dva dva = new dva(null, null, null, null, null);
		dva.a(new Func<e6d, bool>(a.a));
		array[num] = dva;
		base.a(array);
	}

	// Token: 0x06004DEF RID: 19951 RVA: 0x0022A030 File Offset: 0x00228230
	protected override void abp(cnk A_0, c5x A_1)
	{
		base.a("Могильщики \u0097 с ними нам не ужиться, ведь они закопают нас всех!", 4);
		base.a("Но ведь за этим вы здесь, кровожадные маньяки.", 4);
		base.a("Чтобы увидеть как эти твари подыхают в мучениях!", 4);
	}

	// Token: 0x06004DF0 RID: 19952 RVA: 0x0022A058 File Offset: 0x00228258
	protected override void abq(cnk A_0, c5x A_1)
	{
		base.a("Претенденты, нам покажите вы кровопролитие!", 4);
	}

	// Token: 0x02000ECE RID: 3790
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004DF3 RID: 19955 RVA: 0x0022A07C File Offset: 0x0022827C
		internal bool a(e6d A_0)
		{
			bu6 service = bpo.GetService<bu6>();
			for (int i = 1; i <= 12; i++)
			{
				csd a_ = this.a.aqw().g("monster" + i.ToString());
				if (i % 3 == 0)
				{
					vq.a("creatures\\Burrower", a_, false);
				}
				else if (i == 2 && service.aq2() >= GameDifficulty.Dominating)
				{
					vq.a("creatures\\BurrowerWarrior", a_, false);
				}
				else
				{
					vq.a("creatures\\Spawn", a_, false);
				}
			}
			csd a_2 = this.a.aqw().g("gladiator2");
			vq.a("creatures\\arena\\challenger2", a_2, false);
			csd a_3 = this.a.aqw().g("gladiator3");
			vq.a("creatures\\arena\\challenger3", a_3, false);
			return true;
		}

		// Token: 0x04001FD9 RID: 8153
		public cnk a;
	}
}
