using System;
using System.Linq;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000C12 RID: 3090
public sealed class blu : jn
{
	// Token: 0x06004618 RID: 17944 RVA: 0x001CB1A0 File Offset: 0x001C93A0
	public override string cc()
	{
		return "xpbl";
	}

	// Token: 0x06004619 RID: 17945 RVA: 0x001CB1A8 File Offset: 0x001C93A8
	public blu() : base("xpbl_cruzer", "creature\\characters\\xpbl\\Cruzer")
	{
	}

	// Token: 0x0600461A RID: 17946 RVA: 0x001CB1BC File Offset: 0x001C93BC
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_cruzer_dead", new bool?(false)).Value)
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_started", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_completed", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_goAlone", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_partyLeavesRig", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_tookOutSonarEarly", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_sonarDestroyedBeforePartyDocked", new bool?(false)).Value)
		{
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
		else
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_fu_pirateAttackFailed", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_pirates_joined", new bool?(false)).Value)
			{
				return "xpbl_fu";
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_guardedAudience", new bool?(false)).Value)
			{
				return "xpbl_g2_InnerShip";
			}
			if (A_0.r().GetPrimitivePropertyValue<int>("loc_cvw_dragAndDrop_eventType", new int?(0)).Value == 5 && !string.Equals(A_0.c().b(), "xpbl_g2", StringComparison.OrdinalIgnoreCase))
			{
				return "Xpbl_ww_DragNDrop";
			}
			return "xpbl_g2";
		}
	}

	// Token: 0x0600461B RID: 17947 RVA: 0x001CB3F8 File Offset: 0x001C95F8
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

	// Token: 0x0600461C RID: 17948 RVA: 0x001CB448 File Offset: 0x001C9648
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		((c5x)A_0).b(bp5.k + "xpbl_rig_ps");
		bm6 aspect = A_0.GetAspect<bm6>();
		if (aspect != null)
		{
			if (string.Equals(A_2, "xpbl_rig1", StringComparison.OrdinalIgnoreCase))
			{
				if (A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_attackStarted", new bool?(false)).Value)
				{
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_cruzer:dock");
				}
				else
				{
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_cruzer:boat");
				}
			}
			else if (string.Equals(A_2, "xpbl_rig2", StringComparison.OrdinalIgnoreCase))
			{
				aspect.y6()[ddq.ay] = new bt4("cruzer_sonar");
			}
			else
			{
				aspect.y6()[ddq.ay] = new bt4("global:xpbl_cruzer");
			}
			aspect.y6().RemoveProperty(ddq.bg);
			if (string.Equals(A_2, "Xpbl_ww_DragNDrop", StringComparison.OrdinalIgnoreCase))
			{
				aspect.y6()[ddq.b2] = true;
				aspect.y6()[ddq.b5] = 0;
				aspect.y6()[ddq.b3] = "food.mushroomBrew";
				aspect.y6()[ddq.b4] = 500;
			}
			else
			{
				aspect.y6().RemoveProperty(ddq.b2);
				aspect.y6().RemoveProperty(ddq.b5);
				aspect.y6().RemoveProperty(ddq.b3);
				aspect.y6().RemoveProperty(ddq.b4);
			}
		}
		amc aspect2 = A_0.GetAspect<amc>();
		if (aspect2 != null)
		{
			if (string.Equals(A_2, "xpbl_rig1", StringComparison.OrdinalIgnoreCase) || string.Equals(A_2, "xpbl_rig2", StringComparison.OrdinalIgnoreCase))
			{
				aspect2.aa().AttributesBase &= ~d8o.o;
				aspect2.aa().FactionId = asp.fw;
				aspect2.aa().Offense.a(WeaponKey.Primary);
				aspect2.aa().Skills.Get<jk>().a(140);
				return;
			}
			aspect2.aa().AttributesBase |= d8o.o;
			if (string.Equals(A_2, "Xpbl_ww_DragNDrop", StringComparison.OrdinalIgnoreCase))
			{
				aspect2.aa().FactionId = asp.fk;
				aspect2.aa().Offense.a(WeaponKey.Secondary);
				aspect2.aa().Skills.Get<jk>().a(150);
				if (!Enumerable.Any<coh>(aspect2.aa().Bag.b("food.mushroomBrew")))
				{
					aspect2.aa().Bag.z3(new d48(ez2.CreateDefinitonProvider<cv9>("Consumables\\Food\\MushroomBrew")), true);
				}
				aspect2.aa().Defense.a(5000, null, null, false, false, false, null);
				return;
			}
			aspect2.aa().FactionId = asp.fr;
			if (string.Equals(A_2, "xpbl_g2_InnerShip", StringComparison.OrdinalIgnoreCase))
			{
				aspect2.aa().Offense.a(WeaponKey.Secondary);
				aspect2.aa().Skills.Get<jk>().a(150);
				return;
			}
			aspect2.aa().Offense.a(WeaponKey.Primary);
			aspect2.aa().Skills.Get<jk>().a(140);
		}
	}
}
