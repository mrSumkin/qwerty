using System;

namespace TimelapseVertigo.Generators.Items
{
	// Token: 0x02002223 RID: 8739
	[eiz("eIR")]
	[Serializable]
	public enum ItemRange
	{
		// Token: 0x04004A34 RID: 18996
		None,
		// Token: 0x04004A35 RID: 18997
		Tech,
		// Token: 0x04004A36 RID: 18998
		Medical,
		// Token: 0x04004A37 RID: 18999
		MedicalConventional,
		// Token: 0x04004A38 RID: 19000
		MedicalDrugs,
		// Token: 0x04004A39 RID: 19001
		Firearms,
		// Token: 0x04004A3A RID: 19002
		Weapons,
		// Token: 0x04004A3B RID: 19003
		Military,
		// Token: 0x04004A3C RID: 19004
		Psi,
		// Token: 0x04004A3D RID: 19005
		Blueprints,
		// Token: 0x04004A3E RID: 19006
		Explosives,
		// Token: 0x04004A3F RID: 19007
		Common,
		// Token: 0x04004A40 RID: 19008
		Armors,
		// Token: 0x04004A41 RID: 19009
		Device_Utility,
		// Token: 0x04004A42 RID: 19010
		Device_Explosives,
		// Token: 0x04004A43 RID: 19011
		Device_Automatons,
		// Token: 0x04004A44 RID: 19012
		Documents,
		// Token: 0x04004A45 RID: 19013
		Food,
		// Token: 0x04004A46 RID: 19014
		EnergyCells,
		// Token: 0x04004A47 RID: 19015
		Ammo,
		// Token: 0x04004A48 RID: 19016
		Grenades,
		// Token: 0x04004A49 RID: 19017
		Traps,
		// Token: 0x04004A4A RID: 19018
		FirearmAmmo,
		// Token: 0x04004A4B RID: 19019
		SpecialFirearmAmmo,
		// Token: 0x04004A4C RID: 19020
		ThrowingKnives,
		// Token: 0x04004A4D RID: 19021
		PsionicMentors,
		// Token: 0x04004A4E RID: 19022
		Drinks = 27,
		// Token: 0x04004A4F RID: 19023
		Seashell,
		// Token: 0x04004A50 RID: 19024
		GiantSpiderCocoon,
		// Token: 0x04004A51 RID: 19025
		Medical_FirstAid,
		// Token: 0x04004A52 RID: 19026
		Luxury,
		// Token: 0x04004A53 RID: 19027
		SpecialBolts,
		// Token: 0x04004A54 RID: 19028
		LauncherGrenades,
		// Token: 0x04004A55 RID: 19029
		Rockets,
		// Token: 0x04004A56 RID: 19030
		Food_Junky = 101,
		// Token: 0x04004A57 RID: 19031
		Food_Snacks,
		// Token: 0x04004A58 RID: 19032
		Food_Sea,
		// Token: 0x04004A59 RID: 19033
		Food_Canned,
		// Token: 0x04004A5A RID: 19034
		Food_Tchortists,
		// Token: 0x04004A5B RID: 19035
		Weapons_Melee = 201,
		// Token: 0x04004A5C RID: 19036
		Weapons_Melee_Blunt,
		// Token: 0x04004A5D RID: 19037
		Weapons_Melee_Bladed,
		// Token: 0x04004A5E RID: 19038
		Weapons_Energy = 210,
		// Token: 0x04004A5F RID: 19039
		Blueprints_Medical = 301,
		// Token: 0x04004A60 RID: 19040
		Blueprints_Medical_Conventional,
		// Token: 0x04004A61 RID: 19041
		Blueprints_Medical_Drugs,
		// Token: 0x04004A62 RID: 19042
		Blueprints_Military,
		// Token: 0x04004A63 RID: 19043
		Blueprints_ElectronicUtility,
		// Token: 0x04004A64 RID: 19044
		Component_Electronic = 401,
		// Token: 0x04004A65 RID: 19045
		Component_Mechanic,
		// Token: 0x04004A66 RID: 19046
		Component_Simple,
		// Token: 0x04004A67 RID: 19047
		Component_Natural,
		// Token: 0x04004A68 RID: 19048
		Component_Military,
		// Token: 0x04004A69 RID: 19049
		Component_EnergyCore,
		// Token: 0x04004A6A RID: 19050
		Component_Modulator,
		// Token: 0x04004A6B RID: 19051
		Component_Industrial,
		// Token: 0x04004A6C RID: 19052
		Component_GunBarrel,
		// Token: 0x04004A6D RID: 19053
		Component_Firearms,
		// Token: 0x04004A6E RID: 19054
		Component_Psionic,
		// Token: 0x04004A6F RID: 19055
		Component_Medical,
		// Token: 0x04004A70 RID: 19056
		Component_EnergyShield,
		// Token: 0x04004A71 RID: 19057
		Component_InorganicChemistry,
		// Token: 0x04004A72 RID: 19058
		Component_Crossbow,
		// Token: 0x04004A73 RID: 19059
		Component_MetalPlates,
		// Token: 0x04004A74 RID: 19060
		Component_MachineGuns,
		// Token: 0x04004A75 RID: 19061
		Component_MinigunMotors,
		// Token: 0x04004A76 RID: 19062
		Component_GrenadeLaunchers,
		// Token: 0x04004A77 RID: 19063
		Component_RocketLaunchers,
		// Token: 0x04004A78 RID: 19064
		Trash = 500,
		// Token: 0x04004A79 RID: 19065
		VehiclePart_Engine = 601,
		// Token: 0x04004A7A RID: 19066
		VehiclePart_Battery,
		// Token: 0x04004A7B RID: 19067
		VehiclePart_JetskiSuspension,
		// Token: 0x04004A7C RID: 19068
		Sormirbaren_Military = 700,
		// Token: 0x04004A7D RID: 19069
		Sormirbaren_Common,
		// Token: 0x04004A7E RID: 19070
		Sormirbaren_Cookable,
		// Token: 0x04004A7F RID: 19071
		Sormirbaren_AnimalSkinAndCarapace,
		// Token: 0x04004A80 RID: 19072
		Sormirbaren_Toxic,
		// Token: 0x04004A81 RID: 19073
		Sormirbaren_Pot,
		// Token: 0x04004A82 RID: 19074
		Sormirbaren_Fish,
		// Token: 0x04004A83 RID: 19075
		Sormirbaren_Weapons,
		// Token: 0x04004A84 RID: 19076
		Lemurian_Common = 801,
		// Token: 0x04004A85 RID: 19077
		Gangs_LunaticImitatorRangedWeapons = 900,
		// Token: 0x04004A86 RID: 19078
		GlobalUniques = 100000,
		// Token: 0x04004A87 RID: 19079
		Test = 999999
	}
}
