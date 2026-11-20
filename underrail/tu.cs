using System;
using System.Collections.Generic;
using TimelapseVertigo.Playfield.CustomLogic.Data;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02000C1A RID: 3098
public sealed class tu : jn
{
	// Token: 0x0600463E RID: 17982 RVA: 0x001CDA40 File Offset: 0x001CBC40
	public tu() : base("rc_dude", "creature\\characters\\rc_dude")
	{
	}

	// Token: 0x0600463F RID: 17983 RVA: 0x001CDA54 File Offset: 0x001CBC54
	public override string b1(cyt A_0)
	{
		if (!A_0.r().GetPrimitivePropertyValue<bool>("quest_DudesOtherQuest_goToCC", new bool?(false)).Value)
		{
			return "rc1";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_DudesOtherQuest_PartTwo_enteredRift", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quest_DudesOtherQuest_PartTwo_Completed", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("quest_DudesOtherQuest_goToWumb", new bool?(false)).Value)
		{
			return "xpbl_wumb2";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_DudesOtherQuest_PartOne_Started", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quest_DudesOtherQuest_PartOne_Completed", new bool?(false)).Value)
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("quest_DudesOtherQuest_goToLux_Dh", new bool?(false)).Value)
			{
				return "xpbl_lux_dh";
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("quest_DudesOtherQuest_goToLux", new bool?(false)).Value)
			{
				return "lux-c5";
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("quest_DudesOtherQuest_goToUp", new bool?(false)).Value)
			{
				return "xpbl_up_dh";
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("quest_DudesOtherQuest_goToCC", new bool?(false)).Value)
			{
				return "xpbl_cc_dh";
			}
		}
		string text;
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_rc_dude_ingredientDeal_completed", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_rc_dude_beenToPlayersHouse", new bool?(false)).Value && string.Equals(A_0.c().b(), "cc_ph", StringComparison.OrdinalIgnoreCase) && !A_0.r().GetPrimitivePropertyValue<bool>("loc_cc_ph_hasOccupants", new bool?(false)).Value && d39.a(A_0, null).TryGetValue(PlayerHouseElement.LowerFloorDebris, out text) && text != null && text == "cleared")
		{
			return "cc_ph";
		}
		return "xpbl_lux_dh";
	}

	// Token: 0x06004640 RID: 17984 RVA: 0x001CDCA0 File Offset: 0x001CBEA0
	public override string ce(cyt A_0, string A_1)
	{
		if (string.Equals(A_1, "xpbl_wumb2", StringComparison.OrdinalIgnoreCase))
		{
			if (!A_0.r().GetPrimitivePropertyValue<bool>("quest_DudesOtherQuest_PartTwo_Started_introducedWumb", new bool?(false)).Value)
			{
				return "outside";
			}
			return "storage";
		}
		else if (string.Equals(A_1, "xpbl_lux_dh", StringComparison.OrdinalIgnoreCase))
		{
			if (!A_0.r().GetPrimitivePropertyValue<bool>("quest_DudesOtherQuest_PartOne_Completed", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("quest_DudesOtherQuest_PartTwo_Completed", new bool?(false)).Value)
			{
				return "barrel";
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("quest_DudesOtherQuest_PartTwo_Started", new bool?(false)).Value)
			{
				return "rift";
			}
			return "lab";
		}
		else if (string.Equals(A_1, "lux-c5", StringComparison.OrdinalIgnoreCase))
		{
			if (!A_0.r().GetPrimitivePropertyValue<bool>("quest_DudesOtherQuest_lux_c5-introduced", new bool?(false)).Value)
			{
				return "wrong";
			}
			return "entrance";
		}
		else if (string.Equals(A_1, "xpbl_up_dh", StringComparison.OrdinalIgnoreCase))
		{
			if (!A_0.r().GetPrimitivePropertyValue<bool>("loc_up_dh_introduced", new bool?(false)).Value)
			{
				return "enter";
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("quest_DudesOtherQuest_up_dh_canEnterLab", new bool?(false)).Value)
			{
				return "lab";
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("quest_DudesOtherQuest_up_dh_dudeHides", new bool?(false)).Value)
			{
				return "exit";
			}
			return "lock";
		}
		else
		{
			if (!string.Equals(A_1, "xpbl_cc_dh", StringComparison.OrdinalIgnoreCase))
			{
				return null;
			}
			if (!A_0.r().GetPrimitivePropertyValue<bool>("xpbl_npc_cc_dh_zonerMa_Met", new bool?(false)).Value)
			{
				return "start";
			}
			if (!A_0.r().GetPrimitivePropertyValue<bool>("interface_xpbl_cc_dh_panel_removed", new bool?(false)).Value)
			{
				return "enter";
			}
			if (!A_0.r().GetPrimitivePropertyValue<bool>("quest_DudesOtherQuest_cc_dh_finalTalk", new bool?(false)).Value)
			{
				return "panel";
			}
			return "exit";
		}
	}

	// Token: 0x06004641 RID: 17985 RVA: 0x001CDEE0 File Offset: 0x001CC0E0
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		bm6 aspect = A_0.GetAspect<bm6>();
		if (aspect != null)
		{
			if (!string.Equals(A_2, "xpbl_lux_dh", StringComparison.OrdinalIgnoreCase) && !string.Equals(A_2, "xpbl_cc_dh", StringComparison.OrdinalIgnoreCase))
			{
				aspect.y6().RemoveProperty(ddq.bc);
			}
			if (!string.Equals(A_2, "xpbl_cc_dh", StringComparison.OrdinalIgnoreCase))
			{
				aspect.y6().RemoveProperty(ddq.k);
				aspect.y6().RemoveProperty(ddq.n);
				aspect.y6().RemoveProperty(ddq.l);
			}
			if (!string.Equals(A_2, "xpbl_wumb2", StringComparison.OrdinalIgnoreCase))
			{
				aspect.ad()["Civilian"] = true;
			}
			else
			{
				aspect.ad().RemoveProperty("Civilian");
			}
			if (string.Equals(A_2, "xpbl_wumb2", StringComparison.OrdinalIgnoreCase))
			{
				aspect.y6()[ddq.ay] = new bt4("global:rc_dude:storage");
				aspect.y6().RemoveProperty(ddq.w);
			}
			else if (string.Equals(A_2, "xpbl_lux_dh", StringComparison.OrdinalIgnoreCase))
			{
				aspect.y6()[ddq.bc] = "quest_DudesOtherQuest_talkedInLux";
				aspect.y6()[ddq.w] = CharacterState.Custom1;
				if (A_1.r().GetPrimitivePropertyValue<bool>("quest_DudesOtherQuest_PartTwo_Started", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("quest_DudesOtherQuest_PartTwo_Completed", new bool?(false)).Value)
				{
					if (A_1.r().GetPrimitivePropertyValue<bool>("quest_DudesOtherQuest_PartTwo_Started", new bool?(false)).Value)
					{
						aspect.y6()[ddq.ay] = new bt4("global:rc_dude:rift");
					}
					else
					{
						aspect.y6()[ddq.ay] = new bt4("global:rc_dude:lab");
					}
				}
				else
				{
					aspect.y6()[ddq.ay] = new bt4("global:rc_dude:barrel");
				}
			}
			else if (string.Equals(A_2, "lux-c5", StringComparison.OrdinalIgnoreCase))
			{
				aspect.y6()[ddq.ay] = new bt4("global:rc_dude:entrance");
				aspect.y6()[ddq.w] = CharacterState.Custom1;
			}
			else if (string.Equals(A_2, "xpbl_up_dh", StringComparison.OrdinalIgnoreCase))
			{
				aspect.y6()[ddq.w] = CharacterState.Custom2;
				if (!A_1.r().GetPrimitivePropertyValue<bool>("loc_up_dh_introduced", new bool?(false)).Value)
				{
					aspect.y6()[ddq.ay] = new bt4("global:rc_dude:enter");
				}
				else if (A_1.r().GetPrimitivePropertyValue<bool>("quest_DudesOtherQuest_up_dh_canEnterLab", new bool?(false)).Value)
				{
					aspect.y6()[ddq.ay] = new bt4("global:rc_dude:lab");
				}
				else if (A_1.r().GetPrimitivePropertyValue<bool>("quest_DudesOtherQuest_up_dh_dudeHides", new bool?(false)).Value)
				{
					aspect.y6()[ddq.ay] = new bt4("global:rc_dude:exit");
				}
				else
				{
					aspect.y6()[ddq.ay] = new bt4("global:rc_dude:lock");
				}
			}
			else if (string.Equals(A_2, "xpbl_cc_dh", StringComparison.OrdinalIgnoreCase))
			{
				aspect.y6()[ddq.w] = CharacterState.Custom2;
				if (!A_1.r().GetPrimitivePropertyValue<bool>("interface_xpbl_cc_dh_panel_removed", new bool?(false)).Value)
				{
					aspect.y6()[ddq.k] = new List<string>
					{
						"pa1",
						"pa2",
						"pa3"
					};
					aspect.y6()[ddq.l] = 10000;
					aspect.y6()[ddq.n] = true;
					aspect.y6().RemoveProperty(ddq.ay);
				}
				else if (!A_1.r().GetPrimitivePropertyValue<bool>("quest_DudesOtherQuest_cc_dh_finalTalk", new bool?(false)).Value)
				{
					aspect.y6().RemoveProperty(ddq.k);
					aspect.y6().RemoveProperty(ddq.n);
					aspect.y6().RemoveProperty(ddq.l);
					aspect.y6()[ddq.ay] = new bt4("global:rc_dude:panel");
				}
				else
				{
					aspect.y6().RemoveProperty(ddq.k);
					aspect.y6().RemoveProperty(ddq.n);
					aspect.y6().RemoveProperty(ddq.l);
					aspect.y6()[ddq.ay] = new bt4("global:rc_dude:exit");
				}
			}
			else if (string.Equals(A_2, "cc_ph", StringComparison.OrdinalIgnoreCase))
			{
				aspect.y6()[ddq.k] = new List<string>
				{
					"dude1",
					"dude2",
					"dude3"
				};
				aspect.y6()[ddq.l] = 10000;
				aspect.y6()[ddq.n] = true;
				aspect.y6().RemoveProperty(ddq.ay);
				A_1.r()["npc_rc_dude_beenToPlayersHouse"] = true;
				A_1.r()["loc_cc_ph_hasOccupants"] = true;
			}
			else
			{
				aspect.y6()[ddq.ay] = new bt4("global:rc_dude");
				aspect.y6()[ddq.w] = CharacterState.Custom1;
				aspect.y6()[ddq.y] = 13000;
				aspect.y6().RemoveProperty(ddq.k);
				aspect.y6().RemoveProperty(ddq.n);
				aspect.y6().RemoveProperty(ddq.l);
			}
			amc aspect2 = A_0.GetAspect<amc>();
			if (aspect2 != null)
			{
				if (string.Equals(A_2, "xpbl_wumb2", StringComparison.OrdinalIgnoreCase))
				{
					if (aspect2.aa().Gear.j()[WeaponKey.Secondary].Item != null && aspect2.aa().Gear.j()[WeaponKey.Secondary].Item.TypedDefinition.ae().GetValueOrDefault() == WeaponSubtype.Pistol_Plasma)
					{
						goto IL_847;
					}
					dro dro = new dro();
					dro.na(14);
					dro.nc(20);
					dro.a("PlasmaDischarger");
					dro.d(3);
					using (List<coh>.Enumerator enumerator = dro.np().GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							coh coh = enumerator.Current;
							if (coh is cd1)
							{
								euf.a(coh, null);
								aspect2.aa().Gear.j()[WeaponKey.Secondary].a(coh as cd1, true);
							}
							else
							{
								aspect2.aa().Bag.z3(coh, true);
							}
						}
						goto IL_847;
					}
				}
				if (string.Equals(A_2, "xpbl_up_dh", StringComparison.OrdinalIgnoreCase))
				{
					if (aspect2.aa().Gear.j()[WeaponKey.Secondary].Item != null)
					{
						goto IL_847;
					}
					an5 an = new an5();
					an.na(14);
					an.nc(20);
					using (List<coh>.Enumerator enumerator = an.np().GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							coh coh2 = enumerator.Current;
							if (coh2 is cd1)
							{
								euf.a(coh2, null);
								aspect2.aa().Gear.j()[WeaponKey.Secondary].a(coh2 as cd1, true);
								aspect2.aa().Offense.a(WeaponKey.Primary);
							}
							else
							{
								aspect2.aa().Bag.z3(coh2, true);
							}
						}
						goto IL_847;
					}
				}
				aspect2.aa().Gear.j()[WeaponKey.Secondary].b(null);
				aspect2.aa().Offense.a(WeaponKey.Primary);
				IL_847:
				if (string.Equals(A_2, "rc1", StringComparison.OrdinalIgnoreCase))
				{
					aspect2.aa().FactionId = asp.cl;
				}
				else
				{
					aspect2.aa().FactionId = asp.fq;
				}
				if (string.Equals(A_2, "xpbl_lux_dh", StringComparison.OrdinalIgnoreCase) && A_1.r().GetPrimitivePropertyValue<bool>("quest_DudesOtherQuest_PartTwo_Completed", new bool?(false)).Value && A_1.r().GetPrimitivePropertyValue<bool>("npc_rc_dude_ingredientDeal_completed", new bool?(false)).Value)
				{
					e3l e3l = A_0.GetAspect<e3l>();
					if (e3l == null)
					{
						e3l = new e3l(A_0 as c5x);
						A_0.SetAspect<e3l>(e3l);
					}
					if (!e3l.a.Contains("GotCocktail"))
					{
						aspect2.aa().Bag.z3(new d48(ez2.CreateDefinitonProvider<cv9>("Consumables\\Food\\Cocktails\\Absence")), true);
						aspect2.aa().Bag.z3(new d48(ez2.CreateDefinitonProvider<ebz>("Devices\\Lighter")), true);
						e3l.a.Add("GotCocktail");
					}
				}
			}
			bn5 bn = A_0.GetAspect<j7>() as bn5;
			if (bn != null)
			{
				if (string.Equals(A_2, "cc_ph", StringComparison.OrdinalIgnoreCase) || (string.Equals(A_2, "xpbl_cc_dh", StringComparison.OrdinalIgnoreCase) && !A_1.r().GetPrimitivePropertyValue<bool>("interface_xpbl_cc_dh_panel_removed", new bool?(false)).Value))
				{
					bn.a(false);
					return;
				}
				bn.a(true);
			}
		}
	}
}
