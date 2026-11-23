using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x02000970 RID: 2416
[eiz("DCSSR1")]
[Serializable]
public sealed class e0w : bdw, ISerializable
{
	// Token: 0x06003ABB RID: 15035 RVA: 0x0015C5FC File Offset: 0x0015A7FC
	private e0w(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003ABC RID: 15036 RVA: 0x0015C604 File Offset: 0x0015A804
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003ABD RID: 15037 RVA: 0x0015C608 File Offset: 0x0015A808
	public e0w()
	{
	}

	// Token: 0x06003ABE RID: 15038 RVA: 0x0015C610 File Offset: 0x0015A810
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("dc-res2");
			if (aud != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "dc-res2_l2") + ".uzl");
				aud.Zone.a(a_, 1, null);
			}
		}
	}
}
