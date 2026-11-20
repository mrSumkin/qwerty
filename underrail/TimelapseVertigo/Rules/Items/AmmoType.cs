using System;

namespace TimelapseVertigo.Rules.Items
{
	// Token: 0x02002229 RID: 8745
	[eiz("eM")]
	[Serializable]
	public enum AmmoType
	{
		// Token: 0x04004AA8 RID: 19112
		None,
		// Token: 0x04004AA9 RID: 19113
		Caliber_5 = 100,
		// Token: 0x04004AAA RID: 19114
		Caliber_5_Std,
		// Token: 0x04004AAB RID: 19115
		Caliber_5_W2C,
		// Token: 0x04004AAC RID: 19116
		Caliber_5_JHP,
		// Token: 0x04004AAD RID: 19117
		Caliber_5_Shock,
		// Token: 0x04004AAE RID: 19118
		Caliber_762 = 200,
		// Token: 0x04004AAF RID: 19119
		Caliber_762_Std,
		// Token: 0x04004AB0 RID: 19120
		Caliber_762_W2C,
		// Token: 0x04004AB1 RID: 19121
		Caliber_762_JHP,
		// Token: 0x04004AB2 RID: 19122
		Caliber_762_MS,
		// Token: 0x04004AB3 RID: 19123
		Caliber_9 = 300,
		// Token: 0x04004AB4 RID: 19124
		Caliber_9_Std,
		// Token: 0x04004AB5 RID: 19125
		Caliber_9_W2C,
		// Token: 0x04004AB6 RID: 19126
		Caliber_9_JHP,
		// Token: 0x04004AB7 RID: 19127
		Caliber_9_Acid,
		// Token: 0x04004AB8 RID: 19128
		Caliber_44 = 400,
		// Token: 0x04004AB9 RID: 19129
		Caliber_44_Std,
		// Token: 0x04004ABA RID: 19130
		Caliber_44_W2C,
		// Token: 0x04004ABB RID: 19131
		Caliber_44_JHP,
		// Token: 0x04004ABC RID: 19132
		Caliber_44_Exp,
		// Token: 0x04004ABD RID: 19133
		Caliber_86 = 500,
		// Token: 0x04004ABE RID: 19134
		Caliber_86_Std,
		// Token: 0x04004ABF RID: 19135
		Caliber_86_W2C,
		// Token: 0x04004AC0 RID: 19136
		Caliber_86_JHP,
		// Token: 0x04004AC1 RID: 19137
		Caliber_86_Inc,
		// Token: 0x04004AC2 RID: 19138
		Caliber_127 = 600,
		// Token: 0x04004AC3 RID: 19139
		Caliber_127_Std,
		// Token: 0x04004AC4 RID: 19140
		Caliber_127_W2C,
		// Token: 0x04004AC5 RID: 19141
		Caliber_127_JHP,
		// Token: 0x04004AC6 RID: 19142
		Caliber_127_Cnt,
		// Token: 0x04004AC7 RID: 19143
		ShotgunShell = 700,
		// Token: 0x04004AC8 RID: 19144
		ShotgunShell_6,
		// Token: 0x04004AC9 RID: 19145
		ShotgunShell_12,
		// Token: 0x04004ACA RID: 19146
		ShotgunShell_20,
		// Token: 0x04004ACB RID: 19147
		ShotgunShell_3,
		// Token: 0x04004ACC RID: 19148
		Grenade_25 = 800,
		// Token: 0x04004ACD RID: 19149
		Grenade_25_He,
		// Token: 0x04004ACE RID: 19150
		Grenade_25_Frag,
		// Token: 0x04004ACF RID: 19151
		Grenade_25_Concussive,
		// Token: 0x04004AD0 RID: 19152
		Grenade_25_Incendiary,
		// Token: 0x04004AD1 RID: 19153
		Grenade_40 = 900,
		// Token: 0x04004AD2 RID: 19154
		Grenade_40_He,
		// Token: 0x04004AD3 RID: 19155
		Grenade_40_Frag,
		// Token: 0x04004AD4 RID: 19156
		Grenade_40_Thermobaric,
		// Token: 0x04004AD5 RID: 19157
		Grenade_40_Cluster,
		// Token: 0x04004AD6 RID: 19158
		Vial_Acid = 1000,
		// Token: 0x04004AD7 RID: 19159
		Vial_Acid_Regular,
		// Token: 0x04004AD8 RID: 19160
		Vial_Acid_Corrosive,
		// Token: 0x04004AD9 RID: 19161
		Vial_Acid_Rusting,
		// Token: 0x04004ADA RID: 19162
		Vial_Cryogel = 1100,
		// Token: 0x04004ADB RID: 19163
		Vial_Incendiary = 1200,
		// Token: 0x04004ADC RID: 19164
		Rocket_84 = 1300,
		// Token: 0x04004ADD RID: 19165
		Rocket_84_He,
		// Token: 0x04004ADE RID: 19166
		Rocket_84_Wp,
		// Token: 0x04004ADF RID: 19167
		Rocket_84_Kin,
		// Token: 0x04004AE0 RID: 19168
		Rocket_84_Cs,
		// Token: 0x04004AE1 RID: 19169
		Rocket_40 = 1400,
		// Token: 0x04004AE2 RID: 19170
		Rocket_40_Tandem,
		// Token: 0x04004AE3 RID: 19171
		Rocket_66 = 1500,
		// Token: 0x04004AE4 RID: 19172
		Rocket_66_Incendiary,
		// Token: 0x04004AE5 RID: 19173
		Energy = 10000,
		// Token: 0x04004AE6 RID: 19174
		Bolts = 20000,
		// Token: 0x04004AE7 RID: 19175
		SerratedBolts,
		// Token: 0x04004AE8 RID: 19176
		BroadheadBolts,
		// Token: 0x04004AE9 RID: 19177
		Sledgehammer = 30000,
		// Token: 0x04004AEA RID: 19178
		Knife,
		// Token: 0x04004AEB RID: 19179
		Dagger,
		// Token: 0x04004AEC RID: 19180
		Unarmed,
		// Token: 0x04004AED RID: 19181
		Crowbar,
		// Token: 0x04004AEE RID: 19182
		FistWeapon,
		// Token: 0x04004AEF RID: 19183
		Mental = 40000,
		// Token: 0x04004AF0 RID: 19184
		BigDrill = 50000,
		// Token: 0x04004AF1 RID: 19185
		PnemuaticHammer = 60000,
		// Token: 0x04004AF2 RID: 19186
		HighExplosives = 70000,
		// Token: 0x04004AF3 RID: 19187
		Thermobaric = 70010,
		// Token: 0x04004AF4 RID: 19188
		Spear = 80000,
		// Token: 0x04004AF5 RID: 19189
		Sword = 90000,
		// Token: 0x04004AF6 RID: 19190
		ObsidianSword,
		// Token: 0x04004AF7 RID: 19191
		SonicWave = 100000,
		// Token: 0x04004AF8 RID: 19192
		BallistaBolt = 110000,
		// Token: 0x04004AF9 RID: 19193
		VoidEnergy = 120000,
		// Token: 0x04004AFA RID: 19194
		EtherealEnergy = 130000,
		// Token: 0x04004AFB RID: 19195
		ExoskeletonDrill = 140000,
		// Token: 0x04004AFC RID: 19196
		ThrowingKnife = 150000,
		// Token: 0x04004AFD RID: 19197
		ThrowingKnifeFeat0,
		// Token: 0x04004AFE RID: 19198
		ThrowingKnifeFeat1,
		// Token: 0x04004AFF RID: 19199
		ThrowingKnifeFeat2,
		// Token: 0x04004B00 RID: 19200
		ThrowingKnifeFeat3,
		// Token: 0x04004B01 RID: 19201
		ThrowingKnifeFeat4,
		// Token: 0x04004B02 RID: 19202
		ThrowingKnifeFeat5,
		// Token: 0x04004B03 RID: 19203
		SiphonerTongue = 160001
	}
}
