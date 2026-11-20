using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Data;

// Token: 0x02000271 RID: 625
public static class nf
{
	// Token: 0x0600125B RID: 4699 RVA: 0x0004C050 File Offset: 0x0004A250
	static nf()
	{
		for (int i = -1; i <= 1; i++)
		{
			for (int j = -1; j <= 1; j++)
			{
				if (i == -1 || j == -1 || i == 1 || j == 1)
				{
					nf.b.Add(new Point(i, j));
				}
			}
		}
		for (int k = -2; k <= 2; k++)
		{
			for (int l = -2; l <= 2; l++)
			{
				if (k == -2 || l == -2 || k == 2 || l == 2)
				{
					nf.b.Add(new Point(k, l));
				}
			}
		}
	}

	// Token: 0x0600125C RID: 4700 RVA: 0x0004C104 File Offset: 0x0004A304
	public static Collection<b76> a(c1a A_0)
	{
		czh.a(A_0, "zone");
		Collection<b76> collection = new Collection<b76>();
		foreach (aud aud in A_0.Areas)
		{
			foreach (b0b b0b in aud.Entities)
			{
				foreach (ejt ejt in b0b.RaysEmitters)
				{
					bsf bsf = ejt as bsf;
					if (bsf != null)
					{
						if (bsf.Definition != null && bsf.Definition.Layer != b0b.Layer)
						{
							collection.Add(new etl(bsf));
						}
					}
					else
					{
						c6g c6g = ejt as c6g;
						if (c6g != null && c6g.Definition != null && c6g.Definition.Layer != b0b.Layer)
						{
							collection.Add(new bpt(c6g));
						}
					}
				}
			}
			foreach (e4b e4b in aud.SoftLightAreas)
			{
				if (e4b.b() != null && e4b.b().Layer != e4b.m4())
				{
					collection.Add(new ezw(e4b));
				}
			}
		}
		return collection;
	}

	// Token: 0x0600125D RID: 4701 RVA: 0x0004C324 File Offset: 0x0004A524
	public static void a(c1a A_0, string A_1, string A_2, Dictionary<int, qi> A_3, bool A_4, bool A_5, Dictionary<int, string> A_6 = null)
	{
		czh.a(A_0, "zone");
		czh.a(A_3, "settings");
		czh.a(A_2, "baseName");
		string text = Path.Combine(A_1, A_2);
		bool flag = Enumerable.Any<qi>(A_3.Values, new Func<qi, bool>(nf.a.a.a));
		if (A_5)
		{
			l8.b(A_0).b(text + ".uzdm");
		}
		for (int i = 0; i < 10; i++)
		{
			string text2 = null;
			if (A_6 != null && A_6.TryGetValue(i, out text2))
			{
				text2 = "_" + text2;
			}
			string a_ = string.Concat(new string[]
			{
				text,
				"_L",
				i.ToString(),
				text2,
				".uzl"
			});
			qi qi = qi.c;
			if (A_3.ContainsKey(i))
			{
				qi = A_3[i];
			}
			if (qi != qi.a && (flag || qi == qi.b))
			{
				doq doq = doq.a(A_0, i, A_4);
				if (qi == qi.b && (!doq.g() || !A_4))
				{
					doq.b(a_);
				}
			}
		}
		if (flag)
		{
			A_0.p(text + ".uz");
		}
	}

	// Token: 0x0600125E RID: 4702 RVA: 0x0004C480 File Offset: 0x0004A680
	public static void a(c1a A_0, doq A_1, int A_2, tm A_3)
	{
		foreach (ah7 a_ in A_1.b())
		{
			nf.a(a_, A_2);
			A_0.a(a_);
		}
		foreach (ego a_2 in A_1.f())
		{
			nf.a(a_2, A_2);
			A_0.b(a_2);
		}
		foreach (csd a_3 in A_1.d())
		{
			nf.a(a_3, A_2);
			A_0.a(a_3);
		}
		foreach (cpe cpe in A_1.e())
		{
			aud aud = A_0.d(cpe.AreaId);
			if (aud != null)
			{
				nf.a(aud, cpe, A_2, Point.Zero, A_3);
			}
		}
		foreach (ah7 ah in A_1.b())
		{
			if (A_0.Initialized)
			{
				ah.bc(true);
			}
		}
		if (A_1.a() != null)
		{
			foreach (Property property in A_1.a().Properties)
			{
				A_0.CustomProperties[property.Name] = property.Value;
			}
		}
	}

