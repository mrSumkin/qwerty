using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02001FE1 RID: 8161
public class aad : cao
{
	// Token: 0x0600BFAD RID: 49069 RVA: 0x00426CF0 File Offset: 0x00424EF0
	public esj i()
	{
		return this.d;
	}

	// Token: 0x0600BFAE RID: 49070 RVA: 0x00426CF8 File Offset: 0x00424EF8
	public void a(esj A_0)
	{
		this.d = A_0;
		this.c();
	}

	// Token: 0x0600BFAF RID: 49071 RVA: 0x00426D08 File Offset: 0x00424F08
	public Point e()
	{
		return this.a;
	}

	// Token: 0x0600BFB0 RID: 49072 RVA: 0x00426D10 File Offset: 0x00424F10
	public void a(Point A_0)
	{
		this.a = A_0;
		this.c();
	}

	// Token: 0x0600BFB1 RID: 49073 RVA: 0x00426D20 File Offset: 0x00424F20
	public bool k()
	{
		return this.e;
	}

	// Token: 0x0600BFB2 RID: 49074 RVA: 0x00426D28 File Offset: 0x00424F28
	public void a(bool A_0)
	{
		this.e = A_0;
		this.j.a(A_0);
		if (this.e)
		{
			this.a();
		}
	}

	// Token: 0x0600BFB3 RID: 49075 RVA: 0x00426D50 File Offset: 0x00424F50
	public string h()
	{
		return this.f;
	}

	// Token: 0x0600BFB4 RID: 49076 RVA: 0x00426D58 File Offset: 0x00424F58
	public void a(string A_0)
	{
		this.f = A_0;
		this.j.a(A_0);
		this.c();
	}

	// Token: 0x0600BFB5 RID: 49077 RVA: 0x00426D74 File Offset: 0x00424F74
	public Color f()
	{
		return this.g;
	}

	// Token: 0x0600BFB6 RID: 49078 RVA: 0x00426D7C File Offset: 0x00424F7C
	public void b(Color A_0)
	{
		this.g = A_0;
	}

	// Token: 0x0600BFB7 RID: 49079 RVA: 0x00426D88 File Offset: 0x00424F88
	public Color g()
	{
		return this.h;
	}

	// Token: 0x0600BFB8 RID: 49080 RVA: 0x00426D90 File Offset: 0x00424F90
	public void a(Color A_0)
	{
		this.h = A_0;
		this.b();
	}

	// Token: 0x0600BFB9 RID: 49081 RVA: 0x00426DA0 File Offset: 0x00424FA0
	public Color j()
	{
		return this.i;
	}

	// Token: 0x0600BFBA RID: 49082 RVA: 0x00426DA8 File Offset: 0x00424FA8
	public void c(Color A_0)
	{
		this.i = A_0;
		this.b();
	}

	// Token: 0x0600BFBB RID: 49083 RVA: 0x00426DB8 File Offset: 0x00424FB8
	public override bool n4()
	{
		return true;
	}

	// Token: 0x0600BFBC RID: 49084 RVA: 0x00426DBC File Offset: 0x00424FBC
	public override void n5(bool A_0)
	{
	}

	// Token: 0x0600BFBD RID: 49085 RVA: 0x00426DC0 File Offset: 0x00424FC0
	public aad()
	{
		this.d();
		this.c();
	}

	// Token: 0x0600BFBE RID: 49086 RVA: 0x00426E14 File Offset: 0x00425014
	private void d()
	{
		wj wj = wj.a();
		this.b = wj.f;
		this.c = wj.g2;
		this.d = wj.g3;
		this.j = new avo();
		this.j.IsPrivateComponent = true;
		this.j.a(this.e);
		this.j.a(cab.a);
		this.j.a(ad4.b);
		this.aox(this.j);
	}

	// Token: 0x0600BFBF RID: 49087 RVA: 0x00426E98 File Offset: 0x00425098
	private void c()
	{
		if (this.e)
		{
			if (!this.a())
			{
				this.b();
				return;
			}
		}
		else
		{
			this.b();
		}
	}

	// Token: 0x0600BFC0 RID: 49088 RVA: 0x00426EC0 File Offset: 0x004250C0
	private void b()
	{
		if (this.j != null)
		{
			if (this.e)
			{
				this.j.Location = new Point(this.i().c + this.a.X, this.a.Y + (base.Size.d - this.j.Size.d) / 2);
			}
			else
			{
				this.j.Location = new Point(this.i().c + this.a.X, this.a.Y);
				this.j.Size = new esj(base.Size.c - (this.i().c + this.a.X), base.Size.d);
			}
			this.j.Color = (this.Enabled ? this.h : this.i);
		}
	}

	// Token: 0x0600BFC1 RID: 49089 RVA: 0x00426FD0 File Offset: 0x004251D0
	private bool a()
	{
		esj a_ = base.Size;
		base.Size = new esj(this.i().c + this.a.X + this.j.Size.c, Math.Max(this.i().d, this.j.Size.d));
		return esj.c(a_, base.Size);
	}

	// Token: 0x0600BFC2 RID: 49090 RVA: 0x00427044 File Offset: 0x00425244
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.b();
	}

	// Token: 0x0600BFC3 RID: 49091 RVA: 0x00427054 File Offset: 0x00425254
	protected override void j5(object A_0, c1 A_1)
	{
		base.j5(A_0, A_1);
		if (this.j != null)
		{
			this.j.Text = base.Text;
		}
		this.c();
	}

	// Token: 0x0600BFC4 RID: 49092 RVA: 0x00427080 File Offset: 0x00425280
	protected override void n6(object A_0, c1 A_1)
	{
		base.n6(A_0, A_1);
		this.b();
	}

	// Token: 0x0600BFC5 RID: 49093 RVA: 0x00427094 File Offset: 0x00425294
	public override void iv(e6d A_0, cp9 A_1)
	{
		if (!string.IsNullOrEmpty(this.b))
		{
			Texture2D texture2D = A_1.a.us(this.b, null);
			if (texture2D != null)
			{
				Point zero = Point.Zero;
				Color white = Color.White;
				if (!this.Enabled)
				{
					white = this.g;
				}
				if (base.Checked)
				{
					zero.Y = 1;
				}
				if (base.Pressed)
				{
					zero.X = 2;
				}
				else if (this.IsMousedOver && this.Enabled)
				{
					zero.X = 1;
				}
				Point point = base.at();
				A_1.b().w5(texture2D, new Vector2((float)point.X, (float)(point.Y + (base.Size.d - this.i().d) / 2)), new Rectangle?(new Rectangle(this.c.X + zero.X * this.i().c, this.c.Y + zero.Y * this.i().d, this.i().c, this.i().d)), white);
			}
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x04004518 RID: 17688
	private new Point a = new Point(5, 0);

	// Token: 0x04004519 RID: 17689
	public new string b;

	// Token: 0x0400451A RID: 17690
	public new Point c;

	// Token: 0x0400451B RID: 17691
	private new esj d;

	// Token: 0x0400451C RID: 17692
	private new bool e = true;

	// Token: 0x0400451D RID: 17693
	private new string f;

	// Token: 0x0400451E RID: 17694
	private new Color g = Color.Gray;

	// Token: 0x0400451F RID: 17695
	private Color h = Color.White;

	// Token: 0x04004520 RID: 17696
	private Color i = Color.Gray;

	// Token: 0x04004521 RID: 17697
	private new avo j;
}
