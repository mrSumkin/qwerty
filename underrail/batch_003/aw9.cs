using System;
using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02002013 RID: 8211
public sealed class aw9 : a03
{
	// Token: 0x0600C214 RID: 49684 RVA: 0x004337E0 File Offset: 0x004319E0
	public override bool et()
	{
		if (!base.IsMousedOver)
		{
			return Enumerable.Any<euz>(base.Controls, new Func<euz, bool>(aw9.a.a.a));
		}
		return true;
	}

	// Token: 0x0600C215 RID: 49685 RVA: 0x0043381C File Offset: 0x00431A1C
	public string f()
	{
		return this.d;
	}

	// Token: 0x0600C216 RID: 49686 RVA: 0x00433824 File Offset: 0x00431A24
	public void a(string A_0)
	{
		if (this.d != A_0)
		{
			this.d = A_0;
			this.d();
		}
	}

	// Token: 0x0600C217 RID: 49687 RVA: 0x00433844 File Offset: 0x00431A44
	public Func<object, bool> g()
	{
		return this.g;
	}

	// Token: 0x0600C218 RID: 49688 RVA: 0x00433850 File Offset: 0x00431A50
	public aw9()
	{
		this.e();
	}

	// Token: 0x0600C219 RID: 49689 RVA: 0x004338A8 File Offset: 0x00431AA8
	public aw9(IEnumerable A_0, Func<object, string> A_1 = null, Func<object, bool> A_2 = null)
	{
		czh.a(A_0, "items");
		this.f = A_1;
		this.g = A_2;
		foreach (object obj in A_0)
		{
			if (this.g == null || this.g(obj))
			{
				base.h().Add(obj);
			}
		}
		this.e();
	}

	// Token: 0x0600C21A RID: 49690 RVA: 0x00433988 File Offset: 0x00431B88
	public void a(IEnumerable A_0, Func<object, bool> A_1 = null)
	{
		this.g = A_1;
		base.h().Clear();
		foreach (object obj in A_0)
		{
			if (this.g == null || this.g(obj))
			{
				base.h().Add(obj);
			}
		}
	}

