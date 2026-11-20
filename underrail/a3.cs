using System;
using TimelapseVertigo.Rules;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000C11 RID: 3089
public sealed class a3 : jn
{
	// Token: 0x06004612 RID: 17938 RVA: 0x001CABAC File Offset: 0x001C8DAC
	public override string cc()
	{
		return "xpbl";
	}

	// Token: 0x06004613 RID: 17939 RVA: 0x001CABB4 File Offset: 0x001C8DB4
	public override bool cd()
	{
		return true;
	}

	// Token: 0x06004614 RID: 17940 RVA: 0x001CABB8 File Offset: 0x001C8DB8
	public a3() : base("xpbl_razor", "creature\\characters\\xpbl\\Razor")
	{
	}

	// Token: 0x06004615 RID: 17941 RVA: 0x001CABCC File Offset: 0x001C8DCC
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_razor_dead", new bool?(false)).Value)
		{
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_started", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_shipCleared", new bool?(false)).Value)
		{
			if (!A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_timeToAttack", new bool?(false)).Value)
			{
				return "cvw17";
			}
			if (!A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_goAlone", new bool?(false)).Value)
			{
				return "cvw21";
			}
			return "none";
		}
		else
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_guardedAudience", new bool?(false)).Value)
			{
				return "xpbl_g2_InnerShip";
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_pirates_joined", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorSaved", new bool?(false)).Value)
			{
				return "xpbl_i5";
			}
			return "xpbl_f4";
		}
	}

	// Token: 0x06004616 RID: 17942 RVA: 0x001CAD18 File Offset: 0x001C8F18
	public override string ce(cyt A_0, string A_1)
	{
		if (!string.Equals(A_1, "cvw21", StringComparison.OrdinalIgnoreCase))
		{
			return null;
		}
		if (!A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_razor_enteredCVW21", new bool?(false)).Value)
		{
			return "attack";
		}
		return "guard";
	}

	// Token: 0x06004617 RID: 17943 RVA: 0x001CAD68 File Offset: 0x001C8F68
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		if (A_0 != null)
		{
			amc aspect = A_0.GetAspect<amc>();
			if (aspect != null)
			{
				if (string.Equals(A_2, "xpbl_f4", StringComparison.OrdinalIgnoreCase) || string.Equals(A_2, "cvw17", StringComparison.OrdinalIgnoreCase) || string.Equals(A_2, "cvw21", StringComparison.OrdinalIgnoreCase))
				{
					aspect.aa().Offense.a(WeaponKey.Secondary);
					if (aspect.aa().Vehicle == null)
					{
						b5o b5o;
						agt value;
						agt value2;
						agt value3;
						if (!A_1.r().GetPrimitivePropertyValue<bool>("faction_xpbl_pir_gotAegisJets", new bool?(false)).Value)
						{
							b5o = new b5o("xpbl_Scooter");
							value = new agt(ez2.CreateDefinitonProvider<eqg>("vehicleParts\\Engines\\WellMadeEngine225"));
							value2 = new agt(ez2.CreateDefinitonProvider<esd>("vehicleParts\\Batteries\\BArmCurrent800"));
							value3 = new agt(ez2.CreateDefinitonProvider<eu0>("vehicleParts\\Xpbl_JetskiSuspensions\\XGMist"));
							aspect.a(bln.kz);
						}
						else
						{
							b5o = new b5o("xpbl_AegisPatroller");
							value = new agt(ez2.CreateDefinitonProvider<eqg>("vehicleParts\\Engines\\BArmLightstep250"));
							value2 = new agt(ez2.CreateDefinitonProvider<esd>("vehicleParts\\Batteries\\BArmScilon250"));
							value3 = new agt(ez2.CreateDefinitonProvider<eu0>("vehicleParts\\Xpbl_JetskiSuspensions\\BArmMediumJetShocks"));
							aspect.a(bln.k8);
						}
						if (b5o != null)
						{
							aspect.aa().Vehicle = new bcx();
							aspect.aa().Vehicle.a(b5o);
							aspect.aa().Vehicle.o()["engine"] = value;
							aspect.aa().Vehicle.o()["battery"] = value2;
							aspect.aa().Vehicle.o()["suspension"] = value3;
							aspect.aa().Vehicle.k();
							aspect.aa().Vehicle.b((double)aspect.aa().Vehicle.v());
							aspect.aa().Vehicle.a(double.MaxValue);
							aspect.aa().Vehicle.k();
							aspect.aa().Portrait = "xpbl_prz";
							aspect.aa().bl();
							aspect.at();
						}
					}
				}
				else
				{
					aspect.aa().Vehicle = null;
					aspect.a(bln.hq);
					aspect.aa().bl();
					aspect.at();
					aspect.aa().Offense.a(WeaponKey.Primary);
				}
				if (string.Equals(A_2, "xpbl_g2_InnerShip", StringComparison.OrdinalIgnoreCase))
				{
					aspect.aa().Skills.Get<jk>().a(140);
				}
				else
				{
					aspect.aa().Skills.Get<jk>().a(130);
				}
				if (string.Equals(A_2, "cvw17", StringComparison.OrdinalIgnoreCase) || string.Equals(A_2, "cvw21", StringComparison.OrdinalIgnoreCase))
				{
					if (string.Equals(A_2, "cvw21", StringComparison.OrdinalIgnoreCase) && !A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_razor_enteredCVW21", new bool?(false)).Value)
					{
						A_1.r()["npc_xpbl_pir_razor_enteredCVW21"] = true;
						cd1 cd = aspect.aa().Gear.j()[WeaponKey.Secondary].Item;
						if (cd != null)
						{
							AmmoType item = AmmoType.ShotgunShell_3;
							cd.LoadedAmmo.Clear();
							for (int i = 0; i < cd.TypedDefinition.f(); i++)
							{
								cd.LoadedAmmo.Add(item);
							}
						}
						if (A_1.ae() >= GameDifficulty.Dominating)
						{
							coh coh = new d48(ez2.CreateDefinitonProvider<cv9>("consumables\\medicine\\AdrenalineShot"));
							if (coh != null)
							{
								aspect.aa().Bag.z3(coh, true);
							}
						}
					}
					aspect.aa().AttributesBase &= ~d8o.o;
					aspect.aa().FactionId = asp.fw;
				}
				else
				{
					aspect.aa().AttributesBase |= d8o.o;
					aspect.aa().FactionId = asp.fr;
				}
			}
			bm6 aspect2 = A_0.GetAspect<bm6>();
			if (aspect2 != null && string.Equals(A_2, "cvw21", StringComparison.OrdinalIgnoreCase))
			{
				aspect2.y6().RemoveProperty(ddq.bg);
			}
		}
	}
}
