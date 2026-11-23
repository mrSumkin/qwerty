using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Data;

// Token: 0x02001183 RID: 4483
public static class eum
{
	// Token: 0x06005FBE RID: 24510 RVA: 0x0029B4CC File Offset: 0x002996CC
	static eum()
	{
		eum.a();
	}

	// Token: 0x06005FBF RID: 24511 RVA: 0x0029B4EC File Offset: 0x002996EC
	private static void a()
	{
		eum.a(Convert.ToByte("01011010", 2), Convert.ToByte("11111111", 2), new Point(8, 1));
		eum.a(Convert.ToByte("01010010", 2), Convert.ToByte("11111111", 2), new Point(0, 1));
		eum.a(Convert.ToByte("00011010", 2), Convert.ToByte("11111111", 2), new Point(1, 1));
		eum.a(Convert.ToByte("01001010", 2), Convert.ToByte("11111111", 2), new Point(2, 1));
		eum.a(Convert.ToByte("01011000", 2), Convert.ToByte("11111111", 2), new Point(3, 1));
		eum.a(Convert.ToByte("01010000", 2), Convert.ToByte("11111110", 2), new Point(5, 0));
		eum.a(Convert.ToByte("01001000", 2), Convert.ToByte("11111011", 2), new Point(6, 0));
		eum.a(Convert.ToByte("00010010", 2), Convert.ToByte("11011111", 2), new Point(7, 0));
		eum.a(Convert.ToByte("00001010", 2), Convert.ToByte("01111111", 2), new Point(8, 0));
		eum.a(Convert.ToByte("01000000", 2), Convert.ToByte("11111000", 2), new Point(1, 0));
		eum.a(Convert.ToByte("00000010", 2), Convert.ToByte("00011111", 2), new Point(2, 0));
		eum.a(Convert.ToByte("00010000", 2), Convert.ToByte("11010110", 2), new Point(3, 0));
		eum.a(Convert.ToByte("00001000", 2), Convert.ToByte("01101011", 2), new Point(4, 0));
		eum.a(Convert.ToByte("00000100", 2), Convert.ToByte("00000100", 2), new Point(4, 1));
		eum.a(Convert.ToByte("00000001", 2), Convert.ToByte("00000001", 2), new Point(5, 1));
		eum.a(Convert.ToByte("00100000", 2), Convert.ToByte("00100000", 2), new Point(6, 1));
		eum.a(Convert.ToByte("10000000", 2), Convert.ToByte("10000000", 2), new Point(7, 1));
	}

	// Token: 0x06005FC0 RID: 24512 RVA: 0x0029B73C File Offset: 0x0029993C
	private static void a(byte A_0, byte A_1, Point A_2)
	{
		bzx bzx = new bzx(A_0, A_1, A_2);
		eum.a.Add(bzx);
		eum.b.Add(A_2, bzx);
	}

	// Token: 0x06005FC1 RID: 24513 RVA: 0x0029B76C File Offset: 0x0029996C
	private static byte b(ak1 A_0, string A_1)
	{
		aud aud = A_0.Area;
		if (aud == null)
		{
			return 0;
		}
		byte b = 0;
		int num = 0;
		for (int i = 1; i >= -1; i--)
		{
			for (int j = 1; j >= -1; j--)
			{
				if (j != 0 || i != 0)
				{
					ak1 ak = aud.b(A_0.Location.X + j, A_0.Location.Y + i);
					if (ak != null)
					{
						foreach (b0b b0b in ak.Entities)
						{
							c5x c5x = (c5x)b0b;
							if (c5x.IsFloor && c5x.o.b != null && c5x.o.b.a != null && c5x.o.b.a.ToLower() == A_1.ToLower() && c5x.o.b.b == Point.Zero)
							{
								b |= (byte)(1 << num);
								break;
							}
						}
					}
					num++;
				}
			}
		}
		return b;
	}

	// Token: 0x06005FC2 RID: 24514 RVA: 0x0029B8CC File Offset: 0x00299ACC
	private static int a(byte[] A_0, int A_1)
	{
		int num = A_1 / 8;
		int num2 = A_1 % 8;
		return A_0[num] >> 8 - (num2 + 1) & 1;
	}

	// Token: 0x06005FC3 RID: 24515 RVA: 0x0029B8F0 File Offset: 0x00299AF0
	private static bool a(byte A_0, int A_1)
	{
		return ((int)A_0 & 1 << A_1) != 0;
	}

