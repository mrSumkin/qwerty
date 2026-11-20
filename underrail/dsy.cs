using System;
using Microsoft.Xna.Framework;

// Token: 0x02001FC4 RID: 8132
public sealed class dsy
{
	// Token: 0x0600BF0A RID: 48906 RVA: 0x004217D8 File Offset: 0x0041F9D8
	public bool c()
	{
		return this.j;
	}

	// Token: 0x0600BF0B RID: 48907 RVA: 0x004217E0 File Offset: 0x0041F9E0
	public void a(bool A_0)
	{
		this.j = A_0;
	}

	// Token: 0x0600BF0C RID: 48908 RVA: 0x004217EC File Offset: 0x0041F9EC
	public Rectangle? a()
	{
		return this.e;
	}

	// Token: 0x0600BF0D RID: 48909 RVA: 0x004217F4 File Offset: 0x0041F9F4
	public void a(Rectangle? A_0)
	{
		this.e = A_0;
	}

	// Token: 0x0600BF0E RID: 48910 RVA: 0x00421800 File Offset: 0x0041FA00
	public int d()
	{
		return this.d;
	}

	// Token: 0x0600BF0F RID: 48911 RVA: 0x00421808 File Offset: 0x0041FA08
	public void a(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600BF10 RID: 48912 RVA: 0x00421814 File Offset: 0x0041FA14
	public Point? f()
	{
		return this.f;
	}

	// Token: 0x0600BF11 RID: 48913 RVA: 0x0042181C File Offset: 0x0041FA1C
	public void a(Point? A_0)
	{
		this.f = A_0;
	}

	// Token: 0x0600BF12 RID: 48914 RVA: 0x00421828 File Offset: 0x0041FA28
	public euz e()
	{
		return this.a;
	}

	// Token: 0x0600BF13 RID: 48915 RVA: 0x00421830 File Offset: 0x0041FA30
	public dsy(euz A_0, amj A_1, esj A_2, int A_3, Rectangle? A_4, Point? A_5, int A_6, bool A_7 = false, bool A_8 = false)
	{
		czh.a(A_0, "target");
		czh.a(A_1, "textProvider");
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
		this.e = A_4;
		this.f = A_5;
		this.g = A_6;
		this.k = A_7;
		this.l = A_8;
	}

	// Token: 0x0600BF14 RID: 48916 RVA: 0x004218A0 File Offset: 0x0041FAA0
	public void a(e6d A_0)
	{
		if (this.i != null)
		{
			if (this.g > 0 && (this.h -= A_0.a().ElapsedGameTime.TotalMilliseconds) <= 0.0)
			{
				this.b();
			}
			if (this.i != null)
			{
				this.i.b();
			}
		}
	}

	// Token: 0x0600BF15 RID: 48917 RVA: 0x00421914 File Offset: 0x0041FB14
	public void b()
	{
		b5j b5j = this.i;
		this.i = null;
		if (this.j || this.a.IsMousedOver)
		{
			ecs ecs = this.b.yf(this.a);
			if (ecs != null)
			{
				Rectangle value;
				if (this.e != null)
				{
					value = this.e.Value;
				}
				else
				{
					Point point = this.a.at();
					value = new Rectangle(point.X, point.Y, this.a.Size.c, this.a.Size.d);
				}
				this.i = new b5j(ecs, value, this.c, this.d, this.f, this.k, this.l);
				if (b5j != null)
				{
					this.i.l = b5j.l;
				}
				this.h = (double)this.g;
			}
		}
	}

	// Token: 0x040044A8 RID: 17576
	private euz a;

	// Token: 0x040044A9 RID: 17577
	private amj b;

	// Token: 0x040044AA RID: 17578
	private esj c;

	// Token: 0x040044AB RID: 17579
	private int d;

	// Token: 0x040044AC RID: 17580
	private Rectangle? e;

	// Token: 0x040044AD RID: 17581
	private Point? f;

	// Token: 0x040044AE RID: 17582
	private int g;

	// Token: 0x040044AF RID: 17583
	private double h;

	// Token: 0x040044B0 RID: 17584
	private b5j i;

	// Token: 0x040044B1 RID: 17585
	private bool j;

	// Token: 0x040044B2 RID: 17586
	private bool k;

	// Token: 0x040044B3 RID: 17587
	private bool l;
}
