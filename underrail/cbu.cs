using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x020009EA RID: 2538
[eiz("XPBLB6SKB")]
[Serializable]
public sealed class cbu : bdw, ISerializable
{
	// Token: 0x06003CB0 RID: 15536 RVA: 0x00168628 File Offset: 0x00166828
	private cbu(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003CB1 RID: 15537 RVA: 0x00168630 File Offset: 0x00166830
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003CB2 RID: 15538 RVA: 0x00168634 File Offset: 0x00166834
	public cbu()
	{
	}

	// Token: 0x06003CB3 RID: 15539 RVA: 0x00168640 File Offset: 0x00166840
	public void av(c1a A_0, cyt A_1)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null && A_0 != null)
		{
			aud aud = A_0.n("xpbl_b6");
			if (aud != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "xpbl_b6_l" + 2.ToString()) + ".uzl");
				aud.Zone.a(a_, 1, null);
			}
		}
	}
}
