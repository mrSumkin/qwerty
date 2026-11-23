using System;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TimelapseVertigo.Common.Settings;

// Token: 0x02000586 RID: 1414
public sealed class d49 : amm
{
	// Token: 0x060024A3 RID: 9379 RVA: 0x000CED30 File Offset: 0x000CCF30
	public bool e()
	{
		return this.k;
	}

	// Token: 0x060024A4 RID: 9380 RVA: 0x000CED38 File Offset: 0x000CCF38
	public void a(bool A_0)
	{
		this.k = A_0;
	}

	// Token: 0x060024A5 RID: 9381 RVA: 0x000CED44 File Offset: 0x000CCF44
	public bool c()
	{
		return this.l;
	}

	// Token: 0x060024A6 RID: 9382 RVA: 0x000CED4C File Offset: 0x000CCF4C
	public void c(bool A_0)
	{
		this.l = A_0;
	}

	// Token: 0x060024A7 RID: 9383 RVA: 0x000CED58 File Offset: 0x000CCF58
	public bool d()
	{
		return this.j;
	}

	// Token: 0x060024A8 RID: 9384 RVA: 0x000CED60 File Offset: 0x000CCF60
	public void b(bool A_0)
	{
		this.j = A_0;
	}

	// Token: 0x060024A9 RID: 9385 RVA: 0x000CED6C File Offset: 0x000CCF6C
	public d49(bu2 A_0)
	{
		czh.a(A_0, "dialogController");
		this.p = A_0;
		this.b();
		this.a();
		this.Focusable = true;
	}

