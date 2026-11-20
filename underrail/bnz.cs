using System;
using System.Globalization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200016C RID: 364
public class bnz : aiu
{
	// Token: 0x06000939 RID: 2361 RVA: 0x000263BC File Offset: 0x000245BC
	public bnz(string A_0) : base(A_0)
	{
	}

	// Token: 0x0600093A RID: 2362 RVA: 0x000263C8 File Offset: 0x000245C8
	public bnz(string A_0, string A_1, Point A_2, int A_3, int A_4, esj A_5, Vector2 A_6, float A_7 = 1f, int A_8 = 0) : this(A_0)
	{
		this.a = A_1;
		this.f = A_2;
		this.b = A_3;
		this.e = A_5;
		this.c = A_4;
		this.g = A_6;
		this.h = A_7;
		this.d = A_8;
	}

	// Token: 0x0600093B RID: 2363 RVA: 0x0002641C File Offset: 0x0002461C
	public override void ob(e6d A_0, cp9 A_1, bool A_2)
	{
		if (string.IsNullOrWhiteSpace(this.a))
		{
			return;
		}
		int num;
		if (this.i >= this.b - 1)
		{
			num = Math.Max(this.c, this.d);
		}
		else
		{
			num = this.c;
		}
		this.j += A_0.a().ElapsedGameTime.TotalMilliseconds;
		if (this.j >= (double)num)
		{
			this.j -= (double)num;
			int num2 = this.i + 1;
			this.i = num2;
			if (num2 >= this.b)
			{
				this.i = 0;
			}
		}
		Texture2D resource = A_1.a.GetResource<Texture2D>(this.a, null);
		if (resource != null)
		{
			int num3;
			if (base.a() is int)
			{
				num3 = (int)base.a();
			}
			else if (base.a() != null)
			{
				if (!int.TryParse(base.a().ToString(), NumberStyles.Number, CultureInfo.InvariantCulture, out num3))
				{
					num3 = 0;
				}
			}
			else
			{
				num3 = 0;
			}
			Rectangle value = new Rectangle(this.f.X + this.i * this.e.c, this.f.Y + num3 * this.e.d, this.e.c, this.e.d);
			Vector2 a_ = new Vector2((float)A_0.b().X - this.g.X, (float)A_0.b().Y - this.g.Y);
			A_1.b().w5(resource, a_, new Rectangle?(value), Color.White * this.h);
		}
	}

	// Token: 0x040005E5 RID: 1509
	public string a;

	// Token: 0x040005E6 RID: 1510
	public int b;

	// Token: 0x040005E7 RID: 1511
	public int c;

	// Token: 0x040005E8 RID: 1512
	public int d;

	// Token: 0x040005E9 RID: 1513
	public esj e;

	// Token: 0x040005EA RID: 1514
	public Point f;

	// Token: 0x040005EB RID: 1515
	public Vector2 g;

	// Token: 0x040005EC RID: 1516
	public float h;

	// Token: 0x040005ED RID: 1517
	private int i;

	// Token: 0x040005EE RID: 1518
	private double j;
}
