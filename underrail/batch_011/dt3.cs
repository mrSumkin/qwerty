using System;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02001158 RID: 4440
public static class dt3
{
	// Token: 0x06005F16 RID: 24342 RVA: 0x002849CC File Offset: 0x00282BCC
	public static void a(aud A_0, Point A_1, Point A_2, int A_3)
	{
		if (A_0 != null && A_0.Zone != null)
		{
			c5x c5x = bpo.GetServiceOrThrow<d6j>().dv().b("Locale\\Miscellaneous\\Effects\\Rats") as c5x;
			c5x.Layer = aju.x;
			c5x.Location = A_1.a();
			ak1 ak = A_0.a(A_2);
			if (c5x != null && c5x.o.b != null && c5x.j.b != null && ak != null)
			{
				bpu aspect = c5x.GetAspect<bpu>();
				if (aspect != null)
				{
					float num = aspect.h9();
					num *= (float)(0.8 + 0.4 * cuo.a.NextDouble());
					aspect.b(num);
					aspect.a(num);
				}
				HorizontalDirection? horizontalDirection = aw1.a(c5x, ak, true);
				if (horizontalDirection != null)
				{
					horizontalDirection = new HorizontalDirection?(a63.b(horizontalDirection.Value));
					c5x.o.b.b = new Point(0, (int)(horizontalDirection.Value * HorizontalDirection.East));
					A_0.a(c5x);
					c5x.c().a("rats", "Rats", 1f, c9z.a, true, false);
					qy qy = new qy();
					qy.b(false);
					qy.c(false);
					if (A_3 > 0)
					{
						qy.ad().Add(new bm3(A_3));
					}
					qy.ad().Add(new bpr(c5x.j.b, A_2.a()));
					qy.ad().Add(new c7(c5x, false, false, true, false));
					A_0.Zone.ActionManager.g9(qy, atp.a);
				}
			}
		}
	}
}
