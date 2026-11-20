using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TimelapseVertigo.Common.Settings;

// Token: 0x02002067 RID: 8295
public sealed class b3w : euz, ebk
{
	// Token: 0x0600C577 RID: 50551 RVA: 0x0044FC7C File Offset: 0x0044DE7C
	public euz p()
	{
		return this.t;
	}

	// Token: 0x0600C578 RID: 50552 RVA: 0x0044FC84 File Offset: 0x0044DE84
	public void a(euz A_0)
	{
		this.t = A_0;
	}

	// Token: 0x0600C579 RID: 50553 RVA: 0x0044FC90 File Offset: 0x0044DE90
	public dbi l()
	{
		return this.f;
	}

	// Token: 0x0600C57A RID: 50554 RVA: 0x0044FC98 File Offset: 0x0044DE98
	public dbi x()
	{
		return this.g;
	}

	// Token: 0x0600C57B RID: 50555 RVA: 0x0044FCA0 File Offset: 0x0044DEA0
	public bp2 k()
	{
		return this.e.a();
	}

	// Token: 0x0600C57C RID: 50556 RVA: 0x0044FCB0 File Offset: 0x0044DEB0
	public void a(bp2 A_0)
	{
		this.e.b(A_0);
	}

	// Token: 0x0600C57D RID: 50557 RVA: 0x0044FCC0 File Offset: 0x0044DEC0
	public string x8()
	{
		return this.o;
	}

	// Token: 0x0600C57E RID: 50558 RVA: 0x0044FCC8 File Offset: 0x0044DEC8
	public void a(string A_0)
	{
		this.o = A_0;
	}

	// Token: 0x0600C57F RID: 50559 RVA: 0x0044FCD4 File Offset: 0x0044DED4
	public bool r()
	{
		return this.i;
	}

	// Token: 0x0600C580 RID: 50560 RVA: 0x0044FCDC File Offset: 0x0044DEDC
	public void e(bool A_0)
	{
		if (this.i != A_0)
		{
			this.i = A_0;
			this.c();
		}
	}

	// Token: 0x0600C581 RID: 50561 RVA: 0x0044FCF8 File Offset: 0x0044DEF8
	public bool u()
	{
		return this.j;
	}

	// Token: 0x0600C582 RID: 50562 RVA: 0x0044FD00 File Offset: 0x0044DF00
	public void d(bool A_0)
	{
		if (this.j != A_0)
		{
			this.j = A_0;
			this.c();
		}
	}

	// Token: 0x0600C583 RID: 50563 RVA: 0x0044FD1C File Offset: 0x0044DF1C
	public bool g()
	{
		return this.k;
	}

	// Token: 0x0600C584 RID: 50564 RVA: 0x0044FD24 File Offset: 0x0044DF24
	public void a(bool A_0)
	{
		if (this.k != A_0)
		{
			this.k = A_0;
			this.c();
		}
	}

	// Token: 0x0600C585 RID: 50565 RVA: 0x0044FD40 File Offset: 0x0044DF40
	public bool h()
	{
		return this.l;
	}

	// Token: 0x0600C586 RID: 50566 RVA: 0x0044FD48 File Offset: 0x0044DF48
	public void f(bool A_0)
	{
		if (this.l != A_0)
		{
			this.l = A_0;
			this.c();
		}
	}

	// Token: 0x0600C587 RID: 50567 RVA: 0x0044FD64 File Offset: 0x0044DF64
	public coh yx()
	{
		return null;
	}

	// Token: 0x0600C588 RID: 50568 RVA: 0x0044FD68 File Offset: 0x0044DF68
	public bool yy()
	{
		return false;
	}

	// Token: 0x0600C589 RID: 50569 RVA: 0x0044FD6C File Offset: 0x0044DF6C
	public bool j()
	{
		return this.m;
	}

	// Token: 0x0600C58A RID: 50570 RVA: 0x0044FD74 File Offset: 0x0044DF74
	public void c(bool A_0)
	{
		if (this.m != A_0)
		{
			this.m = A_0;
			this.b(this.h.c, this.h.d);
		}
	}

	// Token: 0x0600C58B RID: 50571 RVA: 0x0044FDA8 File Offset: 0x0044DFA8
	public bool w()
	{
		return this.n;
	}

	// Token: 0x0600C58C RID: 50572 RVA: 0x0044FDB0 File Offset: 0x0044DFB0
	public void b(bool A_0)
	{
		if (this.n != A_0)
		{
			this.n = A_0;
			this.c();
		}
	}

