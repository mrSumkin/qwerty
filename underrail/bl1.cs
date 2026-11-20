using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Data;
using Ouroboros.Core.Logging;
using Ouroboros.Playfield.References;

// Token: 0x02001009 RID: 4105
public sealed class bl1 : b4b, z6, ewf, b49
{
	// Token: 0x0600549F RID: 21663 RVA: 0x002562CC File Offset: 0x002544CC
	public Guid qe()
	{
		return bl1.b;
	}

	// Token: 0x060054A0 RID: 21664 RVA: 0x002562D4 File Offset: 0x002544D4
	public string y8()
	{
		return "TimelapsePlayfieldManager";
	}

	// Token: 0x060054A1 RID: 21665 RVA: 0x002562DC File Offset: 0x002544DC
	public e3h yn()
	{
		return this.d;
	}

	// Token: 0x060054A2 RID: 21666 RVA: 0x002562E4 File Offset: 0x002544E4
	public bl1()
	{
		this.f();
	}

	// Token: 0x060054A3 RID: 21667 RVA: 0x002562F4 File Offset: 0x002544F4
	public void d1(e6d A_0)
	{
		if (this.e != null && this.d != null && this.d.Zones.Count > 0)
		{
			this.e.aho(A_0);
		}
	}

	// Token: 0x060054A4 RID: 21668 RVA: 0x00256334 File Offset: 0x00254534
	public c1a yo(bfc A_0, bool A_1)
	{
		czh.a(A_0, "locale");
		c1a c1a = null;
		try
		{
			doq a_ = null;
			c1a = this.a(A_0.Id, out a_);
			if (A_1)
			{
				this.a(c1a, a_);
			}
			c1a.bc(true);
			bl1.b(c1a);
			bpo.GetServiceOrThrow<li>().kb(c1a);
			bpo.GetServiceOrThrow<cne>().uz(false);
		}
		catch (Exception a_2)
		{
			dux.a(a_2, LogSeverity.CriticalError, rz.g, new object[]
			{
				A_0.ToString()
			});
		}
		return c1a;
	}

	// Token: 0x060054A5 RID: 21669 RVA: 0x002563C8 File Offset: 0x002545C8
	public void yp(c2w A_0, c1a A_1, bool A_2)
	{
		string path = d5x.m();
		A_1.k();
		bool flag = A_1.bd(true);
		l8 l = l8.a(A_1);
		doq doq = doq.a(A_1, 1, false);
		az0 az = bl1.c(A_1);
		if (bmg.a)
		{
			string a_ = Path.Combine(path, A_0.b()) + "_L1.uzl";
			string a_2 = Path.Combine(path, A_0.b()) + ".uzdm";
			string a_3 = Path.Combine(path, A_0.b()) + ".ap";
			doq.b(a_);
			l.b(a_2);
			az.b(a_3);
		}
		else
		{
			string name = (Path.Combine(d5x.x, A_0.b()) + "_L1.uzl").ToLowerInvariant();
			string name2 = (Path.Combine(d5x.x, A_0.b()) + ".uzdm").ToLowerInvariant();
			string name3 = (Path.Combine(d5x.x, A_0.b()) + ".ap").ToLowerInvariant();
			bmg.b().PutItemCompressed<doq>(name, doq, true);
			bmg.b().PutItemCompressed<l8>(name2, l, true);
			bmg.b().PutItemCompressed<az0>(name3, az, true);
		}
		if (!A_2)
		{
			A_1.a(doq, 1, null);
			if (flag)
			{
				A_1.bc(true);
			}
		}
	}

	// Token: 0x060054A6 RID: 21670 RVA: 0x00256528 File Offset: 0x00254728
	public void yq(c1a A_0)
	{
		A_0.n();
		this.d.SightProcessor.a();
		this.d.LightProcessor.a();
		this.d.PathProcessor.a();
		A_0.bd(true);
		this.d.a(A_0.y8());
	}

	// Token: 0x060054A7 RID: 21671 RVA: 0x00256588 File Offset: 0x00254788
	public void g()
	{
	}

