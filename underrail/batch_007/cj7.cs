using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000ADC RID: 2780
[eiz("XPBLSFCDJ")]
[Serializable]
public sealed class cj7 : cze, ISerializable
{
	// Token: 0x060040C9 RID: 16585 RVA: 0x0018AFC4 File Offset: 0x001891C4
	private cj7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060040CA RID: 16586 RVA: 0x0018AFD0 File Offset: 0x001891D0
	public cj7()
	{
	}

	// Token: 0x060040CB RID: 16587 RVA: 0x0018AFDC File Offset: 0x001891DC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqu().r()["loc_xpbl_b12_temple_totemConstructionDestroyed"] = true;
		}
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.Area != null && c5x.Zone != null)
		{
			aud a_ = c5x.Area;
			Vector3 a_2 = new Vector3(12.2f, 6f, 2f);
			foreach (b0b b0b in c5x.Zone.a().ab4(new string[]
			{
				"mountedShadowlithFragmentPart"
			}))
			{
				c5x c5x2 = (c5x)b0b;
				c5x2.w();
				c5x2.an();
			}
			List<b0b> list = c5x.Zone.a().ab4(new string[]
			{
				"totemConstruction"
			});
			foreach (b0b b0b2 in list)
			{
				c5x c5x3 = (c5x)b0b2;
				if (c5x3.o.b != null)
				{
					c5x3.o.b.b = new Point(c5x3.o.b.b.X, 1);
				}
			}
			doq a_3 = doq.a(Path.Combine(d5x.q(), "xpbl_b12_temple_l2") + ".uzl");
			c5x.Zone.a(a_3, 1, null);
			c5x.w();
			c5x.an();
			dv1.a(new List<string>
			{
				"Objects\\Obstacles\\xpbl_SavageBoneShards",
				"Objects\\Obstacles\\xpbl_SavageBoneShards1"
			}, a_, a_2, 0.7f, 30, 300, 1f, 4.5f, true, true, false, new Action<c5x>(cj7.a), false);
			if (list.Count > 0)
			{
				(list[0] as c5x).c().a("BoneRustling");
			}
		}
	}

	// Token: 0x060040CC RID: 16588 RVA: 0x0018B214 File Offset: 0x00189414
	private static void a(c5x A_0)
	{
		if (A_0.o.b != null)
		{
			A_0.o.b.b.X = cuo.a.Next(10);
		}
		A_0.x = true;
	}
}
