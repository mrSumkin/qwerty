using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001C08 RID: 7176
public static class euf
{
	// Token: 0x06009D03 RID: 40195 RVA: 0x003DABA0 File Offset: 0x003D8DA0
	public static double a(efk A_0, btz A_1)
	{
		double num = 0.0;
		if (A_1 == btz.g && A_0.BaseAbilities.Dexterity > 5)
		{
			num += (double)(A_0.BaseAbilities.Dexterity - 5) * 0.01;
		}
		if (A_0 != null && !(A_0 is e3q))
		{
			num += Convert.ToDouble(euf.b().NpcCritChanceBonus);
		}
		return num;
	}

	// Token: 0x06009D04 RID: 40196 RVA: 0x003DAC10 File Offset: 0x003D8E10
	public static GameDifficultySettings b()
	{
		bu6 service = bpo.GetService<bu6>();
		if (service != null)
		{
			return service.ar2();
		}
		return aiy.cp[1];
	}

	// Token: 0x06009D05 RID: 40197 RVA: 0x003DAC3C File Offset: 0x003D8E3C
	public static double s(cd1 A_0)
	{
		if (A_0 != null && A_0.TypedDefinition != null)
		{
			if (A_0.TypedDefinition.af() != null)
			{
				return A_0.TypedDefinition.af().Value;
			}
			if (euf.o(A_0))
			{
				return as3.bl;
			}
			if (euf.n(A_0))
			{
				return as3.bm;
			}
			WeaponSubtype? weaponSubtype = euf.d(A_0.TypedDefinition);
			if (weaponSubtype != null && weaponSubtype.Value / WeaponSubtype.Knife == WeaponSubtype.Pistol_5)
			{
				return as3.bn;
			}
		}
		return 0.0;
	}

	// Token: 0x06009D06 RID: 40198 RVA: 0x003DACE4 File Offset: 0x003D8EE4
	public static bool t(efk A_0)
	{
		return A_0 != null && A_0.Vehicle != null && (A_0.Vehicle.y() == bws.b || A_0.Vehicle.y() == bws.a);
	}

	// Token: 0x06009D07 RID: 40199 RVA: 0x003DAD28 File Offset: 0x003D8F28
	public static bool r(cd1 A_0)
	{
		return euf.h(A_0.TypedDefinition);
	}

	// Token: 0x06009D08 RID: 40200 RVA: 0x003DAD38 File Offset: 0x003D8F38
	public static bool h(bke A_0)
	{
		return A_0.ak() >= AmmoType.Vial_Acid && A_0.ak() <= AmmoType.Vial_Incendiary;
	}

	// Token: 0x06009D09 RID: 40201 RVA: 0x003DAD5C File Offset: 0x003D8F5C
	public static bool q(cd1 A_0)
	{
		return euf.g(A_0.TypedDefinition);
	}

	// Token: 0x06009D0A RID: 40202 RVA: 0x003DAD6C File Offset: 0x003D8F6C
	public static bool g(bke A_0)
	{
		WeaponSubtype? weaponSubtype = euf.d(A_0);
		return weaponSubtype != null && (weaponSubtype.GetValueOrDefault() == WeaponSubtype.Pistol_Laser || weaponSubtype.GetValueOrDefault() == WeaponSubtype.Pistol_Plasma || weaponSubtype.GetValueOrDefault() == WeaponSubtype.Pistol_Electro || weaponSubtype.GetValueOrDefault() == WeaponSubtype.Pistol_Sonic);
	}

	// Token: 0x06009D0B RID: 40203 RVA: 0x003DADC4 File Offset: 0x003D8FC4
	public static bool p(cd1 A_0)
	{
		return euf.f(A_0.TypedDefinition);
	}

	// Token: 0x06009D0C RID: 40204 RVA: 0x003DADD4 File Offset: 0x003D8FD4
	public static bool f(bke A_0)
	{
		WeaponSubtype? weaponSubtype = euf.d(A_0);
		return weaponSubtype != null && (weaponSubtype.GetValueOrDefault() == WeaponSubtype.Pistol_Laser || weaponSubtype.GetValueOrDefault() == WeaponSubtype.Pistol_Plasma || weaponSubtype.GetValueOrDefault() == WeaponSubtype.Pistol_Electro || weaponSubtype.GetValueOrDefault() == WeaponSubtype.Pistol_Sonic || weaponSubtype.GetValueOrDefault() == WeaponSubtype.FusionCannon);
	}

	// Token: 0x06009D0D RID: 40205 RVA: 0x003DAE3C File Offset: 0x003D903C
	public static void a(efk A_0, ref du2 A_1)
	{
		if (A_0 is e3q && A_1.b() == DamageType.Mechanical)
		{
			if (A_1.c() > as3.br)
			{
				A_1.a(as3.br);
				return;
			}
		}
		else if (A_1.c() > 1.0)
		{
			A_1.a(1.0);
		}
	}

	// Token: 0x06009D0E RID: 40206 RVA: 0x003DAEA0 File Offset: 0x003D90A0
	public static bool o(cd1 A_0)
	{
		return euf.e((A_0 != null) ? A_0.TypedDefinition : null);
	}

	// Token: 0x06009D0F RID: 40207 RVA: 0x003DAEBC File Offset: 0x003D90BC
	public static bool e(bke A_0)
	{
		return A_0 != null && (A_0.a5() == "sp:Unarmed" || A_0.a5() == "sp:ForceWaveFist" || A_0.a5() == "sp:MutatedClaw");
	}

	// Token: 0x06009D10 RID: 40208 RVA: 0x003DAF10 File Offset: 0x003D9110
	public static bool n(cd1 A_0)
	{
		return A_0 != null && A_0.TypedDefinition != null && euf.c(euf.d(A_0.TypedDefinition));
	}

	// Token: 0x06009D11 RID: 40209 RVA: 0x003DAF38 File Offset: 0x003D9138
	public static bool d(WeaponSubtype? A_0)
	{
		return A_0.GetValueOrDefault() == WeaponSubtype.Unarmed;
	}

	// Token: 0x06009D12 RID: 40210 RVA: 0x003DAF48 File Offset: 0x003D9148
	public static bool c(WeaponSubtype? A_0)
	{
		return A_0 != null && A_0.Value > (WeaponSubtype)300 && A_0.Value < (WeaponSubtype)400;
	}

	// Token: 0x06009D13 RID: 40211 RVA: 0x003DAF78 File Offset: 0x003D9178
	public static bool d(AmmoType A_0)
	{
		return A_0 == AmmoType.Unarmed || A_0 == AmmoType.FistWeapon;
	}

	// Token: 0x06009D14 RID: 40212 RVA: 0x003DAF90 File Offset: 0x003D9190
	public static bool m(cd1 A_0)
	{
		if (A_0 == null || A_0.TypedDefinition == null)
		{
			return false;
		}
		WeaponSubtype? weaponSubtype = euf.d(A_0.TypedDefinition);
		if (weaponSubtype != null)
		{
			return euf.g(weaponSubtype.Value);
		}
		return eub.c(A_0);
	}

	// Token: 0x06009D15 RID: 40213 RVA: 0x003DAFDC File Offset: 0x003D91DC
	public static bool g(WeaponSubtype A_0)
	{
		return (A_0 >= WeaponSubtype.Pistol_5 && A_0 <= WeaponSubtype.Pistol_44) || (A_0 >= WeaponSubtype.Sniper_762 && A_0 <= WeaponSubtype.AssaultRifle_9) || (A_0 >= WeaponSubtype.Shotgun_Regular && A_0 <= WeaponSubtype.GrenadeLauncher_40) || (A_0 >= WeaponSubtype.LMG_9 && A_0 <= WeaponSubtype.Minigun_127) || (A_0 >= WeaponSubtype.RocketLauncher_84 && A_0 <= WeaponSubtype.RocketLauncher_66);
	}

	// Token: 0x06009D16 RID: 40214 RVA: 0x003DB03C File Offset: 0x003D923C
	public static bool l(cd1 A_0)
	{
		return A_0 != null && A_0.TypedDefinition != null && (A_0.TypedDefinition.e() == btz.j || A_0.TypedDefinition.e() == btz.k || A_0.TypedDefinition.e() == btz.i || A_0.TypedDefinition.e() == btz.l);
	}

	// Token: 0x06009D17 RID: 40215 RVA: 0x003DB0A4 File Offset: 0x003D92A4
	public static bool k(cd1 A_0)
	{
		if (A_0 != null && A_0.TypedDefinition != null)
		{
			WeaponSubtype? weaponSubtype = euf.d(A_0.TypedDefinition);
			if (weaponSubtype != null)
			{
				return euf.f(weaponSubtype.Value);
			}
		}
		return false;
	}

	// Token: 0x06009D18 RID: 40216 RVA: 0x003DB0E8 File Offset: 0x003D92E8
	public static bool f(WeaponSubtype A_0)
	{
		return A_0 / WeaponSubtype.Sniper_127 == WeaponSubtype.Pistol_Laser;
	}