	// Token: 0x0600C58D RID: 50573 RVA: 0x0044FDCC File Offset: 0x0044DFCC
	public Func<ebk, coh, bool> i()
	{
		return this.p;
	}

	// Token: 0x0600C58E RID: 50574 RVA: 0x0044FDD4 File Offset: 0x0044DFD4
	public void a(Func<ebk, coh, bool> A_0)
	{
		this.p = A_0;
	}

	// Token: 0x0600C58F RID: 50575 RVA: 0x0044FDE0 File Offset: 0x0044DFE0
	public Func<ebk, bool> q()
	{
		return this.q;
	}

	// Token: 0x0600C590 RID: 50576 RVA: 0x0044FDE8 File Offset: 0x0044DFE8
	public void a(Func<ebk, bool> A_0)
	{
		this.q = A_0;
	}

	// Token: 0x0600C591 RID: 50577 RVA: 0x0044FDF4 File Offset: 0x0044DFF4
	public csy s()
	{
		return this.r;
	}

	// Token: 0x0600C592 RID: 50578 RVA: 0x0044FDFC File Offset: 0x0044DFFC
	public double? f()
	{
		return this.s;
	}

	// Token: 0x0600C593 RID: 50579 RVA: 0x0044FE04 File Offset: 0x0044E004
	public void a(double? A_0)
	{
		this.s = A_0;
	}

