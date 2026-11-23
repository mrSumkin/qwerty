using System;
using System.Runtime.Serialization;

// Token: 0x020007A1 RID: 1953
[eiz("XPBLPIRCalamityRF")]
[Serializable]
public sealed class b9d : egv, ISerializable
{
	// Token: 0x0600311D RID: 12573 RVA: 0x0012DC28 File Offset: 0x0012BE28
	private b9d(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600311E RID: 12574 RVA: 0x0012DC30 File Offset: 0x0012BE30
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x0600311F RID: 12575 RVA: 0x0012DC34 File Offset: 0x0012BE34
	public b9d()
	{
	}

	// Token: 0x06003120 RID: 12576 RVA: 0x0012DC40 File Offset: 0x0012BE40
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 != null && A_0.ap9() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_calamity_talkFlinger_beat", new bool?(false)).Value)
				{
					return bhm.c;
				}
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_firstRaid_completed", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_completed", new bool?(false)).Value;
				bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_completed", new bool?(false)).Value;
				float val = 3f;
				if (value3)
				{
					val = 1.5f;
				}
				else if (value2)
				{
					val = 2f;
				}
				else if (value)
				{
					val = bhm.a;
				}
				return Math.Max(bhm.c, val);
			}
		}
		return bhm.a;
	}
}
