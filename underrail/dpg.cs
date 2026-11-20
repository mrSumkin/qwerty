using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02002073 RID: 8307
public class dpg : euz
{
	// Token: 0x0600C646 RID: 50758 RVA: 0x00456368 File Offset: 0x00454568
	public esj q()
	{
		return this.a;
	}

	// Token: 0x0600C647 RID: 50759 RVA: 0x00456370 File Offset: 0x00454570
	public void b(esj A_0)
	{
		if (esj.c(this.a, A_0))
		{
			this.a = A_0;
			this.a();
		}
	}

	// Token: 0x0600C648 RID: 50760 RVA: 0x00456390 File Offset: 0x00454590
	public esj p()
	{
		return this.b;
	}

	// Token: 0x0600C649 RID: 50761 RVA: 0x00456398 File Offset: 0x00454598
	public void a(esj A_0)
	{
		if (esj.c(this.b, A_0))
		{
			this.b = A_0;
		}
	}

	// Token: 0x0600C64A RID: 50762 RVA: 0x004563B4 File Offset: 0x004545B4
	public int f()
	{
		return this.c;
	}

	// Token: 0x0600C64B RID: 50763 RVA: 0x004563BC File Offset: 0x004545BC
	public void a(int A_0)
	{
		if (this.c != A_0)
		{
			this.c = A_0;
			this.a();
		}
	}

	// Token: 0x0600C64C RID: 50764 RVA: 0x004563D8 File Offset: 0x004545D8
	public Point k()
	{
		return this.g;
	}

	// Token: 0x0600C64D RID: 50765 RVA: 0x004563E0 File Offset: 0x004545E0
	public void a(Point A_0)
	{
		if (this.g != A_0)
		{
			this.g = A_0;
			this.a();
		}
	}

	// Token: 0x0600C64E RID: 50766 RVA: 0x00456400 File Offset: 0x00454600
	public string l()
	{
		return this.d;
	}

	// Token: 0x0600C64F RID: 50767 RVA: 0x00456408 File Offset: 0x00454608
	public void b(string A_0)
	{
		if (this.d != A_0)
		{
			this.d = A_0;
			this.a();
		}
	}

	// Token: 0x0600C650 RID: 50768 RVA: 0x00456428 File Offset: 0x00454628
	public Point c()
	{
		return this.e;
	}

	// Token: 0x0600C651 RID: 50769 RVA: 0x00456430 File Offset: 0x00454630
	public void b(Point A_0)
	{
		if (this.e != A_0)
		{
			this.e = A_0;
			this.a();
		}
	}

	// Token: 0x0600C652 RID: 50770 RVA: 0x00456450 File Offset: 0x00454650
	public esj? e()
	{
		return this.f;
	}

	// Token: 0x0600C653 RID: 50771 RVA: 0x0045645C File Offset: 0x0045465C
	public void a(esj? A_0)
	{
		esj? esj = this.f;
		esj? esj2 = A_0;
		if (esj != null != (esj2 != null) || (esj != null && esj.c(esj.GetValueOrDefault(), esj2.GetValueOrDefault())))
		{
			this.f = A_0;
			this.a();
		}
	}

	// Token: 0x0600C654 RID: 50772 RVA: 0x004564C4 File Offset: 0x004546C4
	public string i()
	{
		return this.h;
	}

	// Token: 0x0600C655 RID: 50773 RVA: 0x004564CC File Offset: 0x004546CC
	public void a(string A_0)
	{
		if (this.h != A_0)
		{
			this.h = A_0;
			this.a();
		}
	}

	// Token: 0x0600C656 RID: 50774 RVA: 0x004564EC File Offset: 0x004546EC
	public Color o()
	{
		return this.i;
	}

	// Token: 0x0600C657 RID: 50775 RVA: 0x004564F4 File Offset: 0x004546F4
	public void a(Color A_0)
	{
		if (this.i != A_0)
		{
			this.i = A_0;
			this.a();
		}
	}

