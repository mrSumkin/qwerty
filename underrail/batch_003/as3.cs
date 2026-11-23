using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020018FA RID: 6394
public static class as3
{
	// Token: 0x060087E7 RID: 34791 RVA: 0x0038188C File Offset: 0x0037FA8C
	static as3()
	{
		as3.ao = new Dictionary<WeaponSubtype, WeaponAggregateSubtype[]>();
		as3.ao[WeaponSubtype.Crowbar] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.Crowbar,
			WeaponAggregateSubtype.BluntMelee
		};
		as3.ao[WeaponSubtype.Unknown] = new WeaponAggregateSubtype[1];
		as3.ao[WeaponSubtype.Crossbow] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.Crossbow
		};
		as3.ao[WeaponSubtype.Pistol_5] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.FirearmPistol,
			WeaponAggregateSubtype.Firearm
		};
		as3.ao[WeaponSubtype.Pistol_762] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.FirearmPistol,
			WeaponAggregateSubtype.Firearm
		};
		as3.ao[WeaponSubtype.Pistol_9] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.FirearmPistol,
			WeaponAggregateSubtype.Firearm
		};
		as3.ao[WeaponSubtype.Pistol_44] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.FirearmPistol,
			WeaponAggregateSubtype.Firearm
		};
		as3.ao[WeaponSubtype.Sniper_762] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.Sniper,
			WeaponAggregateSubtype.Firearm
		};
		as3.ao[WeaponSubtype.Sniper_86] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.Sniper,
			WeaponAggregateSubtype.Firearm
		};
		as3.ao[WeaponSubtype.Sniper_127] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.Sniper,
			WeaponAggregateSubtype.Firearm
		};
		as3.ao[WeaponSubtype.Smg_5] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.SMG,
			WeaponAggregateSubtype.Firearm
		};
		as3.ao[WeaponSubtype.Smg_762] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.SMG,
			WeaponAggregateSubtype.Firearm
		};
		as3.ao[WeaponSubtype.Smg_86] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.SMG,
			WeaponAggregateSubtype.Firearm
		};
		as3.ao[WeaponSubtype.AssaultRifle_762] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.AssaultRifle,
			WeaponAggregateSubtype.Firearm
		};
		as3.ao[WeaponSubtype.AssaultRifle_86] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.AssaultRifle,
			WeaponAggregateSubtype.Firearm
		};
		as3.ao[WeaponSubtype.AssaultRifle_9] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.AssaultRifle,
			WeaponAggregateSubtype.Firearm
		};
		as3.ao[WeaponSubtype.Shotgun_Regular] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.Shotgun,
			WeaponAggregateSubtype.Firearm
		};
		as3.ao[WeaponSubtype.Shotgun_Combat] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.Shotgun,
			WeaponAggregateSubtype.Firearm
		};
		as3.ao[WeaponSubtype.GrenadeLauncher_25] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.GrenadeLauncher,
			WeaponAggregateSubtype.Firearm
		};
		as3.ao[WeaponSubtype.GrenadeLauncher_40] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.GrenadeLauncher,
			WeaponAggregateSubtype.Firearm
		};
		as3.ao[WeaponSubtype.LMG_9] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.LMG,
			WeaponAggregateSubtype.Firearm,
			WeaponAggregateSubtype.HeavyGun
		};
		as3.ao[WeaponSubtype.LMG_44] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.LMG,
			WeaponAggregateSubtype.Firearm,
			WeaponAggregateSubtype.HeavyGun
		};
		as3.ao[WeaponSubtype.Minigun_44] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.Minigun,
			WeaponAggregateSubtype.Firearm,
			WeaponAggregateSubtype.HeavyGun
		};
		as3.ao[WeaponSubtype.Minigun_127] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.Minigun,
			WeaponAggregateSubtype.Firearm,
			WeaponAggregateSubtype.HeavyGun
		};
		as3.ao[WeaponSubtype.FusionCannon] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.EnergyWeapon,
			WeaponAggregateSubtype.HeavyGun
		};
		as3.ao[WeaponSubtype.RocketLauncher_84] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.RocketLauncher,
			WeaponAggregateSubtype.Firearm,
			WeaponAggregateSubtype.HeavyGun
		};
		as3.ao[WeaponSubtype.RocketLauncher_40] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.RocketLauncher,
			WeaponAggregateSubtype.Firearm,
			WeaponAggregateSubtype.HeavyGun
		};
		as3.ao[WeaponSubtype.RocketLauncher_66] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.RocketLauncher,
			WeaponAggregateSubtype.Firearm,
			WeaponAggregateSubtype.HeavyGun
		};
		as3.ao[WeaponSubtype.Sledgehammer] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.BluntMelee,
			WeaponAggregateSubtype.Sledgehammer
		};
		as3.ao[WeaponSubtype.Spear] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.BladedMelee,
			WeaponAggregateSubtype.Spears
		};
		as3.ao[WeaponSubtype.Sword] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.BladedMelee,
			WeaponAggregateSubtype.Sword
		};
		as3.ao[WeaponSubtype.Machete_Straight] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.BladedMelee,
			WeaponAggregateSubtype.Sword
		};
		as3.ao[WeaponSubtype.Machete_Curved] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.BladedMelee,
			WeaponAggregateSubtype.Sword
		};
		as3.ao[WeaponSubtype.Knife] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.BladedMelee,
			WeaponAggregateSubtype.Knife
		};
		as3.ao[WeaponSubtype.SerratedKnife] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.BladedMelee,
			WeaponAggregateSubtype.Knife
		};
		as3.ao[WeaponSubtype.Dagger] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.BladedMelee,
			WeaponAggregateSubtype.Knife
		};
		as3.ao[WeaponSubtype.Glove_Leather] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.Gloves
		};
		as3.ao[WeaponSubtype.Glove_Metal] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.Gloves
		};
		as3.ao[WeaponSubtype.Glove_Boxing] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.Gloves
		};
		as3.ao[WeaponSubtype.Pistol_Laser] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.EnergyPistol,
			WeaponAggregateSubtype.EnergyWeapon
		};
		as3.ao[WeaponSubtype.Pistol_Plasma] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.EnergyPistol,
			WeaponAggregateSubtype.EnergyWeapon
		};
		as3.ao[WeaponSubtype.Pistol_Electro] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.EnergyPistol,
			WeaponAggregateSubtype.EnergyWeapon
		};
		as3.ao[WeaponSubtype.Pistol_Sonic] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.EnergyPistol,
			WeaponAggregateSubtype.EnergyWeapon
		};
		as3.ao[WeaponSubtype.Unarmed] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.Unarmed
		};
		as3.ao[WeaponSubtype.Pistol_Acid_Blob] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.ChemicalPistol
		};
		as3.ao[WeaponSubtype.Pistol_Cryo_Blob] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.ChemicalPistol
		};
		as3.ao[WeaponSubtype.Pistol_Indendiary_Blob] = new WeaponAggregateSubtype[]
		{
			WeaponAggregateSubtype.ChemicalPistol
		};
		as3.ab = new Dictionary<btz, double>();
		as3.ab.Add(btz.f, 0.0);
		as3.ab.Add(btz.g, 0.0);
		as3.ab.Add(btz.a, 0.0);
		as3.ab.Add(btz.c, 0.0);
		as3.ab.Add(btz.d, 0.0);
		as3.ab.Add(btz.b, 0.0);
		as3.ab.Add(btz.e, -0.15);
		as3.ab.Add(btz.h, 0.0);
		as3.ab.Add(btz.i, 0.0);
		as3.ab.Add(btz.j, -0.05);
		as3.ab.Add(btz.k, -0.1);
		as3.ab.Add(btz.l, -0.05);
		as3.m = new Dictionary<btz, double>();
		as3.m.Add(btz.f, 0.055);
		as3.m.Add(btz.g, 0.0);
		as3.m.Add(btz.a, 0.055);
		as3.m.Add(btz.c, 0.09);
		as3.m.Add(btz.d, 0.04);
		as3.m.Add(btz.b, 0.062);
		as3.m.Add(btz.e, 0.11);
		as3.m.Add(btz.h, 0.1);
		as3.m.Add(btz.i, 0.1);
		as3.m.Add(btz.j, 0.1);
		as3.m.Add(btz.k, 0.125);
		as3.m.Add(btz.l, 0.1);
		as3.n = new Dictionary<btz, double>();
		as3.n.Add(btz.f, 1.0);
		as3.n.Add(btz.g, 1.0);
		as3.n.Add(btz.a, 1.0);
		as3.n.Add(btz.c, 1.0);
		as3.n.Add(btz.d, 1.0);
		as3.n.Add(btz.b, 1.0);
		as3.n.Add(btz.e, 0.25);
		as3.n.Add(btz.h, 1.0);
		as3.n.Add(btz.i, 1.0);
		as3.n.Add(btz.j, 0.75);
		as3.n.Add(btz.k, 0.65);
		as3.n.Add(btz.l, 1.0);
		as3.v = new Dictionary<btz, int>();
		as3.v[btz.a] = 2000;
		as3.v[btz.b] = 2000;
		as3.v[btz.f] = 0;
		as3.v[btz.c] = 3000;
		as3.v[btz.d] = 2750;
		as3.v[btz.g] = 0;
		as3.v[btz.e] = 3000;
		as3.v[btz.h] = 3500;
		as3.v[btz.i] = 3500;
		as3.v[btz.j] = 3500;
		as3.v[btz.k] = 4000;
		as3.v[btz.l] = 4000;
		as3.w = new Dictionary<WeaponSubtype, double>();
		as3.w[WeaponSubtype.Unknown] = 0.0;
		as3.w[WeaponSubtype.Crossbow] = 0.08;
		as3.w[WeaponSubtype.Pistol_5] = 0.1;
		as3.w[WeaponSubtype.Pistol_762] = 0.1;
		as3.w[WeaponSubtype.Pistol_9] = 0.1;
		as3.w[WeaponSubtype.Pistol_44] = 0.1;
		as3.w[WeaponSubtype.Sniper_762] = 0.1;
		as3.w[WeaponSubtype.Sniper_86] = 0.1;
		as3.w[WeaponSubtype.Sniper_127] = 0.1;
		as3.w[WeaponSubtype.Smg_5] = 0.05;
		as3.w[WeaponSubtype.Smg_762] = 0.05;
		as3.w[WeaponSubtype.Smg_86] = 0.05;
		as3.w[WeaponSubtype.AssaultRifle_762] = 0.05;
		as3.w[WeaponSubtype.AssaultRifle_86] = 0.05;
		as3.w[WeaponSubtype.AssaultRifle_9] = 0.05;
		as3.w[WeaponSubtype.LMG_9] = 0.04;
		as3.w[WeaponSubtype.LMG_44] = 0.04;
		as3.w[WeaponSubtype.Minigun_44] = 0.03;
		as3.w[WeaponSubtype.Minigun_127] = 0.03;
		as3.w[WeaponSubtype.Shotgun_Regular] = 0.05;
		as3.w[WeaponSubtype.Shotgun_Combat] = 0.05;
		as3.w[WeaponSubtype.GrenadeLauncher_25] = 0.05;
		as3.w[WeaponSubtype.GrenadeLauncher_40] = 0.05;
		as3.w[WeaponSubtype.RocketLauncher_84] = 0.05;
		as3.w[WeaponSubtype.RocketLauncher_40] = 0.05;
		as3.w[WeaponSubtype.RocketLauncher_66] = 0.05;
		as3.w[WeaponSubtype.FusionCannon] = 0.05;
		as3.w[WeaponSubtype.Sledgehammer] = 0.05;
		as3.w[WeaponSubtype.Spear] = 0.05;
		as3.w[WeaponSubtype.Sword] = 0.05;
		as3.w[WeaponSubtype.Machete_Straight] = 0.05;
		as3.w[WeaponSubtype.Machete_Curved] = 0.04;
		as3.w[WeaponSubtype.Knife] = 0.08;
		as3.w[WeaponSubtype.SerratedKnife] = 0.08;
		as3.w[WeaponSubtype.Dagger] = 0.1;
		as3.w[WeaponSubtype.Glove_Leather] = 0.05;
		as3.w[WeaponSubtype.Glove_Metal] = 0.05;
		as3.w[WeaponSubtype.Glove_Boxing] = 0.05;
		as3.w[WeaponSubtype.Pistol_Laser] = 0.06;
		as3.w[WeaponSubtype.Pistol_Plasma] = 0.05;
		as3.w[WeaponSubtype.Pistol_Electro] = 0.05;
		as3.w[WeaponSubtype.Unarmed] = 0.05;
		as3.w[WeaponSubtype.Pistol_Acid_Blob] = 0.04;
		as3.w[WeaponSubtype.Pistol_Cryo_Blob] = 0.04;
		as3.w[WeaponSubtype.Pistol_Indendiary_Blob] = 0.04;
		as3.x = new Dictionary<WeaponSubtype, double>();
		as3.x[WeaponSubtype.Unknown] = 0.0;
		as3.x[WeaponSubtype.Crossbow] = 1.0;
		as3.x[WeaponSubtype.Pistol_5] = 1.0;
		as3.x[WeaponSubtype.Pistol_762] = 1.0;
		as3.x[WeaponSubtype.Pistol_9] = 1.0;
		as3.x[WeaponSubtype.Pistol_44] = 1.0;
		as3.x[WeaponSubtype.Sniper_762] = 1.0;
		as3.x[WeaponSubtype.Sniper_86] = 1.0;
		as3.x[WeaponSubtype.Sniper_127] = 1.0;
		as3.x[WeaponSubtype.Smg_5] = 1.0;
		as3.x[WeaponSubtype.Smg_762] = 1.0;
		as3.x[WeaponSubtype.Smg_86] = 1.0;
		as3.x[WeaponSubtype.AssaultRifle_762] = 1.0;
		as3.x[WeaponSubtype.AssaultRifle_86] = 1.0;
		as3.x[WeaponSubtype.AssaultRifle_9] = 1.0;
		as3.x[WeaponSubtype.Shotgun_Regular] = 1.0;
		as3.x[WeaponSubtype.Shotgun_Combat] = 1.0;
		as3.x[WeaponSubtype.GrenadeLauncher_25] = 1.0;
		as3.x[WeaponSubtype.GrenadeLauncher_40] = 1.0;
		as3.x[WeaponSubtype.RocketLauncher_84] = 1.0;
		as3.x[WeaponSubtype.RocketLauncher_40] = 1.0;
		as3.x[WeaponSubtype.RocketLauncher_66] = 1.0;
		as3.x[WeaponSubtype.LMG_9] = 0.9;
		as3.x[WeaponSubtype.LMG_44] = 0.9;
		as3.x[WeaponSubtype.Minigun_44] = 1.15;
		as3.x[WeaponSubtype.Minigun_127] = 1.15;
		as3.x[WeaponSubtype.FusionCannon] = 1.0;
		as3.x[WeaponSubtype.Sledgehammer] = 1.0;
		as3.x[WeaponSubtype.Spear] = 1.0;
		as3.x[WeaponSubtype.Sword] = 1.4;
		as3.x[WeaponSubtype.Machete_Straight] = 1.4;
		as3.x[WeaponSubtype.Machete_Curved] = 1.6;
		as3.x[WeaponSubtype.Knife] = 1.15;
		as3.x[WeaponSubtype.SerratedKnife] = 1.3;
		as3.x[WeaponSubtype.Dagger] = 1.15;
		as3.x[WeaponSubtype.Glove_Leather] = 1.0;
		as3.x[WeaponSubtype.Glove_Metal] = 1.0;
		as3.x[WeaponSubtype.Glove_Boxing] = 1.0;
		as3.x[WeaponSubtype.Pistol_Laser] = 1.0;
		as3.x[WeaponSubtype.Pistol_Plasma] = 1.2;
		as3.x[WeaponSubtype.Pistol_Electro] = 1.0;
		as3.x[WeaponSubtype.Unarmed] = 1.0;
		as3.x[WeaponSubtype.Pistol_Acid_Blob] = 1.0;
		as3.x[WeaponSubtype.Pistol_Cryo_Blob] = 1.0;
		as3.x[WeaponSubtype.Pistol_Indendiary_Blob] = 1.0;
		as3.y = new Dictionary<btz, float[]>();
		as3.y[btz.a] = new float[]
		{
			10f,
			7f
		};
		as3.y[btz.b] = new float[]
		{
			9f,
			6f
		};
		as3.y[btz.f] = new float[]
		{
			14f,
			9f
		};
		as3.y[btz.c] = new float[]
		{
			14f,
			10f
		};
		as3.y[btz.d] = new float[]
		{
			20f,
			14f
		};
		as3.y[btz.g] = new float[2];
		as3.y[btz.e] = new float[]
		{
			9f,
			4f
		};
		as3.y[btz.h] = new float[]
		{
			10f,
			5f
		};
		as3.y[btz.i] = new float[]
		{
			14f,
			10f
		};
		as3.y[btz.j] = new float[]
		{
			14f,
			7f
		};
		as3.y[btz.k] = new float[]
		{
			12f,
			7f
		};
		as3.y[btz.l] = new float[]
		{
			14f,
			8f
		};
		as3.z = new Dictionary<btz, int>();
		as3.z[btz.a] = 0;
		as3.z[btz.b] = 25;
		as3.z[btz.f] = 0;
		as3.z[btz.c] = 30;
		as3.z[btz.d] = 35;
		as3.z[btz.g] = 0;
		as3.z[btz.e] = 20;
		as3.z[btz.h] = 40;
		as3.z[btz.i] = 50;
		as3.z[btz.j] = 0;
		as3.z[btz.k] = 40;
		as3.z[btz.l] = 45;
		as3.aa = new Dictionary<btz, int>();
		as3.aa[btz.a] = 0;
		as3.aa[btz.b] = 2;
		as3.aa[btz.f] = 0;
		as3.aa[btz.c] = 2;
		as3.aa[btz.d] = 2;
		as3.aa[btz.g] = 0;
		as3.aa[btz.e] = 2;
		as3.aa[btz.h] = 4;
		as3.aa[btz.i] = 4;
		as3.aa[btz.j] = 0;
		as3.aa[btz.k] = 2;
		as3.aa[btz.l] = 4;
		as3.ac = new Dictionary<WeaponSubtype, double>();
		as3.ac[WeaponSubtype.Unknown] = 0.0;
		as3.ac[WeaponSubtype.Crossbow] = 16.0;
		as3.ac[WeaponSubtype.Pistol_5] = 13.0;
		as3.ac[WeaponSubtype.Pistol_762] = 16.0;
		as3.ac[WeaponSubtype.Pistol_9] = 20.0;
		as3.ac[WeaponSubtype.Pistol_44] = 30.0;
		as3.ac[WeaponSubtype.Sniper_762] = 35.0;
		as3.ac[WeaponSubtype.Sniper_86] = 42.0;
		as3.ac[WeaponSubtype.Sniper_127] = 48.0;
		as3.ac[WeaponSubtype.AssaultRifle_762] = 16.0;
		as3.ac[WeaponSubtype.AssaultRifle_86] = 18.0;
		as3.ac[WeaponSubtype.AssaultRifle_9] = 20.0;
		as3.ac[WeaponSubtype.Shotgun_Regular] = 43.0;
		as3.ac[WeaponSubtype.Shotgun_Combat] = 38.0;
		as3.ac[WeaponSubtype.GrenadeLauncher_25] = 28.0;
		as3.ac[WeaponSubtype.GrenadeLauncher_40] = 40.0;
		as3.ac[WeaponSubtype.RocketLauncher_84] = 50.0;
		as3.ac[WeaponSubtype.RocketLauncher_40] = 50.0;
		as3.ac[WeaponSubtype.RocketLauncher_66] = 50.0;
		as3.ac[WeaponSubtype.LMG_9] = 20.0;
		as3.ac[WeaponSubtype.LMG_44] = 22.0;
		as3.ac[WeaponSubtype.Minigun_44] = 25.0;
		as3.ac[WeaponSubtype.Minigun_127] = 29.0;
		as3.ac[WeaponSubtype.FusionCannon] = 75.0;
		as3.ac[WeaponSubtype.Smg_5] = 8.0;
		as3.ac[WeaponSubtype.Smg_762] = 10.0;
		as3.ac[WeaponSubtype.Smg_86] = 13.0;
		as3.ac[WeaponSubtype.Sledgehammer] = 20.0;
		as3.ac[WeaponSubtype.Spear] = 16.0;
		as3.ac[WeaponSubtype.Sword] = 12.0;
		as3.ac[WeaponSubtype.Machete_Straight] = 12.0;
		as3.ac[WeaponSubtype.Machete_Curved] = 11.0;
		as3.ac[WeaponSubtype.Knife] = 9.0;
		as3.ac[WeaponSubtype.SerratedKnife] = 8.0;
		as3.ac[WeaponSubtype.Dagger] = 8.0;
		as3.ac[WeaponSubtype.Glove_Leather] = 7.0;
		as3.ac[WeaponSubtype.Glove_Metal] = 10.0;
		as3.ac[WeaponSubtype.Glove_Boxing] = 7.0;
		as3.ac[WeaponSubtype.Pistol_Laser] = 12.0;
		as3.ac[WeaponSubtype.Pistol_Plasma] = 38.0;
		as3.ac[WeaponSubtype.Pistol_Electro] = 19.0;
		as3.ac[WeaponSubtype.Unarmed] = 5.0;
		as3.ac[WeaponSubtype.Pistol_Acid_Blob] = 23.0;
		as3.ac[WeaponSubtype.Pistol_Cryo_Blob] = 27.0;
		as3.ac[WeaponSubtype.Pistol_Indendiary_Blob] = 17.0;
		as3.ad = new Dictionary<WeaponSubtype, double>();
		as3.ad[WeaponSubtype.Unknown] = 0.0;
		as3.ad[WeaponSubtype.Crossbow] = 1.3;
		as3.ad[WeaponSubtype.Pistol_5] = 0.4;
		as3.ad[WeaponSubtype.Pistol_762] = 0.53;
		as3.ad[WeaponSubtype.Pistol_9] = 0.66;
		as3.ad[WeaponSubtype.Pistol_44] = 1.25;
		as3.ad[WeaponSubtype.Sniper_762] = 2.4;
		as3.ad[WeaponSubtype.Sniper_86] = 2.85;
		as3.ad[WeaponSubtype.Sniper_127] = 3.3;
		as3.ad[WeaponSubtype.Smg_5] = 0.4;
		as3.ad[WeaponSubtype.Smg_762] = 0.7;
		as3.ad[WeaponSubtype.Smg_86] = 0.85;
		as3.ad[WeaponSubtype.AssaultRifle_762] = 0.7;
		as3.ad[WeaponSubtype.AssaultRifle_86] = 0.775;
		as3.ad[WeaponSubtype.AssaultRifle_9] = 0.8;
		as3.ad[WeaponSubtype.Shotgun_Regular] = 3.15;
		as3.ad[WeaponSubtype.Shotgun_Combat] = 2.7;
		as3.ad[WeaponSubtype.GrenadeLauncher_25] = 2.4;
		as3.ad[WeaponSubtype.GrenadeLauncher_40] = 3.2;
		as3.ad[WeaponSubtype.RocketLauncher_84] = 4.0;
		as3.ad[WeaponSubtype.RocketLauncher_40] = 4.0;
		as3.ad[WeaponSubtype.RocketLauncher_66] = 4.0;
		as3.ad[WeaponSubtype.LMG_9] = 0.8;
		as3.ad[WeaponSubtype.LMG_44] = 0.9;
		as3.ad[WeaponSubtype.Minigun_44] = 1.0;
		as3.ad[WeaponSubtype.Minigun_127] = 1.15;
		as3.ad[WeaponSubtype.FusionCannon] = 8.0;
		as3.ad[WeaponSubtype.Sledgehammer] = 1.75;
		as3.ad[WeaponSubtype.Spear] = 1.55;
		as3.ad[WeaponSubtype.Sword] = 1.0;
		as3.ad[WeaponSubtype.Machete_Straight] = 1.0;
		as3.ad[WeaponSubtype.Machete_Curved] = 0.9;
		as3.ad[WeaponSubtype.Knife] = 0.5;
		as3.ad[WeaponSubtype.SerratedKnife] = 0.4;
		as3.ad[WeaponSubtype.Dagger] = 0.45;
		as3.ad[WeaponSubtype.Glove_Leather] = 0.3;
		as3.ad[WeaponSubtype.Glove_Metal] = 0.4;
		as3.ad[WeaponSubtype.Glove_Boxing] = 0.3;
		as3.ad[WeaponSubtype.Pistol_Laser] = 0.4;
		as3.ad[WeaponSubtype.Pistol_Plasma] = 1.125;
		as3.ad[WeaponSubtype.Pistol_Electro] = 0.48;
		as3.ad[WeaponSubtype.Unarmed] = 0.2;
		as3.ad[WeaponSubtype.Pistol_Acid_Blob] = 0.72;
		as3.ad[WeaponSubtype.Pistol_Cryo_Blob] = 0.9;
		as3.ad[WeaponSubtype.Pistol_Indendiary_Blob] = 0.6;
		as3.ae = new Dictionary<WeaponSubtype, b1j>();
		as3.ae[WeaponSubtype.Unknown] = new b1j(0.0, 0.0);
		as3.ae[WeaponSubtype.Crossbow] = new b1j(0.66, 1.33);
		as3.ae[WeaponSubtype.Pistol_5] = new b1j(0.85, 1.15);
		as3.ae[WeaponSubtype.Pistol_762] = new b1j(0.66, 1.33);
		as3.ae[WeaponSubtype.Pistol_9] = new b1j(0.66, 1.33);
		as3.ae[WeaponSubtype.Pistol_44] = new b1j(0.5, 1.5);
		as3.ae[WeaponSubtype.Sniper_762] = new b1j(0.8, 1.2);
		as3.ae[WeaponSubtype.Sniper_86] = new b1j(0.8, 1.2);
		as3.ae[WeaponSubtype.Sniper_127] = new b1j(0.8, 1.2);
		as3.ae[WeaponSubtype.AssaultRifle_762] = new b1j(0.8, 1.2);
		as3.ae[WeaponSubtype.AssaultRifle_86] = new b1j(0.7, 1.3);
		as3.ae[WeaponSubtype.AssaultRifle_9] = new b1j(0.6, 1.4);
		as3.ae[WeaponSubtype.Shotgun_Regular] = new b1j(0.6, 1.4);
		as3.ae[WeaponSubtype.Shotgun_Combat] = new b1j(0.7, 1.3);
		as3.ae[WeaponSubtype.GrenadeLauncher_25] = new b1j(0.8, 1.2);
		as3.ae[WeaponSubtype.GrenadeLauncher_40] = new b1j(0.66, 1.33);
		as3.ae[WeaponSubtype.RocketLauncher_84] = new b1j(0.6, 1.4);
		as3.ae[WeaponSubtype.RocketLauncher_40] = new b1j(0.6, 1.4);
		as3.ae[WeaponSubtype.RocketLauncher_66] = new b1j(0.6, 1.4);
		as3.ae[WeaponSubtype.LMG_9] = new b1j(0.8, 1.2);
		as3.ae[WeaponSubtype.LMG_44] = new b1j(0.7, 1.3);
		as3.ae[WeaponSubtype.Minigun_44] = new b1j(0.75, 1.25);
		as3.ae[WeaponSubtype.Minigun_127] = new b1j(0.6, 1.4);
		as3.ae[WeaponSubtype.FusionCannon] = new b1j(0.875, 1.125);
		as3.ae[WeaponSubtype.Smg_5] = new b1j(0.8, 1.2);
		as3.ae[WeaponSubtype.Smg_762] = new b1j(0.66, 1.33);
		as3.ae[WeaponSubtype.Smg_86] = new b1j(0.66, 1.33);
		as3.ae[WeaponSubtype.Sledgehammer] = new b1j(0.78, 1.22);
		as3.ae[WeaponSubtype.Spear] = new b1j(0.7, 1.3);
		as3.ae[WeaponSubtype.Sword] = new b1j(0.8, 1.2);
		as3.ae[WeaponSubtype.Machete_Straight] = new b1j(0.8, 1.2);
		as3.ae[WeaponSubtype.Machete_Curved] = new b1j(0.65, 1.35);
		as3.ae[WeaponSubtype.Knife] = new b1j(0.75, 1.25);
		as3.ae[WeaponSubtype.SerratedKnife] = new b1j(0.75, 1.25);
		as3.ae[WeaponSubtype.Dagger] = new b1j(0.5, 1.35);
		as3.ae[WeaponSubtype.Glove_Leather] = new b1j(0.75, 1.25);
		as3.ae[WeaponSubtype.Glove_Metal] = new b1j(0.75, 1.25);
		as3.ae[WeaponSubtype.Glove_Boxing] = new b1j(0.75, 1.25);
		as3.ae[WeaponSubtype.Pistol_Laser] = new b1j(0.85, 1.15);
		as3.ae[WeaponSubtype.Pistol_Plasma] = new b1j(0.8, 1.2);
		as3.ae[WeaponSubtype.Pistol_Electro] = new b1j(0.5, 1.5);
		as3.ae[WeaponSubtype.Unarmed] = new b1j(0.75, 1.25);
		as3.ae[WeaponSubtype.Pistol_Acid_Blob] = new b1j(0.8, 1.2);
		as3.ae[WeaponSubtype.Pistol_Cryo_Blob] = new b1j(0.85, 1.15);
		as3.ae[WeaponSubtype.Pistol_Indendiary_Blob] = new b1j(0.75, 1.25);
		as3.af = new Dictionary<WeaponSubtype, int>();
		as3.af[WeaponSubtype.Unknown] = 0;
		as3.af[WeaponSubtype.Crossbow] = 25;
		as3.af[WeaponSubtype.Pistol_5] = 16;
		as3.af[WeaponSubtype.Pistol_762] = 20;
		as3.af[WeaponSubtype.Pistol_9] = 25;
		as3.af[WeaponSubtype.Pistol_44] = 32;
		as3.af[WeaponSubtype.Sniper_762] = 35;
		as3.af[WeaponSubtype.Sniper_86] = 40;
		as3.af[WeaponSubtype.Sniper_127] = 45;
		as3.af[WeaponSubtype.Smg_5] = 11;
		as3.af[WeaponSubtype.Smg_762] = 13;
		as3.af[WeaponSubtype.Smg_86] = 16;
		as3.af[WeaponSubtype.AssaultRifle_762] = 13;
		as3.af[WeaponSubtype.AssaultRifle_86] = 14;
		as3.af[WeaponSubtype.AssaultRifle_9] = 16;
		as3.af[WeaponSubtype.Shotgun_Regular] = 25;
		as3.af[WeaponSubtype.Shotgun_Combat] = 25;
		as3.af[WeaponSubtype.GrenadeLauncher_25] = 25;
		as3.af[WeaponSubtype.GrenadeLauncher_40] = 35;
		as3.af[WeaponSubtype.RocketLauncher_84] = 45;
		as3.af[WeaponSubtype.RocketLauncher_40] = 45;
		as3.af[WeaponSubtype.RocketLauncher_66] = 45;
		as3.af[WeaponSubtype.LMG_9] = 30;
		as3.af[WeaponSubtype.LMG_44] = 35;
		as3.af[WeaponSubtype.Minigun_44] = 40;
		as3.af[WeaponSubtype.Minigun_127] = 45;
		as3.af[WeaponSubtype.FusionCannon] = 50;
		as3.af[WeaponSubtype.Sledgehammer] = 25;
		as3.af[WeaponSubtype.Spear] = 20;
		as3.af[WeaponSubtype.Sword] = 16;
		as3.af[WeaponSubtype.Machete_Straight] = 16;
		as3.af[WeaponSubtype.Machete_Curved] = 16;
		as3.af[WeaponSubtype.Knife] = 12;
		as3.af[WeaponSubtype.SerratedKnife] = 12;
		as3.af[WeaponSubtype.Dagger] = 12;
		as3.af[WeaponSubtype.Glove_Leather] = 12;
		as3.af[WeaponSubtype.Glove_Metal] = 16;
		as3.af[WeaponSubtype.Glove_Boxing] = 12;
		as3.af[WeaponSubtype.Pistol_Laser] = 15;
		as3.af[WeaponSubtype.Pistol_Plasma] = 40;
		as3.af[WeaponSubtype.Pistol_Electro] = 30;
		as3.af[WeaponSubtype.Unarmed] = 10;
		as3.af[WeaponSubtype.Pistol_Acid_Blob] = 25;
		as3.af[WeaponSubtype.Pistol_Cryo_Blob] = 25;
		as3.af[WeaponSubtype.Pistol_Indendiary_Blob] = 25;
		as3.ag = new Dictionary<WeaponSubtype, int>();
		as3.ag[WeaponSubtype.Unknown] = 0;
		as3.ag[WeaponSubtype.Crossbow] = 0;
		as3.ag[WeaponSubtype.Pistol_5] = 20;
		as3.ag[WeaponSubtype.Pistol_762] = 16;
		as3.ag[WeaponSubtype.Pistol_9] = 12;
		as3.ag[WeaponSubtype.Pistol_44] = 8;
		as3.ag[WeaponSubtype.Sniper_762] = 10;
		as3.ag[WeaponSubtype.Sniper_86] = 8;
		as3.ag[WeaponSubtype.Sniper_127] = 6;
		as3.ag[WeaponSubtype.Smg_5] = 30;
		as3.ag[WeaponSubtype.Smg_762] = 25;
		as3.ag[WeaponSubtype.Smg_86] = 20;
		as3.ag[WeaponSubtype.AssaultRifle_762] = 30;
		as3.ag[WeaponSubtype.AssaultRifle_86] = 25;
		as3.ag[WeaponSubtype.AssaultRifle_9] = 20;
		as3.ag[WeaponSubtype.Shotgun_Regular] = 6;
		as3.ag[WeaponSubtype.Shotgun_Combat] = 6;
		as3.ag[WeaponSubtype.GrenadeLauncher_25] = 8;
		as3.ag[WeaponSubtype.GrenadeLauncher_40] = 4;
		as3.ag[WeaponSubtype.RocketLauncher_84] = 1;
		as3.ag[WeaponSubtype.RocketLauncher_40] = 1;
		as3.ag[WeaponSubtype.RocketLauncher_66] = 1;
		as3.ag[WeaponSubtype.LMG_9] = 50;
		as3.ag[WeaponSubtype.LMG_44] = 50;
		as3.ag[WeaponSubtype.Minigun_44] = 50;
		as3.ag[WeaponSubtype.Minigun_127] = 50;
		as3.ag[WeaponSubtype.FusionCannon] = 0;
		as3.ag[WeaponSubtype.Sledgehammer] = 0;
		as3.ag[WeaponSubtype.Spear] = 0;
		as3.ag[WeaponSubtype.Sword] = 0;
		as3.ag[WeaponSubtype.Machete_Straight] = 0;
		as3.ag[WeaponSubtype.Machete_Curved] = 0;
		as3.ag[WeaponSubtype.Knife] = 0;
		as3.ag[WeaponSubtype.SerratedKnife] = 0;
		as3.ag[WeaponSubtype.Dagger] = 0;
		as3.ag[WeaponSubtype.Glove_Leather] = 0;
		as3.ag[WeaponSubtype.Glove_Metal] = 0;
		as3.ag[WeaponSubtype.Glove_Boxing] = 0;
		as3.ag[WeaponSubtype.Pistol_Laser] = 0;
		as3.ag[WeaponSubtype.Pistol_Plasma] = 0;
		as3.ag[WeaponSubtype.Pistol_Electro] = 0;
		as3.ag[WeaponSubtype.Unarmed] = 0;
		as3.ag[WeaponSubtype.Pistol_Acid_Blob] = 8;
		as3.ag[WeaponSubtype.Pistol_Cryo_Blob] = 8;
		as3.ag[WeaponSubtype.Pistol_Indendiary_Blob] = 8;
		as3.ah = new Dictionary<WeaponSubtype, double>();
		as3.ah[WeaponSubtype.Crowbar] = 0.03;
		as3.ah[WeaponSubtype.Sledgehammer] = 0.1;
		as3.ah[WeaponSubtype.Spear] = 0.08;
		as3.ah[WeaponSubtype.Sword] = 0.07;
		as3.ah[WeaponSubtype.Machete_Straight] = 0.07;
		as3.ah[WeaponSubtype.Machete_Curved] = 0.07;
		as3.ah[WeaponSubtype.Knife] = 0.02;
		as3.ah[WeaponSubtype.SerratedKnife] = 0.02;
		as3.ah[WeaponSubtype.Dagger] = 0.03;
		as3.ah[WeaponSubtype.Glove_Leather] = 0.05;
		as3.ah[WeaponSubtype.Glove_Metal] = 0.1;
		as3.ah[WeaponSubtype.Glove_Boxing] = 0.1;
		as3.ah[WeaponSubtype.Unarmed] = 0.0;
		as3.ai = new Dictionary<WeaponSubtype, int>();
		as3.ai[WeaponSubtype.Crowbar] = 6;
		as3.ai[WeaponSubtype.Sledgehammer] = 8;
		as3.ai[WeaponSubtype.Spear] = 7;
		as3.ai[WeaponSubtype.Sword] = 6;
		as3.ai[WeaponSubtype.Machete_Straight] = 6;
		as3.ai[WeaponSubtype.Machete_Curved] = 6;
		as3.ai[WeaponSubtype.Knife] = 5;
		as3.ai[WeaponSubtype.SerratedKnife] = 5;
		as3.ai[WeaponSubtype.Dagger] = 5;
		as3.ai[WeaponSubtype.Glove_Leather] = 5;
		as3.ai[WeaponSubtype.Glove_Metal] = 5;
		as3.ai[WeaponSubtype.Glove_Boxing] = 5;
		as3.ai[WeaponSubtype.Unarmed] = 0;
		as3.aj = new Dictionary<btz, string>();
		as3.aj[btz.c] = "Автомат";
		as3.aj[btz.f] = "Арбалет";
		as3.aj[btz.g] = "Ближнее";
		as3.aj[btz.a] = "Пистолет";
		as3.aj[btz.b] = "Пистолет-пулемёт";
		as3.aj[btz.d] = "Снайперская винтовка";
		as3.aj[btz.e] = "Дробовик";
		as3.aj[btz.h] = "Гранатомёт";
		as3.aj[btz.i] = "Термоядерная пушка";
		as3.aj[btz.j] = "Пулемёт";
		as3.aj[btz.k] = "Миниган";
		as3.aj[btz.l] = "Ракетница";
		as3.ak = new Dictionary<WeaponSubtype, string>();
		as3.ak[WeaponSubtype.Unknown] = "Unknown";
		as3.ak[WeaponSubtype.Crossbow] = "Арбалет";
		as3.ak[WeaponSubtype.Pistol_5] = "5мм пистолет";
		as3.ak[WeaponSubtype.Pistol_762] = "7,62мм пистолет";
		as3.ak[WeaponSubtype.Pistol_9] = "9мм пистолет";
		as3.ak[WeaponSubtype.Pistol_44] = ".44 пистолет";
		as3.ak[WeaponSubtype.Sniper_762] = "7,62мм снайперская винтовка";
		as3.ak[WeaponSubtype.Sniper_86] = "8,6мм снайперская винтовка";
		as3.ak[WeaponSubtype.Sniper_127] = "12,7мм снайперская винтовка";
		as3.ak[WeaponSubtype.Smg_5] = "5мм пистолет-пулемёт";
		as3.ak[WeaponSubtype.Smg_762] = "7,62мм пистолет-пулемёт";
		as3.ak[WeaponSubtype.Smg_86] = "8,6мм пистолет-пулемёт";
		as3.ak[WeaponSubtype.AssaultRifle_762] = "7,62мм автомат";
		as3.ak[WeaponSubtype.AssaultRifle_86] = "8,6мм автомат";
		as3.ak[WeaponSubtype.AssaultRifle_9] = "9мм автомат";
		as3.ak[WeaponSubtype.Shotgun_Regular] = "Дробовик";
		as3.ak[WeaponSubtype.Shotgun_Combat] = "Боевой дробовик";
		as3.ak[WeaponSubtype.GrenadeLauncher_25] = "25мм гранатомёт";
		as3.ak[WeaponSubtype.GrenadeLauncher_40] = "40мм гранатомёт";
		as3.ak[WeaponSubtype.RocketLauncher_84] = "84мм ракетница";
		as3.ak[WeaponSubtype.RocketLauncher_40] = "40мм ракетница";
		as3.ak[WeaponSubtype.RocketLauncher_66] = "66мм ракетница";
		as3.ak[WeaponSubtype.LMG_9] = "9мм пулемёт";
		as3.ak[WeaponSubtype.LMG_44] = ".44 пулемёт";
		as3.ak[WeaponSubtype.Minigun_44] = ".44 миниган";
		as3.ak[WeaponSubtype.Minigun_127] = "12.7мм миниган";
		as3.ak[WeaponSubtype.FusionCannon] = "Термоядерная пушка";
		as3.ak[WeaponSubtype.Sledgehammer] = "Кувалда";
		as3.ak[WeaponSubtype.Spear] = "Копьё";
		as3.ak[WeaponSubtype.Sword] = "Меч";
		as3.ak[WeaponSubtype.Machete_Straight] = "Прямой мачете";
		as3.ak[WeaponSubtype.Machete_Curved] = "Изогнутый мачете";
		as3.ak[WeaponSubtype.Knife] = "Обычный нож";
		as3.ak[WeaponSubtype.SerratedKnife] = "Зазубренный нож";
		as3.ak[WeaponSubtype.Dagger] = "Кинжал";
		as3.ak[WeaponSubtype.Glove_Leather] = "Кожаная перчатка";
		as3.ak[WeaponSubtype.Glove_Metal] = "Металлическая перчатка";
		as3.ak[WeaponSubtype.Glove_Boxing] = "Боксерская перчатка";
		as3.ak[WeaponSubtype.Pistol_Laser] = "Лазерный пистолет";
		as3.ak[WeaponSubtype.Pistol_Plasma] = "Плазменный пистолет";
		as3.ak[WeaponSubtype.Pistol_Electro] = "Электрошоковый пистолет";
		as3.ak[WeaponSubtype.Unarmed] = "Unarmed";
		as3.ak[WeaponSubtype.Pistol_Acid_Blob] = "Кислотный пистолет";
		as3.ak[WeaponSubtype.Pistol_Cryo_Blob] = "Криожидкостный пистолет";
		as3.ak[WeaponSubtype.Pistol_Indendiary_Blob] = "Зажигательный пистолет";
		as3.al = new Dictionary<WeaponSubtype, string>();
		as3.al[WeaponSubtype.Unknown] = "Unknown";
		as3.al[WeaponSubtype.Crossbow] = "Арбалеты";
		as3.al[WeaponSubtype.Pistol_5] = "5мм пистолеты";
		as3.al[WeaponSubtype.Pistol_762] = "7,62мм пистолеты";
		as3.al[WeaponSubtype.Pistol_9] = "9мм пистолеты";
		as3.al[WeaponSubtype.Pistol_44] = ".44 пистолеты";
		as3.al[WeaponSubtype.Sniper_762] = "7,62мм снайперские винтовки";
		as3.al[WeaponSubtype.Sniper_86] = "8,6мм снайперские винтовки";
		as3.al[WeaponSubtype.Sniper_127] = "12,7мм снайперские винтовки";
		as3.al[WeaponSubtype.Smg_5] = "5мм пистолеты-пулемёты";
		as3.al[WeaponSubtype.Smg_762] = "7,62мм пистолеты-пулемёты";
		as3.al[WeaponSubtype.Smg_86] = "8,6мм пистолеты-пулемёты";
		as3.al[WeaponSubtype.AssaultRifle_762] = "7,62мм автоматы";
		as3.al[WeaponSubtype.AssaultRifle_86] = "8,6мм автоматы";
		as3.al[WeaponSubtype.AssaultRifle_9] = "9мм автоматы";
		as3.al[WeaponSubtype.Shotgun_Regular] = "Дробовики";
		as3.al[WeaponSubtype.Shotgun_Combat] = "Боевые дробовики";
		as3.al[WeaponSubtype.GrenadeLauncher_25] = "25мм гранатомёты";
		as3.al[WeaponSubtype.GrenadeLauncher_40] = "40мм гранатомёты";
		as3.al[WeaponSubtype.FusionCannon] = "Термоядерные пушки";
		as3.al[WeaponSubtype.Sledgehammer] = "Кувалды";
		as3.al[WeaponSubtype.Spear] = "Копья";
		as3.al[WeaponSubtype.Sword] = "Мечи";
		as3.al[WeaponSubtype.Machete_Straight] = "Прямые мачете";
		as3.al[WeaponSubtype.Machete_Curved] = "Изогнутые мачете";
		as3.al[WeaponSubtype.Knife] = "Обычные ножи";
		as3.al[WeaponSubtype.SerratedKnife] = "Зазубренные ножи";
		as3.al[WeaponSubtype.Dagger] = "Кинжалы";
		as3.al[WeaponSubtype.Glove_Leather] = "Кожаные перчатки";
		as3.al[WeaponSubtype.Glove_Metal] = "Металлические перчатки";
		as3.al[WeaponSubtype.Glove_Boxing] = "Боксерские перчатки";
		as3.al[WeaponSubtype.Pistol_Laser] = "Лазерные пистолеты";
		as3.al[WeaponSubtype.Pistol_Plasma] = "Плазменные пистолеты";
		as3.al[WeaponSubtype.Pistol_Electro] = "Электрошоковые пистолеты";
		as3.al[WeaponSubtype.Unarmed] = "Unarmed";
		as3.al[WeaponSubtype.Pistol_Acid_Blob] = "Кислотные пистолеты";
		as3.al[WeaponSubtype.Pistol_Cryo_Blob] = "Криожидкостные пистолеты";
		as3.al[WeaponSubtype.Pistol_Indendiary_Blob] = "Зажигательные пистолеты";
		as3.am = new Dictionary<WeaponAggregateSubtype, string>();
		as3.am[WeaponAggregateSubtype.Unknown] = "Неизвестное оружие";
		as3.am[WeaponAggregateSubtype.FirearmPistol] = "Огнестрельный пистолет";
		as3.am[WeaponAggregateSubtype.EnergyPistol] = "Энергетический пистолет";
		as3.am[WeaponAggregateSubtype.Crossbow] = "Арбалет";
		as3.am[WeaponAggregateSubtype.Sniper] = "Снайперская";
		as3.am[WeaponAggregateSubtype.SMG] = "Пистолет-пулемёт";
		as3.am[WeaponAggregateSubtype.AssaultRifle] = "Автомат";
		as3.am[WeaponAggregateSubtype.ChemicalPistol] = "Химический пистолет";
		as3.am[WeaponAggregateSubtype.Shotgun] = "Дробовик";
		as3.am[WeaponAggregateSubtype.GrenadeLauncher] = "Гранатомёт";
		as3.am[WeaponAggregateSubtype.RocketLauncher] = "Ракетница";
		as3.am[WeaponAggregateSubtype.EnergyWeapon] = "Энергетическое оружие";
		as3.am[WeaponAggregateSubtype.Crowbar] = "Монтировка";
		as3.am[WeaponAggregateSubtype.BluntMelee] = "Дробящее оружие";
		as3.am[WeaponAggregateSubtype.BladedMelee] = "Клинковое оружие";
		as3.am[WeaponAggregateSubtype.Gloves] = "Кулачное оружие";
		as3.am[WeaponAggregateSubtype.Spears] = "Копьё";
		as3.am[WeaponAggregateSubtype.Sword] = "Меч";
		as3.am[WeaponAggregateSubtype.Unarmed] = "Безоружных атак";
		as3.an = new Dictionary<WeaponAggregateSubtype, string>();
		as3.an[WeaponAggregateSubtype.Unknown] = "Неизвестное оружие";
		as3.an[WeaponAggregateSubtype.FirearmPistol] = "Огнестрельные пистолеты";
		as3.an[WeaponAggregateSubtype.EnergyPistol] = "Энергетические пистолеты";
		as3.an[WeaponAggregateSubtype.Crossbow] = "Арбалеты";
		as3.an[WeaponAggregateSubtype.Sniper] = "Снайперские";
		as3.an[WeaponAggregateSubtype.SMG] = "Пистолеты-пулемёты";
		as3.an[WeaponAggregateSubtype.AssaultRifle] = "Автоматы";
		as3.an[WeaponAggregateSubtype.ChemicalPistol] = "Химические пистолеты";
		as3.an[WeaponAggregateSubtype.Shotgun] = "Дробовики";
		as3.an[WeaponAggregateSubtype.GrenadeLauncher] = "Гранатомёты";
		as3.an[WeaponAggregateSubtype.RocketLauncher] = "Ракетницы";
		as3.an[WeaponAggregateSubtype.EnergyWeapon] = "Энергетические оружия";
		as3.an[WeaponAggregateSubtype.Crowbar] = "Монтировки";
		as3.an[WeaponAggregateSubtype.BluntMelee] = "Дробящее оружие";
		as3.an[WeaponAggregateSubtype.BladedMelee] = "Клинковое оружие";
		as3.an[WeaponAggregateSubtype.Gloves] = "Кулачное оружие";
		as3.an[WeaponAggregateSubtype.Spears] = "Копья";
		as3.an[WeaponAggregateSubtype.Sword] = "Мечи";
		as3.an[WeaponAggregateSubtype.Unarmed] = "Безоружных атак";
	}

	// Token: 0x04003587 RID: 13703
	public static readonly int a = 0;

	// Token: 0x04003588 RID: 13704
	public const int b = 2000;

	// Token: 0x04003589 RID: 13705
	public static readonly int c = 1500;

	// Token: 0x0400358A RID: 13706
	public static readonly float d = 0.95f;

	// Token: 0x0400358B RID: 13707
	public static readonly int e = d0u.b;

	// Token: 0x0400358C RID: 13708
	public static readonly int f = 1000;

	// Token: 0x0400358D RID: 13709
	public static readonly double g = 6.0;

	// Token: 0x0400358E RID: 13710
	public static readonly double h = 1.0;

	// Token: 0x0400358F RID: 13711
	public static readonly double i = 0.05;

	// Token: 0x04003590 RID: 13712
	public static readonly double j = 0.015;

	// Token: 0x04003591 RID: 13713
	public static readonly double k = 0.5;

	// Token: 0x04003592 RID: 13714
	public static readonly double l = 0.0005;

	// Token: 0x04003593 RID: 13715
	public static readonly Dictionary<btz, double> m;

	// Token: 0x04003594 RID: 13716
	public static readonly Dictionary<btz, double> n;

	// Token: 0x04003595 RID: 13717
	public static readonly double o = 0.007;

	// Token: 0x04003596 RID: 13718
	public static readonly double p = 0.005;

	// Token: 0x04003597 RID: 13719
	public static readonly float q = 0.25f;

	// Token: 0x04003598 RID: 13720
	public static readonly int r = 5;

	// Token: 0x04003599 RID: 13721
	public static readonly double s = 0.4;

	// Token: 0x0400359A RID: 13722
	public static readonly double t = 1.5;

	// Token: 0x0400359B RID: 13723
	public static readonly double u = 4.1;

	// Token: 0x0400359C RID: 13724
	public static readonly Dictionary<btz, int> v;

	// Token: 0x0400359D RID: 13725
	public static readonly Dictionary<WeaponSubtype, double> w;

	// Token: 0x0400359E RID: 13726
	public static readonly Dictionary<WeaponSubtype, double> x;

	// Token: 0x0400359F RID: 13727
	public static readonly Dictionary<btz, float[]> y;

	// Token: 0x040035A0 RID: 13728
	public static readonly Dictionary<btz, int> z;

	// Token: 0x040035A1 RID: 13729
	public static readonly Dictionary<btz, int> aa;

	// Token: 0x040035A2 RID: 13730
	public static readonly Dictionary<btz, double> ab;

	// Token: 0x040035A3 RID: 13731
	public static readonly Dictionary<WeaponSubtype, double> ac;

	// Token: 0x040035A4 RID: 13732
	public static readonly Dictionary<WeaponSubtype, double> ad;

	// Token: 0x040035A5 RID: 13733
	public static readonly Dictionary<WeaponSubtype, b1j> ae;

	// Token: 0x040035A6 RID: 13734
	public static readonly Dictionary<WeaponSubtype, int> af;

	// Token: 0x040035A7 RID: 13735
	public static readonly Dictionary<WeaponSubtype, int> ag;

	// Token: 0x040035A8 RID: 13736
	public static readonly Dictionary<WeaponSubtype, double> ah;

	// Token: 0x040035A9 RID: 13737
	public static readonly Dictionary<WeaponSubtype, int> ai;

	// Token: 0x040035AA RID: 13738
	public static readonly Dictionary<btz, string> aj;

	// Token: 0x040035AB RID: 13739
	public static readonly Dictionary<WeaponSubtype, string> ak;

	// Token: 0x040035AC RID: 13740
	public static readonly Dictionary<WeaponSubtype, string> al;

	// Token: 0x040035AD RID: 13741
	public static readonly Dictionary<WeaponAggregateSubtype, string> am;

	// Token: 0x040035AE RID: 13742
	public static readonly Dictionary<WeaponAggregateSubtype, string> an;

	// Token: 0x040035AF RID: 13743
	public static readonly Dictionary<WeaponSubtype, WeaponAggregateSubtype[]> ao;

	// Token: 0x040035B0 RID: 13744
	public static readonly double ap = 1.0;

	// Token: 0x040035B1 RID: 13745
	public static readonly double aq = 1.0;

	// Token: 0x040035B2 RID: 13746
	public static readonly double ar = 0.65;

	// Token: 0x040035B3 RID: 13747
	public static readonly int @as = 1500;

	// Token: 0x040035B4 RID: 13748
	public static readonly int at = 10;

	// Token: 0x040035B5 RID: 13749
	public static readonly int au = 4;

	// Token: 0x040035B6 RID: 13750
	public static readonly int av = 4;

	// Token: 0x040035B7 RID: 13751
	public static readonly int aw = 8;

	// Token: 0x040035B8 RID: 13752
	public static readonly int ax = 5;

	// Token: 0x040035B9 RID: 13753
	public static readonly double ay = 0.07;

	// Token: 0x040035BA RID: 13754
	public static readonly int az = 18;

	// Token: 0x040035BB RID: 13755
	public static readonly double a0 = 0.05;

	// Token: 0x040035BC RID: 13756
	public static readonly double a1 = 1.0;

	// Token: 0x040035BD RID: 13757
	public static readonly double a2 = 0.25;

	// Token: 0x040035BE RID: 13758
	public static readonly double a3 = 0.3;

	// Token: 0x040035BF RID: 13759
	public static readonly double a4 = 1.0;

	// Token: 0x040035C0 RID: 13760
	public static readonly double a5 = 0.3;

	// Token: 0x040035C1 RID: 13761
	public static readonly double a6 = 1.0;

	// Token: 0x040035C2 RID: 13762
	public static readonly double a7 = 250.0;

	// Token: 0x040035C3 RID: 13763
	public static readonly double a8 = 0.1;

	// Token: 0x040035C4 RID: 13764
	public static readonly double a9 = 0.95;

	// Token: 0x040035C5 RID: 13765
	public static readonly double ba = 0.25;

	// Token: 0x040035C6 RID: 13766
	public static int bb = 3;

	// Token: 0x040035C7 RID: 13767
	public static readonly double bc = 0.1;

	// Token: 0x040035C8 RID: 13768
	public static readonly double bd = 0.95;

	// Token: 0x040035C9 RID: 13769
	public static readonly double be = 4.0;

	// Token: 0x040035CA RID: 13770
	public static readonly double bf = 5.0;

	// Token: 0x040035CB RID: 13771
	public static readonly double bg = 2.0;

	// Token: 0x040035CC RID: 13772
	public static readonly double bh = 0.05;

	// Token: 0x040035CD RID: 13773
	public static readonly double bi = 0.05;

	// Token: 0x040035CE RID: 13774
	public static readonly double bj = 2.0;

	// Token: 0x040035CF RID: 13775
	public static readonly float bk = 0f;

	// Token: 0x040035D0 RID: 13776
	public static readonly double bl = 1.0;

	// Token: 0x040035D1 RID: 13777
	public static readonly double bm = 0.8;

	// Token: 0x040035D2 RID: 13778
	public static readonly double bn = 0.6;

	// Token: 0x040035D3 RID: 13779
	public static readonly double bo = 3.0;

	// Token: 0x040035D4 RID: 13780
	public static readonly double bp = 2.0;

	// Token: 0x040035D5 RID: 13781
	public static readonly double bq = 5000.0;

	// Token: 0x040035D6 RID: 13782
	public static readonly double br = 0.95;

	// Token: 0x040035D7 RID: 13783
	public static readonly double bs = 0.85;

	// Token: 0x040035D8 RID: 13784
	public static readonly string bt = "Electrocution";

	// Token: 0x040035D9 RID: 13785
	public static readonly a1q bu = new a1q(DamageType.Electricity, 80000, 120000);

	// Token: 0x040035DA RID: 13786
	public static readonly double bv = 0.95;

	// Token: 0x040035DB RID: 13787
	public static readonly double bw = 0.1;

	// Token: 0x040035DC RID: 13788
	public static readonly double bx = 0.35;
}
