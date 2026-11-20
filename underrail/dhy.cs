using System;

// Token: 0x02000C4E RID: 3150
public sealed class dhy : jn
{
	// Token: 0x060046DC RID: 18140 RVA: 0x001D3F74 File Offset: 0x001D2174
	public override string cc()
	{
		return "xpbl";
	}

	// Token: 0x060046DD RID: 18141 RVA: 0x001D3F7C File Offset: 0x001D217C
	public dhy() : base("xpbl_pirateRaider2", "creature\\characters\\support\\xpbl\\pir_pirateRaider2")
	{
	}

	// Token: 0x060046DE RID: 18142 RVA: 0x001D3F90 File Offset: 0x001D2190
	public override string b1(cyt A_0)
	{
		if (!A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_started", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_goAlone", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_partyLeavesRig", new bool?(false)).Value)
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_attackSecondZone", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_sonarDestroyed", new bool?(false)).Value)
		{
			return "xpbl_rig2";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_partyDocksAtRig", new bool?(false)).Value)
		{
			return "xpbl_rig1";
		}
		return null;
	}

	// Token: 0x060046DF RID: 18143 RVA: 0x001D4080 File Offset: 0x001D2280
	public override string ce(cyt A_0, string A_1)
	{
		if (!string.Equals(A_1, "xpbl_rig1", StringComparison.OrdinalIgnoreCase))
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_attackStarted", new bool?(false)).Value)
		{
			return "dock";
		}
		return "boat";
	}

	// Token: 0x060046E0 RID: 18144 RVA: 0x001D40D0 File Offset: 0x001D22D0
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		if (A_0 != null)
		{
			((c5x)A_0).b(bp5.k + "xpbl_rig_ps");
			bm6 aspect = A_0.GetAspect<bm6>();
			if (aspect != null)
			{
				if (string.Equals(A_2, "xpbl_rig1", StringComparison.OrdinalIgnoreCase))
				{
					if (A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_attackStarted", new bool?(false)).Value)
					{
						aspect.y6()[ddq.ay] = new bt4("global:xpbl_pirateRaider2:dock");
					}
					else
					{
						aspect.y6()[ddq.ay] = new bt4("global:xpbl_pirateRaider2:boat");
					}
				}
				else if (string.Equals(A_2, "xpbl_rig2", StringComparison.OrdinalIgnoreCase))
				{
					aspect.y6()[ddq.ay] = new bt4("pirateRaider2_sonar");
				}
				else
				{
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_pirateRaider2");
				}
				aspect.y6().RemoveProperty(ddq.bg);
			}
		}
	}
}
