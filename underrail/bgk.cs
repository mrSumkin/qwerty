using System;
using System.Runtime.Serialization;

// Token: 0x020009C4 RID: 2500
[eiz("LUMTAC1")]
[Serializable]
public sealed class bgk : bdw, ISerializable
{
	// Token: 0x06003C0B RID: 15371 RVA: 0x001630C0 File Offset: 0x001612C0
	private bgk(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C0C RID: 15372 RVA: 0x001630C8 File Offset: 0x001612C8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C0D RID: 15373 RVA: 0x001630CC File Offset: 0x001612CC
	public bgk()
	{
	}

	// Token: 0x06003C0E RID: 15374 RVA: 0x001630D4 File Offset: 0x001612D4
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("lu-b31");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("8834e617-8e46-4c53-8c15-b174aa690c53"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("bb48826f-b728-47be-aed2-1c230207b0ee"), aud).ao() as c5x;
				if (c5x != null && c5x2 != null)
				{
					c5x.w();
					c5x.an();
					c5x2.w();
					c5x2.an();
				}
			}
		}
	}
}
