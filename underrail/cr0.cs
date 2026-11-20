using System;

// Token: 0x02000C2F RID: 3119
public sealed class cr0 : jn
{
	// Token: 0x06004682 RID: 18050 RVA: 0x001D1A20 File Offset: 0x001CFC20
	public cr0() : base("sgs_bisson", "creature\\characters\\sgs_bisson")
	{
	}

	// Token: 0x06004683 RID: 18051 RVA: 0x001D1A34 File Offset: 0x001CFC34
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("sgs_rocksCleared", new bool?(false)).Value)
		{
			return "StationAlpha-Level6";
		}
		return "LU-SouthGateStation-N";
	}

	// Token: 0x06004684 RID: 18052 RVA: 0x001D1A70 File Offset: 0x001CFC70
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		if (A_0 != null)
		{
			bm6 aspect = A_0.GetAspect<bm6>();
			if (aspect != null)
			{
				if (A_2 == "LU-SouthGateStation-N")
				{
					aspect.b("lu_sgsn_psionic");
					return;
				}
				aspect.b("humanSoldier");
			}
		}
	}
}
