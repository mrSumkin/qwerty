using System;

namespace TimelapseVertigo.Rules.Capabilities
{
	// Token: 0x02000064 RID: 100
	[eiz("eSPLTGT")]
	[Serializable]
	public enum SpellTargetType
	{
		// Token: 0x0400030B RID: 779
		Self,
		// Token: 0x0400030C RID: 780
		Any,
		// Token: 0x0400030D RID: 781
		Spot = 20,
		// Token: 0x0400030E RID: 782
		DiscoveredSpot,
		// Token: 0x0400030F RID: 783
		VisibleSpot,
		// Token: 0x04000310 RID: 784
		DiscoveredPenetrableSpot,
		// Token: 0x04000311 RID: 785
		DiscoveredTraversableSpot,
		// Token: 0x04000312 RID: 786
		DiscoveredUnoccupiedTraversableSpot,
		// Token: 0x04000313 RID: 787
		TrappableSpot,
		// Token: 0x04000314 RID: 788
		DisembarkableSpot,
		// Token: 0x04000315 RID: 789
		CreatureOrWaterTile = 30,
		// Token: 0x04000316 RID: 790
		Thing = 40,
		// Token: 0x04000317 RID: 791
		Creature,
		// Token: 0x04000318 RID: 792
		HumanoidNotSelf,
		// Token: 0x04000319 RID: 793
		Object,
		// Token: 0x0400031A RID: 794
		LockableObject,
		// Token: 0x0400031B RID: 795
		HackableObject,
		// Token: 0x0400031C RID: 796
		ClosedVentilationShaft,
		// Token: 0x0400031D RID: 797
		OpenVentilationShaft,
		// Token: 0x0400031E RID: 798
		CreatureNotSelf,
		// Token: 0x0400031F RID: 799
		PureUsableObject,
		// Token: 0x04000320 RID: 800
		Item,
		// Token: 0x04000321 RID: 801
		PoweredItem,
		// Token: 0x04000322 RID: 802
		BulletBasedWeapon,
		// Token: 0x04000323 RID: 803
		Fireplace,
		// Token: 0x04000324 RID: 804
		EnergyStorageObject,
		// Token: 0x04000325 RID: 805
		FirearmWeapon,
		// Token: 0x04000326 RID: 806
		BladedMeleeWeapon,
		// Token: 0x04000327 RID: 807
		SledgehammerWeapon,
		// Token: 0x04000328 RID: 808
		SharpenableWeapon,
		// Token: 0x04000329 RID: 809
		CapacitativeSheetCompatibleWeapon,
		// Token: 0x0400032A RID: 810
		LivingCreature,
		// Token: 0x0400032B RID: 811
		BandagableLivingCreature,
		// Token: 0x0400032C RID: 812
		LivingCreatureNotSelf,
		// Token: 0x0400032D RID: 813
		CreatureNotSelfWithLastDamage,
		// Token: 0x0400032E RID: 814
		CreatureWithLastDamage,
		// Token: 0x0400032F RID: 815
		Robot,
		// Token: 0x04000330 RID: 816
		ActiveCamera,
		// Token: 0x04000331 RID: 817
		Humanoid,
		// Token: 0x04000332 RID: 818
		Trap = 70,
		// Token: 0x04000333 RID: 819
		SpyableDoor,
		// Token: 0x04000334 RID: 820
		HumanoidNoVehicleNotSelf,
		// Token: 0x04000335 RID: 821
		DeployedGasGrenade,
		// Token: 0x04000336 RID: 822
		DiscoveredPenetrableSpotWithWater,
		// Token: 0x04000337 RID: 823
		FirearmWeaponNotLauncher,
		// Token: 0x04000338 RID: 824
		RepairableMechanicalItem = 101,
		// Token: 0x04000339 RID: 825
		RepairableElectronicItem,
		// Token: 0x0400033A RID: 826
		RepairableFabricItem,
		// Token: 0x0400033B RID: 827
		MinableRockOrDestrucableRockOrDebris = 201,
		// Token: 0x0400033C RID: 828
		DamagedCoilSpiderWeb,
		// Token: 0x0400033D RID: 829
		LoadBearingColumn,
		// Token: 0x0400033E RID: 830
		SkerderGraveMechanism,
		// Token: 0x0400033F RID: 831
		RepairableVehicle = 300,
		// Token: 0x04000340 RID: 832
		HotwireableVehicle,
		// Token: 0x04000341 RID: 833
		TowableNavalObject,
		// Token: 0x04000342 RID: 834
		PoisonableWeapon = 401,
		// Token: 0x04000343 RID: 835
		ExplosiveCompatibleWeapon
	}
}