	// Token: 0x0600C21B RID: 49691 RVA: 0x00433A14 File Offset: 0x00431C14
	public override void iv(e6d A_0, cp9 A_1)
	{
		if (this.b)
		{
			cne cne = dr3.a();
			if (cne != null)
			{
				Point point = base.at();
				wj wj = wj.a();
				if (wj.c())
				{
					Texture2D resource = cne.GetResource<Texture2D>(bo1.w, null);
					if (resource != null)
					{
						esj a_ = c4o.a(resource, 3, 3);
						c4o.b(A_1, resource, a_, Point.Zero, new Rectangle(point.X, point.Y, base.Size.c, base.Size.d), base.Color, true, null);
					}
				}
				else
				{
					Texture2D resource2 = cne.GetResource<Texture2D>(wj.f, null);
					if (resource2 != null)
					{
						c4o.b(A_1, resource2, wj.fn, Point.Zero, new Rectangle(point.X, point.Y, base.Size.c, base.Size.d), base.Color, true, new Point?(wj.fm));
					}
				}
			}
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x0600C21C RID: 49692 RVA: 0x00433B38 File Offset: 0x00431D38
	private void e()
	{
		wj wj = wj.a();
		this.c = base.Size;
		this.a = new dak();
		this.a.Text = "";
		this.a.Size = this.c;
		this.a.Font = this.d;
		if (wj.c())
		{
			this.a.d = bo1.z;
		}
		else
		{
			this.a.d = wj.f;
			this.a.f = wj.e7;
			this.a.e = new esj?(wj.e8);
			this.d = wj.fc;
			this.e = egg.b(this.d) + 1;
		}
		this.a.g = adi.a;
		this.a.h = Color.Black;
		this.a.i = Color.Black;
		this.a.TextLabelOffset = new Point(10, this.e);
		this.a.LabelHorizontalAlignment = cab.a;
		this.a.LabelVerticalAlignment = ad4.b;
		this.a.IsPrivateComponent = true;
		this.a.w = cab.c;
		this.a.x = ad4.b;
		this.a.p(new EventHandler<b25>(this.b));
		e4z.f(this.a);
		this.aox(this.a);
		this.d();
	}

	// Token: 0x0600C21D RID: 49693 RVA: 0x00433CC4 File Offset: 0x00431EC4
	private void d()
	{
		wj wj = wj.a();
		this.e = egg.b(this.d) + 1;
		this.a.Size = this.c;
		this.a.Font = this.d;
		this.a.TextLabelOffset = new Point(10, this.e);
		if (wj.c())
		{
			this.a.r = (this.b ? bo1.bl : bo1.bm);
		}
		else
		{
			this.a.r = wj.f;
			this.a.t = wj.fd;
			this.a.s = new esj?(wj.fe);
			this.a.u = wj.ff;
			this.a.y = true;
			this.a.n = adi.a;
			this.a.p = Color.Black;
			this.a.o = Color.Black;
			if (this.b)
			{
				dak dak = this.a;
				dak.t.X = dak.t.X + wj.fe.c;
			}
		}
		this.a.Text = this.a(base.l());
	}

	// Token: 0x0600C21E RID: 49694 RVA: 0x00433E20 File Offset: 0x00432020
	private void c()
	{
		if (!this.b)
		{
			this.a();
			return;
		}
		this.b();
	}

	// Token: 0x0600C21F RID: 49695 RVA: 0x00433E40 File Offset: 0x00432040
	private void b()
	{
		this.b = false;
		foreach (euz a_ in Enumerable.ToList<zt>(Enumerable.OfType<zt>(base.Controls)))
		{
			this.g(a_);
		}
		base.Size = this.c;
		this.d();
	}

	// Token: 0x0600C220 RID: 49696 RVA: 0x00433EC0 File Offset: 0x004320C0
	private void a()
	{
		wj wj = wj.a();
		this.b = true;
		base.Size = new esj(this.c.c, this.c.d + this.e + base.h().Count * (this.c.d - 2));
		int num = this.c.d + 2;
		for (int i = 0; i < base.h().Count; i++)
		{
			object obj = base.h()[i];
			zt zt = new zt();
			zt.Text = this.a(obj);
			zt.Location = new Point(4, num + (this.c.d - 2) * i);
			zt.Size = new esj(this.c.c - 8, this.c.d - 2);
			zt.Font = this.d;
			if (wj.c())
			{
				zt.d = bo1.ab;
			}
			else
			{
				zt.d = wj.f;
				zt.e = wj.fg;
				zt.f = new esj?(wj.fh);
			}
			zt.TextLabelOffset = new Point(6, this.e);
			zt.a = adi.a;
			zt.c = adi.b;
			zt.b = Color.Black;
			zt.Tag = obj;
			zt.HorizontalAlignment = cab.a;
			zt.VerticalAlignment = ad4.b;
			zt.p(new EventHandler<b25>(this.a));
			zt.Enabled = (this.h == null || this.h(obj));
			e4z.f(zt);
			this.aox(zt);
		}
		this.d();
	}

	// Token: 0x0600C221 RID: 49697 RVA: 0x004340A0 File Offset: 0x004322A0
	private string a(object A_0)
	{
		object obj;
		if (this.f != null)
		{
			obj = this.f(A_0);
		}
		else
		{
			obj = A_0;
		}
		if (obj == null)
		{
			return "";
		}
		if (obj.GetType().IsEnum)
		{
			return obj.ToString().a();
		}
		return obj.ToString();
	}

	// Token: 0x0600C222 RID: 49698 RVA: 0x004340FC File Offset: 0x004322FC
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		if (!this.b)
		{
			this.c = base.Size;
			this.d();
		}
	}

	// Token: 0x0600C223 RID: 49699 RVA: 0x00434124 File Offset: 0x00432324
	protected override void nr(object A_0, b25 A_1)
	{
		base.nr(A_0, A_1);
		if (this.b)
		{
			this.b();
		}
	}

	// Token: 0x0600C224 RID: 49700 RVA: 0x00434140 File Offset: 0x00432340
	protected override void sr(object A_0, a8t A_1)
	{
		base.sr(A_0, A_1);
		if (this.b)
		{
			this.b();
			this.a();
		}
	}

	// Token: 0x0600C225 RID: 49701 RVA: 0x00434164 File Offset: 0x00432364
	protected override void ss(object A_0, a8t A_1)
	{
		base.ss(A_0, A_1);
		if (this.b)
		{
			this.b();
			this.a();
		}
	}

	// Token: 0x0600C226 RID: 49702 RVA: 0x00434188 File Offset: 0x00432388
	protected override void st(object A_0, c1 A_1)
	{
		base.st(A_0, A_1);
		this.d();
	}

	// Token: 0x0600C227 RID: 49703 RVA: 0x00434198 File Offset: 0x00432398
	private void b(object A_0, b25 A_1)
	{
		this.c();
	}

	// Token: 0x0600C228 RID: 49704 RVA: 0x004341A0 File Offset: 0x004323A0
	private void a(object A_0, b25 A_1)
	{
		base.e((A_0 as zt).Tag);
		if (this.b)
		{
			this.b();
		}
	}

	// Token: 0x0400463C RID: 17980
	private new dak a;

	// Token: 0x0400463D RID: 17981
	private new bool b;

	// Token: 0x0400463E RID: 17982
	private new esj c;

	// Token: 0x0400463F RID: 17983
	private new string d = egg.v ? egg.a : egg.aq;

	// Token: 0x04004640 RID: 17984
	private new int e = egg.v ? 6 : egg.b(egg.aq);

	// Token: 0x04004641 RID: 17985
	public new Func<object, string> f;

	// Token: 0x04004642 RID: 17986
	private new Func<object, bool> g;

	// Token: 0x04004643 RID: 17987
	public Func<object, bool> h;

	// Token: 0x02002014 RID: 8212
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600C22B RID: 49707 RVA: 0x004341D8 File Offset: 0x004323D8
		internal bool a(euz A_0)
		{
			return A_0.IsMousedOver;
		}

		// Token: 0x04004644 RID: 17988
		public static readonly aw9.a a = new aw9.a();

		// Token: 0x04004645 RID: 17989
		public static Func<euz, bool> b;
	}
}