	// Token: 0x06009D19 RID: 40217 RVA: 0x003DB0F4 File Offset: 0x003D92F4
	public static bool j(cd1 A_0)
	{
		if (A_0 != null && A_0.TypedDefinition != null)
		{
			WeaponSubtype? weaponSubtype = euf.d(A_0.TypedDefinition);
			if (weaponSubtype != null)
			{
				return euf.c(weaponSubtype.Value);
			}
		}
		return false;
	}

	// Token: 0x06009D1A RID: 40218 RVA: 0x003DB138 File Offset: 0x003D9338
	public static bool i(cd1 A_0)
	{
		if (A_0 != null && A_0.TypedDefinition != null)
		{
			WeaponSubtype? weaponSubtype = euf.d(A_0.TypedDefinition);
			if (weaponSubtype != null)
			{
				return euf.d(weaponSubtype.Value);
			}
		}
		return false;
	}

	// Token: 0x06009D1B RID: 40219 RVA: 0x003DB17C File Offset: 0x003D937C
	public static bool e(WeaponSubtype A_0)
	{
		return A_0 == WeaponSubtype.FusionCannon;
	}

	// Token: 0x06009D1C RID: 40220 RVA: 0x003DB184 File Offset: 0x003D9384
	public static bool h(cd1 A_0)
	{
		if (A_0 != null && A_0.TypedDefinition != null)
		{
			WeaponSubtype? weaponSubtype = euf.d(A_0.TypedDefinition);
			if (weaponSubtype != null)
			{
				return euf.e(weaponSubtype.Value);
			}
		}
		return false;
	}

	// Token: 0x06009D1D RID: 40221 RVA: 0x003DB1C8 File Offset: 0x003D93C8
	public static bool b(WeaponSubtype? A_0)
	{
		return A_0 != null && A_0.Value / WeaponSubtype.Sniper_127 == WeaponSubtype.Sniper_762;
	}

	// Token: 0x06009D1E RID: 40222 RVA: 0x003DB1E8 File Offset: 0x003D93E8
	public static bool a(WeaponSubtype? A_0)
	{
		return A_0 != null && A_0.Value / WeaponSubtype.Sniper_127 == WeaponSubtype.Sniper_86;
	}

	// Token: 0x06009D1F RID: 40223 RVA: 0x003DB208 File Offset: 0x003D9408
	public static bool d(WeaponSubtype A_0)
	{
		return A_0 / WeaponSubtype.Sniper_127 == WeaponSubtype.Pistol_Plasma;
	}

	// Token: 0x06009D20 RID: 40224 RVA: 0x003DB214 File Offset: 0x003D9414
	public static bool c(WeaponSubtype A_0)
	{
		return A_0 == WeaponSubtype.RocketLauncher_84 || A_0 == WeaponSubtype.RocketLauncher_40 || A_0 == WeaponSubtype.RocketLauncher_66;
	}

	// Token: 0x06009D21 RID: 40225 RVA: 0x003DB230 File Offset: 0x003D9430
	public static bool g(cd1 A_0)
	{
		if (A_0 != null && A_0.TypedDefinition != null)
		{
			WeaponSubtype? weaponSubtype = euf.d(A_0.TypedDefinition);
			if (weaponSubtype != null)
			{
				return euf.b(weaponSubtype.Value);
			}
		}
		return false;
	}

	// Token: 0x06009D22 RID: 40226 RVA: 0x003DB274 File Offset: 0x003D9474
	public static bool b(WeaponSubtype A_0)
	{
		return A_0 / (WeaponSubtype)100 == WeaponSubtype.Pistol_Laser;
	}

	// Token: 0x06009D23 RID: 40227 RVA: 0x003DB280 File Offset: 0x003D9480
	public static bool f(cd1 A_0)
	{
		if (A_0 != null && A_0.TypedDefinition != null)
		{
			WeaponSubtype? weaponSubtype = euf.d(A_0.TypedDefinition);
			if (weaponSubtype != null)
			{
				return euf.a(weaponSubtype.Value);
			}
		}
		return false;
	}

	// Token: 0x06009D24 RID: 40228 RVA: 0x003DB2C4 File Offset: 0x003D94C4
	public static bool a(WeaponSubtype A_0)
	{
		return A_0 / (WeaponSubtype)100 == WeaponSubtype.Pistol_762;
	}

	// Token: 0x06009D25 RID: 40229 RVA: 0x003DB2D0 File Offset: 0x003D94D0
	public static WeaponSubtype? d(bke A_0)
	{
		return A_0.ae();
	}

	// Token: 0x06009D26 RID: 40230 RVA: 0x003DB2DC File Offset: 0x003D94DC
	public static bg3 a(efk A_0, efk A_1, cmn A_2, double A_3, cd1 A_4 = null)
	{
		cd1 cd;
		if (A_4 != null)
		{
			cd = A_4;
		}
		else
		{
			cd = A_0.Offense.u();
		}
		bg3 bg = new bg3();
		double num = euf.a(A_0, btz.g, false);
		double a_ = (A_2.f ? 0.0 : euf.o(A_1)) * A_2.j;
		bg.g = qw.b(num + (double)A_2.e, a_);
		bg.e = euf.b(A_0, cd);
		bg.d = euf.c(A_0, cd);
		bg.k = euf.d(cd);
		bg.j = cd.TypedDefinition.ab();
		double num2 = bg.g + bg.j;
		if (A_3 == 0.0)
		{
			bg.a = 0.0;
		}
		else
		{
			double num3 = 0.0;
			foreach (bns bns in cd.TypedDefinition.n())
			{
				num3 += bns.hy(cd, A_0, A_1);
			}
			bg.a = Math.Round(d05.b(as3.bc, num2 * A_3, as3.bd) + as3.ab[btz.g] + A_0.Offense.ar() + bg.k - bg.e - bg.d + num3, 2);
			if (!A_2.f && euf.q(A_1))
			{
				if (A_1.Feats.Contains<erg>())
				{
					bg.a -= erg.a;
				}
				if (A_1.StatusEffects.a(doy.a))
				{
					bg.a -= a9y.a(A_1);
				}
			}
			double num4 = as3.bd;
			if (A_0 != null && A_0.Feats.Contains<c1z>())
			{
				num4 -= c1z.a;
			}
			bg.a = d05.b(as3.bc, bg.a, num4);
			if (A_0.Vehicle != null)
			{
				double num5 = euf.a(A_0, A_4 ?? A_0.Offense.u(), true);
				WeaponSubtype? weaponSubtype = euf.d(cd.TypedDefinition);
				if (weaponSubtype != null)
				{
					int num6 = (int)(weaponSubtype.Value / (WeaponSubtype)100);
					if ((num6 == 2 || num6 == 3 || num6 == 10) && (!A_0.Feats.Contains<cyz>() || (A_0.Vehicle.y() != bws.b && A_0.Vehicle.y() != bws.a)))
					{
						num5 = Math.Round(Math.Max(0.05, num5 - as3.bw), 2);
					}
				}
				bg.a *= num5;
			}
		}
		return bg;
	}

