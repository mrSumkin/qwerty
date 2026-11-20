using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x020008E9 RID: 2281
[eiz("CHSPWNT")]
[Serializable]
public sealed class dim : bdw, ISerializable
{
	// Token: 0x06003890 RID: 14480 RVA: 0x0014F154 File Offset: 0x0014D354
	private dim(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003891 RID: 14481 RVA: 0x0014F15C File Offset: 0x0014D35C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003892 RID: 14482 RVA: 0x0014F160 File Offset: 0x0014D360
	public dim()
	{
	}

	// Token: 0x06003893 RID: 14483 RVA: 0x0014F16C File Offset: 0x0014D36C
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("cv16");
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (aud != null && serviceOrThrow != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_ch_tapioSpawned", new bool?(false)).Value)
		{
			serviceOrThrow.aqu().r()["npc_ch_tapioSpawned"] = true;
			doq a_ = doq.a(Path.Combine(d5x.q(), "cv16_l4") + ".uzl");
			aud.Zone.a(a_, 1, null);
		}
	}
}
