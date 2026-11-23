using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02001007 RID: 4103
public static class aw1
{
	// Token: 0x06005475 RID: 21621 RVA: 0x00255100 File Offset: 0x00253300
	static aw1()
	{
		aw1.a.Add(HorizontalDirection.North, new acn(aw1.h));
		aw1.a.Add(HorizontalDirection.South, new acn(aw1.g));
		aw1.a.Add(HorizontalDirection.East, new acn(aw1.e));
		aw1.a.Add(HorizontalDirection.West, new acn(aw1.f));
		aw1.a.Add(HorizontalDirection.Northwest, new acn(aw1.d));
		aw1.a.Add(HorizontalDirection.Northeast, new acn(aw1.c));
		aw1.a.Add(HorizontalDirection.Southwest, new acn(aw1.b));
		aw1.a.Add(HorizontalDirection.Southeast, new acn(aw1.a));
	}

	// Token: 0x06005476 RID: 21622 RVA: 0x002551D0 File Offset: 0x002533D0
	public static anp b(Point A_0, aud A_1, float A_2, long A_3 = 0L, long A_4 = 0L)
	{
		czh.a(A_1, "area");
		anp anp = new anp(A_0, A_1, A_2, bcj.a(new long[]
		{
			1L,
			4L
		}) | A_3, false, A_4);
		anp.a(new float?(aju.e));
		return anp;
	}

	// Token: 0x06005477 RID: 21623 RVA: 0x00255210 File Offset: 0x00253410
	public static anp a(Point A_0, aud A_1, float A_2, long A_3 = 0L, long A_4 = 0L)
	{
		czh.a(A_1, "area");
		anp anp = new anp(A_0, A_1, A_2, bcj.a(new long[]
		{
			4L
		}) | A_3, false, A_4);
		anp.a(new float?(aju.e));
		return anp;
	}

	// Token: 0x06005478 RID: 21624 RVA: 0x0025524C File Offset: 0x0025344C
	public static bool a(float A_0, float A_1)
	{
		return (float)Convert.ToInt32(A_0) <= A_1;
	}

	// Token: 0x06005479 RID: 21625 RVA: 0x0025525C File Offset: 0x0025345C
	public static void b(b0b A_0, object A_1, bool A_2 = false)
	{
		HorizontalDirection? horizontalDirection = aw1.a(A_0, A_1, A_2);
		if (horizontalDirection != null)
		{
			A_0.VisualDirection = horizontalDirection.Value;
		}
	}

	// Token: 0x0600547A RID: 21626 RVA: 0x0025528C File Offset: 0x0025348C
	public static HorizontalDirection? a(b0b A_0, object A_1, bool A_2 = false)
	{
		ak1 ak = A_1 as ak1;
		if (A_1 != A_0 && (ak == null || !(new Point((int)A_0.Location.X, (int)A_0.Location.Y) == ak.Location)))
		{
			Vector3? vector = null;
			Vector3 vector2 = A_0.Location;
			b0b b0b = A_1 as b0b;
			if (b0b != null)
			{
				vector = new Vector3?(b0b.Location);
				if (A_2)
				{
					Vector3? vector3 = vector;
					Vector3 value = b0b.Size.b().b() / 2f;
					vector = vector3 + value;
					vector2 += A_0.Size.b().b() / 2f;
				}
			}
			else if (ak != null)
			{
				vector = new Vector3?(new Vector3((float)ak.Location.X, (float)ak.Location.Y, 0f));
				if (A_2)
				{
					Vector3? vector3 = vector;
					Vector3 value = new Vector3(0.5f, 0.5f, 0f);
					vector = vector3 + value;
					vector2 += new Vector3(0.5f, 0.5f, 0f);
				}
			}
			if (vector != null)
			{
				return new HorizontalDirection?(bnx.a(vector2, vector.Value));
			}
		}
		return null;
	}

	// Token: 0x0600547B RID: 21627 RVA: 0x00255440 File Offset: 0x00253640
	public static void a(c5x A_0, b0b A_1)
	{
		ak1 ak = null;
		double num = double.MaxValue;
		foreach (ak1 ak2 in A_1.l)
		{
			double num2 = aw1.a(A_0, ak2);
			if (num2 < num)
			{
				num = num2;
				ak = ak2;
			}
		}
		if (ak != null)
		{
			aw1.b(A_0, ak, false);
		}
	}