	// Token: 0x0600C594 RID: 50580 RVA: 0x0044FE10 File Offset: 0x0044E010
	[CompilerGenerated]
	public void d(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.y;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.y, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C595 RID: 50581 RVA: 0x0044FE48 File Offset: 0x0044E048
	[CompilerGenerated]
	public void e(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.y;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.y, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C596 RID: 50582 RVA: 0x0044FE80 File Offset: 0x0044E080
	[CompilerGenerated]
	public void a(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.z;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.z, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C597 RID: 50583 RVA: 0x0044FEB8 File Offset: 0x0044E0B8
	[CompilerGenerated]
	public void f(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.z;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.z, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C598 RID: 50584 RVA: 0x0044FEF0 File Offset: 0x0044E0F0
	[CompilerGenerated]
	public void c(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.aa;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.aa, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C599 RID: 50585 RVA: 0x0044FF28 File Offset: 0x0044E128
	[CompilerGenerated]
	public void b(EventHandler<b25> A_0)
	{
		EventHandler<b25> eventHandler = this.aa;
		EventHandler<b25> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<b25> value = (EventHandler<b25>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<b25>>(ref this.aa, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600C59A RID: 50586 RVA: 0x0044FF60 File Offset: 0x0044E160
	public b3w(dbi A_0, csy A_1 = null, bool A_2 = false, bool A_3 = true, bool A_4 = false, bool A_5 = false, int A_6 = 0, bool A_7 = false)
	{
		czh.a(A_0, "container");
		this.f = A_0;
		this.i = A_2;
		this.j = A_3;
		this.r = A_1;
		this.u = A_4;
		this.v = A_5;
		this.a(A_6, A_7);
	}

	// Token: 0x0600C59B RID: 50587 RVA: 0x0044FFC4 File Offset: 0x0044E1C4
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.b();
		this.c();
		this.a();
	}

	// Token: 0x0600C59C RID: 50588 RVA: 0x0044FFE0 File Offset: 0x0044E1E0
	private void b(object A_0, c1 A_1)
	{
		this.e();
		this.a();
		this.b();
	}

	// Token: 0x0600C59D RID: 50589 RVA: 0x0044FFF4 File Offset: 0x0044E1F4
	private void a(object A_0, c1 A_1)
	{
		this.a((int)A_1.a() - (int)A_1.b());
	}

	// Token: 0x0600C59E RID: 50590 RVA: 0x00450014 File Offset: 0x0044E214
	private void b(object A_0, by0 A_1)
	{
		this.a();
	}

	// Token: 0x0600C59F RID: 50591 RVA: 0x0045001C File Offset: 0x0044E21C
	private void a(object A_0, by0 A_1)
	{
		this.a();
	}

	// Token: 0x0600C5A0 RID: 50592 RVA: 0x00450024 File Offset: 0x0044E224
	private void c(object A_0, b25 A_1)
	{
		if (this.y != null)
		{
			this.y(A_0, A_1);
		}
	}

	// Token: 0x0600C5A1 RID: 50593 RVA: 0x00450040 File Offset: 0x0044E240
	private void b(object A_0, b25 A_1)
	{
		if (A_1.b() == eoo.b && this.z != null)
		{
			this.z(A_0, A_1);
		}
	}

	// Token: 0x0600C5A2 RID: 50594 RVA: 0x00450068 File Offset: 0x0044E268
	private void a(object A_0, b25 A_1)
	{
		if (this.aa != null)
		{
			this.aa(A_0, A_1);
		}
	}

	// Token: 0x0600C5A3 RID: 50595 RVA: 0x00450088 File Offset: 0x0044E288
	protected override void it(object A_0, b25 A_1)
	{
		base.it(A_0, A_1);
		bdl bdl = this.d;
		bdl.e(bdl.l() - this.d.m() * Math.Sign(A_1.c()));
	}

	// Token: 0x0600C5A4 RID: 50596 RVA: 0x004500C8 File Offset: 0x0044E2C8
	protected override void lq(object A_0, b25 A_1)
	{
		base.lq(A_0, A_1);
		if (A_1.b() == eoo.d)
		{
			d4f.a();
		}
	}

	// Token: 0x0600C5A5 RID: 50597 RVA: 0x004500E8 File Offset: 0x0044E2E8
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
		this.w = bpo.GetService<c73>();
		etf service = bpo.GetService<etf>();
		if (service != null)
		{
			this.x = service.ar7();
			return;
		}
		this.x = null;
	}

	// Token: 0x0600C5A6 RID: 50598 RVA: 0x00450128 File Offset: 0x0044E328
	public void a(esj A_0)
	{
		this.b(A_0.c, A_0.d);
	}

	// Token: 0x0600C5A7 RID: 50599 RVA: 0x00450140 File Offset: 0x0044E340
	public void b(int A_0, int A_1)
	{
		wj wj = wj.a();
		int a_;
		int a_2;
		if (wj.d == UiSize.Classic)
		{
			a_ = this.a + A_0 * (cqy.b.c + 5);
			a_2 = this.d() + (A_1 * (cqy.b.d + 5) - 5);
		}
		else
		{
			a_ = this.a + 2 * this.b + A_0 * (wj.cm.c - wj.cn) + wj.cn;
			a_2 = this.d() + A_1 * (wj.cm.d - wj.cn) + wj.cn;
		}
		base.Size = new esj(a_, a_2);
	}

	// Token: 0x0600C5A8 RID: 50600 RVA: 0x004501F0 File Offset: 0x0044E3F0
	public esj a(int A_0, int A_1)
	{
		wj wj = wj.a();
		int a_;
		int a_2;
		if (wj.d == UiSize.Classic)
		{
			a_ = (A_0 - this.a) / (cqy.b.c + 5);
			a_2 = (A_1 - this.d() + 5) / (cqy.b.d + 5);
		}
		else
		{
			a_ = (A_0 - this.a - 2 * this.b - wj.cn) / (wj.cm.c - wj.cn);
			a_2 = (A_1 - this.d() + 5 - wj.cn) / (wj.cm.d - wj.cn);
		}
		return new esj(a_, a_2);
	}

	// Token: 0x0600C5A9 RID: 50601 RVA: 0x0045029C File Offset: 0x0044E49C
	public override bool iq(e08 A_0)
	{
		if (A_0 == null)
		{
			return false;
		}
		coh coh = A_0.c() as coh;
		if (coh != null)
		{
			ebk ebk = A_0.a() as ebk;
			if (ebk != null && this.ye(ebk, coh) && ebk.yg(this))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600C5AA RID: 50602 RVA: 0x004502F4 File Offset: 0x0044E4F4
	public bool ye(ebk A_0, coh A_1)
	{
		bool flag = this.t();
		if (this.p != null)
		{
			return flag && ((this.j && A_0.x8() == this.x8()) || this.p(A_0, A_1));
		}
		return flag;
	}

	// Token: 0x0600C5AB RID: 50603 RVA: 0x00450350 File Offset: 0x0044E550
	public bool yg(ebk A_0)
	{
		return this.q == null || (this.j && A_0.x8() == this.x8()) || this.q(A_0);
	}

	// Token: 0x0600C5AC RID: 50604 RVA: 0x00450390 File Offset: 0x0044E590
	public coh yd()
	{
		return null;
	}

	// Token: 0x0600C5AD RID: 50605 RVA: 0x00450398 File Offset: 0x0044E598
	public coh yb(coh A_0, bool A_1 = false)
	{
		this.f.z3(A_0, A_1);
		A_0.Stealable = true;
		A_0.Lootable = true;
		if (this.r != null)
		{
			this.r.kk(this.f, A_0, this.m());
		}
		return null;
	}

	// Token: 0x0600C5AE RID: 50606 RVA: 0x004503E4 File Offset: 0x0044E5E4
	public coh a(int A_0, coh A_1)
	{
		this.f.z4(A_0, A_1);
		if (this.r != null)
		{
			this.r.kk(this.f, A_1, this.m());
		}
		return null;
	}

	// Token: 0x0600C5AF RID: 50607 RVA: 0x00450418 File Offset: 0x0044E618
	public bool t()
	{
		if (this.k)
		{
			return c69.b();
		}
		return !this.l || !c69.a();
	}

	// Token: 0x0600C5B0 RID: 50608 RVA: 0x00450440 File Offset: 0x0044E640
	public override bool iz(MouseState A_0)
	{
		return base.iz(A_0) || this.e.iz(A_0);
	}

	// Token: 0x0600C5B1 RID: 50609 RVA: 0x00450460 File Offset: 0x0044E660
	public void yc(coh A_0, int A_1, int A_2)
	{
		coh coh = A_0.fy();
		coh.Stacks = A_2 - A_1;
		this.f.aaa(coh);
	}

	// Token: 0x0600C5B2 RID: 50610 RVA: 0x0045048C File Offset: 0x0044E68C
	public bool a(coh A_0)
	{
		return this.r == null || this.r.ki(this.f, A_0, this.m());
	}

	// Token: 0x0600C5B3 RID: 50611 RVA: 0x004504B4 File Offset: 0x0044E6B4
	public object m()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		object result;
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			result = serviceOrThrow.aqu().v().b().GetAspect<amc>();
		}
		else
		{
			result = null;
		}
		return result;
	}

	// Token: 0x0600C5B4 RID: 50612 RVA: 0x00450518 File Offset: 0x0044E718
	public void v()
	{
		this.g.aad();
	}

	// Token: 0x0600C5B5 RID: 50613 RVA: 0x00450528 File Offset: 0x0044E728
	public bool a(coh A_0, out Color? A_1)
	{
		A_1 = null;
		if (!this.u || A_0 == null || this.w == null)
		{
			return false;
		}
		if (this.w.aeg(A_0))
		{
			return true;
		}
		A_1 = new Color?(new Color(new Vector3(0.4f, 0.4f, 0.4f)));
		return false;
	}

	// Token: 0x0600C5B6 RID: 50614 RVA: 0x00450594 File Offset: 0x0044E794
	public bool b(coh A_0)
	{
		return this.v && this.w != null && !this.w.aeh(A_0);
	}

	// Token: 0x0600C5B7 RID: 50615 RVA: 0x004505C0 File Offset: 0x0044E7C0
	public bool b(coh A_0, ref Color? A_1)
	{
		if (this.x == null)
		{
			return false;
		}
		if (!this.x.ahb(A_0))
		{
			A_1 = new Color?(new Color(new Vector3(0.4f, 0.4f, 0.4f)));
			return false;
		}
		return true;
	}

	// Token: 0x0600C5B8 RID: 50616 RVA: 0x00450614 File Offset: 0x0044E814
	public int o()
	{
		return this.e.b();
	}

	// Token: 0x0600C5B9 RID: 50617 RVA: 0x00450624 File Offset: 0x0044E824
	public override void iv(e6d A_0, cp9 A_1)
	{
		base.iv(A_0, A_1);
		wj wj = wj.a();
		if (wj.d != UiSize.Classic && wj.f != null)
		{
			Texture2D texture2D = A_1.a.us(wj.f, null);
			if (texture2D != null)
			{
				Point point = base.at();
				int num = this.d();
				Rectangle a_ = new Rectangle(point.X + (this.n ? this.a : 0) - wj.c8, point.Y + num - wj.c8, this.h.c * (wj.cm.c - wj.cn) + wj.cn + 2 * wj.c8, base.Size.d - num + 2 * wj.c8);
				c4o.b(A_1, texture2D, wj.c7, Point.Zero, a_, new Color(50, 50, 50), false, new Point?(wj.c6));
			}
		}
	}

	// Token: 0x0600C5BA RID: 50618 RVA: 0x00450734 File Offset: 0x0044E934
	internal bool c(coh A_0)
	{
		if (this.g.z5(A_0))
		{
			if (this.r != null)
			{
				this.r.kl(this.f, A_0, this.m());
			}
			return true;
		}
		return false;
	}

	// Token: 0x0600C5BB RID: 50619 RVA: 0x00450770 File Offset: 0x0044E970
	internal Rectangle? n()
	{
		euz euz;
		if (this.t != null)
		{
			euz = this.t;
		}
		else
		{
			euz = this;
		}
		Point point = euz.at();
		return new Rectangle?(new Rectangle(point.X, point.Y, euz.Size.c, euz.Size.d));
	}

	// Token: 0x0600C5BC RID: 50620 RVA: 0x004507CC File Offset: 0x0044E9CC
	protected override void ag6(object A_0, etu A_1)
	{
		base.ag6(A_0, A_1);
		coh coh = A_1.b().c() as coh;
		ebk a_ = A_1.b().a() as ebk;
		if ((this.r == null || this.r.ki(this.f, coh, this.m())) && c69.a(a_, this, coh, false))
		{
			e4z.c();
		}
	}

	// Token: 0x0600C5BD RID: 50621 RVA: 0x00450840 File Offset: 0x0044EA40
	protected override void i0()
	{
		base.i0();
		this.f.zw(new EventHandler<by0>(this.a));
		this.f.zy(new EventHandler<by0>(this.b));
		this.g = new bqr(this.f);
		this.e();
		this.a();
		this.b();
	}

	// Token: 0x0600C5BE RID: 50622 RVA: 0x004508A4 File Offset: 0x0044EAA4
	protected override void i1()
	{
		base.i1();
		this.f.zx(new EventHandler<by0>(this.a));
		this.f.zz(new EventHandler<by0>(this.b));
		this.g.Dispose();
		this.g = null;
	}

	// Token: 0x0600C5BF RID: 50623 RVA: 0x004508F8 File Offset: 0x0044EAF8
	private void a(int A_0, bool A_1)
	{
		wj wj = wj.a();
		if (wj.d == UiSize.Classic)
		{
			this.d = new se();
		}
		else
		{
			this.a = wj.bo.c;
			this.b = (int)((double)this.a * 0.2);
			this.d = new c1y();
		}
		this.d.a(100);
		this.d.e(10);
		this.d.c(1);
		this.d.IsPrivateComponent = true;
		this.d.f(new EventHandler<c1>(this.a));
		this.aox(this.d);
		this.e = new b8i(this, A_1);
		this.e.Location = new Point(0, 0);
		this.e.Gravity = axy.c;
		if (A_0 >= 0 && A_0 < c65.a().Count)
		{
			this.e.b(c65.a()[A_0]);
		}
		b8i b8i = this.e;
		b8i.m = (EventHandler<c1>)Delegate.Combine(b8i.m, new EventHandler<c1>(this.b));
		this.aox(this.e);
		this.c();
	}

	// Token: 0x0600C5C0 RID: 50624 RVA: 0x00450A44 File Offset: 0x0044EC44
	private void e()
	{
		if (this.g != null && this.e != null)
		{
			this.g.a(this.e.a());
		}
	}

	// Token: 0x0600C5C1 RID: 50625 RVA: 0x00450A74 File Offset: 0x0044EC74
	private int d()
	{
		if (this.m)
		{
			return this.e.Location.Y + this.e.Size.d + 10;
		}
		return 0;
	}

	// Token: 0x0600C5C2 RID: 50626 RVA: 0x00450AA8 File Offset: 0x0044ECA8
	private void c()
	{
		wj wj = wj.a();
		int num = this.d();
		int num2 = base.Size.d - num;
		if (wj.d == UiSize.Classic)
		{
			this.h = new esj((base.Size.c - this.a) / (cqy.b.c + 5), (num2 + 5) / (cqy.b.d + 5));
		}
		else
		{
			this.h = new esj((base.Size.c - this.a - 2 * this.b - wj.cn) / (wj.cm.c - wj.cn), (num2 + 5) / (wj.cm.d - wj.cn));
		}
		if (this.n)
		{
			this.d.Location = new Point(0, num);
		}
		else
		{
			this.d.Location = new Point(base.Size.c - (this.a + (int)((double)this.b * 1.5)), num);
		}
		this.d.Size = new esj(this.a, num2);
		this.d.d((int)Math.Ceiling((double)this.h.d / 2.0));
		this.e.Visible = this.m;
		foreach (dkk a_ in Enumerable.ToList<dkk>(Enumerable.OfType<dkk>(base.Controls)))
		{
			this.g(a_);
		}
		for (int i = 0; i < this.h.d; i++)
		{
			for (int j = 0; j < this.h.c; j++)
			{
				dkk dkk;
				if (wj.d == UiSize.Classic)
				{
					dkk = new dkk(this, i * this.h.c + j);
					dkk.Location = new Point((this.n ? this.a : 0) + j * (cqy.b.c + 5), num + i * (cqy.b.d + 5));
					dkk.Color = new Color(50, 50, 50) * 0.3f;
				}
				else
				{
					dkk = new dkk(this, i * this.h.c + j, wj.cm, wj.o);
					dkk.Location = new Point((this.n ? this.a : 0) + j * (wj.cm.c - wj.cn), num + i * (wj.cm.d - wj.cn));
					dkk.d = wj.f;
					dkk.e = wj.cq;
					dkk.h = new Vector2?(wj.w);
					dkk.i = wj.x;
					dkk.a(Color.LightGray);
					dkk.r = wj.s;
					dkk.Color = new Color(25, 25, 25);
					dkk.u = true;
				}
				dkk.e(this.i);
				dkk.CanSplit = this.j;
				dkk.CanMerge = this.j;
				dkk.p(new EventHandler<b25>(this.c));
				dkk.i(new EventHandler<b25>(this.b));
				dkk.j(new EventHandler<b25>(this.a));
				dkk.PropagateMouseScrollEvent = true;
				this.aox(dkk);
			}
		}
	}

	// Token: 0x0600C5C3 RID: 50627 RVA: 0x00450E90 File Offset: 0x0044F090
	private void b()
	{
		this.d.e(0);
	}

	// Token: 0x0600C5C4 RID: 50628 RVA: 0x00450EA0 File Offset: 0x0044F0A0
	private void a()
	{
		if (this.g != null)
		{
			this.d.a(Math.Max(0, (int)Math.Ceiling((double)this.g.z2().Count / (double)this.h.c) - this.h.d));
			if (this.d.l() > this.d.k())
			{
				this.d.e(this.d.k());
			}
		}
	}

	// Token: 0x0600C5C5 RID: 50629 RVA: 0x00450F2C File Offset: 0x0044F12C
	private void a(int A_0)
	{
		foreach (dkk dkk in Enumerable.OfType<dkk>(base.Controls))
		{
			dkk.Index += A_0 * this.h.c;
		}
	}

	// Token: 0x0400486F RID: 18543
	private new int a = 27;

	// Token: 0x04004870 RID: 18544
	private new int b;

	// Token: 0x04004871 RID: 18545
	private new const int c = 5;

	// Token: 0x04004872 RID: 18546
	private new bdl d;

	// Token: 0x04004873 RID: 18547
	private new b8i e;

	// Token: 0x04004874 RID: 18548
	private new dbi f;

	// Token: 0x04004875 RID: 18549
	private new bqr g;

	// Token: 0x04004876 RID: 18550
	private esj h;

	// Token: 0x04004877 RID: 18551
	private bool i;

	// Token: 0x04004878 RID: 18552
	private new bool j;

	// Token: 0x04004879 RID: 18553
	private new bool k;

	// Token: 0x0400487A RID: 18554
	private new bool l;

	// Token: 0x0400487B RID: 18555
	private new bool m = true;

	// Token: 0x0400487C RID: 18556
	private bool n;

	// Token: 0x0400487D RID: 18557
	private string o;

	// Token: 0x0400487E RID: 18558
	private Func<ebk, coh, bool> p;

	// Token: 0x0400487F RID: 18559
	private Func<ebk, bool> q;

	// Token: 0x04004880 RID: 18560
	private csy r;

	// Token: 0x04004881 RID: 18561
	private double? s;

	// Token: 0x04004882 RID: 18562
	private euz t;

	// Token: 0x04004883 RID: 18563
	public bool u;

	// Token: 0x04004884 RID: 18564
	private bool v;

	// Token: 0x04004885 RID: 18565
	public c73 w;

	// Token: 0x04004886 RID: 18566
	private cb6 x;

	// Token: 0x04004887 RID: 18567
	[CompilerGenerated]
	private EventHandler<b25> y;

	// Token: 0x04004888 RID: 18568
	[CompilerGenerated]
	private EventHandler<b25> z;

	// Token: 0x04004889 RID: 18569
	[CompilerGenerated]
	private EventHandler<b25> aa;
}