	// Token: 0x060054A8 RID: 21672 RVA: 0x0025658C File Offset: 0x0025478C
	public void yr(c1a A_0, TypedObjectReference<bag> A_1)
	{
		if (A_0 != null && A_0.Areas != null)
		{
			foreach (aud aud in A_0.Areas)
			{
				HashSet<Point> hashSet = new HashSet<Point>();
				foreach (cno cno in aud.Divinations)
				{
					if (cno.y8() != null && cno.y8().StartsWith("shroud", StringComparison.OrdinalIgnoreCase))
					{
						this.a(hashSet, new Rectangle(cno.d().X, cno.d().Y, cno.e().c, cno.e().d));
					}
				}
				Rectangle? rectangle = null;
				Point zero = Point.Zero;
				for (;;)
				{
					Rectangle? rectangle2;
					rectangle = (rectangle2 = this.b(aud, hashSet, ref zero));
					if (rectangle2 == null)
					{
						break;
					}
					this.a(A_1, aud, rectangle.Value);
					this.a(hashSet, rectangle.Value);
				}
			}
		}
	}

	// Token: 0x060054A9 RID: 21673 RVA: 0x002566E0 File Offset: 0x002548E0
	public bool ys(b0b A_0)
	{
		ln aspect = A_0.GetAspect<ln>();
		if (aspect != null)
		{
			if (!string.IsNullOrEmpty(aspect.d()))
			{
				if (aspect.b())
				{
					if (dk2.b(aspect.d()))
					{
						return false;
					}
				}
				else if (!dk2.b(aspect.d()))
				{
					return false;
				}
			}
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				if (aspect.a() != null && serviceOrThrow.aqu().ae() < aspect.a().Value)
				{
					return false;
				}
				if (aspect.g() != null && serviceOrThrow.aqu().ae() > aspect.g().Value)
				{
					return false;
				}
				if (aspect.f() != null && !aspect.f().jh(A_0))
				{
					return false;
				}
				if (aspect.e() < 1.0 && new Random(serviceOrThrow.aqu().l() + aspect.a8().qe().GetHashCode()).NextDouble() > aspect.e())
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x060054AA RID: 21674 RVA: 0x00256820 File Offset: 0x00254A20
	public bool yt(ya A_0, cpe A_1)
	{
		d8a d8a = A_0 as d8a;
		if (d8a != null)
		{
			bl1.a a = new bl1.a();
			a.a = d8a.ago();
			if (a.a != null)
			{
				b0b b0b = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(A_1.Entities, new Func<b0b, bool>(a.a)));
				if (b0b != null)
				{
					return this.ys(b0b);
				}
			}
		}
		return true;
	}

	// Token: 0x060054AB RID: 21675 RVA: 0x00256888 File Offset: 0x00254A88
	public bool yu(ya A_0, aud A_1)
	{
		d8a d8a = A_0 as d8a;
		if (d8a != null)
		{
			bl1.b b = new bl1.b();
			b.a = d8a.ago();
			if (b.a != null)
			{
				b0b b0b = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(A_1.Entities, new Func<b0b, bool>(b.a)));
				if (b0b != null)
				{
					return this.ys(b0b);
				}
			}
		}
		return true;
	}

	// Token: 0x060054AC RID: 21676 RVA: 0x002568F0 File Offset: 0x00254AF0
	public bool yv(object A_0)
	{
		ak1 ak = A_0 as ak1;
		if (ak != null)
		{
			List<ya> list = ak.a(typeof(a1w));
			if (list != null)
			{
				foreach (ya ya in list)
				{
					a1w a1w = ya as a1w;
					if (a1w != null && (a1w.g() == null || a1w.g().jh(a1w)) && a1w.b().Contains(asp.a))
					{
						return true;
					}
				}
				return false;
			}
		}
		return false;
	}

	// Token: 0x060054AD RID: 21677 RVA: 0x002569AC File Offset: 0x00254BAC
	private void f()
	{
		this.c();
		this.e();
	}

	// Token: 0x060054AE RID: 21678 RVA: 0x002569BC File Offset: 0x00254BBC
	private void e()
	{
		this.e = new crp();
		bpo.RegisterService<d02>(this.e);
		bpo.RegisterService<io>(this.e);
	}

	// Token: 0x060054AF RID: 21679 RVA: 0x002569E0 File Offset: 0x00254BE0
	private void d()
	{
		bpo.UnregisterService<d02>();
		bpo.UnregisterService<io>();
		this.e = null;
	}

