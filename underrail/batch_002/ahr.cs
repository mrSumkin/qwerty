using System;
using System.Runtime.Serialization;

// Token: 0x0200078B RID: 1931
[eiz("TCHHannaRF")]
[Serializable]
public sealed class ahr : egv, ISerializable
{
	// Token: 0x060030C5 RID: 12485 RVA: 0x0012C5E8 File Offset: 0x0012A7E8
	private ahr(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060030C6 RID: 12486 RVA: 0x0012C5F0 File Offset: 0x0012A7F0
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x060030C7 RID: 12487 RVA: 0x0012C5F4 File Offset: 0x0012A7F4
	public ahr()
	{
	}

	// Token: 0x060030C8 RID: 12488 RVA: 0x0012C600 File Offset: 0x0012A800
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 != null && A_0.ap9() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_tch_preservation_KillMateoCompleted", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_tch_preservation_KillMateoWHeadCompleted", new bool?(false)).Value;
				bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_tch_preservation_utilityStationCompleted", new bool?(false)).Value;
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_tch_preservation_TrackDownNevilCompleted", new bool?(false)).Value)
				{
					return 2f;
				}
				if (value3)
				{
					return 2.3f;
				}
				if (value || value2)
				{
					return 2.6f;
				}
				return 2.8f;
			}
		}
		return bhm.a;
	}
}
