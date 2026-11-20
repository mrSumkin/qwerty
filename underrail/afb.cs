using System;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TimelapseVertigo.Common;
using TimelapseVertigo.UI;

// Token: 0x0200203E RID: 8254
public sealed class afb : ec9
{
	// Token: 0x0600C39D RID: 50077 RVA: 0x0043C4E0 File Offset: 0x0043A6E0
	public afb(ps A_0, bool A_1)
	{
		this.v = A_1;
		this.l = A_0;
		this.e();
	}

	// Token: 0x0600C39E RID: 50078 RVA: 0x0043C578 File Offset: 0x0043A778
	private new void e()
	{
		wj wj = wj.a();
		if (!wj.c())
		{
			this.i = wj.g5;
			this.j = wj.g6;
			this.e = wj.ha;
			this.k = wj.g8;
			this.d = wj.g9;
		}
		if (wj.c())
		{
			base.Size = new esj(600, 520);
			this.c = bo1.r;
		}
		else
		{
			base.Size = wj.g7;
			this.c = wj.f;
			this.e = wj.b8;
			this.d = new esj?(wj.b9);
		}
		this.Focusable = true;
		base.g(new EventHandler<ane>(this.a));
		base.t(new EventHandler<b25>(this.d));
		this.m = new avo();
		this.m.IsPrivateComponent = true;
		this.m.Text = "С М Е Р Т Ь";
		if (wj.c())
		{
			this.m.Location = new Point(this.c + this.a, this.b + 25);
			this.m.a(egg.e);
			this.m.Size = new esj(base.Size.c - 2 * this.a - this.c, 40);
		}
		else
		{
			this.m.Location = new Point(this.b * 4 + this.d.c + this.a, this.b + 25);
			this.m.a(wj.hb);
			this.m.a(true);
		}
		this.m.a(ad4.a);
		this.m.a(cab.a);
		this.m.Color = Color.Red;
		this.aox(this.m);
		this.n = new avo();
		this.n.IsPrivateComponent = true;
		this.n.Text = "Она приходит быстро. Только при тщательной подготовке, правильном принятии решений и некоторой удаче вы можете надеяться на выживание.";
		this.n.a(cab.a);
		this.n.a(ad4.a);
		this.n.Color = adi.a;
		if (wj.c())
		{
			this.n.a(egg.b);
			this.n.Location = new Point(this.m.Location.X, this.m.Location.Y + this.m.Size.d + 4);
			this.n.Size = new esj(base.Size.c - 2 * this.a - 200, 200);
		}
		else
		{
			this.n.a(wj.g5);
			this.n.Location = new Point(this.m.Location.X, this.m.Location.Y + this.m.Size.d + 4);
			this.n.Size = new esj(base.Size.c - this.n.Location.X - 2 * this.a, this.b * 2 + this.d.d - (this.m.Location.Y + this.m.Size.d));
		}
		this.aox(this.n);
		this.f = base.Size.d - (this.n.Location.Y + this.n.Size.d) - 2 * this.b;
		int num = (base.Size.c - 2 * this.b) / 3;
		this.o = this.a("Продолжить", new Point(this.b, base.Size.d - this.e - this.b), num);
		this.o.c(new EventHandler<b25>(this.a));
		this.o.Enabled = this.v;
		this.p = this.a("Загрузить", new Point(this.b + num, base.Size.d - this.e - this.b), num);
		this.p.c(new EventHandler<b25>(this.b));
		this.q = this.a("Выход", new Point(this.b + 2 * num, base.Size.d - this.e - this.b), num);
		this.q.c(new EventHandler<b25>(this.c));
		if (wj.c())
		{
			this.r = new se();
			this.r.Size = new esj(27, this.f - 12);
			this.r.Location = new Point(base.Size.c - 5 - this.r.Size.c, base.Size.d - this.e - 2 * this.b - this.f + 6);
		}
		else
		{
			this.r = new c1y();
			this.r.Size = new esj(wj.bo.c, this.f - 12);
			this.r.Location = new Point(base.Size.c - 5 - this.r.Size.c, base.Size.d - this.e - 2 * this.b - this.f + 6);
		}
		this.r.a(0);
		this.r.e(0);
		this.r.c(1);
		this.r.IsPrivateComponent = true;
		this.r.f(new EventHandler<c1>(this.a));
		this.aox(this.r);
		aha service = bpo.GetService<aha>();
		if (service != null)
		{
			yj yj = service.we(TimelapseTextFeeds.Combat.ToString());
			if (yj != null)
			{
				ecs ecs = new ecs();
				foreach (dl6 dl in yj.a())
				{
					foreach (bph bph in dl.a)
					{
						bph.a = new d22(this.k, bph.a.b);
					}
					ecs.a.Add(dl);
				}
				int a_ = base.Size.c - this.b * 2 - this.h * 2 - this.r.Size.c;
				this.s = Enumerable.FirstOrDefault<ecs>(ecs.a(a_, 0));
				this.u = Math.Max(0, this.s.a.Count - this.g);
				this.r.a(this.u);
				this.r.e(this.u);
				this.d();
			}
		}
	}

