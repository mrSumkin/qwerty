using System;
using System.ComponentModel;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Ouroboros.Core.Logging;

// Token: 0x02000174 RID: 372
[dmo(DisplayName = "Classic Button", Description = "A classic button.", InitialWidth = 100, InitialHeight = 30)]
public class dak : cao
{
	// Token: 0x17000045 RID: 69
	// (get) Token: 0x06000980 RID: 2432 RVA: 0x000271D8 File Offset: 0x000253D8
	// (set) Token: 0x06000981 RID: 2433 RVA: 0x000271E8 File Offset: 0x000253E8
	[Category("Appearance")]
	public string Font
	{
		get
		{
			return this.c.g();
		}
		set
		{
			this.c.a(value);
		}
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x06000982 RID: 2434 RVA: 0x000271F8 File Offset: 0x000253F8
	// (set) Token: 0x06000983 RID: 2435 RVA: 0x00027208 File Offset: 0x00025408
	[Category("Layout")]
	public cab LabelHorizontalAlignment
	{
		get
		{
			return this.c.f();
		}
		set
		{
			this.c.a(value);
		}
	}

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x06000984 RID: 2436 RVA: 0x00027218 File Offset: 0x00025418
	// (set) Token: 0x06000985 RID: 2437 RVA: 0x00027228 File Offset: 0x00025428
	[Category("Layout")]
	public ad4 LabelVerticalAlignment
	{
		get
		{
			return this.c.e();
		}
		set
		{
			this.c.a(value);
		}
	}

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x06000986 RID: 2438 RVA: 0x00027238 File Offset: 0x00025438
	// (set) Token: 0x06000987 RID: 2439 RVA: 0x00027240 File Offset: 0x00025440
	[Category("Layout")]
	public Point TextLabelOffset
	{
		get
		{
			return this.v;
		}
		set
		{
			this.v = value;
			this.a();
		}
	}

	// Token: 0x06000988 RID: 2440 RVA: 0x00027250 File Offset: 0x00025450
	public dak() : this("GUI\\ClassicButton")
	{
	}

	// Token: 0x06000989 RID: 2441 RVA: 0x00027260 File Offset: 0x00025460
	public dak(string A_0)
	{
		this.c = new avo();
		this.c.IsPrivateComponent = true;
		this.c.a(false);
		this.d = A_0;
		this.aox(this.c);
	}

	// Token: 0x0600098A RID: 2442 RVA: 0x00027324 File Offset: 0x00025524
	protected override void j5(object A_0, c1 A_1)
	{
		base.j5(A_0, A_1);
		this.c.Text = (A_1.a() as string);
	}

	// Token: 0x0600098B RID: 2443 RVA: 0x00027344 File Offset: 0x00025544
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.a();
	}

	// Token: 0x0600098C RID: 2444 RVA: 0x00027354 File Offset: 0x00025554
	protected override void lq(object A_0, b25 A_1)
	{
		base.lq(A_0, A_1);
	}

