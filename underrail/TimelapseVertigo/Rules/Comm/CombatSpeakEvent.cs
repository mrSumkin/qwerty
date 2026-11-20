using System;

namespace TimelapseVertigo.Rules.Comm
{
	// Token: 0x0200001B RID: 27
	[eiz("eCSE")]
	[Serializable]
	public enum CombatSpeakEvent
	{
		// Token: 0x04000089 RID: 137
		Unknown,
		// Token: 0x0400008A RID: 138
		Battlecry_General = 10,
		// Token: 0x0400008B RID: 139
		Battlecry_Melee,
		// Token: 0x0400008C RID: 140
		Battlecry_Fists = 30,
		// Token: 0x0400008D RID: 141
		Battlecry_Hammer = 40,
		// Token: 0x0400008E RID: 142
		Battlecry_Knife = 50,
		// Token: 0x0400008F RID: 143
		Battlecry_Spear = 60,
		// Token: 0x04000090 RID: 144
		Battlecry_Sword = 65,
		// Token: 0x04000091 RID: 145
		Battlecry_SingleFirearm = 70,
		// Token: 0x04000092 RID: 146
		Battlecry_Shotgun,
		// Token: 0x04000093 RID: 147
		Battlecry_GrenadeLauncher,
		// Token: 0x04000094 RID: 148
		Battlecry_Burst = 80,
		// Token: 0x04000095 RID: 149
		Battlecry_EnergyWeapon = 100,
		// Token: 0x04000096 RID: 150
		Battlecry_ChemicalWeapon,
		// Token: 0x04000097 RID: 151
		Battlecry_StandardGrenade = 110,
		// Token: 0x04000098 RID: 152
		Battlecry_Firebomb = 120,
		// Token: 0x04000099 RID: 153
		Battlecry_Emp = 130,
		// Token: 0x0400009A RID: 154
		Battlecry_Crossbow = 140,
		// Token: 0x0400009B RID: 155
		Battlecry_Mind = 160,
		// Token: 0x0400009C RID: 156
		Battlecry_Frost = 170,
		// Token: 0x0400009D RID: 157
		Battlecry_Fire = 180,
		// Token: 0x0400009E RID: 158
		Battlecry_Telekinesis = 190,
		// Token: 0x0400009F RID: 159
		Battlecry_Electricity = 200,
		// Token: 0x040000A0 RID: 160
		Battlecry_Flashbang = 210,
		// Token: 0x040000A1 RID: 161
		Battlecry_Temporal = 220,
		// Token: 0x040000A2 RID: 162
		Hit_ResistedAll = 400,
		// Token: 0x040000A3 RID: 163
		Hit_ShieldedAll,
		// Token: 0x040000A4 RID: 164
		Hit_BlockedAll = 403,
		// Token: 0x040000A5 RID: 165
		Hit_General = 410,
		// Token: 0x040000A6 RID: 166
		Hit_CriticallyHit = 420,
		// Token: 0x040000A7 RID: 167
		Hit_MeleeBlunt = 425,
		// Token: 0x040000A8 RID: 168
		Hit_MeleeSharp,
		// Token: 0x040000A9 RID: 169
		Hit_Firearm = 430,
		// Token: 0x040000AA RID: 170
		Hit_BurningSensation = 440,
		// Token: 0x040000AB RID: 171
		Hit_Frost = 450,
		// Token: 0x040000AC RID: 172
		Hit_Frozen = 460,
		// Token: 0x040000AD RID: 173
		Hit_Tranquilized = 470,
		// Token: 0x040000AE RID: 174
		Hit_Flashbang = 480,
		// Token: 0x040000AF RID: 175
		Hit_Mind = 490,
		// Token: 0x040000B0 RID: 176
		Hit_Bolt = 520,
		// Token: 0x040000B1 RID: 177
		Hit_Kneecap = 540,
		// Token: 0x040000B2 RID: 178
		Hit_Caltrops = 560,
		// Token: 0x040000B3 RID: 179
		Hit_BearTrap = 570,
		// Token: 0x040000B4 RID: 180
		Hit_ToxicGas = 590,
		// Token: 0x040000B5 RID: 181
		Hit_LowHealth = 620,
		// Token: 0x040000B6 RID: 182
		Hit_Companion = 650,
		// Token: 0x040000B7 RID: 183
		Affliction_Burning = 800,
		// Token: 0x040000B8 RID: 184
		Affliction_Chilled = 810,
		// Token: 0x040000B9 RID: 185
		Affliction_Rooted = 820,
		// Token: 0x040000BA RID: 186
		Affliction_Enraged = 850,
		// Token: 0x040000BB RID: 187
		Affliction_Poisoned = 860,
		// Token: 0x040000BC RID: 188
		Affliction_Fear = 870,
		// Token: 0x040000BD RID: 189
		Affliction_BrokenRibs = 890,
		// Token: 0x040000BE RID: 190
		Affliction_MentalSubversion = 900,
		// Token: 0x040000BF RID: 191
		Affliction_Bleeding = 910,
		// Token: 0x040000C0 RID: 192
		Taunt_General = 1100,
		// Token: 0x040000C1 RID: 193
		Taunt_LowHealth = 1120,
		// Token: 0x040000C2 RID: 194
		Taunt_Chilled = 1130,
		// Token: 0x040000C3 RID: 195
		Taunt_Burning = 1140,
		// Token: 0x040000C4 RID: 196
		Taunt_Rooted = 1150,
		// Token: 0x040000C5 RID: 197
		Taunt_Stunned = 1160,
		// Token: 0x040000C6 RID: 198
		Taunt_Poisoned = 1190,
		// Token: 0x040000C7 RID: 199
		Taunt_Bleeding = 1220,
		// Token: 0x040000C8 RID: 200
		Taunt_Missed = 1230,
		// Token: 0x040000C9 RID: 201
		Consume_Antidote = 1400,
		// Token: 0x040000CA RID: 202
		Consume_Healing = 1410,
		// Token: 0x040000CB RID: 203
		Consume_Painkiller = 1420,
		// Token: 0x040000CC RID: 204
		Consume_Booster = 1430,
		// Token: 0x040000CD RID: 205
		Consume_Psi = 1440,
		// Token: 0x040000CE RID: 206
		Special_HeardNoise = 1600,
		// Token: 0x040000CF RID: 207
		Special_CallForHelp = 1610,
		// Token: 0x040000D0 RID: 208
		Special_RemoteCallForHelp = 1620,
		// Token: 0x040000D1 RID: 209
		Dying = 2000,
		// Token: 0x040000D2 RID: 210
		Custom1 = 3001,
		// Token: 0x040000D3 RID: 211
		Custom2,
		// Token: 0x040000D4 RID: 212
		Custom3,
		// Token: 0x040000D5 RID: 213
		Custom4,
		// Token: 0x040000D6 RID: 214
		Custom5
	}
}
