using System;
using System.Collections.Generic;
using System.Diagnostics;
using TimelapseVertigo.Rules;

// Token: 0x0200214B RID: 8523
[s3("1.1.1.2_CampSupplyDeductionFix", "1.1.1.2")]
public sealed class bfg : cwo
{
	// Token: 0x0600C8DC RID: 51420 RVA: 0x0046E500 File Offset: 0x0046C700
	public bool ee(cyt A_0)
	{
		try
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("playerEnteredBlackSea", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionDestroyed", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionUndeployed", new bool?(false)).Value)
			{
				bool value = A_0.r().GetPrimitivePropertyValue<bool>("global_beginExpedition", new bool?(false)).Value;
				bool value2 = A_0.r().GetPrimitivePropertyValue<bool>("interface_xpbl_mc_microChipImplanter_extractedChipFromPhilsHand", new bool?(false)).Value;
				bool value3 = A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_sc_foundDispatcherCoordinates", new bool?(false)).Value;
				bool value4 = A_0.r().GetPrimitivePropertyValue<bool>("xpbl_ds3_acornTaken", new bool?(false)).Value;
				bool value5 = A_0.r().GetPrimitivePropertyValue<bool>("loc_mu_gaveMedicine", new bool?(false)).Value;
				int value6 = A_0.r().GetPrimitivePropertyValue<int>("event_pir_meeting_weaponsOfferLevel", new int?(0)).Value;
				int value7 = A_0.r().GetPrimitivePropertyValue<int>("event_pir_meeting_techOfferLevel", new int?(0)).Value;
				int num = A_0.r().GetPrimitivePropertyValue<int>("event_pir_meeting_medicineOfferLevel", new int?(0)).Value;
				int value8 = A_0.r().GetPrimitivePropertyValue<int>("faction_xpbl_expedition_weaponSupply", new int?(0)).Value;
				int value9 = A_0.r().GetPrimitivePropertyValue<int>("faction_xpbl_expedition_techSupply", new int?(0)).Value;
				int value10 = A_0.r().GetPrimitivePropertyValue<int>("faction_xpbl_expedition_medicineSupply", new int?(0)).Value;
				int value11 = A_0.r().GetPrimitivePropertyValue<int>("loc_xpbl_e5_battleNumber", new int?(0)).Value;
				bool value12 = A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_sormirbaren_defeated", new bool?(false)).Value;
				bu6 service = bpo.GetService<bu6>();
				if (service != null && service.aq2() != GameDifficulty.Easy)
				{
					if (value5 && num < 3)
					{
						num++;
					}
					List<int> list = new List<int>
					{
						value8,
						value9,
						value10
					};
					List<int> list2 = new List<int>
					{
						value6,
						value7,
						num
					};
					bool value13 = A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_fu_pirateAttackHandled", new bool?(false)).Value;
					bool value14 = A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorKidnapped", new bool?(false)).Value;
					bool value15 = A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_saveTheProfessor_completed", new bool?(false)).Value;
					bool flag = false;
					if (value13 && (!value14 || (value14 && value15)))
					{
						flag = true;
					}
					if (flag || !value || value3)
					{
						for (int i = 0; i < list.Count; i++)
						{
							if (i >= 2 || !value12)
							{
								if (((i == 2 && value2) || (i < 2 && value11 < 4)) && list[i] < 3)
								{
									list[i] = Math.Max(1, 3 - list2[i]);
								}
								else if (((i == 2 && value3) || (i < 2 && value11 < 5)) && list[i] < 2)
								{
									list[i] = Math.Max(1, 2 - list2[i]);
								}
								if (i != 1)
								{
									if (i != 2)
									{
										A_0.r()["faction_xpbl_expedition_weaponSupply"] = list[i];
									}
									else
									{
										A_0.r()["faction_xpbl_expedition_medicineSupply"] = list[i];
									}
								}
								else
								{
									A_0.r()["faction_xpbl_expedition_techSupply"] = list[i];
								}
							}
						}
					}
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}
}