	// Token: 0x060054B0 RID: 21680 RVA: 0x002569F4 File Offset: 0x00254BF4
	private void c()
	{
		d6j serviceOrThrow = bpo.GetServiceOrThrow<d6j>();
		this.d = new e3h(bl1.a, bl1.b(), bl1.a());
		this.d.CollisionHandler = new r7();
		serviceOrThrow.dz(this.d);
	}

	// Token: 0x060054B1 RID: 21681 RVA: 0x00256A30 File Offset: 0x00254C30
	private static d4p b()
	{
		return new d4p(true);
	}

	// Token: 0x060054B2 RID: 21682 RVA: 0x00256A38 File Offset: 0x00254C38
	private static etb a()
	{
		etb etb = new etb();
		etb.a().a(c3.d);
		return etb;
	}

	// Token: 0x060054B3 RID: 21683 RVA: 0x00256A4C File Offset: 0x00254C4C
	private static az0 c(c1a A_0)
	{
		az0 az = new az0();
		az.c = A_0.ElapsedZoneTime;
		foreach (e36 e in A_0.ActionManager.g8())
		{
			if (bl1.a(e.a))
			{
				az.b.Add(e);
			}
		}
		return az;
	}

	// Token: 0x060054B4 RID: 21684 RVA: 0x00256AD4 File Offset: 0x00254CD4
	private static bool a(auv A_0)
	{
		return !(A_0 is bx5);
	}

	// Token: 0x060054B5 RID: 21685 RVA: 0x00256AE4 File Offset: 0x00254CE4
	private void b(c1a A_0, doq A_1)
	{
		foreach (cpe cpe in A_1.e())
		{
			List<b0b> list = new List<b0b>();
			foreach (b0b b0b in cpe.Entities)
			{
				abh aspect = b0b.GetAspect<abh>();
				if (aspect != null && aspect.b > 0)
				{
					c5x c5x = new c5x();
					c5x.Location = b0b.Location;
					c5x.Size = b0b.Size;
					c5x.Layer = aju.x;
					c5x.SetAspect<c4k>(new c4k(c5x)
					{
						a = this.a(b0b)
					});
					aspect.a = new EntityAspectReference<c4k, c4k>(bl1.a, A_0.qe(), cpe.AreaId, c5x.qe());
					list.Add(c5x);
				}
			}
			foreach (b0b item in list)
			{
				cpe.Entities.Add(item);
			}
		}
	}