	// Token: 0x060024AA RID: 9386 RVA: 0x000CEDC8 File Offset: 0x000CCFC8
	public override void iv(e6d A_0, cp9 A_1)
	{
		wj wj = wj.a();
		Point point = base.at();
		if (this.j && A_1.a != null)
		{
			Texture2D resource;
			if (wj.d == UiSize.Classic)
			{
				resource = A_1.a.GetResource<Texture2D>(bo1.ak, null);
			}
			else
			{
				resource = A_1.a.GetResource<Texture2D>(wj.f, null);
			}
			if (resource != null)
			{
				cnk service = bpo.GetService<cnk>();
				float scale;
				if (service != null)
				{
					scale = service.aq1().b().x();
				}
				else
				{
					scale = 0.6f;
				}
				Rectangle a_ = new Rectangle(point.X, point.Y, base.Size.c, base.Size.d);
				if (wj.d == UiSize.Classic)
				{
					c4o.a(A_1, resource, new esj(50, 50), Point.Zero, a_, Color.White * scale, true, null);
				}
				else
				{
					c4o.a(A_1, resource, wj.b0, Point.Zero, a_, Color.White * scale, true, new Point?(wj.bz));
				}
			}
		}
		if (this.q != null)
		{
			this.q.a(new Point(point.X + this.e.X, point.Y + this.e.Y - this.o), A_1, null, 1f);
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x060024AB RID: 9387 RVA: 0x000CEF5C File Offset: 0x000CD15C
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
		if (bpo.GetServiceOrThrow<cnk>().aq1().b().a())
		{
			if (this.p.nt() != null)
			{
				c5x c5x = this.p.nt().ActorEntity as c5x;
				if (c5x != null)
				{
					if (c5x.ad != null)
					{
						this.f.b(c5x.ad.Value);
					}
					else
					{
						this.f.b(c5x.Lightning);
					}
					this.f.a(c5x.Lightning);
					return;
				}
			}
		}
		else
		{
			this.f.b(Color.White);
			this.f.a(Color.White);
		}
	}

	// Token: 0x060024AC RID: 9388 RVA: 0x000CF024 File Offset: 0x000CD224
	private void b()
	{
		wj wj = wj.a();
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		this.a = serviceOrThrow.aq1().b().h();
		esj esj = a2x.a();
		float num = 1f;
		bd8 a_;
		if (serviceOrThrow.aq1().b().n() == InterfaceElementSize2.Huge)
		{
			a_ = bd8.c;
		}
		else if (serviceOrThrow.aq1().b().n() == InterfaceElementSize2.ExtraLarge)
		{
			a_ = bd8.b;
			num = 1.5f;
		}
		else if (serviceOrThrow.aq1().b().n() == InterfaceElementSize2.Large)
		{
			a_ = bd8.b;
		}
		else
		{
			a_ = bd8.a;
		}
		this.f = new apw(a_);
		if (num != 1f)
		{
			apw apw = this.f;
			apw.Size = esj.b(apw.Size, (double)num);
		}
		this.f.a(false);
		this.f.Location = new Point(5, 5);
		this.f.IsPrivateComponent = true;
		this.aox(this.f);
		this.d = (int)((double)esj.d * 0.27);
		this.d += this.f.Size.d - 50;
		int num2 = (int)Math.Max(600.0, (double)esj.c * ((this.a != InterfaceElementSize2.Small) ? 0.7 : 0.45));
		if (wj.d != UiSize.Classic)
		{
			num2 = Math.Min(num2, 1600);
		}
		base.Size = new esj(num2, this.d);
		this.b = base.Size.c - 50;
		this.c = this.b + 15;
		this.e = new Point(10, this.f.Location.Y + this.f.Size.d + 5);
		this.g = new avo();
		this.g.a(cm3.a(this.a));
		this.g.Location = new Point(this.f.Location.X + this.f.Size.c + 5, 5);
		this.g.Size = new esj(400, this.f.Size.d);
		this.g.a(ad4.b);
		this.g.a(cab.a);
		this.g.IsPrivateComponent = true;
		this.aox(this.g);
		this.h = new doz();
		if (wj.d == UiSize.Classic)
		{
			this.h.Size = new esj(25, 25);
			this.h.a(new Point(150, 0));
			this.h.a(bo1.ak);
		}
		else
		{
			this.e.X = (int)(10 + this.a * (InterfaceElementSize2)5);
			this.b = base.Size.c - 2 * this.e.X;
			this.h.Size = wj.b1;
			this.h.a(new Point(wj.bz.X + wj.b0.c * 3, wj.bz.Y));
			this.h.a(wj.f);
		}
		this.h.Location = new Point(base.Size.c - this.h.Size.c, 0);
		this.h.IsPrivateComponent = true;
		this.h.a(c9j.e);
		this.h.c(new EventHandler<b25>(this.b));
		this.h.Visible = this.p.nv();
		this.aox(this.h);
		if (this.m)
		{
			if (wj.d == UiSize.Classic)
			{
				this.i = new se();
			}
			else
			{
				this.i = new c1y();
			}
			if (this.h.Visible)
			{
				this.i.Location = new Point(base.Size.c - wj.bo.c - this.n, this.h.Location.Y + this.h.Size.d + this.n);
			}
			else
			{
				this.i.Location = new Point(base.Size.c - wj.bo.c - this.n, this.n);
			}
			this.i.Size = new esj(wj.bo.c, base.Size.d - this.i.Location.Y - this.n);
			this.i.Visible = false;
			this.i.a(0);
			this.i.e(0);
			this.i.c(esj.d / 10);
			this.i.d(esj.d / 4);
			this.i.IsPrivateComponent = true;
			this.i.f(new EventHandler<c1>(this.a));
			this.aox(this.i);
			this.c -= this.i.Size.c + 3;
		}
	}

	// Token: 0x060024AD RID: 9389 RVA: 0x000CF5D4 File Offset: 0x000CD7D4
	private void a(object A_0, c1 A_1)
	{
		int num = this.i.l();
		if (num != this.o)
		{
			if (this.f != null)
			{
				this.f.Location = new Point(this.f.Location.X, this.f.Location.Y + this.o - num);
			}
			if (this.g != null)
			{
				this.g.Location = new Point(this.g.Location.X, this.g.Location.Y + this.o - num);
			}
			foreach (ejl ejl in Enumerable.ToList<ejl>(Enumerable.OfType<ejl>(base.Controls)))
			{
				ejl.Location = new Point(ejl.Location.X, ejl.Location.Y + this.o - num);
			}
			this.o = num;
		}
	}

	// Token: 0x060024AE RID: 9390 RVA: 0x000CF704 File Offset: 0x000CD904
	private bool a()
	{
		this.i.e(0);
		if (this.p.nt() != null)
		{
			this.f.a(this.p.nt().ActorPortrait);
			this.g.Text = this.p.nt().ActorName;
			this.g.Color = (this.p.nt().ActorColor ?? cm3.c);
		}
		else
		{
			this.f.a(null);
			this.g.Text = "Неизвестно";
			this.g.Color = cm3.c;
		}
		this.q = null;
		ecs ecs = cm3.a(this.a, this.p.nx(), null, null, null, null);
		if (ecs != null)
		{
			ecs ecs2 = Enumerable.FirstOrDefault<ecs>(ecs.a(this.b, 0));
			if (ecs2 != null)
			{
				this.q = ecs2.b();
			}
		}
		int num = this.e.Y + this.q.b.d;
		foreach (ejl a_ in Enumerable.ToList<ejl>(Enumerable.OfType<ejl>(base.Controls)))
		{
			this.g(a_);
		}
		num += 20;
		if (this.p.nw().at7() != null && this.p.nw().at7().d().Count > 0)
		{
			for (int i = 0; i < this.p.nw().at7().d().Count; i++)
			{
				aof aof = this.p.nw().at7().d()[i];
				ejl ejl = new ejl(i + 1, aof.Text, this.c, aof.Answer.d(), aof.Answer.c());
				ejl.Location = new Point(25, num);
				ejl.Tag = i;
				ejl.PropagateMouseScrollEvent = true;
				ejl.c(new EventHandler<b25>(this.a));
				e4z.h(ejl);
				this.aox(ejl);
				num += ejl.Size.d;
			}
		}
		else
		{
			string a_2;
			if (this.p.nw().at7() != null && this.p.nw().at7().e().PossibleNextSteps != null && this.p.nw().at7().e().PossibleNextSteps.Count > 0)
			{
				a_2 = "::Продолжить.::";
			}
			else
			{
				a_2 = "::Завершить диалог.::";
			}
			ejl ejl2 = new ejl(1, a_2, this.c, false, null);
			ejl2.Location = new Point(25, num);
			ejl2.Tag = -1;
			ejl2.c(new EventHandler<b25>(this.a));
			e4z.h(ejl2);
			this.aox(ejl2);
			num += ejl2.Size.d;
		}
		num += 10;
		if (this.i != null)
		{
			esj esj = a2x.a();
			int num2 = 0;
			if (num > esj.d)
			{
				num2 = num - esj.d;
				num = esj.d;
			}
			this.i.Visible = (num2 > 0);
			this.i.a(num2);
			this.i.e(0);
		}
		base.Size = new esj(base.Size.c, Math.Max(this.d, num));
		if (ecs != null && ecs.a != null && ecs.a.Count > 0)
		{
			a7v.a(new Color?(this.g.Color), this.g.Text, ecs);
		}
		if (this.i != null)
		{
			this.i.Size = new esj(this.i.Size.c, base.Size.d - this.i.Location.Y - this.n);
		}
		return false;
	}

	// Token: 0x060024AF RID: 9391 RVA: 0x000CFB98 File Offset: 0x000CDD98
	private void a(int A_0, ecs A_1)
	{
		if (A_0 > -1)
		{
			this.p.nw().aud(A_0);
			if (this.p.nu() != null)
			{
				a7v.a(this.p.nu().ActorColor, this.p.nu().ActorName, A_1);
			}
		}
		else
		{
			this.p.nw().aue();
		}
		this.p.nz();
		if (this.p.nw().at7() != null)
		{
			this.a();
		}
	}

	// Token: 0x060024B0 RID: 9392 RVA: 0x000CFC30 File Offset: 0x000CDE30
	private void b(object A_0, b25 A_1)
	{
		e4z.i();
		base.z();
	}

	// Token: 0x060024B1 RID: 9393 RVA: 0x000CFC40 File Offset: 0x000CDE40
	private void a(object A_0, b25 A_1)
	{
		ejl ejl = A_0 as ejl;
		this.a((int)ejl.Tag, ejl.OriginalText);
	}

	// Token: 0x060024B2 RID: 9394 RVA: 0x000CFC6C File Offset: 0x000CDE6C
	protected override void g6(object A_0, ane A_1)
	{
		base.g6(A_0, A_1);
		if (A_1.a == Keys.C && (A_1.b.Contains(Keys.LeftControl) || A_1.b.Contains(Keys.RightControl)) && this.p != null && !string.IsNullOrEmpty(this.p.nx()))
		{
			bpo.GetServiceOrThrow<bbp>().kw(this.p.nx());
			return;
		}
		if (A_1.a == Keys.Escape && this.p.nv())
		{
			base.z();
			return;
		}
		int num;
		if (A_1.a < Keys.NumPad0)
		{
			num = A_1.a - Keys.D0;
		}
		else
		{
			num = A_1.a - Keys.NumPad0;
		}
		if (num >= 1 && num <= 9)
		{
			foreach (ejl ejl in Enumerable.OfType<ejl>(base.Controls))
			{
				if (ejl.Number == num && ejl.Enabled)
				{
					e4z.b();
					this.a((int)ejl.Tag, ejl.OriginalText);
					break;
				}
			}
		}
	}

	// Token: 0x060024B3 RID: 9395 RVA: 0x000CFDC8 File Offset: 0x000CDFC8
	protected override void it(object A_0, b25 A_1)
	{
		int num = A_1.c() / 120;
		if (this.i != null && this.i.Visible)
		{
			bdl bdl = this.i;
			bdl.e(bdl.l() - num * this.i.m());
		}
	}

	// Token: 0x04001546 RID: 5446
	private new InterfaceElementSize2 a;

	// Token: 0x04001547 RID: 5447
	private new int b;

	// Token: 0x04001548 RID: 5448
	private new int c;

	// Token: 0x04001549 RID: 5449
	private new int d;

	// Token: 0x0400154A RID: 5450
	private new Point e;

	// Token: 0x0400154B RID: 5451
	private new apw f;

	// Token: 0x0400154C RID: 5452
	private new avo g;

	// Token: 0x0400154D RID: 5453
	private doz h;

	// Token: 0x0400154E RID: 5454
	private bdl i;

	// Token: 0x0400154F RID: 5455
	private new bool j = true;

	// Token: 0x04001550 RID: 5456
	private new bool k = true;

	// Token: 0x04001551 RID: 5457
	private new bool l = true;

	// Token: 0x04001552 RID: 5458
	public new bool m = true;

	// Token: 0x04001553 RID: 5459
	private int n = 5;

	// Token: 0x04001554 RID: 5460
	private int o;

	// Token: 0x04001555 RID: 5461
	private bu2 p;

	// Token: 0x04001556 RID: 5462
	private dn3 q;
}
