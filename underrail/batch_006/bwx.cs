using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules;

// Token: 0x02000EC7 RID: 3783
[e79("Arena/PsiBeetlesFight")]
public sealed class bwx : ds5
{
	// Token: 0x06004DD8 RID: 19928 RVA: 0x00229C88 File Offset: 0x00227E88
	protected override int abm()
	{
		return 3;
	}

	// Token: 0x06004DD9 RID: 19929 RVA: 0x00229C8C File Offset: 0x00227E8C
	protected override string abn()
	{
		return "PsiBeetlesFightEnd";
	}

	// Token: 0x06004DDA RID: 19930 RVA: 0x00229C94 File Offset: 0x00227E94
	protected override void abo(cnk A_0, c5x A_1)
	{
		bwx.a a = new bwx.a();
		a.a = A_0;
		btm[] array = new btm[1];
		int num = 0;
		dva dva = new dva(null, null, null, null, null);
		dva.a(new Func<e6d, bool>(a.a));
		array[num] = dva;
		base.a(array);
	}

	// Token: 0x06004DDB RID: 19931 RVA: 0x00229CDC File Offset: 0x00227EDC
	protected override void abp(cnk A_0, c5x A_1)
	{
		base.a("Мы снова с вами! Уверен, вам не терпится увидеть очередное жестокое шоу!", 4);
		base.a("Ах, неужели кто-то упомянул жуков? Так вот что сегодня в меню для наших претендентов!", 4);
		base.a("Или это они сами в меню?! ::Смеётся.::", 4);
	}

	// Token: 0x06004DDC RID: 19932 RVA: 0x00229D04 File Offset: 0x00227F04
	protected override void abq(cnk A_0, c5x A_1)
	{
		base.a("Нам покажите вы кровопролитие!", 4);
	}

	// Token: 0x02000EC8 RID: 3784
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004DDF RID: 19935 RVA: 0x00229D28 File Offset: 0x00227F28
		internal bool a(e6d A_0)
		{
			bu6 service = bpo.GetService<bu6>();
			for (int i = 1; i <= 9; i++)
			{
				csd a_ = this.a.aqw().g("monster" + i.ToString());
				if (i == 9 && service.aq2() >= GameDifficulty.Dominating)
				{
					vq.a("creatures\\GreaterPsiBeetle", a_, false);
				}
				else
				{
					vq.a("creatures\\PsiBeetle", a_, false);
				}
			}
			csd a_2 = this.a.aqw().g("gladiator1");
			vq.a("creatures\\arena\\challenger3", a_2, false);
			csd a_3 = this.a.aqw().g("gladiator2");
			vq.a("creatures\\arena\\challenger4", a_3, false);
			return true;
		}

		// Token: 0x04001FD7 RID: 8151
		public cnk a;
	}
}
