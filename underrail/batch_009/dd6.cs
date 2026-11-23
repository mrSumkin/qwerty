using System;
using System.Runtime.Serialization;

// Token: 0x020009C1 RID: 2497
[eiz("LURGFTH")]
[Serializable]
public sealed class dd6 : bdw, ISerializable
{
	// Token: 0x06003C00 RID: 15360 RVA: 0x00162CB0 File Offset: 0x00160EB0
	private dd6(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C01 RID: 15361 RVA: 0x00162CB8 File Offset: 0x00160EB8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C02 RID: 15362 RVA: 0x00162CBC File Offset: 0x00160EBC
	public dd6()
	{
	}

	// Token: 0x06003C03 RID: 15363 RVA: 0x00162CC8 File Offset: 0x00160EC8
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("lu-b27");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("fbb7ef41-8bab-4a3d-bdda-6e493d26eaec"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("9c5b2d97-540d-469b-9491-6d50cece1e10"), aud).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("84c18b0e-a2fb-4522-b3d3-11b05e5c83d2"), aud).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("21987034-21dc-470e-997f-757bdf7be4a4"), aud).ao() as c5x;
				c5x c5x5 = new ar7(new Guid("9e45dbbc-6ead-4021-a1ce-ed0a5e73026e"), aud).ao() as c5x;
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
				if (c5x5 != null)
				{
					c5x5.w();
					c5x5.an();
				}
			}
		}
	}
}
