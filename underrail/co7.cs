using System;
using System.Linq;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000C0F RID: 3087
public sealed class co7 : jn
{
	// Token: 0x0600460A RID: 17930 RVA: 0x001CA594 File Offset: 0x001C8794
	public override string cc()
	{
		return "xpbl";
	}

	// Token: 0x0600460B RID: 17931 RVA: 0x001CA59C File Offset: 0x001C879C
	public co7() : base("xpbl_savage", "creature\\characters\\xpbl\\DocSavage")
	{
	}

	// Token: 0x0600460C RID: 17932 RVA: 0x001CA5B0 File Offset: 0x001C87B0
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_le_doc_dead", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionUndeployed", new bool?(false)).Value)
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_underAttack", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_aegis_importantNpcsCanJoinBattle", new bool?(false)).Value && (string.Equals(A_0.c().b(), "xpbl_e5", StringComparison.OrdinalIgnoreCase) || A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_savage_summonedToBattle", new bool?(false)).Value))
		{
			return "xpbl_e5";
		}
		return "xpbl_d6";
	}

	// Token: 0x0600460D RID: 17933 RVA: 0x001CA694 File Offset: 0x001C8894
	public override string ce(cyt A_0, string A_1)
	{
		if (string.Equals(A_1, "xpbl_e5", StringComparison.OrdinalIgnoreCase))
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_savage_summonedToBattle", new bool?(false)).Value)
			{
				return "fight";
			}
			return "limbo";
		}
		else
		{
			if (!string.Equals(A_1, "xpbl_d6", StringComparison.OrdinalIgnoreCase))
			{
				return null;
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_e5_allInvadersKilled", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quest_xpbl_savageInvasion_completed", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_md_foundPhilsBody", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_le_woundedSecTropper", new bool?(false)).Value)
			{
				return "defib";
			}
			return "main";
		}
	}

	// Token: 0x0600460E RID: 17934 RVA: 0x001CA78C File Offset: 0x001C898C
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		amc aspect2 = A_0.GetAspect<amc>();
		bn5 bn = A_0.GetAspect<j7>() as bn5;
		if (bn == null)
		{
			bn = new bn5(A_0 as c5x);
			A_0.SetAspect<j7>(bn);
			bn.b("Characters\\xpbl\\le_doc");
		}
		if (aspect != null && aspect2 != null)
		{
			if (string.Equals(A_2, "xpbl_d6", StringComparison.OrdinalIgnoreCase))
			{
				if (A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_e5_allInvadersKilled", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("quest_xpbl_savageInvasion_completed", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_md_foundPhilsBody", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_le_woundedSecTropper_died", new bool?(false)).Value)
				{
					aspect.b("le_docDefibrillation");
					aspect.y6()[ddq.w] = CharacterState.Custom1;
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_savage:defib");
					A_1.r()["npc_le_docSavage_defibrilating"] = true;
					bn.a(false);
				}
				else
				{
					aspect.b("humanSoldier");
					aspect.y6().RemoveProperty(ddq.w);
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_savage:main");
					aspect2.ap = null;
					aspect2.aq = null;
					A_1.r()["npc_le_docSavage_defibrilating"] = false;
					bn.a(true);
				}
				if (aspect2 != null)
				{
					aspect2.aa().Offense.a(WeaponKey.Primary);
				}
			}
			else if (string.Equals(A_2, "xpbl_e5", StringComparison.OrdinalIgnoreCase))
			{
				if (A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_savage_summonedToBattle", new bool?(false)).Value)
				{
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_savage:fight");
				}
				else
				{
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_savage:limbo");
				}
				aspect.b("humanSoldier");
				aspect.y6().RemoveProperty(ddq.w);
				aspect.y6()[ddq.ay] = new bt4("global:xpbl_savage:main");
				aspect2.ap = null;
				aspect2.aq = null;
				A_1.r()["npc_le_docSavage_defibrilating"] = false;
				bn.a(true);
				if (aspect2 != null)
				{
					aspect2.aa().Offense.a(WeaponKey.Secondary);
				}
			}
			if (aspect2.aa().StatusEffects.a(eys.a))
			{
				eys a_ = Enumerable.FirstOrDefault<eys>(aspect2.aa().StatusEffects.Get<eys>());
				aspect2.aa().StatusEffects.d(a_);
			}
			if (A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_le_doc_gaveCigar", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_le_doc_nervous", new bool?(false)).Value && A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_sc_foundDispatcherCoordinates", new bool?(false)).Value)
			{
				A_1.r()["npc_xpbl_le_doc_nervous"] = true;
			}
			if (aspect2.aa().a("lighter", false) == null)
			{
				aspect2.aa().Bag.z3(new d48(ez2.CreateDefinitonProvider<ebz>("Devices\\Lighter"))
				{
					Stealable = false
				}, true);
			}
		}
	}
}
