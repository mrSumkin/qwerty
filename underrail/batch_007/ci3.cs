using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TimelapseVertigo.Common;
using TimelapseVertigo.Common.Settings;

// Token: 0x0200208E RID: 8334
public sealed class ci3 : daj, amj
{
	// Token: 0x0600C735 RID: 50997 RVA: 0x0046109C File Offset: 0x0045F29C
	public mv q()
	{
		return this.t;
	}

	// Token: 0x0600C736 RID: 50998 RVA: 0x004610A4 File Offset: 0x0045F2A4
	public ek7 n()
	{
		return this.j;
	}

	// Token: 0x0600C737 RID: 50999 RVA: 0x004610AC File Offset: 0x0045F2AC
	public e60 m()
	{
		return this.i;
	}

	// Token: 0x0600C738 RID: 51000 RVA: 0x004610B4 File Offset: 0x0045F2B4
	public m9 v()
	{
		return this.m;
	}

	// Token: 0x0600C739 RID: 51001 RVA: 0x004610BC File Offset: 0x0045F2BC
	public djx d()
	{
		return this.o;
	}

	// Token: 0x0600C73A RID: 51002 RVA: 0x004610C4 File Offset: 0x0045F2C4
	public apt l()
	{
		return this.q;
	}

	// Token: 0x0600C73B RID: 51003 RVA: 0x004610CC File Offset: 0x0045F2CC
	public b5r s()
	{
		return this.r;
	}

	// Token: 0x0600C73C RID: 51004 RVA: 0x004610D4 File Offset: 0x0045F2D4
	public bool r()
	{
		return this.ad;
	}

	// Token: 0x0600C73D RID: 51005 RVA: 0x004610DC File Offset: 0x0045F2DC
	public void a(bool A_0)
	{
		if (this.ad != A_0)
		{
			this.ad = A_0;
			this.b();
		}
	}

	// Token: 0x0600C73E RID: 51006 RVA: 0x004610F8 File Offset: 0x0045F2F8
	public ci3(ps A_0)
	{
		czh.a(A_0, "controller");
		this.f = A_0;
		this.c();
		this.af = new dsy(this.k, this.k, esj.a(), 600, null, new Point?(new Point(this.k.Location.X + 15, this.k.Location.Y - 45)), 1000, false, false);
	}

	// Token: 0x0600C73F RID: 51007 RVA: 0x004611C8 File Offset: 0x0045F3C8
	public override void ag5(e6d A_0)
	{
		Stopwatch stopwatch = null;
		if (dm9.e)
		{
			stopwatch = Stopwatch.StartNew();
		}
		base.ag5(A_0);
		if ((this.ae += A_0.a().ElapsedGameTime.TotalMilliseconds) > 550.0)
		{
			this.ae = 0.0;
		}
		this.n.Visible = (this.f.ak2() && this.ae > 275.0);
		if (!base.IsFocus)
		{
			this.t.i();
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			this.g.a(serviceOrThrow.aqu().v().b() as c5x);
		}
		this.a(A_0);
		if (stopwatch != null)
		{
			stopwatch.Stop();
			this.aq.Add(stopwatch.Elapsed.TotalMilliseconds);
			if (this.aq.Count >= 100)
			{
				this.@as = Math.Round(Enumerable.Sum(this.aq) / (double)this.ap.Count, 2);
				this.aq.Clear();
			}
		}
		if (this.t != null)
		{
			KeyboardState state = Keyboard.GetState();
			if (state.IsKeyDown(Keys.LeftAlt) || state.IsKeyDown(Keys.RightAlt))
			{
				this.t.g.c = new brh?(brh.a);
			}
			else
			{
				this.t.g.c = null;
			}
		}
		ps service = bpo.GetService<ps>();
		if (service != null)
		{
			service.akv(this.j.j().Checked);
		}
	}

