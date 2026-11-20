using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x02001163 RID: 4451
public static class aex
{
	// Token: 0x06005F36 RID: 24374 RVA: 0x00286000 File Offset: 0x00284200
	public static c5x a(aud A_0, Vector3 A_1, int A_2, int A_3, bool A_4 = true, bool A_5 = false)
	{
		if (A_0 != null && A_0.Zone != null)
		{
			c5x c5x = boj.a(A_0, A_1, null, "xpbl_VoidStarUncolored", int.MaxValue, double.MaxValue, null, null, null, null);
			qy qy = new qy();
			ad6 item;
			if (A_5)
			{
				ad6 ad = new ad6(c5x);
				ad.b(0.0);
				ad.c(1.0);
				ad.a(A_4 ? dz6.a((double)(1f / (float)A_3)) : ((double)(1f / (float)A_3)));
				item = ad;
			}
			else
			{
				ad6 ad2 = new ad6(c5x);
				ad2.b(1.0);
				ad2.c(0.0);
				ad2.a(A_4 ? dz6.a((double)(1f / (float)A_3)) : ((double)(1f / (float)A_3)));
				item = ad2;
			}
			qy.ad().Add(new bm3(A_2));
			qy.ad().Add(item);
			qy.ad().Add(new c7(c5x, false, false, true, false));
			A_0.Zone.ActionManager.g9(qy, atp.a);
			c5x.p.b.a[1].c = new Color?(Color.White);
			c5x.p.b.a[0].c = new Color?(aex.a[cuo.a.Next(aex.a.Length)]);
			return c5x;
		}
		return null;
	}

	// Token: 0x06005F37 RID: 24375 RVA: 0x002861C8 File Offset: 0x002843C8
	public static void b(aud A_0, Vector3 A_1, int A_2, int A_3, float A_4 = 1f, float A_5 = 4.25f, bool A_6 = false, bool A_7 = true)
	{
		if (A_0 != null && A_0.Zone != null && A_2 > 0)
		{
			int num = A_7 ? (dz6.b(A_3) / A_2) : (A_3 / A_2);
			for (int i = 0; i < A_2; i++)
			{
				int num2 = i * num;
				float num3 = 0.3f;
				Vector3 vector = new Vector3(-num3 / 2f + (float)cuo.a.NextDouble() * num3, -num3 / 2f + (float)cuo.a.NextDouble() * num3, -num3 / 2f + (float)cuo.a.NextDouble() * num3);
				Vector3 value = vector;
				value.Normalize();
				Vector3 vector2 = A_1 + vector;
				Vector3 vector3 = vector2 + value * A_4 * (1f - (float)cuo.a.NextDouble() * 0.2f);
				double num4 = (double)Vector3.Distance(vector2, vector3);
				c5x c5x = aex.a(A_0, vector3, num2, (int)(1000.0 * (num4 / (double)A_5)), A_7, true);
				c5x.x = A_6;
				c5x.ae = new float?(0f);
				bpu bpu = new bpu(c5x);
				bpu.a(A_7 ? dz6.b(A_5) : A_5);
				bpu.b(A_7 ? dz6.b(A_5) : A_5);
				c5x.SetAspect<bpu>(bpu);
				mj mj = new mj(c5x);
				c5x.SetAspect<mj>(mj);
				qy qy = new qy();
				if (num2 > 0)
				{
					qy.ad().Add(new bm3(num2));
				}
				List<auv> list = qy.ad();
				ch3 ch = new ch3();
				ch.a(null);
				list.Add(new a4s(ch, null, new ar7(c5x), null));
				qy.ad().Add(new bpr(mj, vector2));
				A_0.Zone.ActionManager.g9(qy, atp.a);
			}
		}
	}

	// Token: 0x06005F38 RID: 24376 RVA: 0x002863C8 File Offset: 0x002845C8
	public static void a(aud A_0, Vector3 A_1, int A_2, int A_3, float A_4 = 1f, float A_5 = 4.25f, bool A_6 = false, bool A_7 = true)
	{
		if (A_0 != null && A_0.Zone != null && A_2 > 0)
		{
			int num = A_7 ? (dz6.b(A_3) / A_2) : (A_3 / A_2);
			for (int i = 0; i < A_2; i++)
			{
				int num2 = i * num;
				float num3 = 0.3f;
				Vector3 vector = new Vector3(-num3 / 2f + (float)cuo.a.NextDouble() * num3, -num3 / 2f + (float)cuo.a.NextDouble() * num3, -num3 / 2f + (float)cuo.a.NextDouble() * num3);
				Vector3 value = vector;
				value.Normalize();
				Vector3 vector2 = A_1 + vector;
				Vector3 vector3 = vector2 + value * A_4 * (1f - (float)cuo.a.NextDouble() * 0.2f);
				double num4 = (double)Vector3.Distance(vector3, vector2);
				c5x c5x = aex.a(A_0, A_1 + vector, num2, (int)(1000.0 * (num4 / (double)A_5)), A_7, false);
				c5x.x = A_6;
				c5x.ae = new float?(0f);
				bpu bpu = new bpu(c5x);
				bpu.a(A_7 ? dz6.b(A_5) : A_5);
				bpu.b(A_7 ? dz6.b(A_5) : A_5);
				c5x.SetAspect<bpu>(bpu);
				mj mj = new mj(c5x);
				c5x.SetAspect<mj>(mj);
				qy qy = new qy();
				if (num2 > 0)
				{
					qy.ad().Add(new bm3(num2));
				}
				List<auv> list = qy.ad();
				ch3 ch = new ch3();
				ch.a(null);
				list.Add(new a4s(ch, null, new ar7(c5x), null));
				qy.ad().Add(new bpr(mj, vector3));
				A_0.Zone.ActionManager.g9(qy, atp.a);
			}
		}
	}

	// Token: 0x040025E0 RID: 9696
	private static readonly Color[] a = new Color[]
	{
		Color.Purple,
		Color.Indigo,
		Color.DarkSlateBlue
	};
}
