using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TimelapseVertigo.Common;
using TimelapseVertigo.Common.Settings;

// Token: 0x02001FE8 RID: 8168
public sealed class a0c : cao, amj
{
	// Token: 0x0600BFE2 RID: 49122 RVA: 0x00428574 File Offset: 0x00426774
	public a0c(abf A_0, bsq A_1 = null)
	{
		czh.a(A_0, "library");
		this.l = A_0;
		this.j = A_1;
		wj wj = wj.a();
		if (wj.c())
		{
			this.b = a0c.a;
			this.c = bj8.a;
			this.e = bo1.bt;
			this.f = new Rectangle(0, 0, 41, 41);
			this.g = new Rectangle(123, 0, 41, 41);
			this.h = new Rectangle(164, 0, 41, 41);
		}
		else
		{
			this.b = wj.ez;
			this.c = wj.o;
			this.e = wj.f;
			this.f = new Rectangle(wj.ey.X, wj.ey.Y, wj.ez.c, wj.ez.d);
			this.g = new Rectangle(wj.ey.X + 3 * wj.ez.c, wj.ey.Y, wj.ez.c, wj.ez.d);
			this.h = new Rectangle(wj.ey.X + 4 * wj.ez.c, wj.ey.Y, wj.ez.c, wj.ez.d);
		}
		this.d = new Point((this.b.c - this.c.c) / 2, (this.b.d - this.c.d) / 2);
		base.Size = this.b;
	}

