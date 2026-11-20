using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020005AC RID: 1452
public sealed class dm1 : a9t, amj
{
	// Token: 0x060026B1 RID: 9905 RVA: 0x000DD6B8 File Offset: 0x000DB8B8
	public dm1(efk A_0)
	{
		czh.a(A_0, "character");
		wj wj = wj.a();
		if (wj.c())
		{
			this.ae = egg.ai;
			this.ah = new d22(egg.@as, adi.a);
			this.ai = new d22(egg.w, adi.a);
		}
		else
		{
			this.ae = wj.dm;
			this.ah = new d22(wj.dn, adi.a);
			this.ai = new d22(wj.dp, adi.a);
			this.al = wj.dq;
			this.am = wj.du;
			this.an = "        ";
		}
		this.af = new d22(this.ae, Color.LightGray);
		this.ag = new d22(this.ae, dm1.a);
		this.h = A_0;
		this.i();
		this.h();
		if (wj.c())
		{
			this.ac = new dsy(this, this, esj.a(), 400, null, null, 3000, false, false);
			return;
		}
		this.ac = new dsy(this, this, esj.a(), (int)((float)base.Size.c * 0.6f), null, null, 3000, false, false);
	}

	// Token: 0x060026B2 RID: 9906 RVA: 0x000DD880 File Offset: 0x000DBA80
	public override void iv(e6d A_0, cp9 A_1)
	{
		this.ac.a(A_0);
		base.iv(A_0, A_1);
		Point point = base.at();
		if (!wj.a().c() && this.ao != null && this.ap != null && this.aq == dm1.f)
		{
			foreach (dm1.a a in this.ao)
			{
				if (a == this.ap)
				{
					int num = a.c;
					int num2 = base.Size.c - wj.a().ds - (a.a + num);
					if (num2 < 0)
					{
						num += num2;
					}
					Rectangle a_ = new Rectangle(point.X + a.a, point.Y + a.b, num, a.d);
					Texture2D resource = A_1.a.GetResource<Texture2D>("Locale\\Meta\\Blank", null);
					A_1.b().xa(resource, a_, adi.a * 0.25f);
				}
			}
		}
		if (dm1.f == baf.a)
		{
			this.a(A_1, point, 15, 110, this.m, this.n, "Overview.State", 0, -50);
			this.a(A_1, point, this.ak, 110, this.o, this.p, "Overview.BaseAbilities", 1, 0);
			return;
		}
		if (dm1.f == baf.b)
		{
			this.a(A_1, point, 15, 110, this.q, this.r, "Overview.Defense", 5, 0);
			this.a(A_1, point, this.ak, 110, this.u, this.v, "Overview.Resistances", 3, -50);
			this.a(A_1, point, 15, 310, this.w, this.x, "Overview.Shield", 4, 0);
			this.a(A_1, point, this.ak, 310, this.s, this.t, "Overview.Subterfuge", 6, -50);
			return;
		}
		this.a(A_1, point, 15, 110, this.y, this.z, "Overview.Weapon", 2, 0);
		if (this.aa.ContainsKey(dm1.g))
		{
			this.a(A_1, point, this.ak, 150, this.aa[dm1.g][0], this.aa[dm1.g][1], null, -1, 0);
		}
	}

	// Token: 0x060026B3 RID: 9907 RVA: 0x000DDB24 File Offset: 0x000DBD24
	public override void ag5(e6d A_0)
	{
		if ((this.ab += A_0.a().ElapsedGameTime.TotalMilliseconds) > 250.0)
		{
			this.ab = 0.0;
			this.g();
		}
		foreach (cao cao in this.ad)
		{
			cao.Visible = (dm1.f == baf.c);
		}
		base.ag5(A_0);
	}

