using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TimelapseVertigo.Common.Settings;

// Token: 0x02001FD8 RID: 8152
public sealed class c8r : euz, aj3
{
	// Token: 0x0600BF66 RID: 48998 RVA: 0x004242F4 File Offset: 0x004224F4
	[CompilerGenerated]
	public azr ajs()
	{
		return this.n;
	}

	// Token: 0x0600BF67 RID: 48999 RVA: 0x004242FC File Offset: 0x004224FC
	[CompilerGenerated]
	public void ajt(azr A_0)
	{
		this.n = A_0;
	}

	// Token: 0x0600BF68 RID: 49000 RVA: 0x00424308 File Offset: 0x00422508
	public override bool wo()
	{
		return false;
	}

	// Token: 0x0600BF69 RID: 49001 RVA: 0x0042430C File Offset: 0x0042250C
	public c8r(aqo A_0, azr A_1 = null)
	{
		this.Focusable = true;
		this.m = A_0;
		this.ajt(A_1);
		this.a();
	}

	// Token: 0x0600BF6A RID: 49002 RVA: 0x00424330 File Offset: 0x00422530
	private void a()
	{
		wj wj = wj.a(UiSize.Small);
		this.a = wj.i3;
		this.b = wj.i4;
		this.c = wj.i5;
		this.d = wj.i6;
		this.e = wj.i7;
		this.f = wj.i8;
		this.g = wj.i9;
		this.h = wj.ja;
		this.i = wj.jb;
		this.j = wj.jc;
		esj esj = esj.a();
		Point point = new Point(this.a, this.a);
		if (this.m == aqo.b)
		{
			this.a(Keys.Escape, ref point, ref esj, false, true, 1f, null, "Esc", false);
			this.a(Keys.Back, ref point, ref esj, false, false, 2f, new Rectangle?(this.d), null, false);
			this.a(ref point);
			this.l = this.a(Keys.D7, ref point, ref esj, false, true, 1f, null, null, false);
			this.a(Keys.D8, ref point, ref esj, false, true, 1f, null, null, false);
			this.a(Keys.D9, ref point, ref esj, false, true, 1f, null, null, false);
			this.a(ref point);
			this.a(Keys.D4, ref point, ref esj, false, true, 1f, null, null, false);
			this.a(Keys.D5, ref point, ref esj, false, true, 1f, null, null, false);
			this.a(Keys.D6, ref point, ref esj, false, true, 1f, null, null, false);
			this.a(ref point);
			this.a(Keys.D1, ref point, ref esj, false, true, 1f, null, null, false);
			this.a(Keys.D2, ref point, ref esj, false, true, 1f, null, null, false);
			this.a(Keys.D3, ref point, ref esj, false, true, 1f, null, null, false);
			this.a(ref point);
			this.a(Keys.D0, ref point, ref esj, false, true, 1f, null, null, false);
			this.a(ref point, ref esj, 2f);
		}
		else
		{
			this.a(Keys.Escape, ref point, ref esj, false, true, 1f, null, "Esc", false);
			this.a(Keys.D1, ref point, ref esj, true, true, 1f, null, null, false);
			this.a(Keys.D2, ref point, ref esj, true, true, 1f, null, null, false);
			this.a(Keys.D3, ref point, ref esj, true, true, 1f, null, null, false);
			this.a(Keys.D4, ref point, ref esj, true, true, 1f, null, null, false);
			this.a(Keys.D5, ref point, ref esj, true, true, 1f, null, null, false);
			this.a(Keys.D6, ref point, ref esj, true, true, 1f, null, null, false);
			this.a(Keys.D7, ref point, ref esj, true, true, 1f, null, null, false);
			this.a(Keys.D8, ref point, ref esj, true, true, 1f, null, null, false);
			this.a(Keys.D9, ref point, ref esj, true, true, 1f, null, null, false);
			this.a(Keys.D0, ref point, ref esj, true, true, 1f, null, null, false);
			this.a(Keys.Subtract, ref point, ref esj, true, true, 1f, null, null, false);
			this.a(Keys.OemPlus, ref point, ref esj, true, true, 1f, null, null, false);
			this.a(ref point);
			this.l = this.a(Keys.Q, ref point, ref esj, false, true, 1f, null, null, true);
			this.a(Keys.W, ref point, ref esj, false, true, 1f, null, null, true);
			this.a(Keys.E, ref point, ref esj, false, true, 1f, null, null, true);
			this.a(Keys.R, ref point, ref esj, false, true, 1f, null, null, true);
			this.a(Keys.T, ref point, ref esj, false, true, 1f, null, null, true);
			this.a(Keys.Y, ref point, ref esj, false, true, 1f, null, null, true);
			this.a(Keys.U, ref point, ref esj, false, true, 1f, null, null, true);
			this.a(Keys.I, ref point, ref esj, false, true, 1f, null, null, true);
			this.a(Keys.O, ref point, ref esj, false, true, 1f, null, null, true);
			this.a(Keys.P, ref point, ref esj, false, true, 1f, null, null, true);
			this.a(Keys.OemOpenBrackets, ref point, ref esj, true, true, 1f, null, null, false);
			this.a(Keys.OemCloseBrackets, ref point, ref esj, true, true, 1f, null, null, false);
			this.a(Keys.OemPipe, ref point, ref esj, true, true, 1f, null, null, false);
			this.a(ref point);
			this.a(Keys.A, ref point, ref esj, false, true, 1f, null, null, true);
			this.a(Keys.S, ref point, ref esj, false, true, 1f, null, null, true);
			this.a(Keys.D, ref point, ref esj, false, true, 1f, null, null, true);
			this.a(Keys.F, ref point, ref esj, false, true, 1f, null, null, true);
			this.a(Keys.G, ref point, ref esj, false, true, 1f, null, null, true);
			this.a(Keys.H, ref point, ref esj, false, true, 1f, null, null, true);
			this.a(Keys.J, ref point, ref esj, false, true, 1f, null, null, true);
			this.a(Keys.K, ref point, ref esj, false, true, 1f, null, null, true);
			this.a(Keys.L, ref point, ref esj, false, true, 1f, null, null, true);
			this.a(Keys.OemSemicolon, ref point, ref esj, true, true, 1f, null, null, false);
			this.a(Keys.OemQuotes, ref point, ref esj, true, true, 1f, null, null, false);
			this.a(ref point, ref esj, 2f);
			this.a(ref point);
			this.a(Keys.Z, ref point, ref esj, false, true, 1f, null, null, true);
			this.a(Keys.X, ref point, ref esj, false, true, 1f, null, null, true);
			this.a(Keys.C, ref point, ref esj, false, true, 1f, null, null, true);
			this.a(Keys.V, ref point, ref esj, false, true, 1f, null, null, true);
			this.a(Keys.B, ref point, ref esj, false, true, 1f, null, null, true);
			this.a(Keys.N, ref point, ref esj, false, true, 1f, null, null, true);
			this.a(Keys.M, ref point, ref esj, false, true, 1f, null, null, true);
			this.a(Keys.OemComma, ref point, ref esj, true, true, 1f, null, null, false);
			this.a(Keys.OemPeriod, ref point, ref esj, true, true, 1f, null, null, false);
			this.a(Keys.OemQuestion, ref point, ref esj, true, true, 1f, null, null, false);
			this.a(Keys.Home, ref point, ref esj, false, true, 1f, null, "Home", false);
			this.a(Keys.Up, ref point, ref esj, false, false, 1f, new Rectangle?(this.j), null, false);
			this.a(Keys.End, ref point, ref esj, false, true, 1f, null, "End", false);
			this.a(ref point);
			this.b(ref point, ref esj, 2f).c(new EventHandler<b25>(this.b));
			this.a(Keys.Space, ref point, ref esj, false, true, 6f, null, null, false);
			this.a(Keys.Back, ref point, ref esj, false, false, 2f, new Rectangle?(this.d), null, false);
			this.a(Keys.Left, ref point, ref esj, false, false, 1f, new Rectangle?(this.g), null, false);
			this.a(Keys.Down, ref point, ref esj, false, false, 1f, new Rectangle?(this.i), null, false);
			this.a(Keys.Right, ref point, ref esj, false, false, 1f, new Rectangle?(this.h), null, false);
		}
		base.Size = new esj(esj.c + this.a - this.b, point.Y + this.c + this.a);
	}