	// Token: 0x060054B6 RID: 21686 RVA: 0x00256C8C File Offset: 0x00254E8C
	private void a(c1a A_0, doq A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		foreach (cpe cpe in A_1.e())
		{
			foreach (b0b b0b in cpe.Entities)
			{
				c4k aspect = b0b.GetAspect<c4k>();
				if (aspect != null && aspect.a != null && aspect.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().p() >= aspect.b.Value)
				{
					bool flag = false;
					foreach (ak1 a_ in b0b.l)
					{
						if (aw1.a(aspect.a, a_, false, null))
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						aspect.b = null;
						b0b b0b2 = this.a(aspect.a);
						b0b2.Location = b0b.Location;
						b0b2.Layer = aju.x;
						ery aspect2 = b0b2.GetAspect<ery>();
						if (aspect2 != null)
						{
							aspect2.e();
						}
						abh aspect3 = b0b2.GetAspect<abh>();
						if (aspect3 != null)
						{
							aspect3.a = new EntityAspectReference<c4k, c4k>(bl1.a, A_0.qe(), cpe.AreaId, b0b.qe());
						}
						b0b.Area.a(b0b2);
					}
				}
				amc aspect4 = b0b.GetAspect<amc>();
				if (b0b.GetAspect<dfc>() != null && aspect4 != null && bp5.a(aspect4.aa().Id) && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(bp5.b(aspect4.aa().Id), new bool?(false)).Value)
				{
					b0b.w();
					b0b.an();
				}
				else
				{
					bhk aspect5 = b0b.GetAspect<bhk>();
					if (aspect5 != null && aspect5.b() != null && aspect5.b().jh(b0b))
					{
						if (!aspect5.a())
						{
							c5x c5x = new c5x();
							c5x.Location = b0b.Location;
							c5x.Size = b0b.Size;
							c5x.Layer = aju.x;
							c5x.SetAspect<bth>(new bth(c5x)
							{
								b = aspect5.b(),
								a = this.a(b0b)
							});
							b0b.Area.a(c5x);
						}
						b0b.w();
						b0b.an();
					}
					else
					{
						bth aspect6 = b0b.GetAspect<bth>();
						if (aspect6 != null && aspect6.a != null)
						{
							bool flag2 = false;
							amc aspect7 = aspect6.a.GetAspect<amc>();
							if (aspect6.a.GetAspect<dfc>() != null && aspect7 != null && bp5.a(aspect7.aa().Id) && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(bp5.b(aspect7.aa().Id), new bool?(false)).Value)
							{
								b0b.w();
								b0b.an();
							}
							else if (!flag2 && (aspect6.b == null || !aspect6.b.jh(b0b)))
							{
								aspect6.a(A_0, new Guid?(cpe.AreaId));
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060054B7 RID: 21687 RVA: 0x002570D0 File Offset: 0x002552D0
	private b0b a(b0b A_0)
	{
		Stream stream = eoq.SerializeToBinary<b0b>(A_0, dds.a(), null, eh9.c, true, true);
		stream.Position = 0L;
		b0b b0b = eoq.DeserializeFromBinary<b0b>(stream, dds.a(), true, true);
		stream.Dispose();
		b0b.aq();
		return b0b;
	}

	// Token: 0x060054B8 RID: 21688 RVA: 0x00257114 File Offset: 0x00255314
	private static void b(c1a A_0)
	{
		foreach (aud a_ in A_0.Areas)
		{
			bl1.a(a_);
		}
	}

	// Token: 0x060054B9 RID: 21689 RVA: 0x0025716C File Offset: 0x0025536C
	private static void a(aud A_0)
	{
		List<ew1> list = new List<ew1>();
		foreach (b0b b0b in A_0.Entities)
		{
			c5x c5x = b0b as c5x;
			if (c5x != null && (c5x.g & e2b.g) == e2b.g)
			{
				ew1 aspect = c5x.GetAspect<ew1>();
				if (aspect != null)
				{
					list.Add(aspect);
				}
			}
		}
		foreach (ew1 ew in list)
		{
			ew.d();
		}
	}

	// Token: 0x060054BA RID: 21690 RVA: 0x00257238 File Offset: 0x00255438
	private static void a(c1a A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		dst addon = new dst(A_0, serviceOrThrow.aqu().v().a().d);
		A_0.AttachAddon<ax1>(addon);
		A_0.AttachAddon<d60>(new bwy());
		A_0.AttachAddon<d5s>(new dfa());
	}

	// Token: 0x060054BB RID: 21691 RVA: 0x00257284 File Offset: 0x00255484
	private void a(HashSet<Point> A_0, Rectangle A_1)
	{
		for (int i = A_1.Left; i < A_1.Right; i++)
		{
			for (int j = A_1.Top; j < A_1.Bottom; j++)
			{
				A_0.Add(new Point(i, j));
			}
		}
	}

	// Token: 0x060054BC RID: 21692 RVA: 0x002572D8 File Offset: 0x002554D8
	private Rectangle? b(aud A_0, HashSet<Point> A_1, ref Point A_2)
	{
		Point? point = this.a(A_0, A_1, ref A_2);
		if (point != null)
		{
			int num = A_0.Size.c - 1;
			int num2 = A_0.Size.d - 1;
			string text = null;
			bool flag = false;
			for (int i = point.Value.X; i <= num; i++)
			{
				int j = point.Value.Y;
				while (j <= num2)
				{
					if (A_1.Contains(new Point(i, j)))
					{
						if (text != null)
						{
							if (text == "x")
							{
								num2 = j - 1;
								flag = true;
								break;
							}
							num = i - 1;
							flag = true;
							break;
						}
						else
						{
							int num3 = i - point.Value.X;
							int num4 = j - point.Value.Y;
							if (num3 > num4)
							{
								text = "x";
								num = i - 1;
								break;
							}
							text = "y";
							num2 = j - 1;
							i--;
							break;
						}
					}
					else
					{
						j++;
					}
				}
				if (flag)
				{
					break;
				}
			}
			return new Rectangle?(new Rectangle(point.Value.X, point.Value.Y, num - point.Value.X + 1, num2 - point.Value.Y + 1));
		}
		return null;
	}

	// Token: 0x060054BD RID: 21693 RVA: 0x00257444 File Offset: 0x00255644
	private Point? a(aud A_0, HashSet<Point> A_1, ref Point A_2)
	{
		int num = A_2.Y;
		for (int i = A_2.X; i < A_0.Size.c; i++)
		{
			for (int j = num; j < A_0.Size.d; j++)
			{
				Point point = new Point(i, j);
				if (!A_1.Contains(point))
				{
					A_2 = point;
					return new Point?(point);
				}
			}
			num = 0;
		}
		return null;
	}

	// Token: 0x060054BE RID: 21694 RVA: 0x002574C0 File Offset: 0x002556C0
	private void a(TypedObjectReference<bag> A_0, aud A_1, Rectangle A_2)
	{
		string a_ = "temp" + Guid.NewGuid().ToString();
		cno cno = A_1.Divinations.c(a_);
		cno.b(new Point(A_2.X, A_2.Y));
		cno.a(new esj(A_2.Width, A_2.Height));
		cno.b(A_0);
		A_1.Divinations.b(a_);
	}

	// Token: 0x060054BF RID: 21695 RVA: 0x00257538 File Offset: 0x00255738
	private c1a a(string A_0, out doq A_1)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		string path = d5x.m();
		c1a c1a = c1a.a(Path.Combine(d5x.q(), A_0) + ".uz");
		this.d.a(c1a, false);
		A_1 = null;
		if (bmg.a)
		{
			string a_ = Path.Combine(path, A_0) + "_L1.uzl";
			A_1 = doq.a(a_);
		}
		else
		{
			string name = (Path.Combine(d5x.x, A_0) + "_L1.uzl").ToLowerInvariant();
			A_1 = bmg.b().GetItemCompressed<doq>(name, true);
		}
		if (!A_1.a().GetPrimitivePropertyValue<bool>("Layered|1|RespawningPrepared", new bool?(false)).Value)
		{
			this.b(c1a, A_1);
			A_1.a()["Layered|1|RespawningPrepared"] = true;
		}
		c1a.a(A_1, 1, null);
		l8 l = null;
		if (bmg.a)
		{
			string text = Path.Combine(path, A_0) + ".uzdm";
			if (File.Exists(text))
			{
				l = l8.a(text);
			}
		}
		else
		{
			string name2 = (Path.Combine(d5x.x, A_0) + ".uzdm").ToLowerInvariant();
			l = bmg.b().GetItemCompressed<l8>(name2, false);
		}
		if (l != null)
		{
			l.c(c1a);
		}
		az0 az = null;
		if (bmg.a)
		{
			string text2 = Path.Combine(path, A_0) + ".ap";
			if (File.Exists(text2))
			{
				az = az0.a(text2);
			}
		}
		else
		{
			string name3 = (Path.Combine(d5x.x, A_0) + ".ap").ToLowerInvariant();
			az = bmg.b().GetItemCompressed<az0>(name3, false);
		}
		if (az != null)
		{
			c1a.ActionManager.hf(az);
			c1a.ElapsedZoneTime = az.c;
		}
		bl1.a(c1a);
		stopwatch.Stop();
		Trace.WriteLine("++ Locale zone loaded: " + stopwatch.Elapsed.ToString());
		stopwatch.Reset();
		stopwatch.Start();
		return c1a;
	}

	// Token: 0x04002280 RID: 8832
	public static readonly string a = "LocalePlayfield";

	// Token: 0x04002281 RID: 8833
	private static readonly Guid b = new Guid("{48F960F2-4A39-45d2-AFBE-900AA9750012}");

	// Token: 0x04002282 RID: 8834
	private const string c = "TimelapsePlayfieldManager";

	// Token: 0x04002283 RID: 8835
	private e3h d;

	// Token: 0x04002284 RID: 8836
	private crp e;

	// Token: 0x0200100B RID: 4107
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x060054C3 RID: 21699 RVA: 0x0025777C File Offset: 0x0025597C
		internal bool a(b0b A_0)
		{
			return A_0.qe() == this.a.Value;
		}

		// Token: 0x04002285 RID: 8837
		public Guid? a;
	}

	// Token: 0x0200100C RID: 4108
	[CompilerGenerated]
	private sealed class b
	{
		// Token: 0x060054C5 RID: 21701 RVA: 0x0025779C File Offset: 0x0025599C
		internal bool a(b0b A_0)
		{
			return A_0.qe() == this.a.Value;
		}

		// Token: 0x04002286 RID: 8838
		public Guid? a;
	}
}
