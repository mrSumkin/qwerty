using System;

// Token: 0x02000C39 RID: 3129
public sealed class d5y : jn
{
	// Token: 0x0600469E RID: 18078 RVA: 0x001D247C File Offset: 0x001D067C
	public d5y() : base("jy_garrensSoldier3", "creature\\characters\\support\\jy_garrensSoldier3")
	{
	}

	// Token: 0x0600469F RID: 18079 RVA: 0x001D2490 File Offset: 0x001D0690
	public override string b1(cyt A_0)
	{
		if (new wn().b1(A_0) == "jyt5")
		{
			return "jyt5";
		}
		return "jye2";
	}

	// Token: 0x060046A0 RID: 18080 RVA: 0x001D24BC File Offset: 0x001D06BC
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		amc aspect = A_0.GetAspect<amc>();
		if (aspect != null)
		{
			if (A_2 == "jyt5")
			{
				aspect.aa().c(asp.a);
				aspect.aa().FactionId = asp.bh;
			}
			else
			{
				aspect.aa().c(asp.a);
				aspect.aa().FactionId = asp.bi;
			}
		}
		bm6 aspect2 = A_0.GetAspect<bm6>();
		if (aspect2 != null)
		{
			if (A_2 == "jyt5")
			{
				aspect2.y6()["GuardLoc"] = null;
				return;
			}
			aspect2.y6()["GuardLoc"] = new bt4("global:jy_garrensSoldier3");
		}
	}
}
