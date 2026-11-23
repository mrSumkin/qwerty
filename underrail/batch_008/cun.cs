using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02001353 RID: 4947
public static class cun
{
	// Token: 0x06006FF9 RID: 28665 RVA: 0x002EFC88 File Offset: 0x002EDE88
	public static bool a(c5x A_0, object A_1, List<HorizontalDirection> A_2, int A_3)
	{
		Point b;
		HashSet<Point> hashSet;
		int num;
		cun.b(A_0, A_1, A_2, out b, out hashSet, out num, A_3);
		if (A_0.Area.c() == num)
		{
			Point point;
			Point point2;
			A_0.b(out point, out point2);
			return point == b || hashSet.Contains(point);
		}
		return false;
	}

	// Token: 0x06006FFA RID: 28666 RVA: 0x002EFCD8 File Offset: 0x002EDED8
	private static HashSet<Point> a(c5x A_0, Point A_1, Point A_2, esj A_3, b0b A_4, List<HorizontalDirection> A_5)
	{
		HashSet<Point> hashSet = new HashSet<Point>();
		esj esj = new esj((int)Math.Ceiling((double)A_3.c / 4.0) * 4, (int)Math.Ceiling((double)A_3.d / 4.0) * 4);
		if (esj.c(A_3, esj) && A_4 != null && A_4.z != null && !A_4.TileFormationModifiers.b(2L) && !(A_4.GetAspect<bim>() is cnb))
		{
			if (A_0 != null && A_0.h.b != null && !A_0.h.b.aa().IsMobile)
			{
				Point point;
				Point point2;
				A_0.b(out point, out point2);
				esj esj2 = A_3;
				if (A_0.Location.X > (float)point.X / 4f)
				{
					esj2 = new esj(esj2.c + 1, esj2.d);
				}
				if (A_0.Location.Y > (float)point.Y / 4f)
				{
					esj2 = new esj(esj2.c, esj2.d + 1);
				}
				cun.a(A_1, A_2, esj2, hashSet, A_5);
			}
			else
			{
				cun.a(A_1, A_2, A_3, hashSet, A_5);
			}
		}
		else
		{
			cun.a(A_1, A_2, esj, hashSet, A_5);
		}
		return hashSet;
	}

