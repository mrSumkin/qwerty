using System;

// Token: 0x02000C30 RID: 3120
public sealed class aak : jn
{
	// Token: 0x06004685 RID: 18053 RVA: 0x001D1AB8 File Offset: 0x001CFCB8
	public aak() : base("sgs_roman", "creature\\characters\\sgs_roman")
	{
	}

	// Token: 0x06004686 RID: 18054 RVA: 0x001D1AD0 File Offset: 0x001CFCD0
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_jygetSupportForEels_gotSgsSupport", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("quest_jyeelsAttack_movedOut", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quest_jyeelsAttack_cleared", new bool?(false)).Value)
		{
			return "jy6";
		}
		return "LU-SouthGateStation-N";
	}

	// Token: 0x06004687 RID: 18055 RVA: 0x001D1B54 File Offset: 0x001CFD54
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		if (A_0 != null)
		{
			bm6 aspect = A_0.GetAspect<bm6>();
			if (aspect != null)
			{
				if (A_2 == "jy6")
				{
					aspect.y6()["GuardLoc"] = new bt4("sid0");
					return;
				}
				aspect.y6()["GuardLoc"] = new bt4("global:sgs_roman");
			}
		}
	}
}