	// Token: 0x0600547C RID: 21628 RVA: 0x002554C4 File Offset: 0x002536C4
	public static double b(b0b A_0, b0b A_1)
	{
		return (double)Math.Abs((A_0.Location.b() - A_1.Location.b()).Length());
	}

	// Token: 0x0600547D RID: 21629 RVA: 0x002554FC File Offset: 0x002536FC
	public static double a(b0b A_0, ak1 A_1)
	{
		Vector2 value = new Vector2(A_0.Location.X + A_0.Size.X / 2f, A_0.Location.Y + A_0.Size.Y / 2f);
		Vector2 value2 = new Vector2((float)A_1.Location.X + 0.5f, (float)A_1.Location.Y + 0.5f);
		return (double)Math.Abs((value - value2).Length());
	}

	// Token: 0x0600547E RID: 21630 RVA: 0x00255588 File Offset: 0x00253788
	public static bool a(b0b A_0, b0b A_1)
	{
		Point a_ = A_0.aj().a();
		Point a_2 = d05.a(A_1.aj().a(), a_, true);
		return aw1.a[A_0.VisualDirection](a_2);
	}

	// Token: 0x0600547F RID: 21631 RVA: 0x002555CC File Offset: 0x002537CC
	public static bool a(b0b A_0, bt4 A_1, bool A_2 = false)
	{
		aud aud;
		Vector3 value;
		HorizontalDirection horizontalDirection;
		A_1.a(A_0.Zone, out aud, out value, out horizontalDirection);
		return A_0.Area == aud && A_0.Location == value && (!A_2 || horizontalDirection == A_0.VisualDirection);
	}

	// Token: 0x06005480 RID: 21632 RVA: 0x0025561C File Offset: 0x0025381C
	public static List<amc> a(c5x A_0, int A_1 = 1)
	{
		HashSet<amc> hashSet = new HashSet<amc>();
		Point point = A_0.aj().a();
		for (int i = point.X - A_1; i <= point.X + A_1; i++)
		{
			for (int j = point.Y - A_1; j <= point.Y + A_1; j++)
			{
				ak1 ak = A_0.Area.b(i, j);
				if (ak != null)
				{
					foreach (b0b b0b in ak.Entities)
					{
						c5x c5x = (c5x)b0b;
						if (c5x != A_0 && c5x.h.b != null)
						{
							hashSet.Add(c5x.h.b);
						}
					}
				}
			}
		}
		return new List<amc>(hashSet);
	}

	// Token: 0x06005481 RID: 21633 RVA: 0x00255714 File Offset: 0x00253914
	public static l9 a(c5x A_0)
	{
		l9 result = l9.a;
		if (A_0 != null)
		{
			amc amc;
			if (A_0.h != null)
			{
				amc = A_0.h.b;
			}
			else
			{
				amc = A_0.GetAspect<amc>();
			}
			if (amc != null)
			{
				if (amc.aa().b(d8o.l))
				{
					return l9.b;
				}
				if (amc.aa().b(d8o.n))
				{
					return l9.c;
				}
			}
		}
		return result;
	}

	// Token: 0x06005482 RID: 21634 RVA: 0x00255784 File Offset: 0x00253984
	public static bool a(b0b A_0, ak1 A_1, bool A_2 = false, b0b A_3 = null)
	{
		c5x c5x = A_0 as c5x;
		l9 a_;
		if (c5x != null)
		{
			a_ = aw1.a(c5x);
		}
		else
		{
			a_ = l9.a;
		}
		return aw1.a(A_1, A_2, A_3, a_);
	}

	// Token: 0x06005483 RID: 21635 RVA: 0x002557B8 File Offset: 0x002539B8
	public static bool e(ak1 A_0)
	{
		return A_0 != null && !A_0.Formation.c(4L);
	}

