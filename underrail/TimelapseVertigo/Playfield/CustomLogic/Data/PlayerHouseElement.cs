using System;

namespace TimelapseVertigo.Playfield.CustomLogic.Data
{
	// Token: 0x02002232 RID: 8754
	[eiz("ePHE")]
	[Serializable]
	public enum PlayerHouseElement
	{
		// Token: 0x04004B1C RID: 19228
		MainPower = 1,
		// Token: 0x04004B1D RID: 19229
		SecurityCameras,
		// Token: 0x04004B1E RID: 19230
		MainFloorDebris = 10,
		// Token: 0x04004B1F RID: 19231
		MainFloorLights,
		// Token: 0x04004B20 RID: 19232
		LowerFloorDebris = 20,
		// Token: 0x04004B21 RID: 19233
		LowerFloorLights,
		// Token: 0x04004B22 RID: 19234
		UpperFloorDebris = 30,
		// Token: 0x04004B23 RID: 19235
		UpperFloorLights,
		// Token: 0x04004B24 RID: 19236
		Entrance_Turrets = 101,
		// Token: 0x04004B25 RID: 19237
		Entrance_Drapery,
		// Token: 0x04004B26 RID: 19238
		MainFloor_Hallway_Drapery = 200,
		// Token: 0x04004B27 RID: 19239
		MainFloor_Hallway_Lockers,
		// Token: 0x04004B28 RID: 19240
		MainFloor_Hallway_Shelves,
		// Token: 0x04004B29 RID: 19241
		MainFloor_Hallway_Patrol,
		// Token: 0x04004B2A RID: 19242
		MainFloor_Hallway_Painting,
		// Token: 0x04004B2B RID: 19243
		MainFloor_BroomCloset_Shelves = 300,
		// Token: 0x04004B2C RID: 19244
		MainFloor_SecurityRoom_Desk = 400,
		// Token: 0x04004B2D RID: 19245
		MainFloor_SecurityRoom_Locker,
		// Token: 0x04004B2E RID: 19246
		MainFloor_LivingRoom_Rug = 501,
		// Token: 0x04004B2F RID: 19247
		MainFloor_LivingRoom_Lockers,
		// Token: 0x04004B30 RID: 19248
		MainFloor_LivingRoom_Painting,
		// Token: 0x04004B31 RID: 19249
		MainFloor_LivingRoom_Tv,
		// Token: 0x04004B32 RID: 19250
		MainFloor_LivingRoom_FurnitureSet,
		// Token: 0x04004B33 RID: 19251
		MainFloor_LivingRoom_Armoire,
		// Token: 0x04004B34 RID: 19252
		MainFloor_LivingRoom_Trophy_Beast,
		// Token: 0x04004B35 RID: 19253
		MainFloor_Kitchen_Table = 601,
		// Token: 0x04004B36 RID: 19254
		MainFloor_Kitchen_DrinksShelf,
		// Token: 0x04004B37 RID: 19255
		MainFloor_Kitchen_Freezer,
		// Token: 0x04004B38 RID: 19256
		MainFloor_Kitchen_Elements,
		// Token: 0x04004B39 RID: 19257
		MainFloor_Kitchen_Refrigerator,
		// Token: 0x04004B3A RID: 19258
		MainFloor_Kitchen_BarStools,
		// Token: 0x04004B3B RID: 19259
		UpperFloor_Hallway_Patrol = 1101,
		// Token: 0x04004B3C RID: 19260
		UpperFloor_Hallway_Drapery,
		// Token: 0x04004B3D RID: 19261
		UpperFloor_Hallway_Shelves,
		// Token: 0x04004B3E RID: 19262
		UpperFloor_Hallway_Lockers,
		// Token: 0x04004B3F RID: 19263
		UpperFloor_Toilet = 1201,
		// Token: 0x04004B40 RID: 19264
		UpperFloor_Armory_WeaponShelves = 1301,
		// Token: 0x04004B41 RID: 19265
		UpperFloor_Armory_Table,
		// Token: 0x04004B42 RID: 19266
		UpperFloor_Gym_Rug = 1401,
		// Token: 0x04004B43 RID: 19267
		UpperFloor_Gym_PunchingBag,
		// Token: 0x04004B44 RID: 19268
		UpperFloor_Gym_Bench,
		// Token: 0x04004B45 RID: 19269
		UpperFloor_Gym_Weights,
		// Token: 0x04004B46 RID: 19270
		UpperFloor_Balcony_Benches = 1501,
		// Token: 0x04004B47 RID: 19271
		UpperFloor_Balcony_Turrets,
		// Token: 0x04004B48 RID: 19272
		UpperFloor_Study_Desk = 1601,
		// Token: 0x04004B49 RID: 19273
		UpperFloor_Study_FileCabinet,
		// Token: 0x04004B4A RID: 19274
		UpperFloor_Study_Printer,
		// Token: 0x04004B4B RID: 19275
		UpperFloor_Bedroom_Rug = 1701,
		// Token: 0x04004B4C RID: 19276
		UpperFloor_Bedroom_Bed,
		// Token: 0x04004B4D RID: 19277
		UpperFloor_Bedroom_Armoire,
		// Token: 0x04004B4E RID: 19278
		UpperFloor_Bedroom_Nightstand,
		// Token: 0x04004B4F RID: 19279
		UpperFloor_Bedroom_Drapery,
		// Token: 0x04004B50 RID: 19280
		LowerFloor_Workshop_ElectroShelves = 2101,
		// Token: 0x04004B51 RID: 19281
		LowerFloor_Workshop_Shelves,
		// Token: 0x04004B52 RID: 19282
		LowerFloor_Workshop_Cabinet,
		// Token: 0x04004B53 RID: 19283
		LowerFloor_Workshop_ElectronicEquipment,
		// Token: 0x04004B54 RID: 19284
		LowerFloor_Workshop_MechanicEquipment,
		// Token: 0x04004B55 RID: 19285
		LowerFloor_Lab_Lockers = 2201,
		// Token: 0x04004B56 RID: 19286
		LowerFloor_Lab_Shelves,
		// Token: 0x04004B57 RID: 19287
		LowerFloor_Lab_OperatingTable,
		// Token: 0x04004B58 RID: 19288
		LowerFloor_Lab_ChemicalEquipment,
		// Token: 0x04004B59 RID: 19289
		LowerFloor_Lab_MedicalBed,
		// Token: 0x04004B5A RID: 19290
		LowerFloor_Leatherworks_TailoringEquipment = 2301,
		// Token: 0x04004B5B RID: 19291
		LowerFloor_Leatherworks_Shelves
	}
}
