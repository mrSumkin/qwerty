using System;

// Token: 0x02000C4F RID: 3151
public sealed class dhz : jn
{
	// Token: 0x060046E1 RID: 18145 RVA: 0x001D41D8 File Offset: 0x001D23D8
	public override string cc()
	{
		return "xpbl";
	}

	// Token: 0x060046E2 RID: 18146 RVA: 0x001D41E0 File Offset: 0x001D23E0
	public dhz() : base("xpbl_pirateRaider1", "creature\\characters\\support\\xpbl\\pir_pirateRaider1")
	{
	}

	// Token: 0x060046E3 RID: 18147 RVA: 0x001D41F4 File Offset: 0x001D23F4
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

	// Token: 0x060046E4 RID: 18148 RVA: 0x001D42E4 File Offset: 0x001D24E4
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

	// Token: 0x060046E5 RID: 18149 RVA: 0x001D4334 File Offset: 0x001D2534
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
						aspect.y6()[ddq.ay] = new bt4("global:xpbl_pirateRaider1:dock");
					}
					else
					{
						aspect.y6()[ddq.ay] = new bt4("global:xpbl_pirateRaider1:boat");
					}
				}
				else if (string.Equals(A_2, "xpbl_rig2", StringComparison.OrdinalIgnoreCase))
				{
					aspect.y6()[ddq.ay] = new bt4("pirateRaider1_sonar");
				}
				else
				{
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_pirateRaider1");
				}
				aspect.y6().RemoveProperty(ddq.bg);
			}
		}
	}
}
