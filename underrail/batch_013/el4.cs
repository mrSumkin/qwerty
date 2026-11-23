using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x020007E5 RID: 2021
public abstract class el4 : ccn
{
	// Token: 0x060032A0 RID: 12960 RVA: 0x0013A6C0 File Offset: 0x001388C0
	protected virtual bool i()
	{
		return false;
	}

	// Token: 0x060032A1 RID: 12961 RVA: 0x0013A6C4 File Offset: 0x001388C4
	protected virtual bool k()
	{
		return false;
	}

	// Token: 0x060032A2 RID: 12962 RVA: 0x0013A6C8 File Offset: 0x001388C8
	protected virtual bool m()
	{
		return false;
	}

	// Token: 0x060032A3 RID: 12963
	protected abstract esj a3();

	// Token: 0x060032A4 RID: 12964 RVA: 0x0013A6CC File Offset: 0x001388CC
	protected virtual bool a7()
	{
		return true;
	}

	// Token: 0x060032A5 RID: 12965 RVA: 0x0013A6D0 File Offset: 0x001388D0
	protected virtual bool a6()
	{
		return true;
	}

	// Token: 0x060032A6 RID: 12966 RVA: 0x0013A6D4 File Offset: 0x001388D4
	protected virtual bool e()
	{
		return true;
	}

	// Token: 0x060032A7 RID: 12967 RVA: 0x0013A6D8 File Offset: 0x001388D8
	protected virtual bool f()
	{
		return true;
	}

	// Token: 0x060032A8 RID: 12968 RVA: 0x0013A6E0 File Offset: 0x001388E0
	protected virtual int? au5()
	{
		return null;
	}

	// Token: 0x060032A9 RID: 12969 RVA: 0x0013A6F8 File Offset: 0x001388F8
	protected virtual int? n()
	{
		return null;
	}

	// Token: 0x060032AA RID: 12970 RVA: 0x0013A710 File Offset: 0x00138910
	protected virtual int? g2()
	{
		return null;
	}

	// Token: 0x060032AB RID: 12971 RVA: 0x0013A728 File Offset: 0x00138928
	protected virtual int? ox()
	{
		return null;
	}

	// Token: 0x060032AC RID: 12972 RVA: 0x0013A740 File Offset: 0x00138940
	protected virtual bool g()
	{
		return false;
	}

