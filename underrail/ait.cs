using System;
using System.Runtime.Serialization;

// Token: 0x020009B9 RID: 2489
[eiz("LUTHFDHEP")]
[Serializable]
public sealed class ait : bdw, ISerializable
{
	// Token: 0x06003BE0 RID: 15328 RVA: 0x001621E0 File Offset: 0x001603E0
	private ait(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003BE1 RID: 15329 RVA: 0x001621E8 File Offset: 0x001603E8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003BE2 RID: 15330 RVA: 0x001621EC File Offset: 0x001603EC
	public ait()
	{
	}

	// Token: 0x06003BE3 RID: 15331 RVA: 0x001621F4 File Offset: 0x001603F4
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0 != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("lo_lu-b29_bombPlanted", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("lo_lu-b29_defuseSuccess", new bool?(false)).Value)
		{
			serviceOrThrow.aqu().r()["lo_lu-b29_trainBlewUp"] = true;
		}
	}
}
