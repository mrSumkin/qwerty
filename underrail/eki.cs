using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000175 RID: 373
[dmo(DisplayName = "Classic Checkbox", Description = "A classic checkbox.", InitialWidth = 150, InitialHeight = 30)]
public class eki : cao
{
	// Token: 0x0600098F RID: 2447 RVA: 0x000277C8 File Offset: 0x000259C8
	public Point f()
	{
		return this.a;
	}

	// Token: 0x06000990 RID: 2448 RVA: 0x000277D0 File Offset: 0x000259D0
	public void a(Point A_0)
	{
		this.a = A_0;
		this.d();
	}

	// Token: 0x06000991 RID: 2449 RVA: 0x000277E0 File Offset: 0x000259E0
	public string l()
	{
		return this.b;
	}

	// Token: 0x06000992 RID: 2450 RVA: 0x000277E8 File Offset: 0x000259E8
	public void a(string A_0)
	{
		this.b = A_0;
		this.d();
	}

	// Token: 0x06000993 RID: 2451 RVA: 0x000277F8 File Offset: 0x000259F8
	public bool k()
	{
		return this.c;
	}

	// Token: 0x06000994 RID: 2452 RVA: 0x00027800 File Offset: 0x00025A00
	public void a(bool A_0)
	{
		this.c = A_0;
		this.h.a(A_0);
		if (this.c)
		{
			this.b();
		}
	}

	// Token: 0x06000995 RID: 2453 RVA: 0x00027828 File Offset: 0x00025A28
	public string i()
	{
		return this.d;
	}

	// Token: 0x06000996 RID: 2454 RVA: 0x00027830 File Offset: 0x00025A30
	public void b(string A_0)
	{
		this.d = A_0;
		this.h.a(A_0);
		this.d();
	}

	// Token: 0x06000997 RID: 2455 RVA: 0x0002784C File Offset: 0x00025A4C
	public Color g()
	{
		return this.e;
	}

	// Token: 0x06000998 RID: 2456 RVA: 0x00027854 File Offset: 0x00025A54
	public void b(Color A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06000999 RID: 2457 RVA: 0x00027860 File Offset: 0x00025A60
	public Color h()
	{
		return this.f;
	}

	// Token: 0x0600099A RID: 2458 RVA: 0x00027868 File Offset: 0x00025A68
	public void a(Color A_0)
	{
		this.f = A_0;
		this.c();
	}

	// Token: 0x0600099B RID: 2459 RVA: 0x00027878 File Offset: 0x00025A78
	public Color j()
	{
		return this.g;
	}

	// Token: 0x0600099C RID: 2460 RVA: 0x00027880 File Offset: 0x00025A80
	public void c(Color A_0)
	{
		this.g = A_0;
		this.c();
	}

	// Token: 0x0600099D RID: 2461 RVA: 0x00027890 File Offset: 0x00025A90
	public override bool n4()
	{
		return true;
	}

	// Token: 0x0600099E RID: 2462 RVA: 0x00027894 File Offset: 0x00025A94
	public override void n5(bool A_0)
	{
	}

	// Token: 0x0600099F RID: 2463 RVA: 0x00027898 File Offset: 0x00025A98
	public eki()
	{
		this.e();
		this.d();
	}

	// Token: 0x060009A0 RID: 2464 RVA: 0x000278F8 File Offset: 0x00025AF8
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.c();
	}

	// Token: 0x060009A1 RID: 2465 RVA: 0x00027908 File Offset: 0x00025B08
	protected override void j5(object A_0, c1 A_1)
	{
		base.j5(A_0, A_1);
		if (this.h != null)
		{
			this.h.Text = base.Text;
		}
		this.d();
	}

	// Token: 0x060009A2 RID: 2466 RVA: 0x00027934 File Offset: 0x00025B34
	protected override void n6(object A_0, c1 A_1)
	{
		base.n6(A_0, A_1);
		this.c();
	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x00027948 File Offset: 0x00025B48
	public override void iv(e6d A_0, cp9 A_1)
	{
		Texture2D texture2D = this.a();
		if (texture2D != null)
		{
			esj esj = eki.a(texture2D);
			Point zero = Point.Zero;
			Color white = Color.White;
			if (!this.Enabled)
			{
				white = this.e;
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
			A_1.b().w5(texture2D, new Vector2((float)point.X, (float)(point.Y + (base.Size.d - esj.d) / 2)), new Rectangle?(new Rectangle(zero.X * esj.c, zero.Y * esj.d, esj.c, esj.d)), white);
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x060009A4 RID: 2468 RVA: 0x00027A48 File Offset: 0x00025C48
	private void e()
	{
		this.h = new avo();
		this.h.IsPrivateComponent = true;
		this.h.a(this.c);
		this.h.a(cab.a);
		this.h.a(ad4.b);
		this.aox(this.h);
	}

	// Token: 0x060009A5 RID: 2469 RVA: 0x00027AA4 File Offset: 0x00025CA4
	private void d()
	{
		if (this.c)
		{
			if (!this.b())
			{
				this.c();
				return;
			}
		}
		else
		{
			this.c();
		}
	}

	// Token: 0x060009A6 RID: 2470 RVA: 0x00027ACC File Offset: 0x00025CCC
	private void c()
	{
		if (this.h != null)
		{
			esj esj = eki.a(this.a());
			if (this.c)
			{
				this.h.Location = new Point(esj.c + this.a.X, this.a.Y + (base.Size.d - this.h.Size.d) / 2);
			}
			else
			{
				this.h.Location = new Point(esj.c + this.a.X, this.a.Y);
				this.h.Size = new esj(base.Size.c - (esj.c + this.a.X), base.Size.d);
			}
			this.h.Color = (this.Enabled ? this.f : this.g);
		}
	}

	// Token: 0x060009A7 RID: 2471 RVA: 0x00027BDC File Offset: 0x00025DDC
	private bool b()
	{
		esj esj = eki.a(this.a());
		esj a_ = base.Size;
		base.Size = new esj(esj.c + this.a.X + this.h.Size.c, Math.Max(esj.d, this.h.Size.d));
		return esj.c(a_, base.Size);
	}

	// Token: 0x060009A8 RID: 2472 RVA: 0x00027C50 File Offset: 0x00025E50
	private static esj a(Texture2D A_0)
	{
		if (A_0 != null)
		{
			return new esj(A_0.Width / 3, A_0.Height / 2);
		}
		return esj.a();
	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x00027C78 File Offset: 0x00025E78
	private Texture2D a()
	{
		if (!string.IsNullOrEmpty(this.b))
		{
			cne cne = dr3.a();
			if (cne != null)
			{
				return cne.GetResource<Texture2D>(this.b, null);
			}
		}
		return null;
	}

	// Token: 0x04000625 RID: 1573
	private new Point a = new Point(5, 0);

	// Token: 0x04000626 RID: 1574
	private new string b = "gui\\ClassicCheckbox";

	// Token: 0x04000627 RID: 1575
	private new bool c = true;

	// Token: 0x04000628 RID: 1576
	private new string d;

	// Token: 0x04000629 RID: 1577
	private new Color e = Color.Gray;

	// Token: 0x0400062A RID: 1578
	private new Color f = Color.White;

	// Token: 0x0400062B RID: 1579
	private new Color g = Color.Gray;

	// Token: 0x0400062C RID: 1580
	private avo h;
}
