using System;
using System.Runtime.CompilerServices;

// Token: 0x02000EC0 RID: 3776
[e79("Arena/RathoundPackFight")]
public sealed class bug : ds5
{
	// Token: 0x06004DC3 RID: 19907 RVA: 0x00229318 File Offset: 0x00227518
	protected override int abm()
	{
		return 2;
	}

	// Token: 0x06004DC4 RID: 19908 RVA: 0x0022931C File Offset: 0x0022751C
	protected override string abn()
	{
		return "RathoundPackFightEnd";
	}

	// Token: 0x06004DC5 RID: 19909 RVA: 0x00229328 File Offset: 0x00227528
	protected override void abo(cnk A_0, c5x A_1)
	{
		bug.a a = new bug.a();
		a.a = A_0;
		btm[] array = new btm[1];
		int num = 0;
		dva dva = new dva(null, null, null, null, null);
		dva.a(new Func<e6d, bool>(a.a));
		array[num] = dva;
		base.a(array);
	}

	// Token: 0x06004DC6 RID: 19910 RVA: 0x00229370 File Offset: 0x00227570
	protected override void abp(cnk A_0, c5x A_1)
	{
		base.a("И мы снова в эфире!", 4);
		base.a("Мои кровожадные маньяки, сейчас вы увидите ещё одну прекрасную резню!", 4);
		base.a("Сегодня вашему вниманию предлагается схватка между этими тремя претендентами и сворой голодных крысоволков!", 4);
	}

	// Token: 0x06004DC7 RID: 19911 RVA: 0x00229398 File Offset: 0x00227598
	protected override void abq(cnk A_0, c5x A_1)
	{
		base.a("Нам покажите вы кровопролитие!", 4);
	}

	// Token: 0x02000EC1 RID: 3777
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004DCA RID: 19914 RVA: 0x002293BC File Offset: 0x002275BC
		internal bool a(e6d A_0)
		{
			for (int i = 1; i <= 12; i++)
			{
				csd a_ = this.a.aqw().g("monster" + i.ToString());
				c5x c5x;
				if (i == 2)
				{
					c5x = vq.a("creatures\\rathoundAncient", a_, false);
				}
				else if (i == 4 || i == 6 || i == 7)
				{
					c5x = vq.a("creatures\\rathoundAlpha", a_, false);
				}
				else
				{
					c5x = vq.a("creatures\\rathound", a_, false);
				}
				if (c5x != null)
				{
					c5x.RemoveAspect<a6p>();
					if (c5x.h.b != null)
					{
						c5x.h.b.aa().FactionId = asp.@as;
					}
				}
			}
			csd a_2 = this.a.aqw().g("gladiator1");
			vq.a("creatures\\arena\\challenger1", a_2, false);
			csd a_3 = this.a.aqw().g("gladiator3");
			vq.a("creatures\\arena\\challenger2", a_3, false);
			return true;
		}

		// Token: 0x04001FCE RID: 8142
		public cnk a;
	}
}