	// Token: 0x0600C740 RID: 51008 RVA: 0x004613B0 File Offset: 0x0045F5B0
	public override void iv(e6d A_0, cp9 A_1)
	{
		Stopwatch stopwatch = null;
		if (dm9.e)
		{
			stopwatch = Stopwatch.StartNew();
		}
		ds6.a();
		if (this.t != null)
		{
			if (this.al > 0.0)
			{
				this.al -= A_0.a().ElapsedGameTime.TotalMilliseconds;
				this.am -= A_0.a().ElapsedGameTime.TotalMilliseconds;
				if (this.am <= 0.0)
				{
					int maxValue = this.ah;
					int maxValue2 = this.aj;
					if (this.al < 750.0)
					{
						maxValue = (int)((double)this.ag + (double)(this.ah - this.ag) * this.al / 750.0);
						maxValue2 = (int)((double)this.ai + (double)(this.aj - this.ai) * this.al / 750.0);
					}
					this.t.Location = new Point(((cuo.a.NextDouble() > 0.5) ? 1 : -1) * cuo.a.Next(this.ag, maxValue), ((cuo.a.NextDouble() > 0.5) ? 1 : -1) * cuo.a.Next(this.ai, maxValue2));
					this.t.f();
					this.am = (double)this.ak;
				}
			}
			else if (this.t.Location != Point.Zero)
			{
				this.t.Location = Point.Zero;
				this.t.f();
			}
		}
		base.iv(A_0, A_1);
		this.af.a(A_0);
		if (this.f.ak6())
		{
			ap1 service = bpo.GetService<ap1>();
			if (service != null)
			{
				cj cj = service.aer();
				if (cj != null && cj.b() != null && cj.b().a() != null)
				{
					Point a_ = base.at();
					esj esj = a2x.a();
					Point a_2;
					if (wj.a().c())
					{
						a_2 = new Point((esj.c - cj.b().a().b.c) / 2, 150);
					}
					else
					{
						a_2 = new Point((esj.c - cj.b().a().b.c) / 2, Convert.ToInt32((float)esj.d * 0.66f - (float)cj.b().a().b.d) / 2);
					}
					Point a_3 = d05.a(a_, a_2, false);
					cj.b().a().a(a_3, A_1, A_1.a, (float)cj.a());
				}
			}
		}
		if (eti.Get<bool>("ShowZoneName", new bool?(false)).Value && A_0.c().IsKeyDown(Keys.LeftAlt))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqw() != null)
			{
				A_1.b().xb(A_1.a.GetResource<SpriteFont>(egg.@as, null), string.Format("Зона: {0}", serviceOrThrow.aqw().y8()), new Vector2(150f, 15f), Color.White);
			}
		}
		this.z.a(A_0);
		this.aa.a(A_0);
		if (this.ab != null)
		{
			this.ab.a(A_0);
		}
		if (this.ac != null)
		{
			this.ac.a(A_0);
		}
		ds6.a(A_1, A_0);
		if (stopwatch != null)
		{
			stopwatch.Stop();
			this.ap.Add(stopwatch.Elapsed.TotalMilliseconds);
			if (this.ap.Count >= 100)
			{
				this.ar = Math.Round(Enumerable.Sum(this.ap) / (double)this.ap.Count, 2);
				this.ap.Clear();
			}
			A_1.b().xb(A_1.a.GetResource<SpriteFont>(egg.b, null), string.Format("Draw: {0} | Update: {1}", this.ar, this.@as), Vector2.Zero, Color.White);
		}
	}

	// Token: 0x0600C741 RID: 51009 RVA: 0x00461848 File Offset: 0x0045FA48
	public c15 a(string A_0, dbi A_1, csy A_2, bool A_3)
	{
		evh evh = this.p();
		ebk a_;
		if (evh == null)
		{
			a_ = new b3w(bpo.GetServiceOrThrow<cnk>().aqu().v().Bag, null, false, true, false, false, 0, false);
		}
		else
		{
			a_ = evh.BagView;
		}
		c15 c = new c15(A_1, a_, A_2, A_3);
		c.Text = A_0;
		c.Location = new Point(40, 250);
		this.aox(c);
		return c;
	}

	// Token: 0x0600C742 RID: 51010 RVA: 0x004618BC File Offset: 0x0045FABC
	public zj a(bcx A_0, dbi A_1, csy A_2, object A_3)
	{
		evh evh = this.p();
		ebk a_;
		if (evh == null)
		{
			a_ = new b3w(bpo.GetServiceOrThrow<cnk>().aqu().v().Bag, null, false, true, false, false, 0, false);
		}
		else
		{
			a_ = evh.BagView;
		}
		zj zj = new zj(A_0, A_1, a_, A_2, A_3 as wv);
		zj.Location = new Point(10, 150);
		if (zj.Location.Y + zj.Size.d > base.Size.d)
		{
			zj.Location = new Point(zj.Location.X, (base.Size.d - zj.Size.d) / 2);
		}
		this.aox(zj);
		return zj;
	}

	// Token: 0x0600C743 RID: 51011 RVA: 0x00461988 File Offset: 0x0045FB88
	public eed i()
	{
		eed eed = new eed();
		eed.Location = new Point(10, 150);
		if (eed.Location.Y + eed.Size.d > base.Size.d)
		{
			eed.Location = new Point(eed.Location.X, (base.Size.d - eed.Size.d) / 2);
		}
		eed.a(new EventHandler<el5>(this.g));
		this.aox(eed);
		this.i.f().Checked = true;
		return eed;
	}

	// Token: 0x0600C744 RID: 51012 RVA: 0x00461A30 File Offset: 0x0045FC30
	public ckj u()
	{
		ckj ckj = new ckj();
		ckj.Location = new Point(10, 150);
		ckj.a(new EventHandler<el5>(this.f));
		this.aox(ckj);
		this.i.l().Checked = true;
		return ckj;
	}

	// Token: 0x0600C745 RID: 51013 RVA: 0x00461A84 File Offset: 0x0045FC84
	public evh b(efk A_0)
	{
		evh evh = new evh(A_0);
		evh.Location = new Point(base.Size.c - (evh.Size.c + 10), 150);
		if (evh.Location.Y + evh.Size.d > base.Size.d)
		{
			evh.Location = new Point(evh.Location.X, (base.Size.d - evh.Size.d) / 2);
		}
		evh.a(new EventHandler<el5>(this.j));
		this.aox(evh);
		this.i.d().Checked = true;
		return evh;
	}

	// Token: 0x0600C746 RID: 51014 RVA: 0x00461B44 File Offset: 0x0045FD44
	public ax3 o()
	{
		ax3 ax = new ax3();
		ax.Location = new Point(base.Size.c - (ax.Size.c + 10), 150);
		if (ax.Location.Y + ax.Size.d > this.k.Location.Y)
		{
			ax.Location = new Point(ax.Location.X, (base.Size.d - ax.Size.d) / 2);
		}
		ax.a(new EventHandler<el5>(this.i));
		this.aox(ax);
		this.i.i().Checked = true;
		return ax;
	}

	// Token: 0x0600C747 RID: 51015 RVA: 0x00461C08 File Offset: 0x0045FE08
	public evh p()
	{
		return Enumerable.FirstOrDefault<evh>(Enumerable.OfType<evh>(base.Controls));
	}

	// Token: 0x0600C748 RID: 51016 RVA: 0x00461C1C File Offset: 0x0045FE1C
	public dm1 a(efk A_0)
	{
		dm1 dm = new dm1(A_0);
		dm.Location = new Point(10, 150);
		dm.a(new EventHandler<el5>(this.e));
		this.aox(dm);
		this.i.h().Checked = true;
		return dm;
	}

	// Token: 0x0600C749 RID: 51017 RVA: 0x00461C70 File Offset: 0x0045FE70
	public a5r g()
	{
		a5r a5r = new a5r();
		a5r.a(new EventHandler<el5>(this.h));
		this.aox(a5r);
		this.i.k().Checked = true;
		return a5r;
	}

	// Token: 0x0600C74A RID: 51018 RVA: 0x00461CB0 File Offset: 0x0045FEB0
	public dhn h()
	{
		dhn dhn = new dhn();
		dhn.Location = new Point(10, 150);
		if (dhn.Location.Y + dhn.Size.d > this.k.Location.Y)
		{
			dhn.Location = new Point(dhn.Location.X, (base.Size.d - dhn.Size.d) / 2);
		}
		dhn.a(new EventHandler<el5>(this.d));
		this.aox(dhn);
		this.i.c().Checked = true;
		return dhn;
	}

	// Token: 0x0600C74B RID: 51019 RVA: 0x00461D5C File Offset: 0x0045FF5C
	public d49 a(bu2 A_0)
	{
		a2x.a();
		d49 d = new d49(A_0);
		this.a(d);
		d.q(new EventHandler<c1>(this.c));
		this.aox(d);
		d.a9();
		return d;
	}

	// Token: 0x0600C74C RID: 51020 RVA: 0x00461DA0 File Offset: 0x0045FFA0
	private void c(object A_0, c1 A_1)
	{
		d49 d = A_0 as d49;
		if (d != null)
		{
			this.a(d);
		}
	}

	// Token: 0x0600C74D RID: 51021 RVA: 0x00461DC4 File Offset: 0x0045FFC4
	private void a(d49 A_0)
	{
		esj esj = a2x.a();
		int num;
		if (A_0.Size.d >= esj.d - 10)
		{
			num = 0;
		}
		else
		{
			num = 10;
		}
		A_0.Location = new Point((esj.c - A_0.Size.c) / 2, esj.d - (A_0.Size.d + num));
	}

	// Token: 0x0600C74E RID: 51022 RVA: 0x00461E30 File Offset: 0x00460030
	public b6o a(eg A_0, ble A_1)
	{
		b6o b6o = new b6o(A_0, A_1);
		b6o.Location = new Point(10, 150);
		if (b6o.Location.Y + b6o.Size.d > base.Size.d)
		{
			b6o.Location = new Point(b6o.Location.X, (base.Size.d - b6o.Size.d) / 2);
		}
		this.aox(b6o);
		return b6o;
	}

	// Token: 0x0600C74F RID: 51023 RVA: 0x00461EB8 File Offset: 0x004600B8
	public ekj t()
	{
		esj esj = a2x.a();
		ekj ekj = new ekj();
		ekj.Location = new Point((esj.c - ekj.Size.c) / 2, (esj.d - ekj.Size.d) / 2);
		ekj.Gravity = axy.c;
		ekj.a(new EventHandler<el5>(this.c));
		ekj.b(new EventHandler<EventArgs>(this.a));
		this.aox(ekj);
		this.j.k().Checked = true;
		return ekj;
	}

	// Token: 0x0600C750 RID: 51024 RVA: 0x00461F4C File Offset: 0x0046014C
	public iw a(a9m A_0)
	{
		iw iw = new iw(bpo.GetServiceOrThrow<cnk>().aqu().v(), A_0, false);
		iw.Focusable = true;
		this.aox(iw);
		iw.a9();
		iw.a(new EventHandler<el5>(this.a));
		bpo.GetServiceOrThrow<bcm>().aax(iw);
		return iw;
	}

	// Token: 0x0600C751 RID: 51025 RVA: 0x00461FA4 File Offset: 0x004601A4
	public void a(amc A_0)
	{
		if (A_0 != null)
		{
			this.h.a(A_0.aa());
			this.h.a(A_0.a8());
			this.h.Visible = (this.ad && A_0.aa() != null);
			return;
		}
		this.h.a(null);
		this.h.a(null);
		this.h.Visible = false;
	}

	// Token: 0x0600C752 RID: 51026 RVA: 0x00462024 File Offset: 0x00460224
	public amm a(c5x A_0, b14 A_1, Point? A_2, string A_3)
	{
		aqu aqu = new aqu(A_0, A_1, A_2, A_3);
		aqu.Location = new Point((base.Size.c - aqu.Size.c) / 2, (base.Size.d - aqu.Size.d) / 2);
		this.aox(aqu);
		return aqu;
	}

	// Token: 0x0600C753 RID: 51027 RVA: 0x00462084 File Offset: 0x00460284
	public ewq f()
	{
		ewq ewq = new ewq();
		ewq.b();
		ewq.Gravity = axy.c;
		ewq.a(new EventHandler<el5>(this.b));
		this.aox(ewq);
		ewq.a9();
		return ewq;
	}

	// Token: 0x0600C754 RID: 51028 RVA: 0x004620C8 File Offset: 0x004602C8
	public void k()
	{
		this.an = true;
		if (this.s == null)
		{
			esj esj = a2x.a();
			int num = Convert.ToInt32((double)esj.d * 0.75);
			if (num % 2 == 1)
			{
				num++;
			}
			esj esj2 = new esj(esj.c, num);
			this.ao = 0.0;
			this.s = new j9(esj2);
			this.s.Location = new Point(0, -esj2.d);
			this.aox(this.s);
		}
	}

	// Token: 0x0600C755 RID: 51029 RVA: 0x00462160 File Offset: 0x00460360
	public void e()
	{
		this.an = false;
	}

	// Token: 0x0600C756 RID: 51030 RVA: 0x0046216C File Offset: 0x0046036C
	public void j()
	{
		this.an = false;
		if (this.s != null)
		{
			this.s.bp();
			this.g(this.s);
			this.s = null;
		}
	}

	// Token: 0x0600C757 RID: 51031 RVA: 0x004621A0 File Offset: 0x004603A0
	private void a(e6d A_0)
	{
		bool flag = false;
		if (this.an)
		{
			this.s.b();
			if (this.ao < 1.0)
			{
				this.ao = Math.Min(1.0, this.ao + A_0.a().ElapsedGameTime.TotalMilliseconds * 0.003);
				flag = true;
			}
		}
		else if (this.s != null)
		{
			this.s.a();
			this.ao -= A_0.a().ElapsedGameTime.TotalMilliseconds * 0.003;
			if (this.ao <= 0.0)
			{
				this.g(this.s);
				this.s = null;
			}
			else
			{
				flag = true;
			}
		}
		if (flag)
		{
			int num = Convert.ToInt32((double)this.s.Size.d * (-1.0 + this.ao));
			this.s.Location = new Point(0, num);
		}
	}

	// Token: 0x0600C758 RID: 51032 RVA: 0x004622C8 File Offset: 0x004604C8
	private void c()
	{
		wj wj = wj.a();
		this.Focusable = true;
		this.c();
		this.a();
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		esj esj = a2x.a();
		if (wj.c())
		{
			this.g = new dl5(serviceOrThrow.aqu().v(), 1f, false, null);
		}
		else
		{
			this.g = new dl5(serviceOrThrow.aqu().v(), wj.k, false, null);
		}
		this.g.Location = new Point(10, 10);
		this.g.c(new EventHandler<b25>(this.q));
		this.g.a(new EventHandler<b25>(this.p));
		this.aox(this.g);
		if (wj.c())
		{
			this.h = new dl5(0.8f, true, null);
		}
		else
		{
			this.h = new dl5(wj.j, true, null);
		}
		this.h.a(false);
		this.h.c(false);
		this.h.d(false);
		this.h.b(false);
		this.h.Location = new Point(this.g.Location.X + this.g.Size.c + 30, 10);
		this.h.Visible = false;
		this.h.c(new EventHandler<b25>(this.q));
		this.aox(this.h);
		this.i = new e60();
		this.i.Location = new Point(esj.c - (this.i.Size.c + 10), 10);
		this.i.d().c(new EventHandler<b25>(this.l));
		this.i.e().c(new EventHandler<b25>(this.t));
		this.i.c().c(new EventHandler<b25>(this.s));
		this.i.l().c(new EventHandler<b25>(this.r));
		this.i.j().c(new EventHandler<b25>(this.n));
		this.i.h().c(new EventHandler<b25>(this.m));
		this.i.f().c(new EventHandler<b25>(this.j));
		this.i.k().c(new EventHandler<b25>(this.i));
		if (this.i.g() != null)
		{
			this.i.g().c(new EventHandler<b25>(this.f));
		}
		this.i.i().c(new EventHandler<b25>(this.k));
		this.p = new bp0();
		this.p.Location = new Point(esj.c - (this.p.Size.c + 10), this.i.Location.Y + this.i.Size.d + 8);
		this.aox(this.p);
		this.j = new ek7(serviceOrThrow.aqu().v());
		this.j.Location = new Point((base.Size.c - this.j.Size.c) / 2, base.Size.d - this.j.Size.d - 10);
		this.j.b(new EventHandler<EventArgs>(this.a));
		this.j.k().c(new EventHandler<b25>(this.o));
		this.j.y(new EventHandler<c1>(this.a));
		this.j.w(new EventHandler<c1>(this.b));
		this.aox(this.j);
		this.k = new br4();
		this.k.Color = Color.Green;
		this.k.a(Color.Yellow);
		this.k.Size = wj.ac;
		this.k.Location = new Point((base.Size.c - this.k.Size.c) / 2, this.j.Location.Y - this.k.Size.d - 3);
		this.k.j(new EventHandler<b25>(this.g));
		this.k.l(new EventHandler<b25>(this.h));
		this.aox(this.k);
		this.l = new b6u(new dsx());
		if (wj.d == UiSize.Classic)
		{
			this.l.Size = new esj(650, 40);
			this.l.Location = new Point(this.k.Location.X + 10, this.k.Location.Y - this.l.Size.d - 5);
		}
		else
		{
			this.l.Size = new esj(this.k.Size.c - 20, (int)(40f * wj.iw));
			this.l.Location = new Point(this.k.Location.X + 10, this.k.Location.Y - this.l.Size.d - 5);
		}
		this.aox(this.l);
		this.m = new m9();
		this.m.Location = new Point(1, this.k.Location.Y - this.k.Size.d - this.m.Size.d);
		this.aox(this.m);
		this.n = new bg1();
		this.n.b = bo1.bo;
		this.n.Size = new esj(40, 40);
		this.n.d = new Rectangle?(new Rectangle(0, 18, this.n.Size.c, this.n.Size.d));
		this.n.Location = new Point(esj.c - (this.n.Size.c + 15), this.i.Location.Y + this.i.Size.d + 15);
		this.n.Visible = false;
		this.aox(this.n);
		this.o = new djx(new dsx());
		this.o.Location = new Point(esj.c - (this.o.Size.c + 10), this.j.Location.Y + this.j.Size.d - this.o.Size.d);
		this.aox(this.o);
		this.aox(this.i);
		this.q = new apt();
		if (wj.d == UiSize.Classic)
		{
			this.q.Location = new Point(esj.c / 2 - this.q.Size.c / 2, esj.d - 150);
		}
		else
		{
			this.q.Location = new Point(esj.c / 2 - this.q.Size.c / 2, (int)((double)esj.d * 0.66) - this.q.Size.d / 2);
		}
		this.aox(this.q);
		this.r = new b5r();
		this.r.Size = new esj(120, 48);
		this.r.Location = new Point((base.Size.c - this.r.Size.c) / 2, (base.Size.d - this.r.Size.d) / 2);
		this.aox(this.r);
		if (wj.d == UiSize.Classic)
		{
			this.y = new doz();
			this.y.a(wj.u);
			this.y.Size = wj.t;
		}
		this.v = new doz();
		if (wj.d == UiSize.Classic)
		{
			this.v.a(bo1.bn);
			this.v.Size = new esj(18, 25);
			this.v.a(new Point(21, 42));
		}
		else
		{
			this.v.a(wj.f);
			this.v.Size = wj.ay;
			this.v.a(wj.az);
		}
		if (wj.d != UiSize.Classic && serviceOrThrow.aq1().g().d)
		{
			this.v.Location = new Point(10, this.j.Location.Y + (this.j.Size.d - (wj.ay.d + wj.a0.d + 4)) / 2);
		}
		else
		{
			this.v.Location = new Point(10, this.j.Location.Y + (this.j.Size.d - wj.ay.d) / 2);
		}
		this.v.c(new EventHandler<b25>(this.d));
		this.v.j(new EventHandler<b25>(this.v));
		this.v.l(new EventHandler<b25>(this.v));
		this.aox(this.v);
		this.u = new doz();
		if (wj.d == UiSize.Classic)
		{
			this.u.a(bo1.bn);
			this.u.Size = new esj(18, 25);
			this.u.a(new Point(39, 42));
		}
		else
		{
			this.u.a(wj.f);
			this.u.Size = wj.ay;
			this.u.a((wj.az.b() + new Vector2((float)this.v.Size.c, 0f)).a());
		}
		this.u.Location = new Point(this.v.Location.X + this.v.Size.c, this.v.Location.Y);
		if (wj.d != UiSize.Classic && serviceOrThrow.aq1().g().d)
		{
			this.w = new doz();
			this.w.Size = wj.a0;
			this.w.a(wj.f);
			this.w.a(wj.a1);
			this.w.Location = new Point(this.v.Location.X, this.v.Location.Y + this.v.Size.d + 2);
			this.w.c(new EventHandler<b25>(this.c));
			this.w.j(new EventHandler<b25>(this.u));
			this.w.l(new EventHandler<b25>(this.u));
			e4z.f(this.w);
			this.aox(this.w);
			this.x = new doz();
			this.x.Size = wj.a0;
			this.x.a(wj.f);
			this.x.a(new Point(wj.a1.X + wj.a0.c, wj.a1.Y));
			this.x.Location = new Point(this.w.Location.X + wj.a0.c, this.w.Location.Y);
			this.x.c(new EventHandler<b25>(this.b));
			this.x.j(new EventHandler<b25>(this.u));
			this.x.l(new EventHandler<b25>(this.u));
			e4z.f(this.x);
			this.aox(this.x);
			this.ab = new dsy(this.w, this, esj.a(), cq4.a(250), new Rectangle?(new Rectangle(this.w.Location.X, this.w.Location.Y, this.w.Size.c * 2, this.w.Size.d)), null, 3000, false, false);
			this.ac = new dsy(this.x, this, esj.a(), cq4.a(250), new Rectangle?(new Rectangle(this.x.Location.X, this.x.Location.Y, this.x.Size.c * 2, this.x.Size.d)), null, 3000, false, false);
		}
		this.u.c(new EventHandler<b25>(this.e));
		this.u.j(new EventHandler<b25>(this.v));
		this.u.l(new EventHandler<b25>(this.v));
		this.aox(this.u);
		this.z = new dsy(this.v, this, esj.a(), cq4.a(250), new Rectangle?(new Rectangle(this.v.Location.X, this.v.Location.Y, this.v.Size.c * 2, this.v.Size.d)), null, 3000, false, false);
		this.aa = new dsy(this.u, this, esj.a(), cq4.a(250), new Rectangle?(new Rectangle(this.v.Location.X, this.v.Location.Y, this.v.Size.c * 2, this.v.Size.d)), null, 3000, false, false);
	}

	// Token: 0x0600C759 RID: 51033 RVA: 0x0046328C File Offset: 0x0046148C
	private void b()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		this.i.Visible = this.ad;
		this.g.Visible = this.ad;
		this.j.Visible = this.ad;
		this.k.Visible = this.ad;
		this.l.Visible = this.ad;
		this.m.Visible = this.ad;
		this.h.Visible = this.ad;
		this.o.Visible = this.ad;
		this.p.Visible = this.ad;
		this.u.Visible = this.ad;
		this.v.Visible = this.ad;
		if (this.x != null)
		{
			this.x.Visible = (this.ad && serviceOrThrow.aq1().g().d);
		}
		if (this.w != null)
		{
			this.w.Visible = (this.ad && serviceOrThrow.aq1().g().d);
		}
	}

	// Token: 0x0600C75A RID: 51034 RVA: 0x004633C8 File Offset: 0x004615C8
	private void a()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		li serviceOrThrow2 = bpo.GetServiceOrThrow<li>();
		this.t = new mv(serviceOrThrow2.ka());
		this.t.Gravity = axy.b;
		this.t.c();
		this.t.aoa(new bw7());
		this.t.an9().t9(true);
		this.t.an9().t5(new Vector2(0f, 0f));
		this.t.an9().t7(new Vector2(1f, 1f));
		this.t.e.b = 0.25f;
		this.t.d.a(true);
		this.t.d.c(true);
		this.t.d.a(20);
		this.t.d.a(0.3f);
		this.t.ap = cxc.b();
		this.t.c = serviceOrThrow.aqu().v().a();
		this.t.h.a = edg.b;
		this.t.a(serviceOrThrow.aq1().e().f());
		this.t.d.a(serviceOrThrow.aq1().e().d());
		this.t.t(new EventHandler<b25>(this.a));
		this.t.f();
		this.aox(this.t);
	}

	// Token: 0x0600C75B RID: 51035 RVA: 0x0046356C File Offset: 0x0046176C
	public ecs yf(euz A_0)
	{
		string text = null;
		string a_ = null;
		string a_2 = null;
		string a_3 = null;
		if (A_0 == this.v)
		{
			text = "Медленнее";
			a_ = d1o.b(Hotkey.SlowDown);
			a_2 = "CTRL+Колесо мыши вниз";
			a_3 = "Уменьшает скорость вне боя. Не работает во время управления транспортом или при перегруженности.";
		}
		else if (A_0 == this.u)
		{
			text = "Быстрее";
			a_ = d1o.b(Hotkey.SpeedUp);
			a_2 = "CTRL+Колесо мыши вверх";
			a_3 = "Увеличивает скорость вне боя. Не работает во время управления транспортом или при перегруженности.";
		}
		else if (A_0 == this.w)
		{
			text = "Отдалить";
			a_ = "SHIFT+Колесо мыши вниз";
			a_3 = "Уменьшить масштаб.";
		}
		else if (A_0 == this.x)
		{
			text = "Приблизить";
			a_ = "SHIFT+Колесо мыши вверх";
			a_3 = "Увеличить масштаб.";
		}
		if (text == null)
		{
			return null;
		}
		return cq4.a(text, a_, a_2, a_3);
	}

	// Token: 0x0600C75C RID: 51036 RVA: 0x0046362C File Offset: 0x0046182C
	private void v(object A_0, b25 A_1)
	{
		this.z.b();
		this.aa.b();
	}

	// Token: 0x0600C75D RID: 51037 RVA: 0x00463644 File Offset: 0x00461844
	private void u(object A_0, b25 A_1)
	{
		this.ab.b();
		this.ac.b();
	}

	// Token: 0x0600C75E RID: 51038 RVA: 0x0046365C File Offset: 0x0046185C
	private void t(object A_0, b25 A_1)
	{
		this.f.alq();
	}

	// Token: 0x0600C75F RID: 51039 RVA: 0x0046366C File Offset: 0x0046186C
	private void j(object A_0, el5 A_1)
	{
		this.i.d().Checked = false;
	}

	// Token: 0x0600C760 RID: 51040 RVA: 0x00463680 File Offset: 0x00461880
	private void i(object A_0, el5 A_1)
	{
		this.i.i().Checked = false;
	}

	// Token: 0x0600C761 RID: 51041 RVA: 0x00463694 File Offset: 0x00461894
	private void h(object A_0, el5 A_1)
	{
		this.i.k().Checked = false;
	}

	// Token: 0x0600C762 RID: 51042 RVA: 0x004636A8 File Offset: 0x004618A8
	private void g(object A_0, el5 A_1)
	{
		this.i.f().Checked = false;
	}

	// Token: 0x0600C763 RID: 51043 RVA: 0x004636BC File Offset: 0x004618BC
	private void f(object A_0, el5 A_1)
	{
		this.i.l().Checked = false;
	}

	// Token: 0x0600C764 RID: 51044 RVA: 0x004636D0 File Offset: 0x004618D0
	private void e(object A_0, el5 A_1)
	{
		this.i.h().Checked = false;
	}

	// Token: 0x0600C765 RID: 51045 RVA: 0x004636E4 File Offset: 0x004618E4
	private void d(object A_0, el5 A_1)
	{
		this.i.c().Checked = false;
	}

	// Token: 0x0600C766 RID: 51046 RVA: 0x004636F8 File Offset: 0x004618F8
	private void s(object A_0, b25 A_1)
	{
		if (this.i.c().Checked)
		{
			this.f.aly();
			return;
		}
		this.f.alx();
	}

	// Token: 0x0600C767 RID: 51047 RVA: 0x00463728 File Offset: 0x00461928
	private void r(object A_0, b25 A_1)
	{
		if (this.i.l().Checked)
		{
			this.f.al0();
			return;
		}
		this.f.alz();
	}

	// Token: 0x0600C768 RID: 51048 RVA: 0x00463758 File Offset: 0x00461958
	private void a(object A_0, EventArgs A_1)
	{
		eb1 eb = A_0 as eb1;
		if (eb != null)
		{
			this.f.amb(eb.zc());
		}
	}

	// Token: 0x0600C769 RID: 51049 RVA: 0x00463784 File Offset: 0x00461984
	private void q(object A_0, b25 A_1)
	{
		dl5 dl = A_0 as dl5;
		if (dl != null && dl.o() != null)
		{
			bi3 service = bpo.GetService<bi3>();
			if (service != null && service.aij() != null)
			{
				service.ain(dl.o());
			}
		}
	}

	// Token: 0x0600C76A RID: 51050 RVA: 0x004637D0 File Offset: 0x004619D0
	private void p(object A_0, b25 A_1)
	{
		dl5 dl = A_0 as dl5;
		if (dl != null && dl.o() != null)
		{
			bi3 service = bpo.GetService<bi3>();
			if (service != null && service.aij() != null)
			{
				service.ain(dl.o());
				return;
			}
			ny aspect = dl.o().GetAspect<ny>();
			if (aspect != null)
			{
				bx5 bx = new bx5(dl.o());
				bx.l(new EventHandler<EventArgs>(new b90().a));
				aspect.a(bx, atp.a, true, false);
				a7v.a(new ed7(dl.o(), null));
			}
		}
	}

	// Token: 0x0600C76B RID: 51051 RVA: 0x0046386C File Offset: 0x00461A6C
	private void o(object A_0, b25 A_1)
	{
		this.f.alu();
	}

	// Token: 0x0600C76C RID: 51052 RVA: 0x0046387C File Offset: 0x00461A7C
	private void c(object A_0, el5 A_1)
	{
		this.j.k().Checked = false;
	}

	// Token: 0x0600C76D RID: 51053 RVA: 0x00463890 File Offset: 0x00461A90
	private void n(object A_0, b25 A_1)
	{
		this.f.al3();
	}

	// Token: 0x0600C76E RID: 51054 RVA: 0x004638A0 File Offset: 0x00461AA0
	private void m(object A_0, b25 A_1)
	{
		if (this.i.h().Checked)
		{
			this.f.al5();
			return;
		}
		this.f.al4();
	}

	// Token: 0x0600C76F RID: 51055 RVA: 0x004638D0 File Offset: 0x00461AD0
	private void l(object A_0, b25 A_1)
	{
		if (this.i.d().Checked)
		{
			this.f.alw();
			return;
		}
		this.f.alv();
	}

	// Token: 0x0600C770 RID: 51056 RVA: 0x00463900 File Offset: 0x00461B00
	private void k(object A_0, b25 A_1)
	{
		if (this.i.i().Checked)
		{
			this.f.al2();
			return;
		}
		this.f.al1();
	}

	// Token: 0x0600C771 RID: 51057 RVA: 0x00463930 File Offset: 0x00461B30
	private void j(object A_0, b25 A_1)
	{
		if (this.i.f().Checked)
		{
			this.f.al7();
			return;
		}
		this.f.al6();
	}

	// Token: 0x0600C772 RID: 51058 RVA: 0x00463960 File Offset: 0x00461B60
	private void i(object A_0, b25 A_1)
	{
		if (this.i.k().Checked)
		{
			this.f.al9();
			return;
		}
		this.f.al8();
	}

	// Token: 0x0600C773 RID: 51059 RVA: 0x00463990 File Offset: 0x00461B90
	private void h(object A_0, b25 A_1)
	{
		this.af.b();
	}

	// Token: 0x0600C774 RID: 51060 RVA: 0x004639A0 File Offset: 0x00461BA0
	private void g(object A_0, b25 A_1)
	{
		this.af.b();
	}

	// Token: 0x0600C775 RID: 51061 RVA: 0x004639B0 File Offset: 0x00461BB0
	private void b(object A_0, c1 A_1)
	{
		this.f.amd();
	}

	// Token: 0x0600C776 RID: 51062 RVA: 0x004639C0 File Offset: 0x00461BC0
	private void a(object A_0, c1 A_1)
	{
		this.f.amd();
	}

	// Token: 0x0600C777 RID: 51063 RVA: 0x004639D0 File Offset: 0x00461BD0
	private void f(object A_0, b25 A_1)
	{
		this.f.ama();
	}

	// Token: 0x0600C778 RID: 51064 RVA: 0x004639E0 File Offset: 0x00461BE0
	private void b(object A_0, el5 A_1)
	{
		this.i.g().Checked = false;
		base.a9();
	}

	// Token: 0x0600C779 RID: 51065 RVA: 0x004639FC File Offset: 0x00461BFC
	private bool a(euz A_0)
	{
		for (euz euz = A_0; euz != null; euz = euz.Parent)
		{
			if (euz is e8p)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600C77A RID: 51066 RVA: 0x00463A28 File Offset: 0x00461C28
	private void e(object A_0, b25 A_1)
	{
		this.q.a(true);
	}

	// Token: 0x0600C77B RID: 51067 RVA: 0x00463A38 File Offset: 0x00461C38
	private void d(object A_0, b25 A_1)
	{
		this.q.b(true);
	}

	// Token: 0x0600C77C RID: 51068 RVA: 0x00463A48 File Offset: 0x00461C48
	private void c(object A_0, b25 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		serviceOrThrow.aq9(serviceOrThrow.aq8() - 0.25f);
	}

	// Token: 0x0600C77D RID: 51069 RVA: 0x00463A60 File Offset: 0x00461C60
	private void b(object A_0, b25 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		serviceOrThrow.aq9(serviceOrThrow.aq8() + 0.25f);
	}

	// Token: 0x0600C77E RID: 51070 RVA: 0x00463A78 File Offset: 0x00461C78
	private void a(object A_0, b25 A_1)
	{
		if (this.u == null || !this.u.Visible || !this.u.Enabled)
		{
			return;
		}
		KeyboardState state = Keyboard.GetState();
		if (state.IsKeyDown(Keys.LeftControl) || state.IsKeyDown(Keys.RightControl))
		{
			int num = A_1.c() / 120;
			bool flag = num > 0;
			for (int i = 0; i < Math.Abs(num); i++)
			{
				if (flag)
				{
					this.q.a(i == 0);
				}
				else
				{
					this.q.b(i == 0);
				}
			}
		}
	}

	// Token: 0x0600C77F RID: 51071 RVA: 0x00463B28 File Offset: 0x00461D28
	public override string afm(euz A_0)
	{
		if (this.a(A_0))
		{
			return null;
		}
		if (this.f.alg())
		{
			return TimelapseCursor.Wait.ToString();
		}
		return this.f.ame(A_0);
	}

	// Token: 0x0600C780 RID: 51072 RVA: 0x00463B70 File Offset: 0x00461D70
	protected override bool afn(euz A_0, b25 A_1)
	{
		return !this.a(A_0) && (this.f.alg() || (A_1.b() == eoo.d && this.f.amd()));
	}

	// Token: 0x0600C781 RID: 51073 RVA: 0x00463BAC File Offset: 0x00461DAC
	protected override bool afo(euz A_0, b25 A_1)
	{
		return !this.a(A_0) && this.f.alg();
	}

	// Token: 0x0600C782 RID: 51074 RVA: 0x00463BC8 File Offset: 0x00461DC8
	protected override bool afp(euz A_0, b25 A_1)
	{
		return !this.a(A_0) && this.f.alg();
	}

	// Token: 0x0600C783 RID: 51075 RVA: 0x00463BE4 File Offset: 0x00461DE4
	protected override bool afq(euz A_0, ane A_1)
	{
		return !this.a(A_0) && this.f.alg();
	}

	// Token: 0x0600C784 RID: 51076 RVA: 0x00463C00 File Offset: 0x00461E00
	protected override bool afr(euz A_0, ane A_1)
	{
		return !this.a(A_0) && this.f.alg();
	}

	// Token: 0x0600C785 RID: 51077 RVA: 0x00463C1C File Offset: 0x00461E1C
	protected override bool afs(euz A_0, ane A_1)
	{
		return !this.a(A_0) && this.f.alg();
	}

	// Token: 0x0600C786 RID: 51078 RVA: 0x00463C38 File Offset: 0x00461E38
	[CompilerGenerated]
	private void a(object A_0, el5 A_1)
	{
		bpo.GetServiceOrThrow<bcm>().aax(this);
		base.a9();
	}

	// Token: 0x040049C1 RID: 18881
	private new const int a = 10;

	// Token: 0x040049C2 RID: 18882
	private new const int b = 40;

	// Token: 0x040049C3 RID: 18883
	private new const int c = 150;

	// Token: 0x040049C4 RID: 18884
	private new const int d = 550;

	// Token: 0x040049C5 RID: 18885
	private new const double e = 3.0;

	// Token: 0x040049C6 RID: 18886
	private new ps f;

	// Token: 0x040049C7 RID: 18887
	private new dl5 g;

	// Token: 0x040049C8 RID: 18888
	private dl5 h;

	// Token: 0x040049C9 RID: 18889
	private e60 i;

	// Token: 0x040049CA RID: 18890
	private new ek7 j;

	// Token: 0x040049CB RID: 18891
	private new br4 k;

	// Token: 0x040049CC RID: 18892
	private new b6u l;

	// Token: 0x040049CD RID: 18893
	private new m9 m;

	// Token: 0x040049CE RID: 18894
	private bg1 n;

	// Token: 0x040049CF RID: 18895
	private djx o;

	// Token: 0x040049D0 RID: 18896
	private bp0 p;

	// Token: 0x040049D1 RID: 18897
	private apt q;

	// Token: 0x040049D2 RID: 18898
	private b5r r;

	// Token: 0x040049D3 RID: 18899
	private j9 s;

	// Token: 0x040049D4 RID: 18900
	private mv t;

	// Token: 0x040049D5 RID: 18901
	private doz u;

	// Token: 0x040049D6 RID: 18902
	private doz v;

	// Token: 0x040049D7 RID: 18903
	private doz w;

	// Token: 0x040049D8 RID: 18904
	private new doz x;

	// Token: 0x040049D9 RID: 18905
	private doz y;

	// Token: 0x040049DA RID: 18906
	private new dsy z;

	// Token: 0x040049DB RID: 18907
	private dsy aa;

	// Token: 0x040049DC RID: 18908
	private dsy ab;

	// Token: 0x040049DD RID: 18909
	private dsy ac;

	// Token: 0x040049DE RID: 18910
	private bool ad = true;

	// Token: 0x040049DF RID: 18911
	private double ae;

	// Token: 0x040049E0 RID: 18912
	private new dsy af;

	// Token: 0x040049E1 RID: 18913
	public int ag = 5;

	// Token: 0x040049E2 RID: 18914
	public int ah = 5;

	// Token: 0x040049E3 RID: 18915
	public int ai = 10;

	// Token: 0x040049E4 RID: 18916
	public int aj = 10;

	// Token: 0x040049E5 RID: 18917
	public int ak = 10;

	// Token: 0x040049E6 RID: 18918
	public double al;

	// Token: 0x040049E7 RID: 18919
	public new double am;

	// Token: 0x040049E8 RID: 18920
	private bool an;

	// Token: 0x040049E9 RID: 18921
	private new double ao;

	// Token: 0x040049EA RID: 18922
	private new List<double> ap = new List<double>();

	// Token: 0x040049EB RID: 18923
	private List<double> aq = new List<double>();

	// Token: 0x040049EC RID: 18924
	private double ar;

	// Token: 0x040049ED RID: 18925
	private double @as;

	// Token: 0x040049EE RID: 18926
	private new const int at = 100;
}