	// Token: 0x06009D27 RID: 40231 RVA: 0x003DB5D4 File Offset: 0x003D97D4
	public static cwt a(efk A_0, efk A_1, cmn A_2, double A_3 = 0.0, bool? A_4 = null, double A_5 = 1.0, cd1 A_6 = null, bool A_7 = true)
	{
		cd1 cd = A_6 ?? A_0.Offense.u();
		bke bke = cd.TypedDefinition;
		foreach (bns bns in bke.n())
		{
			bns.atf(A_2, cd, A_0, A_1);
		}
		cwt cwt = new cwt();
		cwt.x = bke.ak();
		cwt.ae = euf.d(bke);
		cwt.n = euf.s(cd);
		cwt.z = true;
		cwt.aa = euf.o(cd);
		cwt.i = new ap9(A_0);
		cwt.j = new ap9(A_1);
		cwt.ai = A_6;
		double a_ = euf.a(A_0, btz.g, false);
		if (A_4 != null)
		{
			cwt.b = A_4.Value;
		}
		else
		{
			bg3 bg = euf.a(A_0, A_1, A_2, A_5, cd);
			kl.d(ref bg.a, A_0, A_1);
			cwt.b = euf.a(A_0, A_1, bg.a);
		}
		if (cwt.b)
		{
			if (A_1.Vehicle != null)
			{
				cwt.c = new bool?(cuo.a.NextDouble() < A_1.Vehicle.ad());
			}
			if (A_1 != null && A_1.Gear.l().Item != null && A_1.Gear.l().Item.fu() != null && A_1.Gear.l().Item.fu().c() > 0.0 && !A_1.SpecialStates.a && !A_1.SpecialStates.c)
			{
				double num = A_1.Gear.l().Item.fu().c();
				if (A_1.Feats.Contains<e2c>())
				{
					num += e2c.a + (double)A_1.GetSpecializationValue<c8y>(true) * c8y.a;
				}
				cwt.d = euf.a(num);
			}
			cwt.h = bke.c();
			double num2;
			if (A_7)
			{
				num2 = A_0.Offense.a0();
			}
			else
			{
				num2 = bke.ai();
			}
			num2 += A_3 + A_2.c;
			if (A_1 != null)
			{
				if (cwt.x == AmmoType.Mental)
				{
					num2 += A_1.Defense.ac();
				}
				else
				{
					num2 += A_1.Defense.w();
				}
			}
			euf.a(ref num2, A_0, A_1);
			kl.b(ref num2, A_0, A_1);
			cwt.e = (!A_1.ImmuneToCriticalHits && euf.a(num2));
			double num3 = 1.0;
			WeaponSubtype? a_2 = euf.d(bke);
			if ((a_2.GetValueOrDefault() == WeaponSubtype.Knife || a_2.GetValueOrDefault() == WeaponSubtype.Dagger || a_2.GetValueOrDefault() == WeaponSubtype.SerratedKnife || a_2.GetValueOrDefault() == WeaponSubtype.Sword || a_2.GetValueOrDefault() == WeaponSubtype.Machete_Curved || a_2.GetValueOrDefault() == WeaponSubtype.Machete_Straight) && cwt.e && A_0.Feats.Contains<cln>())
			{
				double num4 = (double)d05.b(0f, 1f - euf.f(A_1), 1f);
				double num5 = 1.0 + (double)((int)(num4 / cln.b)) * cln.a(A_0);
				num3 *= num5;
			}
			double num6 = qw.a(bke, a_);
			double num7 = qw.a(A_0, bke, a_2);
			double num8 = 0.0;
			if (A_0.Vehicle != null)
			{
				num8 = A_0.Vehicle.q();
				if (A_0.Vehicle.y() == bws.b || A_0.Vehicle.y() == bws.a)
				{
					if (bke.ae().GetValueOrDefault() == WeaponSubtype.Spear && A_0.Feats.Contains<eyf>())
					{
						num8 += eyf.a;
					}
					if (A_0.Feats.Contains<dtv>())
					{
						num8 += dtv.a;
					}
				}
			}
			double num9 = 0.0;
			foreach (bns bns2 in bke.n())
			{
				num9 += bns2.rl(cd, A_0, A_1, cwt.c.GetValueOrDefault());
			}
			double num10;
			if (A_7)
			{
				num10 = A_0.Offense.am();
			}
			else
			{
				num10 = bke.y();
			}
			num10 += A_2.d;
			num10 *= num3;
			foreach (a1q a_3 in bke.l())
			{
				csk item = euf.a(a_3, cwt.e ? num10 : 0.0, num6 + ((a_3.DamageType == DamageType.Mechanical) ? num7 : 0.0), A_2.b + num8 + num9, null);
				foreach (bns bns3 in bke.n())
				{
					bns3.lk(ref item, cd, A_0, A_1, cwt.c.GetValueOrDefault());
				}
				kl.a(ref item, cd, A_0, A_1);
				if (item.Amount > 0)
				{
					cwt.f.Add(item);
				}
			}
			if (A_0.Feats.Contains<b6t>() && !cwt.e)
			{
				euf.b(cwt.f, new csk(DamageType.Mechanical, Math.Min(A_0.Level, b6t.a + A_0.GetSpecializationValue<cs2>(true) * cs2.a)));
			}
			euf.a(cwt, A_2);
		}
		List<edm> list = bk0.a(A_0, cd);
		if (list != null)
		{
			foreach (edm edm in list)
			{
				if (euf.a(edm, A_0, A_1))
				{
					cwt.g.Add(edm);
				}
			}
		}
		cwt.a |= A_2.a;
		return cwt;
	}

	// Token: 0x06009D28 RID: 40232 RVA: 0x003DBCA8 File Offset: 0x003D9EA8
	public static bg3 a(efk A_0, efk A_1, double A_2, double A_3, bool A_4, AmmoType A_5, bool A_6, double A_7, cmn A_8, cd1 A_9 = null, int? A_10 = null)
	{
		bg3 bg = new bg3();
		cd1 cd = A_9 ?? A_0.Offense.u();
		bke bke = cd.TypedDefinition;
		bg.i = d05.b(0.0, (A_2 - 3.0) / 3.0, 1.0);
		if (A_4 || bke.ae().GetValueOrDefault() == WeaponSubtype.GrenadeLauncher_25 || bke.ae().GetValueOrDefault() == WeaponSubtype.GrenadeLauncher_40 || bke.ae().GetValueOrDefault() == WeaponSubtype.FusionCannon)
		{
			bg.h = 1.0;
		}
		else
		{
			bg.h = 1.0 - (1.0 - Math.Min(1.0, A_3 + 0.15)) * 0.6 * bg.i;
		}
		double num;
		if (A_10 != null)
		{
			num = (double)A_10.Value;
		}
		else
		{
			num = euf.a(A_0, bke.e(), false);
		}
		euf.a(A_0, bke, A_2, ref num);
		double num2 = 0.0;
		if (A_1 != null)
		{
			num2 = euf.p(A_1);
		}
		double num3 = 1.0;
		if ((A_8.a & c3u.e) == c3u.e)
		{
			num3 -= 0.5;
		}
		num3 -= A_8.i;
		if (eub.c(A_5) && A_0.Feats.Contains<g4>() && !A_6)
		{
			num3 -= g4.a + (double)A_0.GetSpecializationValue<b9l>(true) * b9l.a;
		}
		if (bke.e() == btz.a && bke.ae() != null && euf.g(bke.ae().Value) && A_2 <= as3.u)
		{
			double num4 = as3.u - as3.t;
			double num5 = Math.Max(0.0, A_2 - as3.t);
			double num6 = (1.0 - Math.Min(1.0, num5 / num4)) * as3.s;
			num3 -= num6;
		}
		num2 = (double)((int)(num2 * Math.Max(0.0, num3)));
		double a_ = (double)((bke.h() > 0f) ? bke.h() : bke.ad());
		bg.g = qw.c(num + (double)A_8.e, num2);
		bg.f = qw.a(a_, A_2, bke.e(), num);
		bg.e = euf.r(A_0);
		bg.d = euf.s(A_0);
		bg.k = euf.d(cd);
		if (A_6)
		{
			bg.b = (double)bke.z();
		}
		if (!A_0.Offense.af())
		{
			bg.c = bke.aj();
			if (A_0.Feats.Contains<cbz>())
			{
				bg.c = Math.Max(0.0, bg.c - cbz.a - (double)A_0.GetSpecializationValue<dfj>(true) * dfj.a);
			}
		}
		if (bke.ab() < 0.0 || (bg.d == 0.0 && bg.b == 0.0 && bg.c == 0.0))
		{
			bg.j = bke.ab();
		}
		double num7 = bg.g * bg.h * bg.f + bg.j + A_8.h;
		if (A_7 == 0.0)
		{
			bg.a = 0.0;
		}
		else
		{
			double num8 = 0.0;
			foreach (bns bns in cd.TypedDefinition.n())
			{
				num8 += bns.hz(cd, A_0, A_1, A_2, A_3, A_4, A_5, A_6);
			}
			double num9 = as3.a9;
			if (A_0 != null && A_0.Feats.Contains<c1z>())
			{
				num9 -= c1z.a;
			}
			bg.a = Math.Round(d05.b(as3.a8, num7 * A_7, num9) + as3.ab[bke.e()] + A_0.Offense.ar() + bg.k - bg.b - bg.c - bg.e - bg.d + num8, 2);
			if (bke.e() == btz.f)
			{
				bg.a += (double)A_0.GetSpecializationValue<e76>(true) * e76.a;
			}
			if (A_1 != null && euf.q(A_1))
			{
				if (A_1.Feats.Contains<cx9>())
				{
					bg.a -= cx9.a;
				}
				if (A_1.StatusEffects.a(doy.a))
				{
					bg.a -= a9y.a(A_1);
				}
			}
			bg.a = d05.b(as3.a8, bg.a, num9);
			if (A_0.Vehicle != null)
			{
				bg.a *= euf.a(A_0, A_9 ?? A_0.Offense.u(), false);
			}
		}
		return bg;
	}

