using System;

// Token: 0x02000C19 RID: 3097
public sealed class ap4 : jn
{
	// Token: 0x06004639 RID: 17977 RVA: 0x001CD090 File Offset: 0x001CB290
	public override string cc()
	{
		return "xpbl";
	}

	// Token: 0x0600463A RID: 17978 RVA: 0x001CD098 File Offset: 0x001CB298
	public ap4() : base("xpbl_briggs", "creature\\characters\\xpbl\\Briggs")
	{
	}

	// Token: 0x0600463B RID: 17979 RVA: 0x001CD0AC File Offset: 0x001CB2AC
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_briggs_dead", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionUndeployed", new bool?(false)).Value)
		{
			return null;
		}
		if (!A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_saveTheProfessor_completed", new bool?(false)).Value && (A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorSaved", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_saveTheProfessor_returnToCampWithoutProfessor", new bool?(false)).Value))
		{
			return "xpbl_d6";
		}
		if ((A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorKidnapped", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorSaved", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_saveTheProfessor_started", new bool?(false)).Value) || (A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_fu_pirateAttackFailed", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_briggs_talkedDeadPirates", new bool?(false)).Value))
		{
			return "xpbl_fu";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_underAttack", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_aegis_importantNpcsCanJoinBattle", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_fu_pirateAttackHandled", new bool?(false)).Value && (string.Equals(A_0.c().b(), "xpbl_e5", StringComparison.OrdinalIgnoreCase) || A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_briggs_summonedToBattle", new bool?(false)).Value))
		{
			return "xpbl_e5";
		}
		cky cky = (A_0.ac() as bv9).abu(asp.a, asp.f5);
		if (A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_le_philsImplantAcquired", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_le_finishedFortEntrance", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("global_beginExpedition", new bool?(false)).Value)
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("loc_le_openedFort", new bool?(false)).Value)
			{
				return "xpbl_fu";
			}
			if (!A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_pirates_joined", new bool?(false)).Value && cky.a != h.a)
			{
				return "xpbl_e6";
			}
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

	// Token: 0x0600463C RID: 17980 RVA: 0x001CD40C File Offset: 0x001CB60C
	public override string ce(cyt A_0, string A_1)
	{
		if (string.Equals(A_1, "xpbl_d6", StringComparison.OrdinalIgnoreCase))
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorSaved", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_saveTheProfessor_completed", new bool?(false)).Value)
			{
				return "oldTent";
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_underAttack", new bool?(false)).Value)
			{
				return "front";
			}
			if (!A_0.r().GetPrimitivePropertyValue<bool>("quest_xpbl_savageInvasion_completed", new bool?(false)).Value)
			{
				return "oldTent";
			}
			return "brigTent";
		}
		else if (string.Equals(A_1, "xpbl_fu", StringComparison.OrdinalIgnoreCase))
		{
			if ((A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorKidnapped", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorSaved", new bool?(false)).Value) || A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_fu_pirateAttackFailed", new bool?(false)).Value)
			{
				return "evac";
			}
			return "up";
		}
		else
		{
			if (!string.Equals(A_1, "xpbl_e5", StringComparison.OrdinalIgnoreCase))
			{
				return null;
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_briggs_summonedToBattle", new bool?(false)).Value)
			{
				return "fight";
			}
			return "limbo";
		}
	}

	// Token: 0x0600463D RID: 17981 RVA: 0x001CD598 File Offset: 0x001CB798
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		if (aspect != null)
		{
			if (string.Equals(A_2, "xpbl_d6", StringComparison.OrdinalIgnoreCase))
			{
				if (A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_underAttack", new bool?(false)).Value)
				{
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_briggs:front");
				}
				else if (!A_1.r().GetPrimitivePropertyValue<bool>("quest_xpbl_savageInvasion_completed", new bool?(false)).Value)
				{
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_briggs:oldTent");
				}
				else
				{
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_briggs:brigTent");
				}
			}
			else if (string.Equals(A_2, "xpbl_fu", StringComparison.OrdinalIgnoreCase))
			{
				if (!A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_fu_descended", new bool?(false)).Value)
				{
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_briggs:up");
				}
				else if (A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorKidnapped", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorSaved", new bool?(false)).Value)
				{
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_briggs:evac");
				}
				else
				{
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_briggs:tun");
				}
			}
			if (string.Equals(A_2, "xpbl_e5", StringComparison.OrdinalIgnoreCase))
			{
				if (A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_briggs_summonedToBattle", new bool?(false)).Value)
				{
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_briggs:fight");
				}
				else
				{
					aspect.y6()[ddq.ay] = new bt4("global:xpbl_briggs:limbo");
				}
			}
			else
			{
				aspect.y6()[ddq.ay] = new bt4("global:xpbl_briggs");
			}
		}
		amc aspect2 = A_0.GetAspect<amc>();
		if (aspect2 != null)
		{
			if (string.Equals(A_2, "xpbl_e4", StringComparison.OrdinalIgnoreCase) || string.Equals(A_2, "xpbl_g3", StringComparison.OrdinalIgnoreCase))
			{
				if (!A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_le_briggs_spawnE4Team", new bool?(false)).Value)
				{
					A_1.a(new bw0(A_2.ToString(), new bhh(), 1));
					A_1.r()["npc_xpbl_le_briggs_spawnE4Team"] = true;
				}
				if (aspect2.aa().Vehicle == null)
				{
					b5o b5o = new b5o("xpbl_AegisPatroller");
					agt value = new agt(ez2.CreateDefinitonProvider<eqg>("vehicleParts\\Engines\\BArmLightstep250"));
					agt value2 = new agt(ez2.CreateDefinitonProvider<esd>("vehicleParts\\Batteries\\BArmScilon250"));
					agt value3 = new agt(ez2.CreateDefinitonProvider<eu0>("vehicleParts\\Xpbl_JetskiSuspensions\\BArmMediumJetShocks"));
					aspect2.a(bln.k6);
					if (b5o != null)
					{
						aspect2.aa().Vehicle = new bcx();
						aspect2.aa().Vehicle.a(b5o);
						aspect2.aa().Vehicle.o()["engine"] = value;
						aspect2.aa().Vehicle.o()["battery"] = value2;
						aspect2.aa().Vehicle.o()["suspension"] = value3;
						aspect2.aa().Vehicle.k();
						aspect2.aa().Vehicle.b((double)aspect2.aa().Vehicle.v());
						aspect2.aa().Vehicle.a(double.MaxValue);
						aspect2.aa().Vehicle.k();
						aspect2.aa().Portrait = bln.hy;
						aspect2.aa().bl();
						aspect2.at();
					}
				}
			}
			else
			{
				aspect2.aa().Vehicle = null;
				aspect2.a(bln.hy);
				aspect2.aa().bl();
			}
		}
		string a_ = "characters\\xpbl\\le_briggs";
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
	}
}
