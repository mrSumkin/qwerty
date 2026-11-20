using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules;

// Token: 0x02000ECA RID: 3786
[e79("Arena/SiphonersFight")]
public sealed class djb : ds5
{
	// Token: 0x06004DE2 RID: 19938 RVA: 0x00229E10 File Offset: 0x00228010
	protected override int abm()
	{
		return 2;
	}

	// Token: 0x06004DE3 RID: 19939 RVA: 0x00229E14 File Offset: 0x00228014
	protected override string abn()
	{
		return "SiphonersFightEnd";
	}

	// Token: 0x06004DE4 RID: 19940 RVA: 0x00229E20 File Offset: 0x00228020
	protected override void abo(cnk A_0, c5x A_1)
	{
		djb.a a = new djb.a();
		a.a = A_0;
		btm[] array = new btm[1];
		int num = 0;
		dva dva = new dva(null, null, null, null, null);
		dva.a(new Func<e6d, bool>(a.a));
		array[num] = dva;
		base.a(array);
	}

	// Token: 0x06004DE5 RID: 19941 RVA: 0x00229E68 File Offset: 0x00228068
	protected override void abp(cnk A_0, c5x A_1)
	{
		base.a("Добро пожаловать на очередное шоу!", 4);
		base.a("Приносим свои извинения всем нашим зрителям канала «Арена Сегодня»; нам только что сообщили, что у нас возникли небольшие технические неполадки.", 5);
		base.a("Но не волнуйтесь \u0097 мы разберёмся с ними как можно скорее; ваша жажда крови должна быть утолена! ::Смеётся.::", 5);
		base.a("Но не будем больше откладывать \u0097 пора нашим претендентам сразиться с брызгунами!", 4);
	}

	// Token: 0x06004DE6 RID: 19942 RVA: 0x00229EA8 File Offset: 0x002280A8
	protected override void abq(cnk A_0, c5x A_1)
	{
		base.a("Это будет хардкорное кровопролитие!", 4);
	}

	// Token: 0x02000ECB RID: 3787
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004DE9 RID: 19945 RVA: 0x00229ECC File Offset: 0x002280CC
		internal bool a(e6d A_0)
		{
			bu6 service = bpo.GetService<bu6>();
			for (int i = 1; i <= 7; i++)
			{
				csd a_ = this.a.aqw().g("monster" + i.ToString());
				if (dk2.b("xpbl") && ((i == 2 && service.aq2() >= GameDifficulty.Hard) || ((i == 3 || i == 7) && service.aq2() >= GameDifficulty.Dominating)))
				{
					vq.a("creatures\\xpbl\\GreaterSiphoner", a_, false);
				}
				else
				{
					vq.a("creatures\\Siphoner", a_, false);
				}
			}
			csd a_2 = this.a.aqw().g("gladiator1");
			vq.a("creatures\\arena\\challenger1", a_2, false);
			csd a_3 = this.a.aqw().g("gladiator3");
			vq.a("creatures\\arena\\challenger4", a_3, false);
			return true;
		}

		// Token: 0x04001FD8 RID: 8152
		public cnk a;
	}
}
