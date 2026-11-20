using System;

// Token: 0x02000BD6 RID: 3030
public sealed class ab0 : jn
{
	// Token: 0x06004551 RID: 17745 RVA: 0x001C2DB0 File Offset: 0x001C0FB0
	public ab0() : base("sgs_vencel", "creature\\characters\\sgs_vencel")
	{
	}

	// Token: 0x06004552 RID: 17746 RVA: 0x001C2DC4 File Offset: 0x001C0FC4
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("loc_sgs_doneTutorial", new bool?(false)).Value)
		{
			return "StationAlpha-Level3";
		}
		return "StationAlpha-Level2";
	}

	// Token: 0x06004553 RID: 17747 RVA: 0x001C2E00 File Offset: 0x001C1000
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		if (A_2.Equals("StationAlpha-Level3", StringComparison.OrdinalIgnoreCase))
		{
			bn5 bn = A_0.GetAspect<j7>() as bn5;
			if (bn != null)
			{
				bn.b(true);
			}
		}
	}
}
