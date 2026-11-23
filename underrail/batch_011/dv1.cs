using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x02001157 RID: 4439
public static class dv1
{
	// Token: 0x06005F13 RID: 24339 RVA: 0x00284370 File Offset: 0x00282570
	public static c5x a(string A_0, aud A_1, Vector3 A_2, int A_3, int A_4, bool A_5 = true, bool A_6 = false, bool A_7 = true)
	{
		if (A_1 != null && A_1.Zone != null)
		{
			c5x c5x;
			if (A_7)
			{
				c5x = boj.a(A_1, A_2, null, A_0, int.MaxValue, double.MaxValue, null, null, null, null);
			}
			else
			{
				c5x = vq.a(A_0, A_1.Zone, new bt4(A_1.y8(), A_2), false);
			}
			if (c5x != null)
			{
				qy qy = new qy();
				ad6 item = null;
				if (A_4 > 0)
				{
					if (A_6)
					{
						ad6 ad = new ad6(c5x);
						ad.b(0.0);
						ad.c(1.0);
						ad.a(A_5 ? dz6.a((double)(1f / (float)A_4)) : ((double)(1f / (float)A_4)));
						item = ad;
					}
					else
					{
						ad6 ad2 = new ad6(c5x);
						ad2.b(1.0);
						ad2.c(0.0);
						ad2.a(A_5 ? dz6.a((double)(1f / (float)A_4)) : ((double)(1f / (float)A_4)));
						item = ad2;
					}
				}
				if (A_3 > 0)
				{
					qy.ad().Add(new bm3(A_3));
				}
				if (A_4 > 0)
				{
					qy.ad().Add(item);
				}
				A_1.Zone.ActionManager.g9(qy, atp.a);
				return c5x;
			}
		}
		return null;
	}

	// Token: 0x06005F14 RID: 24340 RVA: 0x00284504 File Offset: 0x00282704
	public static void a(List<string> A_0, aud A_1, Vector3 A_2, int A_3, int A_4, float A_5 = 1f, float A_6 = 4.25f, bool A_7 = false, bool A_8 = true, bool A_9 = true, Action<c5x> A_10 = null, bool A_11 = false)
	{
		if (A_1 != null && A_1.Zone != null && A_3 > 0 && A_0 != null && A_0.Count > 0)
		{
			int num = A_8 ? (dz6.b(A_4) / A_3) : (A_4 / A_3);
			for (int i = 0; i < A_3; i++)
			{
				float num2 = 0.3f;
				Vector3 vector = new Vector3(-num2 / 2f + (float)cuo.a.NextDouble() * num2, -num2 / 2f + (float)cuo.a.NextDouble() * num2, -num2 / 2f + (float)cuo.a.NextDouble() * num2);
				Vector3 value = vector;
				value.Normalize();
				Vector3 vector2 = A_2 + vector;
				Vector3 vector3 = vector2 + value * A_5 * (1f - (float)cuo.a.NextDouble() * 0.2f);
				double num3 = (double)Vector3.Distance(vector2, vector3);
				int num4 = i * num;
				if (A_11)
				{
					double num5 = num3 / (double)A_6;
				}
				c5x c5x = dv1.a(A_0[cuo.a.Next(A_0.Count)], A_1, vector3, num4, (int)(1000.0 * (num3 / (double)A_6)), A_8, true, A_9);
				if (c5x != null)
				{
					c5x.x = A_7;
					c5x.ae = new float?(0f);
					bpu bpu = new bpu(c5x);
					bpu.a(A_8 ? dz6.b(A_6) : A_6);
					bpu.b(A_8 ? dz6.b(A_6) : A_6);
					c5x.SetAspect<bpu>(bpu);
					mj mj = new mj(c5x);
					c5x.SetAspect<mj>(mj);
					qy qy = new qy();
					if (num4 > 0)
					{
						qy.ad().Add(new bm3(num4));
					}
					List<auv> list = qy.ad();
					ch3 ch = new ch3();
					ch.a(null);
					list.Add(new a4s(ch, null, new ar7(c5x), null));
					qy.ad().Add(new bpr(mj, vector2));
					qy.ad().Add(new c7(c5x, false, false, true, false));
					A_1.Zone.ActionManager.g9(qy, atp.a);
				}
			}
		}
	}

	// Token: 0x06005F15 RID: 24341 RVA: 0x0028475C File Offset: 0x0028295C
	public static void a(List<string> A_0, aud A_1, Vector3 A_2, float A_3, int A_4, int A_5, float A_6 = 1f, float A_7 = 4.25f, bool A_8 = false, bool A_9 = true, bool A_10 = true, Action<c5x> A_11 = null, bool A_12 = false)
	{
		if (A_1 != null && A_1.Zone != null && A_4 > 0 && A_0 != null && A_0.Count > 0)
		{
			int num = A_9 ? (dz6.b(A_5) / A_4) : (A_5 / A_4);
			for (int i = 0; i < A_4; i++)
			{
				Vector3 vector = new Vector3(-A_3 / 2f + (float)cuo.a.NextDouble() * A_3, -A_3 / 2f + (float)cuo.a.NextDouble() * A_3, -A_3 / 2f + (float)cuo.a.NextDouble() * A_3);
				Vector3 value = vector;
				value.Normalize();
				Vector3 vector2 = A_2 + vector;
				Vector3 vector3 = vector2 + value * A_6 * (1f - (float)cuo.a.NextDouble() * 0.2f);
				double num2 = (double)Vector3.Distance(vector3, vector2);
				int num3 = i * num;
				int a_;
				if (A_12)
				{
					a_ = (int)(1000.0 * (num2 / (double)A_7));
				}
				else
				{
					a_ = 1;
				}
				c5x c5x = dv1.a(A_0[cuo.a.Next(A_0.Count)], A_1, A_2 + vector, num3, a_, A_9, false, A_10);
				if (c5x != null)
				{
					if (A_11 != null)
					{
						A_11(c5x);
					}
					c5x.x = A_8;
					c5x.ae = new float?(0f);
					bpu bpu = new bpu(c5x);
					bpu.a(A_9 ? dz6.b(A_7) : A_7);
					bpu.b(A_9 ? dz6.b(A_7) : A_7);
					c5x.SetAspect<bpu>(bpu);
					mj mj = new mj(c5x);
					c5x.SetAspect<mj>(mj);
					qy qy = new qy();
					if (num3 > 0)
					{
						qy.ad().Add(new bm3(num3));
					}
					List<auv> list = qy.ad();
					ch3 ch = new ch3();
					ch.a(null);
					list.Add(new a4s(ch, null, new ar7(c5x), null));
					qy.ad().Add(new bpr(mj, vector3));
					qy.ad().Add(new c7(c5x, false, false, true, false));
					A_1.Zone.ActionManager.g9(qy, atp.a);
				}
			}
		}
	}
}
