using System;
using System.Runtime.Serialization;

// Token: 0x02000A3F RID: 2623
[eiz("XPBLCITKP")]
[Serializable]
public sealed class cdc : bdw, ISerializable
{
	// Token: 0x06003E2F RID: 15919 RVA: 0x00176B38 File Offset: 0x00174D38
	private cdc(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003E30 RID: 15920 RVA: 0x00176B40 File Offset: 0x00174D40
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003E31 RID: 15921 RVA: 0x00176B44 File Offset: 0x00174D44
	public cdc()
	{
	}

	// Token: 0x06003E32 RID: 15922 RVA: 0x00176B50 File Offset: 0x00174D50
	public void av(c1a A_0, cyt A_1)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null && !A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_oldfield_dead", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_thrasher_awakened", new bool?(false)).Value)
		{
			c5x c5x = new ar7(new Guid("d4ac396e-10f7-4a61-8f0e-941c31813923"), A_0.n("xpbl_e3_u")).ao() as c5x;
			if (c5x != null && A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_thrasher_awakened", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_oldfield_dead", new bool?(false)).Value)
			{
				c5x.h.b.aa().a(null, null, false);
			}
		}
	}
}