	// Token: 0x0600BF6B RID: 49003 RVA: 0x00424CF4 File Offset: 0x00422EF4
	private void a(ref Point A_0)
	{
		A_0.X = this.a;
		A_0.Y += this.c + this.b;
	}

	// Token: 0x0600BF6C RID: 49004 RVA: 0x00424D1C File Offset: 0x00422F1C
	private cwv a(Keys A_0, ref Point A_1, ref esj A_2, bool A_3 = false, bool A_4 = true, float A_5 = 1f, Rectangle? A_6 = null, string A_7 = null, bool A_8 = false)
	{
		cwv cwv = new cwv(this, A_0, A_3, this.a(A_5), A_7);
		cwv.Location = A_1;
		cwv.IsPrivateComponent = true;
		cwv.g = A_6;
		cwv.i = A_4;
		cwv.c(new EventHandler<b25>(this.c));
		cwv.j = A_8;
		A_1.X += cwv.Size.c + this.b;
		A_2.c = Math.Max(A_2.c, A_1.X);
		this.aox(cwv);
		return cwv;
	}

	// Token: 0x0600BF6D RID: 49005 RVA: 0x00424DB8 File Offset: 0x00422FB8
	private ap3 b(ref Point A_0, ref esj A_1, float A_2)
	{
		ap3 ap = new ap3(this, this.a(A_2));
		ap.Location = A_0;
		ap.IsPrivateComponent = true;
		A_0.X += ap.Size.c + this.b;
		A_1.c = Math.Max(A_1.c, A_0.X);
		this.aox(ap);
		return ap;
	}