	// Token: 0x0600BFE3 RID: 49123 RVA: 0x00428740 File Offset: 0x00426940
	public override void iv(e6d A_0, cp9 A_1)
	{
		Point point = base.at();
		Vector2 a_ = point.b();
		Texture2D texture2D = A_1.a.us(this.e, null);
		if (texture2D != null)
		{
			A_1.b().w5(texture2D, a_, new Rectangle?(this.f), Color.DarkGray * 0.7f);
		}
		if (!string.IsNullOrEmpty(this.i))
		{
			c3n c3n = dgk.a(this.i);
			c7i c7i = c3n as c7i;
			if (c3n != null && c7i != null)
			{
				string text = c3n.bm(null);
				if (!string.IsNullOrEmpty(text))
				{
					c3i c3i = ejh.b(text, A_1.a);
					if (c3i != null)
					{
						Rectangle a_2 = new Rectangle(point.X + this.d.X, point.Y + this.d.Y, this.c.c, this.c.d);
						c3i.a(A_1, a_2, Color.White, 0, null);
					}
				}
			}
			if (this.l.d.b(this.i))
			{
				A_1.b().w5(texture2D, a_, new Rectangle?(this.g), adi.ak[c7i.School]);
			}
			if (this.m != null)
			{
				A_1.b().w5(texture2D, a_, new Rectangle?(this.h), this.m.Value * 0.5f);
			}
		}
		if (this.k != null)
		{
			this.k.a(A_0);
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x0600BFE4 RID: 49124 RVA: 0x00428900 File Offset: 0x00426B00
	public ecs yf(euz A_0)
	{
		if (!string.IsNullOrEmpty(this.i))
		{
			c3n c3n = dgk.a(this.i);
			if (c3n != null)
			{
				return cq4.a(ecf.a(c3n, new dsx(), null), null, false);
			}
		}
		return null;
	}

	// Token: 0x0600BFE5 RID: 49125 RVA: 0x00428944 File Offset: 0x00426B44
	public override void ag5(e6d A_0)
	{
		if (this.k == null)
		{
			this.k = bd1.a(this, this, (this.j != null) ? this.j.s2() : null);
		}
		this.a();
		base.ag5(A_0);
	}

	// Token: 0x0600BFE6 RID: 49126 RVA: 0x0042899C File Offset: 0x00426B9C
	protected override void ik(object A_0, b25 A_1)
	{
		base.ik(A_0, A_1);
		this.k.b();
	}

	// Token: 0x0600BFE7 RID: 49127 RVA: 0x004289B4 File Offset: 0x00426BB4
	protected override void nr(object A_0, b25 A_1)
	{
		base.nr(A_0, A_1);
		this.k.b();
	}

	// Token: 0x0600BFE8 RID: 49128 RVA: 0x004289CC File Offset: 0x00426BCC
	protected override void vu(object A_0, b25 A_1)
	{
		base.vu(A_0, A_1);
		this.m = null;
	}

	// Token: 0x0600BFE9 RID: 49129 RVA: 0x004289E4 File Offset: 0x00426BE4
	protected override void vt(object A_0, b25 A_1)
	{
		base.vt(A_0, A_1);
		if (!string.IsNullOrEmpty(this.i))
		{
			if (this.l.d.b(this.i))
			{
				c7i c7i = dgk.a(this.i) as c7i;
				if (c7i != null)
				{
					this.m = new Color?(adi.ak[c7i.School]);
					return;
				}
			}
			else if (this.l.d.d(this.i))
			{
				c7i c7i2 = dgk.a(this.i) as c7i;
				if (c7i2 != null)
				{
					this.m = new Color?(adi.ak[c7i2.School]);
					return;
				}
			}
			else
			{
				this.m = new Color?(Color.Red);
			}
		}
	}

	// Token: 0x0600BFEA RID: 49130 RVA: 0x00428AB8 File Offset: 0x00426CB8
	protected override void lq(object A_0, b25 A_1)
	{
		base.lq(A_0, A_1);
		if (!string.IsNullOrEmpty(this.i))
		{
			e4z.a();
			if (this.l.d.b(this.i))
			{
				this.l.d.c(this.i);
				return;
			}
			this.l.d.a(this.i);
		}
	}

	// Token: 0x0600BFEB RID: 49131 RVA: 0x00428B2C File Offset: 0x00426D2C
	protected override void ns(object A_0, b25 A_1)
	{
		base.ns(A_0, A_1);
		if (base.Pressed && this.i != null && base.PressedDuration >= wj.b)
		{
			chr service = bpo.GetService<chr>();
			if (service != null && service.ax() == null)
			{
				e08 a_ = new e08(this, new ejq
				{
					a = this.i
				}, TimelapseCursor.PsiBookItemDrag.ToString());
				service.az(a_);
				base.Pressed = false;
				e4z.d();
			}
		}
	}

	// Token: 0x0600BFEC RID: 49132 RVA: 0x00428BBC File Offset: 0x00426DBC
	private void a()
	{
		if (this.k != null)
		{
			cnk cnk = ces.b();
			int a_;
			if (cnk.aq1().b().g() == InterfaceElementSize2.Huge)
			{
				a_ = (int)((double)djp.b * 2.5);
			}
			else if (cnk.aq1().b().g() == InterfaceElementSize2.ExtraLarge)
			{
				a_ = djp.b * 2;
			}
			else if (cnk.aq1().b().g() == InterfaceElementSize2.Large)
			{
				a_ = (int)((double)djp.b * 1.5);
			}
			else
			{
				a_ = djp.b;
			}
			this.k.a(a_);
		}
	}

	// Token: 0x0400453A RID: 17722
	public new static readonly esj a = new esj(41, 41);

	// Token: 0x0400453B RID: 17723
	public new esj b;

	// Token: 0x0400453C RID: 17724
	public new esj c;

	// Token: 0x0400453D RID: 17725
	private new Point d;

	// Token: 0x0400453E RID: 17726
	private new string e;

	// Token: 0x0400453F RID: 17727
	private new Rectangle f;

	// Token: 0x04004540 RID: 17728
	private new Rectangle g;

	// Token: 0x04004541 RID: 17729
	private Rectangle h;

	// Token: 0x04004542 RID: 17730
	public string i;

	// Token: 0x04004543 RID: 17731
	private new bsq j;

	// Token: 0x04004544 RID: 17732
	private new dsy k;

	// Token: 0x04004545 RID: 17733
	private new abf l;

	// Token: 0x04004546 RID: 17734
	private new Color? m;
}
