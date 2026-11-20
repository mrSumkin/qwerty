using System;

namespace TimelapseVertigo.Rules.Characters
{
	// Token: 0x02000020 RID: 32
	[eiz("eCAI")]
	[Flags]
	[Serializable]
	public enum CharacterImmunities : long
	{
		// Token: 0x04000100 RID: 256
		None = 0L,
		// Token: 0x04000101 RID: 257
		MindAffecting = 1L,
		// Token: 0x04000102 RID: 258
		Placeholder = 2L,
		// Token: 0x04000103 RID: 259
		Stun = 4L,
		// Token: 0x04000104 RID: 260
		Incapacitation = 8L,
		// Token: 0x04000105 RID: 261
		Blind = 16L,
		// Token: 0x04000106 RID: 262
		MindControl = 32L,
		// Token: 0x04000107 RID: 263
		Chill = 64L,
		// Token: 0x04000108 RID: 264
		Freeze = 128L,
		// Token: 0x04000109 RID: 265
		Slow = 256L,
		// Token: 0x0400010A RID: 266
		Root = 512L,
		// Token: 0x0400010B RID: 267
		CriticalHits = 1024L,
		// Token: 0x0400010C RID: 268
		Bleeding = 2048L,
		// Token: 0x0400010D RID: 269
		Fear = 4096L,
		// Token: 0x0400010E RID: 270
		Burning = 8192L,
		// Token: 0x0400010F RID: 271
		Poison = 16384L,
		// Token: 0x04000110 RID: 272
		ShortCircuiting = 32768L,
		// Token: 0x04000111 RID: 273
		Dismantle = 65536L,
		// Token: 0x04000112 RID: 274
		Caltrops = 131072L,
		// Token: 0x04000113 RID: 275
		AcidPuddles = 262144L,
		// Token: 0x04000114 RID: 276
		Daze = 524288L,
		// Token: 0x04000115 RID: 277
		TemporalEffects = 1048576L,
		// Token: 0x04000116 RID: 278
		Unbalancing = 2097152L,
		// Token: 0x04000117 RID: 279
		Decapitation = 4194304L,
		// Token: 0x04000118 RID: 280
		Bilocation = 8388608L,
		// Token: 0x04000119 RID: 281
		AiScrambling = 16777216L,
		// Token: 0x0400011A RID: 282
		DirtyKickExtraStun = 33554432L,
		// Token: 0x0400011B RID: 283
		Biohazard = 67108864L,
		// Token: 0x0400011C RID: 284
		KneecapShot = 134217728L
	}
}