	// Token: 0x06009D29 RID: 40233 RVA: 0x003DC25C File Offset: 0x003DA45C
	public static bg3 a(efk A_0, efk A_1, double A_2, double A_3, bool A_4, bool A_5, double A_6, c3u A_7, double A_8 = 0.0)
	{
		bg3 bg = new bg3();
		bg.i = d05.b(0.0, (A_2 - 3.0) / 3.0, 1.0);
		if (A_4)
		{
			bg.h = 1.0;
		}
		else
		{
			bg.h = 1.0 - (1.0 - Math.Min(1.0, A_3 + 0.15)) * 0.75 * bg.i;
		}
		double num = (double)A_0.Skills.Get<dei>().g();
		double num2 = euf.p(A_1);
		if ((A_7 & c3u.e) == c3u.e)
		{
			num2 /= 2.0;
		}
		if (A_5)
		{
			bg.b = as3.a2;
		}
		bg.g = qw.c(num, num2);
		bg.f = qw.a((double)as3.ax, A_2, as3.ay, num, 1.0);
		double num3 = bg.g * bg.h * bg.f + bg.j;
		if (A_6 == 0.0)
		{
			bg.a = 0.0;
		}
		else
		{
			bg.a = d05.b(as3.a8, num3 * A_6 + A_8, as3.a9) + A_0.Offense.aw() + bg.k - bg.b - bg.c - bg.e - bg.d;
			double num4 = as3.a9;
			if (A_0 != null && A_0.Feats.Contains<c1z>())
			{
				num4 -= c1z.a;
			}
			bg.a = d05.b(as3.a8, bg.a, num4);
			if (A_0.Vehicle != null)
			{
				bg.a *= euf.a(A_0, null, false);
			}
		}
		return bg;
	}

	// Token: 0x06009D2A RID: 40234 RVA: 0x003DC45C File Offset: 0x003DA65C
	private static void a(efk A_0, bke A_1, double A_2, ref double A_3)
	{
		if (A_0.Feats.Contains<bbt>() && A_1.e() == btz.a && A_1.ae() != null && euf.g(A_1.ae().Value) && A_2 <= 1.9)
		{
			double num = bbt.a(A_0) * (double)A_0.Skills.Get<jk>().f();
			A_3 += num;
		}
	}

	// Token: 0x06009D2B RID: 40235 RVA: 0x003DC4E0 File Offset: 0x003DA6E0
	public static cwt a(efk A_0, efk A_1, double A_2, cmn A_3, double A_4, double A_5, bool A_6, AmmoType A_7, bool A_8, double A_9, bool A_10 = false, cd1 A_11 = null, int? A_12 = null, bool A_13 = true, double? A_14 = null)
	{
		cd1 cd = A_11 ?? A_0.Offense.u();
		bke bke = cd.TypedDefinition;
		foreach (bns bns in bke.n())
		{
			bns.ate(A_3, cd, A_0, A_1, A_2, A_5, A_6, A_7, A_8);
		}
		cwt cwt = new cwt();
		cwt.x = A_7;
		cwt.ae = euf.d(bke);
		cwt.n = euf.s(cd);
		cwt.i = new ap9(A_0);
		cwt.j = new ap9(A_1);
		cwt.ai = A_11;
		double a_ = euf.a(A_0, bke.e(), false);
		euf.a(A_0, bke, A_2, ref a_);
		bg3 bg = euf.a(A_0, A_1, A_2, A_5, A_6, A_7, A_8, A_9, A_3, A_11, A_12);
		kl.d(ref bg.a, A_0, A_1);
		cwt.b = (A_10 || euf.a(A_0, A_1, bg.a));
		if (cwt.b)
		{
			if (A_1 != null && A_1.Vehicle != null)
			{
				cwt.c = new bool?(cuo.a.NextDouble() < A_1.Vehicle.ad());
			}
			cwt.h = bke.c();
			double num;
			if (A_13)
			{
				num = A_0.Offense.a0();
			}
			else
			{
				num = bke.ai();
			}
			num += A_4 + A_3.c;
			if (A_1 != null)
			{
				if (cwt.x == AmmoType.Mental)
				{
					num += A_1.Defense.ac();
				}
				else
				{
					num += A_1.Defense.w();
				}
			}
			euf.a(ref num, A_0, A_1);
			kl.b(ref num, A_0, A_1);
			cwt.e = ((A_1 == null || !A_1.ImmuneToCriticalHits) && euf.a(num));
			double a_2 = qw.a(bke, a_);
			double num2;
			if (A_13)
			{
				num2 = A_0.Offense.am();
			}
			else
			{
				num2 = bke.y();
			}
			double num3 = 0.0;
			if (A_0.Vehicle != null && (A_0.Vehicle.y() == bws.b || A_0.Vehicle.y() == bws.a) && A_0.Feats.Contains<dtv>())
			{
				num3 += dtv.a;
			}
			double num4 = 0.0;
			foreach (bns bns2 in bke.n())
			{
				num4 += bns2.rk(cd, A_0, A_1, A_2, A_5, A_6, A_7, A_8, cwt.c.GetValueOrDefault());
			}
			foreach (a1q a_3 in bke.l())
			{
				csk item = euf.a(a_3, cwt.e ? (num2 + A_3.d) : 0.0, a_2, A_3.b + num3 + num4, A_14);
				foreach (bns bns3 in bke.n())
				{
					bns3.ll(ref item, cd, A_0, A_1, A_2, A_5, A_6, A_7, A_8, cwt.c.GetValueOrDefault());
				}
				kl.a(ref item, cd, A_0, A_1);
				if (item.Amount > 0)
				{
					cwt.f.Add(item);
				}
			}
			if ((bke.e() == btz.g || bke.e() == btz.f || (euf.m(A_0.Offense.u()) && !euf.k(cd) && !euf.i(cd))) && A_0.Feats.Contains<b6t>() && !cwt.e)
			{
				euf.b(cwt.f, new csk(DamageType.Mechanical, Math.Min(A_0.Level, b6t.a + A_0.GetSpecializationValue<cs2>(true) * cs2.a)));
			}
			euf.a(cwt, A_3);
			dgr itemDefinition = ez2.GetItemDefinition<dgr>("ammo\\" + A_7.ToString(), false);
			if (itemDefinition != null)
			{
				foreach (edm edm in itemDefinition.a())
				{
					if (euf.a(edm, A_0, A_1))
					{
						cwt.g.Add(edm);
					}
				}
			}
		}
		List<edm> list = bk0.a(A_0, cd);
		if (list != null)
		{
			foreach (edm edm2 in list)
			{
				if (euf.a(edm2, A_0, A_1))
				{
					cwt.g.Add(edm2);
				}
			}
		}
		cwt.a |= A_3.a;
		return cwt;
	}

	// Token: 0x06009D2C RID: 40236 RVA: 0x003DCA74 File Offset: 0x003DAC74
	public static double s(efk A_0)
	{
		return euf.c(A_0, A_0.Offense.u());
	}

	// Token: 0x06009D2D RID: 40237 RVA: 0x003DCA88 File Offset: 0x003DAC88
	public static double c(efk A_0, cd1 A_1)
	{
		double num = euf.a(A_0, A_1.TypedDefinition.e(), false);
		double num2 = (double)euf.c(A_1.TypedDefinition);
		if (num2 > 0.0 && num < num2)
		{
			return (1.0 - num / num2) * as3.aq;
		}
		return 0.0;
	}

	// Token: 0x06009D2E RID: 40238 RVA: 0x003DCAE8 File Offset: 0x003DACE8
	public static double r(efk A_0)
	{
		return euf.b(A_0, A_0.Offense.u());
	}

	// Token: 0x06009D2F RID: 40239 RVA: 0x003DCAFC File Offset: 0x003DACFC
	public static double b(efk A_0, cd1 A_1)
	{
		double num = (double)A_0.BaseAbilities.Strength;
		double num2 = (double)A_1.TypedDefinition.i();
		if (num2 > 0.0 && num < num2)
		{
			return (1.0 - num / num2) * as3.ap;
		}
		return 0.0;
	}

	// Token: 0x06009D30 RID: 40240 RVA: 0x003DCB58 File Offset: 0x003DAD58
	public static csk a(a1q A_0, double A_1, double A_2, double A_3, double? A_4 = null)
	{
		double num;
		if (A_4 != null)
		{
			num = A_4.Value;
		}
		else
		{
			num = Math.Min(1.0, euf.a.NextDouble() + 0.01);
		}
		return new csk(A_0.DamageType, Convert.ToInt32((1.0 + A_1) * Math.Max(0.05, 1.0 + A_3) * (1.0 + A_2) * ((double)A_0.LowerBoundary + num * (double)(A_0.UpperBoundary - A_0.LowerBoundary))));
	}

	// Token: 0x06009D31 RID: 40241 RVA: 0x003DCC00 File Offset: 0x003DAE00
	public static csk a(a1q A_0, double A_1 = 1.0)
	{
		double num = euf.a.NextDouble();
		return new csk(A_0.DamageType, Convert.ToInt32(A_1 * ((double)A_0.LowerBoundary + num * (double)(A_0.UpperBoundary - A_0.LowerBoundary))));
	}

