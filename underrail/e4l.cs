using System;
using System.Runtime.Serialization;

// Token: 0x020009A5 RID: 2469
[eiz("JYDPA")]
[Serializable]
public sealed class e4l : bdw, ISerializable
{
	// Token: 0x06003B90 RID: 15248 RVA: 0x00160A0C File Offset: 0x0015EC0C
	private e4l(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B91 RID: 15249 RVA: 0x00160A14 File Offset: 0x0015EC14
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B92 RID: 15250 RVA: 0x00160A18 File Offset: 0x0015EC18
	public e4l()
	{
	}

	// Token: 0x06003B93 RID: 15251 RVA: 0x00160A24 File Offset: 0x0015EC24
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("jyfd");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("88f5e9b0-80fa-4ed7-968f-d36b05744c6f"), aud).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("6b3d34c2-22fb-47f0-aa79-3d1deb1467ee"), aud).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("e7b41656-6178-44b3-becd-498c3c139cac"), aud).ao() as c5x;
			c5x c5x4 = new ar7(new Guid("f230bbcd-c7a5-49a4-8697-e142176f485d"), aud).ao() as c5x;
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
