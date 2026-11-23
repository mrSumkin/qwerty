using System;

// Token: 0x02000C3A RID: 3130
public sealed class a8b : jn
{
	// Token: 0x060046A1 RID: 18081 RVA: 0x001D2574 File Offset: 0x001D0774
	public a8b() : base("jy_garrensSoldier2", "creature\\characters\\support\\jy_garrensSoldier2")
	{
	}

	// Token: 0x060046A2 RID: 18082 RVA: 0x001D2588 File Offset: 0x001D0788
	public override string b1(cyt A_0)
	{
		if (new wn().b1(A_0) == "jyt5")
		{
			return "jyt5";
		}
		return "jye1";
	}

	// Token: 0x060046A3 RID: 18083 RVA: 0x001D25B4 File Offset: 0x001D07B4
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		if (aspect != null)
		{
			if (A_2 == "jyt5")
			{
				aspect.b("humanSoldier");
				aspect.y6()["GuardLoc"] = null;
				return;
			}
			aspect.b("jye_guard1");
			aspect.y6()["GuardLoc"] = new bt4("global:jy_garrensSoldier2");
		}
	}
}
