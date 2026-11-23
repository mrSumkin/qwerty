using System;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common;
using TimelapseVertigo.UI;

// Token: 0x02000593 RID: 1427
public sealed class cef : ec9, e8p, amj
{
	// Token: 0x060024F4 RID: 9460 RVA: 0x000D06B4 File Offset: 0x000CE8B4
	public cef(b9n A_0)
	{
		czh.a(A_0, "controller");
		this.e = A_0;
		this.a();
	}

	// Token: 0x060024F5 RID: 9461 RVA: 0x000D070C File Offset: 0x000CE90C
	public override void iv(e6d A_0, cp9 A_1)
	{
		d0p.a(A_1, Color.Black * 0.75f, true, true);
		base.iv(A_0, A_1);
		dsy dsy = this.n;
		if (dsy == null)
		{
			return;
		}
		dsy.a(A_0);
	}

	// Token: 0x060024F6 RID: 9462 RVA: 0x000D0744 File Offset: 0x000CE944
	private void a()
	{
		wj wj = wj.a();
		if (wj.c())
		{
			this.c = bo1.m;
		}
		else
		{
			this.a = wj.hx;
			this.b = wj.hy;
			this.c = wj.hv;
			this.d = wj.hw;
			this.c = wj.f;
			this.e = wj.dc;
			this.d = new esj?(wj.dd);
			base.Color = Color.White * 0.75f;
			int num = (int)pp.b.aqu().i();
			this.f = new bg1();
			this.f.Size = wj.he;
			this.f.b = string.Format(bo1.b0, wj.e);
			this.f.d = new Rectangle?(new Rectangle(num * wj.he.c, 0, wj.he.c, wj.he.d));
			this.f.Location = new Point(0, this.a);
			this.f.Color = adi.a;
			this.f.j(new EventHandler<b25>(this.f));
			this.f.l(new EventHandler<b25>(this.g));
			this.aox(this.f);
			this.m = this.f.Size.d + this.b;
		}
		esj esj = new esj(this.c.c + 2 * this.a, 2 * this.a + 7 * (this.c.d + this.b) + this.m - this.b);
		if (this.f != null)
		{
			esj esj2 = a2x.a();
			int val = Convert.ToInt32((float)(esj2.c - esj.c) / 2.25f);
			this.n = new dsy(this.f, this, new esj(Math.Min(val, 500), 200), Convert.ToInt32((float)(esj2.c - esj.c) / 2.25f), null, new Point?(new Point(esj2.c, 0)), 1000, true, false);
		}
		if (wj.c())
		{
			if (esj.d % 2 != 0)
			{
				esj = new esj(esj.c, esj.d + 1);
			}
		}
		else
		{
			wj.a(ref esj.d);
			this.f.Location = new Point((esj.c - this.f.Size.c) / 2, this.f.Location.Y);
		}
		base.Size = esj;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		this.g = this.a(0, dh9.c("GameMenu_Resume"));
		this.g.c(new EventHandler<b25>(this.e));
		this.h = this.a(1, dh9.c("GameMenu_Save"));
		this.h.Enabled = serviceOrThrow.arh();
		this.h.c(new EventHandler<b25>(this.c));
		this.i = this.a(2, dh9.c("GameMenu_Load"));
		this.i.c(new EventHandler<b25>(this.b));
		this.j = this.a(3, dh9.c("GameMenu_ExportChar"));
		this.j.c(new EventHandler<b25>(this.a));
		if (serviceOrThrow.aqu() != null)
		{
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(qu.a, new bool?(false)).Value)
			{
				this.j.Enabled = false;
			}
			else if (serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().Vehicle != null)
			{
				this.j.Enabled = false;
			}
		}
		this.k = this.a(4, dh9.c("GameMenu_Options"));
		this.l = this.a(6, dh9.c("GameMenu_Quit"));
		this.l.c(new EventHandler<b25>(this.d));
	}

	// Token: 0x060024F7 RID: 9463 RVA: 0x000D0BC4 File Offset: 0x000CEDC4
	private void g(object A_0, b25 A_1)
	{
		this.f.Color = adi.a;
		dsy dsy = this.n;
		if (dsy == null)
		{
			return;
		}
		dsy.b();
	}

	// Token: 0x060024F8 RID: 9464 RVA: 0x000D0BEC File Offset: 0x000CEDEC
	private void f(object A_0, b25 A_1)
	{
		this.f.Color = adi.d;
		dsy dsy = this.n;
		if (dsy == null)
		{
			return;
		}
		dsy.b();
	}

	// Token: 0x060024F9 RID: 9465 RVA: 0x000D0C14 File Offset: 0x000CEE14
	private zt a(int A_0, string A_1)
	{
		wj wj = wj.a();
		zt zt = new zt();
		if (wj.c())
		{
			zt.Text = A_1;
			zt.TextLabelOffset = new Point(0, 6);
		}
		else
		{
			zt.Text = A_1.ToUpperInvariant();
			zt.TextLabelOffset = new Point(0, wj.hz);
			zt.d = wj.f;
			zt.e = wj.fg;
			zt.f = new esj?(wj.fh);
		}
		zt.Location = new Point(this.a, this.m + this.a + (this.c.d + this.b) * A_0);
		zt.Size = this.c;
		zt.Font = this.d;
		zt.HorizontalAlignment = cab.b;
		zt.VerticalAlignment = ad4.b;
		zt.a = adi.a;
		zt.c = adi.b;
		zt.b = Color.White;
		zt.IsPrivateComponent = true;
		e4z.j(zt);
		this.aox(zt);
		return zt;
	}

	// Token: 0x060024FA RID: 9466 RVA: 0x000D0D28 File Offset: 0x000CEF28
	private new void e(object A_0, b25 A_1)
	{
		base.z();
	}

	// Token: 0x060024FB RID: 9467 RVA: 0x000D0D30 File Offset: 0x000CEF30
	private new void d(object A_0, b25 A_1)
	{
		base.z();
		this.e.avt();
	}

	// Token: 0x060024FC RID: 9468 RVA: 0x000D0D44 File Offset: 0x000CEF44
	private new void c(object A_0, b25 A_1)
	{
		arv arv = new arv(SavedGameManipulationMode.Save, abx.b);
		arv.Gravity = axy.c;
		arv.b();
		arv.a9();
		bpo.GetServiceOrThrow<bcm>().aau().aox(arv);
	}

	// Token: 0x060024FD RID: 9469 RVA: 0x000D0D80 File Offset: 0x000CEF80
	private void b(object A_0, b25 A_1)
	{
		arv arv = new arv(SavedGameManipulationMode.Load, abx.b);
		arv.Gravity = axy.c;
		arv.b();
		arv.a9();
		bpo.GetServiceOrThrow<bcm>().aau().aox(arv);
	}

	// Token: 0x060024FE RID: 9470 RVA: 0x000D0DBC File Offset: 0x000CEFBC
	private void a(object A_0, b25 A_1)
	{
		bpo.GetServiceOrThrow<d4m>().avp(dla.a(TimelapseWorkflows.ExportCharacter, new object[0]));
	}

	// Token: 0x060024FF RID: 9471 RVA: 0x000D0DD8 File Offset: 0x000CEFD8
	public ecs yf(euz A_0)
	{
		return cq4.a(euf.b());
	}

	// Token: 0x0400156C RID: 5484
	private new int a = 10;

	// Token: 0x0400156D RID: 5485
	private new int b = 10;

	// Token: 0x0400156E RID: 5486
	private new esj c = new esj(265, 35);

	// Token: 0x0400156F RID: 5487
	private new string d = egg.b;

	// Token: 0x04001570 RID: 5488
	private new b9n e;

	// Token: 0x04001571 RID: 5489
	private new bg1 f;

	// Token: 0x04001572 RID: 5490
	private new zt g;

	// Token: 0x04001573 RID: 5491
	private zt h;

	// Token: 0x04001574 RID: 5492
	private zt i;

	// Token: 0x04001575 RID: 5493
	private new zt j;

	// Token: 0x04001576 RID: 5494
	public new zt k;

	// Token: 0x04001577 RID: 5495
	private new zt l;

	// Token: 0x04001578 RID: 5496
	private new int m;

	// Token: 0x04001579 RID: 5497
	private dsy n;
}
