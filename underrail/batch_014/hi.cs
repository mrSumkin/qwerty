using System;
using System.Runtime.Serialization;

// Token: 0x02000787 RID: 1927
[eiz("RcTravisRF")]
[Serializable]
public sealed class hi : egv, ISerializable
{
	// Token: 0x060030B5 RID: 12469 RVA: 0x0012C250 File Offset: 0x0012A450
	private hi(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060030B6 RID: 12470 RVA: 0x0012C258 File Offset: 0x0012A458
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x060030B7 RID: 12471 RVA: 0x0012C25C File Offset: 0x0012A45C
	public hi()
	{
	}

	// Token: 0x060030B8 RID: 12472 RVA: 0x0012C268 File Offset: 0x0012A468
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
				float num = 3f;
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