	// Token: 0x0600125F RID: 4703 RVA: 0x0004C6B0 File Offset: 0x0004A8B0
	public static void a(aud A_0, cpe A_1, int A_2, Point A_3, tm A_4 = null)
	{
		foreach (e4b e4b in A_1.SoftLightAreas)
		{
			nf.a(e4b, A_2);
			if (A_3 != Point.Zero)
			{
				e4b.b(d05.a(e4b.d(), A_3, false));
			}
			A_0.SoftLightAreas.b(e4b);
		}
		foreach (cno cno in A_1.Divinations)
		{
			nf.a(cno, A_2);
			if (A_3 != Point.Zero)
			{
				cno.b(d05.a(cno.d(), A_3, false));
			}
			A_0.Divinations.b(cno);
		}
		foreach (b0b b0b in A_1.Entities)
		{
			nf.a(b0b, A_2);
			Vector3 a_;
			if (A_3 != Point.Zero)
			{
				a_ = new Vector3(b0b.Location.X + (float)A_3.X, b0b.Location.Y + (float)A_3.Y, b0b.Location.Z);
			}
			else
			{
				a_ = b0b.Location;
			}
			b0b.Location = a_;
			if (A_4 != null && A_4.avd(b0b) && !nf.a(b0b, A_0, A_4))
			{
				ak1 ak = A_0.a(b0b.aj().a());
				if (ak != null)
				{
					bool flag = false;
					foreach (Point a_2 in nf.b)
					{
						ak1 ak2 = A_0.a(d05.a(ak.Location, a_2, false));
						if (ak2 != null)
						{
							b0b.Location = ak2.Location.a();
							if (nf.a(b0b, A_0, A_4))
							{
								flag = true;
								break;
							}
						}
					}
					if (!flag)
					{
						b0b.Location = a_;
					}
				}
			}
			A_0.a(b0b);
			if (A_0.Initialized)
			{
				b0b.bc(true);
			}
		}
		foreach (ya ya in A_1.Triggers)
		{
			nf.a(ya, A_2);
			if (A_3 != Point.Zero)
			{
				ya.Location = d05.a(ya.Location, A_3, false);
			}
			l2 l = ya as l2;
			if (l != null)
			{
				l.jl(A_0);
			}
			A_0.b(ya);
		}
	}

	// Token: 0x06001260 RID: 4704 RVA: 0x0004CA28 File Offset: 0x0004AC28
	private static bool a(b0b A_0, aud A_1, tm A_2)
	{
		Point point;
		Point point2;
		A_0.a(A_1.Playfield, out point, out point2);
		bool flag = true;
		for (int i = point.X; i <= point2.X; i++)
		{
			for (int j = point.Y; j <= point2.Y; j++)
			{
				ak1 ak = A_1.b(i, j);
				if (ak != null && !A_2.ave(A_0, ak))
				{
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				break;
			}
		}
		return flag;
	}

	// Token: 0x06001261 RID: 4705 RVA: 0x0004CAAC File Offset: 0x0004ACAC
	private static void a(bvq A_0, int A_1)
	{
		if (A_1 > 0)
		{
			A_0.m5(A_1);
		}
	}

	// Token: 0x04000A2D RID: 2605
	public const int a = 10;

	// Token: 0x04000A2E RID: 2606
	private static List<Point> b = new List<Point>();

	// Token: 0x02000272 RID: 626
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06001264 RID: 4708 RVA: 0x0004CAD0 File Offset: 0x0004ACD0
		internal bool a(qi A_0)
		{
			return A_0 == qi.a;
		}

		// Token: 0x04000A2F RID: 2607
		public static readonly nf.a a = new nf.a();

		// Token: 0x04000A30 RID: 2608
		public static Func<qi, bool> b;
	}
}
