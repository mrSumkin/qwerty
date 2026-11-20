using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x020009BE RID: 2494
[eiz("LUSFBC")]
[Serializable]
public sealed class dxq : bdw, ISerializable
{
	// Token: 0x06003BF4 RID: 15348 RVA: 0x00162950 File Offset: 0x00160B50
	private dxq(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003BF5 RID: 15349 RVA: 0x00162958 File Offset: 0x00160B58
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003BF6 RID: 15350 RVA: 0x0016295C File Offset: 0x00160B5C
	public dxq()
	{
	}

	// Token: 0x06003BF7 RID: 15351 RVA: 0x00162964 File Offset: 0x00160B64
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0 != null)
		{
			aud aud = A_0.n("lu-b26x");
			if (aud != null)
			{
				bv9 bv = serviceOrThrow.aqu().ac() as bv9;
				doq a_ = doq.a(Path.Combine(d5x.q(), "lu-b26x_l" + 2.ToString()) + ".uzl");
				aud.Zone.a(a_, 1, null);
				bv.a(asp.c8, asp.a, h.c, null, true, false, false);
				bv.a(asp.c8, asp.da, h.e, new h?(h.a), false, false, false);
				bv.a(asp.da, asp.a, h.c, null, true, false, false);
			}
		}
	}
}
