using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

// Token: 0x0200206E RID: 8302
public sealed class bnr : ec9
{
	// Token: 0x0600C611 RID: 50705 RVA: 0x00453C84 File Offset: 0x00451E84
	private bnr(eyp A_0, string A_1, string A_2, params cpk[] A_3)
	{
		wj wj = wj.a();
		if (!wj.c())
		{
			this.a = (this.b = (this.c = wj.g5));
			this.e = (int)((float)this.e * wj.g4.Y);
			this.f = (int)((float)this.f * wj.g4.Y);
			this.g = (int)((float)this.g * wj.g4.X);
			this.h = (int)((float)this.g * wj.g4.X);
			this.d = wj.g6;
		}
		base.Name = A_1;
		this.p = A_2;
		this.a(A_1, A_2, A_3);
		this.l = A_0;
		this.b();
	}

	// Token: 0x0600C612 RID: 50706 RVA: 0x00453DAC File Offset: 0x00451FAC
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.b();
	}

	// Token: 0x0600C613 RID: 50707 RVA: 0x00453DC0 File Offset: 0x00451FC0
	private void a(object A_0, b25 A_1)
	{
		if (this.l != null)
		{
			this.a();
			euz euz = A_0 as euz;
			this.l.g0(euz.Tag as string);
			return;
		}
		this.a();
	}

	// Token: 0x0600C614 RID: 50708 RVA: 0x00453E04 File Offset: 0x00452004
	protected override void y7(object A_0, ane A_1)
	{
		base.y7(A_0, A_1);
		if (this.m != null && (A_1.a == Keys.Enter || A_1.a == Keys.Space || string.Equals(d1o.a(A_1.a).ToString(), this.m, StringComparison.OrdinalIgnoreCase)))
		{
			zt zt = Enumerable.FirstOrDefault<zt>(Enumerable.Where<zt>(this.k, new Func<zt, bool>(this.b)));
			if (zt != null)
			{
				this.a(zt, new b25());
				return;
			}
		}
		else if (this.n != null && (A_1.a == Keys.Escape || string.Equals(d1o.a(A_1.a).ToString(), this.n, StringComparison.OrdinalIgnoreCase)))
		{
			zt zt2 = Enumerable.FirstOrDefault<zt>(Enumerable.Where<zt>(this.k, new Func<zt, bool>(this.a)));
			if (zt2 != null)
			{
				this.a(zt2, new b25());
			}
		}
	}

	// Token: 0x0600C615 RID: 50709 RVA: 0x00453EF8 File Offset: 0x004520F8
	private void a(string A_0, string A_1, params cpk[] A_2)
	{
		wj wj = wj.a();
		if (wj.c())
		{
			this.c = bo1.r;
		}
		else
		{
			this.c = wj.f;
			this.e = wj.b8;
			this.d = new esj?(wj.b9);
		}
		this.Focusable = true;
		this.i = new avo();
		this.i.Location = new Point(this.h, this.g + 6);
		this.i.IsPrivateComponent = true;
		this.i.Text = A_0;
		this.i.a(ad4.a);
		this.i.a(cab.a);
		this.i.a(this.a);
		this.i.Color = Color.White;
		this.aox(this.i);
		this.j = new avo();
		this.j.IsPrivateComponent = true;
		this.j.Text = string.Format(this.p ?? "", (int)Math.Ceiling(this.o / 1000.0));
		this.j.a(cab.a);
		this.j.a(ad4.a);
		this.j.Color = adi.a;
		this.j.a(this.b);
		this.aox(this.j);
		foreach (cpk cpk in A_2)
		{
			zt zt = this.c();
			zt.Enabled = cpk.c;
			zt.Text = cpk.b;
			zt.Tag = cpk.a;
			zt.c(new EventHandler<b25>(this.a));
			this.k.Add(zt);
			e4z.j(zt);
			this.aox(zt);
		}
	}

	// Token: 0x0600C616 RID: 50710 RVA: 0x004540F4 File Offset: 0x004522F4
	private new zt c()
	{
		wj wj = wj.a();
		zt zt = new zt();
		zt.a = Color.White;
		zt.b = Color.White;
		zt.c = Color.DarkGray;
		if (wj.c())
		{
			zt.d = bo1.b;
		}
		else
		{
			zt.d = wj.f;
			zt.e = wj.fg;
			zt.f = new esj?(wj.fh);
		}
		zt.TextLabelOffset = new Point(0, this.d);
		zt.h = Color.White;
		zt.Font = this.c;
		zt.c = adi.b;
		zt.a = Color.White;
		zt.b = Color.White;
		return zt;
	}

	// Token: 0x0600C617 RID: 50711 RVA: 0x004541C0 File Offset: 0x004523C0
	private void b()
	{
		if (this.i != null)
		{
			int a_ = 30;
			if (this.i.g() != null)
			{
				cne service = bpo.GetService<cne>();
				if (service != null)
				{
					SpriteFont resource = service.GetResource<SpriteFont>(this.i.g(), null);
					if (resource != null)
					{
						a_ = resource.LineSpacing + 5;
					}
				}
			}
			this.i.Size = new esj(base.Size.c - 2 * this.h, a_);
		}
		if (this.j != null)
		{
			this.j.Location = new Point(this.h, this.i.Location.Y + this.i.Size.d + 10);
			this.j.Size = new esj(base.Size.c - 2 * this.h, base.Size.d - 2 * this.g - base.Location.Y - this.k.Count * (this.f + this.e) - ((this.k.Count > 0) ? this.g : 0));
		}
		int num = this.k.Count;
		foreach (zt zt in this.k)
		{
			zt.Location = new Point(this.g, base.Size.d - num * (this.e + this.f) - this.g);
			zt.Size = new esj(base.Size.c - 2 * this.g, this.e);
			num--;
		}
	}

	// Token: 0x0600C618 RID: 50712 RVA: 0x004543B8 File Offset: 0x004525B8
	private void a()
	{
		base.z();
		bpo.GetServiceOrThrow<d1a>().aa4(this.q);
	}

	// Token: 0x0600C619 RID: 50713 RVA: 0x004543D0 File Offset: 0x004525D0
	public override void iv(e6d A_0, cp9 A_1)
	{
		if (base.Parent != null)
		{
			esj esj = bpo.GetServiceOrThrow<bef>().k0();
			Rectangle a_ = new Rectangle(0, 0, esj.c, esj.d);
			d0p.a(A_1, Color.White * 0.75f, a_, true, false);
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x0600C61A RID: 50714 RVA: 0x00454428 File Offset: 0x00452628
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
		this.j.Text = string.Format(this.p ?? "", (int)Math.Ceiling(this.o / 1000.0));
		if (this.o != 0.0)
		{
			this.o -= A_0.a().ElapsedGameTime.TotalMilliseconds;
			if (this.o <= 0.0)
			{
				this.a();
				this.l.g0(this.n);
			}
		}
	}

	// Token: 0x0600C61B RID: 50715 RVA: 0x004544D8 File Offset: 0x004526D8
	public static void a(esj A_0, eyp A_1, string A_2, string A_3, string A_4, string A_5, Color? A_6, Color? A_7, int A_8, cpk[] A_9, euz A_10 = null, euz A_11 = null)
	{
		wj wj = wj.a();
		Vector2 vector = Vector2.One;
		if (!wj.c())
		{
			vector = wj.g4;
		}
		bcm serviceOrThrow = bpo.GetServiceOrThrow<bcm>();
		d1a serviceOrThrow2 = bpo.GetServiceOrThrow<d1a>();
		euz euz;
		if (A_10 != null)
		{
			euz = A_10;
		}
		else
		{
			euz = serviceOrThrow.aau();
		}
		if (euz != null)
		{
			bnr bnr = new bnr(A_1, A_2, A_3, A_9);
			esj a_ = new esj((int)((float)A_0.c * vector.X), (int)((float)A_0.d * vector.Y));
			if (!wj.c())
			{
				wj.a(ref a_.d);
			}
			bnr.Size = a_;
			bnr.Location = new Point((euz.Size.c - bnr.Size.c) / 2, (euz.Size.d - bnr.Size.d) / 2);
			bnr.m = A_4;
			bnr.n = A_5;
			bnr.o = (double)A_8;
			bnr.q = ((A_11 != null) ? A_11 : serviceOrThrow2.aa7());
			if (A_6 != null)
			{
				bnr.i.Color = A_6.Value;
			}
			if (A_7 != null)
			{
				bnr.j.Color = A_7.Value;
			}
			bnr.e(euz);
			bnr.a9();
		}
	}

	// Token: 0x0600C61C RID: 50716 RVA: 0x00454648 File Offset: 0x00452848
	[CompilerGenerated]
	private bool b(zt A_0)
	{
		return this.m.Equals(A_0.Tag as string);
	}

	// Token: 0x0600C61D RID: 50717 RVA: 0x00454660 File Offset: 0x00452860
	[CompilerGenerated]
	private bool a(zt A_0)
	{
		return this.n.Equals(A_0.Tag as string);
	}

	// Token: 0x040048B3 RID: 18611
	private new string a = egg.b;

	// Token: 0x040048B4 RID: 18612
	private new string b = egg.b;

	// Token: 0x040048B5 RID: 18613
	private new string c = egg.b;

	// Token: 0x040048B6 RID: 18614
	private new int d = 6;

	// Token: 0x040048B7 RID: 18615
	private new int e = 35;

	// Token: 0x040048B8 RID: 18616
	private new int f;

	// Token: 0x040048B9 RID: 18617
	private new int g = 10;

	// Token: 0x040048BA RID: 18618
	private int h = 20;

	// Token: 0x040048BB RID: 18619
	private avo i;

	// Token: 0x040048BC RID: 18620
	private new avo j;

	// Token: 0x040048BD RID: 18621
	private new List<zt> k = new List<zt>();

	// Token: 0x040048BE RID: 18622
	private new eyp l;

	// Token: 0x040048BF RID: 18623
	private new string m;

	// Token: 0x040048C0 RID: 18624
	private string n;

	// Token: 0x040048C1 RID: 18625
	private double o;

	// Token: 0x040048C2 RID: 18626
	private string p;

	// Token: 0x040048C3 RID: 18627
	private euz q;
}
