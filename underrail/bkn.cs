using System;
using System.Runtime.Serialization;

// Token: 0x020007A5 RID: 1957
[eiz("XPBLPIRKatyaRF")]
[Serializable]
public sealed class bkn : egv, ISerializable
{
	// Token: 0x0600312D RID: 12589 RVA: 0x0012E254 File Offset: 0x0012C454
	private bkn(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600312E RID: 12590 RVA: 0x0012E25C File Offset: 0x0012C45C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x0600312F RID: 12591 RVA: 0x0012E260 File Offset: 0x0012C460
	public bkn()
	{
	}

	// Token: 0x06003130 RID: 12592 RVA: 0x0012E268 File Offset: 0x0012C468
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 != null && A_0.ap9() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_katya_recognizedPsi", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_xpbl_pir_katya_toldPast", new bool?(false)).Value;
				int value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("SpecialMerchandiseLevel_katya", new int?(-1)).Value;
				float num = bhm.b;
				if (value || value2)
				{
					num -= 1f;
				}
				if (value3 >= 0)
				{
					num -= 0.5f;
				}
				return Math.Max(bhm.c, num);
			}
		}
		return bhm.a;
	}
}
