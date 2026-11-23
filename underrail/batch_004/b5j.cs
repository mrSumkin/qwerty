using System;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

// Token: 0x02001FBD RID: 8125
public sealed class b5j
{
	// Token: 0x0600BECA RID: 48842 RVA: 0x0041BD88 File Offset: 0x00419F88
	public b5j(ecs A_0, Rectangle A_1, esj A_2, int A_3, Point? A_4, bool A_5 = false, bool A_6 = false)
	{
		czh.a(A_0, "richText");
		bef serviceOrThrow = bpo.GetServiceOrThrow<bef>();
		int num = serviceOrThrow.k0().c;
		int num2 = serviceOrThrow.k0().d;
		this.h = A_2;
		this.i = A_3;
		ecs ecs;
		if (this.i > 0)
		{
			ecs = Enumerable.FirstOrDefault<ecs>(A_0.a(this.i, 0));
		}
		else
		{
			ecs = A_0;
		}
		if (ecs != null)
		{
			this.f = ecs.b();
			double num3 = 1.0;
			int num4 = num - 16;
			while (this.i > 0 && this.f.b.d + 20 > num2 && num3 < 4.0 && (int)((double)this.i * num3) < num4)
			{
				num3 += 0.25;
				int num5 = (int)((double)this.i * num3);
				if (num5 > num4)
				{
					num5 = num4;
				}
				ecs = Enumerable.FirstOrDefault<ecs>(A_0.a(num5, 0));
				this.f = ecs.b();
			}
			this.a();
			if (A_4 != null)
			{
				this.g.X = A_4.Value.X;
				this.g.Y = A_4.Value.Y;
				if (A_5)
				{
					this.g.X = this.g.X - this.g.Width;
				}
				if (A_6)
				{
					this.g.Y = this.g.Y - this.g.Height;
					return;
				}
			}
			else
			{
				this.a(A_1);
			}
		}
	}

	// Token: 0x0600BECB RID: 48843 RVA: 0x0041BF40 File Offset: 0x0041A140
	public void b()
	{
		ds6.a(this);
	}

	// Token: 0x0600BECC RID: 48844 RVA: 0x0041BF4C File Offset: 0x0041A14C
	internal void a(cne A_0, cp9 A_1, e6d A_2)
	{
		if (this.f == null || this.f.a == null || this.f.a.Count == 0)
		{
			return;
		}
		Point a_ = new Point(this.g.X + 8, this.g.Y + 8);
		Rectangle a_2 = this.g;
		esj esj = a2x.a();
		bool flag = false;
		if (esj.d < this.g.Height)
		{
			int num = this.g.Height - esj.d;
			int num2 = 15;
			if (!A_2.c().IsKeyDown(Keys.LeftShift) && !A_2.c().IsKeyDown(Keys.RightShift))
			{
				flag = true;
				this.l += A_2.a().ElapsedGameTime.TotalMilliseconds;
			}
			int num3 = Convert.ToInt32((long)this.l % (long)(num * 2 * num2));
			if (num3 > num * num2)
			{
				num3 = num * num2 * 2 - num3;
			}
			int num4 = num3 / num2;
			a_.Y -= num4;
			a_2.Y -= num4;
		}
		Texture2D resource = A_0.GetResource<Texture2D>(b5j.d, null);
		if (resource != null)
		{
			if (b5j.a == null)
			{
				b5j.a = new esj?(c4o.a(resource, 6, 3));
			}
			c4o.a(A_1, resource, b5j.a.Value, new Point((!this.j) ? 1 : 0, 0), a_2, Color.White * this.k, true, null);
		}
		this.f.a(a_, A_1, null, 1f);
		if (flag)
		{
			SpriteFont resource2 = A_1.a.GetResource<SpriteFont>(cq4.c(), null);
			if (resource2 != null)
			{
				string text = "Держите SHIFT для фиксации текста.";
				Vector2 vector = resource2.MeasureString(text);
				Vector2 a_3 = new Vector2((float)(this.g.Right - 10 - (int)vector.X), (float)(esj.d - 5 - (int)vector.Y));
				A_1.b().xb(resource2, text, a_3, Color.Gray);
			}
		}
	}

	// Token: 0x0600BECD RID: 48845 RVA: 0x0041C1A0 File Offset: 0x0041A3A0
	private void a()
	{
		this.g = default(Rectangle);
		this.g.Width = Math.Max(this.h.c, this.f.b.c) + 16;
		this.g.Height = Math.Max(this.h.d, this.f.b.d) + 16;
	}

	// Token: 0x0600BECE RID: 48846 RVA: 0x0041C218 File Offset: 0x0041A418
	private void a(Rectangle A_0)
	{
		esj esj = a2x.a();
		if (A_0.Top <= 0)
		{
			this.g.Y = 0;
		}
		else if (A_0.Y + this.g.Height > esj.d)
		{
			int num = esj.d - this.g.Height;
			if (num >= 0)
			{
				this.g.Y = num;
			}
		}
		else
		{
			this.g.Y = A_0.Y;
		}
		if (A_0.Right + 3 + this.g.Width > esj.c)
		{
			int num2 = A_0.X - (this.g.Width + 3);
			if (num2 >= 0)
			{
				this.g.X = num2;
				return;
			}
		}
		else
		{
			this.g.X = A_0.Right + 3;
		}
	}

	// Token: 0x04004488 RID: 17544
	private static esj? a;

	// Token: 0x04004489 RID: 17545
	private const int b = 3;

	// Token: 0x0400448A RID: 17546
	private const int c = 8;

	// Token: 0x0400448B RID: 17547
	private static readonly string d = bo1.ai;

	// Token: 0x0400448C RID: 17548
	private const float e = 0.8f;

	// Token: 0x0400448D RID: 17549
	private dn3 f;

	// Token: 0x0400448E RID: 17550
	private Rectangle g;

	// Token: 0x0400448F RID: 17551
	private esj h;

	// Token: 0x04004490 RID: 17552
	private int i;

	// Token: 0x04004491 RID: 17553
	public bool j = true;

	// Token: 0x04004492 RID: 17554
	public float k = 0.8f;

	// Token: 0x04004493 RID: 17555
	public double l;
}
