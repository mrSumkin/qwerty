using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;
using TimelapseVertigo.Rules;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001FBF RID: 8127
public static class cq4
{
	// Token: 0x0600BED1 RID: 48849 RVA: 0x0041C338 File Offset: 0x0041A538
	public static esj f()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Huge)
		{
			return new esj(66, 66);
		}
		if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.ExtraLarge)
		{
			return new esj(50, 50);
		}
		serviceOrThrow.aq1().b().g();
		return new esj(33, 33);
	}

	// Token: 0x0600BED2 RID: 48850 RVA: 0x0041C3A8 File Offset: 0x0041A5A8
	public static string e()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Huge)
		{
			return egg.au;
		}
		if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.ExtraLarge)
		{
			return egg.ad;
		}
		serviceOrThrow.aq1().b().g();
		return egg.n;
	}

	// Token: 0x0600BED3 RID: 48851 RVA: 0x0041C40C File Offset: 0x0041A60C
	public static string d()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (egg.v)
		{
			if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.ExtraLarge)
			{
				return egg.t;
			}
			if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Large)
			{
				return egg.t;
			}
			return egg.q;
		}
		else
		{
			if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Huge)
			{
				return egg.bi;
			}
			if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.ExtraLarge)
			{
				return egg.a6;
			}
			if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Large)
			{
				return egg.at;
			}
			return egg.al;
		}
	}

	// Token: 0x0600BED4 RID: 48852 RVA: 0x0041C4C0 File Offset: 0x0041A6C0
	public static string c()
	{
		if (egg.v)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.ExtraLarge)
			{
				return egg.t;
			}
			if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Large)
			{
				return egg.t;
			}
			return egg.n;
		}
		else
		{
			cnk serviceOrThrow2 = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow2.aq1().b().g() == InterfaceElementSize2.Huge)
			{
				return egg.bd;
			}
			if (serviceOrThrow2.aq1().b().g() == InterfaceElementSize2.ExtraLarge)
			{
				return egg.au;
			}
			if (serviceOrThrow2.aq1().b().g() == InterfaceElementSize2.Large)
			{
				return egg.am;
			}
			return egg.ad;
		}
	}

	// Token: 0x0600BED5 RID: 48853 RVA: 0x0041C57C File Offset: 0x0041A77C
	public static string b()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Huge)
		{
			return egg.au;
		}
		if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.ExtraLarge)
		{
			return egg.am;
		}
		if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Large)
		{
			return egg.ad;
		}
		return egg.z;
	}

	// Token: 0x0600BED6 RID: 48854 RVA: 0x0041C5E8 File Offset: 0x0041A7E8
	public static ecs a(coh A_0, efk A_1, object A_2, bool A_3, bool A_4, eg A_5, c3n A_6 = null, double? A_7 = null, bool A_8 = false)
	{
		ecs ecs = new ecs();
		if (A_0 == null)
		{
			return ecs;
		}
		if (A_3)
		{
			cq4.h(ecs, A_0);
			cq4.g(ecs, A_0);
		}
		cq4.f(ecs, A_0);
		cq4.h(ecs, A_0, A_1);
		cq4.e(ecs, A_0);
		cq4.l(ecs, A_0, A_1);
		cq4.c(ecs, A_0);
		cq4.g(ecs, A_0, A_1);
		cq4.d(ecs, A_0, A_1);
		cq4.k(ecs, A_0, A_1);
		cq4.d(ecs, A_0);
		cq4.b(ecs, A_0, A_1);
		cq4.a(ecs, A_0, A_1, A_6);
		cq4.i(ecs, A_0, A_1);
		cq4.e(ecs, A_0, A_1);
		cq4.f(ecs, A_0, A_1);
		cq4.b(ecs, A_0);
		cq4.a(ecs, A_0);
		double? a_;
		if (A_7 != null && A_5 != null && A_0.Definition.a5() != null && A_5.aqa().Contains(A_0.Definition.a5()))
		{
			a_ = null;
		}
		else if (A_0.Definition != null && A_0.Definition.a7().GetPrimitivePropertyValue<bool>(dii.e, new bool?(false)).Value)
		{
			a_ = null;
		}
		else
		{
			a_ = A_7;
		}
		cq4.c(ecs, A_0, A_1);
		cq4.a(ecs, A_0, A_1);
		cq4.m(ecs, A_0, A_1);
		cq4.a(ecs, A_0, A_4, A_5, a_);
		dkk dkk = A_2 as dkk;
		if (dkk != null)
		{
			cq4.a(ecs, A_0, dkk.CanSplit, A_8);
		}
		cq4.j(ecs, A_0, A_1);
		return ecs;
	}

	// Token: 0x0600BED7 RID: 48855 RVA: 0x0041C76C File Offset: 0x0041A96C
	public static ecs a(int A_0, bool A_1)
	{
		ecs ecs = new ecs();
		if (A_1)
		{
			ecs.a.Add(new dl6(new bph[]
			{
				new bph(new d22(cq4.d(), Color.White), dh9.c("PsiWindow_PsionicCircuit"), null)
			}));
			ecs.a.Add(cq4.a());
			ecs.a.Add(new dl6(new bph[]
			{
				new bph(new d22(cq4.c(), cq4.c), dh9.c("PsiWindow_PsionicCircuit_Desc"), null)
			}));
		}
		else
		{
			ecs.a.Add(new dl6(new bph[]
			{
				new bph(new d22(cq4.d(), Color.LightGray), dh9.c("PsiWindow_LockedPsionicCircuit"), null)
			}));
			ecs.a.Add(cq4.a());
			ecs.a.Add(new dl6(new bph[]
			{
				new bph(new d22(cq4.c(), cq4.c), dh9.c("PsiWindow_LockedPsionicCircuit_Desc"), null)
			}));
		}
		if (A_0 < aiy.av)
		{
			cnk cnk = ces.a();
			efk efk = (cnk != null && cnk.aqu() != null) ? cnk.aqu().v() : null;
			c6m a_ = aiy.a(efk, A_0);
			cq4.a(ecs, a_, efk);
		}
		return ecs;
	}

	// Token: 0x0600BED8 RID: 48856 RVA: 0x0041C8D0 File Offset: 0x0041AAD0
	public static ecs c(coh A_0)
	{
		ecs ecs = new ecs();
		cq4.h(ecs, A_0);
		cq4.g(ecs, A_0);
		return ecs;
	}

	// Token: 0x0600BED9 RID: 48857 RVA: 0x0041C8E8 File Offset: 0x0041AAE8
	public static ecs a(GameDifficultySettings A_0)
	{
		if (A_0 == null)
		{
			return null;
		}
		ecs ecs = new ecs();
		ecs.a.Add(cq4.a(qv.b("Rules/CustomDiffOption_Caption_encounter_diff") + ": ", adi.c, dh9.c("NewGame_GameDifficulty_" + A_0.EncounterDifficulty.ToString()), Color.White, null, null));
		ecs.a.Add(cq4.a(qv.b("Rules/CustomDiffOption_Caption_puzzle_diff") + ": ", adi.c, dh9.c("NewGame_GameDifficulty_" + A_0.PuzzleDifficulty.ToString()), Color.White, null, null));
		ecs.a.Add(cq4.a());
		if (dk2.f())
		{
			ecs.a.Add(cq4.a(qv.b("Rules/CustomDiffOption_Caption_max_level") + ": ", adi.c, c2h.a().ToString(), Color.White, null, null));
			ecs.a.Add(cq4.a());
		}
		ecs.a.Add(cq4.a(qv.b("Rules/CustomDiffOption_Caption_health_mod_player") + ": ", adi.c, A_0.PlayerHealthModifier.ToString("P0"), Color.White, null, null));
		ecs.a.Add(cq4.a(qv.b("Rules/CustomDiffOption_Caption_health_mod_npc") + ": ", adi.c, A_0.NpcHealthModifier.ToString("P0"), Color.White, null, null));
		ecs.a.Add(cq4.a(qv.b("Rules/CustomDiffOption_Caption_health_mod_boss") + ": ", adi.c, A_0.NpcBossHealthModifier.ToString("P0"), Color.White, null, null));
		ecs.a.Add(cq4.a(qv.b("Rules/CustomDiffOption_Caption_healing_modifier") + ": ", adi.c, A_0.HealingModifier.ToString("P0"), Color.White, null, null));
		ecs.a.Add(cq4.a(qv.b("Rules/CustomDiffOption_Caption_healing_cooldown") + ": ", adi.c, l4.a(A_0.HealingCooldown, false), Color.White, null, null));
		ecs.a.Add(cq4.a());
		ecs.a.Add(cq4.a(qv.b("Rules/CustomDiffOption_Caption_skill_mod_npc") + ": ", adi.c, A_0.NpcSkillModifier.ToString("P0"), Color.White, null, null));
		ecs.a.Add(cq4.a(qv.b("Rules/CustomDiffOption_Caption_skill_mod_boss") + ": ", adi.c, A_0.NpcBossSkillModifier.ToString("P0"), Color.White, null, null));
		ecs.a.Add(cq4.a(qv.b("Rules/CustomDiffOption_Caption_npc_crit_chance_bonus") + ": ", adi.c, A_0.NpcCritChanceBonus.ToString("P0"), Color.White, null, null));
		ecs.a.Add(cq4.a());
		ecs.a.Add(cq4.a(qv.b("Rules/CustomDiffOption_Caption_zone_transition_ap_cost") + ": ", adi.c, A_0.ZoneTransitionApCost.ToString(), Color.White, null, null));
		ecs.a.Add(cq4.a());
		ecs.a.Add(cq4.a(qv.b("Rules/CustomDiffOption_Caption_sold_item_value_modifier") + ": ", adi.c, A_0.SoldItemValueModifier.ToString("P0"), Color.White, null, null));
		ecs.a.Add(cq4.a(qv.b("Rules/CustomDiffOption_Caption_merchant_purchasing_power") + ": ", adi.c, A_0.MerchantPurchasingPower.ToString("P0"), Color.White, null, null));
		ecs.a.Add(cq4.a(qv.b("Rules/CustomDiffOption_Caption_carry_capacity_mod") + ": ", adi.c, A_0.CarryCapacityMod.ToString("P0"), Color.White, null, null));
		ecs.a.Add(cq4.a(qv.b("Rules/CustomDiffOption_Caption_item_degradation_rate") + ": ", adi.c, A_0.ItemDegradationRate.ToString("P0"), Color.White, null, null));
		return ecs;
	}

	// Token: 0x0600BEDA RID: 48858 RVA: 0x0041CD74 File Offset: 0x0041AF74
	public static ecs a(av A_0, string A_1 = null, bool A_2 = true)
	{
		d02 service = bpo.GetService<d02>();
		ecs ecs = new ecs();
		if (A_0 != null && A_0.p() != null && A_0.w())
		{
			ehl ehl = A_0.p() as ehl;
			object a_ = null;
			if (ehl != null && ehl.bn(A_0) == SpellTargetType.Self)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
				{
					a_ = serviceOrThrow.aqu().v().b();
				}
			}
			bool a_2 = service != null && service.ahg();
			v5 v = A_0.p().PrimaryExecutionMode;
			dl6 dl = new dl6();
			string text = A_0.p().LocalizedName;
			if (A_1 != null)
			{
				text = A_1 + text;
			}
			dl.a.Add(new bph(new d22(cq4.d(), adi.ai[A_0.p().Nature]), text, null));
			ecs.a.Add(dl);
			c7i c7i = A_0.p() as c7i;
			if (c7i != null)
			{
				ecs.a.Add(cq4.a(dh9.a(c7i.School), Color.Yellow, null));
			}
			ecs.a.Add(cq4.a());
			ecs.a.Add(cq4.a(A_0.u(), cq4.e, null));
			ecs.a.Add(cq4.a());
			int num = A_0.d(a_);
			eu7 eu = A_0 as eu7;
			if (eu != null)
			{
				double num2 = (double)eu.a(a_);
				double num3 = (double)eu.c(a_);
				int num4 = eu.g();
				if (v == v5.a)
				{
					if (num > 0)
					{
						Color white = Color.White;
						if (service != null && service.ahg() && A_0.b8() != null)
						{
							d4n d4n = service.ahu(A_0.b8());
							if (d4n != null && d4n.c < (double)num)
							{
								white = cq4.k;
							}
						}
						ecs.a.Add(cq4.a(dh9.c("ActionPoints") + ": ", cq4.f, num.ToString(), white, null, null));
					}
				}
				else if (num2 > 0.0)
				{
					ecs.a.Add(cq4.a(dh9.c("InvocationTime") + ": ", cq4.f, (num2 / 1000.0).ToString("0.00") + dh9.c("SecondsLetter"), Color.White, null, null));
				}
				bd0 bd = A_0 as bd0;
				ce5 ce = A_0.p() as ce5;
				if (bd != null && ce != null)
				{
					float num5 = bd.a();
					Color a_3;
					string str;
					if (A_0.b8() != null && A_0.b8().StatusEffects.a(csc.a))
					{
						num5 = cpn.a(new eoj(A_0.b8(), null, null), (int)num5);
						a_3 = (((float)((int)bd.b8().Defense.q().zo()) <= num5) ? cq4.k : Color.White);
						str = dh9.c("Health");
					}
					else
					{
						a_3 = ((bd.b8().Offense.aa().zo() < num5) ? cq4.k : Color.White);
						str = dh9.c("Psi");
					}
					ecs.a.Add(cq4.a(str + ": ", cq4.f, num5.ToString("0"), a_3, null, null));
				}
				if (num3 > 0.0)
				{
					ecs.a.Add(cq4.a(dh9.c("Range") + ": ", cq4.f, num3.ToString("0.0"), Color.White, null, null));
				}
				if (num4 > 0)
				{
					ecs.a.Add(cq4.a(dh9.c("Radius") + ": ", cq4.f, num4.ToString("0"), Color.White, null, null));
				}
			}
			if (A_0 is bl6 && v == v5.a && num > 0)
			{
				Color white2 = Color.White;
				if (service != null && service.ahg() && A_0.b8() != null)
				{
					d4n d4n2 = service.ahu(A_0.b8());
					if (d4n2 != null && d4n2.c < (double)num)
					{
						white2 = cq4.k;
					}
				}
				ecs.a.Add(cq4.a(dh9.c("ActionPoints") + ": ", cq4.f, num.ToString(), white2, null, null));
			}
			int num6 = 0;
			foreach (cfd cfd in A_0.a(v))
			{
				if (cfd.b > num6)
				{
					num6 = cfd.b;
				}
			}
			if (num6 > 0)
			{
				ecs.a.Add(cq4.a(dh9.c("Cooldown") + ": ", cq4.f, l4.c((double)num6, v == v5.a), Color.White, null, null));
			}
			if (A_2 && c7i != null && A_0.b8() != null && !A_0.b8().Offense.a(A_0.p().TechnicalName))
			{
				ecs.a.Add(cq4.a());
				ecs.a.Add(cq4.a(dh9.c("NotInvervated"), cq4.k, null));
			}
			ip ip = A_0.n();
			if (ip != null && ip.b > 0.0 && ip.a > 0.0)
			{
				ecs.a.Add(cq4.a());
				ecs.a.Add(cq4.a(dh9.c("RemainingCooldown") + ": " + cq4.a(ip.a, a_2), new Color(255, 0, 0), null));
			}
		}
		return ecs;
	}

	// Token: 0x0600BEDB RID: 48859 RVA: 0x0041D424 File Offset: 0x0041B624
	public static string a(double A_0, bool A_1)
	{
		string result;
		if (A_1)
		{
			result = l4.a(l4.a(A_0), true);
		}
		else if (A_0 > 3600000.0)
		{
			result = ((int)Math.Ceiling(A_0 / 3600000.0)).ToString() + dh9.c("HoursLetter");
		}
		else if (A_0 > 60000.0)
		{
			result = ((int)Math.Ceiling(A_0 / 60000.0)).ToString() + dh9.c("MinutesLetter");
		}
		else
		{
			result = ((int)Math.Ceiling(A_0 / 1000.0)).ToString() + dh9.c("SecondsLetter");
		}
		return result;
	}

	// Token: 0x0600BEDC RID: 48860 RVA: 0x0041D4F0 File Offset: 0x0041B6F0
	public static ecs a(cgo A_0)
	{
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		dl.a.Add(new bph(new d22(cq4.d(), Color.DarkGray), A_0.c, null));
		if (A_0.d > 1)
		{
			dl.a.Add(new bph(new d22(cq4.d(), Color.LightGray), " (x" + A_0.d.ToString() + ")", null));
		}
		ecs.a.Add(dl);
		if (A_0.b)
		{
			ecs.a.Add(cq4.a(dh9.c("Crafting_Slot_Optional"), Color.Gray, null));
		}
		if ((A_0.b || A_0.g) && A_0.e > 0f)
		{
			ecs.a.Add(cq4.a());
			dl6 dl2 = new dl6();
			dl2.a.Add(new bph(new d22(cq4.c(), Color.Gray), dh9.c("Crafting_Composition_Diff0") + " ", null));
			dl2.a.Add(new bph(new d22(cq4.c(), Color.White), Convert.ToInt32(A_0.e * 100f).ToString() + "%", null));
			dl2.a.Add(new bph(new d22(cq4.c(), Color.Gray), " " + dh9.c("Crafting_Composition_Diff1"), null));
			ecs.a.Add(dl2);
		}
		return ecs;
	}

	// Token: 0x0600BEDD RID: 48861 RVA: 0x0041D6A0 File Offset: 0x0041B8A0
	public static ecs a(c38 A_0)
	{
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		dl.a.Add(new bph(new d22(cq4.d(), Color.DarkGray), A_0.f(), null));
		if (A_0.a() != 0)
		{
			dl.a.Add(new bph(new d22(cq4.d(), Color.LightGray), string.Concat(new string[]
			{
				" (",
				dh9.c("Vehicle_Slot_MaxSize"),
				": ",
				A_0.a().ToString(),
				")"
			}), null));
		}
		ecs.a.Add(dl);
		if (A_0.g())
		{
			ecs.a.Add(cq4.a(dh9.c("Vehicle_Slot_Optional"), Color.Gray, null));
		}
		ecs.a.Add(cq4.a());
		dl6 dl2 = new dl6();
		string a_;
		if (!string.IsNullOrEmpty(A_0.e()))
		{
			a_ = A_0.e();
		}
		else
		{
			a_ = qv.b("Items\\VehicleParts/" + A_0.c().ToString());
		}
		dl2.a.Add(new bph(new d22(cq4.c(), Color.Gray), a_, null));
		ecs.a.Add(dl2);
		return ecs;
	}

	// Token: 0x0600BEDE RID: 48862 RVA: 0x0041D80C File Offset: 0x0041BA0C
	public static ecs a(string A_0, string A_1, string A_2)
	{
		return cq4.a(A_0, A_1, null, A_2);
	}

	// Token: 0x0600BEDF RID: 48863 RVA: 0x0041D81C File Offset: 0x0041BA1C
	public static ecs a(string A_0, string A_1, string A_2, string A_3)
	{
		ecs ecs = new ecs(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(new d22(cq4.d(), adi.c), A_0, null)
			}),
			new dl6(new List<bph>
			{
				new bph(new d22(cq4.c(), Color.White), null, null)
			}),
			new dl6(new List<bph>
			{
				new bph(new d22(cq4.c(), Color.LightGray), A_3, null)
			})
		});
		if (!string.IsNullOrEmpty(A_1))
		{
			ecs.a[0].a.AddRange(new bph[]
			{
				new bph(new d22(cq4.d(), adi.c), " (", null),
				new bph(new d22(cq4.d(), Color.White), A_1, null),
				new bph(new d22(cq4.d(), adi.c), ")", null)
			});
		}
		if (!string.IsNullOrEmpty(A_2))
		{
			ecs.a[0].a.AddRange(new bph[]
			{
				new bph(new d22(cq4.d(), adi.c), " (", null),
				new bph(new d22(cq4.d(), Color.White), A_2, null),
				new bph(new d22(cq4.d(), adi.c), ")", null)
			});
		}
		return ecs;
	}

	// Token: 0x0600BEE0 RID: 48864 RVA: 0x0041D9B0 File Offset: 0x0041BBB0
	public static dl6 a(string A_0, Color A_1, string A_2 = null)
	{
		return new dl6(new List<bph>
		{
			new bph(new d22(cq4.c(), A_1), A_0, A_2)
		});
	}

	// Token: 0x0600BEE1 RID: 48865 RVA: 0x0041D9D4 File Offset: 0x0041BBD4
	public static dl6 a(string A_0, Color A_1, string A_2, Color A_3, string A_4 = null, string A_5 = null)
	{
		return new dl6(new List<bph>
		{
			new bph(new d22(cq4.c(), A_1), A_0, A_4),
			new bph(new d22(cq4.c(), A_3), A_2, A_5)
		});
	}

	// Token: 0x0600BEE2 RID: 48866 RVA: 0x0041DA14 File Offset: 0x0041BC14
	public static dl6 a()
	{
		return cq4.a(null, Color.White, null);
	}

	// Token: 0x0600BEE3 RID: 48867 RVA: 0x0041DA28 File Offset: 0x0041BC28
	private static void h(ecs A_0, coh A_1)
	{
		dl6 dl = new dl6();
		if (A_1.Definition is x2)
		{
			dl.a.Add(new bph(new d22(cq4.d(), adi.ar), string.IsNullOrEmpty(A_1.Definition.bk()) ? "Unknown" : A_1.Definition.bk(), null));
		}
		else
		{
			dl.a.Add(new bph(new d22(cq4.d(), adi.ag[A_1.Definition.bc()]), string.IsNullOrEmpty(A_1.Definition.bk()) ? "Unknown" : A_1.Definition.bk(), null));
		}
		if (A_1.Stacks > 1)
		{
			dl.a.Add(new bph(new d22(cq4.d(), Color.White), string.Format(" ({0})", A_1.Stacks), null));
		}
		A_0.a.Add(dl);
		if ((string.IsNullOrEmpty(A_1.Definition.az()) || A_1.Definition.az() == "Unknown") && A_1.DefinitionProvider != null)
		{
			A_0.a.Add(new dl6(new bph[]
			{
				new bph(new d22(cq4.d(), Color.Gray), A_1.DefinitionProvider.ToString(), null)
			}));
		}
	}

	// Token: 0x0600BEE4 RID: 48868 RVA: 0x0041DBB4 File Offset: 0x0041BDB4
	private static void g(ecs A_0, coh A_1)
	{
		string text = A_1.Definition.tv();
		string text2 = dh9.c("Item_TypeName_" + text);
		if (!string.IsNullOrEmpty(text2))
		{
			text = text2;
		}
		cd1 cd = A_1 as cd1;
		if (cd != null && cd.TypedDefinition != null && cd.TypedDefinition.an.HasFlag(cum.b))
		{
			text = text + " " + dh9.c("Item_TypeSuffix_TwoHanded");
		}
		A_0.a.Add(cq4.a(text, Color.Yellow, null));
	}

	// Token: 0x0600BEE5 RID: 48869 RVA: 0x0041DC50 File Offset: 0x0041BE50
	private static void f(ecs A_0, coh A_1)
	{
		string text = A_1.Definition.bh();
		if (!string.IsNullOrEmpty(text))
		{
			if (A_0.a.Count > 0)
			{
				A_0.a.Add(cq4.a());
			}
			text = text.Replace("<br>", "\r\n");
			A_0.a.Add(cq4.a(text, cq4.c, null));
		}
	}

	// Token: 0x0600BEE6 RID: 48870 RVA: 0x0041DCC0 File Offset: 0x0041BEC0
	private static void m(ecs A_0, coh A_1, efk A_2)
	{
		string text = "";
		dj3 dj = A_1.Definition as dj3;
		if (dj != null && dj.a2().Count > 0 && !dj.m())
		{
			text = dh9.c("Item_Notification_CannotBeUsedInCombat");
		}
		if (A_1.MaxBattery > 0 && !A_1.Definition.bd())
		{
			if (!string.IsNullOrEmpty(text))
			{
				text = dh9.c("Item_Notification_CannotBeUsedOrRechargedInCombat");
			}
			else
			{
				text = dh9.c("Item_Notification_CannotBeRechargedInCombat");
			}
		}
		if (!string.IsNullOrEmpty(text))
		{
			Color a_;
			if (A_2.IsInCombat)
			{
				a_ = cq4.k;
			}
			else
			{
				a_ = cq4.d;
			}
			A_0.a.Add(cq4.a());
			A_0.a.Add(cq4.a(text, a_, null));
		}
	}

	// Token: 0x0600BEE7 RID: 48871 RVA: 0x0041DD98 File Offset: 0x0041BF98
	private static void a(ecs A_0, coh A_1, bool A_2, bool A_3)
	{
		bool flag = false;
		if (A_2 && A_1.Stacks > 1)
		{
			flag = true;
			A_0.a.Add(cq4.a());
			A_0.a.Add(cq4.a(dh9.c("InventoryNotes_ShiftClickToSplit"), Color.LightGray, null));
		}
		ps service = bpo.GetService<ps>();
		if (service != null && (service.ala() != null || service.ak9() != null))
		{
			if (!flag)
			{
				A_0.a.Add(cq4.a());
			}
			flag = true;
			A_0.a.Add(cq4.a(dh9.c("InventoryNotes_AltClickToTransfer"), Color.LightGray, null));
		}
		if (A_3)
		{
			etf service2 = bpo.GetService<etf>();
			if (service2 != null)
			{
				cb6 cb = service2.ar7();
				if (cb != null && cb.ahb(A_1))
				{
					if (!flag)
					{
						A_0.a.Add(cq4.a());
					}
					A_0.a.Add(cq4.a(dh9.c("InventoryNotes_DoubleClickBlueprint"), Color.LightGray, null));
					return;
				}
			}
			if (A_1 is a06 || A_1 is acz)
			{
				if (!flag)
				{
					A_0.a.Add(cq4.a());
				}
				A_0.a.Add(cq4.a(dh9.c("InventoryNotes_DoubleClickToEquip"), Color.LightGray, null));
			}
		}
	}

	// Token: 0x0600BEE8 RID: 48872 RVA: 0x0041DEF8 File Offset: 0x0041C0F8
	private static void e(ecs A_0, coh A_1)
	{
		if (A_1.Definition is eya)
		{
			eya eya = A_1.Definition as eya;
			if (eya.i() != null && eya.i().Count > 0)
			{
				A_0.a.Add(cq4.a());
				A_0.a.Add(cq4.a(dh9.c("Resistances") + ":", cq4.d, null));
				SortedDictionary<DamageType, du2> sortedDictionary = new SortedDictionary<DamageType, du2>();
				foreach (du2 du in eya.i())
				{
					sortedDictionary[du.b()] = du;
				}
				foreach (KeyValuePair<DamageType, du2> keyValuePair in sortedDictionary)
				{
					bph item = new bph(new d22(cq4.c(), adi.af[keyValuePair.Key]), string.Format("   {0}: {1}", dh9.a(keyValuePair.Key), keyValuePair.Value), null);
					dl6 dl = new dl6();
					dl.a.Add(item);
					A_0.a.Add(dl);
				}
			}
			c43 c = eya as c43;
			if (c != null && c.c() > 0.0 && c.b() > 0)
			{
				A_0.a.Add(cq4.a());
				try
				{
					A_0.a.Add(cq4.a(string.Format(dh9.c("ItemArmorBonuses_BlockChance"), (int)(c.c() * 100.0), c.b()), cq4.f, null));
				}
				catch
				{
				}
			}
			if (eya.f() != null && eya.f().Count > 0)
			{
				foreach (c3e c3e in eya.f())
				{
					A_0.a.Add(cq4.a());
					A_0.a.Add(cq4.a(c3e.xq(), cq4.f, null));
				}
			}
		}
	}

	// Token: 0x0600BEE9 RID: 48873 RVA: 0x0041E1A8 File Offset: 0x0041C3A8
	private static void l(ecs A_0, coh A_1, efk A_2)
	{
		eya eya = A_1.Definition as eya;
		if (eya != null)
		{
			if (eya.h() > 0.0)
			{
				A_0.a.Add(cq4.a());
				A_0.a.Add(cq4.a(dh9.c("Armorpenalty") + ": ", cq4.d, ((int)(eya.h() * 100.0)).ToString() + "%", cq4.k, null, null));
			}
			if (eya.g() > 0)
			{
				A_0.a.Add(cq4.a());
				bool flag = A_2 == null || A_2.BaseAbilities.Get<d3m>().g() >= eya.g();
				A_0.a.Add(cq4.a(dh9.c("MinimalStrengthL") + ": ", flag ? cq4.d : cq4.k, eya.g().ToString(), flag ? cq4.e : cq4.k, null, null));
			}
			c43 c = A_1.Definition as c43;
			if (c != null && c.a())
			{
				A_0.a.Add(cq4.a());
				if (A_2 != null)
				{
					bool flag2 = A_2.BaseAbilities.Get<d3m>().g() >= eya.g();
				}
				A_0.a.Add(cq4.a(dh9.c("ItemArmorBonuses_CannotWieldTwoHanded"), cq4.k, null));
			}
		}
	}

	// Token: 0x0600BEEA RID: 48874 RVA: 0x0041E358 File Offset: 0x0041C558
	private static void k(ecs A_0, coh A_1, efk A_2)
	{
		if (A_1.Definition is diz)
		{
			diz diz = A_1.Definition as diz;
			if (diz != null)
			{
				bool flag = false;
				if (diz.ar() != null && diz.ar().Count > 0)
				{
					flag = true;
					A_0.a.Add(cq4.a());
					foreach (d3e d3e in diz.ar())
					{
						bool flag2;
						if (A_2 == null)
						{
							flag2 = (A_2 == null);
						}
						else
						{
							bool? flag3 = A_2.a(d3e);
							if (flag3 != null)
							{
								flag2 = flag3.Value;
							}
							else
							{
								flag2 = (d3e.Negative || diz.a(A_2));
							}
						}
						if (d3e.Condition != null && !d3e.Condition.jh(new ll(A_2)))
						{
							if (d3e.ConditionalVisibility)
							{
								continue;
							}
							flag2 = false;
						}
						Color a_;
						if (d3e.Negative)
						{
							if (A_2 != null && !flag2)
							{
								a_ = new Color(175, 75, 75);
							}
							else
							{
								a_ = cq4.k;
							}
						}
						else if (A_2 != null && !flag2)
						{
							a_ = new Color(114, 141, 114);
						}
						else
						{
							a_ = cq4.f;
						}
						A_0.a.Add(cq4.a(dh9.c("Item_Equip") + ": " + d3e.ToString(), a_, null));
					}
				}
				if (diz.ao() != null && diz.ao().Count > 0)
				{
					foreach (wq wq in diz.ao())
					{
						if (!string.IsNullOrEmpty(wq.ToString()))
						{
							bool flag4;
							if (A_2 == null)
							{
								flag4 = (A_2 == null);
							}
							else
							{
								bool? flag5 = new bool?(A_2.a(wq));
								if (flag5 != null)
								{
									flag4 = flag5.Value;
								}
								else
								{
									flag4 = (wq.Negative || diz.a(A_2));
								}
							}
							if (!flag)
							{
								A_0.a.Add(cq4.a());
								flag = true;
							}
							Color a_2;
							if (wq.Negative)
							{
								if (A_2 != null && !flag4)
								{
									a_2 = new Color(141, 114, 114);
								}
								else
								{
									a_2 = cq4.k;
								}
							}
							else if (A_2 != null && !flag4)
							{
								a_2 = new Color(114, 141, 114);
							}
							else
							{
								a_2 = cq4.f;
							}
							A_0.a.Add(cq4.a(dh9.c("Item_Equip") + ": " + wq.ToString(), a_2, null));
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BEEB RID: 48875 RVA: 0x0041E694 File Offset: 0x0041C894
	public static int a(int A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		float num = 1f + 0.5f * (float)Math.Max(0, serviceOrThrow.aq1().b().g() - InterfaceElementSize2.Small);
		return (int)((float)A_0 * num);
	}

	// Token: 0x0600BEEC RID: 48876 RVA: 0x0041E6D4 File Offset: 0x0041C8D4
	private static void j(ecs A_0, coh A_1, efk A_2)
	{
		if (A_1.ItemEffects.Count > 0)
		{
			A_0.a.Add(cq4.a());
			A_0.a.Add(cq4.a(dh9.c("Item_TemporaryEffects") + ":", adi.u, null));
			foreach (dbj dbj in A_1.ItemEffects)
			{
				if (dbj != null)
				{
					string a_;
					if (dbj.ShowTicks)
					{
						a_ = string.Format("- {0} ({1}): ", dbj.Name, dbj.RemainingTicks);
					}
					else
					{
						a_ = string.Format("- {0}: ", dbj.Name);
					}
					A_0.a.Add(cq4.a(a_, adi.v, dbj.ae7(A_2, A_1), adi.u, null, null));
				}
			}
		}
	}

	// Token: 0x0600BEED RID: 48877 RVA: 0x0041E7DC File Offset: 0x0041C9DC
	private static void d(ecs A_0, coh A_1)
	{
		dng dng = A_1 as dng;
		if (dng != null)
		{
			string text = qv.b("Items\\Ammo/" + dng.TypedDefinition.b().ToString());
			object[] array = bgg.a(dng.TypedDefinition.b());
			if (array != null && array.Length != 0)
			{
				try
				{
					text = string.Format(text, array);
				}
				catch
				{
				}
			}
			if (!string.IsNullOrEmpty(text))
			{
				A_0.a.Add(cq4.a());
				A_0.a.Add(cq4.a("- " + text, cq4.l, null));
			}
			if (dng.TypedDefinition.a() != null && dng.TypedDefinition.a().Count > 0)
			{
				bool flag = false;
				foreach (edm edm in dng.TypedDefinition.a())
				{
					if (edm.Visible)
					{
						string text2 = edm.b();
						if (!string.IsNullOrWhiteSpace(text2))
						{
							if (!flag)
							{
								A_0.a.Add(cq4.a());
							}
							A_0.a.Add(cq4.a(dh9.c("Item_OnHit") + ": ", cq4.f, string.Format("{0}", text2), new Color(0, 150, 0), null, null));
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BEEE RID: 48878 RVA: 0x0041E98C File Offset: 0x0041CB8C
	private static void i(ecs A_0, coh A_1, efk A_2)
	{
		x2 x = A_1.Definition as x2;
		e3q e3q = A_2 as e3q;
		if (x != null && e3q != null)
		{
			int num;
			if (e3q.e() == ExperienceSystem.Classic)
			{
				num = c2h.c(x.a());
			}
			else
			{
				num = x.a();
			}
			A_0.a.Add(cq4.a());
			string a_;
			if (num > 4)
			{
				a_ = "Item_Oddity_PickUpM";
			}
			else if (num > 1)
			{
				a_ = "Item_Oddity_PickUpM4";
			}
			else
			{
				a_ = "Item_Oddity_PickUp";
			}
			string format = dh9.c(a_);
			try
			{
				A_0.a.Add(cq4.a(string.Format(format, num, x.c()), Color.DarkSeaGreen, null));
			}
			catch
			{
			}
			A_0.a.Add(cq4.a());
			int num2 = e3q.a(x.a5());
			Color a_2;
			if (num2 >= x.c())
			{
				a_2 = Color.OrangeRed;
			}
			else
			{
				a_2 = Color.DarkSeaGreen;
			}
			string a_3;
			if (num > 4)
			{
				a_3 = "Item_Oddity_StudiedM";
			}
			else if (num > 1)
			{
				a_3 = "Item_Oddity_StudiedM4";
			}
			else
			{
				a_3 = "Item_Oddity_Studied";
			}
			string format2 = dh9.c(a_3);
			try
			{
				A_0.a.Add(cq4.a(string.Format(format2, num2, x.c()), a_2, null));
			}
			catch
			{
			}
		}
	}

	// Token: 0x0600BEEF RID: 48879 RVA: 0x0041EB20 File Offset: 0x0041CD20
	private static void a(ecs A_0, coh A_1, efk A_2, c3n A_3)
	{
		if (A_1.Definition.a2().Count > 0)
		{
			bool flag = ke.a(A_2, A_1);
			for (int i = 0; i < A_1.Definition.a2().Count; i++)
			{
				aia aia = A_1.Definition.a2()[i];
				A_0.a.Add(cq4.a());
				if (aia.Value != null)
				{
					Color a_;
					Color a_2;
					if (!flag)
					{
						a_ = new Color(114, 141, 114);
						a_2 = cq4.j;
					}
					else if (A_3 != null && A_3 != aia.Value)
					{
						a_ = cq4.h;
						a_2 = cq4.j;
					}
					else
					{
						a_ = cq4.f;
						a_2 = cq4.i;
					}
					A_0.a.Add(cq4.a(dh9.c("Item_Use") + ": " + aia.Value.bp(new eoj(A_2, A_1, null)), a_, null));
					if (A_2 != null)
					{
						ehl ehl = aia.Value as ehl;
						eoj a_3 = new eoj(A_2, A_1, null);
						if (ehl != null && ehl.bn(a_3) == SpellTargetType.Self)
						{
							cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
							if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
							{
								a_3 = new eoj(A_2, A_1, serviceOrThrow.aqu().v().b());
							}
						}
						IEnumerable<cfd> enumerable = aia.Value.bq(a_3, aia.Value.PrimaryExecutionMode);
						int num = 0;
						foreach (cfd cfd in enumerable)
						{
							if (cfd.b > num)
							{
								num = cfd.b;
							}
						}
						string text = "";
						if (aia.Value.c3(a_3))
						{
							ehl ehl2 = aia.Value as ehl;
							if (ehl2 != null)
							{
								int num2 = ehl2.afh(a_3);
								if (num2 > 0)
								{
									text = string.Concat(new string[]
									{
										text,
										"(",
										dh9.c("AP"),
										": ",
										num2.ToString()
									});
								}
							}
						}
						else
						{
							ehl ehl3 = aia.Value as ehl;
							if (ehl3 != null)
							{
								int num3 = ehl3.n(a_3);
								if (num3 > 0)
								{
									text = string.Concat(new string[]
									{
										text,
										"(",
										dh9.c("UsageTimeL"),
										": ",
										Math.Round((double)num3 / 1000.0, 2).ToString(),
										dh9.c("SecondsLetter")
									});
								}
							}
						}
						if (num > 0)
						{
							if (string.IsNullOrEmpty(text))
							{
								text = "(";
							}
							else
							{
								text += "; ";
							}
							text = text + dh9.c("Cooldown") + ": " + l4.c((double)num, aia.Value.PrimaryExecutionMode == v5.a);
						}
						if (!string.IsNullOrEmpty(text))
						{
							text += ")";
							A_0.a.Add(cq4.a(text, a_, null));
						}
						ip ip = aia.Value.v(a_3);
						if (ip != null && ip.b > 0.0 && ip.a > 0.0)
						{
							A_0.a.Add(cq4.a(dh9.c("RemainingCooldownL") + ": " + cq4.a(ip.a, dz6.e()), a_2, null));
						}
						IList<brl> list = aia.Value.j0();
						if (list != null && list.Count > 0)
						{
							A_0.a.Add(cq4.a());
							A_0.a.Add(cq4.a(dh9.c("Requires") + ":", cq4.d, null));
							foreach (brl brl in list)
							{
								Color a_4;
								if (brl.oh(A_2))
								{
									a_4 = cq4.e;
								}
								else
								{
									a_4 = cq4.k;
								}
								A_0.a.Add(cq4.a("   " + brl.ToString(), a_4, null));
							}
						}
					}
					if (aia.Value is a0y || aia.Value is ew2)
					{
						string text2 = qv.b("Items\\Ammo/ThrowingKnife");
						if (!string.IsNullOrEmpty(text2))
						{
							A_0.a.Add(cq4.a());
							A_0.a.Add(cq4.a(text2, cq4.l, null));
						}
					}
				}
				else
				{
					A_0.a.Add(cq4.a("!Failed to retrieve capability!", Color.Red, null));
				}
			}
		}
	}

	// Token: 0x0600BEF0 RID: 48880 RVA: 0x0041F080 File Offset: 0x0041D280
	private static void c(ecs A_0, coh A_1)
	{
		if (A_1.Definition is b3n)
		{
			b3n b3n = A_1.Definition as b3n;
			A_0.a.Add(cq4.a());
			A_0.a.Add(cq4.a(dh9.c("Shield_Capacity") + ": ", cq4.d, ((int)((double)A_1.MaxBattery * b3n.e())).ToString(), cq4.e, null, null));
			A_0.a.Add(cq4.a(dh9.c("Shield_ConversionRate") + ": ", cq4.d, b3n.e().ToString("0.0"), cq4.e, null, null));
			A_0.a.Add(cq4.a(dh9.c("Shield_DissipationRate") + ": ", cq4.d, (b3n.b() * 100.0).ToString("0.0") + "%", cq4.e, null, null));
			if (b3n.a() != null && b3n.a().Count > 0)
			{
				A_0.a.Add(cq4.a());
				A_0.a.Add(cq4.a(dh9.c("Shield_Shielding") + ":", cq4.d, null));
				foreach (z3 z in b3n.a())
				{
					A_0.a.Add(cq4.a(string.Format("   {0}: {1}", dh9.a(z.ImpactSpeed), z.Value), adi.ah[z.ImpactSpeed], null));
				}
			}
		}
	}

	// Token: 0x0600BEF1 RID: 48881 RVA: 0x0041F280 File Offset: 0x0041D480
	private static void h(ecs A_0, coh A_1, efk A_2)
	{
		agt agt = A_1 as agt;
		if (agt != null && agt.fu() != null)
		{
			cq4.b b = new cq4.b(A_0);
			if (agt.fu().l() != 0)
			{
				b.a();
				A_0.a.Add(cq4.a(dh9.c("Vehicle_Part_PartSize") + ": ", cq4.d, agt.fu().l().ToString(), cq4.e, null, null));
			}
			eqg eqg = agt.fu() as eqg;
			if (eqg != null)
			{
				b.a();
				A_0.a.Add(cq4.a(dh9.c("Vehicle_Part_Power") + ": ", cq4.d, eqg.b().ToString(), cq4.e, null, null));
				A_0.a.Add(cq4.a(dh9.c("Vehicle_Part_ConsumptionRatio") + ": ", cq4.d, Convert.ToInt32(eqg.d() * 100.0).ToString() + "%", cq4.e, null, null));
			}
			dv2 dv = agt.fu() as dv2;
			if (dv != null)
			{
				b.a();
				A_0.a.Add(cq4.a(dh9.c("Vehicle_Part_Stability") + ": ", cq4.d, "+" + Convert.ToInt32(dv.a() * 100.0).ToString() + "%", cq4.e, null, null));
			}
			if (agt.fu().k().Count > 0)
			{
				A_0.a.Add(cq4.a());
				A_0.a.Add(cq4.a(dh9.c("Vehicle_Part_SpecialAbilities") + ":", cq4.d, null));
				foreach (aia aia in agt.fu().k())
				{
					if (aia.Value != null)
					{
						A_0.a.Add(cq4.a(string.Format("- {0}: {1}", aia.Value.LocalizedName, aia.Value.bp(new eoj(A_2, A_1, null))), cq4.f, null));
					}
				}
			}
			if (agt.fu().j())
			{
				A_0.a.Add(cq4.a());
				A_0.a.Add(cq4.a(dh9.c("Vehicle_Part_Broken"), Color.Red, null));
			}
		}
	}

	// Token: 0x0600BEF2 RID: 48882 RVA: 0x0041F554 File Offset: 0x0041D754
	private static void g(ecs A_0, coh A_1, efk A_2)
	{
		cd1 cd = A_1 as cd1;
		bke bke = A_1.Definition as bke;
		if (bke != null && cd != null)
		{
			A_0.a.Add(cq4.a());
			if (bke.l() != null && bke.l().Count > 0)
			{
				if (bke.l().Count > 1)
				{
					int count = A_0.a.Count;
					int num = 0;
					int num2 = 0;
					foreach (a1q a1q in bke.l())
					{
						A_0.a.Add(cq4.a(string.Format("   {0}: {1}-{2}", dh9.a(a1q.DamageType), a1q.LowerBoundary, a1q.UpperBoundary), adi.af[a1q.DamageType], null));
						num2 += a1q.UpperBoundary;
						num += a1q.LowerBoundary;
					}
					A_0.a.Insert(count, cq4.a(string.Format(dh9.c("Damage") + ": {0}-{1}", num, num2), Color.White, null));
				}
				else
				{
					a1q a1q2 = Enumerable.First<a1q>(bke.l());
					dl6 item = new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), Color.White), string.Format(dh9.c("Damage") + ": {0}-{1}", a1q2.LowerBoundary, a1q2.UpperBoundary), null),
						new bph(new d22(cq4.c(), adi.af[a1q2.DamageType]), string.Format(" ({0})", dh9.a(a1q2.DamageType)), null)
					});
					A_0.a.Add(item);
				}
				A_0.a.Add(cq4.a());
			}
			A_0.a.Add(cq4.a(dh9.c("Item_Weapon_ImpactSpeed") + ": ", cq4.d, bke.c().ToString().a(), adi.ah[bke.c()], null, null));
			A_0.a.Add(cq4.a(dh9.c("Item_Weapon_BaseActionPoints") + ": ", cq4.d, bke.v().ToString() + " " + dh9.c("AP"), cq4.e, null, null));
			dl6 dl;
			if (bke.ad() == as3.bk)
			{
				if (bke.ah() > 0)
				{
					dl = cq4.a(dh9.c("Range") + ": ", cq4.d, string.Format(dh9.c("ExtendedMelee") + " ({0})", bke.ah()), cq4.e, null, null);
				}
				else
				{
					dl = cq4.a(dh9.c("Range") + ": ", cq4.d, dh9.c("Melee"), cq4.e, null, null);
				}
			}
			else
			{
				dl = cq4.a(dh9.c("Range") + ": ", cq4.d, bke.ad().ToString(), cq4.e, null, null);
				if (bke.h() > 0f && bke.ad() != bke.h())
				{
					dl.a.AddRange(cq4.a(" (" + dh9.c("Range_Optimal") + ": ", cq4.d, bke.h().ToString(), cq4.e, null, null).a);
					dl.a.Add(cq4.a(")", cq4.d, null).a[0]);
				}
			}
			if (bke.x() != null)
			{
				A_0.a.Add(cq4.a(dh9.c("Item_Weapon_SpreadAngle") + ": ", cq4.d, bke.x().Value.ToString(), cq4.e, null, null));
			}
			A_0.a.Add(dl);
			if (bke.ab() != 0.0)
			{
				A_0.a.Add(cq4.a(dh9.c("Item_Weapon_Precision") + ": ", cq4.d, ((bke.ab() > 0.0) ? "+" : "") + Convert.ToInt32(bke.ab() * 100.0).ToString() + "%", (bke.ab() < 0.0) ? cq4.k : cq4.e, null, null));
			}
			if (bke.z() > 0f)
			{
				A_0.a.Add(cq4.a(dh9.c("Item_Weapon_CloseQuartersPrecision") + ": ", cq4.d, "-" + Convert.ToInt32(bke.z() * 100f).ToString() + "%", cq4.k, null, null));
			}
			if (bke.aj() > 0.0)
			{
				A_0.a.Add(cq4.a(dh9.c("Item_Weapon_MoveAndShootPrecision") + ": ", cq4.d, "-" + Convert.ToInt32(bke.aj() * 100.0).ToString() + "%", cq4.k, null, null));
			}
			if (bke.s() != 0.0)
			{
				A_0.a.Add(cq4.a(dh9.c("Item_Weapon_BurstPrecision") + ": ", cq4.d, ((bke.s() > 0.0) ? "+" : "") + ((int)(bke.s() * 100.0)).ToString() + "%", (bke.s() < 0.0) ? cq4.k : cq4.e, null, null));
			}
			if (bke.d() > 0)
			{
				A_0.a.Add(cq4.a(dh9.c("Item_Weapon_BurstShots") + ": +", cq4.d, bke.d().ToString(), cq4.e, null, null));
			}
			else if (bke.d() < 0)
			{
				A_0.a.Add(cq4.a(dh9.c("Item_Weapon_BurstShots") + ": ", cq4.d, bke.d().ToString(), cq4.k, null, null));
			}
			A_0.a.Add(cq4.a(dh9.c("CombatStatsWindow_Label_Criticalchance") + ": ", cq4.d, Convert.ToInt32(bke.ai() * 100.0).ToString() + "%", cq4.e, null, null));
			A_0.a.Add(cq4.a(dh9.c("CombatStatsWindow_Label_Criticaldamagebonus") + ": ", cq4.d, Convert.ToInt32(bke.y() * 100.0).ToString() + "%", cq4.e, null, null));
			if (bke.i() > 0)
			{
				A_0.a.Add(cq4.a());
				bool flag = A_2 == null || A_2.BaseAbilities.Get<d3m>().g() >= bke.i();
				A_0.a.Add(cq4.a(dh9.c("MinimalStrengthL") + ": ", flag ? cq4.d : cq4.k, bke.i().ToString(), flag ? cq4.e : cq4.k, null, null));
			}
			int num3 = euf.c(bke);
			if (num3 > 0)
			{
				bool flag2 = A_2 == null || euf.a(A_2, bke.e(), false) >= (double)num3;
				A_0.a.Add(cq4.a(dh9.c("Item_Weapon_MinimalWeaponSkill") + ": ", flag2 ? cq4.d : cq4.k, num3.ToString(), flag2 ? cq4.e : cq4.k, null, null));
			}
			double num4 = euf.s(A_1 as cd1);
			if (num4 > 0.0)
			{
				try
				{
					A_0.a.Add(cq4.a());
					A_0.a.Add(cq4.a(string.Format(dh9.c("Item_Weapon_ShieldBypass"), Convert.ToInt32(num4 * 100.0)), cq4.f, null));
				}
				catch
				{
				}
			}
			if (bke.an.HasFlag(cum.b))
			{
				A_0.a.Add(cq4.a());
				A_0.a.Add(cq4.a(dh9.c("Item_Weapon_RequiresBothHands"), new Color(255, 100, 0), null));
			}
			WeaponSubtype? weaponSubtype = euf.d(bke);
			if (bke.aa() != null && bke.aa().Count > 0)
			{
				string str;
				if (euf.b(bke))
				{
					str = dh9.c("Item_Weapon_OnAttack");
				}
				else
				{
					str = dh9.c("Item_Weapon_OnShoot");
				}
				bool flag3 = false;
				foreach (edm edm in bke.aa())
				{
					if (edm.Visible && edm.a())
					{
						string text = edm.b();
						if (!string.IsNullOrWhiteSpace(text))
						{
							if (!flag3)
							{
								A_0.a.Add(cq4.a());
							}
							A_0.a.Add(cq4.a(str + ": ", cq4.f, text, new Color(0, 150, 0), null, null));
						}
					}
				}
			}
			if (bke.aa() != null && bke.aa().Count > 0)
			{
				bool flag4 = false;
				foreach (edm edm2 in bke.aa())
				{
					if (edm2.Visible && !edm2.a())
					{
						string text2 = edm2.b();
						if (!string.IsNullOrWhiteSpace(text2))
						{
							if (!flag4)
							{
								A_0.a.Add(cq4.a());
							}
							A_0.a.Add(cq4.a(dh9.c("Item_Weapon_OnHit") + ": ", cq4.f, text2, new Color(0, 150, 0), null, null));
						}
					}
				}
			}
			if (bke.ak() == AmmoType.Energy)
			{
				A_0.a.Add(cq4.a());
				A_0.a.Add(cq4.a(dh9.c("Item_Weapon_EnergyUsagePerShot") + ": ", cq4.d, (bke.k() > 0.0) ? bke.k().ToString() : dh9.c("Item_Weapon_EnergyUsagePerShot_None"), cq4.f, null, null));
			}
			else
			{
				if (eub.f(bke.ak()) || eub.d(bke.ak()))
				{
					dh0 dh = eub.h(bke.ak());
					if (dh == null)
					{
						goto IL_F26;
					}
					A_0.a.Add(cq4.a());
					A_0.a.Add(cq4.a(dh9.c("Item_Weapon_AmmoType") + ": ", cq4.d, cq4.a(dh.a + ""), dh.b, null, null));
					if (bke.f() <= 0)
					{
						goto IL_F26;
					}
					A_0.a.Add(cq4.a(dh9.c("Item_Weapon_MagazineCapacity") + ": ", cq4.d, bke.f().ToString(), cq4.e, null, null));
					if (bke.r() != 1.0)
					{
						A_0.a.Add(cq4.a(dh9.c("Item_Weapon_ReloadingCost") + ": ", cq4.d, Convert.ToInt32(bke.r() * 100.0).ToString() + "%", cq4.e, null, null));
					}
					if (cd.LoadedAmmo == null || cd.LoadedAmmo.Count <= 0)
					{
						goto IL_F26;
					}
					A_0.a.Add(cq4.a());
					A_0.a.Add(cq4.a(dh9.c("Item_Weapon_Loaded") + string.Format(" ({0} / {1}): ", cd.LoadedAmmo.Count, bke.f()), cq4.d, null));
					using (Dictionary<AmmoType, int>.Enumerator enumerator3 = eub.d(cd).GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							KeyValuePair<AmmoType, int> keyValuePair = enumerator3.Current;
							dh0 dh2 = eub.h(keyValuePair.Key);
							if (dh2 != null)
							{
								string text3 = dh2.a + ((keyValuePair.Value > 1) ? "" : "");
								text3 = cq4.a(text3);
								A_0.a.Add(cq4.a(string.Format("- {0} x {1}", keyValuePair.Value, text3), dh2.b, null));
							}
						}
						goto IL_F26;
					}
				}
				string text4 = qv.b("Items\\Ammo/" + bke.ak().ToString());
				if (!string.IsNullOrEmpty(text4))
				{
					A_0.a.Add(cq4.a());
					A_0.a.Add(cq4.a(text4, cq4.l, null));
				}
			}
			IL_F26:
			double num5;
			int num6;
			qw.a(bke, null, out num5, out num6);
			if (num5 > 0.0)
			{
				A_0.a.Add(cq4.a());
				try
				{
					if (num6 > 0)
					{
						A_0.a.Add(cq4.a(string.Format(dh9.c("Item_Weapon_StrengthScaling1"), Convert.ToInt32(num5 * 100.0), num6), cq4.l, null));
					}
					else
					{
						A_0.a.Add(cq4.a(string.Format(dh9.c("Item_Weapon_StrengthScaling"), Convert.ToInt32(num5 * 100.0)), cq4.l, null));
					}
				}
				catch
				{
				}
			}
			if (weaponSubtype != null)
			{
				string text5 = qv.b("Items\\WeaponSubtypes/" + weaponSubtype.Value.ToString());
				if (string.IsNullOrEmpty(text5) && !string.IsNullOrEmpty(bke.b()))
				{
					text5 = qv.b("Items\\WeaponSubtypes/" + bke.b());
				}
				if (!string.IsNullOrEmpty(text5))
				{
					A_0.a.Add(cq4.a());
					A_0.a.Add(cq4.a(text5, cq4.l, null));
				}
			}
			if (!string.IsNullOrEmpty(bke.b()))
			{
				dkf dkf = ckf.a(bke.b()) as dkf;
				if (dkf != null)
				{
					string text6 = dkf.pc(cd);
					if (!string.IsNullOrEmpty(text6))
					{
						A_0.a.Add(cq4.a());
						A_0.a.Add(cq4.a(text6, cq4.m, null));
					}
				}
			}
			for (int i = 0; i < bke.n().Count; i++)
			{
				A_0.a.Add(cq4.a());
				A_0.a.Add(cq4.a(bke.n()[i].h0(cd) + ".", cq4.m, null));
			}
			if (bke.e() == btz.a && bke.ae() != null && euf.g(bke.ae().Value))
			{
				A_0.a.Add(cq4.a());
				A_0.a.Add(cq4.a(string.Format(dh9.c("Item_Weapon_EvasionIgnore"), Convert.ToInt32(as3.s * 100.0)), cq4.l, null));
			}
		}
	}

	// Token: 0x0600BEF3 RID: 48883 RVA: 0x00420784 File Offset: 0x0041E984
	public static string a(string A_0)
	{
		if (aji.a != null)
		{
			string text = qv.b("AmmoDisplayInfo/" + A_0);
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
		}
		return A_0;
	}

	// Token: 0x0600BEF4 RID: 48884 RVA: 0x004207BC File Offset: 0x0041E9BC
	private static void f(ecs A_0, coh A_1, efk A_2)
	{
		fv fv = A_1 as fv;
		if (fv != null)
		{
			if (fv.QualityLevel > 0)
			{
				A_0.a.Add(cq4.a());
				A_0.a.Add(cq4.a(dh9.c("Item_Component_Quality") + ": ", cq4.d, fv.QualityLevel.ToString(), cq4.e, null, null));
			}
			Dictionary<string, int> dictionary = fv.a();
			if (dictionary != null && dictionary.Count > 0)
			{
				A_0.a.Add(cq4.a());
				A_0.a.Add(cq4.a(dh9.c("Item_Component_RequiredCraftingSkills") + ":", Color.White, null));
				foreach (KeyValuePair<string, int> keyValuePair in dictionary)
				{
					Color a_ = cq4.e;
					if (A_2 != null)
					{
						csn csn = A_2.Skills.a(keyValuePair.Key);
						if (csn != null && csn.g() < keyValuePair.Value)
						{
							a_ = cq4.k;
						}
					}
					string text = keyValuePair.Key;
					string text2 = dh9.a(typeof(SkillEnum).Name, text);
					if (!string.IsNullOrEmpty(text2))
					{
						text = text2;
					}
					A_0.a.Add(cq4.a("   " + text + " ", cq4.d, keyValuePair.Value.ToString(), a_, null, null));
				}
			}
		}
	}

	// Token: 0x0600BEF5 RID: 48885 RVA: 0x00420974 File Offset: 0x0041EB74
	private static void e(ecs A_0, coh A_1, efk A_2)
	{
		c6m c6m = A_1.Definition as c6m;
		if (c6m != null)
		{
			cq4.a(A_0, c6m, A_2);
		}
	}

	// Token: 0x0600BEF6 RID: 48886 RVA: 0x0042099C File Offset: 0x0041EB9C
	private static void a(ecs A_0, c6m A_1, efk A_2)
	{
		if (A_1 != null)
		{
			List<brl> list = A_1.j0();
			if (list != null && list.Count > 0)
			{
				A_0.a.Add(cq4.a());
				A_0.a.Add(cq4.a(dh9.c("Item_Requirements") + ":", Color.White, null));
				foreach (brl brl in list)
				{
					Color a_;
					if (A_2 != null && !brl.oh(A_2))
					{
						a_ = cq4.k;
					}
					else
					{
						a_ = cq4.e;
					}
					A_0.a.Add(cq4.a("  - " + brl.ToString(), a_, null));
				}
			}
		}
	}

	// Token: 0x0600BEF7 RID: 48887 RVA: 0x00420A88 File Offset: 0x0041EC88
	private static void b(ecs A_0, coh A_1)
	{
		if (A_1.MaxBattery > 0)
		{
			A_0.a.Add(cq4.a());
			A_0.a.Add(new dl6
			{
				a = new List<bph>
				{
					new bph(new d22(cq4.c(), cq4.d), dh9.c("Item_BatteryEnergy") + ": ", null),
					new bph(new d22(cq4.c(), cq4.b(A_1)), Math.Ceiling(A_1.Battery).ToString(), null),
					new bph(new d22(cq4.c(), cq4.f), " / " + A_1.MaxBattery.ToString(), null)
				}
			});
		}
	}

	// Token: 0x0600BEF8 RID: 48888 RVA: 0x00420B60 File Offset: 0x0041ED60
	private static void a(ecs A_0, coh A_1)
	{
		bool flag = false;
		if (!A_1.Definition.a9())
		{
			flag = true;
			A_0.a.Add(cq4.a());
			A_0.a.Add(new dl6
			{
				a = new List<bph>
				{
					new bph(new d22(cq4.c(), cq4.d), dh9.c("Item_Durability") + ": ", null),
					new bph(new d22(cq4.c(), cq4.a(A_1)), ((int)A_1.Durability).ToString(), null),
					new bph(new d22(cq4.c(), cq4.e), string.Format(" / {0} ({1})", A_1.MaxDurability, dh9.b(A_1.Definition.ay())), null)
				}
			});
			cd1 cd = A_1 as cd1;
			if (cd != null && cd.TypedDefinition.ao)
			{
				A_0.a.Add(cq4.a(dh9.c("Item_Weapon_Disposable"), cq4.m, null));
			}
		}
		List<coh> classPropertyValue = A_1.Definition.a7().GetClassPropertyValue<List<coh>>("Components");
		if (classPropertyValue != null && classPropertyValue.Count > 0)
		{
			if (!flag)
			{
				A_0.a.Add(cq4.a());
			}
			A_0.a.Add(new dl6
			{
				a = new List<bph>
				{
					new bph(new d22(cq4.c(), cq4.l), dh9.c("Item_CanBeDisassembled"), null)
				}
			});
		}
	}

	// Token: 0x0600BEF9 RID: 48889 RVA: 0x00420D08 File Offset: 0x0041EF08
	private static void a(ecs A_0, coh A_1, bool A_2, eg A_3, double? A_4)
	{
		if (A_1.Weight > 0.0)
		{
			A_0.a.Add(cq4.a());
			if (A_1.Stacks > 1)
			{
				A_0.a.Add(cq4.a(string.Format(dh9.c("Item_Weight") + ": {0} ({1})", A_1.Weight.ToString("0.00"), A_1.SingleItemWeight.ToString("0.00")), Color.BurlyWood, null));
			}
			else
			{
				A_0.a.Add(cq4.a(string.Format(dh9.c("Item_Weight") + ": {0}", A_1.Weight.ToString("0.00")), Color.BurlyWood, null));
			}
		}
		if (A_1.ItemValue > 0)
		{
			A_0.a.Add(cq4.a());
			if (A_3 != null && !A_3.aqe(A_1))
			{
				A_0.a.Add(cq4.a(dh9.c("Item_MerchantWontBuy"), Color.Goldenrod, null));
				return;
			}
			if (A_1.Stacks > 1)
			{
				if (A_4 != null)
				{
					double num = Math.Round((double)A_1.SingleItemValue * A_4.Value, 2);
					int num2 = Convert.ToInt32((double)A_1.ItemValue * A_4.Value);
					A_0.a.Add(cq4.a(dh9.c("Item_Value") + string.Format(": {0} ({1})", num2, num), Color.Gold, null));
				}
				else
				{
					A_0.a.Add(cq4.a(dh9.c("Item_Value") + string.Format(": {0} ({1})", A_1.ItemValue, A_1.SingleItemValue), Color.Gold, null));
				}
			}
			else if (A_4 != null)
			{
				int num3 = Convert.ToInt32((double)A_1.ItemValue * A_4.Value);
				A_0.a.Add(cq4.a(dh9.c("Item_Value") + string.Format(": {0}", num3), Color.Gold, null));
			}
			else
			{
				A_0.a.Add(cq4.a(dh9.c("Item_Value") + string.Format(": {0}", A_1.ItemValue), Color.Gold, null));
			}
			if (A_1.CustomProperties.GetPrimitivePropertyValue<bool>(vo.h, new bool?(false)).Value)
			{
				A_0.a.Add(cq4.a());
				A_0.a.Add(cq4.a(dh9.c("Item_SpecialMerchandise"), Color.Goldenrod, null));
				return;
			}
		}
		else if (A_2)
		{
			A_0.a.Add(cq4.a());
			A_0.a.Add(cq4.a(dh9.c("Item_CannotBeSold"), Color.Goldenrod, null));
		}
	}

	// Token: 0x0600BEFA RID: 48890 RVA: 0x00421020 File Offset: 0x0041F220
	private static void d(ecs A_0, coh A_1, efk A_2)
	{
		a06 a = A_1 as a06;
		if (a != null && a.fu() != null && a.fu().@as().Count > 0)
		{
			A_0.a.Add(cq4.a());
			A_0.a.Add(cq4.a(dh9.c("Item_SpecialAbilities") + ":", cq4.d, null));
			bool flag = ke.a(A_2, a);
			foreach (aia aia in a.fu().@as())
			{
				if (aia.Value != null)
				{
					eoj a_ = new eoj(A_2, A_1, null);
					dl6 dl = new dl6();
					dl.a.Add(new bph(new d22(cq4.c(), flag ? cq4.f : new Color(114, 141, 114)), aia.Value.LocalizedName + ": ", aia.Value.bm(a_)));
					string text = aia.Value.bp(a_);
					d22 a_2 = new d22(cq4.c(), flag ? new Color(0, 150, 0) : new Color(114, 141, 114));
					if (!string.IsNullOrEmpty(text))
					{
						foreach (string text2 in d05.a(text))
						{
							if (string.IsNullOrEmpty(text2))
							{
								dl.a.Add(new bph(a_2, " ", null));
							}
							else
							{
								dl.a.Add(new bph(a_2, text2, null));
							}
							A_0.a.Add(dl);
							dl = new dl6();
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BEFB RID: 48891 RVA: 0x00421238 File Offset: 0x0041F438
	private static void c(ecs A_0, coh A_1, efk A_2)
	{
		e3q e3q = A_2 as e3q;
		if (e3q != null)
		{
			avz avz = A_1.Definition as avz;
			if (avz != null)
			{
				cq4.a a = new cq4.a();
				a.a = d79.a(avz.b());
				if (a.a != null && Enumerable.Any<bdc>(e3q.d(), new Func<bdc, bool>(a.a)))
				{
					A_0.a.Add(cq4.a());
					A_0.a.Add(cq4.a(dh9.c("Item_BlueprintAlreadyKnown"), Color.OrangeRed, null));
				}
			}
			eml eml = A_1.Definition as eml;
			if (eml != null)
			{
				c3n c3n = dgk.a(eml.b());
				if (c3n != null && e3q.PsiAbilities.c(c3n))
				{
					A_0.a.Add(cq4.a());
					A_0.a.Add(cq4.a(dh9.c("Item_MentorAlreadyKnown"), Color.OrangeRed, null));
				}
			}
		}
	}

	// Token: 0x0600BEFC RID: 48892 RVA: 0x0042133C File Offset: 0x0041F53C
	private static void b(ecs A_0, coh A_1, efk A_2)
	{
		c4j c4j = A_1.Definition as c4j;
		if (c4j != null)
		{
			A_0.a.Add(cq4.a());
			bool flag = A_2 == null || A_2.Skills.Get<c0b>().g() >= c4j.b();
			A_0.a.Add(cq4.a(dh9.c("Item_Trap_RequiredSkill") + ": ", flag ? cq4.d : cq4.k, c4j.b().ToString(), flag ? cq4.e : cq4.k, null, null));
			A_0.a.Add(cq4.a(dh9.c("Item_Trap_DetectionDifficulty") + ": ", cq4.d, ((int)(c4j.a() * 100.0)).ToString() + "%", cq4.e, null, null));
		}
	}

	// Token: 0x0600BEFD RID: 48893 RVA: 0x00421444 File Offset: 0x0041F644
	private static void a(ecs A_0, coh A_1, efk A_2)
	{
		if (A_1.Definition.a5() == "plot.xpbl_navcom")
		{
			string text = e3m.a();
			A_0.a.Add(cq4.a());
			if (text != null)
			{
				A_0.a.Add(cq4.a(dh9.c("Item_BlackSea_CurrentGridSquare") + ": ", cq4.f, text, Color.Cyan, null, null));
				return;
			}
			A_0.a.Add(cq4.a(dh9.c("Item_BlackSea_CurrentGridSquare") + ": ", cq4.f, dh9.c("Item_BlackSea_CurrentGridSquare_Unknown"), Color.DodgerBlue, null, null));
		}
	}

	// Token: 0x0600BEFE RID: 48894 RVA: 0x004214F4 File Offset: 0x0041F6F4
	private static Color b(coh A_0)
	{
		double num = A_0.Battery / (double)A_0.MaxBattery;
		if (num > 0.5)
		{
			return cq4.f;
		}
		if (num > 0.0)
		{
			return Color.Orange;
		}
		return Color.Red;
	}

	// Token: 0x0600BEFF RID: 48895 RVA: 0x00421540 File Offset: 0x0041F740
	private static Color a(coh A_0)
	{
		double num = Math.Min(1.0, A_0.Durability / (double)A_0.MaxDurability);
		if (num > dwh.h)
		{
			return cq4.e;
		}
		if (num > dwh.i)
		{
			return Color.Orange;
		}
		return Color.Red;
	}

	// Token: 0x04004497 RID: 17559
	private const int a = 3600000;

	// Token: 0x04004498 RID: 17560
	private const int b = 60000;

	// Token: 0x04004499 RID: 17561
	private static readonly Color c = Color.Gray;

	// Token: 0x0400449A RID: 17562
	private static readonly Color d = Color.LightGray;

	// Token: 0x0400449B RID: 17563
	private static readonly Color e = Color.White;

	// Token: 0x0400449C RID: 17564
	private static readonly Color f = new Color(0, 255, 0);

	// Token: 0x0400449D RID: 17565
	private static readonly Color g = Color.DarkGray;

	// Token: 0x0400449E RID: 17566
	private static readonly Color h = new Color(0, 125, 0);

	// Token: 0x0400449F RID: 17567
	private static readonly Color i = new Color(255, 0, 0);

	// Token: 0x040044A0 RID: 17568
	private static readonly Color j = new Color(125, 0, 0);

	// Token: 0x040044A1 RID: 17569
	private static readonly Color k = new Color(255, 0, 0);

	// Token: 0x040044A2 RID: 17570
	private static readonly Color l = Color.Orange;

	// Token: 0x040044A3 RID: 17571
	private static readonly Color m = new Color(255, 100, 0, 255);

	// Token: 0x02001FC0 RID: 8128
	private sealed class b
	{
		// Token: 0x0600BF01 RID: 48897 RVA: 0x0042163C File Offset: 0x0041F83C
		public b(ecs A_0)
		{
			this.b = A_0;
		}

		// Token: 0x0600BF02 RID: 48898 RVA: 0x0042164C File Offset: 0x0041F84C
		public void a()
		{
			if (!this.a)
			{
				this.b.a.Add(cq4.a());
				this.a = true;
			}
		}

		// Token: 0x040044A4 RID: 17572
		private bool a;

		// Token: 0x040044A5 RID: 17573
		private ecs b;
	}

	// Token: 0x02001FC1 RID: 8129
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x0600BF04 RID: 48900 RVA: 0x00421680 File Offset: 0x0041F880
		internal bool a(bdc A_0)
		{
			return A_0.ao() == this.a;
		}

		// Token: 0x040044A6 RID: 17574
		public cwp a;
	}
}
