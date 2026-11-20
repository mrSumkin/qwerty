using System;
using System.Runtime.Serialization;

namespace TimelapseVertigo.Rules
{
	// Token: 0x0200002C RID: 44
	[eiz("GDS")]
	[Serializable]
	public sealed class GameDifficultySettings : ISerializable
	{
		// Token: 0x060000A1 RID: 161 RVA: 0x00004808 File Offset: 0x00002A08
		private GameDifficultySettings(SerializationInfo info, StreamingContext ctx)
		{
			this.EncounterDifficulty = (GameDifficulty)info.GetInt32("E");
			this.PuzzleDifficulty = (GameDifficulty)info.GetInt32("P");
			this.PlayerHealthModifier = info.GetSingle("HP");
			this.NpcHealthModifier = info.GetSingle("HN");
			this.NpcBossHealthModifier = info.GetSingle("HB");
			this.HealingModifier = info.GetSingle("H");
			this.HealingCooldown = info.GetInt32("HCD");
			this.NpcSkillModifier = info.GetSingle("SN");
			this.NpcBossSkillModifier = info.GetSingle("SB");
			this.NpcCritChanceBonus = info.GetSingle("CC");
			this.SoldItemValueModifier = info.GetSingle("S");
			this.MerchantPurchasingPower = info.GetSingle("B");
			this.CarryCapacityMod = info.GetSingle("CM");
			this.ItemDegradationRate = info.GetSingle("D");
			this.ZoneTransitionApCost = info.GetInt32("T");
			this.MaxLevel = (info.GetValue("L", typeof(int?)) as int?);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000049C4 File Offset: 0x00002BC4
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("E", (int)this.EncounterDifficulty);
			info.AddValue("P", (int)this.PuzzleDifficulty);
			info.AddValue("HP", this.PlayerHealthModifier);
			info.AddValue("HN", this.NpcHealthModifier);
			info.AddValue("HB", this.NpcBossHealthModifier);
			info.AddValue("H", this.HealingModifier);
			info.AddValue("HCD", this.HealingCooldown);
			info.AddValue("SN", this.NpcSkillModifier);
			info.AddValue("SB", this.NpcBossSkillModifier);
			info.AddValue("CC", this.NpcCritChanceBonus);
			info.AddValue("S", this.SoldItemValueModifier);
			info.AddValue("B", this.MerchantPurchasingPower);
			info.AddValue("CM", this.CarryCapacityMod);
			info.AddValue("D", this.ItemDegradationRate);
			info.AddValue("T", this.ZoneTransitionApCost);
			info.AddValue("L", this.MaxLevel);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00004AE8 File Offset: 0x00002CE8
		public bool AdvancedAi
		{
			get
			{
				return this.EncounterDifficulty >= GameDifficulty.Normal;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00004AF8 File Offset: 0x00002CF8
		public bool SuperAi
		{
			get
			{
				return this.EncounterDifficulty >= GameDifficulty.Hard;
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00004B08 File Offset: 0x00002D08
		public GameDifficultySettings()
		{
		}

		// Token: 0x04000158 RID: 344
		public GameDifficulty EncounterDifficulty = GameDifficulty.Normal;

		// Token: 0x04000159 RID: 345
		public GameDifficulty PuzzleDifficulty = GameDifficulty.Normal;

		// Token: 0x0400015A RID: 346
		[do2(1f, 50f, true)]
		public int? MaxLevel;

		// Token: 0x0400015B RID: 347
		[do2(0.2f, 10f, false)]
		public float PlayerHealthModifier = 1.5f;

		// Token: 0x0400015C RID: 348
		[do2(0.2f, 10f, false)]
		public float NpcHealthModifier = 1f;

		// Token: 0x0400015D RID: 349
		[do2(0.2f, 10f, false)]
		public float NpcBossHealthModifier = 1f;

		// Token: 0x0400015E RID: 350
		[do2(0.2f, 10f, false)]
		public float HealingModifier = 1f;

		// Token: 0x0400015F RID: 351
		[do2(1f, 20f, true)]
		public int HealingCooldown = 6;

		// Token: 0x04000160 RID: 352
		[do2(0.2f, 3f, false)]
		public float NpcSkillModifier = 1f;

		// Token: 0x04000161 RID: 353
		[do2(0.2f, 3f, false)]
		public float NpcBossSkillModifier = 1f;

		// Token: 0x04000162 RID: 354
		[do2(0f, 1f, false)]
		public float NpcCritChanceBonus;

		// Token: 0x04000163 RID: 355
		[do2(0f, 60f, true)]
		public int ZoneTransitionApCost;

		// Token: 0x04000164 RID: 356
		[do2(0.1f, 1f, false)]
		public float SoldItemValueModifier = 1f;

		// Token: 0x04000165 RID: 357
		[do2(0.1f, 10f, false)]
		public float MerchantPurchasingPower = 1f;

		// Token: 0x04000166 RID: 358
		[do2(0.1f, 10f, false)]
		public float CarryCapacityMod = 1f;

		// Token: 0x04000167 RID: 359
		[do2(0.1f, 10f, false)]
		public float ItemDegradationRate = 1f;
	}
}
