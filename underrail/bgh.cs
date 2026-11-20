using System;
using System.Runtime.Serialization;

// Token: 0x02000988 RID: 2440
[eiz("UPEPS")]
[Serializable]
public sealed class bgh : bdw, ISerializable
{
	// Token: 0x06003B1C RID: 15132 RVA: 0x0015ED34 File Offset: 0x0015CF34
	private bgh(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B1D RID: 15133 RVA: 0x0015ED3C File Offset: 0x0015CF3C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B1E RID: 15134 RVA: 0x0015ED40 File Offset: 0x0015CF40
	public bgh()
	{
	}

	// Token: 0x06003B1F RID: 15135 RVA: 0x0015ED4C File Offset: 0x0015CF4C
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("epioneLabMadeHostile", new bool?(false)).Value)
		{
			bv9 bv = serviceOrThrow.aqu().ac() as bv9;
			if (bv != null)
			{
				bv.a(asp.bd, asp.a, h.a, null, true, false, false);
				bv.a(asp.bp, asp.a, h.a, null, true, false, false);
			}
		}
	}
}
