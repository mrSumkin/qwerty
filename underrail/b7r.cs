using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x02000908 RID: 2312
[eiz("CCSDF1")]
[Serializable]
public sealed class b7r : bdw, ISerializable
{
	// Token: 0x0600390F RID: 14607 RVA: 0x00152018 File Offset: 0x00150218
	private b7r(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003910 RID: 14608 RVA: 0x00152020 File Offset: 0x00150220
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003911 RID: 14609 RVA: 0x00152024 File Offset: 0x00150224
	public b7r()
	{
	}

	// Token: 0x06003912 RID: 14610 RVA: 0x0015202C File Offset: 0x0015022C
	public void av(c1a A_0, cyt A_1)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null && A_0 != null)
		{
			aud aud = A_0.n("cc17");
			if (aud != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "cc17_l" + 2.ToString()) + ".uzl");
				aud.Zone.a(a_, 1, null);
			}
		}
	}
}
