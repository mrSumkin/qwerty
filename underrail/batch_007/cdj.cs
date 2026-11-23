using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x0200091C RID: 2332
[eiz("CCSDLIS")]
[Serializable]
public sealed class cdj : bdw, ISerializable
{
	// Token: 0x0600395F RID: 14687 RVA: 0x00153574 File Offset: 0x00151774
	private cdj(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003960 RID: 14688 RVA: 0x0015357C File Offset: 0x0015177C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003961 RID: 14689 RVA: 0x00153580 File Offset: 0x00151780
	public cdj()
	{
	}

	// Token: 0x06003962 RID: 14690 RVA: 0x0015358C File Offset: 0x0015178C
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("cc_s5");
			if (aud != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "cc_s5_l3") + ".uzl");
				aud.Zone.a(a_, 1, null);
			}
		}
	}
}
