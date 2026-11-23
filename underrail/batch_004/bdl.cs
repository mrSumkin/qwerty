using System;
using Microsoft.Xna.Framework;

// Token: 0x0200017E RID: 382
public class bdl : c5h
{
	// Token: 0x06000A46 RID: 2630 RVA: 0x0002A500 File Offset: 0x00028700
	public new dak d()
	{
		return this.a;
	}

	// Token: 0x06000A47 RID: 2631 RVA: 0x0002A508 File Offset: 0x00028708
	public dak e()
	{
		return this.b;
	}

	// Token: 0x06000A48 RID: 2632 RVA: 0x0002A510 File Offset: 0x00028710
	public bdl() : this("GUI\\ClassicScrollBarButton", "GUI\\ClassicScrollBarIndicatorButton", "GUI\\ClassicScrollBarUpButton", "GUI\\ClassicScrollBarDownButton", "GUI\\ClassicVScrollBar")
	{
	}

	// Token: 0x06000A49 RID: 2633 RVA: 0x0002A534 File Offset: 0x00028734
	public bdl(string A_0, string A_1, string A_2, string A_3, string A_4)
	{
		this.a.r = A_2;
		this.a.d = A_0;
		this.b.r = A_3;
		this.b.d = A_0;
		this.c.d = A_4;
		this.d.d = A_1;
		this.a();
	}

	// Token: 0x06000A4A RID: 2634 RVA: 0x0002A598 File Offset: 0x00028798
	public bdl(string A_0, Point A_1, esj A_2)
	{
		this.a.r = A_0;
		this.a.t = A_1;
		this.a.s = new esj?(A_2);
		this.b.r = A_0;
		this.b.t = new Point(A_1.X, A_1.Y + 2 * A_2.d);
		this.b.s = new esj?(A_2);
		this.c.d = A_0;
		this.c.f = new Point(A_1.X, A_1.Y + A_2.d);
		this.c.e = new esj?(esj.a(A_2, 3.0));
		this.d.d = A_0;
		this.d.f = new Point(A_1.X, A_1.Y + 3 * A_2.d);
		this.d.e = new esj?(esj.a(A_2, 3.0));
		this.a();
	}

	// Token: 0x06000A4B RID: 2635 RVA: 0x0002A6BC File Offset: 0x000288BC
	private new void a()
	{
		this.c.b(new EventHandler<b25>(this.a));
	}

	// Token: 0x06000A4C RID: 2636 RVA: 0x0002A6D8 File Offset: 0x000288D8
	private new void a(object A_0, b25 A_1)
	{
		base.a(A_1.a().Y > this.d.Location.Y);
	}

	// Token: 0x06000A4D RID: 2637 RVA: 0x0002A700 File Offset: 0x00028900
	protected override void ju()
	{
		esj esj = new esj(base.Size.c, base.Size.c);
		this.a.Size = esj;
		this.b.Size = esj;
		this.a.Location = Point.Zero;
		this.b.Location = new Point(0, base.Size.d - esj.d);
		this.c.Location = new Point(0, esj.d);
		this.c.Size = new esj(base.Size.c, base.Size.d - 2 * esj.d);
		int num = this.c.Size.d - esj.d;
		this.d.Size = esj;
		if (!base.g())
		{
			this.d.Location = new Point(0, esj.d + (int)((float)base.l() / (float)base.k() * (float)num));
		}
	}

	// Token: 0x06000A4E RID: 2638 RVA: 0x0002A818 File Offset: 0x00028A18
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
		if (base.g())
		{
			Point point = base.at();
			Point point2 = new Point(0, A_0.b().Y - point.Y - base.Size.c / 2);
			if (point2.Y < base.Size.c)
			{
				point2.Y = base.Size.c;
			}
			if (point2.Y > base.Size.d - base.Size.c * 2)
			{
				point2.Y = base.Size.d - base.Size.c * 2;
			}
			this.d.Location = point2;
			int num = this.c.Size.d - base.Size.c;
			int a_ = (int)((float)(this.d.Location.Y - base.Size.c) / (float)num * (float)base.k());
			base.e(a_);
		}
	}
}
