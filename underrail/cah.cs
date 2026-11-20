using System;

// Token: 0x02000C3B RID: 3131
public sealed class cah : jn
{
	// Token: 0x060046A4 RID: 18084 RVA: 0x001D2620 File Offset: 0x001D0820
	public cah() : base("jy_garrensSoldier1", "creature\\characters\\support\\jy_garrensSoldier1")
	{
	}

	// Token: 0x060046A5 RID: 18085 RVA: 0x001D2634 File Offset: 0x001D0834
	public override string b1(cyt A_0)
	{
		if (new wn().b1(A_0) == "jyt5")
		{
			return "jyt5";
		}
		return "jye1";
	}

	// Token: 0x060046A6 RID: 18086 RVA: 0x001D2660 File Offset: 0x001D0860
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
			aspect.y6()["GuardLoc"] = new bt4("global:jy_garrensSoldier1");
		}
	}
}