	// Token: 0x0600C39F RID: 50079 RVA: 0x0043CD58 File Offset: 0x0043AF58
	private new void d(object A_0, b25 A_1)
	{
		bdl bdl = this.r;
		bdl.e(bdl.l() - this.r.m() * Math.Sign(A_1.c()));
	}

	// Token: 0x0600C3A0 RID: 50080 RVA: 0x0043CD90 File Offset: 0x0043AF90
	private void a(object A_0, c1 A_1)
	{
		this.d();
	}

	// Token: 0x0600C3A1 RID: 50081 RVA: 0x0043CD98 File Offset: 0x0043AF98
	private new void c(object A_0, b25 A_1)
	{
		this.a();
		this.l.ani();
	}

	// Token: 0x0600C3A2 RID: 50082 RVA: 0x0043CDAC File Offset: 0x0043AFAC
	private void b(object A_0, b25 A_1)
	{
		this.a();
		this.c();
	}

	// Token: 0x0600C3A3 RID: 50083 RVA: 0x0043CDBC File Offset: 0x0043AFBC
	private void a(object A_0, b25 A_1)
	{
		this.a();
		this.b();
	}

	// Token: 0x0600C3A4 RID: 50084 RVA: 0x0043CDD0 File Offset: 0x0043AFD0
	private new void d()
	{
		this.u = this.r.l();
		if (this.s != null)
		{
			ecs ecs = new ecs();
			int num = this.u;
			while (num < this.u + this.g && num < this.s.a.Count)
			{
				ecs.a.Add(this.s.a[num]);
				num++;
			}
			this.t = ecs.b();
		}
	}

	// Token: 0x0600C3A5 RID: 50085 RVA: 0x0043CE60 File Offset: 0x0043B060
	private zt a(string A_0, Point A_1, int A_2)
	{
		wj wj = wj.a();
		zt zt = new zt();
		zt.Text = A_0;
		zt.Location = A_1;
		zt.Size = new esj(A_2, this.e);
		zt.Font = this.i;
		zt.TextLabelOffset = new Point(0, this.j);
		zt.HorizontalAlignment = cab.b;
		zt.VerticalAlignment = ad4.b;
		zt.a = adi.a;
		zt.c = adi.b;
		zt.b = Color.White;
		zt.IsPrivateComponent = true;
		if (!wj.c())
		{
			zt.d = wj.f;
			zt.e = wj.fg;
			zt.f = new esj?(wj.fh);
		}
		e4z.j(zt);
		this.aox(zt);
		return zt;
	}

	// Token: 0x0600C3A6 RID: 50086 RVA: 0x0043CF30 File Offset: 0x0043B130
	private void a(object A_0, ane A_1)
	{
		if (A_1.a == Keys.L)
		{
			this.a();
			this.c();
			return;
		}
		if (A_1.a == Keys.R)
		{
			if (this.v)
			{
				this.a();
				this.b();
				return;
			}
		}
		else if (A_1.a == Keys.Escape)
		{
			this.a();
			this.l.ani();
		}
	}

	// Token: 0x0600C3A7 RID: 50087 RVA: 0x0043CF9C File Offset: 0x0043B19C
	private new void c()
	{
		arv arv = new arv(SavedGameManipulationMode.Load, abx.b);
		arv.Gravity = axy.c;
		arv.b();
		arv.a9();
		bpo.GetServiceOrThrow<bcm>().aau().aox(arv);
		arv.a(new EventHandler<el5>(this.a));
	}

	// Token: 0x0600C3A8 RID: 50088 RVA: 0x0043CFE8 File Offset: 0x0043B1E8
	private void b()
	{
		a3r a3r = bpo.GetServiceOrThrow<cnk>().arj();
		if (a3r != null && !ast.a(a3r.GameVersion, a3r.DLCs))
		{
			bpo.GetServiceOrThrow<d4m>().avp(dla.a(TimelapseWorkflows.LoadGameFromLocale, new object[]
			{
				a3r
			}));
		}
	}

