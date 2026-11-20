using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TimelapseVertigo.Common;
using TimelapseVertigo.Common.Settings;

// Token: 0x02001FE5 RID: 8165
public sealed class et9 : cao, amj
{
	// Token: 0x0600BFCF RID: 49103 RVA: 0x00427990 File Offset: 0x00425B90
	public et9(ax3 A_0, bsq A_1 = null)
	{
		czh.a(A_0, "window");
		this.p = A_0;
		this.n = A_1;
		wj wj = wj.a();
		if (wj.c())
		{
			this.e = new esj(41, 41);
			this.d = bj8.a;
			this.g = bo1.bt;
			this.h = new Rectangle(41, 0, 41, 41);
			this.i = new Rectangle(82, 0, 41, 41);
			this.j = new Rectangle(123, 0, 41, 41);
			this.k = new Rectangle(164, 0, 41, 41);
			this.l = new Rectangle(205, 0, 41, 41);
		}
		else
		{
			this.e = wj.ez;
			this.d = wj.o;
			this.g = wj.f;
			this.h = new Rectangle(wj.ey.X + this.e.c, wj.ey.Y, this.e.c, this.e.d);
			this.i = new Rectangle(wj.ey.X + 2 * this.e.c, wj.ey.Y, this.e.c, this.e.d);
			this.j = new Rectangle(wj.ey.X + 3 * this.e.c, wj.ey.Y, this.e.c, this.e.d);
			this.k = new Rectangle(wj.ey.X + 4 * this.e.c, wj.ey.Y, this.e.c, this.e.d);
			this.l = new Rectangle(wj.ey.X + 5 * this.e.c, wj.ey.Y, this.e.c, this.e.d);
		}
		this.f = new Point((this.e.c - this.d.c) / 2, (this.e.d - this.d.d) / 2);
		base.Size = this.e;
	}

