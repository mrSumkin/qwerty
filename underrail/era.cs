using System;

// Token: 0x02000C31 RID: 3121
public sealed class era : jn
{
	// Token: 0x06004688 RID: 18056 RVA: 0x001D1BBC File Offset: 0x001CFDBC
	public era() : base("jy_silas", "creature\\characters\\jy_silas")
	{
	}

	// Token: 0x06004689 RID: 18057 RVA: 0x001D1BD0 File Offset: 0x001CFDD0
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_jyeelsAttack_movedOut", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quest_jyeelsAttack_cleared", new bool?(false)).Value)
		{
			return "jy6";
		}
		return "jy5";
	}

	// Token: 0x0600468A RID: 18058 RVA: 0x001D1C30 File Offset: 0x001CFE30
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		if (A_0 != null)
		{
			bm6 aspect = A_0.GetAspect<bm6>();
			if (aspect != null)
			{
				if (A_2 == "jy6")
				{
					aspect.y6()["GuardLoc"] = new bt4("eid0");
					return;
				}
				aspect.y6()["GuardLoc"] = new bt4("global:jy_silas");
			}
		}
	}
}