	// Token: 0x060032AD RID: 12973 RVA: 0x0013A744 File Offset: 0x00138944
	protected virtual TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(60.0));
	}

	// Token: 0x060032AE RID: 12974 RVA: 0x0013A75C File Offset: 0x0013895C
	protected virtual bool b()
	{
		return true;
	}

	// Token: 0x060032AF RID: 12975 RVA: 0x0013A760 File Offset: 0x00138960
	protected virtual bool h()
	{
		return true;
	}

	// Token: 0x060032B0 RID: 12976 RVA: 0x0013A764 File Offset: 0x00138964
	protected virtual bool aj0()
	{
		return false;
	}

	// Token: 0x060032B1 RID: 12977 RVA: 0x0013A768 File Offset: 0x00138968
	protected virtual bool oe()
	{
		return false;
	}

	// Token: 0x060032B2 RID: 12978 RVA: 0x0013A76C File Offset: 0x0013896C
	protected virtual bool j()
	{
		return false;
	}

	// Token: 0x060032B3 RID: 12979 RVA: 0x0013A770 File Offset: 0x00138970
	protected virtual bool o()
	{
		return false;
	}

	// Token: 0x060032B4 RID: 12980 RVA: 0x0013A774 File Offset: 0x00138974
	protected virtual bool p()
	{
		return false;
	}

	// Token: 0x060032B5 RID: 12981 RVA: 0x0013A778 File Offset: 0x00138978
	protected virtual bool a()
	{
		return false;
	}

	// Token: 0x060032B6 RID: 12982 RVA: 0x0013A77C File Offset: 0x0013897C
	protected virtual bool l()
	{
		return false;
	}

	// Token: 0x060032B7 RID: 12983 RVA: 0x0013A780 File Offset: 0x00138980
	protected virtual bool kf()
	{
		return false;
	}

	// Token: 0x060032B8 RID: 12984 RVA: 0x0013A784 File Offset: 0x00138984
	protected virtual bool ap5()
	{
		return false;
	}

	// Token: 0x060032B9 RID: 12985 RVA: 0x0013A788 File Offset: 0x00138988
	protected el4()
	{
	}

	// Token: 0x060032BA RID: 12986 RVA: 0x0013A790 File Offset: 0x00138990
	protected el4(params string[] A_0) : base(A_0)
	{
	}

	// Token: 0x060032BB RID: 12987 RVA: 0x0013A79C File Offset: 0x0013899C
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		if (A_0.v() != null)
		{
			if (this.au5() != null && A_0.v().Level < this.au5().Value)
			{
				return false;
			}
			if (this.n() != null && A_0.v().Level > this.n().Value)
			{
				return false;
			}
		}
		bfc bfc = bpo.GetServiceOrThrow<cnk>().ar0(A_0.c().b(), A_0);
		if (bfc != null)
		{
			if (this.g2() != null && bfc.BaseLevel < this.g2().Value)
			{
				return false;
			}
			if (this.ox() != null && bfc.BaseLevel > this.ox().Value)
			{
				return false;
			}
		}
		if (this.l() && !A_2.d())
		{
			return false;
		}
		if (this.a() && !A_2.a())
		{
			return false;
		}
		if (this.o() && !A_2.f())
		{
			return false;
		}
		if (this.p() && !A_2.c())
		{
			return false;
		}
		if ((this.i() && esj.c(A_2.Size, this.a3())) || A_2.Size.c < this.a3().c || A_2.Size.d < this.a3().d)
		{
			return false;
		}
		for (int i = A_2.Location.X; i < A_2.Location.X + A_2.Size.c; i++)
		{
			for (int j = A_2.Location.Y; j < A_2.Location.Y + A_2.Size.d; j++)
			{
				ak1 a_ = A_2.Area.b(i, j);
				if (!this.a(a_))
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x060032BC RID: 12988 RVA: 0x0013A9CC File Offset: 0x00138BCC
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		Point point = A_2.Location;
		if (this.k() && A_2.Size.d > this.a3().d)
		{
			point = new Point(point.X, point.Y + (A_2.Size.d - this.a3().d));
		}
		if (this.m() && A_2.Size.c > this.a3().c)
		{
			point = new Point(point.X + (A_2.Size.c - this.a3().c), point.Y);
		}
		if (this.h())
		{
			if (!this.m() && point.X + this.a3().c < A_2.Size.c)
			{
				int num = A_2.Size.c - (point.X + this.a3().c);
				point = new Point(point.X + num * this.a(A_0, A_2).Next(num + 1), point.Y);
			}
			if (!this.k() && point.Y + this.a3().d < A_2.Size.d)
			{
				int num2 = A_2.Size.d - (point.Y + this.a3().d);
				point = new Point(point.X, point.Y + num2 * this.a(A_0, A_2).Next(num2 + 1));
			}
		}
		doq doq = doq.a(Path.Combine(d5x.p(), this.Id) + "_L1.uzl");
		if (this.b())
		{
			foreach (cpe cpe in doq.e())
			{
				foreach (b0b b0b in cpe.Entities)
				{
					ery aspect = b0b.GetAspect<ery>();
					if (aspect != null)
					{
						aspect.e();
					}
				}
			}
		}
		akf.a(A_2.Area, doq, aju.x, point, new Action<c5x>(new el4.a(A_1, this, A_2).a));
		A_0.r()[this.a(A_1)] = A_0.p();
	}

	// Token: 0x060032BD RID: 12989 RVA: 0x0013AC78 File Offset: 0x00138E78
	public override bool kg(cyt A_0, c1a A_1)
	{
		d60 d = A_1.a();
		bool flag = this.d();
		bool flag2 = false;
		if (this.a8() != null)
		{
			TimeSpan? primitivePropertyValue = A_0.r().GetPrimitivePropertyValue<TimeSpan>(this.a(A_1), null);
			if (primitivePropertyValue != null && primitivePropertyValue.Value + this.a8().Value < A_0.p())
			{
				flag = true;
			}
		}
		List<b0b> list = d.ab4(new string[]
		{
			this.c()
		});
		using (List<b0b>.Enumerator enumerator = list.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (((c5x)enumerator.Current).h.b != null)
				{
					flag2 = true;
					break;
				}
			}
		}
		if (!flag && this.a7() && !flag2)
		{
			flag = true;
		}
		if (flag)
		{
			this.ap6(A_0, A_1);
			if (this.a6())
			{
				foreach (b0b b0b in list)
				{
					c5x c5x = (c5x)b0b;
					if ((!this.e() || flag2 || (c5x.h.b != null && !c5x.h.b.aa().Passive && c5x.h.b.aa().b(d8o.c))) && c5x.Layer == aju.x)
					{
						if (this.ap5() && c5x.GetAspect<cx>() != null)
						{
							foreach (ak1 ak in c5x.l)
							{
								foreach (b0b b0b2 in ak.Entities)
								{
									c5x c5x2 = (c5x)b0b2;
									if (c5x2.IsFloor && c5x2.Layer == 0 && c5x2.ae != null)
									{
										c5x2.ae = null;
									}
								}
							}
						}
						c5x.w();
						c5x.an();
					}
				}
			}
			if (this.f())
			{
				foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
				{
					if (csd.Layer == aju.x && csd.Name != null && csd.Name.StartsWith("randomEvent_", StringComparison.OrdinalIgnoreCase))
					{
						A_1.b(csd);
					}
				}
			}
			return true;
		}
		return false;
	}

	// Token: 0x060032BE RID: 12990 RVA: 0x0013B008 File Offset: 0x00139208
	protected virtual void ap6(cyt A_0, c1a A_1)
	{
	}

	// Token: 0x060032BF RID: 12991 RVA: 0x0013B00C File Offset: 0x0013920C
	protected virtual void iy(c5x A_0)
	{
		string a_ = this.c();
		A_0.b(a_);
		if (A_0.GetAspect<a3f>() == null)
		{
			a3f a3f = new a3f(A_0);
			A_0.SetAspect<a3f>(a3f);
			a3f.a()["AlwaysDespawnEmptyRemains"] = true;
		}
		if (this.j() && A_0.GetAspect<amc>() != null)
		{
			A_0.VisualDirection = (HorizontalDirection)cuo.a.Next(8);
		}
	}

	// Token: 0x060032C0 RID: 12992 RVA: 0x0013B080 File Offset: 0x00139280
	protected virtual bool d()
	{
		return false;
	}

	// Token: 0x060032C1 RID: 12993 RVA: 0x0013B084 File Offset: 0x00139284
	protected Random a(cyt A_0, bop A_1)
	{
		return new Random(A_0.l() + A_1.GetHashCode());
	}

	// Token: 0x060032C2 RID: 12994 RVA: 0x0013B098 File Offset: 0x00139298
	protected string c()
	{
		return string.Format("Event_{0}", this.Id);
	}

	// Token: 0x060032C3 RID: 12995 RVA: 0x0013B0AC File Offset: 0x001392AC
	private string a(c1a A_0)
	{
		return string.Format("Event_{0}_in_{1}_StartTime", this.Id, A_0.y8());
	}

	// Token: 0x060032C4 RID: 12996 RVA: 0x0013B0C4 File Offset: 0x001392C4
	private bool a(ak1 A_0)
	{
		if (this.kf())
		{
			if (!A_0.Formation.c(64L) || A_0.Formation.c(278656L))
			{
				return false;
			}
		}
		else if (A_0.Formation.c(93186L))
		{
			return false;
		}
		if (A_0.f(null) != 0L)
		{
			return false;
		}
		if (!this.g())
		{
			foreach (b0b b0b in A_0.c.Values)
			{
				a3f aspect = ((c5x)b0b).GetAspect<a3f>();
				if (aspect != null && aspect.a().HasProperty("CorpseSourceName"))
				{
					return false;
				}
			}
			return true;
		}
		return true;
	}

	// Token: 0x020011CA RID: 4554
	private sealed class a
	{
		// Token: 0x060061B2 RID: 25010 RVA: 0x002A6F24 File Offset: 0x002A5124
		public a(c1a A_0, el4 A_1, bop A_2)
		{
			this.a = A_0;
			this.c = A_1;
			this.b = A_2;
		}

		// Token: 0x060061B3 RID: 25011 RVA: 0x002A6F44 File Offset: 0x002A5144
		public void a(c5x A_0)
		{
			this.c.iy(A_0);
			if (this.b.e() != null)
			{
				if (this.c.aj0())
				{
					A_0.VisualDirection = this.b.e().Value;
					return;
				}
				if (this.c.oe() && A_0.GetAspect<amc>() != null)
				{
					A_0.VisualDirection = this.b.e().Value;
					bm6 aspect = A_0.GetAspect<bm6>();
					if (aspect != null)
					{
						bt4 classPropertyValue = aspect.y6().GetClassPropertyValue<bt4>(ddq.ay);
						if (classPropertyValue != null && classPropertyValue.d() && !string.IsNullOrEmpty(classPropertyValue.b()))
						{
							csd csd = this.a.g(classPropertyValue.b());
							if (csd != null)
							{
								csd.Direction = this.b.e().Value;
							}
						}
					}
				}
			}
		}

		// Token: 0x04002979 RID: 10617
		private c1a a;

		// Token: 0x0400297A RID: 10618
		private bop b;

		// Token: 0x0400297B RID: 10619
		private el4 c;
	}
}