	// Token: 0x06009D32 RID: 40242 RVA: 0x003DCC48 File Offset: 0x003DAE48
	public static void b(List<csk> A_0, csk A_1)
	{
		int i = 0;
		while (i < A_0.Count)
		{
			csk value = A_0[i];
			if (value.DamageType == A_1.DamageType)
			{
				value.Amount = Math.Max(0, value.Amount + A_1.Amount);
				if (value.Amount == 0)
				{
					A_0.RemoveAt(i);
					return;
				}
				A_0[i] = value;
				return;
			}
			else
			{
				i++;
			}
		}
	}

	// Token: 0x06009D33 RID: 40243 RVA: 0x003DCCC0 File Offset: 0x003DAEC0
	public static bool a(double A_0)
	{
		return euf.a.NextDouble() < A_0;
	}

	// Token: 0x06009D34 RID: 40244 RVA: 0x003DCCD0 File Offset: 0x003DAED0
	public static bool a(efk A_0, efk A_1, double A_2)
	{
		bool result = euf.a.NextDouble() < A_2;
		kl.a(ref result, A_0, A_1);
		return result;
	}

	// Token: 0x06009D35 RID: 40245 RVA: 0x003DCCF8 File Offset: 0x003DAEF8
	public static bool a(edm A_0, efk A_1, efk A_2)
	{
		double a_ = A_0.Chance;
		kl.a(ref a_, A_0, A_1, A_2);
		return euf.a(a_);
	}

	// Token: 0x06009D36 RID: 40246 RVA: 0x003DCD1C File Offset: 0x003DAF1C
	public static bool q(efk A_0)
	{
		return !A_0.SpecialStates.c && !A_0.SpecialStates.h && !A_0.SpecialStates.a && !A_0.SpecialStates.b;
	}

	// Token: 0x06009D37 RID: 40247 RVA: 0x003DCD6C File Offset: 0x003DAF6C
	public static double p(efk A_0)
	{
		if (!euf.q(A_0))
		{
			return 0.0;
		}
		double num = (double)A_0.Defense.z();
		if (!(A_0 is e3q) && !A_0.SpecialStates.a && !A_0.SpecialStates.c && !A_0.SpecialStates.h && !A_0.SpecialStates.b)
		{
			num += (double)A_0.Level * as3.a4;
		}
		if (A_0.Vehicle != null)
		{
			num *= A_0.Vehicle.u();
		}
		return num;
	}

	// Token: 0x06009D38 RID: 40248 RVA: 0x003DCE10 File Offset: 0x003DB010
	public static double a(efk A_0, double A_1 = 0.0, double A_2 = 1.0)
	{
		double num = euf.p(A_0);
		return d05.b(0.0, num / 400.0 * A_2 + A_1, as3.bs);
	}

	// Token: 0x06009D39 RID: 40249 RVA: 0x003DCE48 File Offset: 0x003DB048
	public static double o(efk A_0)
	{
		if (!euf.q(A_0))
		{
			return 0.0;
		}
		double num = (double)A_0.Defense.v();
		if (!(A_0 is e3q) && !A_0.SpecialStates.a && !A_0.SpecialStates.c && !A_0.SpecialStates.h)
		{
			num += (double)A_0.Level * as3.a6;
		}
		return num;
	}

	// Token: 0x06009D3A RID: 40250 RVA: 0x003DCEC4 File Offset: 0x003DB0C4
	public static double a(efk A_0, btz A_1, bool A_2 = false)
	{
		csn csn;
		switch (A_1)
		{
		case btz.a:
		case btz.b:
		case btz.c:
		case btz.d:
		case btz.e:
		case btz.h:
			csn = A_0.Skills.Get<ct7>();
			goto IL_95;
		case btz.f:
			csn = A_0.Skills.Get<e5n>();
			goto IL_95;
		case btz.i:
		case btz.j:
		case btz.k:
		case btz.l:
			if (dk2.e())
			{
				csn = A_0.Skills.Get<e8k>();
				goto IL_95;
			}
			csn = A_0.Skills.Get<ct7>();
			goto IL_95;
		}
		csn = A_0.Skills.Get<jk>();
		IL_95:
		if (csn == null)
		{
			return 0.0;
		}
		if (A_2)
		{
			return (double)csn.f();
		}
		return (double)csn.g();
	}

	// Token: 0x06009D3B RID: 40251 RVA: 0x003DCF8C File Offset: 0x003DB18C
	public static int c(bke A_0)
	{
		int num = as3.z[A_0.e()];
		return (as3.z[A_0.e()] + as3.aa[A_0.e()] * A_0.a8()) / 5 * 5;
	}

	// Token: 0x06009D3C RID: 40252 RVA: 0x003DCFD8 File Offset: 0x003DB1D8
	public static bool f(int A_0, efk A_1)
	{
		double a_ = euf.d(A_0, A_1);
		kl.b(ref a_, A_1);
		return euf.a(a_);
	}

	// Token: 0x06009D3D RID: 40253 RVA: 0x003DCFFC File Offset: 0x003DB1FC
	public static bool e(int A_0, efk A_1)
	{
		double a_ = euf.c(A_0, A_1);
		kl.c(ref a_, A_1);
		return euf.a(a_);
	}

	// Token: 0x06009D3E RID: 40254 RVA: 0x003DD020 File Offset: 0x003DB220
	public static int n(efk A_0)
	{
		int a_ = c2h.d(A_0);
		return c2h.a(aiy.af, a_, (double)aiy.ag);
	}

	// Token: 0x06009D3F RID: 40255 RVA: 0x003DD048 File Offset: 0x003DB248
	public static bool m(efk A_0)
	{
		return euf.f(euf.n(A_0), A_0);
	}

	// Token: 0x06009D40 RID: 40256 RVA: 0x003DD058 File Offset: 0x003DB258
	public static bool l(efk A_0)
	{
		return euf.e(euf.n(A_0), A_0);
	}

	// Token: 0x06009D41 RID: 40257 RVA: 0x003DD06C File Offset: 0x003DB26C
	public static double d(int A_0, efk A_1)
	{
		int num = A_1.Defense.ae();
		return qw.a((double)A_0, (double)num);
	}

	// Token: 0x06009D42 RID: 40258 RVA: 0x003DD090 File Offset: 0x003DB290
	public static double c(int A_0, efk A_1)
	{
		int num = A_1.Defense.ab();
		return qw.a((double)A_0, (double)num);
	}

	// Token: 0x06009D43 RID: 40259 RVA: 0x003DD0B4 File Offset: 0x003DB2B4
	public static bool b(int A_0, efk A_1)
	{
		return euf.a(euf.a(A_0, A_1));
	}

	// Token: 0x06009D44 RID: 40260 RVA: 0x003DD0C4 File Offset: 0x003DB2C4
	public static bool k(efk A_0)
	{
		return A_0 != null && cuo.a.NextDouble() < (double)A_0.Defense.aa;
	}

	// Token: 0x06009D45 RID: 40261 RVA: 0x003DD0EC File Offset: 0x003DB2EC
	public static double a(int A_0, efk A_1)
	{
		int num = A_1.Defense.z();
		return qw.a((double)A_0, (double)num);
	}

	// Token: 0x06009D46 RID: 40262 RVA: 0x003DD110 File Offset: 0x003DB310
	public static double a(int A_0, float A_1)
	{
		if (A_1 == 0f)
		{
			return 0.0;
		}
		return (double)((float)A_0 / A_1);
	}

	// Token: 0x06009D47 RID: 40263 RVA: 0x003DD12C File Offset: 0x003DB32C
	public static double a(int A_0, int A_1)
	{
		if (A_1 == 0)
		{
			return 0.0;
		}
		return (double)A_0 / (double)A_1;
	}

	// Token: 0x06009D48 RID: 40264 RVA: 0x003DD148 File Offset: 0x003DB348
	public static double e(cd1 A_0)
	{
		return euf.a(Enumerable.Sum<a1q>(A_0.TypedDefinition.l(), new Func<a1q, int>(euf.a.a.a)), A_0.TypedDefinition.v());
	}

	// Token: 0x06009D49 RID: 40265 RVA: 0x003DD198 File Offset: 0x003DB398
	public static double a(a1q A_0, float A_1)
	{
		if (A_1 == 0f)
		{
			return 0.0;
		}
		return euf.a((A_0.LowerBoundary + A_0.UpperBoundary) / 2, A_1);
	}

	// Token: 0x06009D4A RID: 40266 RVA: 0x003DD1CC File Offset: 0x003DB3CC
	public static int a(cwt A_0, List<csk> A_1, efk A_2, ahx A_3, double A_4)
	{
		int num = 0;
		if (A_1 != null)
		{
			foreach (csk csk in A_1)
			{
				num += csk.Amount;
			}
		}
		if (A_2.Defense.q().zm() <= 0f)
		{
			return 0;
		}
		return (int)((double)((float)num / A_2.Defense.q().zm()) * A_4 * Math.Max(0.0, 1.0 - A_3.a) * A_0.t * 1000.0);
	}

