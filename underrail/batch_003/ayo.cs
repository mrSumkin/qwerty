using System;
using System.Runtime.Serialization;

// Token: 0x02000786 RID: 1926
[eiz("RcDocRF")]
[Serializable]
public sealed class ayo : egv, ISerializable
{
	// Token: 0x060030B1 RID: 12465 RVA: 0x0012C124 File Offset: 0x0012A324
	private ayo(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060030B2 RID: 12466 RVA: 0x0012C12C File Offset: 0x0012A32C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x060030B3 RID: 12467 RVA: 0x0012C130 File Offset: 0x0012A330
	public ayo()
	{
	}

	// Token: 0x060030B4 RID: 12468 RVA: 0x0012C13C File Offset: 0x0012A33C
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 != null && A_0.ap9() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_cc_facelessRetreated", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_rcshop_buzzerFreed", new bool?(false)).Value;
				bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_rc1_trainSupplies_arrived", new bool?(false)).Value;
				bool value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_doc_questcomplete", new bool?(false)).Value;
				float num = 3f;
				if (value4)
				{
					num -= 0.5f;
				}
				if (value)
				{
					num -= 0.4f;
				}
				if (value2)
				{
					num -= 0.2f;
				}
				if (value3)
				{
					num -= 0.4f;
				}
				return Math.Max(bhm.c, num);
			}
		}
		return bhm.a;
	}
}