	// Token: 0x0600C658 RID: 50776 RVA: 0x00456514 File Offset: 0x00454714
	public Color j()
	{
		return this.j;
	}

	// Token: 0x0600C659 RID: 50777 RVA: 0x0045651C File Offset: 0x0045471C
	public void d(Color A_0)
	{
		this.j = A_0;
	}

	// Token: 0x0600C65A RID: 50778 RVA: 0x00456528 File Offset: 0x00454728
	public Color g()
	{
		return this.k;
	}

	// Token: 0x0600C65B RID: 50779 RVA: 0x00456530 File Offset: 0x00454730
	public void b(Color A_0)
	{
		this.k = A_0;
	}

	// Token: 0x0600C65C RID: 50780 RVA: 0x0045653C File Offset: 0x0045473C
	public Color h()
	{
		return this.l;
	}

	// Token: 0x0600C65D RID: 50781 RVA: 0x00456544 File Offset: 0x00454744
	public void c(Color A_0)
	{
		this.l = A_0;
	}

	// Token: 0x0600C65E RID: 50782 RVA: 0x00456550 File Offset: 0x00454750
	public ezc n()
	{
		return this.q;
	}

	// Token: 0x0600C65F RID: 50783 RVA: 0x00456558 File Offset: 0x00454758
	public cvh m()
	{
		return this.r;
	}

	// Token: 0x0600C660 RID: 50784 RVA: 0x00456560 File Offset: 0x00454760
	public void e(cvh A_0)
	{
		this.a(A_0);
	}

	// Token: 0x0600C661 RID: 50785 RVA: 0x0045656C File Offset: 0x0045476C
	public bool d()
	{
		return this.s;
	}

	// Token: 0x0600C662 RID: 50786 RVA: 0x00456574 File Offset: 0x00454774
	public void a(bool A_0)
	{
		this.s = A_0;
		this.a();
	}

	// Token: 0x0600C663 RID: 50787 RVA: 0x00456588 File Offset: 0x00454788
	public dpg()
	{
		this.q = new ezc(this);
		this.q.f(new EventHandler<ListChangedEventArgs>(this.c));
		this.q.c(new EventHandler<ListChangedEventArgs>(this.b));
		this.q.a(new EventHandler(this.a));
		this.q.b(new EventHandler<ListChangedEventArgs>(this.a));
	}

	// Token: 0x0600C664 RID: 50788 RVA: 0x0045668C File Offset: 0x0045488C
	protected void c(object A_0, ListChangedEventArgs A_1)
	{
		cvh a_ = A_0 as cvh;
		this.d(a_);
		this.a();
	}

	// Token: 0x0600C665 RID: 50789 RVA: 0x004566B0 File Offset: 0x004548B0
	protected void b(object A_0, ListChangedEventArgs A_1)
	{
		cvh a_ = A_0 as cvh;
		this.b(a_);
		this.a();
	}

	// Token: 0x0600C666 RID: 50790 RVA: 0x004566D4 File Offset: 0x004548D4
	protected void a(object A_0, EventArgs A_1)
	{
		foreach (cvh a_ in Enumerable.ToList<cvh>(Enumerable.OfType<cvh>(base.Controls)))
		{
			this.b(a_);
		}
	}

	// Token: 0x0600C667 RID: 50791 RVA: 0x00456738 File Offset: 0x00454938
	protected void a(object A_0, ListChangedEventArgs A_1)
	{
	}

	// Token: 0x0600C668 RID: 50792 RVA: 0x0045673C File Offset: 0x0045493C
	protected void a(object A_0, b25 A_1)
	{
		dak dak = A_0 as dak;
		this.a(dak.Tag as cvh);
	}

