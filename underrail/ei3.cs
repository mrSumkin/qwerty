using System;
using System.Runtime.Serialization;

// Token: 0x02000976 RID: 2422
[eiz("DCCOL")]
[Serializable]
public sealed class ei3 : bdw, ISerializable
{
	// Token: 0x06003AD3 RID: 15059 RVA: 0x0015D130 File Offset: 0x0015B330
	private ei3(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003AD4 RID: 15060 RVA: 0x0015D138 File Offset: 0x0015B338
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003AD5 RID: 15061 RVA: 0x0015D13C File Offset: 0x0015B33C
	public ei3()
	{
	}

	// Token: 0x06003AD6 RID: 15062 RVA: 0x0015D148 File Offset: 0x0015B348
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0.n("dc-tch") != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow != null)
			{
				serviceOrThrow.aqu().r()["loc_dc_cytosene_freePass"] = false;
			}
		}
	}
}
