using System;
using System.Runtime.Serialization;

// Token: 0x020009EC RID: 2540
[eiz("XPBLCVW2SPR")]
[Serializable]
public sealed class bac : bdw, ISerializable
{
	// Token: 0x06003CB8 RID: 15544 RVA: 0x001687E0 File Offset: 0x001669E0
	private bac(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003CB9 RID: 15545 RVA: 0x001687E8 File Offset: 0x001669E8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003CBA RID: 15546 RVA: 0x001687EC File Offset: 0x001669EC
	public bac()
	{
	}

	// Token: 0x06003CBB RID: 15547 RVA: 0x001687F8 File Offset: 0x001669F8
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && A_1.r().GetPrimitivePropertyValue<bool>("frag_xpbl_ww_pretRat", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("ww_pretRat_spawned", new bool?(false)).Value)
		{
			erb.a(serviceOrThrow.aqu(), serviceOrThrow.aqw(), "Xpbl_WW_PretRat", serviceOrThrow.aqw().g("PretRat"));
			A_1.r()["ww_pretRat_spawned"] = true;
		}
	}
}
