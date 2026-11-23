using System;
using Microsoft.Xna.Framework;

// Token: 0x02000176 RID: 374
public class oz : c5h
{
	// Token: 0x060009AA RID: 2474 RVA: 0x00027CB8 File Offset: 0x00025EB8
	public new dak b()
	{
		return this.a;
	}

	// Token: 0x060009AB RID: 2475 RVA: 0x00027CC0 File Offset: 0x00025EC0
	public new dak c()
	{
		return this.b;
	}

	// Token: 0x060009AC RID: 2476 RVA: 0x00027CC8 File Offset: 0x00025EC8
	public oz() : this("GUI\\ClassicScrollBarButton", "GUI\\ClassicScrollBarIndicatorButton", "GUI\\ClassicScrollBarLeftButton", "GUI\\ClassicScrollBarRightButton", "GUI\\ClassicVScrollBar")
	{
	}

	// Token: 0x060009AD RID: 2477 RVA: 0x00027CEC File Offset: 0x00025EEC
	public oz(string A_0, string A_1, string A_2, string A_3, string A_4)
	{
		this.a.r = A_2;
		this.a.d = A_0;
		this.b.r = A_3;
		this.b.d = A_0;
		this.c.d = A_4;
		this.c.b(new EventHandler<b25>(this.a));
		this.d.d = A_1;
	}

	// Token: 0x060009AE RID: 2478 RVA: 0x00027D60 File Offset: 0x00025F60
	protected override void jp(object A_0, b25 A_1)
	{
		if (base.g() && this.a)
		{
			this.a();
		}
		base.jp(A_0, A_1);
	}

	// Token: 0x060009AF RID: 2479 RVA: 0x00027D88 File Offset: 0x00025F88
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.ju();
	}

	// Token: 0x060009B0 RID: 2480 RVA: 0x00027D98 File Offset: 0x00025F98
	protected override void jr(object A_0, c1 A_1)
	{
		base.jr(A_0, A_1);
		this.ju();
	}

	// Token: 0x060009B1 RID: 2481 RVA: 0x00027DA8 File Offset: 0x00025FA8
	protected override void js(object A_0, c1 A_1)
	{
		base.js(A_0, A_1);
		this.ju();
	}

	// Token: 0x060009B2 RID: 2482 RVA: 0x00027DB8 File Offset: 0x00025FB8
	protected override void jt(object A_0, c1 A_1)
	{
		base.jt(A_0, A_1);
		this.ju();
	}

	// Token: 0x060009B3 RID: 2483 RVA: 0x00027DC8 File Offset: 0x00025FC8
	private new void a(object A_0, b25 A_1)
	{
		base.a(A_1.a().X > this.d.Location.X);
	}

	// Token: 0x060009B4 RID: 2484 RVA: 0x00027DF0 File Offset: 0x00025FF0
	protected override void ju()
	{
		esj esj = new esj(base.Size.d, base.Size.d);
		this.a.Size = esj;
		this.b.Size = esj;
		this.a.Location = Point.Zero;
		this.b.Location = new Point(base.Size.c - esj.c, 0);
		this.c.Location = new Point(esj.c, 0);
		this.c.Size = new esj(base.Size.c - 2 * esj.c, base.Size.d);
		this.c.Size;
		this.d.Size = esj;
		if (!base.g())
		{
			this.a();
		}
	}

	// Token: 0x060009B5 RID: 2485 RVA: 0x00027ED4 File Offset: 0x000260D4
	private new void a()
	{
		int num = this.c.Size.c - this.d.Size.c;
		float num2 = (float)(base.k() - base.j());
		float num3 = 0f;
		if (num2 > 0f)
		{
			num3 = (float)(base.l() - base.j()) / num2;
		}
		this.d.Location = new Point(this.d.Size.c + (int)(num3 * (float)num), 0);
	}

	// Token: 0x060009B6 RID: 2486 RVA: 0x00027F5C File Offset: 0x0002615C
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
		if (base.g())
		{
			Point point = base.at();
			Point point2 = new Point(A_0.b().X - point.X - base.Size.d / 2, 0);
			if (point2.X < base.Size.d)
			{
				point2.X = base.Size.d;
			}
			if (point2.X > base.Size.c - base.Size.d * 2)
			{
				point2.X = base.Size.c - base.Size.d * 2;
			}
			this.d.Location = point2;
			int num = this.c.Size.c - base.Size.d;
			int num3;
			if (this.b)
			{
				double num2 = (double)((float)(this.d.Location.X - base.Size.d) / (float)num * (float)(base.k() - base.j()));
				num2 = Math.Round(num2);
				num3 = Convert.ToInt32((double)base.j() + num2);
				num3 = d05.a(base.j(), num3, base.k());
			}
			else
			{
				num3 = (int)((float)base.j() + (float)(this.d.Location.X - base.Size.d) / (float)num * (float)(base.k() - base.j()));
			}
			base.e(num3);
		}
	}

	// Token: 0x0400062D RID: 1581
	public new bool a;

	// Token: 0x0400062E RID: 1582
	public new bool b;
}