	// Token: 0x06009D4B RID: 40267 RVA: 0x003DD290 File Offset: 0x003DB490
	public static int a(cwt A_0, List<csk> A_1, efk A_2, PsiSchool A_3, double A_4)
	{
		return euf.a(A_0, A_1, A_2, A_2.Offense.ag()[A_3].c(), A_4);
	}

	// Token: 0x06009D4C RID: 40268 RVA: 0x003DD2C0 File Offset: 0x003DB4C0
	public static int a(cwt A_0, List<csk> A_1, efk A_2, double A_3)
	{
		return euf.a(A_0, A_1, A_2, A_2.Offense.v(), A_3);
	}

	// Token: 0x06009D4D RID: 40269 RVA: 0x003DD2E4 File Offset: 0x003DB4E4
	public static double a(double A_0, efk A_1, PsiSchool A_2)
	{
		return Math.Max(as3.bh, A_0 - A_1.Offense.ag()[A_2].c().b);
	}

	// Token: 0x06009D4E RID: 40270 RVA: 0x003DD318 File Offset: 0x003DB518
	public static int b(IEnumerable<csk> A_0)
	{
		int num = 0;
		if (A_0 != null)
		{
			foreach (csk csk in A_0)
			{
				num += csk.Amount;
			}
		}
		return num;
	}

