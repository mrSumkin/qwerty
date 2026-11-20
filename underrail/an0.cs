using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x02000925 RID: 2341
[eiz("CCSDITM")]
[Serializable]
public sealed class an0 : bdw, ISerializable
{
	// Token: 0x06003983 RID: 14723 RVA: 0x00153B10 File Offset: 0x00151D10
	private an0(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003984 RID: 14724 RVA: 0x00153B18 File Offset: 0x00151D18
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003985 RID: 14725 RVA: 0x00153B1C File Offset: 0x00151D1C
	public an0()
	{
	}

	// Token: 0x06003986 RID: 14726 RVA: 0x00153B28 File Offset: 0x00151D28
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("cc_tm2");
			if (aud != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "cc_tm_l2") + ".uzl");
				aud.Zone.a(a_, 1, null);
			}
		}
	}
}
