using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules;

// Token: 0x02000AF2 RID: 2802
[eiz("XPBLLEHCSJ")]
[Serializable]
public sealed class abb : cze, ISerializable
{
	// Token: 0x06004116 RID: 16662 RVA: 0x0018CD3C File Offset: 0x0018AF3C
	private abb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004117 RID: 16663 RVA: 0x0018CD48 File Offset: 0x0018AF48
	public abb()
	{
	}

	// Token: 0x06004118 RID: 16664 RVA: 0x0018CD54 File Offset: 0x0018AF54
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_le_openedFort", new bool?(false)).Value;
			bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_beginExpedition", new bool?(false)).Value;
			bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_rf_locatedMicrochipEncoder", new bool?(false)).Value;
			bool value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("interface_xpbl_mc_microChipImplanter_extractedChipFromPhilsHand", new bool?(false)).Value;
			bool value5 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_sc_foundDispatcherCoordinates", new bool?(false)).Value;
			bool value6 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("xpbl_ds3_acornTaken", new bool?(false)).Value;
			int value7 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xpbl_expedition_weaponSupply", new int?(0)).Value;
			int value8 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xpbl_expedition_techSupply", new int?(0)).Value;
			int value9 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("faction_xpbl_expedition_medicineSupply", new int?(0)).Value;
			int value10 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_e5_battleNumber", new int?(0)).Value;
			bool value11 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_xpbl_sormirbaren_defeated", new bool?(false)).Value;
			bu6 service = bpo.GetService<bu6>();
			if (service != null && service.aq2() != GameDifficulty.Easy)
			{
				List<int> list = new List<int>
				{
					value7,
					value8,
					value9
				};
				bool value12 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_fu_pirateAttackHandled", new bool?(false)).Value;
				bool value13 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorKidnapped", new bool?(false)).Value;
				bool value14 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_saveTheProfessor_completed", new bool?(false)).Value;
				bool flag = false;
				if (value12 && (!value13 || (value13 && value14)))
				{
					flag = true;
				}
				if (flag || !value2 || value5)
				{
					TimeSpan? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>("faction_xpbl_expedition_timeTillNextSupplyCheck", null);
					int num = 120;
					if (service.aq2() >= GameDifficulty.Dominating)
					{
						num -= 40;
					}
					else if (service.aq2() >= GameDifficulty.Hard)
					{
						num -= 20;
					}
					if (primitivePropertyValue == null || serviceOrThrow.aqu().p() >= primitivePropertyValue)
					{
						int num2 = 0;
						for (int i = 0; i < list.Count; i++)
						{
							int num3 = 0;
							if (i >= 2 || !value11)
							{
								if (((i == 2 && value4) || (i < 2 && value10 >= 3 + num2)) && list[i] > 3)
								{
									num3++;
								}
								else if (((i == 2 && value5) || (i < 2 && value10 >= 4 + num2)) && list[i] > 2)
								{
									num3++;
								}
								else if (((i == 2 && value6) || (i < 2 && value10 >= 5 + num2)) && list[i] > 1)
								{
									num3++;
								}
								if (i != 1)
								{
									if (i != 2)
									{
										serviceOrThrow.aqu().r()["faction_xpbl_expedition_weaponSupply"] = value7 - num3;
									}
									else
									{
										serviceOrThrow.aqu().r()["faction_xpbl_expedition_medicineSupply"] = value9 - num3;
									}
								}
								else
								{
									serviceOrThrow.aqu().r()["faction_xpbl_expedition_techSupply"] = value8 - num3;
								}
								if (num3 != 0)
								{
									num2++;
								}
							}
						}
						serviceOrThrow.aqu().r()["faction_xpbl_expedition_timeTillNextSupplyCheck"] = serviceOrThrow.aqu().p() + TimeSpan.FromMinutes((double)(num + cuo.a.Next(0, 10)));
					}
				}
			}
		}
	}
}
