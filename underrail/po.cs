using System;

// Token: 0x02000C14 RID: 3092
public sealed class po : jn
{
	// Token: 0x06004621 RID: 17953 RVA: 0x001CB880 File Offset: 0x001C9A80
	public override string cc()
	{
		return "xpbl";
	}

	// Token: 0x06004622 RID: 17954 RVA: 0x001CB888 File Offset: 0x001C9A88
	public po() : base("xpbl_yahota", "creature\\characters\\xpbl\\Yahota")
	{
	}

	// Token: 0x06004623 RID: 17955 RVA: 0x001CB89C File Offset: 0x001C9A9C
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_yahota_dead", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionUndeployed", new bool?(false)).Value)
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorKidnapped", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorSaved", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_leavingDueToProfessorsDeath", new bool?(false)).Value)
		{
			return null;
		}
		if (!A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_underAttack", new bool?(false)).Value)
		{
			return "xpbl_d6";
		}
		if (!A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_yahota_passedFort", new bool?(false)).Value)
		{
			return "xpbl_e6";
		}
		return "xpbl_e5";
	}

	// Token: 0x06004624 RID: 17956 RVA: 0x001CB9B4 File Offset: 0x001C9BB4
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		if (aspect != null)
		{
			if (string.Equals(A_2, "xpbl_e5", StringComparison.OrdinalIgnoreCase))
			{
				if (!A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_yahota_broughtToBeach", new bool?(false)).Value)
				{
					A_1.r()["npc_xpbl_yahota_passedFort"] = true;
					A_1.r()["npc_xpbl_yahota_broughtToBeach"] = true;
					aspect.y6().RemoveProperty(ddq.bg);
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_yahota");
				}
			}
			else if (string.Equals(A_2, "xpbl_e6", StringComparison.OrdinalIgnoreCase))
			{
				if (!A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_yahota_passedFort", new bool?(false)).Value)
				{
					A_1.r()["npc_xpbl_yahota_passedFort"] = true;
					aspect.y6().RemoveProperty(ddq.bg);
					aspect.y6()[ddq.ay] = new bt4("yahota_toBeach");
				}
			}
			else
			{
				aspect.y6().RemoveProperty(ddq.bg);
				aspect.y6()[ddq.ay] = new bt4("global:xpbl_yahota");
			}
		}
		amc aspect2 = A_0.GetAspect<amc>();
		if (aspect2 != null && string.Equals(A_2, "xpbl_e5", StringComparison.OrdinalIgnoreCase))
		{
			coh a_ = new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Caliber_762_Std"))
			{
				Stacks = 30
			};
			coh coh = aspect2.aa().a("Ammo.Caliber_762_Std", false);
			if (coh == null || (coh != null && coh.Stacks < 20))
			{
				aspect2.aa().Bag.z3(a_, true);
			}
		}
	}
}
