using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules;

// Token: 0x02000B16 RID: 2838
[eiz("XPBLARCAJ")]
[Serializable]
public sealed class bzs : cze, ISerializable
{
	// Token: 0x06004194 RID: 16788 RVA: 0x001934D0 File Offset: 0x001916D0
	private bzs(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004195 RID: 16789 RVA: 0x001934DC File Offset: 0x001916DC
	public bzs()
	{
	}

	// Token: 0x06004196 RID: 16790 RVA: 0x001934E8 File Offset: 0x001916E8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		bu6 service = bpo.GetService<bu6>();
		if (serviceOrThrow.aqu() != null && service != null)
		{
			int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_e5_numberOfWaves", new int?(0)).Value;
			int value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_e5_numberOfInvaders", new int?(0)).Value;
			int value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_e5_invadersKilled", new int?(0)).Value;
			string classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_xpbl_e5_invadersType");
			int value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_e5_numberOfSpecialAttackers", new int?(0)).Value;
			int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("global_xpbl_aegisSecTroopersAvailable", new int?(0)).Value;
			int value5 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xpbl_expedition_jetSkiStrength", new int?(0)).Value;
			int value6 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xpbl_expedition_weaponSupply", new int?(0)).Value;
			int value7 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xpbl_expedition_techSupply", new int?(0)).Value;
			int value8 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xpbl_expedition_medicineSupply", new int?(0)).Value;
			bool value9 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_briggs_dead", new bool?(false)).Value;
			bool value10 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_yahota_dead", new bool?(false)).Value;
			bool value11 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_marcus_dead", new bool?(false)).Value;
			bool value12 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_ladelman_dead", new bool?(false)).Value;
			bool value13 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_le_doc_dead", new bool?(false)).Value;
			bool value14 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_e5_nagaActivated", new bool?(false)).Value;
			string classPropertyValue2 = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_xpbl_e5_nagaAttitude");
			double value15 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<double>("npc_xpbl_e5_naga_health", new double?(0.0)).Value;
			int value16 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_e5_lemurianTurretsActive", new int?(0)).Value;
			bool value17 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_acquireHealingPlant_completed", new bool?(false)).Value;
			int value18 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_e5_battleNumber", new int?(0)).Value;
			int num2 = 0;
			int num3 = 0;
			if (service.aq2() == GameDifficulty.Hard)
			{
				num3 = 10;
			}
			else if (service.aq2() != GameDifficulty.Dominating)
			{
				num3 = 15;
			}
			if (classPropertyValue == "Pirates")
			{
				num3 += 5;
			}
			num2 += num;
			num2 += value8 * 2;
			num2 += value7 * 2;
			num2 += value6 * 2;
			if (!value10)
			{
				num2 += 6;
			}
			if (value14 && value15 > 0.0)
			{
				if (classPropertyValue2 == "ally")
				{
					num2 += (int)(0.05 * value15);
				}
				else
				{
					num -= 5;
				}
				if (value15 > 0.0)
				{
					serviceOrThrow.aqu().r()["npc_xpbl_e5_naga_health"] = 0;
					serviceOrThrow.aqu().r()["loc_xpbl_e5_killNaga"] = true;
				}
			}
			if (value17)
			{
				num2 += 5;
			}
			num2 += value16 * 5;
			num2 += value5 * 2;
			num3 += value2 * value - value3 + value4 * 2;
			if (num > 0)
			{
				int num4 = num3 - num2;
				int num5 = 0;
				int num6 = 0;
				for (int i = 0; i < num4; i++)
				{
					if (num6 >= 3)
					{
						num5++;
						num6 = 0;
					}
					num6++;
				}
				num -= num5;
				serviceOrThrow.aqu().r()["global_xpbl_aegisSecTroopersAvailable"] = num;
				if (num < 0)
				{
					int num7 = Math.Abs(num);
					for (int j = 0; j < num7; j++)
					{
						if (j > 3)
						{
							serviceOrThrow.aqu().r()["npc_xpbl_yahota_dead"] = true;
						}
						if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_xpbl_aegis_importantNpcsCanJoinBattle", new bool?(false)).Value)
						{
							if (j > 6)
							{
								serviceOrThrow.aqu().r()["npc_xpbl_marcus_dead"] = true;
							}
							if (j > 9)
							{
								serviceOrThrow.aqu().r()["npc_xpbl_ladelman_dead"] = true;
							}
							if (j > 12)
							{
								serviceOrThrow.aqu().r()["npc_xpbl_le_doc_dead"] = true;
							}
							if (j > 15)
							{
								serviceOrThrow.aqu().r()["npc_xpbl_briggs_dead"] = true;
							}
							if (j > 20)
							{
								this.a(serviceOrThrow, classPropertyValue);
							}
						}
						else
						{
							this.a(serviceOrThrow, classPropertyValue);
						}
					}
				}
			}
			else
			{
				this.a(serviceOrThrow, classPropertyValue);
			}
			new hn().ym(A_0, A_1, null);
		}
	}

	// Token: 0x06004197 RID: 16791 RVA: 0x00193AD4 File Offset: 0x00191CD4
	private void a(cnk A_0, string A_1)
	{
		A_0.aqu().r()["global_xpbl_expeditionDestroyed"] = true;
		if (A_1 == "Sormirbaren")
		{
			A_0.aqu().r()["global_xpbl_expeditionDestroyed_bySavages"] = true;
		}
		else
		{
			A_0.aqu().r()["faction_xpbl_pir_gotAegisJets"] = true;
			A_0.aqu().r()["event_pir_meeting_jetsOfferLevel"] = 4;
			A_0.aqu().r()["global_xpbl_expeditionDestroyed_byPirates"] = true;
		}
		A_0.aqu().r()["npc_xpbl_yahota_dead"] = true;
		A_0.aqu().r()["npc_xpbl_marcus_dead"] = true;
		A_0.aqu().r()["npc_xpbl_ladelman_dead"] = true;
		A_0.aqu().r()["npc_xpbl_le_doc_dead"] = true;
		A_0.aqu().r()["npc_xpbl_briggs_dead"] = true;
		A_0.aqu().a(new bw0("xpbl_fu", new cik(), 1));
		new ain().ym(null, null, null);
		A_0.aqz().atb("xpbl_expeditionNoMore", true);
	}
}
