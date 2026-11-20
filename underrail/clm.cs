using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000AFC RID: 2812
[eiz("XPBLPIRDGP")]
[Serializable]
public sealed class clm : cze, ISerializable
{
	// Token: 0x06004135 RID: 16693 RVA: 0x0018E0CC File Offset: 0x0018C2CC
	private clm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004136 RID: 16694 RVA: 0x0018E0D8 File Offset: 0x0018C2D8
	public clm()
	{
	}

	// Token: 0x06004137 RID: 16695 RVA: 0x0018E0E4 File Offset: 0x0018C2E4
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
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_firstRaid_completed", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_completed", new bool?(false)).Value;
				bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_completed", new bool?(false)).Value;
				bool value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_firstRaid_completed_paid", new bool?(false)).Value;
				bool value5 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_completed_paid", new bool?(false)).Value;
				bool value6 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_completed_paid", new bool?(false)).Value;
				bool value7 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_reportedNexus", new bool?(false)).Value;
				bool value8 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_reportedHorticulture", new bool?(false)).Value;
				bool value9 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_reportedMedical", new bool?(false)).Value;
				bool value10 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_reportedSecurity", new bool?(false)).Value;
				bool value11 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_reportedAbyssal", new bool?(false)).Value;
				bool value12 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_xpbl_pir_archiveUnlocked", new bool?(false)).Value;
				bool value13 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_xpbl_pir_grim_reportedMines", new bool?(false)).Value;
				bool value14 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_reportedNexus_paid", new bool?(false)).Value;
				bool value15 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_reportedHorticulture_paid", new bool?(false)).Value;
				bool value16 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_reportedMedical_paid", new bool?(false)).Value;
				bool value17 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_reportedSecurity_paid", new bool?(false)).Value;
				bool value18 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_reportedAbyssal_paid", new bool?(false)).Value;
				bool value19 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_xpbl_pir_archiveUnlocked_paid", new bool?(false)).Value;
				bool value20 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_xpbl_pir_grim_reportedMines_paid", new bool?(false)).Value;
				string classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("global_xpbl_acorn_gaveTo");
				int value21 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("npc_xpbl_pir_grim_acornBonus", new int?(0)).Value;
				bool value22 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_grim_acornPaid", new bool?(false)).Value;
				int num = 0;
				if (value && !value4)
				{
					if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_firstRaid_goAlone", new bool?(false)).Value)
					{
						num += 200;
					}
					num += 300;
					serviceOrThrow.aqu().r()["quests_xpbl_pirates_firstRaid_completed_paid"] = true;
				}
				if (value2 && !value5)
				{
					if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_goAlone", new bool?(false)).Value)
					{
						num += 400;
					}
					num += 800;
					serviceOrThrow.aqu().r()["quests_xpbl_pirates_secondRaid_completed_paid"] = true;
				}
				if (value3 && !value6)
				{
					if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_goAlone", new bool?(false)).Value)
					{
						num += 300;
					}
					num += 400;
					serviceOrThrow.aqu().r()["quests_xpbl_pirates_theRig_completed_paid"] = true;
				}
				if (value7 && !value14)
				{
					num += 100;
					serviceOrThrow.aqu().r()["npc_xpbl_pir_grim_reportedNexus_paid"] = true;
				}
				if (value8 && !value15)
				{
					num += 200;
					serviceOrThrow.aqu().r()["npc_xpbl_pir_grim_reportedHorticulture_paid"] = true;
				}
				if (value9 && !value16)
				{
					num += 300;
					serviceOrThrow.aqu().r()["npc_xpbl_pir_grim_reportedMedical_paid"] = true;
				}
				if (value10 && !value17)
				{
					num += 400;
					serviceOrThrow.aqu().r()["npc_xpbl_pir_grim_reportedSecurity_paid"] = true;
				}
				if (value11 && !value18)
				{
					num += 500;
					serviceOrThrow.aqu().r()["npc_xpbl_pir_grim_reportedAbyssal_paid"] = true;
				}
				if (value12 && !value19)
				{
					num += 300;
					serviceOrThrow.aqu().r()["faction_xpbl_pir_archiveUnlocked_paid"] = true;
				}
				if (value13 && !value20)
				{
					num += 300;
					serviceOrThrow.aqu().r()["faction_xpbl_pir_grim_reportedMines_paid"] = true;
				}
				if (classPropertyValue != null && classPropertyValue == "grim" && !value22)
				{
					num += 1000 + value21;
					serviceOrThrow.aqu().r()["npc_xpbl_pir_grim_acornPaid"] = true;
				}
				if (num != 0)
				{
					coh coh = new d48(ez2.CreateDefinitonProvider<a54>("currency\\StygianCoin"))
					{
						Stacks = num
					};
					if (coh != null)
					{
						mk mk = new mk();
						mk.StaticItems.z3(coh, true);
						mk.GiveTo = bvl.d;
						mk.PublishEventsForPlayer = true;
						mk.ym(A_0, A_1, null);
						serviceOrThrow.aqu().r()["npc_xpbl_pir_donnie_hasMoneyForPlayer"] = true;
						serviceOrThrow.aqu().r()["loc_xpbl_pir_currentPaycheck"] = num;
					}
				}
			}
		}
	}
}
