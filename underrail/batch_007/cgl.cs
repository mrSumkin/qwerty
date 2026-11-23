using System;
using System.Runtime.Serialization;

// Token: 0x02000784 RID: 1924
[eiz("RcBarkeeperRF")]
[Serializable]
public sealed class cgl : egv, ISerializable
{
	// Token: 0x060030A9 RID: 12457 RVA: 0x0012BE24 File Offset: 0x0012A024
	private cgl(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060030AA RID: 12458 RVA: 0x0012BE2C File Offset: 0x0012A02C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x060030AB RID: 12459 RVA: 0x0012BE30 File Offset: 0x0012A030
	public cgl()
	{
	}

	// Token: 0x060030AC RID: 12460 RVA: 0x0012BE3C File Offset: 0x0012A03C
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
				bool value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_rc_barkeeper_bill_leftFirstTime", new bool?(false)).Value;
				float num = 3f;
				if (value4)
				{
					num += 0.2f;
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