	// Token: 0x0600C3A9 RID: 50089 RVA: 0x0043D038 File Offset: 0x0043B238
	private void a()
	{
		base.z();
		bcm service = bpo.GetService<bcm>();
		bpo.GetServiceOrThrow<d1a>().aa4(service.aau());
	}

	// Token: 0x0600C3AA RID: 50090 RVA: 0x0043D064 File Offset: 0x0043B264
	private void a(object A_0, el5 A_1)
	{
		this.l.anj();
	}

	// Token: 0x0600C3AB RID: 50091 RVA: 0x0043D074 File Offset: 0x0043B274
	public override void iv(e6d A_0, cp9 A_1)
	{
		wj wj = wj.a();
		base.iv(A_0, A_1);
		Point point = base.at();
		Texture2D texture2D = A_1.a.us(bo1.by, null);
		if (texture2D != null)
		{
			if (wj.c())
			{
				Rectangle a_ = new Rectangle(point.X + 35, point.Y + 20, this.d.c, this.d.d);
				A_1.b().xa(texture2D, a_, Color.White);
			}
			else
			{
				Rectangle a_2 = new Rectangle(point.X + this.b * 3, point.Y + this.b * 2, this.d.c, this.d.d);
				A_1.b().xa(texture2D, a_2, Color.White);
			}
		}
		Texture2D texture2D2;
		if (wj.c())
		{
			texture2D2 = A_1.a.us(bo1.a2, null);
		}
		else
		{
			texture2D2 = A_1.a.us(wj.f, null);
		}
		if (texture2D2 != null)
		{
			Point value;
			esj b;
			Color a_3;
			Rectangle rectangle;
			if (wj.c())
			{
				value = Point.Zero;
				b = new esj(texture2D2.Width / 3, texture2D2.Height / 3);
				a_3 = Color.White * 0.5f;
				rectangle = new Rectangle(point.X + this.b, point.Y + base.Size.d - this.e - 2 * this.b - this.f, base.Size.c - 2 * this.b - this.r.Size.c, this.f);
			}
			else
			{
				value = wj.b8;
				b = wj.b9;
				a_3 = Color.Black * 0.5f;
				rectangle = new Rectangle(point.X + this.b, point.Y + base.Size.d - this.e - 2 * this.b - this.f, base.Size.c - 2 * this.b - this.r.Size.c, this.f);
			}
			c4o.a(A_1, texture2D2, b, Point.Zero, rectangle, a_3, true, new Point?(value));
			if (this.t != null)
			{
				this.t.a(new Point(rectangle.X + this.h, rectangle.Y + this.h), A_1, null, 1f);
			}
		}
	}

	// Token: 0x04004716 RID: 18198
	private new int a = 20;

	// Token: 0x04004717 RID: 18199
	private new int b = 10;

	// Token: 0x04004718 RID: 18200
	private new int c = 200;

	// Token: 0x04004719 RID: 18201
	private new esj d = new esj(148, 279);

	// Token: 0x0400471A RID: 18202
	private new int e = 35;

	// Token: 0x0400471B RID: 18203
	private new int f = 200;

	// Token: 0x0400471C RID: 18204
	private new int g = 10;

	// Token: 0x0400471D RID: 18205
	private int h = 8;

	// Token: 0x0400471E RID: 18206
	private string i = egg.b;

	// Token: 0x0400471F RID: 18207
	private new int j = 6;

	// Token: 0x04004720 RID: 18208
	private new string k = egg.ad;

	// Token: 0x04004721 RID: 18209
	private new ps l;

	// Token: 0x04004722 RID: 18210
	private new avo m;

	// Token: 0x04004723 RID: 18211
	private avo n;

	// Token: 0x04004724 RID: 18212
	private zt o;

	// Token: 0x04004725 RID: 18213
	private zt p;

	// Token: 0x04004726 RID: 18214
	private zt q;

	// Token: 0x04004727 RID: 18215
	private bdl r;

	// Token: 0x04004728 RID: 18216
	private ecs s;

	// Token: 0x04004729 RID: 18217
	private dn3 t;

	// Token: 0x0400472A RID: 18218
	private int u;

	// Token: 0x0400472B RID: 18219
	private bool v;
}
