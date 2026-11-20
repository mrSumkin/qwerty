using System;
using Microsoft.Xna.Framework;

// Token: 0x02000725 RID: 1829
public static class ey0
{
	// Token: 0x06002F6F RID: 12143 RVA: 0x0011F5E4 File Offset: 0x0011D7E4
	public static void a(a7m A_0, e5q A_1)
	{
		if (A_1.i != 2147483647)
		{
			return;
		}
		float num;
		if (A_0 != null)
		{
			num = A_0.y;
		}
		else
		{
			num = 1f;
		}
		foreach (a2f a2f in A_1.a)
		{
			if (a2f.a != "d" && a2f.a != "SHD" && a2f.a != "o" && a2f.a != "selection" && !a2f.w)
			{
				Rectangle rectangle = a7m.a(a2f);
				if (rectangle.Top < A_1.i)
				{
					A_1.i = rectangle.Top;
				}
				if (rectangle.Bottom > A_1.j)
				{
					A_1.j = rectangle.Bottom;
				}
				if (rectangle.Left < A_1.k)
				{
					A_1.k = rectangle.Left;
				}
				if (rectangle.Right > A_1.l)
				{
					A_1.l = rectangle.Right;
				}
				Point point = new Point(rectangle.X + (int)((a2f.j.X + 48f) * a2f.l.X * num), rectangle.Y + (int)((a2f.j.Y + 24f) * a2f.l.Y * num));
				if (A_1.o == null || A_1.o.Value.Y < point.Y)
				{
					A_1.o = new Point?(point);
				}
				if (A_1.p == 1f || a2f.l.X > A_1.p)
				{
					A_1.p = a2f.l.X;
				}
			}
		}
		if (A_1.o != null)
		{
			A_1.m = A_1.o.Value.X;
		}
		else
		{
			A_1.m = A_1.k + (A_1.l - A_1.k) / 2;
		}
		A_1.n = A_1.i + (A_1.j - A_1.i) / 2;
	}
}
