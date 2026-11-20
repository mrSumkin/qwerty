using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x02000369 RID: 873
internal static class g8
{
	// Token: 0x06001871 RID: 6257 RVA: 0x0007C7C8 File Offset: 0x0007A9C8
	public static ak1 a(bm6 A_0, int A_1, int A_2)
	{
		ale b = A_0.a8().k.b;
		if (b == null)
		{
			return null;
		}
		Vector3 vector = A_0.a8().aj();
		Point point = new Point((int)vector.X, (int)vector.Y);
		Point? primitivePropertyValue = A_0.y6().GetPrimitivePropertyValue<Point>("IdlingCenter", null);
		if (primitivePropertyValue == null || bnx.a(primitivePropertyValue.Value, point) > (float)(A_1 + A_2 - 1))
		{
			primitivePropertyValue = new Point?(point);
			A_0.y6()["IdlingCenter"] = primitivePropertyValue;
		}
		List<ak1> list = g8.a(b, A_0.a8().Area, point, primitivePropertyValue.Value, A_1, A_2, false);
		if (list.Count > 0)
		{
			return list[cuo.a.Next(list.Count)];
		}
		return null;
	}

	// Token: 0x06001872 RID: 6258 RVA: 0x0007C8B4 File Offset: 0x0007AAB4
	public static ak1 a(bm6 A_0, bm6 A_1, int A_2 = 3, float A_3 = 1.8f, int A_4 = 2147483647)
	{
		g8.c c = new g8.c();
		if (A_0 == null || A_1 == null || A_0.a8() == null || A_1.a8() == null || A_1.a8().Area == null || A_0.a8().Area == null)
		{
			return null;
		}
		ale b = A_0.a8().k.b;
		if (b == null)
		{
			return null;
		}
		Vector3 vector = A_0.a8().aj();
		Point a_ = new Point((int)vector.X, (int)vector.Y);
		c.a = A_1.a8().aj().a();
		List<ak1> list = g8.a(b, A_0.a8().Area, a_, c.a, A_4, A_2, false);
		double num = aw1.b(A_0.a8(), A_1.a8());
		if (list.Count > 0)
		{
			d02 service = bpo.GetService<d02>();
			if (service == null)
			{
				return null;
			}
			HashSet<r0> hashSet = A_1.b(service);
			IEnumerable<ak1> enumerable = list;
			Func<ak1, float> func;
			if ((func = c.b) == null)
			{
				func = (c.b = new Func<ak1, float>(c.a));
			}
			foreach (ak1 ak in Enumerable.OrderByDescending<ak1, float>(enumerable, func))
			{
				r0 r = new r0(ak.Area.c(), new Vector2((float)ak.Location.X, (float)ak.Location.Y));
				if (hashSet.Contains(r))
				{
					float num2 = bnx.a(ak.Location, A_1.a8());
					if (bnx.a(ak.Location, A_0.a8()) >= A_3 && (double)num2 > num && num2 <= (float)A_4)
					{
						return ak;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06001873 RID: 6259 RVA: 0x0007CAB0 File Offset: 0x0007ACB0
	public static ak1 b(bm6 A_0, bm6 A_1, int A_2 = 3)
	{
		g8.d d = new g8.d();
		d.a = A_0;
		if (d.a == null || A_1 == null || d.a.a8() == null || A_1.a8() == null || A_1.a8().Area == null || d.a.a8().Area == null)
		{
			return null;
		}
		ale b = d.a.a8().k.b;
		if (b == null)
		{
			return null;
		}
		Vector3 vector = d.a.a8().aj();
		Point a_ = new Point((int)vector.X, (int)vector.Y);
		Point a_2 = A_1.a8().aj().a();
		List<ak1> list = g8.a(b, d.a.a8().Area, a_, a_2, 2, A_2, false);
		aw1.b(d.a.a8(), A_1.a8());
		if (list.Count > 0)
		{
			d02 service = bpo.GetService<d02>();
			if (service == null)
			{
				return null;
			}
			HashSet<r0> hashSet = A_1.b(service);
			IEnumerable<ak1> enumerable = list;
			Func<ak1, double> func;
			if ((func = d.b) == null)
			{
				func = (d.b = new Func<ak1, double>(d.a));
			}
			foreach (ak1 ak in Enumerable.OrderByDescending<ak1, double>(enumerable, func))
			{
				r0 r = new r0(ak.Area.c(), new Vector2((float)ak.Location.X, (float)ak.Location.Y));
				if (hashSet.Contains(r) && (double)bnx.a(ak.Location, A_1.a8()) <= 1.5)
				{
					return ak;
				}
			}
		}
		return null;
	}

	// Token: 0x06001874 RID: 6260 RVA: 0x0007CCAC File Offset: 0x0007AEAC
	public static ak1 a(bm6 A_0, c5x A_1, int A_2 = 10)
	{
		ale b = A_0.a8().k.b;
		if (b == null)
		{
			return null;
		}
		Vector3 vector = A_0.a8().aj();
		Point a_ = new Point((int)vector.X, (int)vector.Y);
		List<ak1> list = g8.a(b, A_0.a8().Area, a_, Point.Zero, int.MaxValue, A_2, true);
		if (list.Count <= 0)
		{
			return null;
		}
		if (A_1 != null && A_1.Area == A_0.a8().Area)
		{
			g8.a a = new g8.a();
			a.a = A_1.aj().a();
			return Enumerable.FirstOrDefault<ak1>(Enumerable.OrderByDescending<ak1, float>(list, new Func<ak1, float>(a.a)));
		}
		return list[cuo.a.Next(list.Count)];
	}

	// Token: 0x06001875 RID: 6261 RVA: 0x0007CD84 File Offset: 0x0007AF84
	public static ak1 b(bm6 A_0)
	{
		ale b = A_0.a8().k.b;
		if (b == null)
		{
			return null;
		}
		Vector3 vector = A_0.a8().aj();
		Point a_ = new Point((int)vector.X, (int)vector.Y);
		List<ak1> list = g8.a(b, A_0.a8().Area, a_, Point.Zero, int.MaxValue, 5, true);
		int num = int.MaxValue;
		double num2 = double.MaxValue;
		ak1 result = null;
		foreach (ak1 ak in list)
		{
			double num3 = aw1.a(A_0.a8(), ak);
			int num4 = dd5.a(ak);
			if (num4 < num)
			{
				num = num4;
				num2 = num3;
				result = ak;
			}
			else if (num4 == num && num3 < num2)
			{
				num2 = num3;
				result = ak;
			}
		}
		return result;
	}

	// Token: 0x06001876 RID: 6262 RVA: 0x0007CE8C File Offset: 0x0007B08C
	public static ak1 a(bm6 A_0)
	{
		ale b = A_0.a8().k.b;
		if (b == null)
		{
			return null;
		}
		Vector3 vector = A_0.a8().aj();
		Point a_ = new Point((int)vector.X, (int)vector.Y);
		List<ak1> list = g8.a(b, A_0.a8().Area, a_, Point.Zero, int.MaxValue, 5, true);
		int num = int.MaxValue;
		double num2 = double.MaxValue;
		ak1 result = null;
		foreach (ak1 ak in list)
		{
			double num3 = aw1.a(A_0.a8(), ak);
			int num4 = bpv.a(ak);
			if (num4 < num)
			{
				num = num4;
				num2 = num3;
				result = ak;
			}
			else if (num4 == num && num3 < num2)
			{
				num2 = num3;
				result = ak;
			}
		}
		return result;
	}

	// Token: 0x06001877 RID: 6263 RVA: 0x0007CF94 File Offset: 0x0007B194
	public static ak1 a(bm6 A_0, bm6 A_1, int A_2)
	{
		g8.b b = new g8.b();
		if (A_0 == null || A_1 == null || A_0.a8() == null || A_1.a8() == null || A_1.a8().Area == null || A_0.a8().Area == null)
		{
			return null;
		}
		if (A_0.a8().Area != A_1.a8().Area)
		{
			return null;
		}
		ale b2 = A_0.a8().k.b;
		if (b2 == null)
		{
			return null;
		}
		Vector3 vector = A_0.a8().aj();
		b.a = new Point((int)vector.X, (int)vector.Y);
		HashSet<r0> hashSet = A_1.b(bpo.GetServiceOrThrow<d02>());
		if (hashSet != null && hashSet.Count > 0)
		{
			List<ak1> list = g8.a(b2, A_0.a8().Area, b.a, Point.Zero, int.MaxValue, A_2, false);
			int a_ = A_0.a8().Area.c();
			List<ak1> list2 = new List<ak1>();
			foreach (ak1 ak in list)
			{
				r0 r = new r0(a_, new Vector2((float)ak.Location.X, (float)ak.Location.Y));
				if (!hashSet.Contains(r))
				{
					list2.Add(ak);
				}
			}
			if (list2.Count > 0)
			{
				return Enumerable.FirstOrDefault<ak1>(Enumerable.OrderBy<ak1, float>(list2, new Func<ak1, float>(b.a)));
			}
		}
		return null;
	}

	// Token: 0x06001878 RID: 6264 RVA: 0x0007D148 File Offset: 0x0007B348
	private static List<ak1> a(ale A_0, aud A_1, Point A_2, Point A_3, int A_4, int A_5, bool A_6 = false)
	{
		HashSet<Point> hashSet = new HashSet<Point>();
		Dictionary<Point, int> a_ = new Dictionary<Point, int>();
		List<ak1> list = new List<ak1>();
		int a_2 = A_1.c();
		d25 d = new d25();
		d.f = dd5.b(A_0.a8());
		d.g = bpv.a(A_0.a8());
		g8.b(A_0, hashSet, a_, a_2, A_1, A_2, A_3, A_4, A_5 * 10, d, A_6);
		foreach (Point a_3 in hashSet)
		{
			ak1 ak = A_1.a(a_3);
			if (ak != null)
			{
				list.Add(ak);
			}
		}
		return list;
	}

	// Token: 0x06001879 RID: 6265 RVA: 0x0007D20C File Offset: 0x0007B40C
	private static void b(ale A_0, HashSet<Point> A_1, Dictionary<Point, int> A_2, int A_3, aud A_4, Point A_5, Point A_6, int A_7, int A_8, d25 A_9, bool A_10)
	{
		if (g8.a(A_0, A_1, A_2, A_3, A_4, new Point(A_5.X, A_5.Y - 1), A_6, A_7, A_8 - 10, A_9, A_10) && A_8 - 10 > 0)
		{
			g8.b(A_0, A_1, A_2, A_3, A_4, new Point(A_5.X, A_5.Y - 1), A_6, A_7, A_8 - 10, A_9, A_10);
		}
		if (g8.a(A_0, A_1, A_2, A_3, A_4, new Point(A_5.X, A_5.Y + 1), A_6, A_7, A_8 - 10, A_9, A_10) && A_8 - 10 > 0)
		{
			g8.b(A_0, A_1, A_2, A_3, A_4, new Point(A_5.X, A_5.Y + 1), A_6, A_7, A_8 - 10, A_9, A_10);
		}
		if (g8.a(A_0, A_1, A_2, A_3, A_4, new Point(A_5.X - 1, A_5.Y), A_6, A_7, A_8 - 10, A_9, A_10) && A_8 - 10 > 0)
		{
			g8.b(A_0, A_1, A_2, A_3, A_4, new Point(A_5.X - 1, A_5.Y), A_6, A_7, A_8 - 10, A_9, A_10);
		}
		if (g8.a(A_0, A_1, A_2, A_3, A_4, new Point(A_5.X + 1, A_5.Y), A_6, A_7, A_8 - 10, A_9, A_10) && A_8 - 10 > 0)
		{
			g8.b(A_0, A_1, A_2, A_3, A_4, new Point(A_5.X + 1, A_5.Y), A_6, A_7, A_8 - 10, A_9, A_10);
		}
		if (g8.a(A_0, A_1, A_2, A_3, A_4, new Point(A_5.X - 1, A_5.Y - 1), A_6, A_7, A_8 - 14, A_9, A_10) && A_8 - 14 > 0)
		{
			g8.b(A_0, A_1, A_2, A_3, A_4, new Point(A_5.X - 1, A_5.Y - 1), A_6, A_7, A_8 - 14, A_9, A_10);
		}
		if (g8.a(A_0, A_1, A_2, A_3, A_4, new Point(A_5.X + 1, A_5.Y - 1), A_6, A_7, A_8 - 14, A_9, A_10) && A_8 - 14 > 0)
		{
			g8.b(A_0, A_1, A_2, A_3, A_4, new Point(A_5.X + 1, A_5.Y - 1), A_6, A_7, A_8 - 14, A_9, A_10);
		}
		if (g8.a(A_0, A_1, A_2, A_3, A_4, new Point(A_5.X - 1, A_5.Y + 1), A_6, A_7, A_8 - 14, A_9, A_10) && A_8 - 14 > 0)
		{
			g8.b(A_0, A_1, A_2, A_3, A_4, new Point(A_5.X - 1, A_5.Y + 1), A_6, A_7, A_8 - 14, A_9, A_10);
		}
		if (g8.a(A_0, A_1, A_2, A_3, A_4, new Point(A_5.X + 1, A_5.Y + 1), A_6, A_7, A_8 - 14, A_9, A_10) && A_8 - 14 > 0)
		{
			g8.b(A_0, A_1, A_2, A_3, A_4, new Point(A_5.X + 1, A_5.Y + 1), A_6, A_7, A_8 - 14, A_9, A_10);
		}
	}

	// Token: 0x0600187A RID: 6266 RVA: 0x0007D57C File Offset: 0x0007B77C
	private static bool a(ale A_0, HashSet<Point> A_1, Dictionary<Point, int> A_2, int A_3, aud A_4, Point A_5, Point A_6, int A_7, int A_8, d25 A_9, bool A_10)
	{
		if (bnx.a(A_6, A_5) <= (float)A_7 && (!A_1.Contains(A_5) || A_2[A_5] < A_8))
		{
			ak1 ak = A_4.a(A_5);
			if (ak == null || ak.f(A_0.a8()) != 0L)
			{
				return false;
			}
			ee4 a_ = new ee4(A_3, new Point(A_5.X * 4, A_5.Y * 4));
			eyu eyu = A_0.a(a_, null, A_9, null);
			if (eyu.b == ac7.c && (A_10 || eyu.a < 2f))
			{
				A_1.Add(A_5);
				A_2[A_5] = A_8;
				return true;
			}
		}
		return false;
	}

	// Token: 0x0200036A RID: 874
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x0600187C RID: 6268 RVA: 0x0007D648 File Offset: 0x0007B848
		internal float a(ak1 A_0)
		{
			return bnx.a(A_0.Location, this.a);
		}

		// Token: 0x04000E4A RID: 3658
		public Point a;

		// Token: 0x04000E4B RID: 3659
		public Func<ak1, float> b;
	}

	// Token: 0x0200036B RID: 875
	[CompilerGenerated]
	private sealed class d
	{
		// Token: 0x0600187E RID: 6270 RVA: 0x0007D664 File Offset: 0x0007B864
		internal double a(ak1 A_0)
		{
			return aw1.a(this.a.a8(), A_0);
		}

		// Token: 0x04000E4C RID: 3660
		public bm6 a;

		// Token: 0x04000E4D RID: 3661
		public Func<ak1, double> b;
	}

	// Token: 0x0200036C RID: 876
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x06001880 RID: 6272 RVA: 0x0007D680 File Offset: 0x0007B880
		internal float a(ak1 A_0)
		{
			return bnx.a(A_0.Location, this.a);
		}

		// Token: 0x04000E4E RID: 3662
		public Point a;
	}

	// Token: 0x0200036D RID: 877
	[CompilerGenerated]
	private sealed class b
	{
		// Token: 0x06001882 RID: 6274 RVA: 0x0007D69C File Offset: 0x0007B89C
		internal float a(ak1 A_0)
		{
			return bnx.a(A_0.Location, this.a);
		}

		// Token: 0x04000E4F RID: 3663
		public Point a;
	}
}