	// Token: 0x0600BF6E RID: 49006 RVA: 0x00424E24 File Offset: 0x00423024
	private void a(ref Point A_0, ref esj A_1, float A_2)
	{
		dzb dzb = new dzb(this, this.a(A_2));
		dzb.Location = A_0;
		dzb.IsPrivateComponent = true;
		dzb.c(new EventHandler<b25>(this.a));
		A_0.X += dzb.Size.c + this.b;
		A_1.c = Math.Max(A_1.c, A_0.X);
		this.aox(dzb);
	}

	// Token: 0x0600BF6F RID: 49007 RVA: 0x00424EA0 File Offset: 0x004230A0
	private int a(float A_0)
	{
		return Convert.ToInt32(A_0 * (float)this.c + (A_0 - 1f) * (float)this.b);
	}

	// Token: 0x0600BF70 RID: 49008 RVA: 0x00424EC4 File Offset: 0x004230C4
	private void c(object A_0, b25 A_1)
	{
		cwv cwv = A_0 as cwv;
		if (cwv != null && this.a(cwv.b) && (cwv.a || cwv.j))
		{
			this.k = false;
		}
	}

	// Token: 0x0600BF71 RID: 49009 RVA: 0x00424F0C File Offset: 0x0042310C
	private bool a(Keys A_0)
	{
		if (this.ajs() != null)
		{
			azr azr = this.ajs();
			object a_;
			if (!this.k)
			{
				a_ = null;
			}
			else
			{
				(a_ = new Keys[1])[0] = 160;
			}
			azr.au4(A_0, a_, true);
			return true;
		}
		return false;
	}

	// Token: 0x0600BF72 RID: 49010 RVA: 0x00424F54 File Offset: 0x00423154
	private void b(object A_0, b25 A_1)
	{
		e4z.b();
		this.k = !this.k;
	}

