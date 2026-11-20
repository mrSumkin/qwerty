using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000A83 RID: 2691
[eiz("TCHPEDA")]
[Serializable]
public sealed class cib : cze, ISerializable
{
	// Token: 0x06003F4B RID: 16203 RVA: 0x0017F530 File Offset: 0x0017D730
	private cib(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F4C RID: 16204 RVA: 0x0017F53C File Offset: 0x0017D73C
	public cib()
	{
	}

	// Token: 0x06003F4D RID: 16205 RVA: 0x0017F544 File Offset: 0x0017D744
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null && A_0 != null && A_0.Area != null)
		{
			d60 d = A_0.a();
			if (d != null)
			{
				c5x c5x = new ar7(new Guid("0cbacbc3-9d09-4f84-937c-66ab74d5ad8c"), A_0.Area).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("7c8f011c-aa86-45e8-bcf8-533d9aef4896"), A_0.Area).ao() as c5x;
				if (c5x2 != null)
				{
					dtb dtb = new dtb("lift");
					dtb.ad().Add(new bm3(1000));
					List<auv> list = dtb.ad();
					ad6 ad = new ad6(c5x2);
					ad.b(1.0);
					ad.c(0.0);
					ad.a(0.001);
					list.Add(ad);
					dtb.ad().Add(new c7(c5x2, false, false, true, false));
					c5x2.Zone.ActionManager.g9(dtb, atp.b);
				}
				if (c5x != null)
				{
					foreach (b0b b0b in d.ab4(new string[]
					{
						"wall"
					}))
					{
						c5x c5x3 = (c5x)b0b;
						bpu bpu = new bpu(c5x3);
						bpu.a(2f);
						bpu.b(2f);
						c5x3.SetAspect<bpu>(bpu);
						mj mj = new mj(c5x3, bpu);
						c5x3.SetAspect<mj>(mj);
						dtb dtb2 = new dtb("lift");
						dtb2.ad().Add(new bpr(mj, new Vector3(c5x3.Location.X, c5x3.Location.Y, 4.4f)));
						dtb2.ad().Add(new a8v(c5x3, new Vector3(c5x3.Location.X, c5x3.Location.Y, -8.8f)));
						c5x.Zone.ActionManager.g9(dtb2, atp.b);
					}
					foreach (b0b b0b2 in d.ab4(new string[]
					{
						"pillar"
					}))
					{
						c5x c5x4 = (c5x)b0b2;
						bpu bpu2 = new bpu(c5x4);
						bpu2.a(2f);
						bpu2.b(2f);
						c5x4.SetAspect<bpu>(bpu2);
						mj mj2 = new mj(c5x4, bpu2);
						c5x4.SetAspect<mj>(mj2);
						dtb dtb3 = new dtb("lift");
						dtb3.ad().Add(new bpr(mj2, new Vector3(c5x4.Location.X, c5x4.Location.Y, 8.8f)));
						dtb3.ad().Add(new a8v(c5x4, new Vector3(c5x4.Location.X, c5x4.Location.Y, -4.4f)));
						c5x.Zone.ActionManager.g9(dtb3, atp.b);
					}
				}
			}
		}
	}
}
