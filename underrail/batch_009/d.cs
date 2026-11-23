using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x0200090B RID: 2315
[eiz("CCWACT")]
[Serializable]
public sealed class d : bdw, ISerializable
{
	// Token: 0x0600391B RID: 14619 RVA: 0x001522B8 File Offset: 0x001504B8
	private d(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600391C RID: 14620 RVA: 0x001522C0 File Offset: 0x001504C0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x0600391D RID: 14621 RVA: 0x001522C4 File Offset: 0x001504C4
	public d()
	{
	}

	// Token: 0x0600391E RID: 14622 RVA: 0x001522D0 File Offset: 0x001504D0
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("cc2");
			if (aud != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "cc2_l3") + ".uzl");
				aud.Zone.a(a_, 1, null);
			}
		}
	}
}
