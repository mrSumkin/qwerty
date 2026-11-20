using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000AE1 RID: 2785
[eiz("XPBLSLDST")]
[Serializable]
public sealed class vc : cze, ISerializable
{
	// Token: 0x060040D9 RID: 16601 RVA: 0x0018B724 File Offset: 0x00189924
	private vc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060040DA RID: 16602 RVA: 0x0018B730 File Offset: 0x00189930
	public vc()
	{
	}

	// Token: 0x060040DB RID: 16603 RVA: 0x0018B738 File Offset: 0x00189938
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.Area != null && c5x.Zone != null)
		{
			c5x c5x2 = vq.a("Object\\Obstacles\\Xpbl_Lemuria\\DestroyedShadowlith", c5x.Zone, new bt4(c5x.Area.y8(), c5x.Location), false);
			if (c5x2 != null)
			{
				bpo.GetServiceOrThrow<cnk>().aqu().r()[bvw.k] = true;
				awx awx = new awx();
				for (int i = 1; i <= 7; i++)
				{
					awx.ad().Add(new bm3(50));
					List<auv> list = awx.ad();
					bi5 bi = new bi5();
					bi.b(true);
					bi.b(i);
					bi.a(new int?(2));
					list.Add(new a4s(bi, null, new ar7(c5x2), null));
				}
				foreach (b0b b0b in c5x.Zone.a().ab4(new string[]
				{
					"spaceSnake"
				}))
				{
					c5x c5x3 = (c5x)b0b;
					if (c5x3.h.b != null)
					{
						awx.ad().Add(new bm3(500));
						awx.ad().Add(new a4s(new nb(), null, new ar7(c5x3), null));
					}
				}
				c5x.Zone.ActionManager.g9(awx, atp.a);
				dz6.a(awx);
			}
			doq a_ = doq.a(Path.Combine(d5x.q(), "xpbl_ds3_l2") + ".uzl");
			c5x.Zone.a(a_, 1, null);
			Vector3 a_2 = c5x.Location + new Vector3(0.95f, 0.75f, 2.15f);
			dv1.a(new List<string>
			{
				"Object\\Obstacles\\Xpbl_Lemuria\\GreyMonolithPieceSmall",
				"Object\\Obstacles\\Xpbl_Lemuria\\GreyMonolithPieceSmall",
				"Object\\Obstacles\\Xpbl_Lemuria\\GreyMonolithPieceLarge"
			}, c5x.Area, a_2, 0.2f, 30, 300, 1f, 8f, true, true, false, new Action<c5x>(vc.a), false);
		}
	}

	// Token: 0x060040DC RID: 16604 RVA: 0x0018B980 File Offset: 0x00189B80
	private static void a(c5x A_0)
	{
		if (A_0.o.b != null)
		{
			A_0.o.b.b.X = cuo.a.Next(5);
		}
		A_0.g = false;
		A_0.f = false;
		A_0.Size = new Vector3(0.3f, 0.3f, 0.1f);
	}
}
