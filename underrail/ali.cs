using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000172 RID: 370
public sealed class ali : cao
{
	// Token: 0x06000951 RID: 2385 RVA: 0x0002683C File Offset: 0x00024A3C
	public esj i()
	{
		return this.a;
	}

	// Token: 0x06000952 RID: 2386 RVA: 0x00026844 File Offset: 0x00024A44
	public void a(esj A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000953 RID: 2387 RVA: 0x00026850 File Offset: 0x00024A50
	public string b()
	{
		return this.c;
	}

	// Token: 0x06000954 RID: 2388 RVA: 0x00026858 File Offset: 0x00024A58
	public void b(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06000955 RID: 2389 RVA: 0x00026864 File Offset: 0x00024A64
	public cab e()
	{
		return this.d;
	}

	// Token: 0x06000956 RID: 2390 RVA: 0x0002686C File Offset: 0x00024A6C
	public void a(cab A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06000957 RID: 2391 RVA: 0x00026878 File Offset: 0x00024A78
	public Vector2 c()
	{
		return this.e;
	}

	// Token: 0x06000958 RID: 2392 RVA: 0x00026880 File Offset: 0x00024A80
	public void a(Vector2 A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06000959 RID: 2393 RVA: 0x0002688C File Offset: 0x00024A8C
	public Color h()
	{
		return this.f;
	}

	// Token: 0x0600095A RID: 2394 RVA: 0x00026894 File Offset: 0x00024A94
	public void a(Color A_0)
	{
		this.f = A_0;
	}

	// Token: 0x0600095B RID: 2395 RVA: 0x000268A0 File Offset: 0x00024AA0
	public Color g()
	{
		return this.g;
	}

	// Token: 0x0600095C RID: 2396 RVA: 0x000268A8 File Offset: 0x00024AA8
	public void b(Color A_0)
	{
		this.g = A_0;
	}

	// Token: 0x0600095D RID: 2397 RVA: 0x000268B4 File Offset: 0x00024AB4
	public Color d()
	{
		return this.h;
	}

	// Token: 0x0600095E RID: 2398 RVA: 0x000268BC File Offset: 0x00024ABC
	public void c(Color A_0)
	{
		this.h = A_0;
	}

	// Token: 0x0600095F RID: 2399 RVA: 0x000268C8 File Offset: 0x00024AC8
	public string f()
	{
		return this.j;
	}

	// Token: 0x06000960 RID: 2400 RVA: 0x000268D0 File Offset: 0x00024AD0
	public void a(string A_0)
	{
		if (this.j != A_0)
		{
			this.j = A_0;
			this.a();
		}
	}

	// Token: 0x06000961 RID: 2401 RVA: 0x000268F0 File Offset: 0x00024AF0
	public int j()
	{
		return this.k;
	}

	// Token: 0x06000962 RID: 2402 RVA: 0x000268F8 File Offset: 0x00024AF8
	public void a(int A_0)
	{
		this.k = A_0;
	}

	// Token: 0x06000963 RID: 2403 RVA: 0x00026904 File Offset: 0x00024B04
	public ali()
	{
	}

	// Token: 0x06000964 RID: 2404 RVA: 0x00026930 File Offset: 0x00024B30
	public ali(string A_0, esj A_1) : this(A_0, A_1, Point.Zero)
	{
	}

	// Token: 0x06000965 RID: 2405 RVA: 0x00026940 File Offset: 0x00024B40
	public ali(string A_0, esj A_1, Point A_2)
	{
		this.a = A_1;
		this.c = A_0;
		this.b = A_2;
	}

	// Token: 0x06000966 RID: 2406 RVA: 0x00026984 File Offset: 0x00024B84
	public override void iv(e6d A_0, cp9 A_1)
	{
		int num = this.k * this.a.d;
		Color a_;
		if (base.Pressed || base.Checked)
		{
			a_ = this.h;
			num += 2 * this.a.d;
		}
		else if (this.IsMousedOver)
		{
			a_ = this.g;
			num += this.a.d;
		}
		else
		{
			a_ = this.f;
		}
		if (A_1.a != null)
		{
			Point point = base.at();
			if (!string.IsNullOrEmpty(this.c))
			{
				Texture2D resource = A_1.a.GetResource<Texture2D>(this.c, null);
				if (resource != null && base.Size.c > 0 && base.Size.d > 0)
				{
					A_1.b().w6(resource, new Rectangle(point.X + this.a.c, point.Y, base.Size.c - 2 * this.a.c, base.Size.d), new Rectangle?(new Rectangle(this.b.X + this.a.c, this.b.Y + num, this.a.c, this.a.d)), base.Color);
					A_1.b().w6(resource, new Rectangle(point.X, point.Y, this.a.c, base.Size.d), new Rectangle?(new Rectangle(this.b.X, this.b.Y + num, this.a.c, this.a.d)), base.Color);
					A_1.b().w6(resource, new Rectangle(point.X + base.Size.c - this.a.c, point.Y, this.a.c, base.Size.d), new Rectangle?(new Rectangle(this.b.X + this.a.c * 2, this.b.Y + num, this.a.c, this.a.d)), base.Color);
				}
			}
			if (!string.IsNullOrEmpty(base.Text) && !string.IsNullOrEmpty(this.j))
			{
				SpriteFont resource2 = A_1.a.GetResource<SpriteFont>(this.j, null);
				if (resource2 != null)
				{
					if (this.i == null)
					{
						this.i = new Vector2?(resource2.MeasureString(base.Text));
					}
					Vector2 a_2 = point.b() + this.e;
					a_2.Y += ((float)base.Size.d - this.i.Value.Y) / 2f;
					if (this.d == cab.c)
					{
						a_2.X += (float)base.Size.c - this.i.Value.X;
					}
					else if (this.d == cab.b)
					{
						a_2.X += ((float)base.Size.c - this.i.Value.X) / 2f;
					}
					A_1.b().xb(resource2, base.Text, a_2, a_);
				}
			}
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x06000967 RID: 2407 RVA: 0x00026D48 File Offset: 0x00024F48
	protected override void j5(object A_0, c1 A_1)
	{
		base.j5(A_0, A_1);
		this.a();
	}

	// Token: 0x06000968 RID: 2408 RVA: 0x00026D58 File Offset: 0x00024F58
	private void a()
	{
		this.i = null;
	}

	// Token: 0x040005F8 RID: 1528
	private new esj a;

	// Token: 0x040005F9 RID: 1529
	private new Point b;

	// Token: 0x040005FA RID: 1530
	private new string c;

	// Token: 0x040005FB RID: 1531
	private new cab d;

	// Token: 0x040005FC RID: 1532
	private new Vector2 e;

	// Token: 0x040005FD RID: 1533
	private new Color f = Color.White;

	// Token: 0x040005FE RID: 1534
	private new Color g = Color.White;

	// Token: 0x040005FF RID: 1535
	private Color h = Color.White;

	// Token: 0x04000600 RID: 1536
	private Vector2? i;

	// Token: 0x04000601 RID: 1537
	private new string j;

	// Token: 0x04000602 RID: 1538
	private new int k;
}
