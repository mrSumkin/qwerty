using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200207B RID: 8315
internal sealed class e44 : bvr
{
	// Token: 0x0600C692 RID: 50834 RVA: 0x0045825C File Offset: 0x0045645C
	public e44(e3q A_0, a9m A_1) : base(A_0, A_1)
	{
		czh.a(A_0, "character");
		this.a(A_0);
		this.a();
		A_0.Portrait = this.c.e();
	}

	// Token: 0x0600C693 RID: 50835 RVA: 0x0045829C File Offset: 0x0045649C
	protected override void ik(object A_0, b25 A_1)
	{
		base.ik(A_0, A_1);
		this.b.e = null;
		this.b.a(null);
	}

	// Token: 0x0600C694 RID: 50836 RVA: 0x004582C0 File Offset: 0x004564C0
	private void a(object A_0, b25 A_1)
	{
		if (dm9.f && (A_0 as c3p).j() is axr)
		{
			this.b.e = "2";
		}
		else
		{
			this.b.e = null;
		}
		this.b.a(((A_0 as c3p).j() as to).Name);
	}

	// Token: 0x0600C695 RID: 50837 RVA: 0x00458330 File Offset: 0x00456530
	private void b(object A_0, c1 A_1)
	{
		this.a();
	}

	// Token: 0x0600C696 RID: 50838 RVA: 0x0045833C File Offset: 0x0045653C
	private void d(object A_0, EventArgs A_1)
	{
		if (!bl9.a(this.h))
		{
			if (string.IsNullOrEmpty(this.h.Text))
			{
				this.h.Text = "";
				base.c().Name = string.Empty;
				return;
			}
			this.h.Text = this.h.Text.Trim();
			base.c().Name = this.h.Text;
		}
	}

	// Token: 0x0600C697 RID: 50839 RVA: 0x004583C0 File Offset: 0x004565C0
	private void c(object A_0, EventArgs A_1)
	{
		if (this.h.Text != null)
		{
			this.h.Text = this.h.Text.Trim();
		}
		bl9.a(this.h, aqo.a, null);
	}

	// Token: 0x0600C698 RID: 50840 RVA: 0x00458410 File Offset: 0x00456610
	private void a(object A_0, c1 A_1)
	{
		base.c().Portrait = (A_1.a() as string);
		base.c().Gender = this.c.f();
	}

	// Token: 0x0600C699 RID: 50841 RVA: 0x0045844C File Offset: 0x0045664C
	public void a()
	{
		if (this.e != null)
		{
			this.e.Visible = (base.d() > a9m.a);
			this.e.Color = ((base.c().g() > 0) ? adi.a : adi.b);
		}
		if (this.f != null)
		{
			this.f.Visible = (base.d() > a9m.a);
			this.f.Color = ((base.c().g() > 0) ? Color.White : adi.b);
			this.f.Text = base.c().g().ToString();
		}
		if (this.d != null)
		{
			this.d.Visible = (base.d() > a9m.a);
		}
	}

	// Token: 0x0600C69A RID: 50842 RVA: 0x0045852C File Offset: 0x0045672C
	protected override void i0()
	{
		base.i0();
		if (base.c() != null)
		{
			base.c().Feats.b(new EventHandler<EventArgs>(this.b));
			base.c().Feats.a(new EventHandler<EventArgs>(this.a));
		}
	}

	// Token: 0x0600C69B RID: 50843 RVA: 0x00458584 File Offset: 0x00456784
	protected override void i1()
	{
		base.i1();
		if (base.c() != null)
		{
			base.c().Feats.c(new EventHandler<EventArgs>(this.b));
			base.c().Feats.d(new EventHandler<EventArgs>(this.a));
		}
	}

