using System;
using System.Runtime.Serialization;

// Token: 0x0200079F RID: 1951
[eiz("XPBLSavageRF")]
[Serializable]
public sealed class xl : egv, ISerializable
{
	// Token: 0x06003115 RID: 12565 RVA: 0x0012D8B0 File Offset: 0x0012BAB0
	private xl(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003116 RID: 12566 RVA: 0x0012D8B8 File Offset: 0x0012BAB8
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x06003117 RID: 12567 RVA: 0x0012D8BC File Offset: 0x0012BABC
	public xl()
	{
	}

	// Token: 0x06003118 RID: 12568 RVA: 0x0012D8C4 File Offset: 0x0012BAC4
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 != null && A_0.ap9() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_xpbl_le_finishedFortEntrance", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_investigateNexus_completed", new bool?(false)).Value;
				bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_investigateHorticulture_completed", new bool?(false)).Value;
				bool value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_investigateMedical_completed", new bool?(false)).Value;
				bool value5 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_investigateCompound_completed", new bool?(false)).Value;
				bool value6 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_finalDungeon_completed", new bool?(false)).Value;
				bool value7 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_saveTheProfessor_completed", new bool?(false)).Value;
				bool value8 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_le_marcus_informedTechnician", new bool?(false)).Value;
				bool value9 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_le_campHasAcquiredMines", new bool?(false)).Value;
				bool value10 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_e5_nagaActivated", new bool?(false)).Value;
				string classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_xpbl_e5_nagaAttitude");
				bool value11 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("interface_xpbl_fu_securityConsole_turretsActivated", new bool?(false)).Value;
				float num = 3f;
				if (value6)
				{
					return bhm.c;
				}
				if (value)
				{
					num -= 0.15f;
				}
				if (value2 || value3)
				{
					num -= 0.15f;
				}
				if (value4)
				{
					num -= 0.2f;
				}
				if (value5)
				{
					num -= 0.2f;
				}
				if (value7 || value8)
				{
					num -= 0.5f;
				}
				if (value9)
				{
					num -= 0.2f;
				}
				if (value10 && !string.IsNullOrEmpty(classPropertyValue) && classPropertyValue == "ally")
				{
					num -= 0.2f;
				}
				if (value11)
				{
					num -= 0.2f;
				}
				return Math.Max(bhm.c, num);
			}
		}
		return bhm.a;
	}
}
