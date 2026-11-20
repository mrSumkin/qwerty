using System;
using System.Runtime.Serialization;

// Token: 0x020009AA RID: 2474
[eiz("RCDPE")]
[Serializable]
public sealed class dpd : bdw, ISerializable
{
	// Token: 0x06003BA4 RID: 15268 RVA: 0x00161184 File Offset: 0x0015F384
	private dpd(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003BA5 RID: 15269 RVA: 0x0016118C File Offset: 0x0015F38C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003BA6 RID: 15270 RVA: 0x00161190 File Offset: 0x0015F390
	public dpd()
	{
	}

	// Token: 0x06003BA7 RID: 15271 RVA: 0x00161198 File Offset: 0x0015F398
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("lu-b12");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("40f43159-5e76-4774-8484-269b1f4806d8"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("bc79ec22-2825-4294-a3ec-84c776641d7f"), aud).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("35c0a2ae-f563-463c-a517-cfcf3e7273b8"), aud).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("84583d41-b889-42e3-8b20-8cebd494cf99"), aud).ao() as c5x;
				if (c5x != null)
				{
					c5x.w();
					c5x.an();
				}
				if (c5x2 != null)
				{
					c5x2.w();
					c5x2.an();
				}
				if (c5x3 != null)
				{
					c5x3.w();
					c5x3.an();
				}
				if (c5x4 != null)
				{
					c5x4.w();
					c5x4.an();
				}
			}
		}
	}
}