	// Token: 0x06009D4F RID: 40271 RVA: 0x003DD378 File Offset: 0x003DB578
	public static int a(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			return euf.j(A_0.b8());
		}
		return 0;
	}

	// Token: 0x06009D50 RID: 40272 RVA: 0x003DD398 File Offset: 0x003DB598
	public static int j(efk A_0)
	{
		if (A_0.Feats.Contains<co4>())
		{
			return co4.a * d0u.b;
		}
		return 0;
	}

	// Token: 0x06009D51 RID: 40273 RVA: 0x003DD3B8 File Offset: 0x003DB5B8
	public static cd1 i(efk A_0)
	{
		bke bke = new bke();
		bke.g("Без оружия");
		bke.k("sp:Unarmed");
		bke.i(qv.b("Items\\Weapons/Unarmed"));
		bke.f("Weapons.0");
		bke.a(as3.af[WeaponSubtype.Unarmed]);
		bke.f(as3.w[WeaponSubtype.Unarmed]);
		bke.c(as3.bk);
		bke.d(as3.bk);
		bke.b((float)bke.v() * d0u.c);
		bke.a(btz.g);
		bke.a(ImpactSpeed.VeryLow);
		bke.a(esu.h);
		bke.a(bhx.e);
		bke.a(AmmoType.Unarmed);
		bke.g(true);
		bke.a(new WeaponSubtype?(WeaponSubtype.Unarmed));
		double a_ = 1.0 + (double)Math.Max(0, A_0.BaseAbilities.Strength - 5) * 0.05;
		b1j b1j = c4r.a(null, WeaponSubtype.Unarmed, (double)c2h.d(A_0), a_, null, null);
		bke.l().Add(new a1q(DamageType.Mechanical, (int)b1j.b, (int)b1j.c));
		return new cd1(new IndependentItemDefinitionProvider<bke>(bke));
	}

	// Token: 0x06009D52 RID: 40274 RVA: 0x003DD504 File Offset: 0x003DB704
	public static cd1 a()
	{
		bke bke = new bke();
		bke.g("Barrel");
		bke.k("sp:Barrel");
		bke.f("Misc.0");
		bke.a(35);
		bke.f(0.05);
		bke.c(as3.bk);
		bke.d(as3.bk);
		bke.b((float)bke.v() * d0u.c);
		bke.a(btz.g);
		bke.a(ImpactSpeed.VeryLow);
		bke.a(esu.f);
		bke.a(bhx.e);
		bke.a(AmmoType.Sledgehammer);
		bke.g(true);
		bke.a(new WeaponSubtype?(WeaponSubtype.Sledgehammer));
		bke.am().Add("BarrelSlam");
		bke.l().Add(new a1q(DamageType.Mechanical, 30, 55));
		return new cd1(new IndependentItemDefinitionProvider<bke>(bke));
	}

	// Token: 0x06009D53 RID: 40275 RVA: 0x003DD5E4 File Offset: 0x003DB7E4
	public static double d(efk A_0, double A_1 = 1.0)
	{
		double num = (double)(c2h.b(A_0.BaseAbilities.Constitution, A_0.Level) - c2h.b(5, A_0.Level));
		double num2 = (double)c2h.b(20, A_0.Level);
		num += Math.Min(num / 2.0, (double)(A_0.Defense.ab() - c2h.b(5, A_0.Level)));
		num *= A_1;
		return Math.Min(aiy.cj, num / num2);
	}

	// Token: 0x06009D54 RID: 40276 RVA: 0x003DD664 File Offset: 0x003DB864
	public static int h(efk A_0)
	{
		int num = d0u.d;
		if (A_0 != null && A_0.Feats.Contains<bav>())
		{
			num = (int)((double)num * (1.0 - (bav.a + (double)A_0.GetSpecializationValue<b5y>(true) * b5y.a)));
		}
		return num;
	}

	// Token: 0x06009D55 RID: 40277 RVA: 0x003DD6B4 File Offset: 0x003DB8B4
	public static double d(cd1 A_0)
	{
		if (!A_0.Definition.a9() && A_0.MaxDurability > 0)
		{
			double num = A_0.Durability / (double)A_0.MaxDurability;
			if (num < dwh.i)
			{
				return -0.75;
			}
			if (num < dwh.h)
			{
				return (num - dwh.h) * 2.25;
			}
		}
		return 0.0;
	}

	// Token: 0x06009D56 RID: 40278 RVA: 0x003DD728 File Offset: 0x003DB928
	public static double a(cgk A_0)
	{
		if (!A_0.Definition.a9() && A_0.MaxDurability > 0)
		{
			double num = A_0.Durability / (double)A_0.MaxDurability;
			if (num < dwh.i)
			{
				return -1.0;
			}
			if (num < dwh.h)
			{
				return (num - dwh.h) * 3.0;
			}
		}
		return 0.0;
	}

	// Token: 0x06009D57 RID: 40279 RVA: 0x003DD79C File Offset: 0x003DB99C
	public static int c(efk A_0, double A_1)
	{
		return euf.b(A_0, A_0.Skills.Get<dei>().g(), A_1, A_0.Offense.aw());
	}

	// Token: 0x06009D58 RID: 40280 RVA: 0x003DD7CC File Offset: 0x003DB9CC
	public static int b(efk A_0, int A_1, double A_2, double A_3)
	{
		double[] array = euf.a(A_0, A_1, A_2, A_3);
		double num = cuo.a.NextDouble();
		for (int i = 0; i < array.Length; i++)
		{
			if (num < array[i])
			{
				return i;
			}
		}
		return 3;
	}

	// Token: 0x06009D59 RID: 40281 RVA: 0x003DD80C File Offset: 0x003DBA0C
	public static double[] b(efk A_0, double A_1)
	{
		return euf.a(A_0, A_0.Skills.Get<dei>().g(), A_1, A_0.Offense.aw());
	}

	// Token: 0x06009D5A RID: 40282 RVA: 0x003DD83C File Offset: 0x003DBA3C
	public static double[] a(efk A_0, int A_1, double A_2, double A_3)
	{
		double[] array = new double[3];
		if (A_2 > 1.5)
		{
			double num;
			if (A_0 != null && A_0.Vehicle != null)
			{
				num = euf.a(A_0, null, false);
			}
			else
			{
				num = 1.0;
			}
			array[0] = d05.b(0.15, 0.4 - (A_2 - 1.5) * 0.05 + (double)A_1 * 0.0075 + A_3, 0.9) * num;
			array[1] = d05.b(0.15, 0.6 - (A_2 - 1.5) * 0.05 + (double)A_1 * 0.0075 + A_3, 0.9) * num;
			array[2] = d05.b(0.15, 0.8 - (A_2 - 1.5) * 0.05 + (double)A_1 * 0.0075 + A_3, 0.9) * num;
			if (array[1] == array[0])
			{
				array[1] += (1.0 - array[0]) / 3.0;
				array[2] = array[1] + (1.0 - array[0]) / 3.0;
			}
			else if (array[2] == array[1])
			{
				array[2] += (1.0 - array[1]) / 3.0;
			}
		}
		else
		{
			array[0] = 1.0;
			array[1] = 1.33;
			array[2] = 1.66;
		}
		return array;
	}

	// Token: 0x06009D5B RID: 40283 RVA: 0x003DDA10 File Offset: 0x003DBC10
	public static void g(efk A_0)
	{
		foreach (a5e a5e in Enumerable.OfType<a5e>(A_0.StatusEffects.d()))
		{
			a5e.TimeLeft += (double)d0u.b;
		}
	}

	// Token: 0x06009D5C RID: 40284 RVA: 0x003DDA7C File Offset: 0x003DBC7C
	public static bool c(cd1 A_0)
	{
		if (A_0 != null && A_0.TypedDefinition != null)
		{
			if (A_0.TypedDefinition.an.HasFlag(cum.b))
			{
				return false;
			}
			switch (A_0.TypedDefinition.e())
			{
			case btz.a:
				return true;
			case btz.b:
			case btz.c:
			case btz.d:
			case btz.e:
			case btz.f:
			case btz.h:
			case btz.i:
			case btz.j:
			case btz.k:
			case btz.l:
				return false;
			case btz.g:
			{
				WeaponSubtype? weaponSubtype = euf.d(A_0.TypedDefinition);
				return weaponSubtype.Value != WeaponSubtype.Sledgehammer && weaponSubtype.Value != WeaponSubtype.Spear;
			}
			}
		}
		return true;
	}

	// Token: 0x06009D5D RID: 40285 RVA: 0x003DDB38 File Offset: 0x003DBD38
	public static bool a(efk A_0, cd1 A_1)
	{
		return euf.c(A_1) || (A_1.TypedDefinition.ae().GetValueOrDefault() == WeaponSubtype.Spear && A_0 != null && A_0.Feats.Contains<don>());
	}

	// Token: 0x06009D5E RID: 40286 RVA: 0x003DDB88 File Offset: 0x003DBD88
	public static float f(efk A_0)
	{
		return A_0.Defense.q().zo() / Math.Max(1f, A_0.Defense.q().zm());
	}

	// Token: 0x06009D5F RID: 40287 RVA: 0x003DDBC0 File Offset: 0x003DBDC0
	public static float e(efk A_0)
	{
		if (A_0.Gear.h().Item != null)
		{
			int? num = A_0.Gear.h().Item.Definition.ba();
			int num2 = 0;
			if (!(num.GetValueOrDefault() == num2 & num != null))
			{
				return Convert.ToSingle(A_0.Gear.h().Item.Battery / (double)A_0.Gear.h().Item.Definition.ba().Value);
			}
		}
		return 1f;
	}

	// Token: 0x06009D60 RID: 40288 RVA: 0x003DDC5C File Offset: 0x003DBE5C
	public static bool d(efk A_0)
	{
		return ((A_0.Defense.af()[DamageType.Electricity].c() < 1.0 && A_0.Defense.af()[DamageType.Electricity].a() < 1000) || A_0.Feats.Contains<e6h>()) && !A_0.CustomProperties.GetPrimitivePropertyValue<bool>("NoElectroJump", new bool?(false)).Value;
	}

	// Token: 0x06009D61 RID: 40289 RVA: 0x003DDCEC File Offset: 0x003DBEEC
	public static void a(coh A_0, efk A_1 = null)
	{
		if (A_0.MaxBattery > 0)
		{
			A_0.Battery = (double)A_0.MaxBattery;
		}
		cd1 cd = A_0 as cd1;
		if (cd != null)
		{
			if (euf.k(cd))
			{
				AmmoType item = AmmoType.ShotgunShell_6 + cuo.a.Next(3);
				if (A_1 != null)
				{
					dng dng = Enumerable.FirstOrDefault<dng>(Enumerable.Where<dng>(Enumerable.OfType<dng>(A_1.Bag.z2()), new Func<dng, bool>(euf.a.a.a)));
					if (dng != null)
					{
						item = dng.TypedDefinition.b();
					}
				}
				int num = cd.TypedDefinition.f() - cd.LoadedAmmo.Count;
				for (int i = 0; i < num; i++)
				{
					cd.LoadedAmmo.Add(item);
				}
				return;
			}
			if (eub.c(cd) || eub.d(cd.TypedDefinition.ak()))
			{
				int num2 = (int)(cd.TypedDefinition.ak() + 1);
				if (Enum.IsDefined(typeof(AmmoType), num2))
				{
					AmmoType item2 = (AmmoType)num2;
					int num3 = cd.TypedDefinition.f() - cd.LoadedAmmo.Count;
					for (int j = 0; j < num3; j++)
					{
						cd.LoadedAmmo.Add(item2);
					}
				}
			}
		}
	}

	// Token: 0x06009D62 RID: 40290 RVA: 0x003DDE54 File Offset: 0x003DC054
	public static bool b(bke A_0)
	{
		return A_0.ad() == as3.bk;
	}

	// Token: 0x06009D63 RID: 40291 RVA: 0x003DDE64 File Offset: 0x003DC064
	public static bool a(cd1 A_0, cs5 A_1)
	{
		if (A_1 != cs5.a)
		{
			if ((A_1 & cs5.b) != cs5.a && !euf.o(A_0) && !euf.b(A_0.TypedDefinition))
			{
				return false;
			}
			if ((A_1 & cs5.c) != cs5.a && (euf.o(A_0) || euf.b(A_0.TypedDefinition)))
			{
				return false;
			}
			if ((A_1 & cs5.d) != cs5.a && !euf.o(A_0) && !euf.n(A_0))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06009D64 RID: 40292 RVA: 0x003DDEE4 File Offset: 0x003DC0E4
	public static bool a(bcx A_0, cd1 A_1)
	{
		return true;
	}

	// Token: 0x06009D65 RID: 40293 RVA: 0x003DDEE8 File Offset: 0x003DC0E8
	public static int a(efk A_0, int A_1, double A_2 = 1.0)
	{
		return Convert.ToInt32((double)Math.Min(A_0.Skills.Get<jk>().g() / 2, A_1) * A_2);
	}

	// Token: 0x06009D66 RID: 40294 RVA: 0x003DDF0C File Offset: 0x003DC10C
	public static int a(efk A_0, double A_1 = 1.0)
	{
		int a_ = 0;
		if (A_0 != null)
		{
			edm edm = Enumerable.FirstOrDefault<edm>(Enumerable.Where<edm>(A_0.Offense.u().TypedDefinition.aa(), new Func<edm, bool>(euf.a.a.a)));
			if (edm != null)
			{
				a_ = edm.Power;
			}
		}
		return euf.a(A_0, a_, A_1);
	}

	// Token: 0x06009D67 RID: 40295 RVA: 0x003DDF78 File Offset: 0x003DC178
	public static double c(efk A_0)
	{
		double num = h8.a;
		if (A_0 != null && A_0.Feats.Contains<c7z>())
		{
			num += c7z.a + (double)A_0.GetSpecializationValue<c25>(true) * c25.a;
		}
		return num;
	}

	// Token: 0x06009D68 RID: 40296 RVA: 0x003DDFBC File Offset: 0x003DC1BC
	public static double a(bas A_0, efk A_1)
	{
		double num = (double)A_0.e();
		if (A_1 != null)
		{
			num += A_1.Defense.ac();
		}
		euf.a(ref num, A_0.a1(), A_1);
		kl.c(ref num, A_0.a1(), A_1);
		return num;
	}

	// Token: 0x06009D69 RID: 40297 RVA: 0x003DE004 File Offset: 0x003DC204
	public static void a(ref double A_0, efk A_1, efk A_2)
	{
		if (A_2 != null && (A_2.b(d8o.e | d8o.s) || A_2.Passive))
		{
			A_0 *= 0.5;
		}
		kl.a(ref A_0, A_1, A_2);
	}

	// Token: 0x06009D6A RID: 40298 RVA: 0x003DE040 File Offset: 0x003DC240
	public static double b(cd1 A_0)
	{
		if (A_0 != null && A_0.TypedDefinition != null)
		{
			double num = 0.0;
			foreach (a1q a1q in A_0.TypedDefinition.l())
			{
				if (a1q.DamageType == DamageType.Mechanical)
				{
					double num2 = (double)(a1q.LowerBoundary + a1q.UpperBoundary) / 2.0;
					num += num2;
				}
			}
			return num;
		}
		return 0.0;
	}

	// Token: 0x06009D6B RID: 40299 RVA: 0x003DE0E8 File Offset: 0x003DC2E8
	public static List<csk> a(IEnumerable<csk> A_0)
	{
		if (A_0 == null)
		{
			return null;
		}
		Dictionary<DamageType, csk> dictionary = new Dictionary<DamageType, csk>();
		foreach (csk value in A_0)
		{
			csk csk;
			if (dictionary.TryGetValue(value.DamageType, out csk))
			{
				dictionary[value.DamageType] = new csk(value.DamageType, csk.Amount + value.Amount);
			}
			else
			{
				dictionary[value.DamageType] = value;
			}
		}
		return Enumerable.ToList<csk>(dictionary.Values);
	}

	// Token: 0x06009D6C RID: 40300 RVA: 0x003DE19C File Offset: 0x003DC39C
	public static int a(efk A_0, bool A_1)
	{
		if (A_0 != null)
		{
			int num = 0;
			if (A_0.Feats.Contains<ej3>())
			{
				num += ej3.d;
			}
			if (A_0.Feats.Contains<duv>())
			{
				num += duv.d;
			}
			num = Math.Min(10 + 5 * A_0.Level, num);
			int val;
			if (A_1 && dk2.e())
			{
				val = A_0.Skills.Get<e8k>().g();
			}
			else
			{
				val = A_0.Skills.Get<ct7>().g();
			}
			return Math.Max(val, num);
		}
		return 0;
	}

	// Token: 0x06009D6D RID: 40301 RVA: 0x003DE234 File Offset: 0x003DC434
	public static void a(cnm A_0, ref a1q A_1)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<n4>())
		{
			double num = n4.a(A_0.b8());
			A_1 = a1q.a(A_1, 1.0 + num);
		}
	}

	// Token: 0x06009D6E RID: 40302 RVA: 0x003DE290 File Offset: 0x003DC490
	public static int b(efk A_0)
	{
		if (A_0 != null && A_0.Gear.l().Item != null)
		{
			double num = 1.0;
			if (A_0.Feats.Contains<e2c>())
			{
				num = Math.Round(num + e2c.b + (double)A_0.GetSpecializationValue<ai1>(true) * ai1.a, 2);
			}
			ddo ddo = Enumerable.FirstOrDefault<ddo>(A_0.StatusEffects.Get<ddo>());
			if (ddo != null)
			{
				num += ddo.a(A_0);
			}
			return Convert.ToInt32((double)A_0.Gear.l().Item.fu().b() * num);
		}
		return 0;
	}

	// Token: 0x06009D6F RID: 40303 RVA: 0x003DE334 File Offset: 0x003DC534
	public static bool a(WeaponSubtype A_0, WeaponAggregateSubtype A_1)
	{
		WeaponAggregateSubtype[] array = as3.ao[A_0];
		return array != null && Enumerable.Contains<WeaponAggregateSubtype>(array, A_1);
	}

	// Token: 0x06009D70 RID: 40304 RVA: 0x003DE35C File Offset: 0x003DC55C
	public static bool c(AmmoType A_0)
	{
		return A_0 == AmmoType.Knife || A_0 == AmmoType.Dagger || A_0 == AmmoType.Spear || A_0 == AmmoType.Sword || A_0 == AmmoType.ObsidianSword;
	}

	// Token: 0x06009D71 RID: 40305 RVA: 0x003DE394 File Offset: 0x003DC594
	public static double a(efk A_0)
	{
		double result = 1.0;
		if (A_0 != null && A_0.BaseAbilities.Dexterity > aiy.k)
		{
			result = 1.0 - (double)(A_0.BaseAbilities.Dexterity - aiy.k) * aiy.l;
		}
		return result;
	}

	// Token: 0x06009D72 RID: 40306 RVA: 0x003DE3EC File Offset: 0x003DC5EC
	public static int b(AmmoType A_0)
	{
		if (A_0 == AmmoType.Grenade_40_Thermobaric)
		{
			return 3;
		}
		if (A_0 == AmmoType.Grenade_40_Cluster)
		{
			return 3;
		}
		if (A_0 == AmmoType.Grenade_25_Incendiary)
		{
			return 2;
		}
		if (A_0 / AmmoType.Caliber_5 == (AmmoType)9)
		{
			return 2;
		}
		return 1;
	}

	// Token: 0x06009D73 RID: 40307 RVA: 0x003DE424 File Offset: 0x003DC624
	public static int a(AmmoType A_0)
	{
		if (A_0 == AmmoType.Rocket_84_Kin)
		{
			return 0;
		}
		if (A_0 == AmmoType.Rocket_84_Cs)
		{
			return 4;
		}
		return 3;
	}

	// Token: 0x06009D74 RID: 40308 RVA: 0x003DE444 File Offset: 0x003DC644
	private static string a(string A_0, string A_1)
	{
		string str = A_0;
		if (!string.IsNullOrWhiteSpace(A_1))
		{
			str += " ";
		}
		return str + A_1;
	}

	// Token: 0x06009D75 RID: 40309 RVA: 0x003DE474 File Offset: 0x003DC674
	private static double a(efk A_0, cd1 A_1, bool A_2)
	{
		if (A_0 != null && A_0.Vehicle != null)
		{
			double num = A_0.Vehicle.aa();
			double num2 = A_0.Vehicle.ao();
			if (A_0.Vehicle.y() == bws.b || A_0.Vehicle.y() == bws.a)
			{
				if (A_0.Feats.Contains<ej3>())
				{
					num += ej3.a;
					num2 += ej3.b;
				}
				b02 microfeat = A_0.GetMicrofeat<b02>();
				if (microfeat != null)
				{
					num += microfeat.a();
				}
				if (A_0.Feats.Contains<duv>())
				{
					num += duv.a;
					num2 += duv.b;
				}
				if (A_0.Feats.Contains<dtv>())
				{
					num += dtv.b;
					num2 += dtv.b;
				}
				if (num < 1.0 && A_2)
				{
					num += (1.0 - num) / 2.0;
				}
			}
			if (A_1 != null)
			{
				foreach (bns bns in A_1.TypedDefinition.n())
				{
					num += Math.Max(0.0, Math.Min(1.0, bns.af6(A_0, A_2)));
				}
			}
			double num3 = Math.Min(1.0, num);
			if (A_2)
			{
				num3 *= Math.Min(1.0, num2);
			}
			return num3;
		}
		return 0.0;
	}

	// Token: 0x06009D76 RID: 40310 RVA: 0x003DE61C File Offset: 0x003DC81C
	private static void a(cwt A_0, cmn A_1)
	{
		if (A_1.g != 1.0 && A_0.f != null && A_0.f.Count > 0)
		{
			for (int i = 0; i < A_0.f.Count; i++)
			{
				csk csk = A_0.f[i];
				A_0.f[i] = new csk(csk.DamageType, Math.Max(1, Convert.ToInt32((double)csk.Amount * A_1.g)));
			}
		}
	}

	// Token: 0x06009D77 RID: 40311 RVA: 0x003DE6B4 File Offset: 0x003DC8B4
	public static void a(List<csk> A_0, IEnumerable<csk> A_1)
	{
		if (A_1 == null)
		{
			return;
		}
		foreach (csk a_ in A_1)
		{
			euf.a(A_0, a_);
		}
	}

	// Token: 0x06009D78 RID: 40312 RVA: 0x003DE70C File Offset: 0x003DC90C
	public static void a(List<csk> A_0, csk A_1)
	{
		if (A_0 == null)
		{
			A_0 = new List<csk>();
		}
		if (A_0.Count > 0)
		{
			for (int i = 0; i < A_0.Count; i++)
			{
				csk value = A_0[i];
				if (value.DamageType == A_1.DamageType)
				{
					value.Amount += A_1.Amount;
					A_0[i] = value;
					return;
				}
			}
		}
		A_0.Add(A_1);
	}

	// Token: 0x06009D79 RID: 40313 RVA: 0x003DE788 File Offset: 0x003DC988
	public static bool a(cd1 A_0)
	{
		return euf.a((A_0 != null) ? A_0.TypedDefinition : null);
	}

	// Token: 0x06009D7A RID: 40314 RVA: 0x003DE7A4 File Offset: 0x003DC9A4
	public static bool a(bke A_0)
	{
		if (A_0 == null)
		{
			return false;
		}
		WeaponSubtype? weaponSubtype = euf.d(A_0);
		return A_0.e() == btz.a || A_0.e() == btz.b || (weaponSubtype != null && weaponSubtype.Value >= WeaponSubtype.Knife && weaponSubtype.Value < (WeaponSubtype)400) || weaponSubtype.GetValueOrDefault() == WeaponSubtype.Unarmed || euf.e(A_0);
	}

	// Token: 0x04003CBD RID: 15549
	private static Random a = new Random();

	// Token: 0x02001C09 RID: 7177
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06009D7E RID: 40318 RVA: 0x003DE844 File Offset: 0x003DCA44
		internal int a(a1q A_0)
		{
			return (A_0.UpperBoundary + A_0.LowerBoundary) / 2;
		}

		// Token: 0x06009D7F RID: 40319 RVA: 0x003DE858 File Offset: 0x003DCA58
		internal bool a(dng A_0)
		{
			return eub.g(A_0.TypedDefinition.b()) == AmmoType.ShotgunShell;
		}

		// Token: 0x06009D80 RID: 40320 RVA: 0x003DE874 File Offset: 0x003DCA74
		internal bool a(edm A_0)
		{
			return A_0.Name == "spearGuard";
		}

		// Token: 0x04003CBE RID: 15550
		public static readonly euf.a a = new euf.a();

		// Token: 0x04003CBF RID: 15551
		public static Func<a1q, int> b;

		// Token: 0x04003CC0 RID: 15552
		public static Func<dng, bool> c;

		// Token: 0x04003CC1 RID: 15553
		public static Func<edm, bool> d;
	}
}
