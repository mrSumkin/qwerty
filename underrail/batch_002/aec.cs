using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x02000A0C RID: 2572
[eiz("XPBLE3USPC")]
[Serializable]
public sealed class aec : bdw, ISerializable
{
	// Token: 0x06003D47 RID: 15687 RVA: 0x0016D108 File Offset: 0x0016B308
	private aec(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D48 RID: 15688 RVA: 0x0016D110 File Offset: 0x0016B310
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D49 RID: 15689 RVA: 0x0016D114 File Offset: 0x0016B314
	public aec()
	{
	}

	// Token: 0x06003D4A RID: 15690 RVA: 0x0016D120 File Offset: 0x0016B320
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			bpo.GetServiceOrThrow<cnk>();
			aud aud = A_0.n("xpbl_e3_u");
			if (aud != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "xpbl_e3_u_L2_oldfieldsCorpse") + ".uzl");
				aud.Zone.a(a_, 1, null);
			}
		}
	}
}
