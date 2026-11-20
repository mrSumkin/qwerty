using System;

// Token: 0x02000C4D RID: 3149
public sealed class en2 : jn
{
	// Token: 0x060046D7 RID: 18135 RVA: 0x001D3D0C File Offset: 0x001D1F0C
	public override string cc()
	{
		return "xpbl";
	}

	// Token: 0x060046D8 RID: 18136 RVA: 0x001D3D14 File Offset: 0x001D1F14
	public en2() : base("xpbl_pirateRaider3", "creature\\characters\\support\\xpbl\\pir_pirateRaider3")
	{
	}

	// Token: 0x060046D9 RID: 18137 RVA: 0x001D3D2C File Offset: 0x001D1F2C
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

	// Token: 0x060046DA RID: 18138 RVA: 0x001D3E1C File Offset: 0x001D201C
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

	// Token: 0x060046DB RID: 18139 RVA: 0x001D3E6C File Offset: 0x001D206C
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
						aspect.y6()[ddq.ay] = new bt4("global:xpbl_pirateRaider3:dock");
					}
					else
					{
						aspect.y6()[ddq.ay] = new bt4("global:xpbl_pirateRaider3:boat");
					}
				}
				else if (string.Equals(A_2, "xpbl_rig2", StringComparison.OrdinalIgnoreCase))
				{
					aspect.y6()[ddq.ay] = new bt4("pirateRaider3_sonar");
				}
				else
				{
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_pirateRaider3");
				}
				aspect.y6().RemoveProperty(ddq.bg);
			}
		}
	}
}
