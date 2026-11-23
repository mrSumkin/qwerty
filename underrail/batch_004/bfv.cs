using System;
using System.Runtime.Serialization;

// Token: 0x0200095B RID: 2395
[eiz("DCCIFLCIA")]
[Serializable]
public sealed class bfv : bdw, ISerializable
{
	// Token: 0x06003A66 RID: 14950 RVA: 0x0015A30C File Offset: 0x0015850C
	private bfv(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A67 RID: 14951 RVA: 0x0015A314 File Offset: 0x00158514
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A68 RID: 14952 RVA: 0x0015A318 File Offset: 0x00158518
	public bfv()
	{
	}

	// Token: 0x06003A69 RID: 14953 RVA: 0x0015A324 File Offset: 0x00158524
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (A_0 != null && serviceOrThrow != null)
		{
			aud aud = A_0.n("dc-flo");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("0d58b6dc-792d-43a2-be71-85ff3a196699"), aud).ao() as c5x;
				if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_TchortDefeated", new bool?(false)).Value && c5x == null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_dc_flcom_died", new bool?(false)).Value)
				{
					serviceOrThrow.aqu().r()["npc_dc_flcom_died"] = true;
				}
			}
		}
	}
}
