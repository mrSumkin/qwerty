using System;

// Token: 0x02000C38 RID: 3128
public sealed class aqk : jn
{
	// Token: 0x0600469B RID: 18075 RVA: 0x001D2388 File Offset: 0x001D0588
	public aqk() : base("jy_garrensSoldier4", "creature\\characters\\support\\jy_garrensSoldier4")
	{
	}

	// Token: 0x0600469C RID: 18076 RVA: 0x001D239C File Offset: 0x001D059C
	public override string b1(cyt A_0)
	{
		if (new wn().b1(A_0) == "jyt5")
		{
			return "jyt5";
		}
		return "jye2";
	}

	// Token: 0x0600469D RID: 18077 RVA: 0x001D23C4 File Offset: 0x001D05C4
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
			aspect2.y6()["GuardLoc"] = new bt4("global:jy_garrensSoldier4");
		}
	}
}
