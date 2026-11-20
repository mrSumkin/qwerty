using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B13 RID: 2835
[eiz("XPBLLEMGP")]
[Serializable]
public sealed class eb : cze, ISerializable
{
	// Token: 0x0600418B RID: 16779 RVA: 0x00192220 File Offset: 0x00190420
	private eb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600418C RID: 16780 RVA: 0x0019222C File Offset: 0x0019042C
	public eb()
	{
	}

	// Token: 0x0600418D RID: 16781 RVA: 0x00192234 File Offset: 0x00190434
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v().b() != null)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_xpbl_savageInvasion_completed", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_briggs_noFirstPaycheck", new bool?(false)).Value;
				bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_briggs_payReduced", new bool?(false)).Value;
				bool value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_xpbl_le_finishedFortEntrance", new bool?(false)).Value;
				bool value5 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_investigateNexus_completed", new bool?(false)).Value;
				bool value6 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_investigateHorticulture_completed", new bool?(false)).Value;
				bool value7 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_investigateMedical_completed", new bool?(false)).Value;
				bool value8 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_investigateCompound_completed", new bool?(false)).Value;
				bool value9 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_finalDungeon_completed", new bool?(false)).Value;
				bool value10 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_saveTheProfessor_completed", new bool?(false)).Value;
				bool value11 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_le_marcus_informedTechnician", new bool?(false)).Value;
				bool value12 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_le_campHasAcquiredMines", new bool?(false)).Value;
				bool value13 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_e5_nagaActivated", new bool?(false)).Value;
				string classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_xpbl_e5_nagaAttitude");
				bool value14 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("interface_xpbl_fu_securityConsole_turretsActivated", new bool?(false)).Value;
				bool value15 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_xpbl_savageInvasion_completed_paid", new bool?(false)).Value;
				bool value16 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_xpbl_le_finishedFortEntrance_paid", new bool?(false)).Value;
				bool value17 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_investigateNexus_completed_paid", new bool?(false)).Value;
				bool value18 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_investigateHorticulture_completed_paid", new bool?(false)).Value;
				bool value19 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_investigateMedical_completed_paid", new bool?(false)).Value;
				bool value20 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_investigateCompound_completed_paid", new bool?(false)).Value;
				bool value21 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_finalDungeon_completed_paid", new bool?(false)).Value;
				bool value22 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_saveTheProfessor_completed_paid", new bool?(false)).Value;
				bool value23 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_le_marcus_informedTechnician_paid", new bool?(false)).Value;
				bool value24 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_campsDefenses_mines_paid", new bool?(false)).Value;
				bool value25 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_campsDefenses_naga_paid", new bool?(false)).Value;
				bool value26 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_campsDefenses_turrets__paid", new bool?(false)).Value;
				string classPropertyValue2 = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("npc_xpbl_as_todd_finalDestination");
				bool value27 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_todd_paid", new bool?(false)).Value;
				string classPropertyValue3 = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("global_xpbl_acorn_gaveTo");
				int value28 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("npc_xpbl_le_oldfield_acornBonus", new int?(0)).Value;
				bool value29 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_le_oldfield_acornPaid", new bool?(false)).Value;
				int num = 0;
				float num2 = value3 ? 0.5f : 1f;
				if (value && !value15 && (!value2 || (value2 && value11)))
				{
					num += 300;
					serviceOrThrow.aqu().r()["quest_xpbl_savageInvasion_completed_paid"] = true;
				}
				if (value4 && !value16)
				{
					num += 350;
					serviceOrThrow.aqu().r()["global_xpbl_le_finishedFortEntrance_paid"] = true;
				}
				if (value5 && !value17)
				{
					num += 400;
					serviceOrThrow.aqu().r()["quests_xpbl_investigateNexus_completed_paid"] = true;
				}
				if (value6 && !value18)
				{
					num += 400;
					serviceOrThrow.aqu().r()["quests_xpbl_investigateHorticulture_completed_paid"] = true;
				}
				if (value7 && !value19)
				{
					num += 500;
					serviceOrThrow.aqu().r()["quests_xpbl_investigateMedical_completed_paid"] = true;
				}
				if (value8 && !value20)
				{
					num += 500;
					serviceOrThrow.aqu().r()["quests_xpbl_investigateCompound_completed_paid"] = true;
				}
				if (value9 && !value21)
				{
					num += 1000;
					serviceOrThrow.aqu().r()["quests_xpbl_finalDungeon_completed_paid"] = true;
				}
				if (value10 && !value22)
				{
					num += 700;
					serviceOrThrow.aqu().r()["quests_xpbl_expedition_saveTheProfessor_completed_paid"] = true;
				}
				if (value11 && !value23)
				{
					num += 600;
					serviceOrThrow.aqu().r()["npc_xpbl_le_marcus_informedTechnician_paid"] = true;
				}
				if (value12 && !value24)
				{
					num += 500;
					serviceOrThrow.aqu().r()["quests_xpbl_expedition_campsDefenses_mines_paid"] = true;
				}
				if (value13 && classPropertyValue != null && classPropertyValue == "ally" && !value25)
				{
					num += 500;
					serviceOrThrow.aqu().r()["quests_xpbl_expedition_campsDefenses_naga_paid"] = true;
				}
				if (value14 && !value26)
				{
					num += 200;
					serviceOrThrow.aqu().r()["quests_xpbl_expedition_campsDefenses_turrets__paid"] = true;
				}
				if (classPropertyValue2 != null && classPropertyValue2 == "expedition" && !value27)
				{
					num += 1000;
					serviceOrThrow.aqu().r()["quests_xpbl_expedition_todd_paid"] = true;
				}
				if (classPropertyValue3 != null && classPropertyValue3 == "oldfield" && !value29)
				{
					num += 1000 + value28;
					serviceOrThrow.aqu().r()["npc_xpbl_le_oldfield_acornPaid"] = true;
				}
				if (num != 0)
				{
					coh coh = new d48(ez2.CreateDefinitonProvider<a54>("currency\\StygianCoin"))
					{
						Stacks = (int)((float)num * num2)
					};
					if (coh != null)
					{
						mk mk = new mk();
						mk.StaticItems.z3(coh, true);
						mk.GiveTo = bvl.d;
						mk.PublishEventsForPlayer = true;
						mk.ym(A_0, A_1, null);
						serviceOrThrow.aqu().r()["npc_xpbl_le_marcus_hasMoneyForPlayer"] = true;
						serviceOrThrow.aqu().r()["loc_xpbl_le_currentPaycheck"] = (int)((float)num * num2);
					}
				}
			}
		}
	}
}
