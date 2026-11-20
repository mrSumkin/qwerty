using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x02000A0B RID: 2571
[eiz("XPBLF12ODG")]
[Serializable]
public sealed class z0 : bdw, ISerializable
{
	// Token: 0x06003D43 RID: 15683 RVA: 0x0016D01C File Offset: 0x0016B21C
	private z0(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D44 RID: 15684 RVA: 0x0016D024 File Offset: 0x0016B224
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D45 RID: 15685 RVA: 0x0016D028 File Offset: 0x0016B228
	public z0()
	{
	}

	// Token: 0x06003D46 RID: 15686 RVA: 0x0016D034 File Offset: 0x0016B234
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			bpo.GetServiceOrThrow<cnk>();
			aud aud = A_0.n("xpbl_f12");
			if (aud != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "xpbl_f12_L2") + ".uzl");
				aud.Zone.a(a_, 1, null);
				d60 d = aud.Zone.a();
				if (d != null)
				{
					foreach (b0b b0b in d.ab4(new string[]
					{
						"xpbl_sc_dockGate_remove"
					}))
					{
						if (b0b != null)
						{
							b0b.w();
							b0b.an();
						}
					}
				}
			}
		}
	}
}