	// Token: 0x0600BFD0 RID: 49104 RVA: 0x00427C1C File Offset: 0x00425E1C
	public override void iv(e6d A_0, cp9 A_1)
	{
		chr service = bpo.GetService<chr>();
		bool flag = false;
		bool flag2 = false;
		if (service != null && service.ax() != null)
		{
			ejq ejq = service.ax().c() as ejq;
			if (ejq != null)
			{
				flag = (this.IsMousedOver && !base.Pressed);
				if (ejq.a == this.p.b[this.m])
				{
					flag2 = true;
				}
			}
		}
		efk efk = ces.c();
		Point point = base.at();
		Vector2 a_ = point.b();
		Texture2D texture2D = A_1.a.us(this.g, null);
		bool flag3 = this.p.c > this.m;
		string text = this.p.b[this.m];
		string text2 = null;
		if (efk != null)
		{
			text2 = efk.Offense.ai[this.m];
		}
		if (texture2D != null)
		{
			A_1.b().w5(texture2D, a_, new Rectangle?(this.k), Color.Black);
			if (text == null && text2 == null)
			{
				if (flag3)
				{
					if (flag)
					{
						A_1.b().w5(texture2D, a_, new Rectangle?(this.h), et9.a);
					}
					else
					{
						A_1.b().w5(texture2D, a_, new Rectangle?(this.h), et9.b);
					}
				}
				else
				{
					A_1.b().w5(texture2D, a_, new Rectangle?(this.i), et9.c);
				}
			}
		}
		Color a_2 = Color.Transparent;
		c3i c3i = null;
		if (!string.IsNullOrEmpty(text))
		{
			c3n c3n = dgk.a(text);
			c7i c7i = c3n as c7i;
			if (c3n != null && c7i != null)
			{
				string text3 = c3n.bm(null);
				if (!string.IsNullOrEmpty(text3))
				{
					c3i = ejh.b(text3, A_1.a);
					if (c3i != null)
					{
						if (flag2)
						{
							a_2 = Color.White * 0.65f;
						}
						else
						{
							a_2 = Color.White;
						}
					}
				}
			}
		}
		else if (text2 != null)
		{
			c3n c3n2 = dgk.a(text2);
			c7i c7i2 = c3n2 as c7i;
			if (c3n2 != null && c7i2 != null)
			{
				string text4 = c3n2.bm(null);
				if (!string.IsNullOrEmpty(text4))
				{
					c3i = ejh.b(text4, A_1.a);
					a_2 = Color.Gray * 0.35f;
				}
			}
		}
		if (c3i != null)
		{
			Rectangle a_3 = new Rectangle(point.X + this.f.X, point.Y + this.f.Y, this.d.c, this.d.d);
			c3i.a(A_1, a_3, a_2, 0, null);
		}
		Color a_4;
		if (text != null)
		{
			c7i c7i3 = dgk.a(text) as c7i;
			if (c7i3 != null)
			{
				a_4 = adi.ak[c7i3.School];
			}
			else
			{
				a_4 = Color.White;
			}
		}
		else if (text2 != null)
		{
			if (flag)
			{
				a_4 = et9.a;
			}
			else
			{
				a_4 = et9.b;
			}
		}
		else if (flag3)
		{
			if (flag)
			{
				a_4 = et9.a;
			}
			else
			{
				a_4 = et9.b;
			}
		}
		else
		{
			a_4 = et9.c;
		}
		if (efk != null && text2 != text)
		{
			A_1.b().w5(texture2D, a_, new Rectangle?(this.l), a_4);
		}
		else
		{
			A_1.b().w5(texture2D, a_, new Rectangle?(this.j), a_4);
		}
		if (this.q != null)
		{
			A_1.b().w5(texture2D, a_, new Rectangle?(this.k), this.q.Value * 0.5f);
		}
		if (this.o != null)
		{
			this.o.a(A_0);
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x0600BFD1 RID: 49105 RVA: 0x00428054 File Offset: 0x00426254
	public ecs yf(euz A_0)
	{
		string text = this.p.b[this.m];
		if (string.IsNullOrEmpty(text))
		{
			return cq4.a(this.m, this.p.c > this.m);
		}
		c3n c3n = dgk.a(text);
		if (c3n != null)
		{
			return cq4.a(ecf.a(c3n, new dsx(), null), null, false);
		}
		return null;
	}

	// Token: 0x0600BFD2 RID: 49106 RVA: 0x004280C4 File Offset: 0x004262C4
	public override void ag5(e6d A_0)
	{
		if (this.o == null)
		{
			this.o = bd1.a(this, this, (this.n != null) ? this.n.s2() : null);
		}
		this.a();
		base.ag5(A_0);
	}

	// Token: 0x0600BFD3 RID: 49107 RVA: 0x0042811C File Offset: 0x0042631C
	protected override void ik(object A_0, b25 A_1)
	{
		base.ik(A_0, A_1);
		this.o.b();
	}

	// Token: 0x0600BFD4 RID: 49108 RVA: 0x00428134 File Offset: 0x00426334
	protected override void nr(object A_0, b25 A_1)
	{
		base.nr(A_0, A_1);
		if (this.o != null)
		{
			this.o.b();
		}
	}

	// Token: 0x0600BFD5 RID: 49109 RVA: 0x00428154 File Offset: 0x00426354
	protected override void vu(object A_0, b25 A_1)
	{
		base.vu(A_0, A_1);
		if (this.o != null)
		{
			this.q = null;
		}
	}

	// Token: 0x0600BFD6 RID: 49110 RVA: 0x00428178 File Offset: 0x00426378
	protected override void vt(object A_0, b25 A_1)
	{
		base.vt(A_0, A_1);
		if (this.p.c > this.m && this.p.b[this.m] != null)
		{
			c7i c7i = dgk.a(this.p.b[this.m]) as c7i;
			if (c7i != null)
			{
				this.q = new Color?(adi.ak[c7i.School]);
			}
			this.q = new Color?(adi.ak[c7i.School]);
		}
	}

	// Token: 0x0600BFD7 RID: 49111 RVA: 0x0042821C File Offset: 0x0042641C
	protected override void lq(object A_0, b25 A_1)
	{
		base.lq(A_0, A_1);
		if (this.p.b[this.m] != null)
		{
			e4z.a();
			this.p.b[this.m] = null;
		}
	}

	// Token: 0x0600BFD8 RID: 49112 RVA: 0x00428268 File Offset: 0x00426468
	protected override void ns(object A_0, b25 A_1)
	{
		base.ns(A_0, A_1);
		if (base.Pressed && this.p.b[this.m] != null && base.PressedDuration >= wj.b)
		{
			chr service = bpo.GetService<chr>();
			if (service != null && service.ax() == null)
			{
				e08 a_ = new e08(this, new ejq
				{
					a = this.p.b[this.m]
				}, TimelapseCursor.PsiBookItemDrag.ToString());
				service.az(a_);
				base.Pressed = false;
				e4z.d();
			}
		}
	}

	// Token: 0x0600BFD9 RID: 49113 RVA: 0x00428318 File Offset: 0x00426518
	public override bool iq(e08 A_0)
	{
		return this.p.c > this.m && A_0 != null && A_0.c() is ejq;
	}

	// Token: 0x0600BFDA RID: 49114 RVA: 0x00428348 File Offset: 0x00426548
	protected override void ag6(object A_0, etu A_1)
	{
		if (A_1.b() != null)
		{
			ejq ejq = A_1.b().c() as ejq;
			if (ejq != null && ejq.a != null)
			{
				e4z.c();
				string text = this.p.b[this.m];
				this.p.b[this.m] = ejq.a;
				for (int i = 0; i < this.p.b.Length; i++)
				{
					if (i != this.m && this.p.b[i] == ejq.a)
					{
						this.p.b[i] = text;
						break;
					}
				}
			}
		}
		base.ag6(A_0, A_1);
	}

	// Token: 0x0600BFDB RID: 49115 RVA: 0x00428424 File Offset: 0x00426624
	protected override void ag7(object A_0, etu A_1)
	{
		base.ag7(A_0, A_1);
		this.p.b[this.m] = null;
	}

	// Token: 0x0600BFDC RID: 49116 RVA: 0x00428448 File Offset: 0x00426648
	private void a()
	{
		if (this.o != null)
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
			this.o.a(a_);
		}
	}

	// Token: 0x04004528 RID: 17704
	private new static readonly Color a = new Color(0, 145, 66);

	// Token: 0x04004529 RID: 17705
	private new static readonly Color b = new Color(0, 110, 50);

	// Token: 0x0400452A RID: 17706
	private new static readonly Color c = new Color(0, 37, 18);

	// Token: 0x0400452B RID: 17707
	private new esj d;

	// Token: 0x0400452C RID: 17708
	private new esj e;

	// Token: 0x0400452D RID: 17709
	private new Point f;

	// Token: 0x0400452E RID: 17710
	private new string g;

	// Token: 0x0400452F RID: 17711
	private Rectangle h;

	// Token: 0x04004530 RID: 17712
	private Rectangle i;

	// Token: 0x04004531 RID: 17713
	private new Rectangle j;

	// Token: 0x04004532 RID: 17714
	private new Rectangle k;

	// Token: 0x04004533 RID: 17715
	private new Rectangle l;

	// Token: 0x04004534 RID: 17716
	public new int m;

	// Token: 0x04004535 RID: 17717
	private bsq n;

	// Token: 0x04004536 RID: 17718
	private dsy o;

	// Token: 0x04004537 RID: 17719
	public ax3 p;

	// Token: 0x04004538 RID: 17720
	private Color? q;
}
