using System;

// Token: 0x02000C16 RID: 3094
public sealed class clz : jn
{
	// Token: 0x0600462A RID: 17962 RVA: 0x001CC14C File Offset: 0x001CA34C
	public override string cc()
	{
		return "xpbl";
	}

	// Token: 0x0600462B RID: 17963 RVA: 0x001CC154 File Offset: 0x001CA354
	public clz() : base("xpbl_oldfield", "creature\\characters\\xpbl\\Oldfield")
	{
	}

	// Token: 0x0600462C RID: 17964 RVA: 0x001CC168 File Offset: 0x001CA368
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_oldfield_dead", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionUndeployed", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_oldfield_ranAWayInCoreCity", new bool?(false)).Value)
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_oldfield_returnedToCoreCityAfterDestruction", new bool?(false)).Value)
		{
			if (A_0.r().GetClassPropertyValue<string>("global_xpbl_acorn_gaveTo") == null && !A_0.r().GetPrimitivePropertyValue<bool>("loc_cc_facelessRetreated", new bool?(false)).Value)
			{
				return "cc10";
			}
			return null;
		}
		else
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_oldfield_bringToCoreCityAfterDestruction", new bool?(false)).Value)
			{
				return "xpbl_cc-dock2";
			}
			if (!A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorKidnapped", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorSaved", new bool?(false)).Value)
			{
				cky cky = (A_0.ac() as bv9).abu(asp.a, asp.f5);
				if (A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_le_philsImplantAcquired", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorSaved", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("global_beginExpedition", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_sc_foundDispatcherCoordinates", new bool?(false)).Value)
				{
					if (A_0.r().GetPrimitivePropertyValue<bool>("loc_le_openedFort", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorKidnapped_releasedByGrim", new bool?(false)).Value)
					{
						return "xpbl_fu";
					}
					if (!A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_pirates_joined", new bool?(false)).Value && cky.a != h.a)
					{
						return "xpbl_e6";
					}
				}
				return "xpbl_d6";
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_oldfield_passedThrasher", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_saveTheProfessor_completed", new bool?(false)).Value)
			{
				return "xpbl_e4";
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_oldfield_shouldFollowDownManhole", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_oldfield_passedThrasher", new bool?(false)).Value)
			{
				return "xpbl_e3_u";
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_oldfield_broughtToG3", new bool?(false)).Value)
			{
				return "xpbl_g3";
			}
			return "xpbl_e3";
		}
	}

	// Token: 0x0600462D RID: 17965 RVA: 0x001CC4A8 File Offset: 0x001CA6A8
	public override string ce(cyt A_0, string A_1)
	{
		if (string.Equals(A_1, "xpbl_e4", StringComparison.OrdinalIgnoreCase))
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_oldfield_e4_climbUp", new bool?(false)).Value)
			{
				return "up";
			}
			return "down";
		}
		else if (string.Equals(A_1, "xpbl_e3", StringComparison.OrdinalIgnoreCase))
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_e3_interrogatingProfessor", new bool?(false)).Value)
			{
				return "chair";
			}
			return "cell";
		}
		else if (string.Equals(A_1, "xpbl_d6", StringComparison.OrdinalIgnoreCase))
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_underAttack", new bool?(false)).Value && (!A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorKidnapped", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_saveTheProfessor_completed", new bool?(false)).Value))
			{
				return "mrchTent";
			}
			return "oldTent";
		}
		else
		{
			if (!string.Equals(A_1, "xpbl_fu", StringComparison.OrdinalIgnoreCase))
			{
				return null;
			}
			if (!A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_fu_descended", new bool?(false)).Value)
			{
				return "up";
			}
			return "research";
		}
	}

	// Token: 0x0600462E RID: 17966 RVA: 0x001CC5FC File Offset: 0x001CA7FC
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		amc aspect = A_0.GetAspect<amc>();
		if (aspect != null)
		{
			if (A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorKidnapped", new bool?(false)).Value)
			{
				if (!A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_oldfield_piratesTookItems", new bool?(false)).Value)
				{
					aspect.aa().Bag.z2().Clear();
					A_1.r()["npc_xpbl_oldfield_piratesTookItems"] = true;
				}
				if (!A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorSaved", new bool?(false)).Value)
				{
					aspect.aa().FactionId = asp.f8;
					aspect.aa().HostilityBroadcastMode = c2n.c;
				}
				else if (string.Equals(A_2, "xpbl_cc-dock2", StringComparison.OrdinalIgnoreCase) || string.Equals(A_2, "cc10", StringComparison.OrdinalIgnoreCase))
				{
					aspect.aa().FactionId = asp.di;
					aspect.aa().HostilityBroadcastMode = c2n.d;
				}
				else
				{
					aspect.aa().FactionId = asp.f6;
					aspect.aa().HostilityBroadcastMode = c2n.d;
				}
			}
			else
			{
				aspect.aa().FactionId = asp.f6;
				aspect.aa().HostilityBroadcastMode = c2n.d;
			}
		}
		bm6 aspect2 = A_0.GetAspect<bm6>();
		if (aspect2 != null)
		{
			if (string.Equals(A_2, "xpbl_cc-dock2", StringComparison.OrdinalIgnoreCase))
			{
				if (A_1.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionDestroyed", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_oldfield_returnedToCoreCityAfterDestruction", new bool?(false)).Value)
				{
					aspect2.y6()[ddq.bc] = "npc_xpbl_oldfield_returnedToCoreCityAfterDestruction";
				}
			}
			else if (string.Equals(A_2, "xpbl_e3_u", StringComparison.OrdinalIgnoreCase))
			{
				A_1.r()["npc_xpbl_oldfield_passedThrasher"] = true;
			}
			if (string.Equals(A_2, "xpbl_e4", StringComparison.OrdinalIgnoreCase))
			{
				if (A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_oldfield_e4_climbUp", new bool?(false)).Value)
				{
					aspect2.y6()[ddq.ay] = new bt4("global:xpbl_oldfield:up");
				}
				else
				{
					aspect2.y6()[ddq.ay] = new bt4("global:xpbl_oldfield:down");
				}
			}
			else if (string.Equals(A_2, "xpbl_d6", StringComparison.OrdinalIgnoreCase))
			{
				if (A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_e5_allInvadersKilled", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("quest_xpbl_savageInvasion_completed", new bool?(false)).Value)
				{
					aspect2.y6()[ddq.bc] = "quest_xpbl_savageInvasion_completed";
				}
				if (A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_underAttack", new bool?(false)).Value)
				{
					aspect2.y6()[ddq.ay] = new bt4("global:xpbl_oldfield:mrchTent");
				}
				else
				{
					aspect2.y6()[ddq.ay] = new bt4("global:xpbl_oldfield:oldTent");
				}
				if (A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorKidnapped", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_saveTheProfessor_completed", new bool?(false)).Value)
				{
					aspect2.y6()[ddq.bc] = "quests_xpbl_expedition_saveTheProfessor_completed";
				}
				A_1.r()["npc_xpbl_le_oldfield_inTent"] = true;
			}
			else if (string.Equals(A_2, "xpbl_fu", StringComparison.OrdinalIgnoreCase))
			{
				aspect2.y6()[ddq.ay] = new bt4("global:xpbl_oldfield:research");
				A_1.r()["npc_xpbl_le_oldfield_inTent"] = false;
			}
			else if (string.Equals(A_2, "xpbl_e3_u", StringComparison.OrdinalIgnoreCase) || (string.Equals(A_2, "xpbl_e4", StringComparison.OrdinalIgnoreCase) && !A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_oldfield_e4_climbUp", new bool?(false)).Value))
			{
				aspect2.y6()[ddq.bz] = "player";
				aspect2.y6()[ddq.b0] = 3;
				aspect2.y6().RemoveProperty(ddq.ay);
			}
			else
			{
				aspect2.y6().RemoveProperty(ddq.bz);
				aspect2.y6()[ddq.ay] = new bt4("global:xpbl_oldfield");
			}
		}
		string a_ = "characters\\xpbl\\le_oldfield";
		if (A_1.r().GetPrimitivePropertyValue<bool>("global_xpbl_le_philsImplantAcquired", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("loc_le_openedFort", new bool?(false)).Value)
		{
			a_ = "events\\xpbl\\le_openingFort";
		}
		bn5 bn = A_0.GetAspect<j7>() as bn5;
		if (bn == null)
		{
			bn = new bn5(A_0 as c5x);
			A_0.SetAspect<j7>(bn);
		}
		bn.b(a_);
		if ((string.Equals(A_2, "xpbl_e4", StringComparison.OrdinalIgnoreCase) || string.Equals(A_2, "xpbl_g3", StringComparison.OrdinalIgnoreCase)) && A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_underAttack", new bool?(false)).Value)
		{
			new bzs().ym(null, null, null);
		}
	}
}