	// Token: 0x0600C69C RID: 50844 RVA: 0x004585DC File Offset: 0x004567DC
	private void a(e3q A_0)
	{
		wj wj = wj.a();
		this.c = new dgh();
		this.c.b(A_0.Gender);
		this.c.a(base.d() != a9m.c);
		if (wj.c())
		{
			this.c.Location = new Point(40, 10);
			this.c.Size = new esj(166, 171);
		}
		else
		{
			this.c.Location = new Point(wj.fv.c * 2, wj.fv.d * 2);
		}
		this.c.b(new EventHandler<c1>(this.a));
		if (base.d() != a9m.c)
		{
			this.c.a(base.c().Portrait);
		}
		this.aox(this.c);
		this.h = new c68();
		this.h.j = dh9.c("CharScreen_NamePlaceholder");
		if (!string.IsNullOrEmpty(base.c().Name))
		{
			this.h.Text = base.c().Name;
		}
		this.h.Enabled = (base.d() == a9m.c);
		if (wj.c())
		{
			this.h.Location = new Point(210, 50);
			this.h.e = bo1.b;
			this.h.a(egg.f);
			this.h.Size = new esj(480, 40);
			this.h.a(new Point(30, 8));
			this.h.a(true);
		}
		else
		{
			this.h.Location = new Point(this.c.Location.X + this.c.Size.c + wj.fv.c, this.c.Location.Y + wj.fv.d);
			this.h.e = wj.f;
			this.h.f = wj.fg;
			this.h.g = new esj?(wj.fh);
			this.h.a(wj.ga);
			this.h.Size = wj.f9;
			this.h.a(wj.gb);
			this.h.a(true);
		}
		this.h.k = true;
		this.h.e(new EventHandler(this.c));
		this.h.i(new EventHandler(this.d));
		this.h.a(new Vector2(65f, 1105f));
		for (int i = 91; i <= 96; i++)
		{
			this.h.q().Add((char)i);
		}
		this.h.m().Add(' ');
		this.h.m().Add('-');
		this.h.m().Add('\'');
		bl9.a(this.h);
		this.aox(this.h);
		this.g = new avo();
		this.g.Color = adi.a;
		if (wj.c())
		{
			this.g.a(egg.e);
			this.g.Location = new Point(240, 100);
		}
		else
		{
			this.g.a(wj.gc);
			this.g.Location = new Point(this.h.Location.X + this.h.e().X, this.h.Location.Y + this.h.Size.d + 10);
		}
		this.g.a(true);
		this.g.Text = dh9.c("CharScreen_Level") + " " + base.c().Level.ToString();
		this.aox(this.g);
		Point point;
		int num;
		if (wj.c())
		{
			point = new Point(10, 200);
			num = 40;
		}
		else
		{
			point = new Point(wj.fv.c, this.c.Location.Y + this.c.Size.d + (int)((float)wj.fv.d * 1.5f));
			num = wj.gf.d;
		}
		this.a = new List<c3p>();
		Point point2 = point;
		foreach (to to in base.c().BaseAbilities)
		{
			c3p c3p = new c3p();
			c3p.Location = point2;
			c3p.e(base.d() == a9m.a);
			c3p.d(true);
			c3p.a(base.d() == a9m.a);
			if (base.d() == a9m.c)
			{
				c3p.e(aiy.y);
			}
			else
			{
				c3p.e(to.f());
			}
			if (wj.c())
			{
				c3p.Size = new esj(480, 40);
				if (base.d() == a9m.a)
				{
					c3p.c(new Point(315, 8));
				}
				else
				{
					c3p.c(new Point(330, 8));
				}
				c3p.b(50);
				c3p.a(new Point(370, 8));
				c3p.a(80);
				c3p.b(new Color(255, 255, 255, 255));
				c3p.a(new Color(0, 0, 0, 255));
				c3p.c(390);
				c3p.d = bo1.b;
				c3p.Font = egg.e;
				c3p.TextLabelOffset = new Point(30, 8);
			}
			else
			{
				c3p.Size = wj.gf;
				c3p.TextLabelOffset = wj.gd;
				c3p.b(c3p.Size.c / 11);
				c3p.a((int)((float)c3p.f() * 1.65f));
				c3p.c(c3p.Size.c - wj.gz.c * 3);
				c3p.a(new Point(c3p.l() - c3p.g() - wj.gz.c, c3p.TextLabelOffset.Y));
				c3p.c(new Point(c3p.i().X - c3p.f(), c3p.i().Y));
				if (base.d() != a9m.a)
				{
					c3p.c(c3p.i());
				}
				c3p.d = wj.f;
				c3p.e = wj.fg;
				c3p.f = new esj?(wj.fh);
				c3p.Font = wj.gc;
			}
			BaseAbilityEnum baseAbilityEnum;
			Enum.TryParse<BaseAbilityEnum>(to.Name, true, out baseAbilityEnum);
			c3p.b(new Color(255, 255, 255, 255));
			c3p.a(new Color(0, 0, 0, 255));
			c3p.a = adi.a;
			c3p.c = adi.b;
			c3p.HorizontalAlignment = cab.a;
			c3p.VerticalAlignment = ad4.b;
			c3p.h = new Color(255, 255, 255, 255);
			c3p.Text = dh9.a(baseAbilityEnum);
			c3p.Name = to.Name + "Button";
			c3p.a(to);
			c3p.j(new EventHandler<b25>(this.a));
			c3p.a(new EventHandler<c1>(this.b));
			this.a.Add(c3p);
			this.aox(c3p);
			point2 = new Point(point2.X, point2.Y + num);
		}
		this.d = new cxh();
		if (wj.c())
		{
			this.d.Location = new Point(30, 558);
			this.d.Size = new esj(450, 2);
		}
		else
		{
			this.d.Location = new Point(wj.fv.c, base.Size.d - wj.f3.d - 2 * wj.fv.d);
			this.d.Size = new esj(base.Size.c - 3 * wj.fv.c - (int)(3.2f * (float)wj.f3.c), wj.fx.d);
		}
		this.aox(this.d);
		this.e = new avo();
		this.e.Color = adi.a;
		if (wj.c())
		{
			this.e.a(egg.e);
			this.e.Location = new Point(40, 580);
		}
		else
		{
			this.e.a(wj.gc);
			this.e.Location = new Point(this.d.Location.X, this.d.Location.Y + wj.fv.d);
		}
		this.e.a(true);
		this.e.Text = dh9.c("CharScreen_RemainingPoints");
		this.aox(this.e);
		this.f = new avo();
		if (wj.c())
		{
			this.f.a(egg.e);
			this.f.Location = new Point(300, 580);
			this.f.Size = new esj(70, this.e.Size.d);
		}
		else
		{
			this.f.a(wj.gc);
			this.f.Location = new Point(this.e.Location.X + this.e.Size.c + wj.fv.c, this.e.Location.Y);
			this.f.Size = new esj(3 * wj.fv.c, this.e.Size.d);
		}
		this.f.Color = adi.a;
		this.f.a(cab.c);
		this.aox(this.f);
		this.b = new bex();
		if (wj.c())
		{
			this.b.Location = new Point(520, 170);
			this.b.Size = new esj(410, 390);
		}
		else
		{
			esj esj = new esj(100, (int)((float)base.Size.d * 0.6f));
			wj.a(ref esj.d);
			this.b.Location = new Point(this.d.Location.X + this.d.Size.c + wj.fv.c, this.d.Location.Y - esj.d);
			esj.c = base.Size.c - this.b.Location.X - wj.fv.c;
			this.b.Size = esj;
		}
		this.aox(this.b);
	}

