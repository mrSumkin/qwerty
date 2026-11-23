using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Ouroboros.Core.Logging;
using TimelapseVertigo.Common;
using TimelapseVertigo.Common.Settings;

// Token: 0x0200205D RID: 8285
public sealed class m9 : euz, amj
{
	// Token: 0x0600C4CB RID: 50379 RVA: 0x004470F0 File Offset: 0x004452F0
	public TimelapseTextFeeds h()
	{
		return this.p;
	}

	// Token: 0x0600C4CC RID: 50380 RVA: 0x004470F8 File Offset: 0x004452F8
	public void a(TimelapseTextFeeds A_0)
	{
		if (this.p != A_0)
		{
			this.p = A_0;
			this.e();
		}
	}

	// Token: 0x0600C4CD RID: 50381 RVA: 0x00447114 File Offset: 0x00445314
	public m9()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		this.u = serviceOrThrow.aq1().b().p();
		this.g();
		this.c();
		this.e();
	}

	// Token: 0x0600C4CE RID: 50382 RVA: 0x004471C4 File Offset: 0x004453C4
	public override void iv(e6d A_0, cp9 A_1)
	{
		Point point = base.at();
		cne service = bpo.GetService<cne>();
		if (service != null)
		{
			Texture2D resource = service.GetResource<Texture2D>(this.v, null);
			if (resource != null)
			{
				Rectangle rectangle = new Rectangle(point.X, point.Y, this.f.c, base.Size.d);
				if (rectangle.Height % 2 != 0)
				{
					rectangle.Height++;
				}
				c4o.a(A_1, resource, this.e, this.f, rectangle, Color.White);
				if (this.o > 0.0)
				{
					c4o.a(A_1, resource, this.h, Point.Zero, new Rectangle(point.X + this.f.c, point.Y, base.Size.c - this.f.c, base.Size.d), new Color(0, 0, 0, 255) * (float)(this.o * 0.4000000059604645), true, new Point?(this.g));
				}
			}
		}
		this.n.Visible = (this.o == 1.0);
		if (this.q != null)
		{
			this.q.a(new Point(point.X + this.j.X, point.Y + this.j.Y), A_1, null, 1f);
		}
		base.iv(A_0, A_1);
		this.s.a(A_0);
		this.r.a(A_0);
		this.t.a(A_0);
	}

	// Token: 0x0600C4CF RID: 50383 RVA: 0x00447380 File Offset: 0x00445580
	public override void ag5(e6d A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		aha service = bpo.GetService<aha>();
		int num = this.f();
		if (base.Size.c != num)
		{
			base.Size = new esj(num, base.Size.d);
			service.v7(num - Convert.ToInt32((double)this.j.X * 1.175));
			service.wd();
			this.d();
		}
		if (service != null)
		{
			bool flag = false;
			if (this.u != serviceOrThrow.aq1().b().p())
			{
				this.u = serviceOrThrow.aq1().b().p();
				flag = true;
			}
			service.v9(service.wc(serviceOrThrow.aq1().b().p()));
			if (flag)
			{
				service.wd();
				this.d();
			}
		}
		this.b();
		if (base.iz(A_0.b()) && this.p != TimelapseTextFeeds.None)
		{
			if (this.o < 1.0 && (this.o += 0.002 * A_0.a().ElapsedGameTime.TotalMilliseconds) > 1.0)
			{
				this.o = 1.0;
			}
		}
		else if (this.o > 0.0 && (this.o -= 0.002 * A_0.a().ElapsedGameTime.TotalMilliseconds) < 0.0)
		{
			this.o = 0.0;
		}
		base.ag5(A_0);
	}

	// Token: 0x0600C4D0 RID: 50384 RVA: 0x00447550 File Offset: 0x00445750
	public override bool iz(MouseState A_0)
	{
		Point point = base.at();
		return (A_0.X >= point.X && A_0.X < point.X + this.f.c && A_0.Y >= point.Y && A_0.Y <= point.Y + base.Size.d) || this.n.iz(A_0);
	}

	// Token: 0x0600C4D1 RID: 50385 RVA: 0x004475E0 File Offset: 0x004457E0
	public ecs yf(euz A_0)
	{
		string text = null;
		string a_ = null;
		if (A_0 == this.m)
		{
			text = "Без журнала";
			a_ = "Журнал не будет отображаться.";
		}
		else if (A_0 == this.l)
		{
			text = "Журнал диалогов";
			a_ = "В этот журнал попадают диалоги, другие имеющие отношение к повествованию вещи и прочая дребедень.";
		}
		else if (A_0 == this.k)
		{
			text = "Журнал боя";
			a_ = "В этот журнал попадают события боя и всякое разное.";
		}
		if (text != null)
		{
			return new ecs(new List<dl6>
			{
				new dl6(new List<bph>
				{
					new bph(new d22(cq4.d(), adi.c), text, null)
				}),
				new dl6(new List<bph>
				{
					new bph(new d22(cq4.c(), adi.c), "", null)
				}),
				new dl6(new List<bph>
				{
					new bph(new d22(cq4.c(), Color.White), a_, null)
				})
			});
		}
		return null;
	}

	// Token: 0x0600C4D2 RID: 50386 RVA: 0x004476E0 File Offset: 0x004458E0
	protected override void i0()
	{
		base.i0();
		aha service = bpo.GetService<aha>();
		if (service != null)
		{
			service.wa(new EventHandler<an8>(this.a));
		}
	}

	// Token: 0x0600C4D3 RID: 50387 RVA: 0x00447714 File Offset: 0x00445914
	protected override void i1()
	{
		base.i1();
		aha service = bpo.GetService<aha>();
		if (service != null)
		{
			service.wb(new EventHandler<an8>(this.a));
		}
	}

	// Token: 0x0600C4D4 RID: 50388 RVA: 0x00447748 File Offset: 0x00445948
	private void g()
	{
		aha service = bpo.GetService<aha>();
		bpo.GetServiceOrThrow<cnk>();
		esj esj = a2x.a();
		wj wj = wj.a();
		if (wj.d == UiSize.Classic)
		{
			base.Size = new esj(this.f(), Math.Max(176, (int)((double)esj.d * 0.27)));
		}
		else
		{
			this.v = wj.f;
			this.e = wj.a5;
			this.f = wj.a6;
			this.g = wj.a7;
			this.h = wj.a8;
			this.i = wj.ba;
			this.j = wj.bb;
			base.Size = new esj(this.f(), Math.Max(this.i.d * 7, (int)((double)esj.d * 0.33)));
			base.Size = new esj(base.Size.c, base.Size.d + (wj.g - base.Size.d % wj.g));
		}
		if (service != null)
		{
			service.v7(base.Size.c - 70);
		}
		this.k = new doz();
		if (wj.d == UiSize.Classic)
		{
			this.k.a(bo1.aj);
			this.k.Location = new Point(0, 5);
			this.k.a(new Point(325, 0));
		}
		else
		{
			this.k.a(wj.f);
			this.k.Location = new Point(0, 0);
			this.k.a(wj.a9);
		}
		this.k.c(new EventHandler<b25>(this.g));
		this.k.Checked = true;
		this.k.j(new EventHandler<b25>(this.a));
		this.k.l(new EventHandler<b25>(this.b));
		this.a(this.k);
		this.aox(this.k);
		this.l = new doz();
		if (wj.d == UiSize.Classic)
		{
			this.l.a(bo1.aj);
			this.l.Location = new Point(0, 35);
			this.l.a(new Point(325, 50));
		}
		else
		{
			this.l.a(wj.f);
			this.l.Location = new Point(0, this.i.d);
			this.l.a(d05.a(wj.a9, new Point(0, 2 * this.i.d), false));
		}
		this.l.c(new EventHandler<b25>(this.h));
		this.l.j(new EventHandler<b25>(this.c));
		this.l.l(new EventHandler<b25>(this.d));
		this.a(this.l);
		this.aox(this.l);
		this.m = new doz();
		if (wj.d == UiSize.Classic)
		{
			this.m.a(bo1.aj);
			this.m.Location = new Point(0, base.Size.d - 30);
			this.m.a(new Point(325, 100));
		}
		else
		{
			this.m.a(wj.f);
			this.m.Location = new Point(0, base.Size.d - this.i.d);
			this.m.a(d05.a(wj.a9, new Point(0, 4 * this.i.d), false));
		}
		this.m.c(new EventHandler<b25>(this.i));
		this.m.j(new EventHandler<b25>(this.e));
		this.m.l(new EventHandler<b25>(this.f));
		this.a(this.m);
		this.aox(this.m);
		if (wj.d == UiSize.Classic)
		{
			this.n = new se();
			this.n.Location = new Point(27, 5);
			this.n.Size = new esj(27, base.Size.d - this.n.Location.Y * 2);
		}
		else
		{
			this.n = new c1y();
			this.n.Location = new Point(wj.ba.c + 4, wj.bo.d / 3);
			this.n.Size = new esj(wj.bo.c, base.Size.d - this.n.Location.Y * 2);
		}
		this.n.IsPrivateComponent = true;
		this.n.b(0);
		this.n.d(5);
		this.n.c(1);
		this.n.f(new EventHandler<c1>(this.a));
		this.aox(this.n);
	}

	// Token: 0x0600C4D5 RID: 50389 RVA: 0x00447CCC File Offset: 0x00445ECC
	private int f()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		esj esj = a2x.a();
		wj wj = wj.a();
		if (wj.d == UiSize.Classic)
		{
			return (int)(450.0 * serviceOrThrow.aq1().b().j());
		}
		return (int)((double)Math.Min(wj.a4, esj.c / 3) * serviceOrThrow.aq1().b().j());
	}

	// Token: 0x0600C4D6 RID: 50390 RVA: 0x00447D3C File Offset: 0x00445F3C
	private void a(doz A_0)
	{
		A_0.Size = this.i;
		A_0.IsPrivateComponent = true;
		A_0.a(c9j.e);
		e4z.f(A_0);
	}

	// Token: 0x0600C4D7 RID: 50391 RVA: 0x00447D60 File Offset: 0x00445F60
	private void e()
	{
		this.m.Checked = (this.p == TimelapseTextFeeds.None);
		this.k.Checked = (this.p == TimelapseTextFeeds.Combat);
		this.l.Checked = (this.p == TimelapseTextFeeds.Chat);
		this.a(true);
	}

	// Token: 0x0600C4D8 RID: 50392 RVA: 0x00447DB0 File Offset: 0x00445FB0
	private void a(bool A_0)
	{
		aha service = bpo.GetService<aha>();
		bool flag = true;
		if (service != null)
		{
			yj yj = service.we(this.p.ToString());
			if (yj != null)
			{
				bool flag2 = A_0 || this.n.l() == this.n.k();
				this.n.a(Math.Max(0, yj.d().Count - this.a()));
				if ((flag2 || this.n.l() > this.n.k()) && this.n.l() != this.n.k())
				{
					this.n.e(this.n.k());
					flag = false;
				}
			}
			else
			{
				this.n.a(0);
				if (this.n.l() != 0)
				{
					this.n.e(0);
					flag = false;
				}
			}
		}
		if (flag)
		{
			this.d();
		}
	}

	// Token: 0x0600C4D9 RID: 50393 RVA: 0x00447EC0 File Offset: 0x004460C0
	private void d()
	{
		this.q = null;
		aha service = bpo.GetService<aha>();
		if (service != null)
		{
			yj yj = service.we(this.p.ToString());
			if (yj != null)
			{
				try
				{
					ecs ecs = new ecs();
					ecs.a.AddRange(yj.d().GetRange(this.n.l(), Math.Min(this.a(), yj.d().Count - this.n.l())));
					this.q = ecs.b();
				}
				catch (Exception ex)
				{
					dux.b(LogSeverity.Error, "Failed to recreate text solution for the text feedback viewer. Exception: {0}", new object[]
					{
						ex.ToString()
					});
				}
			}
		}
	}

	// Token: 0x0600C4DA RID: 50394 RVA: 0x00447F88 File Offset: 0x00446188
	private void c()
	{
		this.s = new dsy(this.l, this, esj.a(), 150, null, null, 0, false, false);
		this.r = new dsy(this.k, this, esj.a(), 150, null, null, 0, false, false);
		this.t = new dsy(this.m, this, esj.a(), 150, null, null, 0, false, false);
	}

	// Token: 0x0600C4DB RID: 50395 RVA: 0x00448028 File Offset: 0x00446228
	private void b()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		int num = 150;
		if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Huge)
		{
			num = (int)((double)num * 2.5);
		}
		else if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.ExtraLarge)
		{
			num *= 2;
		}
		else if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Large)
		{
			num = (int)((double)num * 1.5);
		}
		if (this.s != null)
		{
			this.s.a(num);
		}
		if (this.r != null)
		{
			this.r.a(num);
		}
		if (this.t != null)
		{
			this.t.a(num);
		}
	}

	// Token: 0x0600C4DC RID: 50396 RVA: 0x004480F4 File Offset: 0x004462F4
	private int a()
	{
		cne serviceOrThrow = bpo.GetServiceOrThrow<cne>();
		aha service = bpo.GetService<aha>();
		if (service != null)
		{
			SpriteFont resource = serviceOrThrow.GetResource<SpriteFont>(service.v8(), null);
			if (resource != null)
			{
				int num = (int)resource.MeasureString(" ").Y;
				return (base.Size.d - this.j.Y * 2) / num;
			}
		}
		return 1;
	}

	// Token: 0x0600C4DD RID: 50397 RVA: 0x00448160 File Offset: 0x00446360
	private void i(object A_0, b25 A_1)
	{
		this.a(TimelapseTextFeeds.None);
	}

	// Token: 0x0600C4DE RID: 50398 RVA: 0x0044816C File Offset: 0x0044636C
	private void h(object A_0, b25 A_1)
	{
		this.a(TimelapseTextFeeds.Chat);
	}

	// Token: 0x0600C4DF RID: 50399 RVA: 0x00448178 File Offset: 0x00446378
	private void g(object A_0, b25 A_1)
	{
		this.a(TimelapseTextFeeds.Combat);
	}

	// Token: 0x0600C4E0 RID: 50400 RVA: 0x00448184 File Offset: 0x00446384
	private void a(object A_0, c1 A_1)
	{
		this.d();
	}

	// Token: 0x0600C4E1 RID: 50401 RVA: 0x00448190 File Offset: 0x00446390
	private void a(object A_0, an8 A_1)
	{
		if (A_1.a() != null && A_1.a().Equals(this.p.ToString()))
		{
			this.a(false);
		}
	}

	// Token: 0x0600C4E2 RID: 50402 RVA: 0x004481D0 File Offset: 0x004463D0
	private void f(object A_0, b25 A_1)
	{
		this.t.b();
	}

	// Token: 0x0600C4E3 RID: 50403 RVA: 0x004481E0 File Offset: 0x004463E0
	private void e(object A_0, b25 A_1)
	{
		this.t.b();
	}

	// Token: 0x0600C4E4 RID: 50404 RVA: 0x004481F0 File Offset: 0x004463F0
	private void d(object A_0, b25 A_1)
	{
		this.s.b();
	}

	// Token: 0x0600C4E5 RID: 50405 RVA: 0x00448200 File Offset: 0x00446400
	private void c(object A_0, b25 A_1)
	{
		this.s.b();
	}

	// Token: 0x0600C4E6 RID: 50406 RVA: 0x00448210 File Offset: 0x00446410
	private void b(object A_0, b25 A_1)
	{
		this.r.b();
	}

	// Token: 0x0600C4E7 RID: 50407 RVA: 0x00448220 File Offset: 0x00446420
	private void a(object A_0, b25 A_1)
	{
		this.r.b();
	}

	// Token: 0x040047D0 RID: 18384
	private new const float a = 0.4f;

	// Token: 0x040047D1 RID: 18385
	private new const double b = 0.002;

	// Token: 0x040047D2 RID: 18386
	private new const int c = 27;

	// Token: 0x040047D3 RID: 18387
	private new const int d = 150;

	// Token: 0x040047D4 RID: 18388
	private new Point e = new Point(300, 0);

	// Token: 0x040047D5 RID: 18389
	private new esj f = new esj(25, 50);

	// Token: 0x040047D6 RID: 18390
	private new Point g = new Point(0, 0);

	// Token: 0x040047D7 RID: 18391
	private esj h = new esj(100, 50);

	// Token: 0x040047D8 RID: 18392
	private esj i = new esj(25, 25);

	// Token: 0x040047D9 RID: 18393
	private new Point j = new Point(60, 10);

	// Token: 0x040047DA RID: 18394
	private new doz k;

	// Token: 0x040047DB RID: 18395
	private new doz l;

	// Token: 0x040047DC RID: 18396
	private new doz m;

	// Token: 0x040047DD RID: 18397
	private cs9 n;

	// Token: 0x040047DE RID: 18398
	private double o;

	// Token: 0x040047DF RID: 18399
	private TimelapseTextFeeds p = TimelapseTextFeeds.Combat;

	// Token: 0x040047E0 RID: 18400
	private dn3 q;

	// Token: 0x040047E1 RID: 18401
	private dsy r;

	// Token: 0x040047E2 RID: 18402
	private dsy s;

	// Token: 0x040047E3 RID: 18403
	private dsy t;

	// Token: 0x040047E4 RID: 18404
	private InterfaceElementSize2 u;

	// Token: 0x040047E5 RID: 18405
	private string v = bo1.aj;
}
