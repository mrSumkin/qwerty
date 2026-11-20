using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x0200096B RID: 2411
[eiz("DCBD")]
[Serializable]
public sealed class avv : bdw, ISerializable
{
	// Token: 0x06003AA6 RID: 15014 RVA: 0x0015BA3C File Offset: 0x00159C3C
	private avv(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003AA7 RID: 15015 RVA: 0x0015BA44 File Offset: 0x00159C44
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003AA8 RID: 15016 RVA: 0x0015BA48 File Offset: 0x00159C48
	public avv()
	{
	}

	// Token: 0x06003AA9 RID: 15017 RVA: 0x0015BA54 File Offset: 0x00159C54
	public void av(c1a A_0, cyt A_1)
	{
		if (A_1 != null && A_0 != null)
		{
			aud aud = A_0.n("dc-tw");
			if (aud != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "dc-tw_l2") + ".uzl");
				aud.Zone.a(a_, 1, null);
			}
		}
	}
}