	// Token: 0x06005FC4 RID: 24516 RVA: 0x0029B900 File Offset: 0x00299B00
	private static List<bzx> a(List<c5x> A_0, string A_1)
	{
		List<bzx> list = new List<bzx>();
		using (List<c5x>.Enumerator enumerator = A_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				eum.b b = new eum.b();
				b.a = enumerator.Current;
				if (b.a.IsFloor && b.a.o.b != null && b.a.o.b.a != null && b.a.o.b.a.ToLower() == A_1.ToLower())
				{
					if (!(b.a.o.b.b != Point.Zero))
					{
						return null;
					}
					bzx item = Enumerable.FirstOrDefault<bzx>(Enumerable.Where<bzx>(eum.a, new Func<bzx, bool>(b.a)));
					list.Add(item);
				}
			}
		}
		return list;
	}

	// Token: 0x06005FC5 RID: 24517 RVA: 0x0029BA24 File Offset: 0x00299C24
	public static CollectionDelta<c5x> a(ak1 A_0, string A_1, string A_2)
	{
		if (A_0 == null)
		{
			return null;
		}
		List<c5x> list = new List<c5x>();
		List<c5x> list2 = new List<c5x>();
		List<c5x> list3 = eum.a(A_0, A_1);
		if (list3 == null)
		{
			return null;
		}
		List<bzx> list4 = eum.a(list3, A_1);
		byte b = eum.b(A_0, A_1);
		byte b2 = 0;
		List<bzx> list5 = new List<bzx>();
		d6j serviceOrThrow = bpo.GetServiceOrThrow<d6j>();
		foreach (bzx bzx in eum.a)
		{
			if ((bzx.a & b) == bzx.a && (b2 & bzx.a) == 0)
			{
				b2 |= bzx.b;
				list5.Add(bzx);
			}
		}
		HashSet<Point> hashSet = new HashSet<Point>(Enumerable.Select<bzx, Point>(Enumerable.Except<bzx>(list4, list5), new Func<bzx, Point>(eum.a.a.a)));
		HashSet<bzx> hashSet2 = new HashSet<bzx>(Enumerable.Except<bzx>(list5, list4));
		foreach (c5x c5x in list3)
		{
			if (hashSet.Contains(c5x.o.b.b))
			{
				list2.Add(c5x);
			}
		}
		foreach (bzx bzx2 in hashSet2)
		{
			int a_ = 0;
			if (eum.a(bzx2.b, 0))
			{
				a_ = -2;
			}
			else if (eum.a(bzx2.a, 5))
			{
				a_ = -1;
			}
			c5x c5x2 = serviceOrThrow.dv().a(A_2).a(null, false) as c5x;
			c5x2.o.b.b = bzx2.c;
			c5x2.Location = A_0.Location.a();
			c5x2.Layer = aju.x;
			c5x2.ae = new float?(0f);
			c5x2.VisualPriority = a_;
			list.Add(c5x2);
		}
		return new CollectionDelta<c5x>(new List<c5x>(), new List<c5x>(), list, list2);
	}

	// Token: 0x06005FC6 RID: 24518 RVA: 0x0029BCA4 File Offset: 0x00299EA4
	public static List<c5x> a(ak1 A_0, string A_1)
	{
		List<c5x> list = new List<c5x>();
		foreach (b0b b0b in A_0.Entities)
		{
			c5x c5x = (c5x)b0b;
			if (c5x.IsFloor && c5x.o.b != null && c5x.o.b.a != null && c5x.o.b.a.ToLower() == A_1.ToLower())
			{
				if (c5x.o.b.b == Point.Zero)
				{
					return null;
				}
				list.Add(c5x);
			}
		}
		return list;
	}

	// Token: 0x06005FC7 RID: 24519 RVA: 0x0029BD88 File Offset: 0x00299F88
	public static bzx a(Point A_0)
	{
		bzx result;
		eum.b.TryGetValue(A_0, out result);
		return result;
	}

	// Token: 0x04002827 RID: 10279
	public static List<bzx> a = new List<bzx>();

	// Token: 0x04002828 RID: 10280
	public static Dictionary<Point, bzx> b = new Dictionary<Point, bzx>();

	// Token: 0x02001184 RID: 4484
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06005FCA RID: 24522 RVA: 0x0029BDB8 File Offset: 0x00299FB8
		internal Point a(bzx A_0)
		{
			return A_0.c;
		}

		// Token: 0x04002829 RID: 10281
		public static readonly eum.a a = new eum.a();

		// Token: 0x0400282A RID: 10282
		public static Func<bzx, Point> b;
	}

	// Token: 0x02001185 RID: 4485
	[CompilerGenerated]
	private sealed class b
	{
		// Token: 0x06005FCC RID: 24524 RVA: 0x0029BDC8 File Offset: 0x00299FC8
		internal bool a(bzx A_0)
		{
			return A_0.c == this.a.o.b.b;
		}

		// Token: 0x0400282B RID: 10283
		public c5x a;
	}
}