	// Token: 0x0600C69D RID: 50845 RVA: 0x00459270 File Offset: 0x00457470
	private void b(object A_0, EventArgs A_1)
	{
		e44.b b = new e44.b();
		ai8 ai = A_0 as ai8;
		b.a = (ai as bar);
		if (b.a != null)
		{
			c3p c3p = Enumerable.FirstOrDefault<c3p>(Enumerable.Where<c3p>(this.a, new Func<c3p, bool>(b.a)));
			if (c3p != null)
			{
				c3p c3p2 = c3p;
				c3p2.e(c3p2.v() + bar.a);
				c3p.c();
			}
		}
	}

	// Token: 0x0600C69E RID: 50846 RVA: 0x004592DC File Offset: 0x004574DC
	private void a(object A_0, EventArgs A_1)
	{
		e44.a a = new e44.a();
		ai8 ai = A_0 as ai8;
		a.a = (ai as bar);
		if (a.a != null)
		{
			c3p c3p = Enumerable.FirstOrDefault<c3p>(Enumerable.Where<c3p>(this.a, new Func<c3p, bool>(a.a)));
			if (c3p != null)
			{
				c3p c3p2 = c3p;
				c3p2.e(c3p2.v() - bar.a);
				c3p.c();
			}
		}
	}

	// Token: 0x0400491C RID: 18716
	private new List<c3p> a;

	// Token: 0x0400491D RID: 18717
	private new bex b;

	// Token: 0x0400491E RID: 18718
	private new dgh c;

	// Token: 0x0400491F RID: 18719
	private new cxh d;

	// Token: 0x04004920 RID: 18720
	private new avo e;

	// Token: 0x04004921 RID: 18721
	private new avo f;

	// Token: 0x04004922 RID: 18722
	private new avo g;

	// Token: 0x04004923 RID: 18723
	private c68 h;

	// Token: 0x0200207D RID: 8317
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x0600C6A3 RID: 50851 RVA: 0x004593D8 File Offset: 0x004575D8
		internal bool a(c3p A_0)
		{
			return A_0.j().GetType() == this.a.od();
		}

		// Token: 0x04004926 RID: 18726
		public bar a;
	}

	// Token: 0x0200207E RID: 8318
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x0600C6A5 RID: 50853 RVA: 0x00459400 File Offset: 0x00457600
		internal bool a(c3p A_0)
		{
			return A_0.j().GetType() == this.a.od();
		}

		// Token: 0x04004927 RID: 18727
		public bar a;
	}
}
