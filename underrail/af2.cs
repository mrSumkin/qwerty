using System;
using System.Runtime.Serialization;

// Token: 0x020008EC RID: 2284
[eiz("TCHMU1UD")]
[Serializable]
public sealed class af2 : bdw, ISerializable
{
	// Token: 0x0600389D RID: 14493 RVA: 0x0014F554 File Offset: 0x0014D754
	private af2(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600389E RID: 14494 RVA: 0x0014F55C File Offset: 0x0014D75C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x0600389F RID: 14495 RVA: 0x0014F560 File Offset: 0x0014D760
	public af2()
	{
	}

	// Token: 0x060038A0 RID: 14496 RVA: 0x0014F568 File Offset: 0x0014D768
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			c5x c5x = (A_0.y8() == "tch_mu1") ? (new ar7(new Guid("9e27b82c-2a37-42f3-8501-9d4f3c9ad868"), A_0.n(A_0.y8())).ao() as c5x) : (new ar7(new Guid("b6e72ce8-f89b-4c63-ae29-8373f65d100e"), A_0.n(A_0.y8())).ao() as c5x);
			if (c5x != null)
			{
				d2b aspect = c5x.GetAspect<d2b>();
				if (aspect != null && aspect.n())
				{
					aspect.a(true, false);
				}
			}
		}
	}
}