	// Token: 0x06005484 RID: 21636 RVA: 0x002557D4 File Offset: 0x002539D4
	public static bool a(ak1 A_0, bool A_1 = false, b0b A_2 = null, l9 A_3 = l9.a)
	{
		if (A_3 == l9.b)
		{
			return !A_0.Formation.c(64L) || A_0.Formation.c(262308L) || (!A_1 && A_0.f(A_2) != 0L);
		}
		if (A_3 == l9.c)
		{
			return !A_0.Formation.c(524352L) || A_0.Formation.c(262308L) || (!A_1 && A_0.f(A_2) != 0L);
		}
		return (A_0.Formation.b(2L) && !A_0.Formation.b(128L)) || A_0.Formation.c(4L) || (!A_1 && A_0.f(A_2) != 0L);
	}

	// Token: 0x06005485 RID: 21637 RVA: 0x002558C0 File Offset: 0x00253AC0
	public static bool a(bt4 A_0, aud A_1, l9 A_2 = l9.a)
	{
		bool result = false;
		Vector3 a_;
		HorizontalDirection horizontalDirection;
		A_0.a(A_1.Zone, out A_1, out a_, out horizontalDirection);
		ak1 ak = A_1.a(a_.a());
		if (ak != null && !aw1.a(ak, false, null, A_2))
		{
			result = true;
		}
		return result;
	}

	// Token: 0x06005486 RID: 21638 RVA: 0x00255908 File Offset: 0x00253B08
	public static bool a(b0b A_0, bt4 A_1, aud A_2)
	{
		c5x c5x = A_0 as c5x;
		l9 a_;
		if (c5x != null)
		{
			a_ = aw1.a(c5x);
		}
		else
		{
			a_ = l9.a;
		}
		return aw1.a(A_1, A_2, a_);
	}

	// Token: 0x06005487 RID: 21639 RVA: 0x00255938 File Offset: 0x00253B38
	public static bool d(ak1 A_0)
	{
		return A_0.Formation.c(64L) && !A_0.Formation.c(128L);
	}

	// Token: 0x06005488 RID: 21640 RVA: 0x00255964 File Offset: 0x00253B64
	public static List<ak1> b(c5x A_0, bool A_1 = true)
	{
		List<ak1> list = new List<ak1>();
		if (A_0.Area != null)
		{
			Point point;
			Point point2;
			A_0.a(out point, out point2);
			for (int i = point.X - 1; i <= point2.X + 1; i++)
			{
				for (int j = point.Y - 1; j <= point2.Y + 1; j++)
				{
					if (!A_1 || (i != point.X - 1 && i != point2.X + 1) || (j != point.Y - 1 && j != point2.Y + 1))
					{
						ak1 ak = A_0.Area.b(i, j);
						if (ak != null && !aw1.a(A_0, ak, false, null))
						{
							list.Add(ak);
						}
					}
				}
			}
		}
		return list;
	}

