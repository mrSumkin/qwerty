using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001A9 RID: 425
public static class c4o
{
	// Token: 0x06000C2C RID: 3116 RVA: 0x00031050 File Offset: 0x0002F250
	public static void b(cp9 A_0, Texture2D A_1, esj A_2, Point A_3, Rectangle A_4, Color A_5, bool A_6, Point? A_7 = null)
	{
		ob ob = A_0.b();
		Rectangle value = default(Rectangle);
		Rectangle a_ = default(Rectangle);
		Point point = new Point(A_3.X * A_2.c * 3, A_3.Y * A_2.d * 3);
		if (A_7 != null)
		{
			point.X += A_7.Value.X;
			point.Y += A_7.Value.Y;
		}
		int a_2 = A_4.X + A_4.Width - A_2.c;
		int a_3 = A_4.Y + A_4.Height - A_2.d;
		c4o.a(ref value, point.X, point.Y, A_2);
		c4o.a(ref a_, A_4.X, A_4.Y, A_2);
		ob.w6(A_1, a_, new Rectangle?(value), A_5);
		c4o.a(ref value, point.X + 2 * A_2.c, point.Y, A_2);
		c4o.a(ref a_, a_2, A_4.Y, A_2);
		ob.w6(A_1, a_, new Rectangle?(value), A_5);
		c4o.a(ref value, point.X, point.Y + 2 * A_2.d, A_2);
		c4o.a(ref a_, A_4.X, a_3, A_2);
		ob.w6(A_1, a_, new Rectangle?(value), A_5);
		c4o.a(ref value, point.X + 2 * A_2.c, point.Y + 2 * A_2.d, A_2);
		c4o.a(ref a_, a_2, a_3, A_2);
		ob.w6(A_1, a_, new Rectangle?(value), A_5);
		int num = A_4.Height / A_2.d - 2;
		for (int i = 0; i < num; i++)
		{
			c4o.a(ref value, point.X, point.Y + A_2.d, A_2);
			c4o.a(ref a_, A_4.X, A_4.Y + (1 + i) * A_2.d, A_2);
			ob.w6(A_1, a_, new Rectangle?(value), A_5);
			c4o.a(ref value, point.X + 2 * A_2.c, point.Y + A_2.d, A_2);
			c4o.a(ref a_, A_4.X + A_4.Width - A_2.c, A_4.Y + (1 + i) * A_2.d, A_2);
			ob.w6(A_1, a_, new Rectangle?(value), A_5);
		}
		int num2 = A_4.Height % A_2.d;
		if (num2 > 0)
		{
			c4o.a(ref value, point.X, point.Y + A_2.d, A_2.c, num2);
			c4o.a(ref a_, A_4.X, A_4.Y + (1 + num) * A_2.d, A_2.c, num2);
			ob.w6(A_1, a_, new Rectangle?(value), A_5);
			c4o.a(ref value, point.X + 2 * A_2.c, point.Y + A_2.d, A_2.c, num2);
			c4o.a(ref a_, A_4.X + A_4.Width - A_2.c, A_4.Y + (1 + num) * A_2.d, A_2.c, num2);
			ob.w6(A_1, a_, new Rectangle?(value), A_5);
		}
		int num3 = A_4.Width / A_2.c - 2;
		for (int j = 0; j < num3; j++)
		{
			c4o.a(ref value, point.X + A_2.c, point.Y, A_2);
			c4o.a(ref a_, A_4.X + (1 + j) * A_2.c, A_4.Y, A_2);
			ob.w6(A_1, a_, new Rectangle?(value), A_5);
			c4o.a(ref value, point.X + A_2.c, point.Y + 2 * A_2.d, A_2);
			c4o.a(ref a_, A_4.X + (1 + j) * A_2.c, A_4.Y + A_4.Height - A_2.d, A_2);
			ob.w6(A_1, a_, new Rectangle?(value), A_5);
		}
		int num4 = A_4.Width % A_2.c;
		if (num4 > 0)
		{
			c4o.a(ref value, point.X + A_2.c, point.Y, num4, A_2.d);
			c4o.a(ref a_, A_4.X + (1 + num3) * A_2.c, A_4.Y, num4, A_2.d);
			ob.w6(A_1, a_, new Rectangle?(value), A_5);
			c4o.a(ref value, point.X + A_2.c, point.Y + 2 * A_2.d, num4, A_2.d);
			c4o.a(ref a_, A_4.X + (1 + num3) * A_2.c, A_4.Y + A_4.Height - A_2.d, num4, A_2.d);
			ob.w6(A_1, a_, new Rectangle?(value), A_5);
		}
		if (A_6)
		{
			for (int k = 0; k < num; k++)
			{
				c4o.a(ref value, point.X + A_2.c, point.Y + A_2.d, A_2);
				for (int l = 0; l < num3; l++)
				{
					c4o.a(ref a_, A_4.X + (1 + l) * A_2.c, A_4.Y + (1 + k) * A_2.d, A_2);
					ob.w6(A_1, a_, new Rectangle?(value), A_5);
				}
				if (num4 > 0)
				{
					c4o.a(ref value, point.X + A_2.c, point.Y + A_2.d, num4, A_2.d);
					c4o.a(ref a_, A_4.X + (1 + num3) * A_2.c, A_4.Y + (1 + k) * A_2.d, num4, A_2.d);
					ob.w6(A_1, a_, new Rectangle?(value), A_5);
				}
			}
			if (num2 > 0)
			{
				c4o.a(ref value, point.X + A_2.c, point.Y + A_2.d, A_2.c, num2);
				for (int m = 0; m < num3; m++)
				{
					c4o.a(ref a_, A_4.X + (1 + m) * A_2.c, A_4.Y + (1 + num) * A_2.d, A_2.c, num2);
					ob.w6(A_1, a_, new Rectangle?(value), A_5);
				}
			}
			if (num4 > 0 && num2 > 0)
			{
				c4o.a(ref value, point.X + A_2.c, point.Y + A_2.d, num4, num2);
				c4o.a(ref a_, A_4.X + (1 + num3) * A_2.c, A_4.Y + (1 + num) * A_2.d, num4, num2);
				ob.w6(A_1, a_, new Rectangle?(value), A_5);
			}
		}
	}

