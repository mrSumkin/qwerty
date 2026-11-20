using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x020009AE RID: 2478
[eiz("FOSABS")]
[Serializable]
public sealed class ayx : bdw, ISerializable
{
	// Token: 0x06003BB4 RID: 15284 RVA: 0x00161768 File Offset: 0x0015F968
	private ayx(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003BB5 RID: 15285 RVA: 0x00161770 File Offset: 0x0015F970
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003BB6 RID: 15286 RVA: 0x00161774 File Offset: 0x0015F974
	public ayx()
	{
	}

	// Token: 0x06003BB7 RID: 15287 RVA: 0x00161780 File Offset: 0x0015F980
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("fo2");
			if (aud != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "fo2_l2") + ".uzl");
				aud.Zone.a(a_, 1, null);
			}
		}
	}
}
