using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x02000998 RID: 2456
[eiz("UPSB1")]
[Serializable]
public sealed class ceb : bdw, ISerializable
{
	// Token: 0x06003B5C RID: 15196 RVA: 0x0015FA50 File Offset: 0x0015DC50
	private ceb(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B5D RID: 15197 RVA: 0x0015FA58 File Offset: 0x0015DC58
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B5E RID: 15198 RVA: 0x0015FA5C File Offset: 0x0015DC5C
	public ceb()
	{
	}

	// Token: 0x06003B5F RID: 15199 RVA: 0x0015FA64 File Offset: 0x0015DC64
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("up-lw2");
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (aud != null && serviceOrThrow != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "up-lw_l4") + ".uzl");
				aud.Zone.a(a_, 1, null);
				(serviceOrThrow.aqu().ac() as bv9).a(asp.bq, asp.a, h.c, null, true, false, false);
			}
		}
	}
}
