using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x02000A21 RID: 2593
[eiz("XPBLLUXC5AWD")]
[Serializable]
public sealed class cn : bdw, ISerializable
{
	// Token: 0x06003DA8 RID: 15784 RVA: 0x00171D0C File Offset: 0x0016FF0C
	private cn(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003DA9 RID: 15785 RVA: 0x00171D14 File Offset: 0x0016FF14
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003DAA RID: 15786 RVA: 0x00171D18 File Offset: 0x0016FF18
	public cn()
	{
	}

	// Token: 0x06003DAB RID: 15787 RVA: 0x00171D24 File Offset: 0x0016FF24
	public void av(c1a A_0, cyt A_1)
	{
		bpo.GetServiceOrThrow<cnk>();
		if (A_0 != null)
		{
			aud aud = A_0.n("lux-c5");
			if (aud != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "lux-c5_L2") + ".uzl");
				aud.Zone.a(a_, 1, null);
				c5x c5x = new ar7(new Guid("309d1adf-4f62-4c13-8491-0d56d5986163"), aud).ao() as c5x;
				if (c5x != null)
				{
					c5x.an();
					c5x.w();
				}
				c5x c5x2 = new ar7(new Guid("3fb178ab-ee1d-4ac2-96b1-0f4bcce38750"), aud).ao() as c5x;
				if (c5x2 != null)
				{
					c5x2.h.b.aa().Defense.a(1000, null, null, false, false, false, null);
				}
				bpo.GetServiceOrThrow<ps>().am3("Xpbl_Lux_OutsideDudesCave");
				ak1 ak = aud.b(21, 7);
				ak1 ak2 = aud.b(22, 7);
				ak.d();
				ak2.d();
			}
		}
	}
}