	// Token: 0x0600098D RID: 2445 RVA: 0x00027364 File Offset: 0x00025564
	public override void iv(e6d A_0, cp9 A_1)
	{
		cvq cvq = dr3.e();
		Point point = base.at();
		try
		{
			cne service = bpo.GetService<cne>();
			if (service != null)
			{
				Texture2D texture2D = null;
				if (!string.IsNullOrEmpty(this.d))
				{
					texture2D = service.GetResource<Texture2D>(this.d, null);
				}
				Texture2D texture2D2 = null;
				if (!string.IsNullOrEmpty(this.r))
				{
					texture2D2 = service.GetResource<Texture2D>(this.r, null);
				}
				Point point2 = default(Point);
				this.c.Color = this.g;
				Color a_ = base.Color;
				Color a_2 = this.n;
				if (!this.Enabled)
				{
					this.c.Color = this.j;
					a_ = this.m;
					a_2 = this.q;
				}
				else if (base.Pressed || base.Checked)
				{
					if (this.z)
					{
						point2.Y = 2;
					}
					else
					{
						point2.X = 2;
					}
					this.c.Color = this.h;
					a_ = this.k;
					a_2 = this.p;
				}
				else if (base.MousedOverCache)
				{
					if (this.z)
					{
						point2.Y = 1;
					}
					else
					{
						point2.X = 1;
					}
					this.c.Color = this.i;
					a_ = this.l;
					a_2 = this.o;
				}
				if (texture2D != null)
				{
					esj a_3;
					if (this.e != null)
					{
						a_3 = this.e.Value;
					}
					else
					{
						a_3 = c4o.a(texture2D, 9, 3);
					}
					c4o.b(A_1, texture2D, a_3, point2, new Rectangle(point.X, point.Y, base.Size.c, base.Size.d), a_, true, new Point?(this.f));
				}
				if (texture2D2 != null)
				{
					esj esj;
					if (this.s != null)
					{
						esj = this.s.Value;
					}
					else
					{
						esj = c4o.a(texture2D2, 3, 1);
					}
					Rectangle a_4 = default(Rectangle);
					a_4.Width = esj.c;
					a_4.Height = esj.d;
					if (this.w == cab.b)
					{
						a_4.X = point.X + (base.Size.c - esj.c) / 2;
					}
					else if (this.w == cab.a)
					{
						a_4.X = point.X + this.u.c;
					}
					else
					{
						a_4.X = point.X + base.Size.c - esj.c - this.u.c;
					}
					if (this.x == ad4.b)
					{
						a_4.Y = point.Y + (base.Size.d - esj.d) / 2;
					}
					else if (this.x == ad4.a)
					{
						a_4.Y = point.Y + this.u.d;
					}
					else
					{
						a_4.Y = point.Y + base.Size.d - esj.d - this.u.d;
					}
					if (this.y)
					{
						point2 = Point.Zero;
					}
					Rectangle value = new Rectangle(this.t.X + point2.X * esj.c, this.t.Y + point2.Y * esj.d, esj.c, esj.d);
					A_1.b().w6(texture2D2, a_4, new Rectangle?(value), a_2);
				}
			}
		}
		catch (Exception ex)
		{
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Verbose, 110))
			{
				string a_5 = "[GUI] - Failed to render Classic Button. Exception: " + ex.ToString();
				cvq.n7(LogSeverity.Verbose, 110, a_5);
			}
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x0600098E RID: 2446 RVA: 0x000277A4 File Offset: 0x000259A4
	private void a()
	{
		this.c.Location = this.v;
		this.c.Size = base.Size;
	}

	// Token: 0x0400060B RID: 1547
	private new const int a = 9;

	// Token: 0x0400060C RID: 1548
	private new const int b = 3;

	// Token: 0x0400060D RID: 1549
	private new avo c;

	// Token: 0x0400060E RID: 1550
	public new string d;

	// Token: 0x0400060F RID: 1551
	public new esj? e;

	// Token: 0x04000610 RID: 1552
	public new Point f;

	// Token: 0x04000611 RID: 1553
	public new Color g = Color.White;

	// Token: 0x04000612 RID: 1554
	public Color h = Color.White;

	// Token: 0x04000613 RID: 1555
	public Color i = Color.White;

	// Token: 0x04000614 RID: 1556
	public new Color j = Color.Gray;

	// Token: 0x04000615 RID: 1557
	public new Color k = Color.White;

	// Token: 0x04000616 RID: 1558
	public new Color l = Color.White;

	// Token: 0x04000617 RID: 1559
	public new Color m = Color.Gray;

	// Token: 0x04000618 RID: 1560
	public Color n = Color.White;

	// Token: 0x04000619 RID: 1561
	public Color o = Color.White;

	// Token: 0x0400061A RID: 1562
	public Color p = Color.White;

	// Token: 0x0400061B RID: 1563
	public Color q = Color.Gray;

	// Token: 0x0400061C RID: 1564
	public string r;

	// Token: 0x0400061D RID: 1565
	public esj? s;

	// Token: 0x0400061E RID: 1566
	public Point t;

	// Token: 0x0400061F RID: 1567
	public esj u;

	// Token: 0x04000620 RID: 1568
	private Point v;

	// Token: 0x04000621 RID: 1569
	public cab w;

	// Token: 0x04000622 RID: 1570
	public ad4 x;

	// Token: 0x04000623 RID: 1571
	public bool y;

	// Token: 0x04000624 RID: 1572
	public bool z;
}