	// Token: 0x060026B4 RID: 9908 RVA: 0x000DDBD0 File Offset: 0x000DBDD0
	public ecs yf(euz A_0)
	{
		wj wj = wj.a();
		MouseState state = Mouse.GetState();
		Point a_ = new Point(state.X, state.Y);
		Point a_2 = base.at();
		Point point = d05.a(a_, a_2, true);
		foreach (cao cao in this.ad)
		{
			if (A_0 == cao)
			{
				return new ecs(new List<dl6>
				{
					new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), adi.c), cao.Tag.ToString().a(), null)
					})
				});
			}
		}
		this.ao = new List<dm1.a>();
		int num = 21;
		int num2 = 235;
		int num3 = 0;
		int a_3 = this.ak - 5;
		if (!wj.c())
		{
			cne serviceOrThrow = bpo.GetServiceOrThrow<cne>();
			SpriteFont resource = serviceOrThrow.GetResource<SpriteFont>(wj.dm, null);
			SpriteFont resource2 = serviceOrThrow.GetResource<SpriteFont>(wj.dn, null);
			SpriteFont resource3 = serviceOrThrow.GetResource<SpriteFont>(wj.dp, null);
			num3 = resource2.LineSpacing + resource3.LineSpacing + wj.@do;
			num = Convert.ToInt32(resource.MeasureString(" ").Y);
			num2 = this.b(num2);
			a_3 = this.b(a_3);
		}
		if (dm1.f == baf.a)
		{
			string text;
			if (dk2.e() && dk2.f())
			{
				text = qv.b("BaseAbilities/HeavyWeapons_Full");
			}
			else if (dk2.e())
			{
				text = qv.b("BaseAbilities/HeavyWeapons_HeavyDuty");
			}
			else if (dk2.f())
			{
				text = qv.b("BaseAbilities/HeavyWeapons_Expedition");
			}
			else
			{
				text = qv.b("BaseAbilities/HeavyWeapons_Base");
			}
			int num4 = 133;
			int num5 = 2;
			if (!wj.c())
			{
				num4 = this.am + num3;
			}
			this.ao.Add(new dm1.a(13, num4, num2, num, dh9.c("Health"), qv.b("CombatStatTooltips/Health")));
			this.ao.Add(new dm1.a(13, num4 + num, num2, num, dh9.c("Shield"), qv.b("CombatStatTooltips/Shield")));
			if (this.h.PsiEmpathy)
			{
				this.ao.Add(new dm1.a(13, num4 + num * 2, num2, num, dh9.c("Psi"), qv.b("CombatStatTooltips/Psi")));
				num5 = 3;
				if (dm9.f)
				{
					this.ao.Add(new dm1.a(13, num4 + num * 3, num2, num, dh9.c("Psi Reserves"), qv.b("CombatStatTooltips/PsiReserve")));
					num5++;
				}
			}
			this.ao.Add(new dm1.a(13, num4 + num * num5, num2, num, dh9.c("HealingEffectiveness"), qv.b("CombatStatTooltips/HealingEffectiveness")));
			this.ao.Add(new dm1.a(13, num4 + num * (num5 + 1), num2, num, dh9.c("ActionPoints"), qv.b("CombatStatTooltips/ActionPoints")));
			this.ao.Add(new dm1.a(13, num4 + num * (num5 + 2), num2, num, dh9.c("MovementPoints"), qv.b("CombatStatTooltips/MovementPoints")));
			this.ao.Add(new dm1.a(a_3, num4, num2, num, dh9.a(BaseAbilityEnum.Strength), qv.a("BaseAbilities/Strength", new object[]
			{
				text
			})));
			this.ao.Add(new dm1.a(a_3, num4 + num, num2, num, dh9.a(BaseAbilityEnum.Dexterity), qv.b("BaseAbilities/Dexterity")));
			this.ao.Add(new dm1.a(a_3, num4 + num * 2, num2, num, dh9.a(BaseAbilityEnum.Agility), qv.b("BaseAbilities/Agility")));
			this.ao.Add(new dm1.a(a_3, num4 + num * 3, num2, num, dh9.a(BaseAbilityEnum.Constitution), qv.b("BaseAbilities/Constitution")));
			this.ao.Add(new dm1.a(a_3, num4 + num * 4, num2, num, dh9.a(BaseAbilityEnum.Perception), qv.b("BaseAbilities/Perception")));
			this.ao.Add(new dm1.a(a_3, num4 + num * 5, num2, num, dh9.a(BaseAbilityEnum.Will), qv.b("BaseAbilities/Will")));
			this.ao.Add(new dm1.a(a_3, num4 + num * 6, num2, num, dh9.a(BaseAbilityEnum.Intelligence), qv.b("BaseAbilities/Intelligence")));
		}
		else if (dm1.f == baf.b)
		{
			int num6 = 133;
			if (!wj.c())
			{
				num6 = this.am + num3;
			}
			this.ao.Add(new dm1.a(13, num6, num2, num, dh9.a(SkillEnum.Dodge), qv.b("CombatStatTooltips/Dodge")));
			this.ao.Add(new dm1.a(13, num6 + num, num2, num, dh9.a(SkillEnum.Evasion), qv.b("CombatStatTooltips/Evasion")));
			this.ao.Add(new dm1.a(13, num6 + num * 2, num2, num, dh9.c("Fortitude"), qv.b("CombatStatTooltips/Fortitude")));
			this.ao.Add(new dm1.a(13, num6 + num * 3, num2, num, dh9.c("Resolve"), qv.b("CombatStatTooltips/Resolve")));
			this.ao.Add(new dm1.a(13, num6 + num * 4, num2, num, dh9.c("CombatStatsWindow_WeaponCrit"), qv.b("CombatStatTooltips/ToGetWeaponCritChanceMod")));
			this.ao.Add(new dm1.a(13, num6 + num * 5, num2, num, dh9.c("CombatStatsWindow_PsiCrit"), qv.b("CombatStatTooltips/ToGetPsiCritChanceMod")));
			this.ao.Add(new dm1.a(13, num6 + num * 6, num2, num, dh9.c("ArmorPenalty"), qv.b("CombatStatTooltips/ArmorPenalty")));
			int num7 = 335;
			if (!wj.c())
			{
				num7 = 310;
				num7 = num7 - 110 + this.am;
				num7 = this.a(num7 - this.am) + this.am + num3;
			}
			this.ao.Add(new dm1.a(13, num7, num2, num, dh9.c("CombatStatsWindow_ShieldCapacity"), qv.b("CombatStatTooltips/ShieldCapacity")));
			this.ao.Add(new dm1.a(13, num7 + num, num2, num, dh9.c("CombatStatsWindow_ShieldCapacity_Shielding_VeryLow"), qv.b("CombatStatTooltips/ShieldingVeryLow") + " " + qv.b("CombatStatTooltips/ShieldingDescription")));
			this.ao.Add(new dm1.a(13, num7 + num * 2, num2, num, dh9.c("CombatStatsWindow_ShieldCapacity_Shielding_Low"), qv.b("CombatStatTooltips/ShieldingLow") + " " + qv.b("CombatStatTooltips/ShieldingDescription")));
			this.ao.Add(new dm1.a(13, num7 + num * 3, num2, num, dh9.c("CombatStatsWindow_ShieldCapacity_Shielding_Medium"), qv.b("CombatStatTooltips/ShieldingMedium") + " " + qv.b("CombatStatTooltips/ShieldingDescription")));
			this.ao.Add(new dm1.a(13, num7 + num * 4, num2, num, dh9.c("CombatStatsWindow_ShieldCapacity_Shielding_High"), qv.b("CombatStatTooltips/ShieldingHigh") + " " + qv.b("CombatStatTooltips/ShieldingDescription")));
			this.ao.Add(new dm1.a(13, num7 + num * 5, num2, num, dh9.c("CombatStatsWindow_ShieldCapacity_Shielding_VeryHigh"), qv.b("CombatStatTooltips/ShieldingVeryHigh") + " " + qv.b("CombatStatTooltips/ShieldingDescription")));
			this.ao.Add(new dm1.a(a_3, num6, num2, num, dh9.c("CombatStatsWindow_MechanicalResistance"), qv.b("CombatStatTooltips/ResistanceMechanical") + " " + qv.b("CombatStatTooltips/ResistanceDescription")));
			this.ao.Add(new dm1.a(a_3, num6 + num, num2, num, dh9.c("CombatStatsWindow_HeatResistance"), qv.b("CombatStatTooltips/ResistanceHeat") + " " + qv.b("CombatStatTooltips/ResistanceDescription")));
			this.ao.Add(new dm1.a(a_3, num6 + num * 2, num2, num, dh9.c("CombatStatsWindow_ColdResistance"), qv.b("CombatStatTooltips/ResistanceCold") + " " + qv.b("CombatStatTooltips/ResistanceDescription")));
			this.ao.Add(new dm1.a(a_3, num6 + num * 3, num2, num, dh9.c("CombatStatsWindow_ElectricalResistance"), qv.b("CombatStatTooltips/ResistanceElectricity") + " " + qv.b("CombatStatTooltips/ResistanceDescription")));
			this.ao.Add(new dm1.a(a_3, num6 + num * 4, num2, num, dh9.c("CombatStatsWindow_AcidResistance"), qv.b("CombatStatTooltips/ResistanceAcid") + " " + qv.b("CombatStatTooltips/ResistanceDescription")));
			this.ao.Add(new dm1.a(a_3, num6 + num * 5, num2, num, dh9.c("CombatStatsWindow_EnergyResistance"), qv.b("CombatStatTooltips/ResistanceEnergy") + " " + qv.b("CombatStatTooltips/ResistanceDescription")));
			this.ao.Add(new dm1.a(a_3, num6 + num * 6, num2, num, dh9.c("CombatStatsWindow_BioResistance"), qv.b("CombatStatTooltips/ResistanceBio") + " " + qv.b("CombatStatTooltips/ResistanceDescription")));
			this.ao.Add(new dm1.a(a_3, num7, num2, num, dh9.a(SkillEnum.Stealth), qv.b("CombatStatTooltips/Stealth")));
			this.ao.Add(new dm1.a(a_3, num7 + num, num2, num, dh9.c("Detection"), qv.b("CombatStatTooltips/Detection")));
			this.ao.Add(new dm1.a(a_3, num7 + num * 2, num2, num, dh9.c("TrapDetection"), qv.b("CombatStatTooltips/TrapDetection")));
		}
		else if (dm1.f == baf.c)
		{
			bke bke = (this.h.Offense.u() != null) ? this.h.Offense.u().TypedDefinition : null;
			int num8 = 133;
			if (!wj.c())
			{
				num8 = this.am + num3;
			}
			this.ao.Add(new dm1.a(13, num8, num2, num, dh9.c("CombatStatsWindow_WeaponDamage"), qv.b("CombatStatTooltips/WeaponDamage")));
			this.ao.Add(new dm1.a(13, num8 + num, num2, num, dh9.c("CombatStatsWindow_ActionPointCost"), qv.b("CombatStatTooltips/WeaponActionPointCost")));
			this.ao.Add(new dm1.a(13, num8 + num * 2, num2, num, dh9.c("CombatStatsWindow_ImpactSpeed"), qv.b("CombatStatTooltips/WeaponImpactSpeed")));
			this.ao.Add(new dm1.a(13, num8 + num * 3, num2, num, dh9.c("CombatStatsWindow_CriticalHitChance"), qv.b("CombatStatTooltips/WeaponCritChance")));
			this.ao.Add(new dm1.a(13, num8 + num * 4, num2, num, dh9.c("CombatStatsWindow_CriticalHitDamageBonus"), qv.b("CombatStatTooltips/WeaponCritBonus")));
			this.ao.Add(new dm1.a(13, num8 + num * 5, num2, num, dh9.c("CombatStatsWindow_SpecialAttackBonusDamage"), qv.b("CombatStatTooltips/SpecialAttackBonusDamage")));
			this.ao.Add(new dm1.a(13, num8 + num * 6, num2, num, dh9.c("Initiative"), qv.b("CombatStatTooltips/Initiative")));
			this.ao.Add(new dm1.a(13, num8 + num * 7, num2, num, dh9.c("CombatStatsWindow_MaximumWeaponRange"), qv.b("CombatStatTooltips/WeaponMaxRange")));
			if (bke != null && bke.h() > 0f && bke.ad() != bke.h())
			{
				this.ao.Add(new dm1.a(13, num8 + num * 8, num2, num, dh9.c("CombatStatsWindow_OptimalWeaponRange"), qv.b("CombatStatTooltips/WeaponOptimalRange")));
			}
			num8 = 173;
			if (!wj.c())
			{
				num8 = 150;
				num8 = num8 - 110 + this.am;
				num8 = this.a(num8 - this.am) + this.am + num3;
			}
			string arg = dm1.g.ToString();
			string str = dh9.a(dm1.g);
			this.ao.Add(new dm1.a(a_3, num8, num2, num, str + " " + dh9.c("CombatStatsWindow_Psi_Skill"), qv.b(string.Format("CombatStatTooltips/{0}Skill", arg))));
			this.ao.Add(new dm1.a(a_3, num8 + num, num2, num, str + " " + dh9.c("CombatStatsWindow_Psi_CriticalHitChance"), qv.b(string.Format("CombatStatTooltips/{0}CritChance", arg))));
			this.ao.Add(new dm1.a(a_3, num8 + num * 2, num2, num, str + " " + dh9.c("CombatStatsWindow_Psi_CriticalHitDamageBonus"), qv.b(string.Format("CombatStatTooltips/{0}CritBonus", arg))));
			this.ao.Add(new dm1.a(a_3, num8 + num * 3, num2, num, str + " " + dh9.c("CombatStatsWindow_Psi_BasePsiCostModifier"), qv.b(string.Format("CombatStatTooltips/{0}PsiCost", arg))));
		}
		foreach (dm1.a a in this.ao)
		{
			if (point.X >= a.a && point.Y >= a.b && point.X < a.a + a.c && point.Y < a.b + a.d)
			{
				this.ap = a;
				this.aq = dm1.f;
				return new ecs(new List<dl6>
				{
					new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), adi.c), a.e, null)
					}),
					new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), Color.White), null, null)
					}),
					new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), Color.LightGray), a.f, null)
					})
				});
			}
		}
		return null;
	}

	// Token: 0x060026B5 RID: 9909 RVA: 0x000DEB9C File Offset: 0x000DCD9C
	private void a(cp9 A_0, Point A_1, int A_2, int A_3, dn3 A_4, dn3 A_5, string A_6, int A_7, int A_8 = 0)
	{
		wj wj = wj.a();
		A_3 = A_3 - 110 + this.am;
		int num = 6;
		if (wj.c())
		{
			num = 0;
		}
		if (A_4 != null)
		{
			A_4.a(new Point(A_1.X + this.b(A_2), A_1.Y + this.a(A_3 - this.am) + this.am - num), A_0, null, 1f);
		}
		if (A_5 != null)
		{
			A_5.a(new Point(A_1.X + this.b(A_2 + this.aj + A_8), A_1.Y + this.a(A_3 - this.am) + this.am - num), A_0, null, 1f);
		}
		if (wj.c())
		{
			if (A_6 != null)
			{
				c3i c3i = ejh.b(A_6, A_0.a);
				if (c3i != null)
				{
					c3i.a(A_0, new Vector2((float)(A_1.X + this.b(A_2)), (float)(A_1.Y + this.a(A_3 - this.am) + this.am - 10)), Color.White, 1f, 0, null);
					return;
				}
			}
		}
		else if (A_7 >= 0)
		{
			SpriteFont resource = A_0.a.GetResource<SpriteFont>(this.ah.a, null);
			Texture2D a_ = A_0.a.us(wj.f, null);
			Vector2 a_2 = new Vector2((float)(A_1.X + this.b(A_2)), (float)(A_1.Y + this.a(A_3 - this.am) + this.am - num - wj.dx.d / 2 + resource.LineSpacing / 2));
			Rectangle value = new Rectangle(wj.dw.X, wj.dw.Y + A_7 * wj.dx.d, wj.dx.c, wj.dx.d);
			A_0.b().w5(a_, a_2, new Rectangle?(value), adi.a);
		}
	}

	// Token: 0x060026B6 RID: 9910 RVA: 0x000DEDD0 File Offset: 0x000DCFD0
	private new void i()
	{
		base.Text = dh9.c("CombatStatsWindow_WindowName");
		wj wj = wj.a();
		if (wj.c())
		{
			base.Size = new esj(495, 480);
		}
		else
		{
			base.Size = wj.dr;
		}
		this.i = new ec9();
		if (wj.c())
		{
			this.i.c = bo1.v;
			this.i.Location = new Point(10, 38);
			this.i.Size = new esj(base.Size.c - this.i.Location.X * 2, 36);
		}
		else
		{
			this.i.c = wj.f;
			this.i.e = wj.dc;
			this.i.d = new esj?(wj.dd);
			this.i.Location = new Point(10 + wj.ds, wj.ci.d + wj.ds);
			esj esj = new esj(base.Size.c - 20 - 2 * wj.ds, wj.dt);
			esj.d += wj.g - esj.d % wj.g;
			this.i.Size = esj;
		}
		this.i.Gravity = axy.b;
		this.aox(this.i);
		this.j = this.a(dh9.c("CombatStatsWindow_Tab_Base"), 0);
		if (wj.c())
		{
			this.j.Location = new Point(20, 45);
		}
		this.j.Tag = baf.a;
		this.j.c(new EventHandler<b25>(this.b));
		this.j.Checked = (dm1.f == baf.a);
		this.aox(this.j);
		this.k = this.a(dh9.c("CombatStatsWindow_Tab_Defense"), 1);
		if (wj.c())
		{
			this.k.Location = new Point(this.j.Location.X + this.j.Size.c + 40, 45);
		}
		this.k.Tag = baf.b;
		this.k.c(new EventHandler<b25>(this.b));
		this.k.Checked = (dm1.f == baf.b);
		this.aox(this.k);
		this.l = this.a(dh9.c("CombatStatsWindow_Tab_Offense"), 2);
		if (wj.c())
		{
			this.l.Location = new Point(this.k.Location.X + this.k.Size.c + 40, 45);
		}
		this.l.Tag = baf.c;
		this.l.c(new EventHandler<b25>(this.b));
		this.l.Checked = (dm1.f == baf.c);
		this.aox(this.l);
		if (!ddv.a(dm1.g))
		{
			dm1.g = PsiSchool.ThoughtControl;
		}
		int num = 0;
		foreach (PsiSchool psiSchool in this.h.Offense.ag().Keys)
		{
			if (ddv.a(psiSchool))
			{
				cao cao;
				if (wj.c())
				{
					cao = new bi("Overview." + psiSchool.ToString(), "Overview." + psiSchool.ToString(), "Overview." + psiSchool.ToString() + ".Highlighted", null, null)
					{
						Location = new Point(dm1.d.X + num * 35, dm1.d.Y)
					};
				}
				else
				{
					int num2 = (int)psiSchool;
					if (num2 < 3)
					{
						num2 = 2 - num2;
					}
					cao = new bw9
					{
						Location = new Point(this.b(this.ak) + num * (wj.dx.c + wj.ds), wj.ci.d + wj.ds * 2 + this.i.Size.d),
						Size = wj.dx,
						a = wj.f,
						b = new Point(wj.dw.X, wj.dw.Y + wj.dx.d * (7 + num2)),
						c = wj.dx,
						Color = adi.a,
						d = adi.d,
						g = new Rectangle?(wj.dy)
					};
				}
				cao.Tag = psiSchool;
				cao.Visible = false;
				cao.c(new EventHandler<b25>(this.a));
				cao.Checked = (dm1.g == psiSchool);
				this.ad.Add(cao);
				this.aox(cao);
				num++;
			}
		}
	}

	// Token: 0x060026B7 RID: 9911 RVA: 0x000DF370 File Offset: 0x000DD570
	private zt a(string A_0, int A_1)
	{
		wj wj = wj.a();
		zt zt = new zt();
		zt.Text = A_0;
		if (wj.c())
		{
			zt.Font = egg.ap;
			zt.TextLabelOffset = new Point(0, 3);
			zt.Size = new esj(112, 22);
		}
		else
		{
			zt.Font = wj.dn;
			zt.TextLabelOffset = new Point(0, egg.b(zt.Font));
			zt.Size = wj.dv;
			int num = (this.i.Size.c - wj.ds - 2 * wj.ds) / 3;
			zt.Location = new Point(this.i.Location.X + wj.ds + (num + wj.ds) * A_1, this.i.Location.Y + (this.i.Size.d - zt.Size.d) / 2);
			zt.d = wj.f;
			zt.e = wj.fg;
			zt.f = new esj?(wj.fh);
		}
		zt.b = Color.Black;
		zt.a = adi.a;
		zt.HorizontalAlignment = cab.b;
		return zt;
	}

	// Token: 0x060026B8 RID: 9912 RVA: 0x000DF4BC File Offset: 0x000DD6BC
	private new void h()
	{
		this.g();
		this.a();
		this.c();
		this.b();
		this.d();
		this.e();
		this.f();
		this.a(PsiSchool.ThoughtControl);
		this.a(PsiSchool.Psychokinesis);
		this.a(PsiSchool.Metathermics);
		this.a(PsiSchool.TemporalManipulation);
	}

	// Token: 0x060026B9 RID: 9913 RVA: 0x000DF510 File Offset: 0x000DD710
	private void a(ecs A_0)
	{
		if (!egg.v)
		{
			A_0.a.Insert(1, new dl6(new List<bph>
			{
				new bph(this.ai, " ", null)
			}));
		}
	}

	// Token: 0x060026BA RID: 9914 RVA: 0x000DF554 File Offset: 0x000DD754
	private new void g()
	{
		ecs ecs = new ecs();
		ecs.a.AddRange(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(this.ah, this.an + dh9.c("CombatStatsWindow_Caption_State"), null)
			})
		});
		ecs.a.AddRange(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(this.af, dh9.c("Health") + ":", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.af, dh9.c("Shield") + ":", null)
			})
		});
		ecs ecs2 = new ecs();
		ecs2.a.AddRange(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(this.ah, " ", null)
			})
		});
		ecs2.a.AddRange(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(this.ag, string.Format("{0} / {1}", (int)this.h.Defense.q().zo(), (int)this.h.Defense.q().zm()), null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.ag, string.Format("{0} / {1}", (int)this.h.Defense.i5(), this.h.Defense.p()), null)
			})
		});
		if (this.h.PsiEmpathy)
		{
			ecs.a.AddRange(new List<dl6>
			{
				new dl6(new List<bph>
				{
					new bph(this.af, dh9.c("Psi") + ":", null)
				})
			});
			ecs2.a.AddRange(new List<dl6>
			{
				new dl6(new List<bph>
				{
					new bph(this.ag, string.Format("{0} / {1} ({2}{3})", new object[]
					{
						(int)this.h.Offense.aa().zo(),
						(int)this.h.Offense.aa().zm(),
						(this.h.Offense.ao() < 0) ? "-" : "+",
						Math.Abs(this.h.Offense.ao())
					}), null)
				})
			});
			if (dm9.f)
			{
				ecs.a.AddRange(new List<dl6>
				{
					new dl6(new List<bph>
					{
						new bph(this.af, dh9.c("PsiReserves") + ":", null)
					})
				});
				ecs2.a.AddRange(new List<dl6>
				{
					new dl6(new List<bph>
					{
						new bph(this.ag, string.Format("{0} / {1}", (int)this.h.Offense.ab().zo(), (int)this.h.Offense.ab().zm()), null)
					})
				});
			}
		}
		ecs.a.AddRange(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(this.af, dh9.c("HealingEffectivenessShort") + ":", null)
			})
		});
		ecs2.a.AddRange(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(this.ag, string.Format("{0}%", Convert.ToInt32(this.h.Defense.aa() * 100.0)), null)
			})
		});
		ecs.a.AddRange(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(this.af, dh9.c("AP") + ":", null)
			})
		});
		ecs2.a.AddRange(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(this.ag, string.Format("{0}", this.h.Offense.n()), null)
			})
		});
		ecs.a.AddRange(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(this.af, dh9.c("MP") + ":", null)
			})
		});
		ecs2.a.AddRange(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(this.ag, string.Format("{0}", this.h.Offense.m()), null)
			})
		});
		this.a(ecs);
		this.a(ecs2);
		this.m = ecs.b();
		this.n = ecs2.b();
	}

	// Token: 0x060026BB RID: 9915 RVA: 0x000DFB0C File Offset: 0x000DDD0C
	private new void f()
	{
		bke bke = (this.h.Offense.u() != null) ? this.h.Offense.u().TypedDefinition : null;
		int num = this.h.Offense.av();
		ecs ecs = new ecs(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(this.ah, this.an + dh9.c("CombatStatsWindow_Caption_Weapon"), null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.af, dh9.c("Damage") + ":", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.af, dh9.c("CombatStatsWindow_Label_Actionpoints") + ":", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.af, dh9.c("CombatStatsWindow_Label_Impactspeed") + ":", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.af, dh9.c("CombatStatsWindow_Label_Criticalchance") + ":", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.af, dh9.c("CombatStatsWindow_Label_Criticalbonus") + ":", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.af, dh9.c("CombatStatsWindow_Label_Specialattackbonus") + ":", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.af, dh9.c("Initiative") + ":", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.af, dh9.c("CombatStatsWindow_Label_Maxrange") + ":", null)
			})
		});
		if (bke != null)
		{
			Color a_ = Color.White;
			int num2 = 0;
			int num3 = 0;
			if (bke.l() != null && bke.l().Count > 0)
			{
				double num4 = qw.a(bke, euf.a(this.h, bke.e(), false));
				double num5 = 0.0;
				if (bke.e() == btz.g)
				{
					WeaponSubtype? a_2 = euf.d(bke);
					num5 = qw.a(this.h, bke, a_2);
				}
				if (bke.l().Count > 1)
				{
					using (List<a1q>.Enumerator enumerator = bke.l().GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							a1q a1q = enumerator.Current;
							if (bke.e() == btz.g && a1q.DamageType == DamageType.Mechanical)
							{
								num3 += Convert.ToInt32((1.0 + num4 + num5) * (double)a1q.UpperBoundary);
								num2 += Convert.ToInt32((1.0 + num4 + num5) * (double)a1q.LowerBoundary);
							}
							else
							{
								num3 += Convert.ToInt32((1.0 + num4) * (double)a1q.UpperBoundary);
								num2 += Convert.ToInt32((1.0 + num4) * (double)a1q.LowerBoundary);
							}
						}
						goto IL_447;
					}
				}
				a1q a1q2 = Enumerable.First<a1q>(bke.l());
				if (bke.e() == btz.g && a1q2.DamageType == DamageType.Mechanical)
				{
					num2 = Convert.ToInt32((1.0 + num4 + num5) * (double)a1q2.LowerBoundary);
					num3 = Convert.ToInt32((1.0 + num4 + num5) * (double)a1q2.UpperBoundary);
				}
				else
				{
					num2 = Convert.ToInt32((1.0 + num4) * (double)a1q2.LowerBoundary);
					num3 = Convert.ToInt32((1.0 + num4) * (double)a1q2.UpperBoundary);
				}
				a_ = adi.af[a1q2.DamageType];
			}
			IL_447:
			ecs ecs2 = new ecs(new List<dl6>
			{
				new dl6(new List<bph>
				{
					new bph(this.ah, " ", null)
				}),
				new dl6(new List<bph>
				{
					new bph(new d22(this.ae, a_), string.Format("{0}-{1}", num2, num3), null)
				}),
				new dl6(new List<bph>
				{
					new bph(this.ag, num.ToString(), null)
				}),
				new dl6(new List<bph>
				{
					new bph(this.ag, bke.c().ToString().a(), null)
				}),
				new dl6(new List<bph>
				{
					new bph(this.ag, ((int)Math.Round(Math.Min(1.0, this.h.Offense.a0()) * 100.0)).ToString() + "%", null)
				}),
				new dl6(new List<bph>
				{
					new bph(this.ag, ((int)Math.Round(this.h.Offense.am() * 100.0)).ToString() + "%", null)
				}),
				new dl6(new List<bph>
				{
					new bph(this.ag, ((int)Math.Round(this.h.Offense.an() * 100.0)).ToString() + "%", null)
				}),
				new dl6(new List<bph>
				{
					new bph(this.ag, this.h.Offense.ay().ToString(), null)
				}),
				new dl6(new List<bph>
				{
					new bph(this.ag, (bke.ad() <= 1f) ? dh9.c("Melee") : bke.ad().ToString(), null)
				})
			});
			if (bke.h() > 0f && bke.ad() != bke.h())
			{
				ecs.a.Add(new dl6(new List<bph>
				{
					new bph(this.af, dh9.c("CombatStatsWindow_Label_Optimalrange") + ":", null)
				}));
				ecs2.a.Add(new dl6(new List<bph>
				{
					new bph(this.ag, bke.h().ToString(), null)
				}));
			}
			this.a(ecs2);
			this.z = ecs2.b();
		}
		else
		{
			this.z = null;
		}
		this.a(ecs);
		this.y = ecs.b();
	}

	// Token: 0x060026BC RID: 9916 RVA: 0x000E02A8 File Offset: 0x000DE4A8
	private void a(PsiSchool A_0)
	{
		bas bas;
		this.h.Offense.ag().TryGetValue(A_0, out bas);
		if (bas != null)
		{
			ecs ecs = new ecs(new List<dl6>
			{
				new dl6(new List<bph>
				{
					new bph(this.ah, dh9.a(A_0), null)
				}),
				new dl6(new List<bph>
				{
					new bph(this.af, dh9.c("CombatStatsWindow_Label_Psi_Skill") + ":", null)
				}),
				new dl6(new List<bph>
				{
					new bph(this.af, dh9.c("CombatStatsWindow_Label_Psi_Criticalchance") + ":", null)
				}),
				new dl6(new List<bph>
				{
					new bph(this.af, dh9.c("CombatStatsWindow_Label_Psi_Criticalbonus") + ":", null)
				}),
				new dl6(new List<bph>
				{
					new bph(this.af, dh9.c("CombatStatsWindow_Label_Psi_Basepsicost") + ":", null)
				})
			});
			ecs ecs2 = new ecs(new List<dl6>
			{
				new dl6(new List<bph>
				{
					new bph(this.ah, " ", null)
				}),
				new dl6(new List<bph>
				{
					new bph(this.ag, bas.b().ToString(), null)
				}),
				new dl6(new List<bph>
				{
					new bph(this.ag, Convert.ToInt32(Math.Min(1f, bas.e()) * 100f).ToString() + "%", null)
				}),
				new dl6(new List<bph>
				{
					new bph(this.ag, Convert.ToInt32(bas.g() * 100f).ToString() + "%", null)
				}),
				new dl6(new List<bph>
				{
					new bph(this.ag, Convert.ToInt32(bas.f() * 100.0).ToString() + "%", null)
				})
			});
			this.a(ecs);
			this.a(ecs2);
			dn3 dn = ecs.b();
			dn3 dn2 = ecs2.b();
			this.aa[A_0] = new dn3[]
			{
				dn,
				dn2
			};
			return;
		}
		this.aa.Remove(A_0);
	}

	// Token: 0x060026BD RID: 9917 RVA: 0x000E056C File Offset: 0x000DE76C
	private new void e()
	{
		ecs ecs = new ecs(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(this.ah, this.an + dh9.c("CombatStatsWindow_Caption_Resistances"), null)
			})
		});
		ecs ecs2 = new ecs(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(this.ah, " ", null)
			})
		});
		foreach (object obj in Enum.GetValues(typeof(DamageType)))
		{
			DamageType damageType = (DamageType)obj;
			ecs.a.Add(new dl6(new List<bph>
			{
				new bph(this.af, dh9.a(damageType), null)
			}));
			ecs2.a.Add(new dl6(new List<bph>
			{
				new bph(new d22(this.ae, dm1.a), string.Format("{0} ({1}%)", this.h.Defense.af()[damageType].ToString(), Convert.ToInt32(this.h.Defense.m()[damageType] * 100.0)), null)
			}));
		}
		this.a(ecs);
		this.a(ecs2);
		this.u = ecs.b();
		this.v = ecs2.b();
	}

	// Token: 0x060026BE RID: 9918 RVA: 0x000E072C File Offset: 0x000DE92C
	private new void d()
	{
		b3n b3n = (this.h.Gear.h().Item != null) ? this.h.Gear.h().Item.TypedDefinition : null;
		coh coh = (this.h.Gear.h().Item != null) ? this.h.Gear.h().Item : null;
		ecs ecs = new ecs(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(this.ah, this.an + dh9.c("CombatStatsWindow_Caption_Shielding"), null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.af, dh9.c("CombatStatsWindow_ShieldCapacityShort") + ": ", null)
			})
		});
		ecs ecs2 = new ecs(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(this.ah, " ", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.ag, (coh != null) ? ((int)((double)coh.MaxBattery * b3n.e())).ToString() : "0", null)
			})
		});
		foreach (object obj in Enum.GetValues(typeof(ImpactSpeed)))
		{
			ImpactSpeed impactSpeed = (ImpactSpeed)obj;
			ecs.a.Add(new dl6(new List<bph>
			{
				new bph(this.af, dh9.a(impactSpeed) + ":", null)
			}));
			ecs2.a.Add(new dl6(new List<bph>
			{
				new bph(this.ag, this.a(impactSpeed).ToString(), null)
			}));
		}
		this.a(ecs);
		this.a(ecs2);
		this.w = ecs.b();
		this.x = ecs2.b();
	}

	// Token: 0x060026BF RID: 9919 RVA: 0x000E09A0 File Offset: 0x000DEBA0
	private void c()
	{
		ecs ecs = new ecs(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(this.ah, this.an + dh9.c("CombatStatsWindow_Tab_Defense"), null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.af, dh9.a(SkillEnum.Dodge) + ":", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.af, dh9.a(SkillEnum.Evasion) + ":", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.af, dh9.c("Fortitude") + ":", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.af, dh9.c("Resolve") + ":", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.af, dh9.c("CombatStatsWindow_Label_Defense_Weaponcrit.chance") + ":", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.af, dh9.c("CombatStatsWindow_Label_Defense_Psicrit.chance") + ":", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.af, dh9.c("CombatStatsWindow_Label_Defense_Armorpenalty") + ":", null)
			})
		});
		Color a_;
		if (this.h.Defense.w() > 0.0)
		{
			a_ = dm1.c;
		}
		else if (this.h.Defense.w() < 0.0)
		{
			a_ = dm1.b;
		}
		else
		{
			a_ = dm1.a;
		}
		Color a_2;
		if (this.h.Defense.ac() > 0.0)
		{
			a_2 = dm1.c;
		}
		else if (this.h.Defense.ac() < 0.0)
		{
			a_2 = dm1.b;
		}
		else
		{
			a_2 = dm1.a;
		}
		ecs ecs2 = new ecs(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(this.ah, " ", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.ag, this.h.Defense.v().ToString(), null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.ag, this.h.Defense.z().ToString(), null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.ag, this.h.Defense.ab().ToString(), null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.ag, this.h.Defense.ae().ToString(), null)
			}),
			new dl6(new List<bph>
			{
				new bph(new d22(this.ae, a_), ((this.h.Defense.w() >= 0.0) ? "+" : "") + (this.h.Defense.w() * 100.0).ToString("0.00") + "%", null)
			}),
			new dl6(new List<bph>
			{
				new bph(new d22(this.ae, a_2), ((this.h.Defense.ac() >= 0.0) ? "+" : "") + (this.h.Defense.ac() * 100.0).ToString("0.00") + "%", null)
			}),
			new dl6(new List<bph>
			{
				new bph(new d22(this.ae, (this.h.Defense.aj() > 0.0) ? dm1.c : dm1.a), ((int)(this.h.Defense.aj() * 100.0)).ToString() + "%", null)
			})
		});
		this.a(ecs);
		this.a(ecs2);
		this.q = ecs.b();
		this.r = ecs2.b();
	}

	// Token: 0x060026C0 RID: 9920 RVA: 0x000E0EF0 File Offset: 0x000DF0F0
	private void b()
	{
		ecs ecs = new ecs(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(this.ah, this.an + dh9.c("CombatStatsWindow_Caption_Subterfuge"), null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.af, dh9.a(SkillEnum.Stealth) + ":", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.af, dh9.c("Detection") + ":", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.af, dh9.c("TrapDetectionShort") + ":", null)
			})
		});
		ecs ecs2 = new ecs(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(this.ah, " ", null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.ag, this.h.Skills.Get<a2n>().g().ToString(), null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.ag, this.h.Detection.ToString(), null)
			}),
			new dl6(new List<bph>
			{
				new bph(this.ag, qw.a(this.h).ToString(), null)
			})
		});
		this.a(ecs);
		this.a(ecs2);
		this.s = ecs.b();
		this.t = ecs2.b();
	}

	// Token: 0x060026C1 RID: 9921 RVA: 0x000E10E4 File Offset: 0x000DF2E4
	private void a()
	{
		ecs ecs = new ecs(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(this.ah, this.an + dh9.c("CombatStatsWindow_Caption_BaseAbilities"), null)
			})
		});
		ecs ecs2 = new ecs(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(this.ah, " ", null)
			})
		});
		foreach (to to in this.h.BaseAbilities)
		{
			Color a_;
			if (to.g() == to.f())
			{
				a_ = dm1.a;
			}
			else if (to.g() > to.f())
			{
				a_ = dm1.b;
			}
			else
			{
				a_ = dm1.c;
			}
			ecs.a.Add(new dl6(new List<bph>
			{
				new bph(this.af, to.a(to), null)
			}));
			ecs2.a.Add(new dl6(new List<bph>
			{
				new bph(new d22(this.ae, a_), to.g().ToString(), null)
			}));
		}
		this.a(ecs);
		this.a(ecs2);
		this.o = ecs.b();
		this.p = ecs2.b();
	}

	// Token: 0x060026C2 RID: 9922 RVA: 0x000E1280 File Offset: 0x000DF480
	private int a(ImpactSpeed A_0)
	{
		dm1.b b = new dm1.b();
		b.a = A_0;
		if (this.h.Defense.z == null)
		{
			return 0;
		}
		return Enumerable.FirstOrDefault<z3>(Enumerable.Where<z3>(this.h.Defense.z, new Func<z3, bool>(b.a))).Value;
	}

	// Token: 0x060026C3 RID: 9923 RVA: 0x000E12E0 File Offset: 0x000DF4E0
	private int b(int A_0)
	{
		return Convert.ToInt32((float)A_0 * this.al.X);
	}

	// Token: 0x060026C4 RID: 9924 RVA: 0x000E12F8 File Offset: 0x000DF4F8
	private int a(int A_0)
	{
		return Convert.ToInt32((float)A_0 * this.al.Y);
	}

	// Token: 0x060026C5 RID: 9925 RVA: 0x000E1310 File Offset: 0x000DF510
	protected override void i0()
	{
		base.i0();
		this.h.a(new EventHandler<EventArgs>(this.a));
	}

	// Token: 0x060026C6 RID: 9926 RVA: 0x000E1330 File Offset: 0x000DF530
	protected override void i1()
	{
		base.i1();
		this.h.c(new EventHandler<EventArgs>(this.a));
	}

	// Token: 0x060026C7 RID: 9927 RVA: 0x000E1350 File Offset: 0x000DF550
	private void a(object A_0, EventArgs A_1)
	{
		this.h();
	}

	// Token: 0x060026C8 RID: 9928 RVA: 0x000E135C File Offset: 0x000DF55C
	private void b(object A_0, b25 A_1)
	{
		zt zt = A_0 as zt;
		if (zt != null && zt.Tag is baf)
		{
			dm1.f = (baf)zt.Tag;
			foreach (zt zt2 in Enumerable.OfType<zt>(base.Controls))
			{
				zt2.Checked = (zt2 == zt);
			}
		}
	}

	// Token: 0x060026C9 RID: 9929 RVA: 0x000E13E8 File Offset: 0x000DF5E8
	protected override void ik(object A_0, b25 A_1)
	{
		base.ik(A_0, A_1);
		this.ac.b();
	}

	// Token: 0x060026CA RID: 9930 RVA: 0x000E1400 File Offset: 0x000DF600
	protected override void nr(object A_0, b25 A_1)
	{
		base.nr(A_0, A_1);
		this.ac.b();
	}

	// Token: 0x060026CB RID: 9931 RVA: 0x000E1418 File Offset: 0x000DF618
	protected override void ns(object A_0, b25 A_1)
	{
		base.ns(A_0, A_1);
		this.ac.b();
	}

	// Token: 0x060026CC RID: 9932 RVA: 0x000E1430 File Offset: 0x000DF630
	private void a(object A_0, b25 A_1)
	{
		cao cao = A_0 as cao;
		if (cao != null && cao.Tag is PsiSchool)
		{
			dm1.g = (PsiSchool)cao.Tag;
			foreach (cao cao2 in this.ad)
			{
				cao2.Checked = ((PsiSchool)cao2.Tag == dm1.g);
			}
		}
	}

	// Token: 0x040015F1 RID: 5617
	private new static readonly Color a = Color.White;

	// Token: 0x040015F2 RID: 5618
	private new static readonly Color b = new Color(0, 255, 0);

	// Token: 0x040015F3 RID: 5619
	private new static readonly Color c = new Color(255, 0, 0);

	// Token: 0x040015F4 RID: 5620
	private new static readonly Point d = new Point(270, 100);

	// Token: 0x040015F5 RID: 5621
	private new const int e = 250;

	// Token: 0x040015F6 RID: 5622
	private new static baf f = baf.a;

	// Token: 0x040015F7 RID: 5623
	private new static PsiSchool g = PsiSchool.ThoughtControl;

	// Token: 0x040015F8 RID: 5624
	private new efk h;

	// Token: 0x040015F9 RID: 5625
	private new ec9 i;

	// Token: 0x040015FA RID: 5626
	private new zt j;

	// Token: 0x040015FB RID: 5627
	private new zt k;

	// Token: 0x040015FC RID: 5628
	private new zt l;

	// Token: 0x040015FD RID: 5629
	private new dn3 m;

	// Token: 0x040015FE RID: 5630
	private dn3 n;

	// Token: 0x040015FF RID: 5631
	private dn3 o;

	// Token: 0x04001600 RID: 5632
	private dn3 p;

	// Token: 0x04001601 RID: 5633
	private dn3 q;

	// Token: 0x04001602 RID: 5634
	private dn3 r;

	// Token: 0x04001603 RID: 5635
	private dn3 s;

	// Token: 0x04001604 RID: 5636
	private dn3 t;

	// Token: 0x04001605 RID: 5637
	private dn3 u;

	// Token: 0x04001606 RID: 5638
	private dn3 v;

	// Token: 0x04001607 RID: 5639
	private dn3 w;

	// Token: 0x04001608 RID: 5640
	private new dn3 x;

	// Token: 0x04001609 RID: 5641
	private dn3 y;

	// Token: 0x0400160A RID: 5642
	private new dn3 z;

	// Token: 0x0400160B RID: 5643
	private Dictionary<PsiSchool, dn3[]> aa = new Dictionary<PsiSchool, dn3[]>();

	// Token: 0x0400160C RID: 5644
	private double ab;

	// Token: 0x0400160D RID: 5645
	private dsy ac;

	// Token: 0x0400160E RID: 5646
	private List<cao> ad = new List<cao>();

	// Token: 0x0400160F RID: 5647
	private string ae;

	// Token: 0x04001610 RID: 5648
	private new d22 af;

	// Token: 0x04001611 RID: 5649
	private d22 ag;

	// Token: 0x04001612 RID: 5650
	private d22 ah;

	// Token: 0x04001613 RID: 5651
	private d22 ai;

	// Token: 0x04001614 RID: 5652
	private int aj = 150;

	// Token: 0x04001615 RID: 5653
	private int ak = 255;

	// Token: 0x04001616 RID: 5654
	private Vector2 al = Vector2.One;

	// Token: 0x04001617 RID: 5655
	private new int am = 110;

	// Token: 0x04001618 RID: 5656
	private string an = "      ";

	// Token: 0x04001619 RID: 5657
	private new List<dm1.a> ao;

	// Token: 0x0400161A RID: 5658
	private new dm1.a ap;

	// Token: 0x0400161B RID: 5659
	private baf aq;

	// Token: 0x02002027 RID: 8231
	private new sealed class a
	{
		// Token: 0x0600C2DE RID: 49886 RVA: 0x0043714C File Offset: 0x0043534C
		public a(int A_0, int A_1, int A_2, int A_3, string A_4, string A_5)
		{
			this.a = A_0;
			this.b = A_1;
			this.c = A_2;
			this.d = A_3;
			this.e = A_4;
			this.f = A_5;
		}

		// Token: 0x040046A2 RID: 18082
		public int a;

		// Token: 0x040046A3 RID: 18083
		public int b;

		// Token: 0x040046A4 RID: 18084
		public int c;

		// Token: 0x040046A5 RID: 18085
		public int d;

		// Token: 0x040046A6 RID: 18086
		public string e;

		// Token: 0x040046A7 RID: 18087
		public string f;
	}

	// Token: 0x02002028 RID: 8232
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x0600C2E0 RID: 49888 RVA: 0x0043718C File Offset: 0x0043538C
		internal bool a(z3 A_0)
		{
			return A_0.ImpactSpeed == this.a;
		}

		// Token: 0x040046A8 RID: 18088
		public ImpactSpeed a;
	}
}
