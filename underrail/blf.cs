using System;

// Token: 0x02000C17 RID: 3095
public sealed class blf : jn
{
	// Token: 0x0600462F RID: 17967 RVA: 0x001CCB6C File Offset: 0x001CAD6C
	public override string cc()
	{
		return "xpbl";
	}

	// Token: 0x06004630 RID: 17968 RVA: 0x001CCB74 File Offset: 0x001CAD74
	public blf() : base("xpbl_marcus", "creature\\characters\\xpbl\\Marcus")
	{
	}

	// Token: 0x06004631 RID: 17969 RVA: 0x001CCB8C File Offset: 0x001CAD8C
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_marcus_dead", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionUndeployed", new bool?(false)).Value)
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_underAttack", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_aegis_importantNpcsCanJoinBattle", new bool?(false)).Value && (string.Equals(A_0.c().b(), "xpbl_e5", StringComparison.OrdinalIgnoreCase) || A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_marcus_summonedToBattle", new bool?(false)).Value))
		{
			return "xpbl_e5";
		}
		if (!A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_briggs_arrivedAtDock", new bool?(false)).Value)
		{
			return "xpbl_d5";
		}
		return "xpbl_d6";
	}

	// Token: 0x06004632 RID: 17970 RVA: 0x001CCC9C File Offset: 0x001CAE9C
	public override string ce(cyt A_0, string A_1)
	{
		if (!string.Equals(A_1, "xpbl_e5", StringComparison.OrdinalIgnoreCase))
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_marcus_summonedToBattle", new bool?(false)).Value)
		{
			return "fight";
		}
		return "limbo";
	}

	// Token: 0x06004633 RID: 17971 RVA: 0x001CCCEC File Offset: 0x001CAEEC
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		if (aspect != null)
		{
			if (string.Equals(A_2, "xpbl_e5", StringComparison.OrdinalIgnoreCase))
			{
				if (A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_marcus_summonedToBattle", new bool?(false)).Value)
				{
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_marcus:fight");
				}
				else
				{
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_marcus:limbo");
				}
			}
			else
			{
				aspect.y6()[ddq.ay] = new bt4("global:xpbl_marcus");
			}
		}
		amc aspect2 = A_0.GetAspect<amc>();
		if (aspect2 != null && string.Equals(A_2, "xpbl_e5", StringComparison.OrdinalIgnoreCase) && (aspect2.aa().a("Battery.FusionCell", false) == null || aspect2.aa().a("Battery.FusionCell", false).Stacks <= 5))
		{
			d48 d = new d48(ez2.CreateDefinitonProvider<sz>("expendables\\energySources\\FusionCell"))
			{
				Stacks = 5
			};
			if (d != null)
			{
				aspect2.aa().Bag.z3(d, true);
			}
		}
	}
}
