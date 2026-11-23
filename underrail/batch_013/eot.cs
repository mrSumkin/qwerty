using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x02000997 RID: 2455
[eiz("UPSFDG")]
[Serializable]
public sealed class eot : bdw, ISerializable
{
	// Token: 0x06003B58 RID: 15192 RVA: 0x0015F9E4 File Offset: 0x0015DBE4
	private eot(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B59 RID: 15193 RVA: 0x0015F9EC File Offset: 0x0015DBEC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B5A RID: 15194 RVA: 0x0015F9F0 File Offset: 0x0015DBF0
	public eot()
	{
	}

	// Token: 0x06003B5B RID: 15195 RVA: 0x0015F9FC File Offset: 0x0015DBFC
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("up5");
			if (aud != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "up5_l2") + ".uzl");
				aud.Zone.a(a_, 1, null);
			}
		}
	}
}
