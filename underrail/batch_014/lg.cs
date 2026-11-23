using System;

// Token: 0x02000BE8 RID: 3048
public sealed class lg : jn
{
	// Token: 0x0600458B RID: 17803 RVA: 0x001C44AC File Offset: 0x001C26AC
	public lg() : base("pr_bioagent2", "creature\\characters\\pr_bioagent2")
	{
	}

	// Token: 0x0600458C RID: 17804 RVA: 0x001C44C0 File Offset: 0x001C26C0
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

	// Token: 0x0600458D RID: 17805 RVA: 0x001C4568 File Offset: 0x001C2768
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

	// Token: 0x0600458E RID: 17806 RVA: 0x001C45F0 File Offset: 0x001C27F0
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		if (string.Equals(A_2, "lup-a6", StringComparison.OrdinalIgnoreCase))
		{
			if (A_1.r().GetPrimitivePropertyValue<bool>("quest_prmutation_openedLock", new bool?(false)).Value)
			{
				base.a(A_0, "global:pr_bioagent2:ready");
				return;
			}
		}
		else if (string.Equals(A_2, "pb-amb", StringComparison.OrdinalIgnoreCase))
		{
			if (A_1.r().GetPrimitivePropertyValue<bool>("loc_pb_bioHazardArrived", new bool?(false)).Value)
			{
				base.a(A_0, "global:pr_bioagent2:office");
				return;
			}
			base.a(A_0, "global:pr_bioagent2:outsideMap");
			return;
		}
		base.a(A_0, "global:pr_bioagent2");
	}
}
