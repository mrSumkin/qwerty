using System;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000C18 RID: 3096
public sealed class e8j : jn
{
	// Token: 0x06004634 RID: 17972 RVA: 0x001CCE14 File Offset: 0x001CB014
	public override string cc()
	{
		return "xpbl";
	}

	// Token: 0x06004635 RID: 17973 RVA: 0x001CCE1C File Offset: 0x001CB01C
	public e8j() : base("xpbl_ladelman", "creature\\characters\\xpbl\\Ladelman")
	{
	}

	// Token: 0x06004636 RID: 17974 RVA: 0x001CCE30 File Offset: 0x001CB030
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_ladelman_dead", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionUndeployed", new bool?(false)).Value)
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_underAttack", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_aegis_importantNpcsCanJoinBattle", new bool?(false)).Value && (string.Equals(A_0.c().b(), "xpbl_e5", StringComparison.OrdinalIgnoreCase) || A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_ladelman_summonedToBattle", new bool?(false)).Value))
		{
			return "xpbl_e5";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_briggs_arrivedAtDock", new bool?(false)).Value)
		{
			return "xpbl_d6";
		}
		if (!A_0.r().GetPrimitivePropertyValue<bool>("global_beginExpedition", new bool?(false)).Value)
		{
			return "xpbl_cc-dock2";
		}
		return "xpbl_d5";
	}

	// Token: 0x06004637 RID: 17975 RVA: 0x001CCF68 File Offset: 0x001CB168
	public override string ce(cyt A_0, string A_1)
	{
		if (!string.Equals(A_1, "xpbl_e5", StringComparison.OrdinalIgnoreCase))
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_ladelman_summonedToBattle", new bool?(false)).Value)
		{
			return "fight";
		}
		return "limbo";
	}

	// Token: 0x06004638 RID: 17976 RVA: 0x001CCFB8 File Offset: 0x001CB1B8
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		amc aspect2 = A_0.GetAspect<amc>();
		if (aspect != null)
		{
			if (string.Equals(A_2, "xpbl_e5", StringComparison.OrdinalIgnoreCase))
			{
				if (A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_ladelman_summonedToBattle", new bool?(false)).Value)
				{
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_ladelman:fight");
				}
				else
				{
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_ladelman:limbo");
				}
				if (aspect2 != null)
				{
					aspect2.aa().Offense.a(WeaponKey.Secondary);
					return;
				}
			}
			else
			{
				aspect.y6()[ddq.ay] = new bt4("global:xpbl_ladelman");
				if (aspect2 != null)
				{
					aspect2.aa().Offense.a(WeaponKey.Primary);
				}
			}
		}
	}
}
