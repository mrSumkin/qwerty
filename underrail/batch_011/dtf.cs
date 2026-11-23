using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Core.Logging;
using TimelapseVertigo.Generators.Items;

// Token: 0x02000713 RID: 1811
public static class dtf
{
	// Token: 0x06002EF9 RID: 12025 RVA: 0x001094F8 File Offset: 0x001076F8
	public static List<ezv> a(ItemRange A_0, int A_1, int A_2)
	{
		dtf.b();
		List<ezv> list = dtf.a(A_0);
		List<ezv> list2 = new List<ezv>();
		foreach (ezv ezv in list)
		{
			if (ezv != null && ezv.d <= A_2 && ezv.e >= A_1 && (ezv.f == null || dk2.b(ezv.f)))
			{
				if (ezv.g != null)
				{
					try
					{
						if (!ezv.g())
						{
							continue;
						}
					}
					catch
					{
					}
				}
				list2.Add(ezv);
			}
		}
		return list2;
	}

	// Token: 0x06002EFA RID: 12026 RVA: 0x001095D0 File Offset: 0x001077D0
	private static void b()
	{
		if (dtf.b == null)
		{
			object obj = dtf.a;
			lock (obj)
			{
				if (dtf.b == null)
				{
					dtf.b = new Dictionary<string, bgf>();
					dtf.b["currency_sc"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<a54>("Currency\\StygianCoin")), false, false), 3, int.MaxValue, null, null);
					dtf.b["blueprint_recycleItem"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\recycleItem")), false, false), 3, int.MaxValue, null, null);
					dtf.b["blueprint_repairKit"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\repairKit")), false, false), 3, int.MaxValue, null, null);
					dtf.b["blueprint_caltrops"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\caltrops")), false, false), 2, int.MaxValue, null, null);
					dtf.b["blueprint_healthHypo"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\healthHypo")), false, false), 4, int.MaxValue, null, null);
					dtf.b["blueprint_advancedHealthHypo"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\advancedHealthHypo")), false, false), 8, int.MaxValue, null, null);
					dtf.b["blueprint_superHealthHypo"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\superHealthHypo")), false, false), 13, int.MaxValue, null, null);
					dtf.b["blueprint_psiBooster"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\psibooster")), false, false), 5, int.MaxValue, null, null);
					if (dm9.f)
					{
						dtf.b["blueprint_psiInhalant"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\psiInhalant")), false, false), 5, int.MaxValue, null, null);
					}
					dtf.b["blueprint_psiReinvigorator"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\PsiReinvigorator")), false, false), 9, int.MaxValue, null, null);
					dtf.b["blueprint_adrenalineShot"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\adrenalineShot")), false, false), 7, int.MaxValue, null, null);
					dtf.b["blueprint_morphineShot"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\morphineShot")), false, false), 9, int.MaxValue, null, null);
					dtf.b["blueprint_grenade"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\grenade")), false, false), 2, int.MaxValue, null, null);
					dtf.b["blueprint_flashbang"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\flashbang")), false, false), 4, int.MaxValue, null, null);
					dtf.b["blueprint_bearTrap"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\bearTrap")), false, false), 1, int.MaxValue, null, null);
					dtf.b["blueprint_throwingKnives"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\throwingKnives")), false, false), 1, int.MaxValue, null, null);
					dtf.b["blueprint_shockShuriken"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\ShockShurikens")), false, false), 4, int.MaxValue, null, null);
					dtf.b["blueprint_mine"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\mine")), false, false), 2, int.MaxValue, null, null);
					dtf.b["blueprint_empMine"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\empMine")), false, false), 3, int.MaxValue, null, null);
					dtf.b["blueprint_leatherArmor"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\leatherArmor")), false, false), 2, int.MaxValue, null, null);
					dtf.b["blueprint_balaclava"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\balaclava")), false, false), 2, int.MaxValue, null, null);
					dtf.b["blueprint_tacticalVest"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\tacticalVest")), false, false), 4, int.MaxValue, null, null);
					dtf.b["blueprint_riotGear"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\riotGear")), false, false), 5, int.MaxValue, null, null);
					dtf.b["blueprint_metalArmor"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\metalArmor")), false, false), 6, int.MaxValue, null, null);
					dtf.b["blueprint_crossbow"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\crossbow")), false, false), 2, int.MaxValue, null, null);
					dtf.b["blueprint_pistol"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\pistol")), false, false), 2, int.MaxValue, null, null);
					dtf.b["blueprint_sniper"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\sniperRifle")), false, false), 8, int.MaxValue, null, null);
					dtf.b["blueprint_smg"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\smg")), false, false), 3, int.MaxValue, null, null);
					dtf.b["blueprint_combatKnife"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\combatKnife")), false, false), 1, int.MaxValue, null, null);
					dtf.b["blueprint_combatGloves"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\combatGloves")), false, false), 3, int.MaxValue, null, null);
					dtf.b["blueprint_sledgehammer"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\sledgehammer")), false, false), 3, int.MaxValue, null, null);
					dtf.b["blueprint_assaultRifle"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\assaultRifle")), false, false), 6, int.MaxValue, null, null);
					dtf.b["blueprint_energyPistol"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\energyPistol")), false, false), 4, int.MaxValue, null, null);
					dtf.b["blueprint_chemicalPistol"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\chemicalPistol")), false, false), 7, int.MaxValue, null, null);
					dtf.b["blueprint_chemicalAmmo"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\chemicalAmmo")), false, false), 7, int.MaxValue, null, null);
					dtf.b["blueprint_chemicalBlobTrap"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\chemicalBlobTrap")), false, false), 7, int.MaxValue, null, null);
					dtf.b["blueprint_extractToxin"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\ExtractToxin")), false, false), 1, int.MaxValue, null, null);
					dtf.b["blueprint_processPlant"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\ProcessPlant")), false, false), 1, int.MaxValue, null, null);
					dtf.b["blueprint_chemicalBolt"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\ChemicalBolt")), false, false), 1, int.MaxValue, null, null);
					dtf.b["blueprint_mechanicalBolt"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\MechanicalBolt")), false, false), 1, int.MaxValue, null, null);
					dtf.b["blueprint_shockBolt"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\ShockBolt")), false, false), 2, int.MaxValue, null, null);
					dtf.b["blueprint_incendiaryBolt"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\IncendiaryBolt")), false, false), 2, int.MaxValue, null, null);
					dtf.b["blueprint_empGrenade"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\EmpGrenade")), false, false), 4, int.MaxValue, null, null);
					dtf.b["blueprint_cloakingDevice"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\CloakingDevice")), false, false), 5, int.MaxValue, null, null);
					dtf.b["blueprint_metalHelmet"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\metalHelmet")), false, false), 5, int.MaxValue, null, null);
					dtf.b["blueprint_goggles"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\goggles")), false, false), 4, int.MaxValue, null, null);
					dtf.b["blueprint_energyShieldEmitter"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\energyShieldEmitter")), false, false), 8, int.MaxValue, null, null);
					dtf.b["blueprint_boots"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\boots")), false, false), 0, int.MaxValue, null, null);
					dtf.b["blueprint_greaves"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\greaves")), false, false), 0, int.MaxValue, null, null);
					dtf.b["blueprint_tabiBoots"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\TabiBoots")), false, false), 0, int.MaxValue, null, null);
					dtf.b["blueprint_psionicHeadband"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\psionicHeadband")), false, false), 5, int.MaxValue, null, null);
					dtf.b["blueprint_taser"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\taser")), false, false), 1, int.MaxValue, null, null);
					dtf.b["blueprint_irongut"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\irongut")), false, false), 8, int.MaxValue, null, null);
					dtf.b["blueprint_trance"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\trance")), false, false), 10, int.MaxValue, null, null);
					dtf.b["blueprint_aegis"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\aegis")), false, false), 8, int.MaxValue, null, null);
					dtf.b["blueprint_focusStim"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\focusStim")), false, false), 7, int.MaxValue, null, null);
					dtf.b["blueprint_jumpingBean"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\jumpingBean")), false, false), 5, int.MaxValue, null, null);
					dtf.b["blueprint_bullhead"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\Bullhead")), false, false), 12, int.MaxValue, null, null);
					dtf.b["blueprint_incendiaryGrenade"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\IncendiaryGrenade")), false, false), 2, int.MaxValue, null, null);
					dtf.b["blueprint_gasGrenade"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\GasGrenade")), false, false), 3, int.MaxValue, null, null);
					dtf.b["blueprint_bullets"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\bullets")), false, false), 1, int.MaxValue, null, null);
					dtf.b["blueprint_w2cBullets"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\W2CBullets")), false, false), 6, int.MaxValue, null, null);
					dtf.b["blueprint_jhpBullets"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\JHPBullets")), false, false), 6, int.MaxValue, null, null);
					dtf.b["blueprint_shockBullets"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\shockBullets")), false, false), 5, int.MaxValue, null, null);
					dtf.b["blueprint_microShrapnelBullets"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\microShrapnelBullets")), false, false), 6, int.MaxValue, null, null);
					dtf.b["blueprint_incendiaryBullets"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\incendiaryBullets")), false, false), 7, int.MaxValue, null, null);
					dtf.b["blueprint_acidBullets"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\acidBullets")), false, false), 8, int.MaxValue, null, null);
					dtf.b["blueprint_explosiveBullets"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\explosiveBullets")), false, false), 9, int.MaxValue, null, null);
					dtf.b["blueprint_contaminatedBullets"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\contaminatedBullets")), false, false), 10, int.MaxValue, null, null);
					dtf.b["blueprint_thinGrenadeCase"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\thinGrenadeCase")), false, false), 1, int.MaxValue, null, null);
					dtf.b["blueprint_fragGrenadeCase"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\fragGrenadeCase")), false, false), 1, int.MaxValue, null, null);
					dtf.b["blueprint_thinMineCase"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\thinMineCase")), false, false), 1, int.MaxValue, null, null);
					dtf.b["blueprint_fragMineCase"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\fragMineCase")), false, false), 1, int.MaxValue, null, null);
					dtf.b["blueprint_throwingNet"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\throwingNet")), false, false), 3, int.MaxValue, null, null);
					dtf.b["blueprint_lockpicks"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\lockpicks")), false, false), 1, int.MaxValue, null, null);
					dtf.b["blueprint_shiv"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\shiv")), false, false), 1, int.MaxValue, null, null);
					if (dk2.f())
					{
						dtf.b["xpbl_blueprint_stingballGrenade"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\xpbl\\StingballGrenade")), false, false), 5, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_blueprint_plasmaGrenade"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\xpbl\\PlasmaGrenade")), false, false), 15, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_blueprint_plasmaMine"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\xpbl\\PlasmaMine")), false, false), 15, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_blueprint_spyingEndoscope"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\xpbl\\SpyingEndoscope")), false, false), 5, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_blueprint_broadheadBolt"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\xpbl\\BroadheadBolt")), false, false), 10, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_blueprint_psionicAccelerator"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\xpbl\\PsionicAccelerator")), false, false), 12, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_blueprint_coagulationShot"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\xpbl\\CoagulationShot")), false, false), 10, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_blueprint_hypercerebrix"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\xpbl\\Hypercerebrix")), false, false), 10, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_blueprint_twitch"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\xpbl\\Twitch")), false, false), 10, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_blueprint_thirdEye"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\xpbl\\ThirdEye")), false, false), 15, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_blueprint_spear"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\xpbl\\spear")), false, false), 5, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_blueprint_machete"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\xpbl\\machete")), false, false), 3, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_blueprint_shotgunShells"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\xpbl\\shotgunShells")), false, false), 3, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_blueprint_shotgun"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\xpbl\\shotgun")), false, false), 3, int.MaxValue, "xpbl", null);
					}
					if (dk2.e())
					{
						dtf.b["xphw_blueprint_grenadeLauncher"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\xphw\\grenadeLauncher")), false, false), 6, int.MaxValue, "xphw", null);
						dtf.b["xphw_blueprint_rocketLauncher"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\xphw\\rocketLauncher")), false, false), 15, int.MaxValue, "xphw", null);
						dtf.b["xphw_blueprint_highExplosiveLauncherGrenade"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\xphw\\HighExplosiveLauncherGrenade")), false, false), 6, int.MaxValue, "xphw", null);
						dtf.b["xphw_blueprint_fragLauncherGrenade"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\xphw\\FragLauncherGrenade")), false, false), 6, int.MaxValue, "xphw", null);
						dtf.b["xphw_blueprint_concussiveLauncherGrenade"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\xphw\\ConcussiveLauncherGrenade")), false, false), 6, int.MaxValue, "xphw", null);
						dtf.b["xphw_blueprint_incendiaryLauncherGrenade"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\xphw\\IncendiaryLauncherGrenade")), false, false), 6, int.MaxValue, "xphw", null);
						dtf.b["xphw_blueprint_thermobaricLauncherGrenade"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\xphw\\ThermobaricLauncherGrenade")), false, false), 6, int.MaxValue, "xphw", null);
						dtf.b["xphw_blueprint_clusterLauncherGrenade"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\xphw\\ClusterLauncherGrenade")), false, false), 6, int.MaxValue, "xphw", null);
						dtf.b["xphw_blueprint_lightMachineGun"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\xphw\\lmg")), false, false), 1, int.MaxValue, "xphw", null);
						dtf.b["xphw_blueprint_minigun"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\xphw\\minigun")), false, false), 15, int.MaxValue, "xphw", null);
						dtf.b["xphw_blueprint_rocket84HighExplosive"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\xphw\\Rocket84HighExplosive")), false, false), 12, int.MaxValue, "xphw", null);
						dtf.b["xphw_blueprint_rocket84Kinetic"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\xphw\\Rocket84Kinetic")), false, false), 12, int.MaxValue, "xphw", null);
						dtf.b["xphw_blueprint_rocket84CaveShaker"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\xphw\\Rocket84CaveShaker")), false, false), 18, int.MaxValue, "xphw", null);
						dtf.b["xphw_blueprint_rocket84WhitePhosphorus"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\xphw\\Rocket84WhitePhosphorus")), false, false), 22, int.MaxValue, "xphw", null);
					}
					dtf.b["mentor_NeuralOverload"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\NeuralOverload")), false, false), 3, int.MaxValue, null, null);
					dtf.b["mentor_Frighten"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\Frighten")), false, false), 5, int.MaxValue, null, null);
					dtf.b["mentor_MentalBreakdown"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\MentalBreakdown")), false, false), 7, int.MaxValue, null, null);
					dtf.b["mentor_Enrage"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\enrage")), false, false), 10, int.MaxValue, null, null);
					dtf.b["mentor_PsiCognitiveInterruption"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\PsiCognitiveInterruption")), false, false), 10, int.MaxValue, null, null);
					dtf.b["mentor_PseudoSpatialProjection"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\PseudoSpatialProjection")), false, false), 10, int.MaxValue, null, null);
					dtf.b["mentor_NeurovisualDisruption"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\NeurovisualDisruption")), false, false), 10, int.MaxValue, null, null);
					dtf.b["mentor_MotorCognitiveTransference"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\MotorCognitiveTransference")), false, false), 8, int.MaxValue, null, null);
					dtf.b["mentor_PsychosomaticPredation"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\PsychosomaticPredation")), false, false), 9, int.MaxValue, null, null);
					dtf.b["mentor_TelekineticPunch"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\TelekineticPunch")), false, false), 2, int.MaxValue, null, null);
					dtf.b["mentor_Electrokinesis"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\Electrokinesis")), false, false), 3, int.MaxValue, null, null);
					dtf.b["mentor_ForceEmission"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\ForceEmission")), false, false), 4, int.MaxValue, null, null);
					dtf.b["mentor_ForceField"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\ForceField")), false, false), 5, int.MaxValue, null, null);
					dtf.b["mentor_TelekineticProxy"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\TelekineticProxy")), false, false), 9, int.MaxValue, null, null);
					dtf.b["mentor_ElectrokineticImprint"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\ElectrokineticImprint")), false, false), 10, int.MaxValue, null, null);
					dtf.b["mentor_Implosion"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\Implosion")), false, false), 10, int.MaxValue, null, null);
					dtf.b["mentor_DisruptiveField"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\DisruptiveField")), false, false), 8, int.MaxValue, null, null);
					dtf.b["mentor_TelekineticGrounding"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\TelekineticGrounding")), false, false), 4, int.MaxValue, null, null);
					dtf.b["mentor_PsychokineticChain"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\PsychokineticChain")), false, false), 10, int.MaxValue, null, null);
					dtf.b["mentor_Cryokinesis"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\Cryokinesis")), false, false), 3, int.MaxValue, null, null);
					dtf.b["mentor_Pyrokinesis"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\Pyrokinesis")), false, false), 4, int.MaxValue, null, null);
					dtf.b["mentor_Cryostasis"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\Cryostasis")), false, false), 6, int.MaxValue, null, null);
					dtf.b["mentor_PyrokineticStream"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\PyrokineticStream")), false, false), 7, int.MaxValue, null, null);
					dtf.b["mentor_ThermodynamicDestabilization"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\ThermodynamicDestabilization")), false, false), 8, int.MaxValue, null, null);
					dtf.b["mentor_CryokineticOrb"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\CryokineticOrb")), false, false), 10, int.MaxValue, null, null);
					dtf.b["mentor_CryogenicBarrier"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\CryogenicBarrier")), false, false), 11, int.MaxValue, null, null);
					dtf.b["mentor_ExothermicAura"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\ExothermicAura")), false, false), 10, int.MaxValue, null, null);
					dtf.b["mentor_CryoShield"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\CryoShield")), false, false), 8, int.MaxValue, null, null);
					dtf.b["mentor_PlasmaBeam"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\PlasmaBeam")), false, false), 14, int.MaxValue, null, null);
					if (dk2.f())
					{
						dtf.b["xpbl_mentor_TemporalDistorsion"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\xpbl\\TemporalDistorsion")), false, false), 3, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_mentor_PsychotemporalDilation"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\xpbl\\PsychotemporalDilation")), false, false), 4, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_mentor_LimitedTemporalIncrement"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\xpbl\\LimitedTemporalIncrement")), false, false), 6, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_mentor_EntropicRecurrence"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\xpbl\\EntropicRecurrence")), false, false), 7, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_mentor_PsychotemporalContraction"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\xpbl\\PsychotemporalContraction")), false, false), 9, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_mentor_TemporaryRewind"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\xpbl\\TemporaryRewind")), false, false), 10, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_mentor_Precognition"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\xpbl\\Precognition")), false, false), 11, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_mentor_Stasis"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<eml>("PsiMentors\\xpbl\\Stasis")), false, false), 12, int.MaxValue, "xpbl", null);
					}
					dtf.b["psiBooster"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<dgn>("consumables\\medicine\\psiBooster")), false, false), 3, int.MaxValue, null, null);
					if (dm9.f)
					{
						dtf.b["psiInhalant"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<dgn>("consumables\\medicine\\psiInhalant")), false, false), 1, int.MaxValue, null, null);
					}
					dtf.b["adrenalineShot"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<dgn>("consumables\\medicine\\adrenalineShot")), false, false), 5, int.MaxValue, null, null);
					dtf.b["morphineShot"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<dgn>("consumables\\medicine\\morphineShot")), false, false), 3, int.MaxValue, null, null);
					dtf.b["healthHypo"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<dgn>("consumables\\medicine\\healthHypo")), false, false), 0, int.MaxValue, null, null);
					dtf.b["advancedHealthHypo"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<dgn>("consumables\\medicine\\advancedhealthHypo")), false, false), 8, int.MaxValue, null, null);
					dtf.b["bandage"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<dgn>("consumables\\medicine\\bandage")), false, false), 0, int.MaxValue, null, null);
					dtf.b["antidote"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<dgn>("consumables\\medicine\\antidote")), false, false), 2, int.MaxValue, null, null);
					dtf.b["irongut"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<dgn>("consumables\\medicine\\irongut")), false, false), 8, int.MaxValue, null, null);
					dtf.b["trance"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<dgn>("consumables\\medicine\\trance")), false, false), 10, int.MaxValue, null, null);
					dtf.b["aegis"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<dgn>("consumables\\medicine\\aegis")), false, false), 8, int.MaxValue, null, null);
					dtf.b["focusStim"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<dgn>("consumables\\medicine\\focusStim")), false, false), 7, int.MaxValue, null, null);
					dtf.b["jumpingBean"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<dgn>("consumables\\medicine\\jumpingBean")), false, false), 5, int.MaxValue, null, null);
					dtf.b["flashbang"] = new bgf(new a64(new acz(ez2.CreateDefinitonProvider<dxw>("grenades\\flashbang")), false, false), 5, int.MaxValue, null, null);
					dtf.b["lockpick"] = new bgf(new d0a(), 0, int.MaxValue, null, null);
					dtf.b["haxxor"] = new bgf(new edt(), 0, int.MaxValue, null, null);
					dtf.b["throwingNet"] = new bgf(new a64(new acz(ez2.CreateDefinitonProvider<cdk>("devices\\throwingNet")), false, false), 1, int.MaxValue, null, null);
					dtf.b["stoneBolas"] = new bgf(new a64(new acz(ez2.CreateDefinitonProvider<cdk>("devices\\xpbl\\stoneBolas")), false, false), 1, int.MaxValue, null, null);
					dtf.b["flare"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<ebz>("devices\\flare")), false, false), 0, int.MaxValue, null, null);
					dtf.b["fishingRod"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<ebz>("devices\\fishingRod")), false, false), 4, int.MaxValue, null, null);
					dtf.b["lighter"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<ebz>("devices\\lighter")), false, false), 0, int.MaxValue, null, null);
					dtf.b["electricTorch"] = new bgf(new a64(new acz(ez2.CreateDefinitonProvider<cdk>("devices\\ElectricTorch")), false, false), 1, int.MaxValue, null, null);
					if (dk2.f())
					{
						dtf.b["xpbl_hotwiringKit"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<ebz>("devices\\HotwiringKit")), false, false), 10, int.MaxValue, "xpbl", null);
					}
					dtf.b["mechanicalRepairKit1"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<ebz>("devices\\mechanicalRepairKit1")), false, false), 0, int.MaxValue, null, null);
					dtf.b["mechanicalRepairKit2"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<ebz>("devices\\mechanicalRepairKit2")), false, false), 8, int.MaxValue, null, null);
					dtf.b["electronicRepairKit1"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<ebz>("devices\\electronicRepairKit1")), false, false), 0, int.MaxValue, null, null);
					dtf.b["electronicRepairKit2"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<ebz>("devices\\electronicRepairKit2")), false, false), 8, int.MaxValue, null, null);
					dtf.b["patchingKit1"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<ebz>("devices\\patchingKit1")), false, false), 0, int.MaxValue, null, null);
					dtf.b["patchingKit2"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<ebz>("devices\\patchingKit2")), false, false), 8, int.MaxValue, null, null);
					dtf.b["sharpeningStone"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<dy0>("Expendables\\GearBoosters\\SharpeningStone")), false, false), 0, int.MaxValue, null, null);
					dtf.b["firecrackerCap"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<dy0>("Expendables\\GearBoosters\\FirecrackerCap")), false, false), 0, int.MaxValue, null, null);
					dtf.b["armor_leatherArmor"] = new bgf(new ee3(), 0, int.MaxValue, null, null);
					dtf.b["armor_tacticalVest"] = new bgf(new bb4(), 4, int.MaxValue, null, null);
					dtf.b["armor_riotGear"] = new bgf(new by2(), 5, int.MaxValue, null, null);
					dtf.b["armor_metalArmor"] = new bgf(new de2(), 10, int.MaxValue, null, null);
					dtf.b["armor_metalHelmet"] = new bgf(new ecy(), 7, int.MaxValue, null, null);
					dtf.b["armor_goggles"] = new bgf(new dpe(), 5, int.MaxValue, null, null);
					dtf.b["armor_balaclava"] = new bgf(new n(), 2, int.MaxValue, null, null);
					dtf.b["armor_shieldEmitter"] = new bgf(new xm(), 8, int.MaxValue, null, null);
					dtf.b["armor_psionicHeadband"] = new bgf(new byo(), 6, int.MaxValue, null, null);
					dtf.b["armor_biotechSuit"] = new bgf(new a64(new c8d(ez2.CreateDefinitonProvider<c43>("armor\\biotechSuit")), false, false), 3, int.MaxValue, null, null);
					dtf.b["armor_doctorsCoat"] = new bgf(new a64(new c8d(ez2.CreateDefinitonProvider<c43>("armor\\DoctorsCoat")), false, false), 2, int.MaxValue, null, null);
					dtf.b["armor_fireProximitySuit"] = new bgf(new a64(new c8d(ez2.CreateDefinitonProvider<c43>("armor\\FireProximitySuit")), false, false), 12, int.MaxValue, null, null);
					dtf.b["armor_blastSuit"] = new bgf(new a64(new c8d(ez2.CreateDefinitonProvider<c43>("armor\\blastSuit")), false, false), 15, int.MaxValue, null, null);
					dtf.b["armor_miningHelmet"] = new bgf(new a64(new k7(ez2.CreateDefinitonProvider<bqu>("armor\\miningHelmet")), false, false), 5, int.MaxValue, null, null);
					dtf.b["armor_gasMask"] = new bgf(new a64(new k7(ez2.CreateDefinitonProvider<bqu>("armor\\GasMask")), false, false), 3, int.MaxValue, null, null);
					dtf.b["armor_robe"] = new bgf(new a64(new c8d(ez2.CreateDefinitonProvider<c43>("armor\\Robe")), false, false), 2, int.MaxValue, null, null);
					dtf.b["armor_workerSuit"] = new bgf(new a64(new c8d(ez2.CreateDefinitonProvider<c43>("armor\\WorkerSuit")), false, false), 1, int.MaxValue, null, null);
					dtf.b["belt_utility"] = new bgf(new a64(new cjh(ez2.CreateDefinitonProvider<c27>("armor\\utilityBelt")), false, false), 1, int.MaxValue, null, null);
					dtf.b["belt_bulletstrap"] = new bgf(new a64(new cjh(ez2.CreateDefinitonProvider<c27>("armor\\BulletstrapBelt")), false, false), 1, int.MaxValue, null, null);
					dtf.b["belt_doctorsPouch"] = new bgf(new a64(new cjh(ez2.CreateDefinitonProvider<c27>("armor\\DoctorsPouch")), false, false), 1, int.MaxValue, null, null);
					dtf.b["belt_trappersBelt"] = new bgf(new a64(new cjh(ez2.CreateDefinitonProvider<c27>("armor\\trappersBelt")), false, false), 1, int.MaxValue, null, null);
					dtf.b["belt_groinGuard"] = new bgf(new a64(new cjh(ez2.CreateDefinitonProvider<c27>("armor\\groinGuard")), false, false), 1, int.MaxValue, null, null);
					dtf.b["belt_liftingBelt"] = new bgf(new a64(new cjh(ez2.CreateDefinitonProvider<c27>("armor\\liftingBelt")), false, false), 2, int.MaxValue, null, null);
					dtf.b["belt_vigorousBelt"] = new bgf(new a64(new cjh(ez2.CreateDefinitonProvider<c27>("armor\\vigorousBelt")), false, false), 1, int.MaxValue, null, null);
					dtf.b["belt_catalyzingBelt"] = new bgf(new a64(new cjh(ez2.CreateDefinitonProvider<c27>("armor\\CatalyzingBelt")), false, false), 5, int.MaxValue, null, null);
					dtf.b["belt_advancedCatalyzingBelt"] = new bgf(new a64(new cjh(ez2.CreateDefinitonProvider<c27>("armor\\AdvancedCatalyzingBelt")), false, false), 10, int.MaxValue, null, null);
					dtf.b["belt_waistPack"] = new bgf(new a64(new cjh(ez2.CreateDefinitonProvider<c27>("armor\\waistPack")), false, false), 1, int.MaxValue, null, null);
					dtf.b["belt_largeWaistPack"] = new bgf(new a64(new cjh(ez2.CreateDefinitonProvider<c27>("armor\\largeWaistPack")), false, false), 10, int.MaxValue, null, null);
					if (dk2.f())
					{
						dtf.b["xpbl_belt_boltQuiver"] = new bgf(new a64(new cjh(ez2.CreateDefinitonProvider<c27>("armor\\Xpbl\\BoltQuiver")), false, false), 8, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_belt_shellstrap"] = new bgf(new a64(new cjh(ez2.CreateDefinitonProvider<c27>("armor\\Xpbl\\ShellstrapBelt")), false, false), 4, int.MaxValue, "xpbl", null);
					}
					if (dk2.e())
					{
						dtf.b["belt_launcherGrenadeStrap"] = new bgf(new a64(new cjh(ez2.CreateDefinitonProvider<c27>("armor\\Xphw\\LauncherGrenadeBelt")), false, false), 10, int.MaxValue, "xphw", null);
					}
					dtf.b["boots"] = new bgf(new b0h(), 0, int.MaxValue, null, null);
					dtf.b["greaves"] = new bgf(new dfl(), 5, int.MaxValue, null, null);
					dtf.b["tabiBoots"] = new bgf(new ao9(), 0, int.MaxValue, null, null);
					dtf.b["pistol"] = new bgf(new coj(), 0, int.MaxValue, null, null);
					dtf.b["smg"] = new bgf(new cvs(), 3, int.MaxValue, null, null);
					dtf.b["sniper"] = new bgf(new cjj(), 5, int.MaxValue, null, null);
					dtf.b["assaultRifle"] = new bgf(new b2d(), 5, int.MaxValue, null, null);
					dtf.b["energyPistol"] = new bgf(new dro(), 6, int.MaxValue, null, null);
					dtf.b["knife"] = new bgf(new an5(), 1, int.MaxValue, null, null);
					dtf.b["sledgehammer"] = new bgf(new ass(), 3, int.MaxValue, null, null);
					dtf.b["crossbow"] = new bgf(new e3u(), 1, int.MaxValue, null, null);
					dtf.b["gloves"] = new bgf(new a1a(), 1, int.MaxValue, null, null);
					dtf.b["steel_crowbar"] = new bgf(new a64(new cd1(ez2.CreateDefinitonProvider<bke>("weapons\\steelCrowbar")), false, false), 2, int.MaxValue, null, null);
					dtf.b["tungsten_crowbar"] = new bgf(new a64(new cd1(ez2.CreateDefinitonProvider<bke>("weapons\\tungstenCrowbar")), false, false), 10, int.MaxValue, null, null);
					dtf.b["tichrome_crowbar"] = new bgf(new a64(new cd1(ez2.CreateDefinitonProvider<bke>("weapons\\tiChromeCrowbar")), false, false), 12, int.MaxValue, null, null);
					dtf.b["superSteel_crowbar"] = new bgf(new a64(new cd1(ez2.CreateDefinitonProvider<bke>("weapons\\superSteelCrowbar")), false, false), 20, int.MaxValue, null, null);
					dtf.b["shiv"] = new bgf(new a64(new cd1(ez2.CreateDefinitonProvider<bke>("weapons\\shiv")), false, false), 1, int.MaxValue, null, null);
					dtf.b["boxingGloves"] = new bgf(new a64(new cd1(ez2.CreateDefinitonProvider<bke>("weapons\\BoxingGloves")), false, false), 5, int.MaxValue, null, null);
					dtf.b["brassKnuckles"] = new bgf(new a64(new cd1(ez2.CreateDefinitonProvider<bke>("weapons\\BrassKnuckles")), false, false), 3, int.MaxValue, null, null);
					dtf.b["knifeThrowerGloves"] = new bgf(new a64(new cd1(ez2.CreateDefinitonProvider<bke>("weapons\\knifeThrowerGloves")), false, false), 4, int.MaxValue, null, null);
					if (dk2.f())
					{
						dtf.b["xpbl_spear"] = new bgf(new cpj(), 5, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_machete"] = new bgf(new b5e(), 3, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_shotgun"] = new bgf(new cob(), 3, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_javelin"] = new bgf(new a64(new cd1(ez2.CreateDefinitonProvider<bke>("weapons\\xpbl\\javelin")), false, false), 10, int.MaxValue, "xpbl", null);
					}
					if (dk2.e())
					{
						dtf.b["xphw_grenadeLauncher"] = new bgf(new auy(), 5, int.MaxValue, "xphw", null);
						dtf.b["xphw_rocketLauncher"] = new bgf(new d1b(), 12, int.MaxValue, "xphw", null);
						dtf.b["xphw_rocketLauncher_drl"] = new bgf(new a64(new cd1(ez2.CreateDefinitonProvider<bke>("weapons\\xphw\\drl")), false, false), 3, int.MaxValue, "xphw", null);
						dtf.b["xphw_lightMachineGun"] = new bgf(new c3m(), 1, int.MaxValue, "xphw", null);
						dtf.b["xphw_minigun"] = new bgf(new e65(), 15, int.MaxValue, "xphw", null);
					}
					Dictionary<string, bgf> dictionary = dtf.b;
					string key = "pistol_with_ammo";
					coj coj = new coj();
					coj.d(cuo.a.Next(2, 4) * 10);
					dictionary[key] = new bgf(coj, 0, int.MaxValue, null, null);
					Dictionary<string, bgf> dictionary2 = dtf.b;
					string key2 = "smg_with_ammo";
					cvs cvs = new cvs();
					cvs.d(cuo.a.Next(6, 9) * 10);
					dictionary2[key2] = new bgf(cvs, 3, int.MaxValue, null, null);
					Dictionary<string, bgf> dictionary3 = dtf.b;
					string key3 = "sniper_with_ammo";
					cjj cjj = new cjj();
					cjj.d(cuo.a.Next(15, 20));
					dictionary3[key3] = new bgf(cjj, 5, int.MaxValue, null, null);
					Dictionary<string, bgf> dictionary4 = dtf.b;
					string key4 = "assaultRifle_with_ammo";
					b2d b2d = new b2d();
					b2d.d(cuo.a.Next(6, 9) * 10);
					dictionary4[key4] = new bgf(b2d, 5, int.MaxValue, null, null);
					Dictionary<string, bgf> dictionary5 = dtf.b;
					string key5 = "energyPistol_with_ammo";
					dro dro = new dro();
					dro.d(cuo.a.Next(2, 4));
					dictionary5[key5] = new bgf(dro, 6, int.MaxValue, null, null);
					Dictionary<string, bgf> dictionary6 = dtf.b;
					string key6 = "crossbow_with_ammo";
					e3u e3u = new e3u();
					e3u.d(cuo.a.Next(2, 4) * 10);
					dictionary6[key6] = new bgf(e3u, 1, int.MaxValue, null, null);
					if (dk2.f())
					{
						Dictionary<string, bgf> dictionary7 = dtf.b;
						string key7 = "xpbl_shotgun_with_ammo";
						cob cob = new cob();
						cob.d(cuo.a.Next(2, 4) * 10);
						dictionary7[key7] = new bgf(cob, 3, int.MaxValue, "xpbl", null);
					}
					if (dk2.e())
					{
						Dictionary<string, bgf> dictionary8 = dtf.b;
						string key8 = "xphw_grenadeLauncher_with_ammo";
						auy auy = new auy();
						auy.d(cuo.a.Next(2, 4) * 4);
						dictionary8[key8] = new bgf(auy, 5, int.MaxValue, "xphw", null);
						Dictionary<string, bgf> dictionary9 = dtf.b;
						string key9 = "xphw_rocketLauncher_with_ammo";
						d1b d1b = new d1b();
						d1b.d(cuo.a.Next(1, 4));
						dictionary9[key9] = new bgf(d1b, 12, int.MaxValue, "xphw", null);
						Dictionary<string, bgf> dictionary10 = dtf.b;
						string key10 = "xphw_lightMachineGun_with_ammo";
						c3m c3m = new c3m();
						c3m.d(cuo.a.Next(7, 10) * 10);
						dictionary10[key10] = new bgf(c3m, 1, int.MaxValue, "xphw", null);
						Dictionary<string, bgf> dictionary11 = dtf.b;
						string key11 = "xphw_minigun_with_ammo";
						e65 e = new e65();
						e.d(cuo.a.Next(7, 10) * 20);
						dictionary11[key11] = new bgf(e, 15, int.MaxValue, "xphw", null);
					}
					dtf.b["grenade_frag"] = new bgf(new ac2(GrenadeOrMineType.Frag), 2, int.MaxValue, null, null);
					dtf.b["grenade_he"] = new bgf(new ac2(GrenadeOrMineType.HE), 3, int.MaxValue, null, null);
					dtf.b["grenade_emp"] = new bgf(new ac2(GrenadeOrMineType.Emp), 4, int.MaxValue, null, null);
					dtf.b["molotovCocktail"] = new bgf(new a64(new acz(ez2.CreateDefinitonProvider<dxw>("Grenades\\MolotovCocktail")), false, false), 1, int.MaxValue, null, null);
					dtf.b["mine_frag"] = new bgf(new ayz(GrenadeOrMineType.Frag), 3, int.MaxValue, null, null);
					dtf.b["mine_he"] = new bgf(new ayz(GrenadeOrMineType.HE), 4, int.MaxValue, null, null);
					dtf.b["mine_emp"] = new bgf(new ayz(GrenadeOrMineType.Emp), 5, int.MaxValue, null, null);
					dtf.b["bearTrap"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<c4j>("Traps\\bearTrap")), false, false), 1, 10, null, null);
					dtf.b["burrowerPoisonBearTrap"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<c4j>("Traps\\burrowerPoisonBearTrap")), false, false), 4, int.MaxValue, null, null);
					dtf.b["caveEarPoisonBearTrap"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<c4j>("Traps\\caveEarPoisonBearTrap")), false, false), 7, int.MaxValue, null, null);
					dtf.b["crawlerPoisonBearTrap"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<c4j>("Traps\\crawlerPoisonBearTrap")), false, false), 10, int.MaxValue, null, null);
					if (dk2.f())
					{
						dtf.b["xpbl_blindingPoisonBearTrap"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<c4j>("Traps\\xpbl\\BlindingPoisonBearTrap")), false, false), 10, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_leperPoisonBearTrap"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<c4j>("Traps\\xpbl\\leperPoisonBearTrap")), false, false), 10, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_heartbreakPoisonBearTrap"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<c4j>("Traps\\xpbl\\heartbreakPoisonBearTrap")), false, false), 10, int.MaxValue, "xpbl", null);
					}
					dtf.b["throwingKnife"] = new bgf(new a64(new acz(ez2.CreateDefinitonProvider<cdk>("Weapons\\ThrowingKnife")), false, false), 1, 10, null, null);
					dtf.b["burrowerPoisonThrowingKnife"] = new bgf(new a64(new acz(ez2.CreateDefinitonProvider<cdk>("Weapons\\burrowerPoisonThrowingKnife")), false, false), 4, int.MaxValue, null, null);
					dtf.b["caveEarPoisonThrowingKnife"] = new bgf(new a64(new acz(ez2.CreateDefinitonProvider<cdk>("Weapons\\caveEarPoisonThrowingKnife")), false, false), 7, int.MaxValue, null, null);
					dtf.b["crawlerPoisonThrowingKnife"] = new bgf(new a64(new acz(ez2.CreateDefinitonProvider<cdk>("Weapons\\crawlerPoisonThrowingKnife")), false, false), 10, int.MaxValue, null, null);
					dtf.b["acidBlobTrap1"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<c4j>("Traps\\AcidBlobTrap1")), false, false), 7, 11, null, null);
					dtf.b["acidBlobTrap2"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<c4j>("Traps\\AcidBlobTrap2")), false, false), 12, 16, null, null);
					dtf.b["acidBlobTrap3"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<c4j>("Traps\\AcidBlobTrap3")), false, false), 17, int.MaxValue, null, null);
					dtf.b["caltrops_regular"] = new bgf(new a64(new acz(ez2.CreateDefinitonProvider<cdk>("devices\\caltrops")), false, false), 2, int.MaxValue, null, null);
					dtf.b["caltrops_burrowerPoison"] = new bgf(new a64(new acz(ez2.CreateDefinitonProvider<cdk>("devices\\BurrowerPoisonCaltrops")), false, false), 4, int.MaxValue, null, null);
					dtf.b["caltrops_caveEarPoison"] = new bgf(new a64(new acz(ez2.CreateDefinitonProvider<cdk>("devices\\caveEarPoisonCaltrops")), false, false), 7, int.MaxValue, null, null);
					dtf.b["caltrops_crawlerPoison"] = new bgf(new a64(new acz(ez2.CreateDefinitonProvider<cdk>("devices\\crawlerPoisonCaltrops")), false, false), 10, int.MaxValue, null, null);
					dtf.b["component_cardboardContainer"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\containers\\cardboardcontainer")), false, false), 5, int.MaxValue, null, null);
					dtf.b["component_fragGrenadeCase"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\containers\\fragGrenadeCase")), false, false), 3, int.MaxValue, null, null);
					dtf.b["component_thinGrenadeCase"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\containers\\thinGrenadeCase")), false, false), 3, int.MaxValue, null, null);
					dtf.b["component_chemicalTrapCase"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\containers\\chemicalTrapCase")), false, false), 6, int.MaxValue, null, null);
					dtf.b["component_digitalTimer"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\devices\\digitalTimer")), false, false), 6, int.MaxValue, null, null);
					dtf.b["component_ampule"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\medical\\ampule")), false, false), 1, int.MaxValue, null, null);
					dtf.b["component_flatBeaker"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\medical\\flatBeaker")), false, false), 3, int.MaxValue, null, null);
					dtf.b["component_capsule"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\medical\\capsule")), false, false), 1, int.MaxValue, null, null);
					dtf.b["component_vial"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\medical\\vial")), false, false), 3, int.MaxValue, null, null);
					if (dm9.f)
					{
						dtf.b["component_spongeFilter"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\medical\\SpongeFilter")), false, false), 3, int.MaxValue, null, null);
					}
					dtf.b["component_mindshroom"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\plants\\mindshroom")), false, false), 7, int.MaxValue, null, null);
					dtf.b["component_lakePoppy"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\plants\\lakePoppy")), false, false), 9, int.MaxValue, null, null);
					dtf.b["component_redDreamMushroom"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\plants\\redDreamMushroom")), false, false), 15, int.MaxValue, null, null);
					dtf.b["component_caveEar"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\plants\\caveEar")), false, false), 6, int.MaxValue, null, null);
					dtf.b["component_syringe"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\medical\\syringe")), false, false), 1, int.MaxValue, null, null);
					dtf.b["component_midazolam"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\chemicals\\midazolam")), false, false), 4, int.MaxValue, null, null);
					dtf.b["component_psionicCatalyst"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\chemicals\\psionicCatalyst")), false, false), 1, int.MaxValue, null, null);
					dtf.b["component_burrowerPoison"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\chemicals\\burrowerPoison")), false, false), 3, int.MaxValue, null, null);
					dtf.b["component_caveEarPoison"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\chemicals\\caveEarPoison")), false, false), 5, int.MaxValue, null, null);
					dtf.b["component_crawlerPoison"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\chemicals\\crawlerPoison")), false, false), 8, int.MaxValue, null, null);
					dtf.b["component_acid"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\chemicals\\acid")), false, false), 6, int.MaxValue, null, null);
					dtf.b["component_blood"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\chemicals\\blood")), false, false), 4, int.MaxValue, null, null);
					dtf.b["component_adrenaline"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\chemicals\\adrenaline")), false, false), 7, int.MaxValue, null, null);
					dtf.b["component_morphine"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\chemicals\\morphine")), false, false), 9, int.MaxValue, null, null);
					dtf.b["component_insectoidSaliva"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\chemicals\\insectoidSaliva")), false, false), 4, int.MaxValue, null, null);
					dtf.b["component_bondingAgent"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\chemicals\\bondingAgent")), false, false), 5, int.MaxValue, null, null);
					if (dm9.f)
					{
						dtf.b["component_smallOxygenTank"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\chemicals\\smallOxygenTank")), false, false), 3, int.MaxValue, null, null);
					}
					dtf.b["component_anticoagulant"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\chemicals\\anticoagulant")), false, false), 2, int.MaxValue, null, null);
					dtf.b["component_taurine"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\chemicals\\taurine")), false, false), 6, int.MaxValue, null, null);
					dtf.b["component_organicGelElectrolyte"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\chemicals\\OrganicGelElectrolyte")), false, false), 5, int.MaxValue, null, null);
					dtf.b["component_hexogen"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\Explosives\\Hexogen")), false, false), 6, int.MaxValue, null, null);
					dtf.b["component_rawTnt"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\Explosives\\RawTNT")), false, false), 3, int.MaxValue, null, null);
					dtf.b["component_fragMineCase"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\containers\\fragMineCase")), false, false), 2, int.MaxValue, null, null);
					dtf.b["component_thinMineCase"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\containers\\thinMineCase")), false, false), 2, int.MaxValue, null, null);
					dtf.b["component_empMineCase"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\containers\\empMineCase")), false, false), 4, int.MaxValue, null, null);
					if (dk2.f())
					{
						dtf.b["xpbl_component_plasmaMineCase"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\containers\\xpbl\\plasmaMineCase")), false, false), 12, int.MaxValue, null, null);
					}
					dtf.b["component_plasmaCore"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\energyCores\\plasmaCore")), false, true), 5, int.MaxValue, null, null);
					dtf.b["component_electroshockGenerator"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\ElectroshockGenerator")), false, true), 3, int.MaxValue, null, null);
					dtf.b["component_pneumaticHammer"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\pneumaticHammer")), false, true), 5, int.MaxValue, null, null);
					dtf.b["component_microElectroshockDischarger"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\MicroElectroshockDischarger")), false, false), 2, int.MaxValue, null, null);
					dtf.b["component_boltTrigger"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\boltTrigger")), false, false), 2, int.MaxValue, null, null);
					dtf.b["component_laserEmitter"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\LaserEmitter")), false, true), 4, int.MaxValue, null, null);
					dtf.b["component_plasmaDischarger"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\PlasmaDischarger")), false, true), 7, int.MaxValue, null, null);
					dtf.b["component_smartModule"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\SmartModule")), false, true), 6, int.MaxValue, null, null);
					dtf.b["component_empDischarger"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\emitters\\ElectromagneticDischarger")), false, false), 4, int.MaxValue, null, null);
					dtf.b["component_energyPistolFrame"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\energyPistolFrame")), false, false), 3, int.MaxValue, null, null);
					dtf.b["component_emDeflector"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\devices\\EmDeflector")), false, true), 4, int.MaxValue, null, null);
					dtf.b["component_emFieldStabilizer"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\devices\\EmFieldStabilizer")), false, true), 4, int.MaxValue, null, null);
					if (dk2.f())
					{
						dtf.b["xpbl_component_plasmaMicroDischarger"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\emitters\\xpbl\\PlasmaMicroDischarger")), false, false), 15, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_opticalFiber"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\devices\\xpbl\\OpticalFiber")), false, false), 5, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_endoscopeEyepiece"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\devices\\xpbl\\EndoscopeEyepiece")), false, false), 8, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_broadheadBoltTip"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\Weapons\\xpbl\\BroadheadBoltTip")), false, false), 10, int.MaxValue, null, null);
						dtf.b["xpbl_component_energyEdgeEmitter"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xpbl\\energyEdgeEmitter")), false, true), 10, int.MaxValue, null, null);
						dtf.b["xpbl_component_polarizer"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xpbl\\polarizer")), false, true), 10, int.MaxValue, null, null);
					}
					dtf.b["component_psionicHeadbandFrame"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\PsionicHeadbandFrame")), false, false), 5, int.MaxValue, null, null);
					dtf.b["component_psionicModulator_metathermic"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\PsionicModulator_Metathermic")), false, true), 5, int.MaxValue, null, null);
					dtf.b["component_psionicModulator_psychokinetic"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\psionicModulator_psychokinetic")), false, true), 5, int.MaxValue, null, null);
					dtf.b["component_psionicModulator_thoughtControl"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\psionicModulator_thoughtControl")), false, true), 5, int.MaxValue, null, null);
					dtf.b["component_psionicModulator_universal"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\psionicModulator_universal")), false, true), 5, int.MaxValue, null, null);
					if (dk2.f())
					{
						dtf.b["xpbl_component_psionicModulator_temporalManipulation"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\xpbl\\psionicModulator_temporalManipulation")), false, true), 5, int.MaxValue, "xpbl", null);
					}
					dtf.b["component_psionicMufflers"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\psionicMufflers")), false, true), 8, int.MaxValue, null, null);
					dtf.b["component_psiCircuitExtension"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\psiCircuitExtension")), false, false), 12, int.MaxValue, null, null);
					dtf.b["component_stableNeuralAmplifier"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\StableNeuralAmplifier")), false, true), 7, int.MaxValue, null, null);
					dtf.b["component_proximalNeuroscopicFilter"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\proximalNeuroscopicFilter")), false, true), 6, int.MaxValue, null, null);
					if (dk2.f())
					{
						dtf.b["xpbl_component_magnifyingNeuroscopicFilter_cryokinesis"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\Xpbl\\MagnifyingNeuroscopicFilter_Cryokinesis")), false, true), 10, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_magnifyingNeuroscopicFilter_cryokineticOrb"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\Xpbl\\MagnifyingNeuroscopicFilter_CryokineticOrb")), false, true), 17, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_magnifyingNeuroscopicFilter_electrokinesis"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\Xpbl\\MagnifyingNeuroscopicFilter_Electrokinesis")), false, true), 10, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_magnifyingNeuroscopicFilter_neuralOverload"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\Xpbl\\MagnifyingNeuroscopicFilter_NeuralOverload")), false, true), 10, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_magnifyingNeuroscopicFilter_pyrokinesis"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\Xpbl\\MagnifyingNeuroscopicFilter_Pyrokinesis")), false, true), 10, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_magnifyingNeuroscopicFilter_pyrokineticStream"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\Xpbl\\MagnifyingNeuroscopicFilter_PyrokineticStream")), false, true), 10, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_magnifyingNeuroscopicFilter_telekineticPunch"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\Xpbl\\MagnifyingNeuroscopicFilter_TelekineticPunch")), false, true), 10, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_magnifyingNeuroscopicFilter_temporalDistorsion"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\Xpbl\\MagnifyingNeuroscopicFilter_TemporalDistorsion")), false, true), 10, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_magnifyingNeuroscopicFilter_plasmaBeam"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\Xpbl\\MagnifyingNeuroscopicFilter_PlasmaBeam")), false, true), 15, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_magnifyingNeuroscopicFilter_cryogenicBarrier"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\Xpbl\\MagnifyingNeuroscopicFilter_CryogenicBarrier")), false, true), 10, int.MaxValue, "xpbl", null);
					}
					dtf.b["component_shieldEmitterBase"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\devices\\ShieldEmitterBase")), false, false), 6, int.MaxValue, null, null);
					dtf.b["component_lowFrequencyShieldModulator"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\devices\\LowFrequencyShieldModulator")), false, true), 7, int.MaxValue, null, null);
					dtf.b["component_mediumFrequencyShieldModulator"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\devices\\MediumFrequencyShieldModulator")), false, true), 7, int.MaxValue, null, null);
					dtf.b["component_highFrequencyShieldModulator"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\devices\\HighFrequencyShieldModulator")), false, true), 7, int.MaxValue, null, null);
					dtf.b["component_circularWaveAmplifier"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\devices\\CircularWaveAmplifier")), false, true), 9, int.MaxValue, null, null);
					dtf.b["component_shieldCapacitor"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\devices\\ShieldCapacitor")), false, true), 9, int.MaxValue, null, null);
					dtf.b["component_highEfficiencyEnergyConverter"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\devices\\HighEfficiencyEnergyConverter")), false, true), 9, int.MaxValue, null, null);
					dtf.b["component_chemicalPistolFrame"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\chemicalPistolFrame")), false, false), 7, int.MaxValue, null, null);
					dtf.b["component_AcidCollector"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\AcidCollector")), false, true), 7, int.MaxValue, null, null);
					dtf.b["component_CryogenicCollector"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\CryogenicCollector")), false, true), 10, int.MaxValue, null, null);
					dtf.b["component_IncendiaryCollector"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\IncendiaryCollector")), false, true), 10, int.MaxValue, null, null);
					dtf.b["component_BlobDispenser"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\BlobDispenser")), false, true), 7, int.MaxValue, null, null);
					dtf.b["component_gasoline"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\chemicals\\gasoline")), false, false), 1, int.MaxValue, null, null);
					dtf.b["component_coal"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\chemicals\\coal")), false, false), 1, int.MaxValue, null, null);
					dtf.b["component_magnesiumPowder"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\chemicals\\magnesiumPowder")), false, false), 7, int.MaxValue, null, null);
					dtf.b["component_graphite"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\chemicals\\Graphite")), false, false), 5, int.MaxValue, null, null);
					dtf.b["component_NapalmC"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\chemicals\\NapalmC")), false, false), 13, int.MaxValue, null, null);
					dtf.b["component_starterMixture"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\chemicals\\StarterMixture")), false, false), 2, int.MaxValue, null, null);
					dtf.b["component_toxicSludge"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\chemicals\\ToxicSludge")), false, false), 4, int.MaxValue, null, null);
					if (dk2.e())
					{
						dtf.b["component_rocketPropellant"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\chemicals\\rocketPropellant")), false, false), 10, int.MaxValue, "xphw", null);
						dtf.b["component_whitePhosphorus"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\chemicals\\whitePhosphorus")), false, false), 12, int.MaxValue, "xphw", null);
					}
					dtf.b["component_crossbowParts1"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\crossbowParts1")), false, true), 1, int.MaxValue, null, null);
					dtf.b["component_crossbowParts2"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\crossbowParts2")), false, true), 4, int.MaxValue, null, null);
					dtf.b["component_crossbowParts3"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\crossbowParts3")), false, true), 6, int.MaxValue, null, null);
					dtf.b["component_crossbowParts4"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\crossbowParts4")), false, true), 10, int.MaxValue, null, null);
					dtf.b["component_crossbowParts5"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\crossbowParts5")), false, true), 14, int.MaxValue, null, null);
					dtf.b["component_pistolFrame1"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\pistolFrame1")), false, true), 1, int.MaxValue, null, null);
					dtf.b["component_pistolFrame2"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\pistolFrame2")), false, true), 4, int.MaxValue, null, null);
					dtf.b["component_pistolFrame3"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\pistolFrame3")), false, true), 8, int.MaxValue, null, null);
					dtf.b["component_pistolFrame4"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\pistolFrame4")), false, true), 12, int.MaxValue, null, null);
					dtf.b["component_sniperFrame1"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\sniperFrame1")), false, true), 3, int.MaxValue, null, null);
					dtf.b["component_sniperFrame2"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\sniperFrame2")), false, true), 7, int.MaxValue, null, null);
					dtf.b["component_sniperFrame3"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\sniperFrame3")), false, true), 11, int.MaxValue, null, null);
					dtf.b["component_sniperFrame4"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\sniperFrame4")), false, true), 16, int.MaxValue, null, null);
					dtf.b["component_assaultRifleFrame1"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\assaultRifleFrame1")), false, true), 3, int.MaxValue, null, null);
					dtf.b["component_assaultRifleFrame2"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\assaultRifleFrame2")), false, true), 7, int.MaxValue, null, null);
					dtf.b["component_assaultRifleFrame3"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\assaultRifleFrame3")), false, true), 11, int.MaxValue, null, null);
					dtf.b["component_assaultRifleFrame4"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\assaultRifleFrame4")), false, true), 16, int.MaxValue, null, null);
					dtf.b["component_smgFrame1"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\smgFrame1")), false, true), 3, int.MaxValue, null, null);
					dtf.b["component_smgFrame2"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\smgFrame2")), false, true), 6, int.MaxValue, null, null);
					dtf.b["component_smgFrame3"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\smgFrame3")), false, true), 9, int.MaxValue, null, null);
					dtf.b["component_smgFrame4"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\smgFrame4")), false, true), 12, int.MaxValue, null, null);
					dtf.b["component_barrel5"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\barrel5")), false, false), 1, int.MaxValue, null, null);
					dtf.b["component_barrel762"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\barrel762")), false, false), 1, int.MaxValue, null, null);
					dtf.b["component_barrel86"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\barrel86")), false, false), 2, int.MaxValue, null, null);
					dtf.b["component_barrel9"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\barrel9")), false, false), 2, int.MaxValue, null, null);
					dtf.b["component_barrel44"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\barrel44")), false, false), 3, int.MaxValue, null, null);
					dtf.b["component_barrel127"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\barrel127")), false, false), 3, int.MaxValue, null, null);
					if (dk2.f())
					{
						dtf.b["xpbl_component_shotgunFrame1"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xpbl\\shotgunFrame1")), false, true), 3, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_shotgunFrame2"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xpbl\\shotgunFrame2")), false, true), 7, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_shotgunFrame3"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xpbl\\shotgunFrame3")), false, true), 11, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_combatShotgunFrame1"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xpbl\\combatShotgunFrame1")), false, true), 5, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_combatShotgunFrame2"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xpbl\\combatShotgunFrame2")), false, true), 10, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_combatShotgunFrame3"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xpbl\\combatShotgunFrame3")), false, true), 15, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_shotgunChoke"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xpbl\\ShotgunChoke")), false, false), 3, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_shotgunTubeExtension"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xpbl\\ShotgunTubeExtension")), false, false), 5, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_longShotgunBarrel"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xpbl\\LongShotgunBarrel")), false, false), 1, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_shortShotgunBarrel"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xpbl\\ShortShotgunBarrel")), false, false), 1, int.MaxValue, "xpbl", null);
					}
					dtf.b["component_knifeHandle"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\KnifeHandle")), false, false), 1, int.MaxValue, null, null);
					dtf.b["component_knifeMold"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\KnifeMold")), false, false), 1, int.MaxValue, null, null);
					dtf.b["component_serratedKnifeMold"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\SerratedKnifeMold")), false, false), 1, int.MaxValue, null, null);
					dtf.b["component_daggerMold"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\DaggerMold")), false, false), 1, int.MaxValue, null, null);
					dtf.b["component_sledgehammerHandle"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\SledgehammerHandle")), false, false), 3, int.MaxValue, null, null);
					dtf.b["component_scope"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\scope")), false, false), 4, int.MaxValue, null, null);
					dtf.b["component_anatomicallyAwareScope"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\AnatomicallyAwareScope")), false, false), 8, int.MaxValue, null, null);
					dtf.b["component_highResolutionDigitalScope"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\HighResolutionDigitalScope")), false, false), 10, int.MaxValue, null, null);
					dtf.b["component_laserSight"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\laserSight")), false, false), 4, int.MaxValue, null, null);
					dtf.b["component_reflexSight"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\reflexSight")), false, false), 4, int.MaxValue, null, null);
					dtf.b["component_crossbowSuperString"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\crossbowSuperString")), false, false), 6, int.MaxValue, null, null);
					dtf.b["component_pneumaticReloader"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\pneumaticReloader")), false, false), 6, int.MaxValue, null, null);
					dtf.b["component_extendedPistolMagazine"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\extendedPistolMagazine")), false, false), 5, int.MaxValue, null, null);
					dtf.b["component_extendedRifleMagazine"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\extendedRifleMagazine")), false, false), 6, int.MaxValue, null, null);
					dtf.b["component_bipod"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\bipod")), false, false), 4, int.MaxValue, null, null);
					dtf.b["component_rifleBarrelRetractor"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\rifleBarrelRetractor")), false, false), 7, int.MaxValue, null, null);
					dtf.b["component_verticalForegrip"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\verticalForegrip")), false, false), 5, int.MaxValue, null, null);
					dtf.b["component_muzzleBrake"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\MuzzleBrake")), false, false), 8, int.MaxValue, null, null);
					dtf.b["component_barrelCompensator"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\BarrelCompensator")), false, false), 4, int.MaxValue, null, null);
					dtf.b["component_silencer"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\Silencer")), false, false), 2, int.MaxValue, null, null);
					dtf.b["component_rapidReloader"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\RapidReloader")), false, false), 12, int.MaxValue, null, null);
					if (dk2.f())
					{
						dtf.b["xpbl_component_spearShaft"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xpbl\\spearShaft")), false, false), 5, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_macheteHandle"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xpbl\\macheteHandle")), false, false), 3, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_straightMacheteBladeMold"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xpbl\\StraightMacheteBladeMold")), false, false), 3, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_curvedMacheteBladeMold"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xpbl\\CurvedMacheteBladeMold")), false, false), 3, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_smallShotgunPelletMold"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\containers\\xpbl\\SmallShotgunPelletMold")), false, false), 3, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_mediumShotgunPelletMold"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\containers\\xpbl\\MediumShotgunPelletMold")), false, false), 3, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_largeShotgunPelletMold"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\containers\\xpbl\\LargeShotgunPelletMold")), false, false), 3, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_hugeShotgunPelletMold"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\containers\\xpbl\\HugeShotgunPelletMold")), false, false), 10, int.MaxValue, "xpbl", null);
					}
					if (dk2.e())
					{
						dtf.b["xphw_component_grenadeLauncherFrame1"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\grenadeLauncherFrame1")), false, true), 3, int.MaxValue, "xphw", null);
						dtf.b["xphw_component_grenadeLauncherFrame2"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\grenadeLauncherFrame2")), false, true), 6, int.MaxValue, "xphw", null);
						dtf.b["xphw_component_grenadeLauncherFrame3"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\grenadeLauncherFrame3")), false, true), 4, int.MaxValue, "xphw", null);
						dtf.b["xphw_component_grenadeLauncherFrame4"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\grenadeLauncherFrame4")), false, true), 8, int.MaxValue, "xphw", null);
						dtf.b["xphw_grenadeLauncherBarrel25"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\grenadeLauncherBarrel25")), false, false), 3, int.MaxValue, "xphw", null);
						dtf.b["xphw_grenadeLauncherBarrel25L"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\grenadeLauncherBarrel25L")), false, false), 8, int.MaxValue, "xphw", null);
						dtf.b["xphw_grenadeLauncherBarrel40"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\grenadeLauncherBarrel40")), false, false), 4, int.MaxValue, "xphw", null);
						dtf.b["xphw_grenadeLauncherBarrel40L"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\grenadeLauncherBarrel40L")), false, false), 10, int.MaxValue, "xphw", null);
						dtf.b["xphw_grenadeLauncherBoxMagazine6"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\grenadeLauncherBoxMagazine6")), false, false), 1, int.MaxValue, "xphw", null);
						dtf.b["xphw_grenadeLauncherBoxMagazine8"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\grenadeLauncherBoxMagazine8")), false, false), 4, int.MaxValue, "xphw", null);
						dtf.b["xphw_grenadeLauncherBoxMagazine10"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\grenadeLauncherBoxMagazine10")), false, false), 9, int.MaxValue, "xphw", null);
						dtf.b["xphw_grenadeLauncherBoxMagazine12"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\grenadeLauncherBoxMagazine12")), false, false), 15, int.MaxValue, "xphw", null);
						dtf.b["xphw_grenadeLauncherRevolverCylinder4"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\grenadeLauncherRevolverCylinder4")), false, false), 1, int.MaxValue, "xphw", null);
						dtf.b["xphw_grenadeLauncherRevolverCylinder6"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\grenadeLauncherRevolverCylinder6")), false, false), 5, int.MaxValue, "xphw", null);
						dtf.b["xphw_grenadeLauncherRevolverCylinder8"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\grenadeLauncherRevolverCylinder8")), false, false), 10, int.MaxValue, "xphw", null);
						dtf.b["xphw_grenadeLauncherIronsights"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\grenadeLauncherIronsights")), false, false), 5, int.MaxValue, "xphw", null);
						dtf.b["xphw_grenadeLauncherScope"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\grenadeLauncherScope")), false, false), 10, int.MaxValue, "xphw", null);
						dtf.b["xphw_airburstScope"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\airburstScope")), false, false), 12, int.MaxValue, "xphw", null);
						dtf.b["xphw_component_rocketLauncherFrame1"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\rocketLauncherFrame1")), false, true), 12, 20, "xphw", null);
						dtf.b["xphw_component_rocketLauncherFrame2"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\rocketLauncherFrame2")), false, true), 15, 25, "xphw", null);
						dtf.b["xphw_component_rocketLauncherFrame3"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\rocketLauncherFrame3")), false, true), 15, 25, "xphw", null);
						dtf.b["xphw_component_rocketLauncherFrame4"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\rocketLauncherFrame4")), false, true), 18, int.MaxValue, "xphw", null);
						dtf.b["xphw_component_rocketLauncherFrame5"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\rocketLauncherFrame5")), false, true), 18, int.MaxValue, "xphw", null);
						dtf.b["xphw_rocketLauncherFiringMechanism1"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\rocketLauncherFiringMechanism1")), false, false), 12, int.MaxValue, "xphw", null);
						dtf.b["xphw_rocketLauncherFiringMechanism2"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\rocketLauncherFiringMechanism2")), false, false), 12, int.MaxValue, "xphw", null);
						dtf.b["xphw_rocketLauncherFiringMechanism3"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\rocketLauncherFiringMechanism3")), false, false), 12, int.MaxValue, "xphw", null);
						dtf.b["xphw_rocketLauncherEmrac"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\rocketLauncherEmrac")), false, false), 12, int.MaxValue, "xphw", null);
						dtf.b["xphw_component_lightMachineGunFrame1"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\lmgFrame1")), false, true), 1, int.MaxValue, "xphw", null);
						dtf.b["xphw_component_lightMachineGunFrame2"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\lmgFrame2")), false, true), 6, int.MaxValue, "xphw", null);
						dtf.b["xphw_component_lightMachineGunFrame3"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\lmgFrame3")), false, true), 3, int.MaxValue, "xphw", null);
						dtf.b["xphw_component_lightMachineGunFrame4"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\lmgFrame4")), false, true), 9, int.MaxValue, "xphw", null);
						dtf.b["xphw_component_minigunFrame1"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\MinigunFrame1")), false, true), 13, 22, "xphw", null);
						dtf.b["xphw_component_minigunFrame2"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\MinigunFrame2")), false, true), 20, int.MaxValue, "xphw", null);
						dtf.b["xphw_component_minigunFrame3"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\MinigunFrame3")), false, true), 13, 22, "xphw", null);
						dtf.b["xphw_component_minigunFrame4"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\MinigunFrame4")), false, true), 20, int.MaxValue, "xphw", null);
						dtf.b["xphw_component_ergonomicHandle"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\ergonomicHandle")), false, false), 6, int.MaxValue, "xphw", null);
						dtf.b["xphw_component_lmgBeltMagazine50"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\lmgBeltMagazine50")), false, false), 1, int.MaxValue, "xphw", null);
						dtf.b["xphw_component_lmgBeltMagazine65"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\lmgBeltMagazine65")), false, false), 6, int.MaxValue, "xphw", null);
						dtf.b["xphw_component_lmgBeltMagazine80"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\lmgBeltMagazine80")), false, false), 12, int.MaxValue, "xphw", null);
						dtf.b["xphw_component_lmgBeltMagazine100"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\lmgBeltMagazine100")), false, false), 20, int.MaxValue, "xphw", null);
						dtf.b["xphw_component_lmgBoxMagazine45"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\lmgBoxMagazine45")), false, false), 1, int.MaxValue, "xphw", null);
						dtf.b["xphw_component_lmgBoxMagazine55"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\lmgBoxMagazine55")), false, false), 6, int.MaxValue, "xphw", null);
						dtf.b["xphw_component_lmgBoxMagazine65"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\lmgBoxMagazine65")), false, false), 12, int.MaxValue, "xphw", null);
						dtf.b["xphw_component_lmgBoxMagazine80"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\lmgBoxMagazine80")), false, false), 20, int.MaxValue, "xphw", null);
						dtf.b["xphw_component_minigunMotorJumpstarter1"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\minigunMotorJumpstarter1")), false, false), 13, int.MaxValue, "xphw", null);
						dtf.b["xphw_component_minigunMotorJumpstarter2"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\minigunMotorJumpstarter2")), false, false), 18, int.MaxValue, "xphw", null);
						dtf.b["xphw_component_minigunMotorSlowStarter1"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\minigunMotorSlowStarter1")), false, false), 13, int.MaxValue, "xphw", null);
						dtf.b["xphw_component_minigunMotorSlowStarter2"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\minigunMotorSlowStarter2")), false, false), 18, int.MaxValue, "xphw", null);
						dtf.b["xphw_component_minigunMotorLongGame1"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\minigunMotorLongGame1")), false, false), 13, int.MaxValue, "xphw", null);
						dtf.b["xphw_component_minigunMotorLongGame2"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\xphw\\minigunMotorLongGame2")), false, false), 18, int.MaxValue, "xphw", null);
					}
					dtf.b["component_fabric_blackCloth"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\fabric\\blackCloth")), false, true), 1, int.MaxValue, null, null);
					dtf.b["component_fabric_aluminizedCloth"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\fabric\\AluminizedCloth")), false, true), 2, int.MaxValue, null, null);
					dtf.b["component_fabric_kevlarCloth"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\fabric\\KevlarCloth")), false, true), 6, int.MaxValue, null, null);
					dtf.b["component_fabric_blastCloth"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\fabric\\BlastCloth")), false, true), 10, int.MaxValue, null, null);
					dtf.b["component_padding_highDensityFoamPadding"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\padding\\HighDensityFoamPadding")), false, true), 5, int.MaxValue, null, null);
					dtf.b["component_padding_softFoamPadding"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\padding\\SoftFoamPadding")), false, true), 0, int.MaxValue, null, null);
					dtf.b["component_padding_galvanicFoamPadding"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\padding\\GalvanicFoamPadding")), false, true), 8, int.MaxValue, null, null);
					dtf.b["component_padding_insulatingFoamPadding"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\padding\\InsulatingFoamPadding")), false, true), 10, int.MaxValue, null, null);
					dtf.b["component_visor"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\visor")), false, false), 3, int.MaxValue, null, null);
					dtf.b["component_shadedVisor"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\shadedVisor")), false, false), 6, int.MaxValue, null, null);
					dtf.b["component_rubberSole"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\RubberSole")), false, false), 1, int.MaxValue, null, null);
					dtf.b["component_gogglesFrame"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\gogglesFrame")), false, false), 3, int.MaxValue, null, null);
					dtf.b["component_imageIntensifierTube"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\ImageIntensifierTube")), false, false), 5, int.MaxValue, null, null);
					dtf.b["component_headlight"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\headlight")), false, true), 3, int.MaxValue, null, null);
					dtf.b["component_adaptiveLens"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\adaptiveLens")), false, false), 3, int.MaxValue, null, null);
					dtf.b["component_seekerLens"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\seekerLens")), false, true), 3, int.MaxValue, null, null);
					dtf.b["component_smartLens"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\smartLens")), false, true), 5, int.MaxValue, null, null);
					dtf.b["component_motionTrackingLens"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\motionTrackingLens")), false, true), 4, int.MaxValue, null, null);
					dtf.b["component_ballisticPanel_reinforcedFabric"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\BallisticPanels\\ReinforcedFabric")), false, true), 0, int.MaxValue, null, null);
					dtf.b["component_ballisticPanel_laminatedFabric"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\BallisticPanels\\LaminatedFabric")), false, true), 0, int.MaxValue, null, null);
					dtf.b["component_vest_insulated"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\vest\\InsulatedVest")), false, true), 0, 18, null, null);
					dtf.b["component_vest_galvanic"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\vest\\GalvanicVest")), false, true), 4, int.MaxValue, null, null);
					dtf.b["component_vest_biohazard"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\vest\\BiohazardVest")), false, true), 8, int.MaxValue, null, null);
					dtf.b["component_vest_sturdy"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\vest\\SturdyVest")), false, true), 10, int.MaxValue, null, null);
					dtf.b["component_vest_regenerative"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\vest\\RegenerativeVest")), false, true), 10, int.MaxValue, null, null);
					dtf.b["component_ballisticArmorPlate_ceramicPlate"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\BallisticArmorPlates\\CeramicPlate")), false, true), 6, int.MaxValue, null, null);
					dtf.b["component_ballisticArmorPlate_nanocompositePlate"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\BallisticArmorPlates\\NanocompositePlate")), false, true), 12, int.MaxValue, null, null);
					dtf.b["component_metalPlate_steel"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\MetalPlates\\Steel")), false, true), 3, int.MaxValue, null, null);
					dtf.b["component_metalPlate_tungstenSteel"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\MetalPlates\\TungstenSteel")), false, true), 8, int.MaxValue, null, null);
					dtf.b["component_metalPlate_tichrome"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\MetalPlates\\TiChrome")), false, true), 15, int.MaxValue, null, null);
					dtf.b["component_metalArmorEnh_spikes_steel"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\MetalArmorEnhancements\\steelSpikes")), false, true), 5, int.MaxValue, null, null);
					dtf.b["component_metalArmorEnh_spikes_tungstenSteel"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\MetalArmorEnhancements\\TungstenSteelSpikes")), false, true), 8, int.MaxValue, null, null);
					dtf.b["component_metalArmorEnh_spikes_tichrome"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\MetalArmorEnhancements\\TiChromeSpikes")), false, true), 15, int.MaxValue, null, null);
					dtf.b["component_metalArmorEnh_serratedBlade_steel"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\MetalArmorEnhancements\\serratedSteelBlade")), false, true), 5, int.MaxValue, null, null);
					dtf.b["component_metalArmorEnh_serratedBlade_tungstenSteel"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\MetalArmorEnhancements\\serratedTungstenSteelBlade")), false, true), 8, int.MaxValue, null, null);
					dtf.b["component_metalArmorEnh_serratedBlade_tichrome"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\MetalArmorEnhancements\\serratedTiChromeBlade")), false, true), 15, int.MaxValue, null, null);
					dtf.b["component_bootSpring"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\bootSpring")), false, true), 4, int.MaxValue, null, null);
					dtf.b["component_bulletCase_5"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\ammoCase\\Caliber_5")), false, false), 1, int.MaxValue, null, null);
					dtf.b["component_bulletCase_762"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\ammoCase\\Caliber_762")), false, false), 1, int.MaxValue, null, null);
					dtf.b["component_bulletCase_86"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\ammoCase\\Caliber_86")), false, false), 1, int.MaxValue, null, null);
					dtf.b["component_bulletCase_9"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\ammoCase\\Caliber_9")), false, false), 1, int.MaxValue, null, null);
					dtf.b["component_bulletCase_44"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\ammoCase\\Caliber_44")), false, false), 1, int.MaxValue, null, null);
					dtf.b["component_bulletCase_127"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\ammoCase\\Caliber_127")), false, false), 1, int.MaxValue, null, null);
					dtf.b["component_bio_animalHeart"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\Bio\\AnimalHeart")), false, false), 1, int.MaxValue, null, null);
					dtf.b["component_bio_insectoidSalivarium"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\Bio\\AnimalHeart")), false, false), 1, int.MaxValue, null, null);
					dtf.b["component_bio_largeIntestine"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\Bio\\LargeIntestine")), false, false), 1, int.MaxValue, null, null);
					dtf.b["component_bio_siphonerTongue"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\Bio\\SiphonerTongue")), false, false), 7, int.MaxValue, null, null);
					if (dk2.f())
					{
						dtf.b["xpbl_component_emptyShotgunShell"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\ammoCase\\xpbl\\ShotgunShell")), false, false), 1, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_bio_colossalCrabCarapace"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\Bio\\Xpbl\\ColossalCrabCarapace")), false, true), 12, 19, "xpbl", null);
						dtf.b["xpbl_component_bio_giantCrabCarapace"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\Bio\\Xpbl\\GiantCrabCarapace")), false, true), 8, 16, "xpbl", null);
						dtf.b["xpbl_component_bio_psiCrabCarapace"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\Bio\\Xpbl\\PsiCrabCarapace")), false, true), 16, 24, "xpbl", null);
						dtf.b["xpbl_component_bio_giantCreeperGland"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\Bio\\Xpbl\\GiantCreeperGland")), false, false), 1, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_bio_heartbreakerSerpentPoisonGland"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\Bio\\Xpbl\\HeartbreakerSerpentPoisonGland")), false, false), 1, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_bio_leperSerpentPoisonGland"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\Bio\\Xpbl\\LeperSerpentPoisonGland")), false, false), 1, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_bio_mutantCrustaceanEgg"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\Bio\\Xpbl\\MutantCrustaceanEgg")), false, false), 1, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_bio_psiCrabHippocampus"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\Bio\\Xpbl\\PsiCrabHippocampus")), false, false), 1, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_bio_rustingAcidGland"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\Bio\\Xpbl\\RustingAcidGland")), false, false), 1, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_leather_bisonLeather"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\Leather\\Xpbl\\BisonLeather")), false, true), 1, 22, "xpbl", null);
						dtf.b["xpbl_component_leather_greaterSiphonerLeather"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\Leather\\Xpbl\\GreaterSiphonerLeather")), false, true), 10, 18, "xpbl", null);
						dtf.b["xpbl_component_leather_heartbreakerSerpentSkin"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\Leather\\Xpbl\\HeartbreakerSerpentSkin")), false, true), 8, 19, "xpbl", null);
						dtf.b["xpbl_component_leather_leperSerpentSkin"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\Leather\\Xpbl\\LeperSerpentSkin")), false, true), 8, 17, "xpbl", null);
						dtf.b["xpbl_component_leather_seaWyrmScales"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\Leather\\Xpbl\\SeaWyrmScales")), false, true), 8, 24, "xpbl", null);
						dtf.b["xpbl_component_plant_greenWart"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\plants\\xpbl\\greenWart")), false, false), 0, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_plant_glittershroomSpores"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\plants\\xpbl\\glittershroomSpores")), false, false), 0, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_plant_honeySpores"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\plants\\xpbl\\honeySpores")), false, false), 0, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_plant_lingula"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\plants\\xpbl\\lingula")), false, false), 0, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_stabilizationWings"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\weapons\\stabilizationWings")), false, true), 6, int.MaxValue, "xpbl", null);
					}
					dtf.b["component_fish_anglerfish"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\animals\\anglerfish")), false, false), 15, int.MaxValue, null, null);
					dtf.b["component_fish_blackDragon"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\animals\\blackDragon")), false, false), 8, int.MaxValue, null, null);
					dtf.b["component_fish_blueEel"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\animals\\blueEel")), false, false), 1, int.MaxValue, null, null);
					dtf.b["component_fish_demonSquid"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\animals\\demonSquid")), false, false), 10, int.MaxValue, null, null);
					dtf.b["component_fish_ghostface"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\animals\\ghostface")), false, false), 1, int.MaxValue, null, null);
					dtf.b["component_fish_minihead"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\animals\\minihead")), false, false), 1, int.MaxValue, null, null);
					dtf.b["component_fish_pentapus"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\animals\\pentapus")), false, false), 5, int.MaxValue, null, null);
					dtf.b["component_fish_phantomJelly"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\animals\\phantomJelly")), false, false), 1, int.MaxValue, null, null);
					dtf.b["component_fish_shrimp"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\animals\\shrimp")), false, false), 10, int.MaxValue, null, null);
					dtf.b["component_fish_slackjaw"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\animals\\slackjaw")), false, false), 1, int.MaxValue, null, null);
					dtf.b["component_fish_walkingFish"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\animals\\walkingFish")), false, false), 8, int.MaxValue, null, null);
					dtf.b["component_fish_yellowPuckerfish"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\animals\\yellowPuckerfish")), false, false), 1, int.MaxValue, null, null);
					if (dk2.f())
					{
						dtf.b["xpbl_component_fish_frogfish"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\animals\\xpbl\\frogfish")), false, false), 1, int.MaxValue, null, null);
						dtf.b["xpbl_component_fish_giantHatchetfish"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\animals\\xpbl\\giantHatchetfish")), false, false), 5, int.MaxValue, null, null);
						dtf.b["xpbl_component_fish_redLippedBatfish"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\animals\\xpbl\\redLippedBatfish")), false, false), 10, int.MaxValue, null, null);
					}
					dtf.b["battery_scLi"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<sz>("expendables\\energySources\\ScLiCell")), false, false), 1, int.MaxValue, null, null);
					dtf.b["battery_fusion"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<sz>("expendables\\energySources\\FusionCell")), false, false), 6, int.MaxValue, null, null);
					dtf.b["battery_plasma"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<sz>("expendables\\energySources\\PlasmaCell")), false, false), 11, int.MaxValue, null, null);
					dtf.b["battery_greaterFusion"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<sz>("expendables\\energySources\\GreaterFusionCell")), false, false), 14, int.MaxValue, null, null);
					dtf.b["ammo_bolt"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Bolt")), false, false), 0, int.MaxValue, null, null);
					dtf.b["ammo_serratedBolt"] = new bgf(new a64(new acz(ez2.CreateDefinitonProvider<cdk>("Ammo\\serratedBolt")), false, false), 1, int.MaxValue, null, null);
					dtf.b["ammo_burrowerPoisonBolt"] = new bgf(new a64(new acz(ez2.CreateDefinitonProvider<cdk>("Ammo\\BurrowerPoisonBolt")), false, false), 3, int.MaxValue, null, null);
					dtf.b["ammo_caveEarPoisonBolt"] = new bgf(new a64(new acz(ez2.CreateDefinitonProvider<cdk>("Ammo\\CaveEarPoisonBolt")), false, false), 7, int.MaxValue, null, null);
					dtf.b["ammo_crawlerPoisonBolt"] = new bgf(new a64(new acz(ez2.CreateDefinitonProvider<cdk>("Ammo\\CrawlerPoisonBolt")), false, false), 13, int.MaxValue, null, null);
					dtf.b["ammo_tranquilizingBolt"] = new bgf(new a64(new acz(ez2.CreateDefinitonProvider<cdk>("Ammo\\TranquilizingBolt")), false, false), 4, int.MaxValue, null, null);
					dtf.b["ammo_shockBolt1"] = new bgf(new a64(new acz(ez2.CreateDefinitonProvider<cdk>("Ammo\\ShockBolt1")), false, false), 2, 8, null, null);
					dtf.b["ammo_shockBolt2"] = new bgf(new a64(new acz(ez2.CreateDefinitonProvider<cdk>("Ammo\\ShockBolt2")), false, false), 9, 14, null, null);
					dtf.b["ammo_shockBolt3"] = new bgf(new a64(new acz(ez2.CreateDefinitonProvider<cdk>("Ammo\\ShockBolt3")), false, false), 14, int.MaxValue, null, null);
					dtf.b["ammo_incendiaryBolt1"] = new bgf(new a64(new acz(ez2.CreateDefinitonProvider<cdk>("Ammo\\incendiaryBolt1")), false, false), 2, 8, null, null);
					dtf.b["ammo_incendiaryBolt2"] = new bgf(new a64(new acz(ez2.CreateDefinitonProvider<cdk>("Ammo\\incendiaryBolt2")), false, false), 9, 14, null, null);
					dtf.b["ammo_incendiaryBolt3"] = new bgf(new a64(new acz(ez2.CreateDefinitonProvider<cdk>("Ammo\\incendiaryBolt3")), false, false), 14, int.MaxValue, null, null);
					dtf.b["ammo_acidBolt1"] = new bgf(new a64(new acz(ez2.CreateDefinitonProvider<cdk>("Ammo\\acidBolt1")), false, false), 7, int.MaxValue, null, null);
					dtf.b["ammo_5_Std"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Caliber_5_Std")), false, false), 0, int.MaxValue, null, null);
					dtf.b["ammo_5_JHP"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Caliber_5_JHP")), false, false), 3, int.MaxValue, null, null);
					dtf.b["ammo_5_W2C"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Caliber_5_W2C")), false, false), 3, int.MaxValue, null, null);
					dtf.b["ammo_762_Std"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Caliber_762_Std")), false, false), 0, int.MaxValue, null, null);
					dtf.b["ammo_762_JHP"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Caliber_762_JHP")), false, false), 3, int.MaxValue, null, null);
					dtf.b["ammo_762_W2C"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Caliber_762_W2C")), false, false), 3, int.MaxValue, null, null);
					dtf.b["ammo_86_Std"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Caliber_86_Std")), false, false), 0, int.MaxValue, null, null);
					dtf.b["ammo_86_JHP"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Caliber_86_JHP")), false, false), 3, int.MaxValue, null, null);
					dtf.b["ammo_86_W2C"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Caliber_86_W2C")), false, false), 3, int.MaxValue, null, null);
					dtf.b["ammo_9_Std"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Caliber_9_Std")), false, false), 2, int.MaxValue, null, null);
					dtf.b["ammo_9_JHP"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Caliber_9_JHP")), false, false), 4, int.MaxValue, null, null);
					dtf.b["ammo_9_W2C"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Caliber_9_W2C")), false, false), 4, int.MaxValue, null, null);
					dtf.b["ammo_44_Std"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Caliber_44_Std")), false, false), 2, int.MaxValue, null, null);
					dtf.b["ammo_44_JHP"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Caliber_44_JHP")), false, false), 4, int.MaxValue, null, null);
					dtf.b["ammo_44_W2C"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Caliber_44_W2C")), false, false), 4, int.MaxValue, null, null);
					dtf.b["ammo_127_Std"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Caliber_127_Std")), false, false), 3, int.MaxValue, null, null);
					dtf.b["ammo_127_JHP"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Caliber_127_JHP")), false, false), 4, int.MaxValue, null, null);
					dtf.b["ammo_127_W2C"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Caliber_127_W2C")), false, false), 4, int.MaxValue, null, null);
					dtf.b["ammo_vial_acid_regular"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\vial_acid_regular")), false, false), 8, int.MaxValue, null, null);
					if (dk2.f())
					{
						dtf.b["xpbl_ammo_shotgunShell_6"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Xpbl\\ShotgunShell_6")), false, false), 3, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_ammo_shotgunShell_12"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Xpbl\\ShotgunShell_12")), false, false), 4, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_ammo_shotgunShell_20"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Xpbl\\ShotgunShell_20")), false, false), 5, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_ammo_shotgunShell_3"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Xpbl\\ShotgunShell_3")), false, false), 10, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_ammo_blindingPoisonBolt"] = new bgf(new a64(new acz(ez2.CreateDefinitonProvider<cdk>("Ammo\\Xpbl\\BlindingPoisonBolt")), false, false), 10, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_ammo_leperPoisonBolt"] = new bgf(new a64(new acz(ez2.CreateDefinitonProvider<cdk>("Ammo\\Xpbl\\LeperPoisonBolt")), false, false), 10, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_ammo_heartbreakPoisonBolt"] = new bgf(new a64(new acz(ez2.CreateDefinitonProvider<cdk>("Ammo\\Xpbl\\HeartbreakPoisonBolt")), false, false), 10, int.MaxValue, "xpbl", null);
					}
					if (dk2.e())
					{
						dtf.b["xphw_ammo_lgrenade_25_He"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Xphw\\Grenade_25_He")), false, false), 7, int.MaxValue, "xphw", null);
						dtf.b["xphw_ammo_lgrenade_25_Frag"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Xphw\\Grenade_25_Frag")), false, false), 7, int.MaxValue, "xphw", null);
						dtf.b["xphw_ammo_lgrenade_40_He"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Xphw\\Grenade_40_He")), false, false), 8, int.MaxValue, "xphw", null);
						dtf.b["xphw_ammo_lgrenade_40_Frag"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Xphw\\Grenade_40_Frag")), false, false), 8, int.MaxValue, "xphw", null);
						dtf.b["xphw_ammo_rocket_84_He"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Xphw\\rocket_84_he")), false, false), 10, int.MaxValue, "xphw", null);
						dtf.b["xphw_ammo_rocket_84_Kin"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Xphw\\rocket_84_kin")), false, false), 15, int.MaxValue, "xphw", null);
						dtf.b["xphw_ammo_rocket_84_Cs"] = new bgf(new a64(new dng(ez2.CreateDefinitonProvider<dgr>("Ammo\\Xphw\\rocket_84_cs")), false, false), 20, int.MaxValue, "xphw", null);
					}
					dtf.b["food_baconCheeseSandwich"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<a3e>("consumables\\food\\BaconCheeseSandwich")), false, false), 8, int.MaxValue, null, null);
					dtf.b["food_burrowerBurger"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<a3e>("consumables\\food\\BurrowerBurger")), false, false), 4, int.MaxValue, null, null);
					dtf.b["food_cannedFish"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<a3e>("consumables\\food\\CannedFish")), false, false), 1, int.MaxValue, null, null);
					dtf.b["food_cannedMeat"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<a3e>("consumables\\food\\CannedMeat")), false, false), 1, int.MaxValue, null, null);
					dtf.b["food_cannedMushrooms"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<a3e>("consumables\\food\\CannedMushrooms")), false, false), 1, int.MaxValue, null, null);
					dtf.b["food_cannedStew"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<a3e>("consumables\\food\\CannedStew")), false, false), 1, int.MaxValue, null, null);
					dtf.b["food_caveHopperSteak"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<a3e>("consumables\\food\\CaveHopperSteak")), false, false), 1, int.MaxValue, null, null);
					dtf.b["food_cookedBurrowerEgg"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<a3e>("consumables\\food\\CookedBurrowerEgg")), false, false), 10, int.MaxValue, null, null);
					dtf.b["food_coreChips"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<a3e>("consumables\\food\\CoreChips")), false, false), 8, int.MaxValue, null, null);
					dtf.b["food_hardcoreChips"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<a3e>("consumables\\food\\HardcoreChips")), false, false), 12, int.MaxValue, null, null);
					dtf.b["food_eelSandwich"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<a3e>("consumables\\food\\EelSandwich")), false, false), 3, int.MaxValue, null, null);
					dtf.b["food_friedSiphonerTongue"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<a3e>("consumables\\food\\FriedSiphonerTongue")), false, false), 7, int.MaxValue, null, null);
					dtf.b["food_mushroomSalad"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<a3e>("consumables\\food\\MushroomSalad")), false, false), 1, int.MaxValue, null, null);
					dtf.b["food_pentapusBarbecue"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<a3e>("consumables\\food\\PentapusBarbecue")), false, false), 10, int.MaxValue, null, null);
					dtf.b["food_pickledMindshrooms"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<a3e>("consumables\\food\\PickledMindshrooms")), false, false), 12, int.MaxValue, null, null);
					dtf.b["food_psiBeetleBrainSoup"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<a3e>("consumables\\food\\PsiBeetleBrainSoup")), false, false), 7, int.MaxValue, null, null);
					dtf.b["food_rathoundBarbeque"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<a3e>("consumables\\food\\RathoundBarbeque")), false, false), 1, int.MaxValue, null, null);
					dtf.b["food_stuffedBat"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<a3e>("consumables\\food\\StuffedBat")), false, false), 1, int.MaxValue, null, null);
					dtf.b["food_underPie"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<a3e>("consumables\\food\\UnderPie")), false, false), 1, int.MaxValue, null, null);
					if (dk2.f())
					{
						dtf.b["food_steamedClams"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<a3e>("consumables\\food\\xpbl\\ButterySteamedClams")), false, false), 10, int.MaxValue, null, null);
						dtf.b["food_bisonMilk"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<a3e>("consumables\\food\\xpbl\\bisonMilk")), false, false), 1, int.MaxValue, null, null);
					}
					dtf.b["drink_mushroomBrew"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<a3e>("consumables\\food\\MushroomBrew")), false, false), 1, int.MaxValue, null, null);
					dtf.b["drink_rootSoda"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<a3e>("consumables\\food\\RootSoda")), false, false), 1, int.MaxValue, null, null);
					dtf.b["scraps_metal"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\scraps\\metalScraps")), false, false), 1, int.MaxValue, null, null);
					dtf.b["scraps_electronic"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\scraps\\electronicScraps")), false, false), 1, int.MaxValue, null, null);
					dtf.b["scraps_fabric"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\scraps\\fabricScraps")), false, false), 1, int.MaxValue, null, null);
					dtf.b["trash_dirtyRag"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\scraps\\dirtyRag")), false, false), 1, int.MaxValue, null, null);
					dtf.b["trash_bottle"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\containers\\bottle")), false, false), 1, int.MaxValue, null, null);
					if (dk2.f())
					{
						dtf.b["xpbl_component_rubberBalls"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\scraps\\xpbl\\rubberBalls")), false, false), 1, int.MaxValue, "xpbl", null);
					}
					if (dk2.f())
					{
						dtf.b["vehiclePart_ScrappyEngine200"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<eqg>("VehicleParts\\Engines\\ScrappyEngine200")), false, false), 9, int.MaxValue, null, null);
						dtf.b["vehiclePart_ScrappyEngine250"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<eqg>("VehicleParts\\Engines\\ScrappyEngine250")), false, false), 10, int.MaxValue, null, null);
						dtf.b["vehiclePart_ScrappyEngine300"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<eqg>("VehicleParts\\Engines\\ScrappyEngine300")), false, false), 11, int.MaxValue, null, null);
						dtf.b["vehiclePart_WellMadeEngine225"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<eqg>("VehicleParts\\Engines\\WellMadeEngine225")), false, false), 11, int.MaxValue, null, null);
						dtf.b["vehiclePart_WellMadeEngine325"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<eqg>("VehicleParts\\Engines\\WellMadeEngine325")), false, false), 11, int.MaxValue, null, null);
						dtf.b["vehiclePart_BArmLightstep250"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<eqg>("VehicleParts\\Engines\\BArmLightstep250")), false, false), 10, int.MaxValue, null, null);
						dtf.b["vehiclePart_XGAlpha27"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<eqg>("VehicleParts\\Engines\\XGAlpha27")), false, false), 12, int.MaxValue, null, null);
						dtf.b["vehiclePart_XGAlpha30"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<eqg>("VehicleParts\\Engines\\XGAlpha30")), false, false), 13, int.MaxValue, null, null);
						dtf.b["vehiclePart_XGBeta35"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<eqg>("VehicleParts\\Engines\\XGBeta35")), false, false), 15, int.MaxValue, null, null);
						dtf.b["vehiclePart_BioInGiant375"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<eqg>("VehicleParts\\Engines\\BioInGiant375")), false, false), 16, int.MaxValue, null, null);
						dtf.b["vehiclePart_BArmShifter400"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<eqg>("VehicleParts\\Engines\\BArmShifter400")), false, false), 17, int.MaxValue, null, null);
						dtf.b["vehiclePart_BArmHauler450"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<eqg>("VehicleParts\\Engines\\BArmHauler450")), false, false), 20, int.MaxValue, null, null);
						dtf.b["vehiclePart_BioInTitan500"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<eqg>("VehicleParts\\Engines\\BioInTitan500")), false, false), 21, int.MaxValue, null, null);
						dtf.b["vehiclePart_BArmHauler550"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<eqg>("VehicleParts\\Engines\\BArmHauler550")), false, false), 22, int.MaxValue, null, null);
						dtf.b["vehiclePart_BArmHauler600"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<eqg>("VehicleParts\\Engines\\BArmHauler600")), false, false), 23, int.MaxValue, null, null);
					}
					if (dk2.f())
					{
						dtf.b["vehiclePart_ScrappyVehicleBattery150"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<esd>("VehicleParts\\Batteries\\ScrappyVehicleBattery150")), false, false), 9, int.MaxValue, null, null);
						dtf.b["vehiclePart_ScrappyVehicleBattery350"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<esd>("VehicleParts\\Batteries\\ScrappyVehicleBattery350")), false, false), 11, int.MaxValue, null, null);
						dtf.b["vehiclePart_ScrappyVehicleBattery600"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<esd>("VehicleParts\\Batteries\\ScrappyVehicleBattery600")), false, false), 14, int.MaxValue, null, null);
						dtf.b["vehiclePart_BArmScilon250"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<esd>("VehicleParts\\Batteries\\BArmScilon250")), false, false), 10, int.MaxValue, null, null);
						dtf.b["vehiclePart_BArmScilon350"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<esd>("VehicleParts\\Batteries\\BArmScilon350")), false, false), 11, int.MaxValue, null, null);
						dtf.b["vehiclePart_XGPower30"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<esd>("VehicleParts\\Batteries\\XGPower30")), false, false), 10, int.MaxValue, null, null);
						dtf.b["vehiclePart_XGPower40"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<esd>("VehicleParts\\Batteries\\XGPower40")), false, false), 12, int.MaxValue, null, null);
						dtf.b["vehiclePart_BArmCurrent550"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<esd>("VehicleParts\\Batteries\\BArmCurrent550")), false, false), 15, int.MaxValue, null, null);
						dtf.b["vehiclePart_BioInM600"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<esd>("VehicleParts\\Batteries\\BioInM600")), false, false), 15, int.MaxValue, null, null);
						dtf.b["vehiclePart_XGSuperpower75"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<esd>("VehicleParts\\Batteries\\XGSuperpower75")), false, false), 16, int.MaxValue, null, null);
						dtf.b["vehiclePart_BArmCurrent800"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<esd>("VehicleParts\\Batteries\\BArmCurrent800")), false, false), 17, int.MaxValue, null, null);
						dtf.b["vehiclePart_BioInL900"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<esd>("VehicleParts\\Batteries\\BioInL900")), false, false), 20, int.MaxValue, null, null);
						dtf.b["vehiclePart_BArmSolar1000"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<esd>("VehicleParts\\Batteries\\BArmSolar1000")), false, false), 21, int.MaxValue, null, null);
						dtf.b["vehiclePart_BArmSolar1250"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<esd>("VehicleParts\\Batteries\\BArmSolar1250")), false, false), 22, int.MaxValue, null, null);
						dtf.b["vehiclePart_BioInL1500"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<esd>("VehicleParts\\Batteries\\BioInL1500")), false, false), 23, int.MaxValue, null, null);
					}
					if (dk2.f())
					{
						dtf.b["xpbl_vehiclePart_jetski_BArmSmallJetShocks"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<eu0>("VehicleParts\\Xpbl_JetskiSuspensions\\BArmSmallJetShocks")), false, false), 10, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_vehiclePart_jetski_XGCloud"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<eu0>("VehicleParts\\Xpbl_JetskiSuspensions\\XGCloud")), false, false), 11, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_vehiclePart_jetski_XGStormCloud"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<eu0>("VehicleParts\\Xpbl_JetskiSuspensions\\XGStormCloud")), false, false), 12, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_vehiclePart_jetski_BArmMediumJetShocks"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<eu0>("VehicleParts\\Xpbl_JetskiSuspensions\\BArmMediumJetShocks")), false, false), 15, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_vehiclePart_jetski_BArmMediumJetShocksSE"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<eu0>("VehicleParts\\Xpbl_JetskiSuspensions\\BArmMediumJetShocksSE")), false, false), 16, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_vehiclePart_jetski_XGMist"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<eu0>("VehicleParts\\Xpbl_JetskiSuspensions\\XGMist")), false, false), 17, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_vehiclePart_jetski_BioInHDS2"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<eu0>("VehicleParts\\Xpbl_JetskiSuspensions\\BioInHDS2")), false, false), 20, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_vehiclePart_jetski_BArmLargeJetShocks"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<eu0>("VehicleParts\\Xpbl_JetskiSuspensions\\BArmLargeJetShocks")), false, false), 21, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_vehiclePart_jetski_BioInHDS3"] = new bgf(new a64(new agt(ez2.CreateDefinitonProvider<eu0>("VehicleParts\\Xpbl_JetskiSuspensions\\BioInHDS3")), false, false), 22, int.MaxValue, "xpbl", null);
					}
					if (dk2.f())
					{
						dtf.b["xpbl_component_clamMeat"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("Components\\Bio\\Xpbl\\ClamMeat")), false, false), 0, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_component_rottenClamMeat"] = new bgf(new a64(new fv(ez2.CreateDefinitonProvider<a1k>("Components\\Bio\\Xpbl\\RottenClamMeat")), false, false), 0, int.MaxValue, "xpbl", null);
					}
					dtf.b["luxury_amberStoneEarrings"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<dj3>("Luxury\\AmberStoneEarrings")), false, false), 0, int.MaxValue, null, null);
					dtf.b["luxury_goldRing"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<dj3>("Luxury\\GoldRing")), false, false), 0, int.MaxValue, null, null);
					dtf.b["luxury_backPendantNecklace"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<dj3>("Luxury\\BackPendantNecklace")), false, false), 0, int.MaxValue, null, null);
					dtf.b["luxury_ceramicWatch"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<dj3>("Luxury\\CeramicWatch")), false, false), 0, int.MaxValue, null, null);
					dtf.b["luxury_palladiumLeglet"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<dj3>("Luxury\\PalladiumLeglet")), false, false), 0, int.MaxValue, null, null);
					dtf.b["luxury_palmBracelet"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<dj3>("Luxury\\PalmBracelet")), false, false), 0, int.MaxValue, null, null);
					dtf.b["luxury_niobiumPiercingSet"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<dj3>("Luxury\\NiobiumPiercingSet")), false, false), 0, int.MaxValue, null, null);
					dtf.b["luxury_tiChromeHairClip"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<dj3>("Luxury\\TiChromeHairClip")), false, false), 0, int.MaxValue, null, null);
					if (dk2.f())
					{
						dtf.b["xpbl_luxury_pearl"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<dj3>("Luxury\\Xpbl\\Pearl")), false, false), 0, int.MaxValue, "xpbl", null);
					}
					if (dk2.f())
					{
						dtf.b["xpbl_vitalityPowder"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<dgn>("consumables\\medicine\\xpbl\\VitalityPowder")), false, false), 0, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_spiritPotion"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<dgn>("consumables\\medicine\\xpbl\\SpiritPotion")), false, false), 0, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_healingSalve"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<dgn>("consumables\\medicine\\xpbl\\HealingSalve")), false, false), 0, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_bioluminousSwampHoney"] = new bgf(new a64(new d48(ez2.CreateDefinitonProvider<cv9>("consumables\\medicine\\xpbl\\BioluminousSwampHoney")), false, false), 0, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_sormirbarenSabre"] = new bgf(new a64(new cd1(ez2.CreateDefinitonProvider<bke>("weapons\\xpbl\\SormirbarenSabre")), false, false), 0, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_sormirbarenSpear"] = new bgf(new a64(new cd1(ez2.CreateDefinitonProvider<bke>("weapons\\xpbl\\SormirbarenSpear")), false, false), 0, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_sormirbarenSledgehammer"] = new bgf(new a64(new cd1(ez2.CreateDefinitonProvider<bke>("weapons\\xpbl\\SormirbarenSledgehammer")), false, false), 0, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_sormirbarenKnife"] = new bgf(new a64(new cd1(ez2.CreateDefinitonProvider<bke>("weapons\\xpbl\\SormirbarenKnife")), false, false), 0, int.MaxValue, "xpbl", null);
						dtf.b["xpbl_sormirbarenCrossbow"] = new bgf(new a64(new cd1(ez2.CreateDefinitonProvider<bke>("weapons\\xpbl\\SormirbarenCrossbow")), false, false), 0, int.MaxValue, "xpbl", null);
					}
					dtf.b["hypnoGoggles"] = new bgf(new a64(new k7(ez2.CreateDefinitonProvider<bqu>("Armor\\HypnoGoggles")), false, true), 5, int.MaxValue, null, null);
					dtf.b["gUnique_helmet_unprojector"] = new bgf(new a64(new k7(ez2.CreateDefinitonProvider<bqu>("armor\\unprojector")), false, false), 8, int.MaxValue, null, null);
					dtf.b["gUnique_helmet_cyclopsEye"] = new bgf(new a64(new k7(ez2.CreateDefinitonProvider<bqu>("armor\\cyclopsEye")), false, false), 14, int.MaxValue, null, null);
					dtf.b["gUnique_helmet_commandoBelt"] = new bgf(new a64(new cjh(ez2.CreateDefinitonProvider<c27>("armor\\commandoBelt")), false, false), 5, int.MaxValue, null, new Func<bool>(dtf.a.a.a));
					dtf.b["gUnique_boots_jumpingStilts"] = new bgf(new a64(new a12(ez2.CreateDefinitonProvider<c5s>("armor\\JumpingStilts")), false, false), 15, int.MaxValue, null, null);
					foreach (KeyValuePair<string, bgf> keyValuePair in dtf.b)
					{
						a64 a = keyValuePair.Value.a as a64;
						if ((keyValuePair.Value.d == null || dk2.b(keyValuePair.Value.d)) && a != null && Enumerable.FirstOrDefault<coh>(a.np()).Definition.az() == "Unknown")
						{
							dux.b(LogSeverity.CriticalError, "Item replicator is invalid. Key: " + keyValuePair.Key, new object[0]);
							throw new Exception("Item replicator is invalid. Key: " + keyValuePair.Key);
						}
					}
				}
			}
		}
	}

	// Token: 0x06002EFB RID: 12027 RVA: 0x00112390 File Offset: 0x00110590
	private static bool a(Version A_0)
	{
		cnk service = bpo.GetService<cnk>();
		return service != null && service.aqu() != null && service.aqu().y() <= A_0;
	}

	// Token: 0x06002EFC RID: 12028 RVA: 0x001123C8 File Offset: 0x001105C8
	private static List<ezv> a(ItemRange A_0)
	{
		if (A_0 <= ItemRange.Component_RocketLaunchers)
		{
			if (A_0 <= ItemRange.Weapons_Melee_Bladed)
			{
				switch (A_0)
				{
				case ItemRange.Tech:
					return new List<ezv>
					{
						dtf.a("haxxor", 3, 1, 1, null),
						dtf.a("electricTorch", 3, 1, 1, null),
						dtf.a("armor_fireProximitySuit", 6, 1, 1, null),
						dtf.a("armor_blastSuit", 15, 1, 1, null),
						dtf.a("armor_gasMask", 3, 1, 1, null),
						dtf.a("component_digitalTimer", 1, 1, 1, null),
						dtf.a("blueprint_grenade", 6, 1, 1, null),
						dtf.a("blueprint_flashbang", 8, 1, 1, null),
						dtf.a("blueprint_mine", 6, 1, 1, null),
						dtf.a("blueprint_empGrenade", 8, 1, 1, null),
						dtf.a("blueprint_empMine", 8, 1, 1, null),
						dtf.a("blueprint_cloakingDevice", 8, 1, 1, null),
						dtf.a("blueprint_energyShieldEmitter", 8, 1, 1, null),
						dtf.a("blueprint_goggles", 6, 1, 1, null),
						dtf.a("blueprint_shockBolt", 6, 1, 1, null),
						dtf.a("blueprint_shockShuriken", 10, 1, 1, null),
						dtf.a("xpbl_blueprint_plasmaGrenade", 250, 1, 1, null),
						dtf.a("xpbl_blueprint_plasmaMine", 250, 1, 1, null),
						dtf.a("xpbl_blueprint_spyingEndoscope", 300, 1, 1, null),
						dtf.a("component_plasmaCore", 2, 1, 1, null),
						dtf.a("component_electroshockGenerator", 3, 1, 1, null),
						dtf.a("component_pneumaticHammer", 4, 1, 1, null),
						dtf.a("component_microElectroshockDischarger", 1, 1, 3, null),
						dtf.a("component_boltTrigger", 1, 1, 1, null),
						dtf.a("component_laserEmitter", 3, 1, 1, null),
						dtf.a("component_plasmaDischarger", 4, 1, 1, null),
						dtf.a("component_smartModule", 4, 1, 1, null),
						dtf.a("component_empDischarger", 3, 1, 3, null),
						dtf.a("component_emDeflector", 3, 1, 1, null),
						dtf.a("component_emFieldStabilizer", 3, 1, 1, null),
						dtf.a("component_energyPistolFrame", 2, 1, 1, null),
						dtf.a("xpbl_component_plasmaMicroDischarger", 8, 1, 3, null),
						dtf.a("xpbl_component_polarizer", 8, 1, 1, null),
						dtf.a("xpbl_component_energyEdgeEmitter", 50, 1, 1, null),
						dtf.a("component_scope", 2, 1, 1, null),
						dtf.a("component_anatomicallyAwareScope", 3, 1, 1, null),
						dtf.a("component_highResolutionDigitalScope", 3, 1, 1, null),
						dtf.a("component_laserSight", 2, 1, 1, null),
						dtf.a("component_reflexSight", 2, 1, 1, null),
						dtf.a("component_pneumaticReloader", 4, 1, 1, null),
						dtf.a("component_vest_galvanic", 3, 1, 1, null),
						dtf.a("component_vest_regenerative", 7, 1, 1, null),
						dtf.a("component_visor", 2, 1, 1, null),
						dtf.a("component_shadedVisor", 2, 1, 1, null),
						dtf.a("component_gogglesFrame", 2, 1, 1, null),
						dtf.a("component_bootSpring", 3, 1, 1, null),
						dtf.a("component_adaptiveLens", 2, 1, 1, null),
						dtf.a("component_seekerLens", 2, 1, 1, null),
						dtf.a("component_smartLens", 3, 1, 1, null),
						dtf.a("component_motionTrackingLens", 3, 1, 1, null),
						dtf.a("component_imageIntensifierTube", 3, 1, 1, null),
						dtf.a("component_headlight", 2, 1, 1, null),
						dtf.a("component_empMineCase", 1, 1, 1, null),
						dtf.a("xpbl_component_plasmaMineCase", 2, 1, 1, null),
						dtf.a("battery_scLi", 1, 1, 1, null),
						dtf.a("battery_fusion", 3, 1, 1, null),
						dtf.a("battery_plasma", 5, 1, 1, null),
						dtf.a("battery_greaterFusion", 9, 1, 1, null),
						dtf.a("belt_utility", 4, 1, 1, null),
						dtf.a("belt_catalyzingBelt", 20, 1, 1, null),
						dtf.a("belt_advancedCatalyzingBelt", 30, 1, 1, null),
						dtf.a("armor_goggles", 4, 1, 1, null),
						dtf.a("armor_psionicHeadband", 6, 1, 1, null),
						dtf.a("armor_shieldEmitter", 6, 1, 1, null),
						dtf.a("scraps_electronic", 3, 1, 3, null),
						dtf.a("electronicRepairKit1", 4, 1, 1, null),
						dtf.a("electronicRepairKit2", 7, 1, 1, null),
						dtf.a("component_psionicHeadbandFrame", 8, 1, 1, null),
						dtf.a("component_psionicModulator_metathermic", 9, 1, 1, null),
						dtf.a("component_psionicModulator_psychokinetic", 9, 1, 1, null),
						dtf.a("component_psionicModulator_thoughtControl", 9, 1, 1, null),
						dtf.a("component_psionicModulator_universal", 9, 1, 1, null),
						dtf.a("xpbl_component_psionicModulator_temporalManipulation", 9, 1, 1, null),
						dtf.a("component_proximalNeuroscopicFilter", 11, 1, 1, null),
						dtf.a("component_stableNeuralAmplifier", 12, 1, 1, null),
						dtf.a("component_psionicMufflers", 13, 1, 1, null),
						dtf.a("component_psiCircuitExtension", 15, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_cryokinesis", 30, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_cryokineticOrb", 30, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_electrokinesis", 30, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_neuralOverload", 30, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_pyrokinesis", 30, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_pyrokineticStream", 30, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_telekineticPunch", 30, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_temporalDistorsion", 30, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_plasmaBeam", 70, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_cryogenicBarrier", 30, 1, 1, null),
						dtf.a("component_shieldEmitterBase", 3, 1, 1, null),
						dtf.a("component_lowFrequencyShieldModulator", 3, 1, 1, null),
						dtf.a("component_mediumFrequencyShieldModulator", 3, 1, 1, null),
						dtf.a("component_highFrequencyShieldModulator", 3, 1, 1, null),
						dtf.a("component_circularWaveAmplifier", 5, 1, 1, null),
						dtf.a("component_shieldCapacitor", 5, 1, 1, null),
						dtf.a("component_highEfficiencyEnergyConverter", 5, 1, 1, null),
						dtf.a("gUnique_helmet_unprojector", 300, 1, 1, null),
						dtf.a("gUnique_helmet_cyclopsEye", 300, 1, 1, null),
						dtf.a("gUnique_boots_jumpingStilts", 300, 1, 1, null)
					};
				case ItemRange.Medical:
					return new List<ezv>
					{
						dtf.a("psiBooster", 2, 1, 1, null),
						dtf.a("psiInhalant", 2, 1, 1, null),
						dtf.a("healthHypo", 1, 1, 1, null),
						dtf.a("advancedHealthHypo", 2, 1, 1, null),
						dtf.a("bandage", 1, 1, 1, null),
						dtf.a("antidote", 3, 1, 1, null),
						dtf.a("adrenalineShot", 3, 1, 1, null),
						dtf.a("morphineShot", 7, 1, 1, null),
						dtf.a("irongut", 20, 1, 1, null),
						dtf.a("trance", 20, 1, 1, null),
						dtf.a("aegis", 20, 1, 1, null),
						dtf.a("focusStim", 20, 1, 1, null),
						dtf.a("jumpingBean", 20, 1, 1, null),
						dtf.a("belt_doctorsPouch", 6, 1, 1, null),
						dtf.a("belt_groinGuard", 6, 1, 1, null),
						dtf.a("belt_vigorousBelt", 6, 1, 1, null),
						dtf.a("armor_biotechSuit", 5, 1, 1, null),
						dtf.a("armor_doctorsCoat", 5, 1, 1, null),
						dtf.a("component_ampule", 1, 1, 5, null),
						dtf.a("component_flatBeaker", 1, 1, 2, null),
						dtf.a("component_capsule", 1, 1, 8, null),
						dtf.a("component_vial", 1, 1, 5, null),
						dtf.a("component_spongeFilter", 1, 1, 3, null),
						dtf.a("component_syringe", 1, 1, 5, null),
						dtf.a("component_midazolam", 4, 1, 1, null),
						dtf.a("component_psionicCatalyst", 5, 1, 1, null),
						dtf.a("component_bondingAgent", 4, 1, 1, null),
						dtf.a("component_anticoagulant", 2, 1, 1, null),
						dtf.a("component_smallOxygenTank", 2, 1, 1, null),
						dtf.a("component_taurine", 5, 1, 1, null),
						dtf.a("component_organicGelElectrolyte", 5, 1, 1, null),
						dtf.a("component_burrowerPoison", 3, 1, 1, null),
						dtf.a("component_caveEarPoison", 10, 1, 1, null),
						dtf.a("component_crawlerPoison", 15, 1, 1, null),
						dtf.a("component_acid", 4, 1, 1, null),
						dtf.a("component_blood", 7, 1, 1, null),
						dtf.a("component_adrenaline", 7, 1, 1, null),
						dtf.a("component_morphine", 10, 1, 1, null),
						dtf.a("component_insectoidSaliva", 10, 1, 1, null),
						dtf.a("component_mindshroom", 8, 1, 1, null),
						dtf.a("component_lakePoppy", 14, 1, 1, null),
						dtf.a("component_caveEar", 14, 1, 1, null),
						dtf.a("component_redDreamMushroom", 14, 1, 1, null),
						dtf.a("blueprint_healthHypo", 15, 1, 1, null),
						dtf.a("blueprint_advancedHealthHypo", 15, 1, 1, null),
						dtf.a("blueprint_superHealthHypo", 15, 1, 1, null),
						dtf.a("blueprint_adrenalineShot", 15, 1, 1, null),
						dtf.a("blueprint_morphineShot", 15, 1, 1, null),
						dtf.a("blueprint_psiBooster", 15, 1, 1, null),
						dtf.a("blueprint_psiInhalant", 15, 1, 1, null),
						dtf.a("blueprint_psiReinvigorator", 15, 1, 1, null),
						dtf.a("blueprint_extractToxin", 15, 1, 1, null),
						dtf.a("blueprint_processPlant", 15, 1, 1, null),
						dtf.a("blueprint_chemicalBolt", 15, 1, 1, null),
						dtf.a("blueprint_irongut", 15, 1, 1, null),
						dtf.a("blueprint_trance", 15, 1, 1, null),
						dtf.a("blueprint_aegis", 15, 1, 1, null),
						dtf.a("blueprint_focusStim", 15, 1, 1, null),
						dtf.a("blueprint_jumpingBean", 15, 1, 1, null),
						dtf.a("blueprint_bullhead", 15, 1, 1, null),
						dtf.a("xpbl_blueprint_psionicAccelerator", 500, 1, 1, null),
						dtf.a("xpbl_blueprint_coagulationShot", 500, 1, 1, null),
						dtf.a("xpbl_blueprint_hypercerebrix", 500, 1, 1, null),
						dtf.a("xpbl_blueprint_twitch", 500, 1, 1, null),
						dtf.a("xpbl_blueprint_thirdEye", 500, 1, 1, null),
						dtf.a("component_magnesiumPowder", 9, 1, 1, null),
						dtf.a("component_whitePhosphorus", 20, 1, 1, null),
						dtf.a("component_graphite", 20, 1, 1, null),
						dtf.a("ammo_vial_acid_regular", 10, 1, 3, null),
						dtf.a("component_psionicHeadbandFrame", 11, 1, 1, null),
						dtf.a("component_psionicModulator_metathermic", 12, 1, 1, null),
						dtf.a("component_psionicModulator_psychokinetic", 12, 1, 1, null),
						dtf.a("component_psionicModulator_thoughtControl", 12, 1, 1, null),
						dtf.a("component_psionicModulator_universal", 12, 1, 1, null),
						dtf.a("xpbl_component_psionicModulator_temporalManipulation", 12, 1, 1, null),
						dtf.a("component_proximalNeuroscopicFilter", 14, 1, 1, null),
						dtf.a("component_stableNeuralAmplifier", 15, 1, 1, null),
						dtf.a("component_psionicMufflers", 16, 1, 1, null),
						dtf.a("component_psiCircuitExtension", 18, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_cryokinesis", 200, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_cryokineticOrb", 200, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_electrokinesis", 200, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_neuralOverload", 200, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_pyrokinesis", 200, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_pyrokineticStream", 200, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_telekineticPunch", 200, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_temporalDistorsion", 200, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_plasmaBeam", 350, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_cryogenicBarrier", 200, 1, 1, null)
					};
				case ItemRange.MedicalConventional:
					return new List<ezv>
					{
						dtf.a("component_mindshroom", 15, 1, 1, null),
						dtf.a("component_ampule", 1, 1, 5, null),
						dtf.a("component_flatBeaker", 1, 1, 2, null),
						dtf.a("component_capsule", 1, 1, 8, null),
						dtf.a("component_vial", 1, 1, 5, null),
						dtf.a("component_spongeFilter", 1, 1, 3, null),
						dtf.a("component_syringe", 1, 1, 5, null),
						dtf.a("component_midazolam", 4, 1, 1, null),
						dtf.a("component_psionicCatalyst", 5, 1, 1, null),
						dtf.a("component_bondingAgent", 4, 1, 1, null),
						dtf.a("component_anticoagulant", 2, 1, 1, null),
						dtf.a("component_smallOxygenTank", 2, 1, 1, null),
						dtf.a("component_taurine", 5, 1, 1, null),
						dtf.a("component_organicGelElectrolyte", 5, 1, 1, null),
						dtf.a("psiBooster", 2, 1, 1, null),
						dtf.a("psiInhalant", 2, 1, 1, null),
						dtf.a("adrenalineShot", 3, 1, 1, null),
						dtf.a("morphineShot", 7, 1, 1, null),
						dtf.a("healthHypo", 1, 1, 1, null),
						dtf.a("advancedHealthHypo", 2, 1, 1, null),
						dtf.a("bandage", 1, 1, 1, null),
						dtf.a("antidote", 3, 1, 1, null),
						dtf.a("irongut", 15, 1, 1, null),
						dtf.a("jumpingBean", 15, 1, 1, null),
						dtf.a("blueprint_healthHypo", 15, 1, 1, null),
						dtf.a("blueprint_advancedHealthHypo", 15, 1, 1, null),
						dtf.a("blueprint_superHealthHypo", 15, 1, 1, null),
						dtf.a("blueprint_adrenalineShot", 15, 1, 1, null),
						dtf.a("blueprint_psiBooster", 15, 1, 1, null),
						dtf.a("blueprint_psiInhalant", 15, 1, 1, null),
						dtf.a("blueprint_psiReinvigorator", 15, 1, 1, null),
						dtf.a("blueprint_extractToxin", 15, 1, 1, null),
						dtf.a("blueprint_processPlant", 15, 1, 1, null),
						dtf.a("blueprint_irongut", 15, 1, 1, null),
						dtf.a("blueprint_jumpingBean", 15, 1, 1, null),
						dtf.a("blueprint_bullhead", 15, 1, 1, null),
						dtf.a("xpbl_blueprint_psionicAccelerator", 500, 1, 1, null),
						dtf.a("xpbl_blueprint_coagulationShot", 500, 1, 1, null),
						dtf.a("xpbl_blueprint_hypercerebrix", 500, 1, 1, null),
						dtf.a("xpbl_blueprint_twitch", 500, 1, 1, null),
						dtf.a("xpbl_blueprint_thirdEye", 500, 1, 1, null),
						dtf.a("belt_doctorsPouch", 6, 1, 1, null),
						dtf.a("belt_groinGuard", 6, 1, 1, null),
						dtf.a("belt_vigorousBelt", 6, 1, 1, null),
						dtf.a("armor_biotechSuit", 8, 1, 1, null),
						dtf.a("armor_doctorsCoat", 7, 1, 1, null),
						dtf.a("component_magnesiumPowder", 9, 1, 1, null),
						dtf.a("component_whitePhosphorus", 14, 1, 1, null),
						dtf.a("component_graphite", 14, 1, 1, null),
						dtf.a("component_psionicHeadbandFrame", 11, 1, 1, null),
						dtf.a("component_psionicModulator_metathermic", 12, 1, 1, null),
						dtf.a("component_psionicModulator_psychokinetic", 12, 1, 1, null),
						dtf.a("component_psionicModulator_thoughtControl", 12, 1, 1, null),
						dtf.a("component_psionicModulator_universal", 12, 1, 1, null),
						dtf.a("xpbl_component_psionicModulator_temporalManipulation", 12, 1, 1, null),
						dtf.a("component_proximalNeuroscopicFilter", 14, 1, 1, null),
						dtf.a("component_stableNeuralAmplifier", 15, 1, 1, null),
						dtf.a("component_psionicMufflers", 16, 1, 1, null),
						dtf.a("component_psiCircuitExtension", 18, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_cryokinesis", 200, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_cryokineticOrb", 200, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_electrokinesis", 200, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_neuralOverload", 200, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_pyrokinesis", 200, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_pyrokineticStream", 200, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_telekineticPunch", 200, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_temporalDistorsion", 200, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_plasmaBeam", 350, 1, 1, null),
						dtf.a("xpbl_component_magnifyingNeuroscopicFilter_cryogenicBarrier", 200, 1, 1, null),
						dtf.a("armor_psionicHeadband", 20, 1, 1, null)
					};
				case ItemRange.MedicalDrugs:
					return new List<ezv>
					{
						dtf.a("component_mindshroom", 5, 1, 1, null),
						dtf.a("component_redDreamMushroom", 8, 1, 1, null),
						dtf.a("component_lakePoppy", 10, 1, 1, null),
						dtf.a("component_caveEar", 10, 1, 1, null),
						dtf.a("morphineShot", 2, 1, 1, null),
						dtf.a("trance", 15, 1, 1, null),
						dtf.a("aegis", 15, 1, 1, null),
						dtf.a("focusStim", 15, 1, 1, null),
						dtf.a("jumpingBean", 15, 1, 1, null),
						dtf.a("component_ampule", 5, 1, 5, null),
						dtf.a("component_flatBeaker", 6, 1, 2, null),
						dtf.a("component_capsule", 5, 1, 8, null),
						dtf.a("component_vial", 5, 1, 5, null),
						dtf.a("component_spongeFilter", 5, 1, 3, null),
						dtf.a("component_syringe", 5, 1, 5, null),
						dtf.a("component_midazolam", 1, 1, 1, null),
						dtf.a("component_psionicCatalyst", 6, 1, 1, null),
						dtf.a("component_burrowerPoison", 1, 1, 1, null),
						dtf.a("component_caveEarPoison", 10, 1, 1, null),
						dtf.a("component_crawlerPoison", 15, 1, 1, null),
						dtf.a("component_acid", 2, 1, 1, null),
						dtf.a("component_adrenaline", 4, 1, 1, null),
						dtf.a("component_morphine", 8, 1, 1, null),
						dtf.a("blueprint_morphineShot", 15, 1, 1, null),
						dtf.a("blueprint_trance", 15, 1, 1, null),
						dtf.a("blueprint_aegis", 15, 1, 1, null),
						dtf.a("blueprint_focusStim", 15, 1, 1, null),
						dtf.a("blueprint_jumpingBean", 15, 1, 1, null),
						dtf.a("ammo_vial_acid_regular", 5, 1, 3, null),
						dtf.a("component_AcidCollector", 10, 1, 1, null),
						dtf.a("component_CryogenicCollector", 10, 1, 1, null),
						dtf.a("component_IncendiaryCollector", 10, 1, 1, null),
						dtf.a("component_chemicalTrapCase", 10, 1, 1, null)
					};
				case ItemRange.Firearms:
					return new List<ezv>
					{
						dtf.a("pistol", 1, 1, 1, null),
						dtf.a("smg", 2, 1, 1, null),
						dtf.a("assaultRifle", 3, 1, 1, null),
						dtf.a("sniper", 4, 1, 1, null),
						dtf.a("xpbl_shotgun", 3, 1, 1, null),
						dtf.a("xphw_grenadeLauncher", 4, 1, 1, null),
						dtf.a("xphw_rocketLauncher", 8, 1, 1, null),
						dtf.a("xphw_rocketLauncher_drl", 8, 1, 1, null),
						dtf.a("xphw_lightMachineGun", 2, 1, 1, null),
						dtf.a("xphw_minigun", 7, 1, 1, null)
					};
				case ItemRange.Weapons:
					return new List<ezv>
					{
						dtf.a("pistol", 1, 1, 1, null),
						dtf.a("smg", 2, 1, 1, null),
						dtf.a("assaultRifle", 3, 1, 1, null),
						dtf.a("sniper", 4, 1, 1, null),
						dtf.a("crossbow", 2, 1, 1, null),
						dtf.a("energyPistol", 5, 1, 1, null),
						dtf.a("knife", 1, 1, 1, null),
						dtf.a("gloves", 2, 1, 1, null),
						dtf.a("sledgehammer", 2, 1, 1, null),
						dtf.a("steel_crowbar", 25, 1, 1, null),
						dtf.a("tungsten_crowbar", 100, 1, 1, null),
						dtf.a("tichrome_crowbar", 100, 1, 1, null),
						dtf.a("superSteel_crowbar", 200, 1, 1, null),
						dtf.a("shiv", 25, 1, 1, null),
						dtf.a("brassKnuckles", 25, 1, 1, null),
						dtf.a("knifeThrowerGloves", 25, 1, 1, null),
						dtf.a("xpbl_spear", 5, 1, 1, null),
						dtf.a("xpbl_machete", 3, 1, 1, null),
						dtf.a("xpbl_shotgun", 3, 1, 1, null),
						dtf.a("xpbl_javelin", 10, 1, 1, null),
						dtf.a("xphw_grenadeLauncher", 5, 1, 1, null),
						dtf.a("xphw_rocketLauncher", 10, 1, 1, null),
						dtf.a("xphw_rocketLauncher_drl", 10, 1, 1, null),
						dtf.a("xphw_lightMachineGun", 2, 1, 1, null),
						dtf.a("xphw_minigun", 8, 1, 1, null)
					};
				case ItemRange.Military:
					return new List<ezv>
					{
						dtf.a("pistol", 1, 1, 1, null),
						dtf.a("smg", 2, 1, 1, null),
						dtf.a("assaultRifle", 3, 1, 1, null),
						dtf.a("sniper", 4, 1, 1, null),
						dtf.a("crossbow", 2, 1, 1, null),
						dtf.a("energyPistol", 5, 1, 1, null),
						dtf.a("knife", 1, 1, 1, null),
						dtf.a("gloves", 2, 1, 1, null),
						dtf.a("sledgehammer", 2, 1, 1, null),
						dtf.a("flashbang", 5, 1, 1, null),
						dtf.a("xpbl_spear", 10, 1, 1, null),
						dtf.a("xpbl_machete", 3, 1, 1, null),
						dtf.a("xpbl_shotgun", 3, 1, 1, null),
						dtf.a("xpbl_javelin", 6, 1, 1, null),
						dtf.a("xphw_grenadeLauncher", 5, 1, 1, null),
						dtf.a("xphw_rocketLauncher", 10, 1, 1, null),
						dtf.a("xphw_rocketLauncher_drl", 10, 1, 1, null),
						dtf.a("xphw_lightMachineGun", 2, 1, 1, null),
						dtf.a("xphw_minigun", 7, 1, 1, null),
						dtf.a("component_fragGrenadeCase", 5, 1, 1, null),
						dtf.a("component_thinGrenadeCase", 5, 1, 1, null),
						dtf.a("component_fragMineCase", 7, 1, 1, null),
						dtf.a("component_thinMineCase", 7, 1, 1, null),
						dtf.a("component_empMineCase", 10, 1, 1, null),
						dtf.a("xpbl_component_plasmaMineCase", 20, 1, 1, null),
						dtf.a("component_rawTnt", 7, 1, 1, null),
						dtf.a("component_hexogen", 9, 1, 1, null),
						dtf.a("component_crossbowParts1", 7, 1, 1, null),
						dtf.a("component_crossbowParts2", 7, 1, 1, null),
						dtf.a("component_crossbowParts3", 7, 1, 1, null),
						dtf.a("component_crossbowParts4", 7, 1, 1, null),
						dtf.a("component_crossbowParts5", 7, 1, 1, null),
						dtf.a("component_pistolFrame1", 7, 1, 1, null),
						dtf.a("component_pistolFrame2", 7, 1, 1, null),
						dtf.a("component_pistolFrame3", 7, 1, 1, null),
						dtf.a("component_pistolFrame4", 7, 1, 1, null),
						dtf.a("component_smgFrame1", 8, 1, 1, null),
						dtf.a("component_smgFrame2", 8, 1, 1, null),
						dtf.a("component_smgFrame3", 8, 1, 1, null),
						dtf.a("component_smgFrame4", 8, 1, 1, null),
						dtf.a("component_sniperFrame1", 10, 1, 1, null),
						dtf.a("component_sniperFrame2", 10, 1, 1, null),
						dtf.a("component_sniperFrame3", 10, 1, 1, null),
						dtf.a("component_sniperFrame4", 10, 1, 1, null),
						dtf.a("component_assaultRifleFrame1", 10, 1, 1, null),
						dtf.a("component_assaultRifleFrame2", 10, 1, 1, null),
						dtf.a("component_assaultRifleFrame3", 10, 1, 1, null),
						dtf.a("component_assaultRifleFrame4", 10, 1, 1, null),
						dtf.a("xpbl_component_shotgunFrame1", 10, 1, 1, null),
						dtf.a("xpbl_component_shotgunFrame2", 10, 1, 1, null),
						dtf.a("xpbl_component_shotgunFrame3", 10, 1, 1, null),
						dtf.a("xpbl_component_combatShotgunFrame1", 12, 1, 1, null),
						dtf.a("xpbl_component_combatShotgunFrame2", 12, 1, 1, null),
						dtf.a("xpbl_component_combatShotgunFrame3", 12, 1, 1, null),
						dtf.a("xphw_component_grenadeLauncherFrame1", 13, 1, 1, null),
						dtf.a("xphw_component_grenadeLauncherFrame2", 15, 1, 1, null),
						dtf.a("xphw_component_grenadeLauncherFrame3", 13, 1, 1, null),
						dtf.a("xphw_component_grenadeLauncherFrame4", 15, 1, 1, null),
						dtf.a("xphw_component_lightMachineGunFrame1", 8, 1, 1, null),
						dtf.a("xphw_component_lightMachineGunFrame2", 8, 1, 1, null),
						dtf.a("xphw_component_lightMachineGunFrame3", 8, 1, 1, null),
						dtf.a("xphw_component_lightMachineGunFrame4", 8, 1, 1, null),
						dtf.a("xphw_component_minigunFrame1", 18, 1, 1, null),
						dtf.a("xphw_component_minigunFrame2", 23, 1, 1, null),
						dtf.a("xphw_component_minigunFrame3", 18, 1, 1, null),
						dtf.a("xphw_component_minigunFrame4", 23, 1, 1, null),
						dtf.a("xphw_component_rocketLauncherFrame1", 18, 1, 1, null),
						dtf.a("xphw_component_rocketLauncherFrame2", 22, 1, 1, null),
						dtf.a("xphw_component_rocketLauncherFrame3", 22, 1, 1, null),
						dtf.a("xphw_component_rocketLauncherFrame4", 25, 1, 1, null),
						dtf.a("xphw_component_rocketLauncherFrame5", 25, 1, 1, null),
						dtf.a("component_scope", 8, 1, 1, null),
						dtf.a("component_anatomicallyAwareScope", 8, 1, 1, null),
						dtf.a("component_highResolutionDigitalScope", 8, 1, 1, null),
						dtf.a("component_laserSight", 8, 1, 1, null),
						dtf.a("component_reflexSight", 8, 1, 1, null),
						dtf.a("component_crossbowSuperString", 12, 1, 1, null),
						dtf.a("component_pneumaticReloader", 12, 1, 1, null),
						dtf.a("component_pneumaticHammer", 12, 1, 1, null),
						dtf.a("component_extendedPistolMagazine", 8, 1, 1, null),
						dtf.a("component_extendedRifleMagazine", 9, 1, 1, null),
						dtf.a("component_bipod", 8, 1, 1, null),
						dtf.a("component_rifleBarrelRetractor", 10, 1, 1, null),
						dtf.a("component_verticalForegrip", 8, 1, 1, null),
						dtf.a("xphw_component_ergonomicHandle", 8, 1, 1, null),
						dtf.a("component_sledgehammerHandle", 5, 1, 1, null),
						dtf.a("xpbl_component_spearShaft", 8, 1, 1, null),
						dtf.a("xpbl_component_macheteHandle", 5, 1, 1, null),
						dtf.a("component_knifeHandle", 3, 1, 1, null),
						dtf.a("component_knifeMold", 3, 1, 1, null),
						dtf.a("component_serratedKnifeMold", 4, 1, 1, null),
						dtf.a("component_daggerMold", 4, 1, 1, null),
						dtf.a("xpbl_component_straightMacheteBladeMold", 4, 1, 1, null),
						dtf.a("xpbl_component_curvedMacheteBladeMold", 4, 1, 1, null),
						dtf.a("xpbl_component_smallShotgunPelletMold", 3, 1, 5, null),
						dtf.a("xpbl_component_mediumShotgunPelletMold", 3, 1, 5, null),
						dtf.a("xpbl_component_largeShotgunPelletMold", 3, 1, 5, null),
						dtf.a("xpbl_component_hugeShotgunPelletMold", 7, 1, 5, null),
						dtf.a("component_muzzleBrake", 5, 1, 1, null),
						dtf.a("component_barrelCompensator", 5, 1, 1, null),
						dtf.a("component_silencer", 4, 1, 1, null),
						dtf.a("component_rapidReloader", 5, 1, 1, null),
						dtf.a("xpbl_component_shotgunChoke", 6, 1, 1, null),
						dtf.a("xpbl_component_shotgunTubeExtension", 7, 1, 1, null),
						dtf.a("blueprint_grenade", 15, 1, 1, null),
						dtf.a("blueprint_thinGrenadeCase", 15, 1, 1, null),
						dtf.a("blueprint_fragGrenadeCase", 15, 1, 1, null),
						dtf.a("blueprint_thinMineCase", 15, 1, 1, null),
						dtf.a("blueprint_fragMineCase", 15, 1, 1, null),
						dtf.a("blueprint_flashbang", 15, 1, 1, null),
						dtf.a("blueprint_mine", 15, 1, 1, null),
						dtf.a("blueprint_empGrenade", 20, 1, 1, null),
						dtf.a("blueprint_empMine", 20, 1, 1, null),
						dtf.a("blueprint_cloakingDevice", 20, 1, 1, null),
						dtf.a("blueprint_energyShieldEmitter", 20, 1, 1, null),
						dtf.a("blueprint_goggles", 15, 1, 1, null),
						dtf.a("blueprint_leatherArmor", 15, 1, 1, null),
						dtf.a("blueprint_balaclava", 15, 1, 1, null),
						dtf.a("blueprint_tacticalVest", 15, 1, 1, null),
						dtf.a("blueprint_riotGear", 15, 1, 1, null),
						dtf.a("blueprint_crossbow", 12, 1, 1, null),
						dtf.a("blueprint_pistol", 12, 1, 1, null),
						dtf.a("blueprint_sniper", 20, 1, 1, null),
						dtf.a("blueprint_metalArmor", 20, 1, 1, null),
						dtf.a("blueprint_metalHelmet", 15, 1, 1, null),
						dtf.a("blueprint_boots", 12, 1, 1, null),
						dtf.a("blueprint_greaves", 1, 1, 1, null),
						dtf.a("blueprint_tabiBoots", 12, 1, 1, null),
						dtf.a("blueprint_smg", 12, 1, 1, null),
						dtf.a("blueprint_combatKnife", 12, 1, 1, null),
						dtf.a("blueprint_shiv", 20, 1, 1, null),
						dtf.a("xpbl_blueprint_machete", 12, 1, 1, null),
						dtf.a("blueprint_caltrops", 12, 1, 1, null),
						dtf.a("blueprint_sledgehammer", 12, 1, 1, null),
						dtf.a("blueprint_assaultRifle", 15, 1, 1, null),
						dtf.a("blueprint_energyPistol", 20, 1, 1, null),
						dtf.a("blueprint_psionicHeadband", 20, 1, 1, null),
						dtf.a("blueprint_chemicalBolt", 15, 1, 1, null),
						dtf.a("blueprint_shockBolt", 15, 1, 1, null),
						dtf.a("blueprint_shockShuriken", 20, 1, 1, null),
						dtf.a("blueprint_chemicalPistol", 15, 1, 1, null),
						dtf.a("blueprint_chemicalBlobTrap", 15, 1, 1, null),
						dtf.a("blueprint_chemicalAmmo", 15, 1, 1, null),
						dtf.a("blueprint_incendiaryGrenade", 15, 1, 1, null),
						dtf.a("blueprint_gasGrenade", 15, 1, 1, null),
						dtf.a("blueprint_bullets", 15, 1, 1, null),
						dtf.a("blueprint_w2cBullets", 15, 1, 1, null),
						dtf.a("blueprint_jhpBullets", 15, 1, 1, null),
						dtf.a("blueprint_shockBullets", 15, 1, 1, null),
						dtf.a("blueprint_microShrapnelBullets", 15, 1, 1, null),
						dtf.a("blueprint_incendiaryBullets", 15, 1, 1, null),
						dtf.a("blueprint_acidBullets", 15, 1, 1, null),
						dtf.a("blueprint_explosiveBullets", 15, 1, 1, null),
						dtf.a("blueprint_contaminatedBullets", 15, 1, 1, null),
						dtf.a("xpbl_blueprint_stingballGrenade", 50, 1, 1, null),
						dtf.a("xpbl_blueprint_plasmaGrenade", 750, 1, 1, null),
						dtf.a("xpbl_blueprint_plasmaMine", 750, 1, 1, null),
						dtf.a("xpbl_blueprint_spyingEndoscope", 750, 1, 1, null),
						dtf.a("xpbl_blueprint_spear", 80, 1, 1, null),
						dtf.a("xpbl_blueprint_shotgunShells", 15, 1, 1, null),
						dtf.a("xpbl_blueprint_shotgun", 15, 1, 1, null),
						dtf.a("xphw_blueprint_grenadeLauncher", 20, 1, 1, null),
						dtf.a("xphw_blueprint_rocketLauncher", 35, 1, 1, null),
						dtf.a("xphw_blueprint_lightMachineGun", 15, 1, 1, null),
						dtf.a("xphw_blueprint_minigun", 30, 1, 1, null),
						dtf.a("xphw_blueprint_highExplosiveLauncherGrenade", 20, 1, 1, null),
						dtf.a("xphw_blueprint_fragLauncherGrenade", 20, 1, 1, null),
						dtf.a("xphw_blueprint_concussiveLauncherGrenade", 300, 1, 1, null),
						dtf.a("xphw_blueprint_incendiaryLauncherGrenade", 300, 1, 1, null),
						dtf.a("xphw_blueprint_thermobaricLauncherGrenade", 300, 1, 1, null),
						dtf.a("xphw_blueprint_clusterLauncherGrenade", 300, 1, 1, null),
						dtf.a("xphw_blueprint_rocket84HighExplosive", 500, 1, 1, null),
						dtf.a("xphw_blueprint_rocket84Kinetic", 500, 1, 1, null),
						dtf.a("xphw_blueprint_rocket84CaveShaker", 750, 1, 1, null),
						dtf.a("xphw_blueprint_rocket84WhitePhosphorus", 1000, 1, 1, null),
						dtf.a("ammo_bolt", 1, 1, 5, null),
						dtf.a("ammo_serratedBolt", 2, 1, 2, null),
						dtf.a("ammo_burrowerPoisonBolt", 3, 1, 2, null),
						dtf.a("ammo_caveEarPoisonBolt", 15, 1, 2, null),
						dtf.a("ammo_crawlerPoisonBolt", 20, 1, 1, null),
						dtf.a("ammo_tranquilizingBolt", 5, 1, 1, null),
						dtf.a("ammo_shockBolt1", 3, 1, 1, null),
						dtf.a("ammo_shockBolt2", 20, 1, 1, null),
						dtf.a("ammo_incendiaryBolt1", 3, 1, 1, null),
						dtf.a("ammo_incendiaryBolt2", 20, 1, 1, null),
						dtf.a("ammo_acidBolt1", 3, 1, 1, null),
						dtf.a("ammo_5_Std", 2, 1, 6, null),
						dtf.a("ammo_5_JHP", 3, 1, 6, null),
						dtf.a("ammo_5_W2C", 3, 1, 6, null),
						dtf.a("ammo_762_Std", 2, 1, 6, null),
						dtf.a("ammo_762_JHP", 3, 1, 6, null),
						dtf.a("ammo_762_W2C", 3, 1, 6, null),
						dtf.a("ammo_86_Std", 2, 1, 4, null),
						dtf.a("ammo_86_JHP", 3, 1, 4, null),
						dtf.a("ammo_86_W2C", 3, 1, 4, null),
						dtf.a("ammo_9_Std", 2, 1, 4, null),
						dtf.a("ammo_9_JHP", 3, 1, 4, null),
						dtf.a("ammo_9_W2C", 3, 1, 4, null),
						dtf.a("ammo_44_Std", 3, 1, 3, null),
						dtf.a("ammo_44_JHP", 4, 1, 3, null),
						dtf.a("ammo_44_W2C", 4, 1, 3, null),
						dtf.a("ammo_127_Std", 3, 1, 3, null),
						dtf.a("ammo_127_JHP", 4, 1, 3, null),
						dtf.a("ammo_127_W2C", 4, 1, 3, null),
						dtf.a("xpbl_ammo_shotgunShell_6", 1, 1, 4, null),
						dtf.a("xpbl_ammo_shotgunShell_12", 1, 1, 4, null),
						dtf.a("xpbl_ammo_shotgunShell_20", 1, 1, 4, null),
						dtf.a("xpbl_ammo_shotgunShell_3", 30, 1, 3, null),
						dtf.a("xphw_ammo_lgrenade_25_He", 2, 1, 4, null),
						dtf.a("xphw_ammo_lgrenade_25_Frag", 2, 1, 4, null),
						dtf.a("xphw_ammo_lgrenade_40_He", 2, 1, 3, null),
						dtf.a("xphw_ammo_lgrenade_40_Frag", 2, 1, 3, null),
						dtf.a("xphw_ammo_rocket_84_He", 8, 1, 2, null),
						dtf.a("xphw_ammo_rocket_84_Kin", 12, 1, 2, null),
						dtf.a("xphw_ammo_rocket_84_Cs", 40, 1, 1, null),
						dtf.a("ammo_vial_acid_regular", 3, 1, 3, null),
						dtf.a("firecrackerCap", 7, 1, 1, null),
						dtf.a("grenade_frag", 2, 1, 1, null),
						dtf.a("grenade_he", 3, 1, 1, null),
						dtf.a("grenade_emp", 4, 1, 1, null),
						dtf.a("molotovCocktail", 2, 1, 1, null),
						dtf.a("mine_frag", 4, 1, 1, null),
						dtf.a("mine_he", 5, 1, 1, null),
						dtf.a("mine_emp", 6, 1, 1, null),
						dtf.a("acidBlobTrap1", 4, 1, 1, null),
						dtf.a("acidBlobTrap2", 20, 1, 1, null),
						dtf.a("bearTrap", 2, 1, 1, null),
						dtf.a("burrowerPoisonBearTrap", 4, 1, 1, null),
						dtf.a("caveEarPoisonBearTrap", 15, 1, 1, null),
						dtf.a("crawlerPoisonBearTrap", 15, 1, 1, null),
						dtf.a("throwingKnife", 1, 1, 1, null),
						dtf.a("burrowerPoisonThrowingKnife", 3, 1, 1, null),
						dtf.a("caveEarPoisonThrowingKnife", 15, 1, 1, null),
						dtf.a("crawlerPoisonThrowingKnife", 15, 1, 1, null),
						dtf.a("throwingNet", 3, 1, 1, null),
						dtf.a("flare", 2, 1, 2, null),
						dtf.a("lighter", 6, 1, 1, null),
						dtf.a("steel_crowbar", 3, 1, 1, null),
						dtf.a("tungsten_crowbar", 15, 1, 1, null),
						dtf.a("tichrome_crowbar", 15, 1, 1, null),
						dtf.a("superSteel_crowbar", 30, 1, 1, null),
						dtf.a("armor_fireProximitySuit", 10, 1, 1, null),
						dtf.a("armor_blastSuit", 15, 1, 1, null),
						dtf.a("armor_gasMask", 3, 1, 1, null),
						dtf.a("armor_workerSuit", 8, 1, 1, null),
						dtf.a("component_ballisticPanel_reinforcedFabric", 4, 1, 1, null),
						dtf.a("component_ballisticPanel_laminatedFabric", 6, 1, 1, null),
						dtf.a("component_vest_insulated", 4, 1, 1, null),
						dtf.a("component_vest_galvanic", 4, 1, 1, null),
						dtf.a("component_vest_biohazard", 6, 1, 1, null),
						dtf.a("component_vest_sturdy", 4, 1, 1, null),
						dtf.a("component_vest_regenerative", 10, 1, 1, null),
						dtf.a("component_ballisticArmorPlate_ceramicPlate", 4, 1, 1, null),
						dtf.a("component_ballisticArmorPlate_nanocompositePlate", 4, 1, 1, null),
						dtf.a("component_metalArmorEnh_spikes_steel", 3, 1, 2, null),
						dtf.a("component_metalArmorEnh_serratedBlade_steel", 4, 1, 2, null),
						dtf.a("component_metalArmorEnh_spikes_tungstenSteel", 4, 1, 2, null),
						dtf.a("component_metalArmorEnh_serratedBlade_tungstenSteel", 5, 1, 2, null),
						dtf.a("component_metalArmorEnh_spikes_tichrome", 6, 1, 2, null),
						dtf.a("component_metalArmorEnh_serratedBlade_tichrome", 7, 1, 2, null),
						dtf.a("component_gasoline", 1, 1, 1, null),
						dtf.a("component_rocketPropellant", 3, 1, 2, null),
						dtf.a("component_NapalmC", 3, 1, 1, null),
						dtf.a("component_starterMixture", 3, 1, 1, null),
						dtf.a("component_chemicalPistolFrame", 7, 1, 1, null),
						dtf.a("component_AcidCollector", 7, 1, 1, null),
						dtf.a("component_CryogenicCollector", 7, 1, 1, null),
						dtf.a("component_IncendiaryCollector", 7, 1, 1, null),
						dtf.a("component_BlobDispenser", 7, 1, 1, null),
						dtf.a("component_chemicalTrapCase", 5, 1, 1, null),
						dtf.a("xpbl_component_stabilizationWings", 4, 1, 1, null),
						dtf.a("xpbl_component_broadheadBoltTip", 5, 1, 10, null),
						dtf.a("armor_leatherArmor", 5, 1, 1, null),
						dtf.a("armor_tacticalVest", 6, 1, 1, null),
						dtf.a("armor_balaclava", 5, 1, 1, null),
						dtf.a("armor_riotGear", 8, 1, 1, null),
						dtf.a("armor_metalArmor", 10, 1, 1, null),
						dtf.a("armor_metalHelmet", 6, 1, 1, null),
						dtf.a("armor_goggles", 10, 1, 1, null),
						dtf.a("armor_shieldEmitter", 10, 1, 1, null),
						dtf.a("belt_bulletstrap", 7, 1, 1, null),
						dtf.a("xpbl_belt_shellstrap", 9, 1, 1, null),
						dtf.a("belt_launcherGrenadeStrap", 12, 1, 1, null),
						dtf.a("belt_utility", 10, 1, 1, null),
						dtf.a("belt_waistPack", 10, 1, 1, null),
						dtf.a("belt_largeWaistPack", 10, 1, 1, null),
						dtf.a("belt_trappersBelt", 7, 1, 1, null),
						dtf.a("belt_liftingBelt", 9, 1, 1, null),
						dtf.a("belt_catalyzingBelt", 20, 1, 1, null),
						dtf.a("belt_advancedCatalyzingBelt", 30, 1, 1, null),
						dtf.a("xpbl_belt_boltQuiver", 10, 1, 1, null),
						dtf.a("boots", 1, 1, 1, null),
						dtf.a("greaves", 1, 1, 1, null),
						dtf.a("tabiBoots", 4, 1, 1, null),
						dtf.a("caltrops_regular", 2, 1, 1, null),
						dtf.a("caltrops_burrowerPoison", 4, 1, 1, null),
						dtf.a("caltrops_caveEarPoison", 15, 1, 1, null),
						dtf.a("caltrops_crawlerPoison", 20, 1, 1, null),
						dtf.a("mechanicalRepairKit1", 4, 1, 1, null),
						dtf.a("mechanicalRepairKit2", 7, 1, 1, null),
						dtf.a("electronicRepairKit1", 5, 1, 1, null),
						dtf.a("electronicRepairKit2", 8, 1, 1, null),
						dtf.a("patchingKit1", 3, 1, 1, null),
						dtf.a("patchingKit2", 6, 1, 1, null),
						dtf.a("sharpeningStone", 6, 1, 1, null),
						dtf.a("shiv", 25, 1, 1, null),
						dtf.a("boxingGloves", 20, 1, 1, null),
						dtf.a("brassKnuckles", 15, 1, 1, null),
						dtf.a("knifeThrowerGloves", 15, 1, 1, null),
						dtf.a("gUnique_helmet_unprojector", 300, 1, 1, null),
						dtf.a("gUnique_helmet_cyclopsEye", 300, 1, 1, null),
						dtf.a("gUnique_helmet_commandoBelt", 300, 1, 1, null),
						dtf.a("gUnique_boots_jumpingStilts", 300, 1, 1, null)
					};
				case ItemRange.Psi:
					return new List<ezv>
					{
						dtf.a("psiBooster", 1, 1, 1, null),
						dtf.a("psiInhalant", 1, 1, 1, null),
						dtf.a("blueprint_psiBooster", 15, 1, 1, null),
						dtf.a("blueprint_psiInhalant", 15, 1, 1, null),
						dtf.a("blueprint_psiReinvigorator", 15, 1, 1, null),
						dtf.a("blueprint_trance", 15, 1, 1, null),
						dtf.a("xpbl_blueprint_psionicAccelerator", 500, 1, 1, null),
						dtf.a("armor_psionicHeadband", 4, 1, 1, null),
						dtf.a("mentor_NeuralOverload", 11, 1, 1, null),
						dtf.a("mentor_Frighten", 11, 1, 1, null),
						dtf.a("mentor_MentalBreakdown", 11, 1, 1, null),
						dtf.a("mentor_Enrage", 11, 1, 1, null),
						dtf.a("mentor_PsiCognitiveInterruption", 12, 1, 1, null),
						dtf.a("mentor_PseudoSpatialProjection", 13, 1, 1, null),
						dtf.a("mentor_NeurovisualDisruption", 14, 1, 1, null),
						dtf.a("mentor_MotorCognitiveTransference", 14, 1, 1, null),
						dtf.a("mentor_PsychosomaticPredation", 14, 1, 1, null),
						dtf.a("mentor_TelekineticPunch", 11, 1, 1, null),
						dtf.a("mentor_Electrokinesis", 11, 1, 1, null),
						dtf.a("mentor_ForceEmission", 11, 1, 1, null),
						dtf.a("mentor_ForceField", 11, 1, 1, null),
						dtf.a("mentor_TelekineticProxy", 11, 1, 1, null),
						dtf.a("mentor_ElectrokineticImprint", 13, 1, 1, null),
						dtf.a("mentor_Implosion", 14, 1, 1, null),
						dtf.a("mentor_DisruptiveField", 15, 1, 1, null),
						dtf.a("mentor_TelekineticGrounding", 11, 1, 1, null),
						dtf.a("mentor_PsychokineticChain", 16, 1, 1, null),
						dtf.a("mentor_Cryokinesis", 11, 1, 1, null),
						dtf.a("mentor_Pyrokinesis", 11, 1, 1, null),
						dtf.a("mentor_Cryostasis", 11, 1, 1, null),
						dtf.a("mentor_PyrokineticStream", 11, 1, 1, null),
						dtf.a("mentor_ThermodynamicDestabilization", 11, 1, 1, null),
						dtf.a("mentor_CryokineticOrb", 13, 1, 1, null),
						dtf.a("mentor_CryogenicBarrier", 13, 1, 1, null),
						dtf.a("mentor_ExothermicAura", 14, 1, 1, null),
						dtf.a("mentor_CryoShield", 15, 1, 1, null),
						dtf.a("mentor_PlasmaBeam", 40, 1, 1, null),
						dtf.a("xpbl_mentor_TemporalDistorsion", 11, 1, 1, null),
						dtf.a("xpbl_mentor_PsychotemporalDilation", 11, 1, 1, null),
						dtf.a("xpbl_mentor_LimitedTemporalIncrement", 11, 1, 1, null),
						dtf.a("xpbl_mentor_EntropicRecurrence", 11, 1, 1, null),
						dtf.a("xpbl_mentor_PsychotemporalContraction", 11, 1, 1, null),
						dtf.a("xpbl_mentor_TemporaryRewind", 13, 1, 1, null),
						dtf.a("xpbl_mentor_Precognition", 14, 1, 1, null),
						dtf.a("xpbl_mentor_Stasis", 15, 1, 1, null),
						dtf.a("gUnique_helmet_cyclopsEye", 300, 1, 1, null)
					};
				case ItemRange.Blueprints:
					return new List<ezv>
					{
						dtf.a("blueprint_recycleItem", 3, 1, 1, null),
						dtf.a("blueprint_repairKit", 3, 1, 1, null),
						dtf.a("blueprint_healthHypo", 2, 1, 1, null),
						dtf.a("blueprint_advancedHealthHypo", 3, 1, 1, null),
						dtf.a("blueprint_superHealthHypo", 4, 1, 1, null),
						dtf.a("blueprint_adrenalineShot", 3, 1, 1, null),
						dtf.a("blueprint_morphineShot", 3, 1, 1, null),
						dtf.a("blueprint_psiBooster", 2, 1, 1, null),
						dtf.a("blueprint_psiInhalant", 2, 1, 1, null),
						dtf.a("blueprint_psiReinvigorator", 2, 1, 1, null),
						dtf.a("blueprint_grenade", 1, 1, 1, null),
						dtf.a("blueprint_thinGrenadeCase", 1, 1, 1, null),
						dtf.a("blueprint_fragGrenadeCase", 1, 1, 1, null),
						dtf.a("blueprint_thinMineCase", 1, 1, 1, null),
						dtf.a("blueprint_fragMineCase", 1, 1, 1, null),
						dtf.a("blueprint_throwingNet", 1, 1, 1, null),
						dtf.a("blueprint_flashbang", 2, 1, 1, null),
						dtf.a("blueprint_bearTrap", 1, 1, 1, null),
						dtf.a("blueprint_throwingKnives", 1, 1, 1, null),
						dtf.a("blueprint_mine", 1, 1, 1, null),
						dtf.a("blueprint_empGrenade", 3, 1, 1, null),
						dtf.a("blueprint_empMine", 3, 1, 1, null),
						dtf.a("blueprint_cloakingDevice", 5, 1, 1, null),
						dtf.a("blueprint_energyShieldEmitter", 3, 1, 1, null),
						dtf.a("blueprint_goggles", 4, 1, 1, null),
						dtf.a("blueprint_leatherArmor", 1, 1, 1, null),
						dtf.a("blueprint_balaclava", 1, 1, 1, null),
						dtf.a("blueprint_tacticalVest", 2, 1, 1, null),
						dtf.a("blueprint_riotGear", 2, 1, 1, null),
						dtf.a("blueprint_crossbow", 1, 1, 1, null),
						dtf.a("blueprint_pistol", 1, 1, 1, null),
						dtf.a("blueprint_sniper", 4, 1, 1, null),
						dtf.a("blueprint_metalArmor", 4, 1, 1, null),
						dtf.a("blueprint_metalHelmet", 4, 1, 1, null),
						dtf.a("blueprint_boots", 1, 1, 1, null),
						dtf.a("blueprint_greaves", 1, 1, 1, null),
						dtf.a("blueprint_tabiBoots", 1, 1, 1, null),
						dtf.a("blueprint_smg", 3, 1, 1, null),
						dtf.a("blueprint_combatKnife", 1, 1, 1, null),
						dtf.a("blueprint_shiv", 3, 1, 1, null),
						dtf.a("xpbl_blueprint_machete", 1, 1, 1, null),
						dtf.a("blueprint_combatGloves", 1, 1, 1, null),
						dtf.a("blueprint_caltrops", 1, 1, 1, null),
						dtf.a("blueprint_lockpicks", 10, 1, 1, null),
						dtf.a("blueprint_sledgehammer", 2, 1, 1, null),
						dtf.a("blueprint_assaultRifle", 3, 1, 1, null),
						dtf.a("blueprint_energyPistol", 5, 1, 1, null),
						dtf.a("blueprint_psionicHeadband", 5, 1, 1, null),
						dtf.a("blueprint_chemicalPistol", 5, 1, 1, null),
						dtf.a("blueprint_chemicalBlobTrap", 3, 1, 1, null),
						dtf.a("blueprint_chemicalAmmo", 4, 1, 1, null),
						dtf.a("blueprint_extractToxin", 1, 1, 1, null),
						dtf.a("blueprint_processPlant", 1, 1, 1, null),
						dtf.a("blueprint_chemicalBolt", 1, 1, 1, null),
						dtf.a("blueprint_mechanicalBolt", 1, 1, 1, null),
						dtf.a("blueprint_shockBolt", 1, 1, 1, null),
						dtf.a("blueprint_incendiaryBolt", 1, 1, 1, null),
						dtf.a("blueprint_shockShuriken", 5, 1, 1, null),
						dtf.a("blueprint_irongut", 4, 1, 1, null),
						dtf.a("blueprint_trance", 4, 1, 1, null),
						dtf.a("blueprint_aegis", 4, 1, 1, null),
						dtf.a("blueprint_focusStim", 4, 1, 1, null),
						dtf.a("blueprint_jumpingBean", 4, 1, 1, null),
						dtf.a("blueprint_bullhead", 4, 1, 1, null),
						dtf.a("blueprint_incendiaryGrenade", 1, 1, 1, null),
						dtf.a("blueprint_gasGrenade", 1, 1, 1, null),
						dtf.a("blueprint_bullets", 1, 1, 1, null),
						dtf.a("blueprint_w2cBullets", 1, 1, 1, null),
						dtf.a("blueprint_jhpBullets", 1, 1, 1, null),
						dtf.a("blueprint_shockBullets", 2, 1, 1, null),
						dtf.a("blueprint_microShrapnelBullets", 2, 1, 1, null),
						dtf.a("blueprint_incendiaryBullets", 2, 1, 1, null),
						dtf.a("blueprint_acidBullets", 2, 1, 1, null),
						dtf.a("blueprint_explosiveBullets", 2, 1, 1, null),
						dtf.a("blueprint_contaminatedBullets", 2, 1, 1, null),
						dtf.a("xpbl_blueprint_stingballGrenade", 12, 1, 1, null),
						dtf.a("xpbl_blueprint_plasmaGrenade", 50, 1, 1, null),
						dtf.a("xpbl_blueprint_plasmaMine", 50, 1, 1, null),
						dtf.a("xpbl_blueprint_spyingEndoscope", 50, 1, 1, null),
						dtf.a("xpbl_blueprint_broadheadBolt", 1, 1, 1, null),
						dtf.a("xpbl_blueprint_psionicAccelerator", 50, 1, 1, null),
						dtf.a("xpbl_blueprint_coagulationShot", 50, 1, 1, null),
						dtf.a("xpbl_blueprint_hypercerebrix", 50, 1, 1, null),
						dtf.a("xpbl_blueprint_twitch", 50, 1, 1, null),
						dtf.a("xpbl_blueprint_thirdEye", 50, 1, 1, null),
						dtf.a("xpbl_blueprint_spear", 10, 1, 1, null),
						dtf.a("xpbl_blueprint_shotgunShells", 2, 1, 1, null),
						dtf.a("xpbl_blueprint_shotgun", 3, 1, 1, null),
						dtf.a("xphw_blueprint_grenadeLauncher", 4, 1, 1, null),
						dtf.a("xphw_blueprint_rocketLauncher", 7, 1, 1, null),
						dtf.a("xphw_blueprint_lightMachineGun", 3, 1, 1, null),
						dtf.a("xphw_blueprint_minigun", 6, 1, 1, null),
						dtf.a("xphw_blueprint_highExplosiveLauncherGrenade", 3, 1, 1, null),
						dtf.a("xphw_blueprint_fragLauncherGrenade", 3, 1, 1, null),
						dtf.a("xphw_blueprint_concussiveLauncherGrenade", 7, 1, 1, null),
						dtf.a("xphw_blueprint_incendiaryLauncherGrenade", 7, 1, 1, null),
						dtf.a("xphw_blueprint_thermobaricLauncherGrenade", 10, 1, 1, null),
						dtf.a("xphw_blueprint_clusterLauncherGrenade", 10, 1, 1, null),
						dtf.a("xphw_blueprint_rocket84HighExplosive", 15, 1, 1, null),
						dtf.a("xphw_blueprint_rocket84Kinetic", 15, 1, 1, null),
						dtf.a("xphw_blueprint_rocket84CaveShaker", 25, 1, 1, null),
						dtf.a("xphw_blueprint_rocket84WhitePhosphorus", 50, 1, 1, null)
					};
				case ItemRange.Explosives:
					return new List<ezv>
					{
						dtf.a("component_fragGrenadeCase", 5, 1, 1, null),
						dtf.a("component_thinGrenadeCase", 5, 1, 1, null),
						dtf.a("component_fragMineCase", 7, 1, 1, null),
						dtf.a("component_thinMineCase", 7, 1, 1, null),
						dtf.a("component_empMineCase", 10, 1, 1, null),
						dtf.a("xpbl_component_plasmaMineCase", 20, 1, 1, null),
						dtf.a("component_rawTnt", 7, 1, 1, null),
						dtf.a("component_hexogen", 9, 1, 1, null),
						dtf.a("firecrackerCap", 7, 1, 1, null),
						dtf.a("flashbang", 4, 1, 1, null),
						dtf.a("grenade_frag", 1, 1, 1, null),
						dtf.a("grenade_he", 2, 1, 1, null),
						dtf.a("grenade_emp", 5, 1, 1, null),
						dtf.a("molotovCocktail", 1, 1, 1, null),
						dtf.a("mine_frag", 3, 1, 1, null),
						dtf.a("mine_he", 4, 1, 1, null),
						dtf.a("mine_emp", 7, 1, 1, null),
						dtf.a("blueprint_grenade", 10, 1, 1, null),
						dtf.a("blueprint_thinGrenadeCase", 15, 1, 1, null),
						dtf.a("blueprint_fragGrenadeCase", 15, 1, 1, null),
						dtf.a("blueprint_thinMineCase", 15, 1, 1, null),
						dtf.a("blueprint_fragMineCase", 15, 1, 1, null),
						dtf.a("blueprint_flashbang", 12, 1, 1, null),
						dtf.a("blueprint_mine", 10, 1, 1, null),
						dtf.a("blueprint_empGrenade", 15, 1, 1, null),
						dtf.a("blueprint_empMine", 15, 1, 1, null),
						dtf.a("xpbl_blueprint_stingballGrenade", 50, 1, 1, null),
						dtf.a("xpbl_blueprint_plasmaGrenade", 200, 1, 1, null),
						dtf.a("xpbl_blueprint_plasmaMine", 200, 1, 1, null),
						dtf.a("component_gasoline", 1, 1, 1, null),
						dtf.a("component_rocketPropellant", 3, 1, 2, null),
						dtf.a("component_magnesiumPowder", 2, 1, 1, null),
						dtf.a("component_whitePhosphorus", 6, 1, 1, null),
						dtf.a("component_NapalmC", 3, 1, 1, null),
						dtf.a("component_starterMixture", 3, 1, 1, null)
					};
				case ItemRange.Common:
				{
					List<ezv> list = dtf.a();
					list.Add(dtf.a("currency_sc", 2, 1, 3, null));
					return list;
				}
				case ItemRange.Armors:
					return new List<ezv>
					{
						dtf.a("armor_leatherArmor", 1, 1, 1, null),
						dtf.a("armor_tacticalVest", 1, 1, 1, null),
						dtf.a("armor_balaclava", 1, 1, 1, null),
						dtf.a("armor_riotGear", 3, 1, 1, null),
						dtf.a("armor_metalArmor", 4, 1, 1, null),
						dtf.a("armor_metalHelmet", 2, 1, 1, null),
						dtf.a("belt_utility", 4, 1, 1, null),
						dtf.a("belt_waistPack", 8, 1, 1, null),
						dtf.a("belt_largeWaistPack", 8, 1, 1, null),
						dtf.a("belt_bulletstrap", 4, 1, 1, null),
						dtf.a("xpbl_belt_shellstrap", 6, 1, 1, null),
						dtf.a("belt_launcherGrenadeStrap", 7, 1, 1, null),
						dtf.a("belt_trappersBelt", 4, 1, 1, null),
						dtf.a("belt_groinGuard", 6, 1, 1, null),
						dtf.a("belt_liftingBelt", 4, 1, 1, null),
						dtf.a("belt_vigorousBelt", 4, 1, 1, null),
						dtf.a("xpbl_belt_boltQuiver", 6, 1, 1, null),
						dtf.a("armor_shieldEmitter", 5, 1, 1, null),
						dtf.a("boots", 1, 1, 1, null),
						dtf.a("поножи", 1, 1, 1, null),
						dtf.a("tabiBoots", 4, 1, 1, null),
						dtf.a("armor_fireProximitySuit", 10, 1, 1, null),
						dtf.a("armor_blastSuit", 15, 1, 1, null),
						dtf.a("armor_gasMask", 6, 1, 1, null),
						dtf.a("gUnique_boots_jumpingStilts", 300, 1, 1, null)
					};
				case ItemRange.Device_Utility:
					return new List<ezv>
					{
						dtf.a("lockpick", 1, 1, 1, null),
						dtf.a("electricTorch", 3, 1, 1, null),
						dtf.a("armor_miningHelmet", 10, 1, 1, null),
						dtf.a("haxxor", 4, 1, 1, null),
						dtf.a("xpbl_hotwiringKit", 6, 1, 1, null),
						dtf.a("armor_gasMask", 7, 1, 1, null),
						dtf.a("steel_crowbar", 2, 1, 1, null),
						dtf.a("tungsten_crowbar", 15, 1, 1, null),
						dtf.a("tichrome_crowbar", 15, 1, 1, null),
						dtf.a("superSteel_crowbar", 30, 1, 1, null),
						dtf.a("throwingNet", 2, 1, 1, null),
						dtf.a("flare", 1, 1, 2, null),
						dtf.a("lighter", 3, 1, 1, null),
						dtf.a("belt_utility", 4, 1, 1, null),
						dtf.a("belt_waistPack", 7, 1, 1, null),
						dtf.a("belt_largeWaistPack", 7, 1, 1, null),
						dtf.a("belt_trappersBelt", 4, 1, 1, null),
						dtf.a("belt_vigorousBelt", 5, 1, 1, null),
						dtf.a("caltrops_regular", 1, 1, 1, null),
						dtf.a("caltrops_burrowerPoison", 3, 1, 1, null),
						dtf.a("caltrops_caveEarPoison", 15, 1, 1, null),
						dtf.a("caltrops_crawlerPoison", 20, 1, 1, null),
						dtf.a("bearTrap", 2, 1, 1, null),
						dtf.a("burrowerPoisonBearTrap", 4, 1, 1, null),
						dtf.a("caveEarPoisonBearTrap", 15, 1, 1, null),
						dtf.a("crawlerPoisonBearTrap", 15, 1, 1, null),
						dtf.a("scraps_electronic", 5, 1, 1, null),
						dtf.a("mechanicalRepairKit1", 4, 1, 1, null),
						dtf.a("mechanicalRepairKit2", 7, 1, 1, null),
						dtf.a("electronicRepairKit1", 5, 1, 1, null),
						dtf.a("electronicRepairKit2", 8, 1, 1, null),
						dtf.a("sharpeningStone", 6, 1, 1, null),
						dtf.a("armor_goggles", 3, 1, 1, null),
						dtf.a("armor_psionicHeadband", 7, 1, 1, null),
						dtf.a("armor_shieldEmitter", 5, 1, 1, null),
						dtf.a("blueprint_lockpicks", 30, 1, 1, null),
						dtf.a("gUnique_helmet_unprojector", 350, 1, 1, null),
						dtf.a("gUnique_helmet_commandoBelt", 350, 1, 1, null),
						dtf.a("gUnique_boots_jumpingStilts", 350, 1, 1, null)
					};
				case ItemRange.Device_Explosives:
					return new List<ezv>();
				case ItemRange.Device_Automatons:
				case (ItemRange)26:
					break;
				case ItemRange.Documents:
					return new List<ezv>();
				case ItemRange.Food:
					return new List<ezv>
					{
						dtf.a("food_baconCheeseSandwich", 1, 1, 1, null),
						dtf.a("food_burrowerBurger", 3, 1, 1, null),
						dtf.a("food_cannedFish", 1, 1, 1, null),
						dtf.a("food_cannedMeat", 1, 1, 1, null),
						dtf.a("food_cannedMushrooms", 1, 1, 1, null),
						dtf.a("food_cannedStew", 1, 1, 1, null),
						dtf.a("food_caveHopperSteak", 1, 1, 1, null),
						dtf.a("food_cookedBurrowerEgg", 3, 1, 1, null),
						dtf.a("food_coreChips", 2, 1, 1, null),
						dtf.a("food_hardcoreChips", 3, 1, 1, null),
						dtf.a("food_eelSandwich", 2, 1, 1, null),
						dtf.a("food_friedSiphonerTongue", 4, 1, 1, null),
						dtf.a("food_mushroomSalad", 1, 1, 1, null),
						dtf.a("food_pentapusBarbecue", 2, 1, 1, null),
						dtf.a("food_pickledMindshrooms", 8, 1, 1, null),
						dtf.a("food_psiBeetleBrainSoup", 4, 1, 1, null),
						dtf.a("food_rathoundBarbeque", 1, 1, 1, null),
						dtf.a("food_stuffedBat", 1, 1, 1, null),
						dtf.a("food_underPie", 2, 1, 1, null)
					};
				case ItemRange.EnergyCells:
					return new List<ezv>
					{
						dtf.a("battery_scLi", 1, 1, 6, null),
						dtf.a("battery_fusion", 2, 1, 4, null),
						dtf.a("battery_plasma", 3, 1, 2, null),
						dtf.a("battery_greaterFusion", 6, 1, 1, null)
					};
				case ItemRange.Ammo:
					return new List<ezv>
					{
						dtf.a("ammo_bolt", 1, 2, 6, null),
						dtf.a("ammo_serratedBolt", 2, 1, 2, null),
						dtf.a("ammo_burrowerPoisonBolt", 3, 1, 2, null),
						dtf.a("ammo_caveEarPoisonBolt", 15, 1, 2, null),
						dtf.a("ammo_crawlerPoisonBolt", 15, 1, 1, null),
						dtf.a("ammo_tranquilizingBolt", 5, 1, 1, null),
						dtf.a("ammo_shockBolt1", 3, 1, 1, null),
						dtf.a("ammo_shockBolt2", 20, 1, 1, null),
						dtf.a("ammo_incendiaryBolt1", 3, 1, 1, null),
						dtf.a("ammo_incendiaryBolt2", 20, 1, 1, null),
						dtf.a("ammo_acidBolt1", 3, 1, 1, null),
						dtf.a("ammo_5_Std", 1, 1, 6, null),
						dtf.a("ammo_5_JHP", 2, 1, 6, null),
						dtf.a("ammo_5_W2C", 2, 1, 6, null),
						dtf.a("ammo_762_Std", 1, 1, 6, null),
						dtf.a("ammo_762_JHP", 2, 1, 6, null),
						dtf.a("ammo_762_W2C", 2, 1, 6, null),
						dtf.a("ammo_86_Std", 1, 1, 4, null),
						dtf.a("ammo_86_JHP", 2, 1, 4, null),
						dtf.a("ammo_86_W2C", 2, 1, 4, null),
						dtf.a("ammo_9_Std", 1, 1, 4, null),
						dtf.a("ammo_9_JHP", 2, 1, 4, null),
						dtf.a("ammo_9_W2C", 2, 1, 4, null),
						dtf.a("ammo_44_Std", 2, 1, 3, null),
						dtf.a("ammo_44_JHP", 3, 1, 3, null),
						dtf.a("ammo_44_W2C", 3, 1, 3, null),
						dtf.a("ammo_127_Std", 2, 1, 3, null),
						dtf.a("ammo_127_JHP", 3, 1, 3, null),
						dtf.a("ammo_127_W2C", 3, 1, 3, null),
						dtf.a("xpbl_ammo_shotgunShell_6", 1, 2, 8, null),
						dtf.a("xpbl_ammo_shotgunShell_12", 1, 2, 8, null),
						dtf.a("xpbl_ammo_shotgunShell_20", 1, 2, 8, null),
						dtf.a("xpbl_ammo_shotgunShell_3", 20, 1, 3, null),
						dtf.a("xphw_ammo_lgrenade_25_He", 2, 1, 7, null),
						dtf.a("xphw_ammo_lgrenade_25_Frag", 2, 1, 7, null),
						dtf.a("xphw_ammo_lgrenade_40_He", 2, 1, 5, null),
						dtf.a("xphw_ammo_lgrenade_40_Frag", 2, 1, 5, null),
						dtf.a("xphw_ammo_rocket_84_He", 4, 1, 2, null),
						dtf.a("xphw_ammo_rocket_84_Kin", 10, 1, 2, null),
						dtf.a("xphw_ammo_rocket_84_Cs", 30, 1, 1, null),
						dtf.a("grenade_frag", 5, 1, 1, null),
						dtf.a("grenade_he", 6, 1, 1, null),
						dtf.a("grenade_emp", 8, 1, 1, null),
						dtf.a("molotovCocktail", 5, 1, 1, null),
						dtf.a("ammo_vial_acid_regular", 6, 1, 3, null),
						dtf.a("caltrops_regular", 3, 1, 1, null),
						dtf.a("caltrops_burrowerPoison", 5, 1, 1, null),
						dtf.a("caltrops_caveEarPoison", 15, 1, 1, null),
						dtf.a("caltrops_crawlerPoison", 20, 1, 1, null),
						dtf.a("throwingKnife", 1, 1, 1, null),
						dtf.a("burrowerPoisonThrowingKnife", 3, 1, 1, null),
						dtf.a("caveEarPoisonThrowingKnife", 15, 1, 1, null),
						dtf.a("crawlerPoisonThrowingKnife", 15, 1, 1, null)
					};
				case ItemRange.Grenades:
					return new List<ezv>
					{
						dtf.a("flashbang", 5, 1, 1, null),
						dtf.a("grenade_frag", 1, 1, 1, null),
						dtf.a("grenade_he", 2, 1, 1, null),
						dtf.a("grenade_emp", 5, 1, 1, null),
						dtf.a("molotovCocktail", 3, 1, 1, null)
					};
				case ItemRange.Traps:
					return new List<ezv>
					{
						dtf.a("mine_frag", 1, 1, 1, null),
						dtf.a("mine_he", 1, 1, 1, null),
						dtf.a("mine_emp", 3, 1, 1, null),
						dtf.a("acidBlobTrap1", 3, 1, 1, null),
						dtf.a("acidBlobTrap2", 20, 1, 1, null),
						dtf.a("caltrops_regular", 3, 1, 1, null),
						dtf.a("caltrops_burrowerPoison", 5, 1, 1, null),
						dtf.a("caltrops_caveEarPoison", 15, 1, 1, null),
						dtf.a("caltrops_crawlerPoison", 20, 1, 1, null),
						dtf.a("bearTrap", 1, 1, 1, null),
						dtf.a("burrowerPoisonBearTrap", 3, 1, 1, null),
						dtf.a("caveEarPoisonBearTrap", 12, 1, 1, null),
						dtf.a("crawlerPoisonBearTrap", 15, 1, 1, null)
					};
				case ItemRange.FirearmAmmo:
					return new List<ezv>
					{
						dtf.a("ammo_5_Std", 1, 1, 6, null),
						dtf.a("ammo_5_JHP", 2, 1, 6, null),
						dtf.a("ammo_5_W2C", 2, 1, 6, null),
						dtf.a("ammo_762_Std", 1, 1, 6, null),
						dtf.a("ammo_762_JHP", 2, 1, 6, null),
						dtf.a("ammo_762_W2C", 2, 1, 6, null),
						dtf.a("ammo_86_Std", 1, 1, 4, null),
						dtf.a("ammo_86_JHP", 2, 1, 4, null),
						dtf.a("ammo_86_W2C", 2, 1, 4, null),
						dtf.a("ammo_9_Std", 1, 1, 4, null),
						dtf.a("ammo_9_JHP", 2, 1, 4, null),
						dtf.a("ammo_9_W2C", 2, 1, 4, null),
						dtf.a("ammo_44_Std", 2, 1, 3, null),
						dtf.a("ammo_44_JHP", 3, 1, 3, null),
						dtf.a("ammo_44_W2C", 3, 1, 3, null),
						dtf.a("ammo_127_Std", 2, 1, 3, null),
						dtf.a("ammo_127_JHP", 3, 1, 3, null),
						dtf.a("ammo_127_W2C", 3, 1, 3, null),
						dtf.a("xpbl_ammo_shotgunShell_6", 1, 2, 8, null),
						dtf.a("xpbl_ammo_shotgunShell_12", 1, 2, 8, null),
						dtf.a("xpbl_ammo_shotgunShell_20", 1, 2, 8, null),
						dtf.a("xpbl_ammo_shotgunShell_3", 20, 1, 3, null),
						dtf.a("xphw_ammo_lgrenade_25_He", 2, 2, 7, null),
						dtf.a("xphw_ammo_lgrenade_25_Frag", 2, 2, 7, null),
						dtf.a("xphw_ammo_lgrenade_40_He", 2, 2, 5, null),
						dtf.a("xphw_ammo_lgrenade_40_Frag", 2, 2, 5, null),
						dtf.a("xphw_ammo_rocket_84_He", 8, 1, 2, null),
						dtf.a("xphw_ammo_rocket_84_Kin", 12, 1, 2, null),
						dtf.a("xphw_ammo_rocket_84_Cs", 40, 1, 1, null)
					};
				case ItemRange.SpecialFirearmAmmo:
					return new List<ezv>
					{
						dtf.a("ammo_5_JHP", 2, 1, 6, null),
						dtf.a("ammo_5_W2C", 2, 1, 6, null),
						dtf.a("ammo_762_JHP", 2, 1, 6, null),
						dtf.a("ammo_762_W2C", 2, 1, 6, null),
						dtf.a("ammo_86_JHP", 2, 1, 4, null),
						dtf.a("ammo_86_W2C", 2, 1, 4, null),
						dtf.a("ammo_9_JHP", 2, 1, 4, null),
						dtf.a("ammo_9_W2C", 2, 1, 4, null),
						dtf.a("ammo_44_JHP", 3, 1, 3, null),
						dtf.a("ammo_44_W2C", 3, 1, 3, null),
						dtf.a("ammo_127_JHP", 3, 1, 3, null),
						dtf.a("ammo_127_W2C", 3, 1, 3, null),
						dtf.a("xpbl_ammo_shotgunShell_3", 20, 1, 3, null)
					};
				case ItemRange.ThrowingKnives:
					return new List<ezv>
					{
						dtf.a("throwingKnife", 1, 1, 1, null),
						dtf.a("burrowerPoisonThrowingKnife", 3, 1, 1, null),
						dtf.a("caveEarPoisonThrowingKnife", 15, 1, 1, null),
						dtf.a("crawlerPoisonThrowingKnife", 15, 1, 1, null)
					};
				case ItemRange.PsionicMentors:
					return new List<ezv>
					{
						dtf.a("mentor_NeuralOverload", 1, 1, 1, null),
						dtf.a("mentor_Frighten", 1, 1, 1, null),
						dtf.a("mentor_MentalBreakdown", 1, 1, 1, null),
						dtf.a("mentor_Enrage", 1, 1, 1, null),
						dtf.a("mentor_PsiCognitiveInterruption", 2, 1, 1, null),
						dtf.a("mentor_PseudoSpatialProjection", 2, 1, 1, null),
						dtf.a("mentor_NeurovisualDisruption", 3, 1, 1, null),
						dtf.a("mentor_MotorCognitiveTransference", 3, 1, 1, null),
						dtf.a("mentor_PsychosomaticPredation", 3, 1, 1, null),
						dtf.a("mentor_TelekineticPunch", 1, 1, 1, null),
						dtf.a("mentor_Electrokinesis", 1, 1, 1, null),
						dtf.a("mentor_ForceEmission", 1, 1, 1, null),
						dtf.a("mentor_ForceField", 1, 1, 1, null),
						dtf.a("mentor_TelekineticProxy", 1, 1, 1, null),
						dtf.a("mentor_ElectrokineticImprint", 2, 1, 1, null),
						dtf.a("mentor_Implosion", 3, 1, 1, null),
						dtf.a("mentor_DisruptiveField", 2, 1, 1, null),
						dtf.a("mentor_TelekineticGrounding", 1, 1, 1, null),
						dtf.a("mentor_PsychokineticChain", 3, 1, 1, null),
						dtf.a("mentor_Cryokinesis", 1, 1, 1, null),
						dtf.a("mentor_Pyrokinesis", 1, 1, 1, null),
						dtf.a("mentor_Cryostasis", 1, 1, 1, null),
						dtf.a("mentor_PyrokineticStream", 1, 1, 1, null),
						dtf.a("mentor_ThermodynamicDestabilization", 1, 1, 1, null),
						dtf.a("mentor_CryokineticOrb", 1, 1, 1, null),
						dtf.a("mentor_CryogenicBarrier", 1, 1, 1, null),
						dtf.a("mentor_ExothermicAura", 2, 1, 1, null),
						dtf.a("mentor_CryoShield", 1, 1, 1, null),
						dtf.a("mentor_PlasmaBeam", 6, 1, 1, null),
						dtf.a("xpbl_mentor_TemporalDistorsion", 1, 1, 1, null),
						dtf.a("xpbl_mentor_PsychotemporalDilation", 1, 1, 1, null),
						dtf.a("xpbl_mentor_LimitedTemporalIncrement", 1, 1, 1, null),
						dtf.a("xpbl_mentor_EntropicRecurrence", 1, 1, 1, null),
						dtf.a("xpbl_mentor_PsychotemporalContraction", 1, 1, 1, null),
						dtf.a("xpbl_mentor_TemporaryRewind", 2, 1, 1, null),
						dtf.a("xpbl_mentor_Precognition", 2, 1, 1, null),
						dtf.a("xpbl_mentor_Stasis", 3, 1, 1, null)
					};
				case ItemRange.Drinks:
					return new List<ezv>
					{
						dtf.a("drink_mushroomBrew", 1, 1, 1, null),
						dtf.a("drink_rootSoda", 1, 1, 1, null)
					};
				case ItemRange.Seashell:
					return new List<ezv>
					{
						dtf.a("xpbl_component_clamMeat", 1, 1, 1, null),
						dtf.a("xpbl_component_rottenClamMeat", 8, 1, 1, null),
						dtf.a("xpbl_luxury_pearl", 100, 1, 1, null)
					};
				case ItemRange.GiantSpiderCocoon:
					return new List<ezv>
					{
						dtf.a("component_fish_blueEel", 1, 1, 1, null),
						dtf.a("component_fish_slackjaw", 1, 1, 1, null),
						dtf.a("xpbl_component_fish_frogfish", 3, 1, 1, null),
						dtf.a("xpbl_component_fish_giantHatchetfish", 2, 1, 1, null),
						dtf.a("xpbl_component_fish_redLippedBatfish", 5, 1, 1, null),
						dtf.a("component_bio_insectoidSalivarium", 1, 1, 1, null),
						dtf.a("component_bio_animalHeart", 1, 1, 1, null),
						dtf.a("xpbl_component_bio_giantCrabCarapace", 2, 1, 1, null),
						dtf.a("xpbl_component_rottenClamMeat", 3, 1, 1, null),
						dtf.a("xpbl_component_bio_giantCreeperGland", 5, 1, 1, null)
					};
				case ItemRange.Medical_FirstAid:
					return new List<ezv>
					{
						dtf.a("psiBooster", 2, 1, 1, null),
						dtf.a("psiInhalant", 2, 1, 1, null),
						dtf.a("healthHypo", 1, 1, 1, null),
						dtf.a("advancedHealthHypo", 2, 1, 1, null),
						dtf.a("bandage", 1, 1, 1, null),
						dtf.a("antidote", 3, 1, 1, null),
						dtf.a("adrenalineShot", 3, 1, 1, null),
						dtf.a("morphineShot", 7, 1, 1, null),
						dtf.a("irongut", 20, 1, 1, null),
						dtf.a("trance", 20, 1, 1, null),
						dtf.a("aegis", 20, 1, 1, null),
						dtf.a("focusStim", 20, 1, 1, null),
						dtf.a("jumpingBean", 20, 1, 1, null)
					};
				case ItemRange.Luxury:
					return new List<ezv>
					{
						dtf.a("luxury_goldRing", 1, 1, 1, null),
						dtf.a("luxury_amberStoneEarrings", 3, 1, 1, null),
						dtf.a("luxury_backPendantNecklace", 1, 1, 1, null),
						dtf.a("luxury_ceramicWatch", 3, 1, 1, null),
						dtf.a("luxury_palladiumLeglet", 5, 1, 1, null),
						dtf.a("luxury_palmBracelet", 10, 1, 1, null),
						dtf.a("luxury_niobiumPiercingSet", 15, 1, 1, null),
						dtf.a("luxury_tiChromeHairClip", 100, 1, 1, null)
					};
				case ItemRange.SpecialBolts:
					return new List<ezv>
					{
						dtf.a("ammo_incendiaryBolt1", 2, 1, 2, null),
						dtf.a("ammo_incendiaryBolt2", 20, 1, 2, null),
						dtf.a("ammo_incendiaryBolt3", 200, 1, 1, null),
						dtf.a("ammo_serratedBolt", 2, 1, 2, null),
						dtf.a("ammo_acidBolt1", 15, 1, 2, null),
						dtf.a("ammo_shockBolt1", 2, 1, 2, null),
						dtf.a("ammo_shockBolt2", 20, 1, 2, null),
						dtf.a("ammo_shockBolt3", 200, 1, 1, null),
						dtf.a("ammo_burrowerPoisonBolt", 3, 1, 2, null),
						dtf.a("ammo_caveEarPoisonBolt", 15, 1, 2, null),
						dtf.a("ammo_crawlerPoisonBolt", 50, 1, 1, null),
						dtf.a("ammo_tranquilizingBolt", 5, 1, 1, null)
					};
				case ItemRange.LauncherGrenades:
					return new List<ezv>
					{
						dtf.a("xphw_ammo_lgrenade_25_He", 1, 2, 7, null),
						dtf.a("xphw_ammo_lgrenade_25_Frag", 1, 2, 7, null),
						dtf.a("xphw_ammo_lgrenade_40_He", 1, 2, 5, null),
						dtf.a("xphw_ammo_lgrenade_40_Frag", 1, 2, 5, null)
					};
				case ItemRange.Rockets:
					return new List<ezv>
					{
						dtf.a("xphw_ammo_rocket_84_He", 1, 1, 2, null),
						dtf.a("xphw_ammo_rocket_84_Kin", 3, 1, 2, null),
						dtf.a("xphw_ammo_rocket_84_Cs", 20, 1, 1, null)
					};
				default:
					switch (A_0)
					{
					case ItemRange.Food_Junky:
						return new List<ezv>
						{
							dtf.a("food_burrowerBurger", 3, 1, 1, null),
							dtf.a("food_caveHopperSteak", 1, 1, 1, null),
							dtf.a("food_cookedBurrowerEgg", 3, 1, 1, null),
							dtf.a("food_eelSandwich", 2, 1, 1, null),
							dtf.a("food_friedSiphonerTongue", 4, 1, 1, null),
							dtf.a("food_pentapusBarbecue", 2, 1, 1, null),
							dtf.a("food_rathoundBarbeque", 1, 1, 1, null),
							dtf.a("food_stuffedBat", 1, 1, 1, null)
						};
					case ItemRange.Food_Snacks:
						return new List<ezv>
						{
							dtf.a("food_coreChips", 2, 1, 1, null),
							dtf.a("food_hardcoreChips", 3, 1, 1, null)
						};
					case ItemRange.Food_Sea:
						return new List<ezv>
						{
							dtf.a("food_eelSandwich", 2, 1, 1, null),
							dtf.a("food_friedSiphonerTongue", 4, 1, 1, null),
							dtf.a("food_pentapusBarbecue", 2, 1, 1, null)
						};
					case ItemRange.Food_Canned:
						return new List<ezv>
						{
							dtf.a("food_cannedFish", 1, 1, 1, null),
							dtf.a("food_cannedMeat", 1, 1, 1, null),
							dtf.a("food_cannedMushrooms", 1, 1, 1, null),
							dtf.a("food_cannedStew", 1, 1, 1, null)
						};
					case ItemRange.Food_Tchortists:
						return new List<ezv>
						{
							dtf.a("food_baconCheeseSandwich", 1, 1, 1, null),
							dtf.a("food_burrowerBurger", 3, 1, 1, null),
							dtf.a("food_cannedFish", 1, 1, 1, null),
							dtf.a("food_cannedMeat", 1, 1, 1, null),
							dtf.a("food_cannedMushrooms", 1, 1, 1, null),
							dtf.a("food_cannedStew", 1, 1, 1, null),
							dtf.a("food_caveHopperSteak", 1, 1, 1, null),
							dtf.a("food_coreChips", 2, 1, 1, null),
							dtf.a("food_hardcoreChips", 3, 1, 1, null),
							dtf.a("food_friedSiphonerTongue", 4, 1, 1, null),
							dtf.a("food_mushroomSalad", 1, 1, 1, null),
							dtf.a("food_pickledMindshrooms", 8, 1, 1, null),
							dtf.a("food_psiBeetleBrainSoup", 4, 1, 1, null),
							dtf.a("food_rathoundBarbeque", 1, 1, 1, null),
							dtf.a("food_stuffedBat", 1, 1, 1, null),
							dtf.a("food_underPie", 2, 1, 1, null)
						};
					default:
						switch (A_0)
						{
						case ItemRange.Weapons_Melee:
							return new List<ezv>
							{
								dtf.a("knife", 1, 1, 1, null),
								dtf.a("gloves", 2, 1, 1, null),
								dtf.a("sledgehammer", 2, 1, 1, null),
								dtf.a("steel_crowbar", 25, 1, 1, null),
								dtf.a("tungsten_crowbar", 100, 1, 1, null),
								dtf.a("tichrome_crowbar", 100, 1, 1, null),
								dtf.a("superSteel_crowbar", 200, 1, 1, null),
								dtf.a("shiv", 25, 1, 1, null),
								dtf.a("brassKnuckles", 25, 1, 1, null),
								dtf.a("knifeThrowerGloves", 25, 1, 1, null),
								dtf.a("xpbl_spear", 5, 1, 1, null),
								dtf.a("xpbl_machete", 3, 1, 1, null),
								dtf.a("xpbl_javelin", 8, 1, 1, null)
							};
						case ItemRange.Weapons_Melee_Blunt:
							return new List<ezv>
							{
								dtf.a("gloves", 2, 1, 1, null),
								dtf.a("sledgehammer", 2, 1, 1, null),
								dtf.a("steel_crowbar", 25, 1, 1, null),
								dtf.a("tungsten_crowbar", 100, 1, 1, null),
								dtf.a("tichrome_crowbar", 100, 1, 1, null),
								dtf.a("superSteel_crowbar", 200, 1, 1, null),
								dtf.a("brassKnuckles", 25, 1, 1, null)
							};
						case ItemRange.Weapons_Melee_Bladed:
							return new List<ezv>
							{
								dtf.a("knife", 1, 1, 1, null),
								dtf.a("shiv", 25, 1, 1, null),
								dtf.a("xpbl_spear", 5, 1, 1, null),
								dtf.a("xpbl_machete", 3, 1, 1, null),
								dtf.a("xpbl_javelin", 10, 1, 1, null)
							};
						}
						break;
					}
					break;
				}
			}
			else
			{
				if (A_0 == ItemRange.Weapons_Energy)
				{
					return new List<ezv>
					{
						dtf.a("energyPistol", 5, 1, 1, null)
					};
				}
				switch (A_0)
				{
				case ItemRange.Blueprints_Medical:
					return new List<ezv>
					{
						dtf.a("blueprint_healthHypo", 1, 1, 1, null),
						dtf.a("blueprint_advancedHealthHypo", 2, 1, 1, null),
						dtf.a("blueprint_superHealthHypo", 4, 1, 1, null),
						dtf.a("blueprint_adrenalineShot", 2, 1, 1, null),
						dtf.a("blueprint_morphineShot", 3, 1, 1, null),
						dtf.a("blueprint_psiBooster", 1, 1, 1, null),
						dtf.a("blueprint_psiInhalant", 1, 1, 1, null),
						dtf.a("blueprint_psiReinvigorator", 2, 1, 1, null),
						dtf.a("blueprint_extractToxin", 1, 1, 1, null),
						dtf.a("blueprint_processPlant", 1, 1, 1, null),
						dtf.a("blueprint_chemicalBolt", 4, 1, 1, null),
						dtf.a("blueprint_chemicalPistol", 5, 1, 1, null),
						dtf.a("blueprint_chemicalBlobTrap", 4, 1, 1, null),
						dtf.a("blueprint_chemicalAmmo", 4, 1, 1, null),
						dtf.a("blueprint_irongut", 3, 1, 1, null),
						dtf.a("blueprint_trance", 3, 1, 1, null),
						dtf.a("blueprint_aegis", 3, 1, 1, null),
						dtf.a("blueprint_focusStim", 3, 1, 1, null),
						dtf.a("blueprint_jumpingBean", 3, 1, 1, null),
						dtf.a("blueprint_bullhead", 3, 1, 1, null),
						dtf.a("xpbl_blueprint_psionicAccelerator", 50, 1, 1, null),
						dtf.a("xpbl_blueprint_coagulationShot", 50, 1, 1, null),
						dtf.a("xpbl_blueprint_hypercerebrix", 50, 1, 1, null),
						dtf.a("xpbl_blueprint_twitch", 50, 1, 1, null),
						dtf.a("xpbl_blueprint_thirdEye", 50, 1, 1, null)
					};
				case ItemRange.Blueprints_Medical_Conventional:
					return new List<ezv>
					{
						dtf.a("blueprint_healthHypo", 1, 1, 1, null),
						dtf.a("blueprint_advancedHealthHypo", 2, 1, 1, null),
						dtf.a("blueprint_superHealthHypo", 3, 1, 1, null),
						dtf.a("blueprint_adrenalineShot", 2, 1, 1, null),
						dtf.a("blueprint_psiBooster", 1, 1, 1, null),
						dtf.a("blueprint_psiInhalant", 1, 1, 1, null),
						dtf.a("blueprint_psiReinvigorator", 2, 1, 1, null),
						dtf.a("blueprint_extractToxin", 1, 1, 1, null),
						dtf.a("blueprint_processPlant", 1, 1, 1, null),
						dtf.a("blueprint_irongut", 3, 1, 1, null),
						dtf.a("blueprint_jumpingBean", 3, 1, 1, null),
						dtf.a("blueprint_bullhead", 3, 1, 1, null),
						dtf.a("xpbl_blueprint_psionicAccelerator", 50, 1, 1, null),
						dtf.a("xpbl_blueprint_coagulationShot", 50, 1, 1, null),
						dtf.a("xpbl_blueprint_hypercerebrix", 50, 1, 1, null),
						dtf.a("xpbl_blueprint_twitch", 50, 1, 1, null),
						dtf.a("xpbl_blueprint_thirdEye", 50, 1, 1, null)
					};
				case ItemRange.Blueprints_Medical_Drugs:
					return new List<ezv>
					{
						dtf.a("blueprint_morphineShot", 3, 1, 1, null),
						dtf.a("blueprint_chemicalBolt", 3, 1, 1, null),
						dtf.a("blueprint_chemicalPistol", 4, 1, 1, null),
						dtf.a("blueprint_chemicalBlobTrap", 3, 1, 1, null),
						dtf.a("blueprint_chemicalAmmo", 3, 1, 1, null),
						dtf.a("blueprint_trance", 3, 1, 1, null),
						dtf.a("blueprint_aegis", 3, 1, 1, null),
						dtf.a("blueprint_focusStim", 3, 1, 1, null),
						dtf.a("blueprint_jumpingBean", 3, 1, 1, null)
					};
				case ItemRange.Blueprints_Military:
					return new List<ezv>
					{
						dtf.a("blueprint_grenade", 1, 1, 1, null),
						dtf.a("blueprint_thinGrenadeCase", 1, 1, 1, null),
						dtf.a("blueprint_fragGrenadeCase", 1, 1, 1, null),
						dtf.a("blueprint_thinMineCase", 1, 1, 1, null),
						dtf.a("blueprint_fragMineCase", 1, 1, 1, null),
						dtf.a("blueprint_flashbang", 2, 1, 1, null),
						dtf.a("blueprint_bearTrap", 1, 1, 1, null),
						dtf.a("blueprint_throwingKnives", 1, 1, 1, null),
						dtf.a("blueprint_throwingNet", 3, 1, 1, null),
						dtf.a("blueprint_mine", 1, 1, 1, null),
						dtf.a("blueprint_empGrenade", 3, 1, 1, null),
						dtf.a("blueprint_empMine", 3, 1, 1, null),
						dtf.a("blueprint_cloakingDevice", 8, 1, 1, null),
						dtf.a("blueprint_energyShieldEmitter", 3, 1, 1, null),
						dtf.a("blueprint_goggles", 3, 1, 1, null),
						dtf.a("blueprint_leatherArmor", 1, 1, 1, null),
						dtf.a("blueprint_balaclava", 1, 1, 1, null),
						dtf.a("blueprint_tacticalVest", 2, 1, 1, null),
						dtf.a("blueprint_riotGear", 2, 1, 1, null),
						dtf.a("blueprint_crossbow", 1, 1, 1, null),
						dtf.a("blueprint_pistol", 1, 1, 1, null),
						dtf.a("blueprint_sniper", 4, 1, 1, null),
						dtf.a("blueprint_metalArmor", 4, 1, 1, null),
						dtf.a("blueprint_metalHelmet", 3, 1, 1, null),
						dtf.a("blueprint_boots", 1, 1, 1, null),
						dtf.a("blueprint_greaves", 1, 1, 1, null),
						dtf.a("blueprint_tabiBoots", 1, 1, 1, null),
						dtf.a("blueprint_smg", 1, 1, 1, null),
						dtf.a("blueprint_combatKnife", 1, 1, 1, null),
						dtf.a("blueprint_shiv", 3, 1, 1, null),
						dtf.a("xpbl_blueprint_machete", 1, 1, 1, null),
						dtf.a("blueprint_combatGloves", 1, 1, 1, null),
						dtf.a("blueprint_caltrops", 1, 1, 1, null),
						dtf.a("blueprint_sledgehammer", 2, 1, 1, null),
						dtf.a("blueprint_assaultRifle", 3, 1, 1, null),
						dtf.a("blueprint_energyPistol", 5, 1, 1, null),
						dtf.a("blueprint_psionicHeadband", 5, 1, 1, null),
						dtf.a("blueprint_chemicalBolt", 1, 1, 1, null),
						dtf.a("blueprint_mechanicalBolt", 1, 1, 1, null),
						dtf.a("blueprint_shockBolt", 1, 1, 1, null),
						dtf.a("blueprint_incendiaryBolt", 1, 1, 1, null),
						dtf.a("blueprint_shockShuriken", 5, 1, 1, null),
						dtf.a("blueprint_chemicalPistol", 5, 1, 1, null),
						dtf.a("blueprint_chemicalBlobTrap", 3, 1, 1, null),
						dtf.a("blueprint_chemicalAmmo", 4, 1, 1, null),
						dtf.a("blueprint_incendiaryGrenade", 1, 1, 1, null),
						dtf.a("blueprint_gasGrenade", 1, 1, 1, null),
						dtf.a("blueprint_bullets", 1, 1, 1, null),
						dtf.a("blueprint_w2cBullets", 1, 1, 1, null),
						dtf.a("blueprint_jhpBullets", 1, 1, 1, null),
						dtf.a("blueprint_shockBullets", 2, 1, 1, null),
						dtf.a("blueprint_microShrapnelBullets", 2, 1, 1, null),
						dtf.a("blueprint_incendiaryBullets", 2, 1, 1, null),
						dtf.a("blueprint_acidBullets", 2, 1, 1, null),
						dtf.a("blueprint_explosiveBullets", 2, 1, 1, null),
						dtf.a("blueprint_contaminatedBullets", 2, 1, 1, null),
						dtf.a("xpbl_blueprint_stingballGrenade", 12, 1, 1, null),
						dtf.a("xpbl_blueprint_plasmaGrenade", 200, 1, 1, null),
						dtf.a("xpbl_blueprint_plasmaMine", 200, 1, 1, null),
						dtf.a("xpbl_blueprint_spyingEndoscope", 200, 1, 1, null),
						dtf.a("xpbl_blueprint_broadheadBolt", 1, 1, 1, null),
						dtf.a("xpbl_blueprint_spear", 10, 1, 1, null),
						dtf.a("xpbl_blueprint_shotgunShells", 2, 1, 1, null),
						dtf.a("xpbl_blueprint_shotgun", 3, 1, 1, null),
						dtf.a("xphw_blueprint_grenadeLauncher", 4, 1, 1, null),
						dtf.a("xphw_blueprint_rocketLauncher", 7, 1, 1, null),
						dtf.a("xphw_blueprint_lightMachineGun", 3, 1, 1, null),
						dtf.a("xphw_blueprint_minigun", 6, 1, 1, null),
						dtf.a("xphw_blueprint_highExplosiveLauncherGrenade", 3, 1, 1, null),
						dtf.a("xphw_blueprint_fragLauncherGrenade", 3, 1, 1, null),
						dtf.a("xphw_blueprint_concussiveLauncherGrenade", 7, 1, 1, null),
						dtf.a("xphw_blueprint_incendiaryLauncherGrenade", 7, 1, 1, null),
						dtf.a("xphw_blueprint_thermobaricLauncherGrenade", 10, 1, 1, null),
						dtf.a("xphw_blueprint_clusterLauncherGrenade", 10, 1, 1, null),
						dtf.a("xphw_blueprint_rocket84HighExplosive", 15, 1, 1, null),
						dtf.a("xphw_blueprint_rocket84Kinetic", 15, 1, 1, null),
						dtf.a("xphw_blueprint_rocket84CaveShaker", 25, 1, 1, null),
						dtf.a("xphw_blueprint_rocket84WhitePhosphorus", 50, 1, 1, null)
					};
				case ItemRange.Blueprints_ElectronicUtility:
					return new List<ezv>
					{
						dtf.a("blueprint_cloakingDevice", 1, 1, 1, null),
						dtf.a("blueprint_energyShieldEmitter", 1, 1, 1, null),
						dtf.a("blueprint_shockBolt", 1, 1, 1, null),
						dtf.a("blueprint_shockShuriken", 5, 1, 1, null),
						dtf.a("blueprint_goggles", 1, 1, 1, null),
						dtf.a("xpbl_blueprint_spyingEndoscope", 5, 1, 1, null)
					};
				default:
					switch (A_0)
					{
					case ItemRange.Component_Electronic:
						return new List<ezv>
						{
							dtf.a("component_digitalTimer", 3, 1, 1, null),
							dtf.a("component_plasmaCore", 2, 1, 1, null),
							dtf.a("component_electroshockGenerator", 2, 1, 1, null),
							dtf.a("xpbl_component_polarizer", 4, 1, 1, null),
							dtf.a("xpbl_component_energyEdgeEmitter", 30, 1, 1, null),
							dtf.a("component_pneumaticHammer", 3, 1, 1, null),
							dtf.a("component_microElectroshockDischarger", 1, 1, 3, null),
							dtf.a("component_laserEmitter", 2, 1, 1, null),
							dtf.a("component_plasmaDischarger", 3, 1, 1, null),
							dtf.a("component_smartModule", 4, 1, 1, null),
							dtf.a("component_vest_galvanic", 4, 1, 1, null),
							dtf.a("component_vest_regenerative", 9, 1, 1, null),
							dtf.a("component_empDischarger", 2, 1, 3, null),
							dtf.a("component_emDeflector", 2, 1, 1, null),
							dtf.a("component_emFieldStabilizer", 2, 1, 1, null),
							dtf.a("component_empMineCase", 1, 1, 1, null),
							dtf.a("xpbl_component_plasmaMineCase", 2, 1, 1, null),
							dtf.a("component_energyPistolFrame", 2, 1, 1, null),
							dtf.a("scraps_electronic", 2, 1, 3, null),
							dtf.a("xpbl_component_plasmaMicroDischarger", 6, 1, 3, null),
							dtf.a("component_psionicHeadbandFrame", 5, 1, 1, null),
							dtf.a("component_psionicModulator_metathermic", 6, 1, 1, null),
							dtf.a("component_psionicModulator_psychokinetic", 6, 1, 1, null),
							dtf.a("component_psionicModulator_thoughtControl", 6, 1, 1, null),
							dtf.a("component_psionicModulator_universal", 6, 1, 1, null),
							dtf.a("xpbl_component_psionicModulator_temporalManipulation", 6, 1, 1, null),
							dtf.a("component_proximalNeuroscopicFilter", 8, 1, 1, null),
							dtf.a("component_stableNeuralAmplifier", 9, 1, 1, null),
							dtf.a("component_psionicMufflers", 10, 1, 1, null),
							dtf.a("component_psiCircuitExtension", 12, 1, 1, null),
							dtf.a("xpbl_component_magnifyingNeuroscopicFilter_cryokinesis", 30, 1, 1, null),
							dtf.a("xpbl_component_magnifyingNeuroscopicFilter_cryokineticOrb", 30, 1, 1, null),
							dtf.a("xpbl_component_magnifyingNeuroscopicFilter_electrokinesis", 30, 1, 1, null),
							dtf.a("xpbl_component_magnifyingNeuroscopicFilter_neuralOverload", 30, 1, 1, null),
							dtf.a("xpbl_component_magnifyingNeuroscopicFilter_pyrokinesis", 30, 1, 1, null),
							dtf.a("xpbl_component_magnifyingNeuroscopicFilter_pyrokineticStream", 30, 1, 1, null),
							dtf.a("xpbl_component_magnifyingNeuroscopicFilter_telekineticPunch", 30, 1, 1, null),
							dtf.a("xpbl_component_magnifyingNeuroscopicFilter_temporalDistorsion", 30, 1, 1, null),
							dtf.a("xpbl_component_magnifyingNeuroscopicFilter_plasmaBeam", 70, 1, 1, null),
							dtf.a("xpbl_component_magnifyingNeuroscopicFilter_cryogenicBarrier", 30, 1, 1, null),
							dtf.a("component_adaptiveLens", 2, 1, 1, null),
							dtf.a("component_seekerLens", 2, 1, 1, null),
							dtf.a("component_smartLens", 3, 1, 1, null),
							dtf.a("component_motionTrackingLens", 3, 1, 1, null),
							dtf.a("component_scope", 2, 1, 1, null),
							dtf.a("component_anatomicallyAwareScope", 3, 1, 1, null),
							dtf.a("component_highResolutionDigitalScope", 3, 1, 1, null),
							dtf.a("component_shieldEmitterBase", 2, 1, 1, null),
							dtf.a("component_lowFrequencyShieldModulator", 2, 1, 1, null),
							dtf.a("component_mediumFrequencyShieldModulator", 2, 1, 1, null),
							dtf.a("component_highFrequencyShieldModulator", 2, 1, 1, null),
							dtf.a("component_circularWaveAmplifier", 4, 1, 1, null),
							dtf.a("component_shieldCapacitor", 4, 1, 1, null),
							dtf.a("component_highEfficiencyEnergyConverter", 4, 1, 1, null),
							dtf.a("xpbl_component_opticalFiber", 2, 1, 5, null),
							dtf.a("xpbl_component_endoscopeEyepiece", 4, 1, 1, null)
						};
					case ItemRange.Component_Mechanic:
						return new List<ezv>
						{
							dtf.a("component_fragGrenadeCase", 1, 1, 1, null),
							dtf.a("component_thinGrenadeCase", 1, 1, 1, null),
							dtf.a("component_fragMineCase", 2, 1, 1, null),
							dtf.a("component_thinMineCase", 2, 1, 1, null),
							dtf.a("component_crossbowParts1", 3, 1, 1, null),
							dtf.a("component_crossbowParts2", 3, 1, 1, null),
							dtf.a("component_crossbowParts3", 3, 1, 1, null),
							dtf.a("component_crossbowParts4", 3, 1, 1, null),
							dtf.a("component_crossbowParts5", 3, 1, 1, null),
							dtf.a("component_pistolFrame1", 2, 1, 1, null),
							dtf.a("component_pistolFrame2", 2, 1, 1, null),
							dtf.a("component_pistolFrame3", 2, 1, 1, null),
							dtf.a("component_pistolFrame4", 2, 1, 1, null),
							dtf.a("component_smgFrame1", 3, 1, 1, null),
							dtf.a("component_smgFrame2", 3, 1, 1, null),
							dtf.a("component_smgFrame3", 3, 1, 1, null),
							dtf.a("component_smgFrame4", 3, 1, 1, null),
							dtf.a("component_sniperFrame1", 4, 1, 1, null),
							dtf.a("component_sniperFrame2", 4, 1, 1, null),
							dtf.a("component_sniperFrame3", 4, 1, 1, null),
							dtf.a("component_sniperFrame4", 4, 1, 1, null),
							dtf.a("component_assaultRifleFrame1", 3, 1, 1, null),
							dtf.a("component_assaultRifleFrame2", 3, 1, 1, null),
							dtf.a("component_assaultRifleFrame3", 3, 1, 1, null),
							dtf.a("component_assaultRifleFrame4", 3, 1, 1, null),
							dtf.a("xpbl_component_shotgunFrame1", 3, 1, 1, null),
							dtf.a("xpbl_component_shotgunFrame2", 3, 1, 1, null),
							dtf.a("xpbl_component_shotgunFrame3", 3, 1, 1, null),
							dtf.a("xpbl_component_combatShotgunFrame1", 4, 1, 1, null),
							dtf.a("xpbl_component_combatShotgunFrame2", 4, 1, 1, null),
							dtf.a("xpbl_component_combatShotgunFrame3", 4, 1, 1, null),
							dtf.a("xphw_component_grenadeLauncherFrame1", 7, 1, 1, null),
							dtf.a("xphw_component_grenadeLauncherFrame2", 8, 1, 1, null),
							dtf.a("xphw_component_grenadeLauncherFrame3", 5, 1, 1, null),
							dtf.a("xphw_component_grenadeLauncherFrame4", 6, 1, 1, null),
							dtf.a("xphw_component_lightMachineGunFrame1", 2, 1, 1, null),
							dtf.a("xphw_component_lightMachineGunFrame2", 2, 1, 1, null),
							dtf.a("xphw_component_lightMachineGunFrame3", 2, 1, 1, null),
							dtf.a("xphw_component_lightMachineGunFrame4", 2, 1, 1, null),
							dtf.a("xphw_component_minigunFrame1", 12, 1, 1, null),
							dtf.a("xphw_component_minigunFrame2", 18, 1, 1, null),
							dtf.a("xphw_component_minigunFrame3", 12, 1, 1, null),
							dtf.a("xphw_component_minigunFrame4", 18, 1, 1, null),
							dtf.a("xphw_component_rocketLauncherFrame1", 10, 1, 1, null),
							dtf.a("xphw_component_rocketLauncherFrame2", 12, 1, 1, null),
							dtf.a("xphw_component_rocketLauncherFrame3", 12, 1, 1, null),
							dtf.a("xphw_component_rocketLauncherFrame4", 18, 1, 1, null),
							dtf.a("xphw_component_rocketLauncherFrame5", 18, 1, 1, null),
							dtf.a("component_scope", 2, 1, 1, null),
							dtf.a("component_crossbowSuperString", 4, 1, 1, null),
							dtf.a("component_pneumaticReloader", 3, 1, 1, null),
							dtf.a("component_extendedPistolMagazine", 2, 1, 1, null),
							dtf.a("component_extendedRifleMagazine", 3, 1, 1, null),
							dtf.a("component_bipod", 2, 1, 1, null),
							dtf.a("component_rifleBarrelRetractor", 4, 1, 1, null),
							dtf.a("component_verticalForegrip", 2, 1, 1, null),
							dtf.a("xphw_component_ergonomicHandle", 2, 1, 1, null),
							dtf.a("component_muzzleBrake", 2, 1, 1, null),
							dtf.a("component_barrelCompensator", 3, 1, 1, null),
							dtf.a("component_silencer", 2, 1, 1, null),
							dtf.a("component_rapidReloader", 5, 1, 1, null),
							dtf.a("xpbl_component_shotgunChoke", 3, 1, 1, null),
							dtf.a("xpbl_component_shotgunTubeExtension", 5, 1, 1, null),
							dtf.a("component_sledgehammerHandle", 1, 1, 1, null),
							dtf.a("xpbl_component_spearShaft", 3, 1, 1, null),
							dtf.a("xpbl_component_macheteHandle", 1, 1, 1, null),
							dtf.a("component_knifeHandle", 1, 1, 1, null),
							dtf.a("component_knifeMold", 1, 1, 1, null),
							dtf.a("component_serratedKnifeMold", 1, 1, 1, null),
							dtf.a("component_daggerMold", 1, 1, 1, null),
							dtf.a("xpbl_component_straightMacheteBladeMold", 2, 1, 1, null),
							dtf.a("xpbl_component_curvedMacheteBladeMold", 2, 1, 1, null),
							dtf.a("xpbl_component_smallShotgunPelletMold", 2, 1, 5, null),
							dtf.a("xpbl_component_mediumShotgunPelletMold", 2, 1, 5, null),
							dtf.a("xpbl_component_largeShotgunPelletMold", 2, 1, 5, null),
							dtf.a("xpbl_component_hugeShotgunPelletMold", 5, 1, 5, null),
							dtf.a("component_ballisticPanel_reinforcedFabric", 2, 1, 1, null),
							dtf.a("component_ballisticPanel_laminatedFabric", 2, 1, 1, null),
							dtf.a("component_ballisticArmorPlate_ceramicPlate", 3, 1, 1, null),
							dtf.a("component_ballisticArmorPlate_nanocompositePlate", 4, 1, 1, null),
							dtf.a("component_metalPlate_steel", 1, 1, 1, null),
							dtf.a("component_metalPlate_tungstenSteel", 2, 1, 1, null),
							dtf.a("component_metalPlate_tichrome", 5, 1, 1, null),
							dtf.a("component_metalArmorEnh_spikes_steel", 2, 1, 3, null),
							dtf.a("component_metalArmorEnh_serratedBlade_steel", 2, 1, 2, null),
							dtf.a("component_metalArmorEnh_spikes_tungstenSteel", 3, 1, 3, null),
							dtf.a("component_metalArmorEnh_serratedBlade_tungstenSteel", 3, 1, 2, null),
							dtf.a("component_metalArmorEnh_spikes_tichrome", 4, 1, 2, null),
							dtf.a("component_metalArmorEnh_serratedBlade_tichrome", 4, 1, 2, null),
							dtf.a("component_visor", 3, 1, 1, null),
							dtf.a("component_shadedVisor", 3, 1, 1, null),
							dtf.a("component_gogglesFrame", 3, 1, 1, null),
							dtf.a("component_bootSpring", 4, 1, 1, null),
							dtf.a("component_rubberSole", 1, 1, 1, null),
							dtf.a("xpbl_component_opticalFiber", 3, 1, 5, null),
							dtf.a("xpbl_component_endoscopeEyepiece", 6, 1, 1, null),
							dtf.a("xpbl_component_broadheadBoltTip", 3, 1, 10, null),
							dtf.a("xpbl_component_stabilizationWings", 4, 1, 1, null),
							dtf.a("component_boltTrigger", 1, 1, 1, null),
							dtf.a("component_pneumaticHammer", 3, 1, 1, null),
							dtf.a("scraps_metal", 2, 1, 3, null)
						};
					case ItemRange.Component_Simple:
						return new List<ezv>
						{
							dtf.a("component_cardboardContainer", 1, 1, 1, null),
							dtf.a("component_ampule", 1, 1, 5, null),
							dtf.a("component_flatBeaker", 1, 1, 2, null),
							dtf.a("component_capsule", 1, 1, 8, null),
							dtf.a("component_vial", 1, 1, 5, null),
							dtf.a("component_spongeFilter", 1, 1, 3, null),
							dtf.a("component_syringe", 1, 1, 5, null),
							dtf.a("component_fabric_blackCloth", 1, 1, 1, null),
							dtf.a("component_padding_highDensityFoamPadding", 4, 1, 1, null),
							dtf.a("component_padding_softFoamPadding", 3, 1, 1, null),
							dtf.a("component_metalPlate_steel", 3, 1, 1, null),
							dtf.a("component_metalPlate_tungstenSteel", 4, 1, 1, null),
							dtf.a("component_boltTrigger", 2, 1, 1, null),
							dtf.a("component_gasoline", 2, 1, 1, null),
							dtf.a("component_coal", 3, 1, 1, null),
							dtf.a("component_rubberSole", 1, 1, 1, null),
							dtf.a("scraps_metal", 2, 1, 3, null),
							dtf.a("scraps_electronic", 2, 1, 3, null),
							dtf.a("scraps_fabric", 2, 1, 3, null),
							dtf.a("xpbl_component_rubberBalls", 3, 1, 3, null),
							dtf.a("xpbl_component_broadheadBoltTip", 3, 1, 10, null)
						};
					case ItemRange.Component_Natural:
						return new List<ezv>
						{
							dtf.a("component_mindshroom", 1, 1, 1, null),
							dtf.a("component_redDreamMushroom", 3, 1, 1, null),
							dtf.a("component_lakePoppy", 10, 1, 1, null),
							dtf.a("component_caveEar", 10, 1, 1, null)
						};
					case ItemRange.Component_Military:
						return new List<ezv>
						{
							dtf.a("component_fragGrenadeCase", 1, 1, 1, null),
							dtf.a("component_thinGrenadeCase", 1, 1, 1, null),
							dtf.a("component_fragMineCase", 2, 1, 1, null),
							dtf.a("component_thinMineCase", 2, 1, 1, null),
							dtf.a("component_empMineCase", 3, 1, 1, null),
							dtf.a("xpbl_component_plasmaMineCase", 6, 1, 1, null),
							dtf.a("component_rawTnt", 3, 1, 1, null),
							dtf.a("component_hexogen", 4, 1, 1, null),
							dtf.a("component_crossbowParts1", 1, 1, 1, null),
							dtf.a("component_crossbowParts2", 1, 1, 1, null),
							dtf.a("component_crossbowParts3", 1, 1, 1, null),
							dtf.a("component_crossbowParts4", 1, 1, 1, null),
							dtf.a("component_crossbowParts5", 1, 1, 1, null),
							dtf.a("component_pistolFrame1", 1, 1, 1, null),
							dtf.a("component_pistolFrame2", 1, 1, 1, null),
							dtf.a("component_pistolFrame3", 1, 1, 1, null),
							dtf.a("component_pistolFrame4", 1, 1, 1, null),
							dtf.a("component_smgFrame1", 1, 1, 1, null),
							dtf.a("component_smgFrame2", 1, 1, 1, null),
							dtf.a("component_smgFrame3", 1, 1, 1, null),
							dtf.a("component_smgFrame4", 1, 1, 1, null),
							dtf.a("component_assaultRifleFrame1", 1, 1, 1, null),
							dtf.a("component_assaultRifleFrame2", 1, 1, 1, null),
							dtf.a("component_assaultRifleFrame3", 1, 1, 1, null),
							dtf.a("component_assaultRifleFrame4", 1, 1, 1, null),
							dtf.a("component_sniperFrame1", 1, 1, 1, null),
							dtf.a("component_sniperFrame2", 1, 1, 1, null),
							dtf.a("component_sniperFrame3", 1, 1, 1, null),
							dtf.a("component_sniperFrame4", 1, 1, 1, null),
							dtf.a("xpbl_component_shotgunFrame1", 1, 1, 1, null),
							dtf.a("xpbl_component_shotgunFrame2", 1, 1, 1, null),
							dtf.a("xpbl_component_shotgunFrame3", 1, 1, 1, null),
							dtf.a("xpbl_component_combatShotgunFrame1", 1, 1, 1, null),
							dtf.a("xpbl_component_combatShotgunFrame2", 1, 1, 1, null),
							dtf.a("xpbl_component_combatShotgunFrame3", 1, 1, 1, null),
							dtf.a("xphw_component_grenadeLauncherFrame1", 3, 1, 1, null),
							dtf.a("xphw_component_grenadeLauncherFrame2", 3, 1, 1, null),
							dtf.a("xphw_component_grenadeLauncherFrame3", 2, 1, 1, null),
							dtf.a("xphw_component_grenadeLauncherFrame4", 2, 1, 1, null),
							dtf.a("xphw_component_lightMachineGunFrame1", 1, 1, 1, null),
							dtf.a("xphw_component_lightMachineGunFrame2", 1, 1, 1, null),
							dtf.a("xphw_component_lightMachineGunFrame3", 1, 1, 1, null),
							dtf.a("xphw_component_lightMachineGunFrame4", 1, 1, 1, null),
							dtf.a("xphw_component_minigunFrame1", 3, 1, 1, null),
							dtf.a("xphw_component_minigunFrame2", 5, 1, 1, null),
							dtf.a("xphw_component_minigunFrame3", 3, 1, 1, null),
							dtf.a("xphw_component_minigunFrame4", 5, 1, 1, null),
							dtf.a("xphw_component_rocketLauncherFrame1", 3, 1, 1, null),
							dtf.a("xphw_component_rocketLauncherFrame2", 4, 1, 1, null),
							dtf.a("xphw_component_rocketLauncherFrame3", 4, 1, 1, null),
							dtf.a("xphw_component_rocketLauncherFrame4", 5, 1, 1, null),
							dtf.a("xphw_component_rocketLauncherFrame5", 5, 1, 1, null),
							dtf.a("component_barrel5", 1, 1, 1, null),
							dtf.a("component_barrel762", 1, 1, 1, null),
							dtf.a("component_barrel86", 2, 1, 1, null),
							dtf.a("component_barrel9", 2, 1, 1, null),
							dtf.a("component_barrel44", 3, 1, 1, null),
							dtf.a("component_barrel127", 3, 1, 1, null),
							dtf.a("xpbl_component_shortShotgunBarrel", 2, 1, 1, null),
							dtf.a("xpbl_component_longShotgunBarrel", 2, 1, 1, null),
							dtf.a("xphw_grenadeLauncherBarrel25", 3, 1, 1, null),
							dtf.a("xphw_grenadeLauncherBarrel25L", 5, 1, 1, null),
							dtf.a("xphw_grenadeLauncherBarrel40", 3, 1, 1, null),
							dtf.a("xphw_grenadeLauncherBarrel40L", 5, 1, 1, null),
							dtf.a("xphw_grenadeLauncherBoxMagazine6", 3, 1, 1, null),
							dtf.a("xphw_grenadeLauncherBoxMagazine8", 4, 1, 1, null),
							dtf.a("xphw_grenadeLauncherBoxMagazine10", 5, 1, 1, null),
							dtf.a("xphw_grenadeLauncherBoxMagazine12", 8, 1, 1, null),
							dtf.a("xphw_grenadeLauncherRevolverCylinder4", 3, 1, 1, null),
							dtf.a("xphw_grenadeLauncherRevolverCylinder6", 5, 1, 1, null),
							dtf.a("xphw_grenadeLauncherRevolverCylinder8", 8, 1, 1, null),
							dtf.a("xphw_component_lmgBeltMagazine50", 3, 1, 1, null),
							dtf.a("xphw_component_lmgBeltMagazine65", 5, 1, 1, null),
							dtf.a("xphw_component_lmgBeltMagazine80", 8, 1, 1, null),
							dtf.a("xphw_component_lmgBeltMagazine100", 20, 1, 1, null),
							dtf.a("xphw_component_lmgBoxMagazine45", 3, 1, 1, null),
							dtf.a("xphw_component_lmgBoxMagazine55", 5, 1, 1, null),
							dtf.a("xphw_component_lmgBoxMagazine65", 8, 1, 1, null),
							dtf.a("xphw_component_lmgBoxMagazine80", 20, 1, 1, null),
							dtf.a("xphw_component_minigunMotorJumpstarter1", 4, 1, 1, null),
							dtf.a("xphw_component_minigunMotorJumpstarter2", 7, 1, 1, null),
							dtf.a("xphw_component_minigunMotorSlowStarter1", 4, 1, 1, null),
							dtf.a("xphw_component_minigunMotorSlowStarter2", 7, 1, 1, null),
							dtf.a("xphw_component_minigunMotorLongGame1", 4, 1, 1, null),
							dtf.a("xphw_component_minigunMotorLongGame2", 7, 1, 1, null),
							dtf.a("xphw_grenadeLauncherIronsights", 3, 1, 1, null),
							dtf.a("xphw_grenadeLauncherScope", 4, 1, 1, null),
							dtf.a("xphw_airburstScope", 6, 1, 1, null),
							dtf.a("xphw_rocketLauncherFiringMechanism1", 4, 1, 1, null),
							dtf.a("xphw_rocketLauncherFiringMechanism2", 6, 1, 1, null),
							dtf.a("xphw_rocketLauncherFiringMechanism3", 6, 1, 1, null),
							dtf.a("xphw_rocketLauncherEmrac", 8, 1, 1, null),
							dtf.a("component_scope", 3, 1, 1, null),
							dtf.a("component_anatomicallyAwareScope", 4, 1, 1, null),
							dtf.a("component_highResolutionDigitalScope", 4, 1, 1, null),
							dtf.a("component_laserSight", 3, 1, 1, null),
							dtf.a("component_reflexSight", 3, 1, 1, null),
							dtf.a("component_crossbowSuperString", 6, 1, 1, null),
							dtf.a("component_pneumaticReloader", 5, 1, 1, null),
							dtf.a("component_extendedPistolMagazine", 3, 1, 1, null),
							dtf.a("component_extendedRifleMagazine", 4, 1, 1, null),
							dtf.a("component_bipod", 3, 1, 1, null),
							dtf.a("component_rifleBarrelRetractor", 6, 1, 1, null),
							dtf.a("component_verticalForegrip", 3, 1, 1, null),
							dtf.a("xphw_component_ergonomicHandle", 3, 1, 1, null),
							dtf.a("component_muzzleBrake", 3, 1, 1, null),
							dtf.a("component_barrelCompensator", 3, 1, 1, null),
							dtf.a("component_silencer", 2, 1, 1, null),
							dtf.a("component_rapidReloader", 5, 1, 1, null),
							dtf.a("xpbl_component_shotgunChoke", 4, 1, 1, null),
							dtf.a("xpbl_component_shotgunTubeExtension", 5, 1, 1, null),
							dtf.a("component_sledgehammerHandle", 2, 1, 1, null),
							dtf.a("xpbl_component_spearShaft", 8, 1, 1, null),
							dtf.a("xpbl_component_macheteHandle", 2, 1, 1, null),
							dtf.a("component_knifeHandle", 1, 1, 1, null),
							dtf.a("component_knifeMold", 1, 1, 1, null),
							dtf.a("component_serratedKnifeMold", 2, 1, 1, null),
							dtf.a("component_daggerMold", 2, 1, 1, null),
							dtf.a("xpbl_component_straightMacheteBladeMold", 2, 1, 1, null),
							dtf.a("xpbl_component_curvedMacheteBladeMold", 1, 1, 1, null),
							dtf.a("xpbl_component_smallShotgunPelletMold", 1, 1, 7, null),
							dtf.a("xpbl_component_mediumShotgunPelletMold", 1, 1, 7, null),
							dtf.a("xpbl_component_largeShotgunPelletMold", 1, 1, 7, null),
							dtf.a("xpbl_component_hugeShotgunPelletMold", 3, 1, 7, null),
							dtf.a("component_ballisticPanel_reinforcedFabric", 2, 1, 1, null),
							dtf.a("component_ballisticPanel_laminatedFabric", 2, 1, 1, null),
							dtf.a("component_ballisticArmorPlate_ceramicPlate", 3, 1, 1, null),
							dtf.a("component_vest_insulated", 1, 1, 1, null),
							dtf.a("component_vest_galvanic", 1, 1, 1, null),
							dtf.a("component_vest_regenerative", 8, 1, 1, null),
							dtf.a("component_vest_biohazard", 3, 1, 1, null),
							dtf.a("component_vest_sturdy", 1, 1, 1, null),
							dtf.a("component_metalPlate_steel", 3, 1, 1, null),
							dtf.a("component_metalPlate_tungstenSteel", 4, 1, 1, null),
							dtf.a("component_metalPlate_tichrome", 10, 1, 1, null),
							dtf.a("component_metalArmorEnh_spikes_steel", 2, 1, 3, null),
							dtf.a("component_metalArmorEnh_serratedBlade_steel", 2, 1, 2, null),
							dtf.a("component_metalArmorEnh_spikes_tungstenSteel", 3, 1, 3, null),
							dtf.a("component_metalArmorEnh_serratedBlade_tungstenSteel", 3, 1, 2, null),
							dtf.a("component_metalArmorEnh_spikes_tichrome", 4, 1, 2, null),
							dtf.a("component_metalArmorEnh_serratedBlade_tichrome", 4, 1, 2, null),
							dtf.a("component_visor", 3, 1, 1, null),
							dtf.a("component_shadedVisor", 3, 1, 1, null),
							dtf.a("component_gogglesFrame", 3, 1, 1, null),
							dtf.a("component_adaptiveLens", 4, 1, 1, null),
							dtf.a("component_seekerLens", 4, 1, 1, null),
							dtf.a("component_smartLens", 5, 1, 1, null),
							dtf.a("component_motionTrackingLens", 5, 1, 1, null),
							dtf.a("component_imageIntensifierTube", 4, 1, 1, null),
							dtf.a("component_headlight", 3, 1, 1, null),
							dtf.a("component_bootSpring", 4, 1, 1, null),
							dtf.a("component_pneumaticHammer", 6, 1, 1, null),
							dtf.a("component_rubberSole", 2, 1, 1, null),
							dtf.a("component_fabric_kevlarCloth", 1, 1, 1, null),
							dtf.a("component_fabric_blastCloth", 1, 1, 1, null),
							dtf.a("component_boltTrigger", 1, 1, 1, null),
							dtf.a("component_gasoline", 1, 1, 1, null),
							dtf.a("component_rocketPropellant", 3, 1, 2, null),
							dtf.a("component_NapalmC", 3, 1, 1, null),
							dtf.a("component_starterMixture", 3, 1, 1, null),
							dtf.a("component_chemicalPistolFrame", 5, 1, 1, null),
							dtf.a("component_AcidCollector", 5, 1, 1, null),
							dtf.a("component_CryogenicCollector", 5, 1, 1, null),
							dtf.a("component_IncendiaryCollector", 5, 1, 1, null),
							dtf.a("component_chemicalTrapCase", 5, 1, 1, null),
							dtf.a("component_BlobDispenser", 5, 1, 1, null),
							dtf.a("component_shieldEmitterBase", 5, 1, 1, null),
							dtf.a("component_lowFrequencyShieldModulator", 5, 1, 1, null),
							dtf.a("component_mediumFrequencyShieldModulator", 5, 1, 1, null),
							dtf.a("component_highFrequencyShieldModulator", 5, 1, 1, null),
							dtf.a("component_circularWaveAmplifier", 8, 1, 1, null),
							dtf.a("component_shieldCapacitor", 8, 1, 1, null),
							dtf.a("component_highEfficiencyEnergyConverter", 8, 1, 1, null),
							dtf.a("xpbl_component_broadheadBoltTip", 1, 1, 10, null),
							dtf.a("xpbl_component_stabilizationWings", 3, 1, 1, null)
						};
					case ItemRange.Component_EnergyCore:
						return new List<ezv>
						{
							dtf.a("component_plasmaCore", 3, 1, 1, null)
						};
					case ItemRange.Component_Modulator:
						return new List<ezv>();
					case ItemRange.Component_Industrial:
						return new List<ezv>
						{
							dtf.a("component_fabric_blackCloth", 1, 1, 1, null),
							dtf.a("component_fabric_aluminizedCloth", 3, 1, 1, null),
							dtf.a("component_fabric_kevlarCloth", 4, 1, 1, null),
							dtf.a("component_fabric_blastCloth", 4, 1, 1, null),
							dtf.a("component_padding_highDensityFoamPadding", 1, 1, 1, null),
							dtf.a("component_padding_galvanicFoamPadding", 2, 1, 1, null),
							dtf.a("component_padding_insulatingFoamPadding", 2, 1, 1, null),
							dtf.a("component_visor", 3, 1, 1, null),
							dtf.a("component_shadedVisor", 3, 1, 1, null),
							dtf.a("component_gogglesFrame", 3, 1, 1, null),
							dtf.a("component_adaptiveLens", 4, 1, 1, null),
							dtf.a("component_padding_softFoamPadding", 1, 1, 1, null),
							dtf.a("component_metalPlate_steel", 2, 1, 1, null),
							dtf.a("component_metalPlate_tungstenSteel", 3, 1, 1, null),
							dtf.a("component_metalPlate_tichrome", 8, 1, 1, null),
							dtf.a("component_metalArmorEnh_spikes_steel", 2, 1, 3, null),
							dtf.a("component_metalArmorEnh_serratedBlade_steel", 2, 1, 2, null),
							dtf.a("component_metalArmorEnh_spikes_tungstenSteel", 3, 1, 3, null),
							dtf.a("component_metalArmorEnh_serratedBlade_tungstenSteel", 3, 1, 2, null),
							dtf.a("component_metalArmorEnh_spikes_tichrome", 4, 1, 2, null),
							dtf.a("component_metalArmorEnh_serratedBlade_tichrome", 4, 1, 2, null),
							dtf.a("component_rawTnt", 5, 1, 1, null),
							dtf.a("component_hexogen", 7, 1, 1, null),
							dtf.a("component_gasoline", 1, 1, 1, null),
							dtf.a("component_rocketPropellant", 4, 1, 2, null),
							dtf.a("component_coal", 1, 1, 1, null),
							dtf.a("component_starterMixture", 1, 1, 1, null),
							dtf.a("component_toxicSludge", 5, 1, 1, null),
							dtf.a("component_magnesiumPowder", 3, 1, 1, null),
							dtf.a("component_whitePhosphorus", 5, 1, 1, null),
							dtf.a("component_graphite", 2, 1, 1, null),
							dtf.a("component_AcidCollector", 5, 1, 1, null),
							dtf.a("component_CryogenicCollector", 5, 1, 1, null),
							dtf.a("component_IncendiaryCollector", 5, 1, 1, null),
							dtf.a("component_chemicalTrapCase", 4, 1, 1, null),
							dtf.a("component_pneumaticHammer", 4, 1, 1, null),
							dtf.a("component_rubberSole", 1, 1, 1, null),
							dtf.a("scraps_metal", 2, 1, 3, null),
							dtf.a("scraps_electronic", 2, 1, 3, null),
							dtf.a("scraps_fabric", 2, 1, 3, null),
							dtf.a("xpbl_component_rubberBalls", 2, 1, 3, null),
							dtf.a("xpbl_component_opticalFiber", 4, 1, 5, null),
							dtf.a("xpbl_component_endoscopeEyepiece", 8, 1, 1, null),
							dtf.a("xpbl_component_stabilizationWings", 5, 1, 1, null),
							dtf.a("armor_workerSuit", 15, 1, 1, null),
							dtf.a("armor_miningHelmet", 20, 1, 1, null)
						};
					case ItemRange.Component_GunBarrel:
						return new List<ezv>
						{
							dtf.a("component_barrel5", 1, 1, 1, null),
							dtf.a("component_barrel762", 1, 1, 1, null),
							dtf.a("component_barrel86", 2, 1, 1, null),
							dtf.a("component_barrel9", 2, 1, 1, null),
							dtf.a("component_barrel44", 3, 1, 1, null),
							dtf.a("component_barrel127", 3, 1, 1, null),
							dtf.a("xpbl_component_shortShotgunBarrel", 2, 1, 1, null),
							dtf.a("xpbl_component_longShotgunBarrel", 2, 1, 1, null),
							dtf.a("xphw_grenadeLauncherBarrel25", 4, 1, 1, null),
							dtf.a("xphw_grenadeLauncherBarrel25L", 6, 1, 1, null),
							dtf.a("xphw_grenadeLauncherBarrel40", 4, 1, 1, null),
							dtf.a("xphw_grenadeLauncherBarrel40L", 6, 1, 1, null)
						};
					case ItemRange.Component_Firearms:
						return new List<ezv>
						{
							dtf.a("component_pistolFrame1", 1, 1, 1, null),
							dtf.a("component_pistolFrame2", 1, 1, 1, null),
							dtf.a("component_pistolFrame3", 1, 1, 1, null),
							dtf.a("component_pistolFrame4", 1, 1, 1, null),
							dtf.a("component_smgFrame1", 2, 1, 1, null),
							dtf.a("component_smgFrame2", 2, 1, 1, null),
							dtf.a("component_smgFrame3", 2, 1, 1, null),
							dtf.a("component_smgFrame4", 2, 1, 1, null),
							dtf.a("component_assaultRifleFrame1", 3, 1, 1, null),
							dtf.a("component_assaultRifleFrame2", 3, 1, 1, null),
							dtf.a("component_assaultRifleFrame3", 3, 1, 1, null),
							dtf.a("component_assaultRifleFrame4", 3, 1, 1, null),
							dtf.a("component_sniperFrame1", 3, 1, 1, null),
							dtf.a("component_sniperFrame2", 3, 1, 1, null),
							dtf.a("component_sniperFrame3", 3, 1, 1, null),
							dtf.a("component_sniperFrame4", 3, 1, 1, null),
							dtf.a("xpbl_component_shotgunFrame1", 3, 1, 1, null),
							dtf.a("xpbl_component_shotgunFrame2", 3, 1, 1, null),
							dtf.a("xpbl_component_shotgunFrame3", 3, 1, 1, null),
							dtf.a("xpbl_component_combatShotgunFrame1", 4, 1, 1, null),
							dtf.a("xpbl_component_combatShotgunFrame2", 4, 1, 1, null),
							dtf.a("xpbl_component_combatShotgunFrame3", 4, 1, 1, null),
							dtf.a("xphw_component_grenadeLauncherFrame1", 7, 1, 1, null),
							dtf.a("xphw_component_grenadeLauncherFrame2", 8, 1, 1, null),
							dtf.a("xphw_component_grenadeLauncherFrame3", 5, 1, 1, null),
							dtf.a("xphw_component_grenadeLauncherFrame4", 6, 1, 1, null),
							dtf.a("xphw_component_lightMachineGunFrame1", 2, 1, 1, null),
							dtf.a("xphw_component_lightMachineGunFrame2", 2, 1, 1, null),
							dtf.a("xphw_component_lightMachineGunFrame3", 2, 1, 1, null),
							dtf.a("xphw_component_lightMachineGunFrame4", 2, 1, 1, null),
							dtf.a("xphw_component_minigunFrame1", 12, 1, 1, null),
							dtf.a("xphw_component_minigunFrame2", 18, 1, 1, null),
							dtf.a("xphw_component_minigunFrame3", 12, 1, 1, null),
							dtf.a("xphw_component_minigunFrame4", 18, 1, 1, null),
							dtf.a("xphw_component_rocketLauncherFrame1", 10, 1, 1, null),
							dtf.a("xphw_component_rocketLauncherFrame2", 12, 1, 1, null),
							dtf.a("xphw_component_rocketLauncherFrame3", 12, 1, 1, null),
							dtf.a("xphw_component_rocketLauncherFrame4", 18, 1, 1, null),
							dtf.a("xphw_component_rocketLauncherFrame5", 18, 1, 1, null),
							dtf.a("component_barrel5", 1, 1, 1, null),
							dtf.a("component_barrel762", 1, 1, 1, null),
							dtf.a("component_barrel86", 2, 1, 1, null),
							dtf.a("component_barrel9", 2, 1, 1, null),
							dtf.a("component_barrel44", 3, 1, 1, null),
							dtf.a("component_barrel127", 3, 1, 1, null),
							dtf.a("xpbl_component_shortShotgunBarrel", 2, 1, 1, null),
							dtf.a("xpbl_component_longShotgunBarrel", 2, 1, 1, null),
							dtf.a("xphw_grenadeLauncherBarrel25", 3, 1, 1, null),
							dtf.a("xphw_grenadeLauncherBarrel25L", 5, 1, 1, null),
							dtf.a("xphw_grenadeLauncherBarrel40", 3, 1, 1, null),
							dtf.a("xphw_grenadeLauncherBarrel40L", 5, 1, 1, null),
							dtf.a("xphw_grenadeLauncherBoxMagazine6", 3, 1, 1, null),
							dtf.a("xphw_grenadeLauncherBoxMagazine8", 4, 1, 1, null),
							dtf.a("xphw_grenadeLauncherBoxMagazine10", 5, 1, 1, null),
							dtf.a("xphw_grenadeLauncherBoxMagazine12", 8, 1, 1, null),
							dtf.a("xphw_grenadeLauncherRevolverCylinder4", 3, 1, 1, null),
							dtf.a("xphw_grenadeLauncherRevolverCylinder6", 5, 1, 1, null),
							dtf.a("xphw_grenadeLauncherRevolverCylinder8", 8, 1, 1, null),
							dtf.a("xphw_component_lmgBeltMagazine50", 3, 1, 1, null),
							dtf.a("xphw_component_lmgBeltMagazine65", 5, 1, 1, null),
							dtf.a("xphw_component_lmgBeltMagazine80", 8, 1, 1, null),
							dtf.a("xphw_component_lmgBeltMagazine100", 20, 1, 1, null),
							dtf.a("xphw_component_lmgBoxMagazine45", 3, 1, 1, null),
							dtf.a("xphw_component_lmgBoxMagazine55", 5, 1, 1, null),
							dtf.a("xphw_component_lmgBoxMagazine65", 8, 1, 1, null),
							dtf.a("xphw_component_lmgBoxMagazine80", 20, 1, 1, null),
							dtf.a("xphw_component_minigunMotorJumpstarter1", 4, 1, 1, null),
							dtf.a("xphw_component_minigunMotorJumpstarter2", 7, 1, 1, null),
							dtf.a("xphw_component_minigunMotorSlowStarter1", 4, 1, 1, null),
							dtf.a("xphw_component_minigunMotorSlowStarter2", 7, 1, 1, null),
							dtf.a("xphw_component_minigunMotorLongGame1", 4, 1, 1, null),
							dtf.a("xphw_component_minigunMotorLongGame2", 7, 1, 1, null),
							dtf.a("xphw_grenadeLauncherIronsights", 3, 1, 1, null),
							dtf.a("xphw_grenadeLauncherScope", 4, 1, 1, null),
							dtf.a("xphw_airburstScope", 6, 1, 1, null),
							dtf.a("xphw_rocketLauncherFiringMechanism1", 4, 1, 1, null),
							dtf.a("xphw_rocketLauncherFiringMechanism2", 6, 1, 1, null),
							dtf.a("xphw_rocketLauncherFiringMechanism3", 6, 1, 1, null),
							dtf.a("xphw_rocketLauncherEmrac", 8, 1, 1, null),
							dtf.a("component_scope", 3, 1, 1, null),
							dtf.a("component_anatomicallyAwareScope", 4, 1, 1, null),
							dtf.a("component_highResolutionDigitalScope", 4, 1, 1, null),
							dtf.a("component_laserSight", 3, 1, 1, null),
							dtf.a("component_reflexSight", 3, 1, 1, null),
							dtf.a("component_extendedPistolMagazine", 3, 1, 1, null),
							dtf.a("component_extendedRifleMagazine", 3, 1, 1, null),
							dtf.a("component_bipod", 3, 1, 1, null),
							dtf.a("component_rifleBarrelRetractor", 5, 1, 1, null),
							dtf.a("component_verticalForegrip", 3, 1, 1, null),
							dtf.a("xphw_component_ergonomicHandle", 3, 1, 1, null),
							dtf.a("component_muzzleBrake", 3, 1, 1, null),
							dtf.a("component_barrelCompensator", 3, 1, 1, null),
							dtf.a("component_silencer", 2, 1, 1, null),
							dtf.a("component_rapidReloader", 5, 1, 1, null),
							dtf.a("xpbl_component_shotgunChoke", 3, 1, 1, null),
							dtf.a("xpbl_component_shotgunTubeExtension", 4, 1, 1, null)
						};
					case ItemRange.Component_Psionic:
						return new List<ezv>
						{
							dtf.a("component_psionicHeadbandFrame", 1, 1, 1, null),
							dtf.a("component_psionicModulator_metathermic", 2, 1, 1, null),
							dtf.a("component_psionicModulator_psychokinetic", 2, 1, 1, null),
							dtf.a("component_psionicModulator_thoughtControl", 2, 1, 1, null),
							dtf.a("component_psionicModulator_universal", 2, 1, 1, null),
							dtf.a("xpbl_component_psionicModulator_temporalManipulation", 2, 1, 1, null),
							dtf.a("component_proximalNeuroscopicFilter", 4, 1, 1, null),
							dtf.a("component_stableNeuralAmplifier", 5, 1, 1, null),
							dtf.a("component_psionicMufflers", 6, 1, 1, null),
							dtf.a("component_psiCircuitExtension", 8, 1, 1, null),
							dtf.a("xpbl_component_magnifyingNeuroscopicFilter_cryokinesis", 15, 1, 1, null),
							dtf.a("xpbl_component_magnifyingNeuroscopicFilter_cryokineticOrb", 15, 1, 1, null),
							dtf.a("xpbl_component_magnifyingNeuroscopicFilter_electrokinesis", 15, 1, 1, null),
							dtf.a("xpbl_component_magnifyingNeuroscopicFilter_neuralOverload", 15, 1, 1, null),
							dtf.a("xpbl_component_magnifyingNeuroscopicFilter_pyrokinesis", 15, 1, 1, null),
							dtf.a("xpbl_component_magnifyingNeuroscopicFilter_pyrokineticStream", 15, 1, 1, null),
							dtf.a("xpbl_component_magnifyingNeuroscopicFilter_telekineticPunch", 15, 1, 1, null),
							dtf.a("xpbl_component_magnifyingNeuroscopicFilter_temporalDistorsion", 15, 1, 1, null),
							dtf.a("xpbl_component_magnifyingNeuroscopicFilter_plasmaBeam", 40, 1, 1, null),
							dtf.a("xpbl_component_magnifyingNeuroscopicFilter_cryogenicBarrier", 15, 1, 1, null)
						};
					case ItemRange.Component_Medical:
						return new List<ezv>
						{
							dtf.a("component_ampule", 1, 1, 5, null),
							dtf.a("component_flatBeaker", 1, 1, 2, null),
							dtf.a("component_capsule", 1, 1, 8, null),
							dtf.a("component_vial", 1, 1, 5, null),
							dtf.a("component_spongeFilter", 1, 1, 3, null),
							dtf.a("component_syringe", 1, 1, 5, null),
							dtf.a("component_midazolam", 4, 1, 1, null),
							dtf.a("component_psionicCatalyst", 8, 1, 1, null),
							dtf.a("component_bondingAgent", 4, 1, 1, null),
							dtf.a("component_anticoagulant", 2, 1, 1, null),
							dtf.a("component_smallOxygenTank", 2, 1, 1, null),
							dtf.a("component_taurine", 3, 1, 1, null),
							dtf.a("component_organicGelElectrolyte", 3, 1, 1, null),
							dtf.a("component_burrowerPoison", 3, 1, 1, null),
							dtf.a("component_caveEarPoison", 10, 1, 1, null),
							dtf.a("component_crawlerPoison", 15, 1, 1, null),
							dtf.a("component_acid", 4, 1, 1, null),
							dtf.a("component_blood", 7, 1, 1, null),
							dtf.a("component_adrenaline", 7, 1, 1, null),
							dtf.a("component_morphine", 10, 1, 1, null),
							dtf.a("component_insectoidSaliva", 10, 1, 1, null),
							dtf.a("component_mindshroom", 8, 1, 1, null),
							dtf.a("component_redDreamMushroom", 14, 1, 1, null),
							dtf.a("component_lakePoppy", 14, 1, 1, null),
							dtf.a("component_caveEar", 14, 1, 1, null),
							dtf.a("component_magnesiumPowder", 9, 1, 1, null),
							dtf.a("component_whitePhosphorus", 20, 1, 1, null),
							dtf.a("component_graphite", 14, 1, 1, null),
							dtf.a("xpbl_component_opticalFiber", 10, 1, 5, null),
							dtf.a("xpbl_component_endoscopeEyepiece", 12, 1, 1, null)
						};
					case ItemRange.Component_EnergyShield:
						return new List<ezv>
						{
							dtf.a("component_shieldEmitterBase", 1, 1, 1, null),
							dtf.a("component_lowFrequencyShieldModulator", 1, 1, 1, null),
							dtf.a("component_mediumFrequencyShieldModulator", 1, 1, 1, null),
							dtf.a("component_highFrequencyShieldModulator", 1, 1, 1, null),
							dtf.a("component_circularWaveAmplifier", 3, 1, 1, null),
							dtf.a("component_shieldCapacitor", 3, 1, 1, null),
							dtf.a("component_highEfficiencyEnergyConverter", 3, 1, 1, null)
						};
					case ItemRange.Component_InorganicChemistry:
						return new List<ezv>
						{
							dtf.a("component_flatBeaker", 1, 1, 2, null),
							dtf.a("component_vial", 1, 1, 5, null),
							dtf.a("component_spongeFilter", 1, 1, 3, null),
							dtf.a("component_bondingAgent", 1, 1, 1, null),
							dtf.a("component_acid", 1, 1, 1, null),
							dtf.a("component_magnesiumPowder", 1, 1, 1, null),
							dtf.a("component_whitePhosphorus", 6, 1, 1, null),
							dtf.a("component_graphite", 1, 1, 1, null),
							dtf.a("component_toxicSludge", 4, 1, 1, null),
							dtf.a("component_gasoline", 1, 1, 1, null),
							dtf.a("component_rocketPropellant", 3, 1, 2, null),
							dtf.a("component_coal", 2, 1, 1, null),
							dtf.a("component_NapalmC", 2, 1, 1, null),
							dtf.a("component_starterMixture", 2, 1, 1, null),
							dtf.a("ammo_vial_acid_regular", 2, 1, 3, null),
							dtf.a("component_AcidCollector", 3, 1, 1, null),
							dtf.a("component_CryogenicCollector", 3, 1, 1, null),
							dtf.a("component_IncendiaryCollector", 3, 1, 1, null),
							dtf.a("component_BlobDispenser", 3, 1, 1, null)
						};
					case ItemRange.Component_Crossbow:
						return new List<ezv>
						{
							dtf.a("component_crossbowParts1", 1, 1, 1, null),
							dtf.a("component_crossbowParts2", 1, 1, 1, null),
							dtf.a("component_crossbowParts3", 1, 1, 1, null),
							dtf.a("component_crossbowParts4", 1, 1, 1, null),
							dtf.a("component_crossbowParts5", 1, 1, 1, null),
							dtf.a("component_scope", 8, 1, 1, null),
							dtf.a("component_anatomicallyAwareScope", 8, 1, 1, null),
							dtf.a("component_highResolutionDigitalScope", 8, 1, 1, null),
							dtf.a("component_laserSight", 8, 1, 1, null),
							dtf.a("component_reflexSight", 8, 1, 1, null),
							dtf.a("component_crossbowSuperString", 12, 1, 1, null),
							dtf.a("component_pneumaticReloader", 12, 1, 1, null)
						};
					case ItemRange.Component_MetalPlates:
						return new List<ezv>
						{
							dtf.a("component_metalPlate_steel", 1, 1, 1, null),
							dtf.a("component_metalPlate_tungstenSteel", 3, 1, 1, null),
							dtf.a("component_metalPlate_tichrome", 5, 1, 1, null)
						};
					case ItemRange.Component_MachineGuns:
						return new List<ezv>
						{
							dtf.a("xphw_component_lightMachineGunFrame1", 2, 1, 1, null),
							dtf.a("xphw_component_lightMachineGunFrame2", 2, 1, 1, null),
							dtf.a("xphw_component_lightMachineGunFrame3", 2, 1, 1, null),
							dtf.a("xphw_component_lightMachineGunFrame4", 2, 1, 1, null),
							dtf.a("xphw_component_minigunFrame1", 5, 1, 1, null),
							dtf.a("xphw_component_minigunFrame2", 9, 1, 1, null),
							dtf.a("xphw_component_minigunFrame3", 5, 1, 1, null),
							dtf.a("xphw_component_minigunFrame4", 9, 1, 1, null),
							dtf.a("xphw_component_ergonomicHandle", 3, 1, 1, null),
							dtf.a("xphw_component_lmgBeltMagazine50", 3, 1, 1, null),
							dtf.a("xphw_component_lmgBeltMagazine65", 5, 1, 1, null),
							dtf.a("xphw_component_lmgBeltMagazine80", 8, 1, 1, null),
							dtf.a("xphw_component_lmgBeltMagazine100", 15, 1, 1, null),
							dtf.a("xphw_component_lmgBoxMagazine45", 3, 1, 1, null),
							dtf.a("xphw_component_lmgBoxMagazine55", 5, 1, 1, null),
							dtf.a("xphw_component_lmgBoxMagazine65", 8, 1, 1, null),
							dtf.a("xphw_component_lmgBoxMagazine80", 15, 1, 1, null)
						};
					case ItemRange.Component_MinigunMotors:
						return new List<ezv>
						{
							dtf.a("xphw_component_minigunMotorJumpstarter1", 1, 1, 1, null),
							dtf.a("xphw_component_minigunMotorJumpstarter2", 3, 1, 1, null),
							dtf.a("xphw_component_minigunMotorSlowStarter1", 1, 1, 1, null),
							dtf.a("xphw_component_minigunMotorSlowStarter2", 3, 1, 1, null),
							dtf.a("xphw_component_minigunMotorLongGame1", 1, 1, 1, null),
							dtf.a("xphw_component_minigunMotorLongGame2", 3, 1, 1, null)
						};
					case ItemRange.Component_GrenadeLaunchers:
						return new List<ezv>
						{
							dtf.a("xphw_grenadeLauncherBarrel25", 3, 1, 1, null),
							dtf.a("xphw_grenadeLauncherBarrel25L", 5, 1, 1, null),
							dtf.a("xphw_grenadeLauncherBarrel40", 3, 1, 1, null),
							dtf.a("xphw_grenadeLauncherBarrel40L", 5, 1, 1, null),
							dtf.a("xphw_grenadeLauncherBoxMagazine6", 3, 1, 1, null),
							dtf.a("xphw_grenadeLauncherBoxMagazine8", 4, 1, 1, null),
							dtf.a("xphw_grenadeLauncherBoxMagazine10", 5, 1, 1, null),
							dtf.a("xphw_grenadeLauncherBoxMagazine12", 8, 1, 1, null),
							dtf.a("xphw_grenadeLauncherRevolverCylinder4", 3, 1, 1, null),
							dtf.a("xphw_grenadeLauncherRevolverCylinder6", 5, 1, 1, null),
							dtf.a("xphw_grenadeLauncherRevolverCylinder8", 8, 1, 1, null),
							dtf.a("xphw_grenadeLauncherIronsights", 3, 1, 1, null),
							dtf.a("xphw_grenadeLauncherScope", 4, 1, 1, null),
							dtf.a("xphw_airburstScope", 6, 1, 1, null),
							dtf.a("xphw_component_grenadeLauncherFrame1", 7, 1, 1, null),
							dtf.a("xphw_component_grenadeLauncherFrame2", 8, 1, 1, null),
							dtf.a("xphw_component_grenadeLauncherFrame3", 5, 1, 1, null),
							dtf.a("xphw_component_grenadeLauncherFrame4", 6, 1, 1, null)
						};
					case ItemRange.Component_RocketLaunchers:
						return new List<ezv>
						{
							dtf.a("xphw_grenadeLauncherIronsights", 3, 1, 1, null),
							dtf.a("xphw_grenadeLauncherScope", 4, 1, 1, null),
							dtf.a("xphw_airburstScope", 7, 1, 1, null),
							dtf.a("xphw_rocketLauncherFiringMechanism1", 3, 1, 1, null),
							dtf.a("xphw_rocketLauncherFiringMechanism2", 6, 1, 1, null),
							dtf.a("xphw_rocketLauncherFiringMechanism3", 6, 1, 1, null),
							dtf.a("xphw_rocketLauncherEmrac", 9, 1, 1, null),
							dtf.a("xphw_component_rocketLauncherFrame1", 4, 1, 1, null),
							dtf.a("xphw_component_rocketLauncherFrame2", 7, 1, 1, null),
							dtf.a("xphw_component_rocketLauncherFrame3", 7, 1, 1, null),
							dtf.a("xphw_component_rocketLauncherFrame4", 9, 1, 1, null),
							dtf.a("xphw_component_rocketLauncherFrame5", 9, 1, 1, null)
						};
					}
					break;
				}
			}
		}
		else if (A_0 <= ItemRange.Sormirbaren_Weapons)
		{
			if (A_0 == ItemRange.Trash)
			{
				return new List<ezv>
				{
					dtf.a("scraps_metal", 1, 1, 5, null),
					dtf.a("scraps_electronic", 1, 1, 5, null),
					dtf.a("scraps_fabric", 1, 1, 5, null),
					dtf.a("xpbl_component_rubberBalls", 2, 1, 3, null),
					dtf.a("trash_dirtyRag", 1, 1, 1, null),
					dtf.a("trash_bottle", 1, 1, 7, null),
					dtf.a("component_toxicSludge", 10, 1, 1, null),
					dtf.a("component_bulletCase_5", 2, 1, 10, null),
					dtf.a("component_bulletCase_762", 2, 1, 10, null),
					dtf.a("component_bulletCase_86", 2, 1, 10, null),
					dtf.a("component_bulletCase_9", 2, 1, 10, null),
					dtf.a("component_bulletCase_44", 2, 1, 10, null),
					dtf.a("component_bulletCase_127", 2, 1, 10, null),
					dtf.a("xpbl_component_emptyShotgunShell", 1, 1, 6, null),
					dtf.a("shiv", 25, 1, 1, null),
					dtf.a("brassKnuckles", 25, 1, 1, null),
					dtf.a("armor_workerSuit", 30, 1, 1, null)
				};
			}
			switch (A_0)
			{
			case ItemRange.VehiclePart_Engine:
				return new List<ezv>
				{
					dtf.a("vehiclePart_ScrappyEngine200", 1, 1, 1, null),
					dtf.a("vehiclePart_ScrappyEngine250", 1, 1, 1, null),
					dtf.a("vehiclePart_ScrappyEngine300", 1, 1, 1, null),
					dtf.a("vehiclePart_WellMadeEngine225", 1, 1, 1, null),
					dtf.a("vehiclePart_WellMadeEngine325", 1, 1, 1, null),
					dtf.a("vehiclePart_BArmLightstep250", 1, 1, 1, null),
					dtf.a("vehiclePart_XGAlpha27", 3, 1, 1, null),
					dtf.a("vehiclePart_XGAlpha30", 100, 1, 1, null),
					dtf.a("vehiclePart_XGBeta35", 1, 1, 1, null),
					dtf.a("vehiclePart_BioInGiant375", 3, 1, 1, null),
					dtf.a("vehiclePart_BArmShifter400", 5, 1, 1, null),
					dtf.a("vehiclePart_BArmHauler450", 1, 1, 1, null),
					dtf.a("vehiclePart_BioInTitan500", 1, 1, 1, null),
					dtf.a("vehiclePart_BArmHauler550", 100, 1, 1, null),
					dtf.a("vehiclePart_BArmHauler600", 5, 1, 1, null)
				};
			case ItemRange.VehiclePart_Battery:
				return new List<ezv>
				{
					dtf.a("vehiclePart_ScrappyVehicleBattery150", 1, 1, 1, null),
					dtf.a("vehiclePart_ScrappyVehicleBattery350", 1, 1, 1, null),
					dtf.a("vehiclePart_ScrappyVehicleBattery600", 1, 1, 1, null),
					dtf.a("vehiclePart_BArmScilon250", 1, 1, 1, null),
					dtf.a("vehiclePart_BArmScilon350", 3, 1, 1, null),
					dtf.a("vehiclePart_XGPower30", 1, 1, 1, null),
					dtf.a("vehiclePart_XGPower40", 5, 1, 1, null),
					dtf.a("vehiclePart_BArmCurrent550", 1, 1, 1, null),
					dtf.a("vehiclePart_BioInM600", 1, 1, 1, null),
					dtf.a("vehiclePart_XGSuperpower75", 3, 1, 1, null),
					dtf.a("vehiclePart_BArmCurrent800", 100, 1, 1, null),
					dtf.a("vehiclePart_BioInL900", 1, 1, 1, null),
					dtf.a("vehiclePart_BArmSolar1000", 2, 1, 1, null),
					dtf.a("vehiclePart_BArmSolar1250", 100, 1, 1, null),
					dtf.a("vehiclePart_BioInL1500", 5, 1, 1, null)
				};
			case ItemRange.VehiclePart_JetskiSuspension:
				return new List<ezv>
				{
					dtf.a("xpbl_vehiclePart_jetski_BArmSmallJetShocks", 1, 1, 1, null),
					dtf.a("xpbl_vehiclePart_jetski_XGCloud", 3, 1, 1, null),
					dtf.a("xpbl_vehiclePart_jetski_XGStormCloud", 100, 1, 1, null),
					dtf.a("xpbl_vehiclePart_jetski_BArmMediumJetShocks", 1, 1, 1, null),
					dtf.a("xpbl_vehiclePart_jetski_BArmMediumJetShocksSE", 3, 1, 1, null),
					dtf.a("xpbl_vehiclePart_jetski_XGMist", 5, 1, 1, null),
					dtf.a("xpbl_vehiclePart_jetski_BioInHDS2", 1, 1, 1, null),
					dtf.a("xpbl_vehiclePart_jetski_BArmLargeJetShocks", 3, 1, 1, null),
					dtf.a("xpbl_vehiclePart_jetski_BioInHDS3", 100, 1, 1, null)
				};
			default:
				switch (A_0)
				{
				case ItemRange.Sormirbaren_Military:
					return new List<ezv>
					{
						dtf.a("ammo_bolt", 1, 5, 10, null),
						dtf.a("xpbl_ammo_blindingPoisonBolt", 1, 1, 3, null),
						dtf.a("xpbl_ammo_leperPoisonBolt", 1, 1, 3, null),
						dtf.a("xpbl_ammo_heartbreakPoisonBolt", 1, 1, 3, null),
						dtf.a("xpbl_sormirbarenSabre", 3, 1, 1, null),
						dtf.a("xpbl_sormirbarenSpear", 3, 1, 1, null),
						dtf.a("xpbl_sormirbarenSledgehammer", 3, 1, 1, null),
						dtf.a("xpbl_sormirbarenKnife", 3, 1, 1, null),
						dtf.a("xpbl_sormirbarenCrossbow", 3, 1, 1, null),
						dtf.a("throwingNet", 2, 1, 1, null),
						dtf.a("stoneBolas", 2, 1, 1, null),
						dtf.a("xpbl_vitalityPowder", 3, 1, 1, null),
						dtf.a("xpbl_healingSalve", 3, 1, 3, null),
						dtf.a("xpbl_spiritPotion", 4, 1, 1, null),
						dtf.a("bearTrap", 2, 1, 1, null),
						dtf.a("xpbl_blindingPoisonBearTrap", 4, 1, 1, null),
						dtf.a("xpbl_leperPoisonBearTrap", 4, 1, 1, null),
						dtf.a("xpbl_heartbreakPoisonBearTrap", 5, 1, 1, null)
					};
				case ItemRange.Sormirbaren_Common:
					return new List<ezv>
					{
						dtf.a("xpbl_vitalityPowder", 3, 1, 1, null),
						dtf.a("xpbl_healingSalve", 1, 1, 3, null),
						dtf.a("xpbl_spiritPotion", 4, 1, 1, null),
						dtf.a("xpbl_sormirbarenKnife", 2, 1, 1, null),
						dtf.a("food_bisonMilk", 5, 1, 2, null)
					};
				case ItemRange.Sormirbaren_Cookable:
					return new List<ezv>
					{
						dtf.a("component_bio_animalHeart", 1, 1, 1, null),
						dtf.a("component_bio_insectoidSalivarium", 1, 1, 1, null),
						dtf.a("component_bio_largeIntestine", 1, 1, 1, null),
						dtf.a("component_bio_siphonerTongue", 1, 1, 1, null),
						dtf.a("xpbl_component_bio_mutantCrustaceanEgg", 1, 1, 1, null),
						dtf.a("xpbl_component_bio_psiCrabHippocampus", 3, 1, 1, null),
						dtf.a("xpbl_bioluminousSwampHoney", 1, 1, 3, null),
						dtf.a("component_fish_anglerfish", 10, 1, 1, null),
						dtf.a("component_fish_blackDragon", 6, 1, 1, null),
						dtf.a("component_fish_blueEel", 1, 1, 1, null),
						dtf.a("component_fish_demonSquid", 3, 1, 1, null),
						dtf.a("component_fish_minihead", 1, 1, 1, null),
						dtf.a("component_fish_shrimp", 10, 1, 1, null),
						dtf.a("component_fish_slackjaw", 1, 1, 1, null),
						dtf.a("component_fish_walkingFish", 10, 1, 1, null),
						dtf.a("component_fish_yellowPuckerfish", 1, 1, 1, null),
						dtf.a("xpbl_component_fish_frogfish", 1, 1, 1, null),
						dtf.a("xpbl_component_fish_giantHatchetfish", 2, 1, 1, null),
						dtf.a("xpbl_component_fish_redLippedBatfish", 4, 1, 1, null),
						dtf.a("food_bisonMilk", 1, 1, 2, null)
					};
				case ItemRange.Sormirbaren_AnimalSkinAndCarapace:
					return new List<ezv>
					{
						dtf.a("xpbl_component_bio_giantCrabCarapace", 1, 1, 1, null),
						dtf.a("xpbl_component_bio_colossalCrabCarapace", 3, 1, 1, null),
						dtf.a("xpbl_component_bio_psiCrabCarapace", 6, 1, 1, null),
						dtf.a("xpbl_component_leather_bisonLeather", 1, 1, 1, null),
						dtf.a("xpbl_component_leather_greaterSiphonerLeather", 3, 1, 1, null),
						dtf.a("xpbl_component_leather_leperSerpentSkin", 1, 1, 1, null),
						dtf.a("xpbl_component_leather_heartbreakerSerpentSkin", 2, 1, 1, null),
						dtf.a("xpbl_component_leather_seaWyrmScales", 4, 1, 1, null)
					};
				case ItemRange.Sormirbaren_Toxic:
					return new List<ezv>
					{
						dtf.a("xpbl_component_bio_giantCreeperGland", 1, 1, 1, null),
						dtf.a("xpbl_component_bio_leperSerpentPoisonGland", 1, 1, 1, null),
						dtf.a("xpbl_component_bio_heartbreakerSerpentPoisonGland", 2, 1, 1, null),
						dtf.a("xpbl_component_bio_rustingAcidGland", 3, 1, 1, null),
						dtf.a("xpbl_component_plant_greenWart", 5, 1, 1, null),
						dtf.a("xpbl_component_plant_lingula", 10, 1, 1, null)
					};
				case ItemRange.Sormirbaren_Pot:
					return new List<ezv>
					{
						dtf.a("component_bio_animalHeart", 1, 1, 1, null),
						dtf.a("component_bio_insectoidSalivarium", 1, 1, 1, null),
						dtf.a("component_bio_largeIntestine", 1, 1, 1, null),
						dtf.a("component_bio_siphonerTongue", 1, 1, 1, null),
						dtf.a("xpbl_component_bio_mutantCrustaceanEgg", 1, 1, 1, null),
						dtf.a("xpbl_bioluminousSwampHoney", 1, 1, 3, null),
						dtf.a("component_fish_anglerfish", 10, 1, 1, null),
						dtf.a("component_fish_blackDragon", 6, 1, 1, null),
						dtf.a("component_fish_blueEel", 1, 1, 1, null),
						dtf.a("component_fish_demonSquid", 3, 1, 1, null),
						dtf.a("component_fish_minihead", 1, 1, 1, null),
						dtf.a("component_fish_shrimp", 10, 1, 1, null),
						dtf.a("component_fish_slackjaw", 1, 1, 1, null),
						dtf.a("component_fish_walkingFish", 10, 1, 1, null),
						dtf.a("component_fish_yellowPuckerfish", 1, 1, 1, null),
						dtf.a("xpbl_component_fish_frogfish", 1, 1, 1, null),
						dtf.a("xpbl_component_fish_giantHatchetfish", 2, 1, 1, null),
						dtf.a("xpbl_component_fish_redLippedBatfish", 4, 1, 1, null),
						dtf.a("xpbl_component_bio_giantCreeperGland", 5, 1, 1, null),
						dtf.a("xpbl_component_bio_leperSerpentPoisonGland", 5, 1, 1, null),
						dtf.a("xpbl_component_bio_heartbreakerSerpentPoisonGland", 8, 1, 1, null),
						dtf.a("xpbl_component_bio_rustingAcidGland", 10, 1, 1, null),
						dtf.a("xpbl_component_plant_greenWart", 1, 1, 1, null),
						dtf.a("xpbl_component_plant_honeySpores", 2, 1, 3, null),
						dtf.a("xpbl_component_plant_glittershroomSpores", 4, 1, 3, null),
						dtf.a("xpbl_component_plant_lingula", 10, 1, 1, null),
						dtf.a("food_bisonMilk", 1, 1, 2, null)
					};
				case ItemRange.Sormirbaren_Fish:
					return new List<ezv>
					{
						dtf.a("component_fish_anglerfish", 10, 1, 1, null),
						dtf.a("component_fish_blackDragon", 6, 1, 1, null),
						dtf.a("component_fish_blueEel", 1, 1, 1, null),
						dtf.a("component_fish_demonSquid", 3, 1, 1, null),
						dtf.a("component_fish_minihead", 1, 1, 1, null),
						dtf.a("component_fish_shrimp", 10, 1, 1, null),
						dtf.a("component_fish_slackjaw", 1, 1, 1, null),
						dtf.a("component_fish_walkingFish", 10, 1, 1, null),
						dtf.a("component_fish_yellowPuckerfish", 1, 1, 1, null),
						dtf.a("xpbl_component_fish_frogfish", 1, 1, 1, null),
						dtf.a("xpbl_component_fish_giantHatchetfish", 2, 1, 1, null),
						dtf.a("xpbl_component_fish_redLippedBatfish", 4, 1, 1, null)
					};
				case ItemRange.Sormirbaren_Weapons:
					return new List<ezv>
					{
						dtf.a("xpbl_sormirbarenSabre", 3, 1, 1, null),
						dtf.a("xpbl_sormirbarenSpear", 3, 1, 1, null),
						dtf.a("xpbl_sormirbarenSledgehammer", 3, 1, 1, null),
						dtf.a("xpbl_sormirbarenKnife", 3, 1, 1, null),
						dtf.a("xpbl_sormirbarenCrossbow", 3, 1, 1, null)
					};
				}
				break;
			}
		}
		else if (A_0 <= ItemRange.Gangs_LunaticImitatorRangedWeapons)
		{
			if (A_0 == ItemRange.Lemurian_Common)
			{
				return dtf.a();
			}
			if (A_0 == ItemRange.Gangs_LunaticImitatorRangedWeapons)
			{
				return new List<ezv>
				{
					dtf.a("pistol_with_ammo", 2, 1, 1, null),
					dtf.a("smg_with_ammo", 2, 1, 1, null),
					dtf.a("assaultRifle_with_ammo", 2, 1, 1, null),
					dtf.a("crossbow_with_ammo", 1, 1, 1, null),
					dtf.a("sniper_with_ammo", 3, 1, 1, null),
					dtf.a("energyPistol_with_ammo", 1, 1, 1, null),
					dtf.a("xpbl_shotgun_with_ammo", 1, 1, 1, null)
				};
			}
		}
		else
		{
			if (A_0 == ItemRange.GlobalUniques)
			{
				return new List<ezv>
				{
					dtf.a("gUnique_helmet_unprojector", 1, 1, 1, null),
					dtf.a("gUnique_helmet_cyclopsEye", 1, 1, 1, null),
					dtf.a("gUnique_helmet_commandoBelt", 1, 1, 1, null),
					dtf.a("gUnique_boots_jumpingStilts", 1, 1, 1, null)
				};
			}
			if (A_0 == ItemRange.Test)
			{
				return new List<ezv>
				{
					dtf.a("hypnoGoggles", 1, 1, 1, null)
				};
			}
		}
		return new List<ezv>();
	}

	// Token: 0x06002EFD RID: 12029 RVA: 0x0011D1B8 File Offset: 0x0011B3B8
	private static ezv a(string A_0, int A_1, int A_2 = 1, int A_3 = 1, string A_4 = null)
	{
		int a_;
		if (A_3 > A_2)
		{
			a_ = zp.a.Next(A_2, A_3 + 1);
		}
		else
		{
			a_ = 1;
		}
		bgf bgf;
		dtf.b.TryGetValue(A_0, out bgf);
		if (bgf != null)
		{
			return new ezv(bgf.a.a1(), A_1, a_, bgf.b, bgf.c, bgf.d, bgf.e);
		}
		return null;
	}

	// Token: 0x06002EFE RID: 12030 RVA: 0x0011D224 File Offset: 0x0011B424
	private static List<ezv> a()
	{
		return new List<ezv>
		{
			dtf.a("mechanicalRepairKit1", 4, 1, 1, null),
			dtf.a("mechanicalRepairKit2", 7, 1, 1, null),
			dtf.a("electronicRepairKit1", 4, 1, 1, null),
			dtf.a("electronicRepairKit2", 7, 1, 1, null),
			dtf.a("patchingKit1", 4, 1, 1, null),
			dtf.a("patchingKit2", 7, 1, 1, null),
			dtf.a("sharpeningStone", 8, 1, 1, null),
			dtf.a("scraps_metal", 3, 1, 3, null),
			dtf.a("scraps_electronic", 3, 1, 3, null),
			dtf.a("scraps_fabric", 3, 1, 3, null),
			dtf.a("xpbl_component_rubberBalls", 3, 1, 3, null),
			dtf.a("pistol", 5, 1, 1, null),
			dtf.a("adrenalineShot", 3, 1, 1, null),
			dtf.a("flashbang", 4, 1, 1, null),
			dtf.a("healthHypo", 2, 1, 1, null),
			dtf.a("advancedHealthHypo", 3, 1, 1, null),
			dtf.a("bandage", 1, 1, 1, null),
			dtf.a("antidote", 3, 1, 1, null),
			dtf.a("component_cardboardContainer", 1, 1, 1, null),
			dtf.a("lockpick", 1, 1, 1, null),
			dtf.a("electricTorch", 5, 1, 1, null),
			dtf.a("haxxor", 4, 1, 1, null),
			dtf.a("xpbl_hotwiringKit", 6, 1, 1, null),
			dtf.a("armor_robe", 5, 1, 1, null),
			dtf.a("component_fragGrenadeCase", 3, 1, 1, null),
			dtf.a("component_thinGrenadeCase", 3, 1, 1, null),
			dtf.a("component_fragMineCase", 5, 1, 1, null),
			dtf.a("component_thinMineCase", 5, 1, 1, null),
			dtf.a("component_ampule", 2, 1, 5, null),
			dtf.a("component_flatBeaker", 3, 1, 2, null),
			dtf.a("component_capsule", 2, 1, 8, null),
			dtf.a("component_vial", 2, 1, 5, null),
			dtf.a("component_spongeFilter", 3, 1, 3, null),
			dtf.a("component_syringe", 2, 1, 5, null),
			dtf.a("grenade_frag", 3, 1, 1, null),
			dtf.a("grenade_he", 4, 1, 1, null),
			dtf.a("grenade_emp", 6, 1, 1, null),
			dtf.a("molotovCocktail", 4, 1, 1, null),
			dtf.a("bearTrap", 2, 1, 1, null),
			dtf.a("burrowerPoisonBearTrap", 4, 1, 1, null),
			dtf.a("caveEarPoisonBearTrap", 15, 1, 1, null),
			dtf.a("crawlerPoisonBearTrap", 15, 1, 1, null),
			dtf.a("throwingKnife", 1, 1, 1, null),
			dtf.a("burrowerPoisonThrowingKnife", 3, 1, 1, null),
			dtf.a("caveEarPoisonThrowingKnife", 15, 1, 1, null),
			dtf.a("crawlerPoisonThrowingKnife", 15, 1, 1, null),
			dtf.a("mine_frag", 5, 1, 1, null),
			dtf.a("mine_he", 6, 1, 1, null),
			dtf.a("mine_emp", 8, 1, 1, null),
			dtf.a("throwingNet", 2, 1, 1, null),
			dtf.a("flare", 1, 1, 1, null),
			dtf.a("lighter", 2, 1, 1, null),
			dtf.a("trash_bottle", 1, 1, 5, null),
			dtf.a("battery_scLi", 1, 1, 1, null),
			dtf.a("battery_fusion", 3, 1, 1, null),
			dtf.a("battery_plasma", 4, 1, 1, null),
			dtf.a("battery_greaterFusion", 7, 1, 1, null),
			dtf.a("steel_crowbar", 3, 1, 1, null),
			dtf.a("tungsten_crowbar", 15, 1, 1, null),
			dtf.a("tichrome_crowbar", 15, 1, 1, null),
			dtf.a("superSteel_crowbar", 30, 1, 1, null),
			dtf.a("belt_waistPack", 6, 1, 1, null),
			dtf.a("belt_largeWaistPack", 10, 1, 1, null),
			dtf.a("ammo_bolt", 2, 2, 5, null),
			dtf.a("ammo_serratedBolt", 3, 1, 2, null),
			dtf.a("ammo_5_Std", 2, 1, 6, null),
			dtf.a("ammo_5_JHP", 3, 1, 6, null),
			dtf.a("ammo_5_W2C", 3, 1, 6, null),
			dtf.a("ammo_762_Std", 2, 1, 6, null),
			dtf.a("ammo_762_JHP", 3, 1, 6, null),
			dtf.a("ammo_762_W2C", 3, 1, 6, null),
			dtf.a("ammo_86_Std", 2, 1, 4, null),
			dtf.a("ammo_86_JHP", 3, 1, 4, null),
			dtf.a("ammo_86_W2C", 3, 1, 4, null),
			dtf.a("ammo_9_Std", 2, 1, 4, null),
			dtf.a("ammo_9_JHP", 3, 1, 4, null),
			dtf.a("ammo_9_W2C", 3, 1, 4, null),
			dtf.a("ammo_44_Std", 3, 1, 3, null),
			dtf.a("ammo_44_JHP", 4, 1, 3, null),
			dtf.a("ammo_44_W2C", 4, 1, 3, null),
			dtf.a("ammo_127_Std", 3, 1, 3, null),
			dtf.a("ammo_127_JHP", 4, 1, 3, null),
			dtf.a("ammo_127_W2C", 4, 1, 3, null),
			dtf.a("xpbl_ammo_shotgunShell_6", 1, 1, 4, null),
			dtf.a("xpbl_ammo_shotgunShell_12", 1, 1, 4, null),
			dtf.a("xpbl_ammo_shotgunShell_20", 1, 1, 4, null),
			dtf.a("xpbl_ammo_shotgunShell_3", 30, 1, 3, null),
			dtf.a("xphw_ammo_lgrenade_25_He", 2, 1, 4, null),
			dtf.a("xphw_ammo_lgrenade_25_Frag", 2, 1, 4, null),
			dtf.a("xphw_ammo_lgrenade_40_He", 2, 1, 3, null),
			dtf.a("xphw_ammo_lgrenade_40_Frag", 2, 1, 3, null),
			dtf.a("component_fabric_blackCloth", 2, 1, 1, null),
			dtf.a("component_padding_softFoamPadding", 2, 1, 1, null),
			dtf.a("component_gasoline", 1, 1, 1, null),
			dtf.a("component_coal", 3, 1, 1, null),
			dtf.a("caltrops_regular", 1, 1, 1, null),
			dtf.a("shiv", 25, 1, 1, null),
			dtf.a("brassKnuckles", 10, 1, 1, null),
			dtf.a("armor_workerSuit", 10, 1, 1, null),
			dtf.a("luxury_goldRing", 500, 1, 1, null),
			dtf.a("xpbl_component_broadheadBoltTip", 5, 1, 10, null)
		};
	}

	// Token: 0x04001A15 RID: 6677
	private static volatile object a = new object();

	// Token: 0x04001A16 RID: 6678
	private static Dictionary<string, bgf> b;

	// Token: 0x02000714 RID: 1812
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06002F02 RID: 12034 RVA: 0x0011DA50 File Offset: 0x0011BC50
		internal bool a()
		{
			return dtf.a(new Version(1, 1, 4, 5));
		}

		// Token: 0x04001A17 RID: 6679
		public static readonly dtf.a a = new dtf.a();

		// Token: 0x04001A18 RID: 6680
		public static Func<bool> b;
	}
}