	// Token: 0x0600BF73 RID: 49011 RVA: 0x00424F70 File Offset: 0x00423170
	private void a(object A_0, b25 A_1)
	{
		if (this.ajs() != null)
		{
			euz euz = this.ajs() as euz;
			if (euz != null && euz.Activated)
			{
				this.ajs().au4(Keys.Enter, null, true);
			}
		}
		base.bp();
		bl9.a();
	}

	// Token: 0x0600BF74 RID: 49012 RVA: 0x00424FC0 File Offset: 0x004231C0
	public override void iv(e6d A_0, cp9 A_1)
	{
		wj wj = wj.a();
		if (wj.d != UiSize.Classic)
		{
			Texture2D texture2D = A_1.a.us(wj.f, null);
			if (texture2D != null)
			{
				Point point = base.at();
				c4o.b(A_1, texture2D, wj.dd, Point.Zero, new Rectangle(point.X, point.Y, base.Size.c, base.Size.d), base.Color * 0.85f, true, new Point?(wj.dc));
			}
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x0600BF75 RID: 49013 RVA: 0x00425064 File Offset: 0x00423264
	protected override void h8(object A_0, ane A_1)
	{
		base.h8(A_0, A_1);
		if (A_1.a == Keys.Escape)
		{
			this.a(Keys.Escape);
			base.bp();
			bl9.a();
			return;
		}
		if (A_1.a == Keys.Enter)
		{
			this.a(Keys.Enter);
			return;
		}
		if (A_1.a == Keys.Up)
		{
			this.a(0, -1);
			return;
		}
		if (A_1.a == Keys.Down)
		{
			this.a(0, 1);
			return;
		}
		if (A_1.a == Keys.Left)
		{
			this.a(-1, 0);
			return;
		}
		if (A_1.a == Keys.Right)
		{
			this.a(1, 0);
			return;
		}
		if ((A_1.a == Keys.Space || A_1.a == Keys.A || A_1.a == Keys.F || A_1.a == Keys.R) && this.l != null)
		{
			this.l.a(eoo.b);
		}
	}

	// Token: 0x0600BF76 RID: 49014 RVA: 0x00425158 File Offset: 0x00423358
	private void a(int A_0, int A_1)
	{
		e4z.b();
		if (this.l != null)
		{
			Point point = new Point(this.l.Location.X + this.l.Size.c / 2 + A_0 * (this.l.Size.c / 2 + 10), this.l.Location.Y + this.l.Size.d / 2 + A_1 * (this.l.Size.c / 2 + 10));
			Rectangle rectangle = new Rectangle(point.X - 3, point.Y - 3, 6, 6);
			foreach (euz euz in base.Controls)
			{
				bbd bbd = euz as bbd;
				if (bbd != null && bbd != this.l)
				{
					Rectangle value = new Rectangle(bbd.Location.X, bbd.Location.Y, bbd.Size.c, bbd.Size.d);
					if (rectangle.Intersects(value))
					{
						this.l = bbd;
						break;
					}
				}
			}
		}
	}

	// Token: 0x040044D3 RID: 17619
	private new int a;

	// Token: 0x040044D4 RID: 17620
	private new int b;

	// Token: 0x040044D5 RID: 17621
	private new int c;

	// Token: 0x040044D6 RID: 17622
	public new Rectangle d;

	// Token: 0x040044D7 RID: 17623
	public new Rectangle e;

	// Token: 0x040044D8 RID: 17624
	public new Rectangle f;

	// Token: 0x040044D9 RID: 17625
	public new Rectangle g;

	// Token: 0x040044DA RID: 17626
	public Rectangle h;

	// Token: 0x040044DB RID: 17627
	public Rectangle i;

	// Token: 0x040044DC RID: 17628
	public new Rectangle j;

	// Token: 0x040044DD RID: 17629
	public new bool k;

	// Token: 0x040044DE RID: 17630
	public new bbd l;

	// Token: 0x040044DF RID: 17631
	private new aqo m;

	// Token: 0x040044E0 RID: 17632
	[CompilerGenerated]
	private azr n;
}
