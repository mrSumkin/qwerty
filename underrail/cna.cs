using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x020009A2 RID: 2466
[eiz("JYEEESD")]
[Serializable]
public sealed class cna : bdw, ISerializable
{
	// Token: 0x06003B84 RID: 15236 RVA: 0x001603C0 File Offset: 0x0015E5C0
	private cna(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B85 RID: 15237 RVA: 0x001603C8 File Offset: 0x0015E5C8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B86 RID: 15238 RVA: 0x001603CC File Offset: 0x0015E5CC
	public cna()
	{
	}

	// Token: 0x06003B87 RID: 15239 RVA: 0x001603D8 File Offset: 0x0015E5D8
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("jye3");
			if (aud != null && bpo.GetServiceOrThrow<cnk>() != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "jye3_l2") + ".uzl");
				aud.Zone.a(a_, 1, null);
				c5x c5x = new ar7(new Guid("facdb88a-aae3-4d76-8af1-cd848de5880c"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("fe4138a7-4f1f-4d24-98f2-92e64046817a"), aud).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("0b1a4875-f351-4515-b393-87f90f33b47e"), aud).ao() as c5x;
				if (c5x != null)
				{
					a0l.a(c5x, "moved_guard1", true);
					c5x.t.b.y6()[ddq.ay] = new bt4("moved_guard1");
				}
				if (c5x2 != null)
				{
					a0l.a(c5x2, "moved_guard2", true);
					c5x2.t.b.y6()[ddq.ay] = new bt4("moved_guard2");
				}
				if (c5x3 != null)
				{
					bja aspect = c5x3.GetAspect<bja>();
					if (aspect != null)
					{
						aspect.a("");
					}
				}
				axh aspect2 = (new ar7(new Guid("fe4db539-7f80-4101-b109-987f44526c9e"), aud).ao() as c5x).GetAspect<axh>();
				if (aspect2 != null)
				{
					aspect2.a(null, false, null);
				}
			}
		}
	}
}