	// Token: 0x06000C2D RID: 3117 RVA: 0x00031788 File Offset: 0x0002F988
	public static void a(cp9 A_0, Texture2D A_1, esj A_2, Point A_3, Rectangle A_4, Color A_5, bool A_6, Point? A_7 = null)
	{
		ob ob = A_0.b();
		Rectangle value = default(Rectangle);
		Rectangle a_ = default(Rectangle);
		Point point = new Point(A_3.X * A_2.c * 3, A_3.Y * A_2.d * 3);
		if (A_7 != null)
		{
			point.X += A_7.Value.X;
			point.Y += A_7.Value.Y;
		}
		int a_2 = A_4.X + A_4.Width - A_2.c;
		int a_3 = A_4.Y + A_4.Height - A_2.d;
		c4o.a(ref value, point.X, point.Y, A_2);
		c4o.a(ref a_, A_4.X, A_4.Y, A_2);
		ob.w6(A_1, a_, new Rectangle?(value), A_5);
		c4o.a(ref value, point.X + 2 * A_2.c, point.Y, A_2);
		c4o.a(ref a_, a_2, A_4.Y, A_2);
		ob.w6(A_1, a_, new Rectangle?(value), A_5);
		c4o.a(ref value, point.X, point.Y + 2 * A_2.d, A_2);
		c4o.a(ref a_, A_4.X, a_3, A_2);
		ob.w6(A_1, a_, new Rectangle?(value), A_5);
		c4o.a(ref value, point.X + 2 * A_2.c, point.Y + 2 * A_2.d, A_2);
		c4o.a(ref a_, a_2, a_3, A_2);
		ob.w6(A_1, a_, new Rectangle?(value), A_5);
		c4o.a(ref value, point.X, point.Y + A_2.d, A_2);
		c4o.a(ref a_, A_4.X, A_4.Y + A_2.d, A_2.c, A_4.Height - 2 * A_2.d);
		ob.w6(A_1, a_, new Rectangle?(value), A_5);
		c4o.a(ref value, point.X + 2 * A_2.c, point.Y + A_2.d, A_2);
		c4o.a(ref a_, A_4.X + A_4.Width - A_2.c, A_4.Y + A_2.d, A_2.c, A_4.Height - 2 * A_2.d);
		ob.w6(A_1, a_, new Rectangle?(value), A_5);
		c4o.a(ref value, point.X + A_2.c, point.Y, A_2);
		c4o.a(ref a_, A_4.X + A_2.c, A_4.Y, A_4.Width - 2 * A_2.c, A_2.d);
		ob.w6(A_1, a_, new Rectangle?(value), A_5);
		c4o.a(ref value, point.X + A_2.c, point.Y + 2 * A_2.d, A_2);
		c4o.a(ref a_, A_4.X + A_2.c, A_4.Y + A_4.Height - A_2.d, A_4.Width - 2 * A_2.c, A_2.d);
		ob.w6(A_1, a_, new Rectangle?(value), A_5);
		if (A_6)
		{
			c4o.a(ref value, point.X + A_2.c, point.Y + A_2.d, A_2);
			c4o.a(ref a_, A_4.X + A_2.c, A_4.Y + A_2.d, A_4.Width - 2 * A_2.c, A_4.Height - 2 * A_2.d);
			ob.w6(A_1, a_, new Rectangle?(value), A_5);
		}
	}