	// Token: 0x06006FFB RID: 28667 RVA: 0x002EFE40 File Offset: 0x002EE040
	public static bool b(c5x A_0, object A_1, List<HorizontalDirection> A_2, out Point A_3, out HashSet<Point> A_4, out int A_5, int A_6)
	{
		int num = A_6;
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.h.b != null && (A_0.IsPlayer || (A_0.h.b != null && !A_0.h.b.aa().IsMobile)))
		{
			num++;
		}
		return cun.a(A_0, A_1, A_2, out A_3, out A_4, out A_5, num);
	}

	// Token: 0x06006FFC RID: 28668 RVA: 0x002EFEB4 File Offset: 0x002EE0B4
	private static bool a(c5x A_0, object A_1, List<HorizontalDirection> A_2, out Point A_3, out HashSet<Point> A_4, out int A_5, int A_6)
	{
		c5x c5x = A_1 as c5x;
		ak1 ak = A_1 as ak1;
		Point point;
		Point point2;
		if (c5x != null)
		{
			c5x.a(out point, out point2);
			bool flag = false;
			if (c5x.z != null && point == point2)
			{
				ak1 a_ = c5x.Area.a(point);
				if (aw1.a(A_0, a_, true, A_0))
				{
					flag = true;
				}
			}
			if (c5x.z != null && !flag)
			{
				c5x.b(out point, out point2);
			}
			else
			{
				point = new Point(point.X * 4, point.Y * 4);
				point2 = new Point(point2.X * 4 + 4 - 1, point2.Y * 4 + 4 - 1);
			}
			A_3 = point;
			if (A_6 > 0)
			{
				point = new Point(point.X - A_6, point.Y - A_6);
				point2 = new Point(point2.X + A_6, point2.Y + A_6);
			}
			A_5 = c5x.Area.c();
		}
		else
		{
			if (ak == null)
			{
				A_3 = Point.Zero;
				A_4 = new HashSet<Point>();
				A_5 = 0;
				return false;
			}
			point = new Point(ak.Location.X * 4, ak.Location.Y * 4);
			point2 = new Point(point.X + 4 - 1, point.Y + 4 - 1);
			A_3 = point;
			A_5 = ak.Area.c();
		}
		A_4 = cun.a(A_0, point, point2, A_0.i(), c5x, A_2);
		Point point3;
		HashSet<Point> hashSet;
		int num;
		if (A_6 > 0 && cun.a(A_0, A_1, A_2, out point3, out hashSet, out num, A_6 - 1) && hashSet != null && hashSet.Count > 0)
		{
			foreach (Point point4 in hashSet)
			{
				A_4.Add(point4);
			}
		}
		return true;
	}

	// Token: 0x06006FFD RID: 28669 RVA: 0x002F00D8 File Offset: 0x002EE2D8
	public static bool a(ref d25 A_0)
	{
		if (A_0 == null)
		{
			A_0 = new d25();
		}
		if (A_0.j == null)
		{
			ps serviceOrThrow = bpo.GetServiceOrThrow<ps>();
			A_0.j = new bool?(serviceOrThrow.alk());
		}
		return A_0.j.Value;
	}

	// Token: 0x06006FFE RID: 28670 RVA: 0x002F0128 File Offset: 0x002EE328
	private static void a(Point A_0, Point A_1, esj A_2, HashSet<Point> A_3, List<HorizontalDirection> A_4)
	{
		double num = (double)A_2.c / 2.0;
		double num2 = (double)A_2.d / 2.0;
		int num3 = (int)Math.Floor((double)A_2.c / 2.0);
		int num4 = (int)Math.Floor((double)A_2.d / 2.0);
		if (num == (double)num3 && num3 > 1)
		{
			num3--;
		}
		if (num2 == (double)num4 && num4 > 1)
		{
			num4--;
		}
		int num5 = Math.Max(0, A_2.c - num3 - 1);
		int num6 = Math.Max(0, A_2.c - num4 - 1);
		for (int i = A_0.X - num3; i <= Math.Max(A_0.X, A_1.X - (A_2.c - 1)) + num3; i++)
		{
			if (cun.a(HorizontalDirection.North, A_4))
			{
				A_3.Add(new Point(i, A_0.Y - A_2.d));
			}
			if (cun.a(HorizontalDirection.South, A_4))
			{
				A_3.Add(new Point(i, A_1.Y + 1));
			}
		}
		for (int j = A_0.Y - num4; j <= Math.Max(A_0.Y, A_1.Y - (A_2.d - 1)) + num4; j++)
		{
			if (cun.a(HorizontalDirection.West, A_4))
			{
				A_3.Add(new Point(A_0.X - A_2.c, j));
			}
			if (cun.a(HorizontalDirection.East, A_4))
			{
				A_3.Add(new Point(A_1.X + 1, j));
			}
		}
		for (int k = 0; k <= num5; k++)
		{
			if (cun.a(HorizontalDirection.Northwest, A_4))
			{
				A_3.Add(new Point(A_0.X - A_2.c + k, A_0.Y - A_2.d));
			}
			if (cun.a(HorizontalDirection.Southwest, A_4))
			{
				A_3.Add(new Point(A_0.X - A_2.c + k, A_1.Y + 1));
			}
			if (cun.a(HorizontalDirection.Northeast, A_4))
			{
				A_3.Add(new Point(A_1.X + 1 - k, A_0.Y - A_2.d));
			}
			if (cun.a(HorizontalDirection.Southeast, A_4))
			{
				A_3.Add(new Point(A_1.X + 1 - k, A_1.Y + 1));
			}
		}
		for (int l = 0; l <= num6; l++)
		{
			if (cun.a(HorizontalDirection.Northwest, A_4))
			{
				A_3.Add(new Point(A_0.X - A_2.c, A_0.Y - A_2.d + l));
			}
			if (cun.a(HorizontalDirection.Southwest, A_4))
			{
				A_3.Add(new Point(A_0.X - A_2.c, A_1.Y + 1 - l));
			}
			if (cun.a(HorizontalDirection.Northeast, A_4))
			{
				A_3.Add(new Point(A_1.X + 1, A_0.Y - A_2.d + l));
			}
			if (cun.a(HorizontalDirection.Southeast, A_4))
			{
				A_3.Add(new Point(A_1.X + 1, A_1.Y + 1 - l));
			}
		}
	}

	// Token: 0x06006FFF RID: 28671 RVA: 0x002F0488 File Offset: 0x002EE688
	private static bool a(HorizontalDirection A_0, List<HorizontalDirection> A_1)
	{
		return A_1 == null || A_1.Count == 0 || A_1.Contains(A_0);
	}
}