	// Token: 0x0600C669 RID: 50793 RVA: 0x00456764 File Offset: 0x00454964
	public override void iv(e6d A_0, cp9 A_1)
	{
		this.b();
		cne cne = dr3.a();
		if (cne != null && !string.IsNullOrEmpty(this.n))
		{
			Texture2D resource = cne.GetResource<Texture2D>(this.n, null);
			if (resource != null)
			{
				Point point = base.at();
				esj a_;
				if (this.p != null)
				{
					a_ = this.p.Value;
				}
				else
				{
					a_ = c4o.a(resource, 3, 3);
				}
				c4o.b(A_1, resource, a_, Point.Zero, new Rectangle(point.X, point.Y + this.a.d - this.b.d + this.c, base.Size.c, base.Size.d - this.a.d + this.b.d - this.c), base.Color, true, new Point?(this.o));
			}
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x0600C66A RID: 50794 RVA: 0x00456874 File Offset: 0x00454A74
	public override void ag5(e6d A_0)
	{
		this.b();
		base.ag5(A_0);
	}

	// Token: 0x0600C66B RID: 50795 RVA: 0x00456884 File Offset: 0x00454A84
	public override bool aox(euz A_0)
	{
		if (A_0.IsPrivateComponent)
		{
			return base.aox(A_0);
		}
		if (this.r == null)
		{
			this.b();
		}
		if (this.r != null)
		{
			this.r.aox(A_0);
			return true;
		}
		return false;
	}

	// Token: 0x0600C66C RID: 50796 RVA: 0x004568D0 File Offset: 0x00454AD0
	public override void aoy()
	{
		this.a();
	}

	// Token: 0x0600C66D RID: 50797 RVA: 0x004568D8 File Offset: 0x00454AD8
	private void d(cvh A_0)
	{
		dak dak = new dak();
		dak.p(new EventHandler<b25>(this.a));
		dak.Tag = A_0;
		dak.IsPrivateComponent = true;
		e4z.a(dak);
		this.aox(dak);
		A_0.y(new EventHandler<c1>(this.a));
		A_0.IsPrivateComponent = true;
		this.aox(A_0);
		this.c(A_0);
	}

	// Token: 0x0600C66E RID: 50798 RVA: 0x00456944 File Offset: 0x00454B44
	private void a(object A_0, c1 A_1)
	{
		this.c(A_0 as cvh);
	}

	// Token: 0x0600C66F RID: 50799 RVA: 0x00456954 File Offset: 0x00454B54
	private void c(cvh A_0)
	{
		dpg.b b = new dpg.b();
		b.a = A_0;
		wj wj = wj.a();
		b.a.IsPrivateComponent = true;
		if (wj.c())
		{
			b.a.Location = new Point(0, this.a.d + this.c);
			b.a.Size = new esj(base.Size.c, base.Size.d - this.a.d - this.c);
		}
		else
		{
			b.a.Location = new Point(0, this.a.d + this.c - this.p().d);
			b.a.Size = new esj(base.Size.c, base.Size.d - b.a.Location.Y);
		}
		b.a.Visible = (b.a == this.r);
		int num = this.q.IndexOf(b.a);
		dak dak = Enumerable.FirstOrDefault<dak>(Enumerable.Where<dak>(Enumerable.OfType<dak>(base.Controls), new Func<dak, bool>(b.a)));
		if (dak != null)
		{
			dak.Enabled = b.a.Enabled;
			if (this.d())
			{
				dak.Visible = dak.Enabled;
			}
			else
			{
				dak.Visible = true;
			}
			dak.Checked = (b.a == this.r);
			dak.Location = new Point((this.a.c - this.b.c) * num, dak.Checked ? 0 : this.c);
			dak.Size = esj.a(this.a, dak.Checked ? new esj(0, this.c) : esj.a());
			dak.d = this.d;
			dak.f = this.e;
			dak.e = this.f;
			dak.Font = this.h;
			dak.TextLabelOffset = this.g;
			dak.k = this.i;
			dak.Color = this.i;
			dak.l = this.i;
			dak.g = this.j;
			dak.i = this.k;
			dak.h = this.l;
			dak.j = this.m;
			dak.IsPrivateComponent = true;
			dak.Text = b.a.Text;
		}
	}

	// Token: 0x0600C670 RID: 50800 RVA: 0x00456C00 File Offset: 0x00454E00
	private void b(cvh A_0)
	{
		dpg.a a = new dpg.a();
		a.a = A_0;
		a.a.t(new EventHandler<c1>(this.a));
		this.g(a.a);
		dak dak = Enumerable.FirstOrDefault<dak>(Enumerable.Where<dak>(Enumerable.OfType<dak>(base.Controls), new Func<dak, bool>(a.a)));
		if (dak != null)
		{
			dak.h(new EventHandler<b25>(this.a));
			this.g(dak);
		}
	}

	// Token: 0x0600C671 RID: 50801 RVA: 0x00456C80 File Offset: 0x00454E80
	private void a(cvh A_0)
	{
		if (base.Controls.Contains(A_0))
		{
			this.r = A_0;
			this.a();
		}
	}

	// Token: 0x0600C672 RID: 50802 RVA: 0x00456CA0 File Offset: 0x00454EA0
	private void b()
	{
		if (this.r == null || !base.Controls.Contains(this.r))
		{
			this.a(Enumerable.FirstOrDefault<cvh>(Enumerable.OfType<cvh>(base.Controls)));
		}
	}

	// Token: 0x0600C673 RID: 50803 RVA: 0x00456CDC File Offset: 0x00454EDC
	private void a()
	{
		foreach (cvh a_ in Enumerable.OfType<cvh>(base.Controls))
		{
			this.c(a_);
		}
	}

	// Token: 0x040048DE RID: 18654
	private new esj a = new esj(120, 40);

	// Token: 0x040048DF RID: 18655
	private new esj b = new esj(2, 2);

	// Token: 0x040048E0 RID: 18656
	private new int c = 5;

	// Token: 0x040048E1 RID: 18657
	private new string d = bo1.y;

	// Token: 0x040048E2 RID: 18658
	private new Point e;

	// Token: 0x040048E3 RID: 18659
	private new esj? f;

	// Token: 0x040048E4 RID: 18660
	private new Point g = new Point(0, 6);

	// Token: 0x040048E5 RID: 18661
	private string h = egg.b;

	// Token: 0x040048E6 RID: 18662
	private Color i = Color.White;

	// Token: 0x040048E7 RID: 18663
	private new Color j = adi.a;

	// Token: 0x040048E8 RID: 18664
	private new Color k = Color.White;

	// Token: 0x040048E9 RID: 18665
	private new Color l = Color.White;

	// Token: 0x040048EA RID: 18666
	private new Color m = adi.b;

	// Token: 0x040048EB RID: 18667
	public string n = bo1.m;

	// Token: 0x040048EC RID: 18668
	public Point o;

	// Token: 0x040048ED RID: 18669
	public esj? p;

	// Token: 0x040048EE RID: 18670
	private ezc q;

	// Token: 0x040048EF RID: 18671
	private cvh r;

	// Token: 0x040048F0 RID: 18672
	private bool s;

	// Token: 0x02002074 RID: 8308
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x0600C675 RID: 50805 RVA: 0x00456D40 File Offset: 0x00454F40
		internal bool a(dak A_0)
		{
			return A_0.IsPrivateComponent && A_0.Tag == this.a;
		}

		// Token: 0x040048F1 RID: 18673
		public cvh a;
	}

	// Token: 0x02002075 RID: 8309
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x0600C677 RID: 50807 RVA: 0x00456D68 File Offset: 0x00454F68
		internal bool a(dak A_0)
		{
			return A_0.IsPrivateComponent && A_0.Tag == this.a;
		}

		// Token: 0x040048F2 RID: 18674
		public cvh a;
	}
}
