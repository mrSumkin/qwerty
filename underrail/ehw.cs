using System;

// Token: 0x02000BE7 RID: 3047
public sealed class ehw : jn
{
	// Token: 0x06004587 RID: 17799 RVA: 0x001C42C0 File Offset: 0x001C24C0
	public ehw() : base("pr_bioagent3", "creature\\characters\\pr_bioagent3")
	{
	}

	// Token: 0x06004588 RID: 17800 RVA: 0x001C42D4 File Offset: 0x001C24D4
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_pr_gasFreeDronesComplete", new bool?(false)).Value)
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_prmutation_started", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quest_prmutation_mutagenPlaced", new bool?(false)).Value)
		{
			return "lup-a6";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("loc_pb_chemicalSetup", new bool?(false)).Value)
		{
			return "pb-amb";
		}
		return null;
	}

	// Token: 0x06004589 RID: 17801 RVA: 0x001C437C File Offset: 0x001C257C
	public override string ce(cyt A_0, string A_1)
	{
		if (string.Equals(A_1, "lup-a6", StringComparison.OrdinalIgnoreCase))
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("quest_prmutation_openedLock", new bool?(false)).Value)
			{
				return "ready";
			}
		}
		else if (string.Equals(A_1, "pb-amb", StringComparison.OrdinalIgnoreCase))
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("loc_pb_bioHazardArrived", new bool?(false)).Value)
			{
				return "office";
			}
			return "outsideMap";
		}
		return null;
	}

	// Token: 0x0600458A RID: 17802 RVA: 0x001C4404 File Offset: 0x001C2604
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		if (string.Equals(A_2, "lup-a6", StringComparison.OrdinalIgnoreCase))
		{
			if (A_1.r().GetPrimitivePropertyValue<bool>("quest_prmutation_openedLock", new bool?(false)).Value)
			{
				base.a(A_0, "global:pr_bioagent3:ready");
				return;
			}
		}
		else if (string.Equals(A_2, "pb-amb", StringComparison.OrdinalIgnoreCase))
		{
			if (A_1.r().GetPrimitivePropertyValue<bool>("loc_pb_bioHazardArrived", new bool?(false)).Value)
			{
				base.a(A_0, "global:pr_bioagent3:office");
				return;
			}
			base.a(A_0, "global:pr_bioagent3:outsideMap");
			return;
		}
		base.a(A_0, "global:pr_bioagent3");
	}
}