	// Token: 0x06000C2E RID: 3118 RVA: 0x00031B54 File Offset: 0x0002FD54
	public static esj a(Texture2D A_0, int A_1, int A_2)
	{
		return new esj(A_0.Width / A_1, A_0.Height / A_2);
	}

	// Token: 0x06000C2F RID: 3119 RVA: 0x00031B70 File Offset: 0x0002FD70
	public static void a(cp9 A_0, Texture2D A_1, Rectangle A_2, Rectangle A_3, Color A_4)
	{
		int num;
		bool flag;
		if (A_3.Width >= 2 * A_2.Height)
		{
			num = A_2.Height;
			flag = true;
		}
		else
		{
			num = (int)Math.Ceiling(A_3.Width / 2m);
			flag = false;
		}
		Rectangle value = new Rectangle(A_2.X, A_2.Y, num, A_2.Height);
		Rectangle a_ = new Rectangle(A_3.X, A_3.Y, num, A_2.Height);
		A_0.b().w6(A_1, a_, new Rectangle?(value), A_4);
		Rectangle value2 = new Rectangle(A_2.Right - num, A_2.Y, num, A_2.Height);
		Rectangle a_2 = new Rectangle(A_3.Right - num, A_3.Y, num, A_2.Height);
		A_0.b().w6(A_1, a_2, new Rectangle?(value2), A_4);
		if (flag)
		{
			Rectangle value3 = new Rectangle(A_2.X + A_2.Height, A_2.Y, A_2.Width - 2 * A_2.Height, A_2.Height);
			Rectangle a_3 = new Rectangle(A_3.X + A_2.Height, A_3.Y, A_3.Width - 2 * A_2.Height, A_2.Height);
			A_0.b().w6(A_1, a_3, new Rectangle?(value3), A_4);
		}
	}

	// Token: 0x06000C30 RID: 3120 RVA: 0x00031CD8 File Offset: 0x0002FED8
	public static void a(cp9 A_0, Texture2D A_1, Point A_2, esj A_3, Rectangle A_4, Color A_5)
	{
		Rectangle value = new Rectangle(A_2.X, A_2.Y + A_3.d, A_3.c, A_3.d);
		int num = 1;
		while ((double)num < Math.Ceiling((double)A_4.Height / (double)A_3.d) - 1.0)
		{
			A_0.b().w5(A_1, new Vector2((float)A_4.X, (float)(A_4.Y + num * A_3.d)), new Rectangle?(value), A_5);
			num++;
		}
		A_0.b().w5(A_1, new Vector2((float)A_4.X, (float)A_4.Y), new Rectangle?(new Rectangle(A_2.X, A_2.Y, A_3.c, A_3.d)), A_5);
		A_0.b().w5(A_1, new Vector2((float)A_4.X, (float)(A_4.Y + A_4.Height - A_3.d)), new Rectangle?(new Rectangle(A_2.X, A_2.Y + A_3.d * 2, A_3.c, A_3.d)), A_5);
	}

	// Token: 0x06000C31 RID: 3121 RVA: 0x00031E10 File Offset: 0x00030010
	public static void a(cp9 A_0, float A_1, Color A_2, Vector2 A_3, Vector2 A_4)
	{
		Texture2D resource = A_0.a.GetResource<Texture2D>("Locale\\Meta\\Blank", null);
		float a_ = (float)Math.Atan2((double)(A_4.Y - A_3.Y), (double)(A_4.X - A_3.X));
		float x = Vector2.Distance(A_3, A_4);
		A_0.b().w9(resource, A_3, null, A_2, a_, Vector2.Zero, new Vector2(x, A_1), SpriteEffects.None, 0f);
	}

	// Token: 0x06000C32 RID: 3122 RVA: 0x00031E90 File Offset: 0x00030090
	private static void a(ref Rectangle A_0, int A_1, int A_2, int A_3, int A_4)
	{
		A_0.X = A_1;
		A_0.Y = A_2;
		A_0.Width = A_3;
		A_0.Height = A_4;
	}

	// Token: 0x06000C33 RID: 3123 RVA: 0x00031EB0 File Offset: 0x000300B0
	private static void a(ref Rectangle A_0, int A_1, int A_2, esj A_3)
	{
		c4o.a(ref A_0, A_1, A_2, A_3.c, A_3.d);
	}
}
