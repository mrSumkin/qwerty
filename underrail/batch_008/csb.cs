using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x020009B1 RID: 2481
[eiz("LUDWFPC")]
[Serializable]
public sealed class csb : bdw, ISerializable
{
	// Token: 0x06003BC0 RID: 15296 RVA: 0x001618FC File Offset: 0x0015FAFC
	private csb(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003BC1 RID: 15297 RVA: 0x00161904 File Offset: 0x0015FB04
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003BC2 RID: 15298 RVA: 0x00161908 File Offset: 0x0015FB08
	public csb()
	{
	}

	// Token: 0x06003BC3 RID: 15299 RVA: 0x00161914 File Offset: 0x0015FB14
	public void av(c1a A_0, cyt A_1)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null && A_0 != null)
		{
			aud aud = A_0.n("lu-c2");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("87216a4d-3f1d-4181-bb12-fd01e4e95977"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("21f4221b-4822-4446-8328-b92d58841c8a"), aud).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("8b879c3f-06b5-4598-98e9-8be8d5dd01c6"), aud).ao() as c5x;
				if (c5x != null)
				{
					c5x.an();
					c5x.w();
				}
				if (c5x2 != null)
				{
					c5x2.an();
					c5x2.w();
				}
				if (c5x3 != null)
				{
					c5x3.an();
					c5x3.w();
				}
				doq a_ = doq.a(Path.Combine(d5x.q(), "lu-c2_l2") + ".uzl");
				aud.Zone.a(a_, 1, null);
			}
		}
	}
}
