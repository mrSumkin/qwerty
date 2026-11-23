using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x02000ADB RID: 2779
[eiz("XPBLSFPDJ")]
[Serializable]
public sealed class df4 : cze, ISerializable
{
	// Token: 0x060040C6 RID: 16582 RVA: 0x0018AD88 File Offset: 0x00188F88
	private df4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060040C7 RID: 16583 RVA: 0x0018AD94 File Offset: 0x00188F94
	public df4()
	{
	}

	// Token: 0x060040C8 RID: 16584 RVA: 0x0018AD9C File Offset: 0x00188F9C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqu().r()["loc_xpbl_b12_temple_shadowlithFragmentDestroyed"] = true;
			serviceOrThrow.aqu().a(new bw0("xpbl_b12", new av7(), 1));
		}
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.Area != null && c5x.Zone != null)
		{
			foreach (b0b b0b in c5x.Zone.a().ab4(new string[]
			{
				"PurpleFlames"
			}))
			{
				ad6 ad = new ad6((c5x)b0b);
				ad.b(1.0);
				ad.c(0.0);
				ad.a(0.0005);
				c5x.Zone.ActionManager.g9(ad, atp.a);
			}
			ah7 ah = c5x.Zone.i("ambientLight");
			if (ah != null)
			{
				fx a_ = new fx(ah, 1f, 0f, -0.0005f, false);
				c5x.Zone.ActionManager.g9(a_, atp.a);
			}
			foreach (b0b b0b2 in c5x.Zone.a().ab4(new string[]
			{
				"downedShadowlithFragment"
			}))
			{
				c5x c5x2 = (c5x)b0b2;
				if (c5x2.o.b != null)
				{
					c5x2.w();
					c5x2.an();
				}
			}
			doq a_2 = doq.a(Path.Combine(d5x.q(), "xpbl_b12_temple_l3") + ".uzl");
			c5x.Zone.a(a_2, 1, null);
			new av7().av(c5x.Zone, serviceOrThrow.aqu());
		}
	}
}