	// Token: 0x06005489 RID: 21641 RVA: 0x00255A3C File Offset: 0x00253C3C
	public static List<ak1> a(c5x A_0, HashSet<ak1> A_1 = null)
	{
		if (A_1 == null)
		{
			A_1 = new HashSet<ak1>();
		}
		List<ak1> list = new List<ak1>();
		List<ak1> list2 = new List<ak1>();
		if (A_0.Area != null)
		{
			Point point;
			Point point2;
			A_0.a(out point, out point2);
			for (int i = point.X - 1; i <= point2.X + 1; i++)
			{
				for (int j = point.Y - 1; j <= point2.Y + 1; j++)
				{
					if ((i != point.X - 1 && i != point2.X + 1) || (j != point.Y - 1 && j != point2.Y + 1))
					{
						ak1 ak = A_0.Area.b(i, j);
						if (ak != null)
						{
							if (!aw1.a(A_0, ak, false, null))
							{
								list.Add(ak);
							}
							else if (!aw1.a(A_0, ak, true, null))
							{
								list2.Add(ak);
							}
						}
					}
				}
			}
		}
		if (list.Count == 0 && list2.Count > 0)
		{
			foreach (ak1 ak2 in list2)
			{
				if (!A_1.Contains(ak2))
				{
					A_1.Add(ak2);
					c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak2.c.Values, new Func<b0b, bool>(aw1.a.a.a))) as c5x;
					if (c5x != null)
					{
						list.AddRange(aw1.a(c5x, A_1));
					}
				}
			}
		}
		return list;
	}

	// Token: 0x0600548A RID: 21642 RVA: 0x00255C0C File Offset: 0x00253E0C
	public static List<ak1> a(c5x A_0, bool A_1 = true)
	{
		List<ak1> list = new List<ak1>();
		if (A_0.Area != null)
		{
			Point point;
			Point point2;
			A_0.a(out point, out point2);
			for (int i = point.X - 1; i <= point2.X + 1; i++)
			{
				for (int j = point.Y - 1; j <= point2.Y + 1; j++)
				{
					if (!A_1 || (i != point.X - 1 && i != point2.X + 1) || (j != point.Y - 1 && j != point2.Y + 1))
					{
						ak1 ak = A_0.Area.b(i, j);
						if (ak != null && !A_0.l.Contains(ak))
						{
							list.Add(ak);
						}
					}
				}
			}
		}
		return list;
	}

	// Token: 0x0600548B RID: 21643 RVA: 0x00255CEC File Offset: 0x00253EEC
	public static List<ak1> c(ak1 A_0)
	{
		List<ak1> list = new List<ak1>();
		if (A_0.Area != null)
		{
			for (int i = A_0.Location.X - 1; i <= A_0.Location.X + 1; i++)
			{
				for (int j = A_0.Location.Y - 1; j <= A_0.Location.Y + 1; j++)
				{
					ak1 ak = A_0.Area.b(i, j);
					if (ak != null && ak != A_0)
					{
						list.Add(ak);
					}
				}
			}
		}
		return list;
	}

	// Token: 0x0600548C RID: 21644 RVA: 0x00255D7C File Offset: 0x00253F7C
	public static bool a(c5x A_0, Vector2 A_1)
	{
		return A_1.X >= A_0.Location.X && A_1.Y >= A_0.Location.Y && A_1.X < A_0.Location.X + A_0.Size.X && A_1.Y < A_0.Location.Y + A_0.Size.Y;
	}

	// Token: 0x0600548D RID: 21645 RVA: 0x00255DF8 File Offset: 0x00253FF8
	public static HorizontalDirection b(HorizontalDirection A_0)
	{
		int num = (int)(A_0 + 4);
		if (num > 7)
		{
			num -= 8;
		}
		return (HorizontalDirection)num;
	}

	// Token: 0x0600548E RID: 21646 RVA: 0x00255E18 File Offset: 0x00254018
	public static ak1 a(ak1 A_0, HorizontalDirection A_1)
	{
		if (A_0 != null && A_0.Area != null)
		{
			Vector2 a_ = aw1.a(A_1);
			ak1 ak = A_0.Area.a(d05.a(A_0.Location, a_.a(), false));
			if (ak != null)
			{
				return ak;
			}
		}
		return null;
	}

	// Token: 0x0600548F RID: 21647 RVA: 0x00255E64 File Offset: 0x00254064
	public static long a(ak1 A_0, bm6 A_1)
	{
		czh.a(A_0, "tile");
		HashSet<Guid> hashSet = new HashSet<Guid>();
		if (A_1 != null && A_1.a8() != null)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				foreach (d4n d4n in service.ahl())
				{
					if (d4n.b.a8() != A_1.a8() && !A_1.a(d4n.b))
					{
						hashSet.Add(d4n.b.a8().qe());
					}
				}
			}
		}
		return A_0.a(hashSet);
	}

	// Token: 0x06005490 RID: 21648 RVA: 0x00255F2C File Offset: 0x0025412C
	public static bool b(ak1 A_0)
	{
		return !A_0.Formation.c(2L) || A_0.Formation.c(1048704L);
	}

	// Token: 0x06005491 RID: 21649 RVA: 0x00255F54 File Offset: 0x00254154
	public static bool a(ak1 A_0)
	{
		if (A_0.Formation.c(524352L))
		{
			return true;
		}
		List<ya> list = A_0.a(typeof(sd));
		if (list != null && list.Count > 0)
		{
			return true;
		}
		using (IEnumerator<b0b> enumerator = A_0.c.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.GetAspect<awy>() != null)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06005492 RID: 21650 RVA: 0x00255FF8 File Offset: 0x002541F8
	public static amc a(Guid A_0, aud A_1 = null)
	{
		amc amc = null;
		if (A_1 != null)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				HashSet<Guid> hashSet = new HashSet<Guid>();
				foreach (d4n d4n in service.ahl())
				{
					if (d4n.b != null)
					{
						if (hashSet.Contains(d4n.b.aa().Uid))
						{
							d4n.b.aa().Uid = Guid.NewGuid();
						}
						else if (amc == null && d4n.b.aa().Uid == A_0 && (A_1 == null || (d4n.b.a8() != null && d4n.b.a8().Area == A_1)))
						{
							amc = d4n.b;
						}
						hashSet.Add(d4n.b.aa().Uid);
					}
				}
			}
		}
		return amc;
	}

	// Token: 0x06005493 RID: 21651 RVA: 0x0025611C File Offset: 0x0025431C
	private static bool h(Point A_0)
	{
		return A_0.Y <= -Math.Abs(A_0.X);
	}

	// Token: 0x06005494 RID: 21652 RVA: 0x00256138 File Offset: 0x00254338
	private static bool g(Point A_0)
	{
		return A_0.Y >= Math.Abs(A_0.X);
	}

	// Token: 0x06005495 RID: 21653 RVA: 0x00256150 File Offset: 0x00254350
	private static bool f(Point A_0)
	{
		return A_0.X <= -Math.Abs(A_0.Y);
	}

	// Token: 0x06005496 RID: 21654 RVA: 0x0025616C File Offset: 0x0025436C
	private static bool e(Point A_0)
	{
		return A_0.X >= Math.Abs(A_0.Y);
	}

	// Token: 0x06005497 RID: 21655 RVA: 0x00256184 File Offset: 0x00254384
	private static bool d(Point A_0)
	{
		return A_0.X <= 0 && A_0.Y <= 0;
	}

	// Token: 0x06005498 RID: 21656 RVA: 0x002561A0 File Offset: 0x002543A0
	private static bool c(Point A_0)
	{
		return A_0.X >= 0 && A_0.Y <= 0;
	}

	// Token: 0x06005499 RID: 21657 RVA: 0x002561BC File Offset: 0x002543BC
	private static bool b(Point A_0)
	{
		return A_0.X <= 0 && A_0.Y >= 0;
	}

	// Token: 0x0600549A RID: 21658 RVA: 0x002561D8 File Offset: 0x002543D8
	private static bool a(Point A_0)
	{
		return A_0.X >= 0 && A_0.Y >= 0;
	}

	// Token: 0x0600549B RID: 21659 RVA: 0x002561F8 File Offset: 0x002543F8
	private static Vector2 a(HorizontalDirection A_0)
	{
		switch (A_0)
		{
		case HorizontalDirection.North:
			return new Vector2(0f, -1f);
		case HorizontalDirection.Northeast:
			return new Vector2(1f, -1f);
		case HorizontalDirection.East:
			return new Vector2(1f, 0f);
		case HorizontalDirection.Southeast:
			return new Vector2(1f, 1f);
		case HorizontalDirection.South:
			return new Vector2(0f, 1f);
		case HorizontalDirection.Southwest:
			return new Vector2(-1f, 1f);
		case HorizontalDirection.West:
			return new Vector2(-1f, 0f);
		}
		return new Vector2(-1f, -1f);
	}

	// Token: 0x0400227D RID: 8829
	public static readonly Dictionary<HorizontalDirection, acn> a = new Dictionary<HorizontalDirection, acn>();

	// Token: 0x02001008 RID: 4104
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x0600549E RID: 21662 RVA: 0x002562C4 File Offset: 0x002544C4
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x0400227E RID: 8830
		public static readonly aw1.a a = new aw1.a();

		// Token: 0x0400227F RID: 8831
		public static Func<b0b, bool> b;
	}
}
