using System;

// Token: 0x02000BE9 RID: 3049
public sealed class au7 : jn
{
	// Token: 0x0600458F RID: 17807 RVA: 0x001C4698 File Offset: 0x001C2898
	public au7() : base("pr_bioagent1", "creature\\characters\\pr_bioagent1")
	{
	}

	// Token: 0x06004590 RID: 17808 RVA: 0x001C46AC File Offset: 0x001C28AC
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_pr_gasFreeDronesComplete", new bool?(false)).Value)
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_prmutation_started", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quest_prmutation_mutagenPlaced", new bool?(false)).Value)
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("quest_prmutation_openedLock", new bool?(false)).Value)
			{
				return "lup_freeDroneBase";
			}
			return "lup-a6";
		}
		else
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("loc_pb_chemicalSetup", new bool?(false)).Value)
			{
				return "pb-amb";
			}
			return null;
		}
	}

	// Token: 0x06004591 RID: 17809 RVA: 0x001C4780 File Offset: 0x001C2980
	public override string ce(cyt A_0, string A_1)
	{
		if (string.Equals(A_1, "lup_freeDroneBase", StringComparison.OrdinalIgnoreCase))
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("quest_prmutation_toldYouToPlaceIt", new bool?(false)).Value)
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

	// Token: 0x06004592 RID: 17810 RVA: 0x001C4808 File Offset: 0x001C2A08
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		if (A_0 != null)
		{
			bm6 aspect = A_0.GetAspect<bm6>();
			if (aspect != null)
			{
				aspect.y6().RemoveProperty(ddq.bg);
				if (string.Equals(A_2, "lup_freeDroneBase", StringComparison.OrdinalIgnoreCase))
				{
					aspect.y6()[ddq.bs] = new exw(d6n.a, 0.0, false, null);
				}
				else
				{
					aspect.y6().RemoveProperty(ddq.bs);
				}
			}
		}
		if (string.Equals(A_2, "lup-a6", StringComparison.OrdinalIgnoreCase))
		{
			if (A_1.r().GetPrimitivePropertyValue<bool>("quest_prmutation_openedLock", new bool?(false)).Value)
			{
				base.a(A_0, "IntoVents");
				return;
			}
		}
		else
		{
			if (string.Equals(A_2, "lup_freeDroneBase", StringComparison.OrdinalIgnoreCase))
			{
				base.a(A_0, "global:pr_bioagent1:ready");
				return;
			}
			if (string.Equals(A_2, "pb-amb", StringComparison.OrdinalIgnoreCase))
			{
				if (A_1.r().GetPrimitivePropertyValue<bool>("loc_pb_bioHazardArrived", new bool?(false)).Value)
				{
					base.a(A_0, "global:pr_bioagent1:office");
					return;
				}
				base.a(A_0, "global:pr_bioagent1:outsideMap");
				return;
			}
		}
		base.a(A_0, "global:pr_bioagent1");
	}
}
