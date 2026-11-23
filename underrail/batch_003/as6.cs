using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02001FCB RID: 8139
internal static class as6
{
	// Token: 0x0600BF2B RID: 48939 RVA: 0x00422170 File Offset: 0x00420370
	public static void a(ob A_0, Texture2D A_1, Point A_2, esj A_3, Color A_4, Point? A_5 = null, esj? A_6 = null)
	{
		czh.a(A_0, "spriteBatch");
		czh.a(A_1, "texture");
		esj esj = (A_6 != null) ? A_6.Value : new esj(A_1.Width, A_1.Height);
		int num = 0;
		while (A_3.d - num > 0)
		{
			int num2 = Math.Min(A_3.d - num, esj.d);
			Rectangle a_ = new Rectangle(A_2.X, A_2.Y + num, A_3.c, num2);
			Rectangle value = new Rectangle((A_5 != null) ? A_5.Value.X : 0, (A_5 != null) ? A_5.Value.Y : 0, esj.c, num2);
			A_0.w6(A_1, a_, new Rectangle?(value), A_4);
			num += num2;
		}
	}

	// Token: 0x0600BF2C RID: 48940 RVA: 0x00422264 File Offset: 0x00420464
	public static void a(cp9 A_0, Vector2 A_1, coh A_2)
	{
		string n = egg.n;
		SpriteFont resource = A_0.a.GetResource<SpriteFont>(n, null);
		if (resource != null)
		{
			string text = as6.a(A_2.Stacks);
			Vector2 vector = resource.MeasureString(text);
			A_0.b().xb(resource, text, new Vector2(A_1.X + ((float)bj8.a.c - vector.X), A_1.Y + ((float)bj8.a.d - vector.Y) + (float)egg.b(n)), Color.White);
		}
	}

	// Token: 0x0600BF2D RID: 48941 RVA: 0x004222FC File Offset: 0x004204FC
	public static void a(cp9 A_0, Vector2 A_1, Vector2 A_2, Vector2 A_3, Vector2 A_4, Texture2D A_5, coh A_6)
	{
		if (A_6 != null)
		{
			double num = -1.0;
			if (A_6.MaxBattery > 0)
			{
				num = A_6.Battery / (double)A_6.MaxBattery;
			}
			else
			{
				cd1 cd = A_6 as cd1;
				if (cd != null && cd.TypedDefinition.e() != btz.g && cd.TypedDefinition.e() != btz.f && cd.TypedDefinition.f() > 0)
				{
					num = (double)cd.LoadedAmmo.Count / (double)cd.TypedDefinition.f();
				}
			}
			if (num != -1.0 && A_5 != null)
			{
				Rectangle value = new Rectangle((int)A_2.X, 0, (int)A_1.X, (int)A_1.Y);
				Rectangle rectangle = new Rectangle((int)A_2.X + (int)A_1.X, 0, (int)A_1.X, (int)A_1.Y);
				Vector2 vector = new Vector2((float)((int)(A_3.X + A_4.X - A_1.X - (1f + A_4.X / 30f))), (float)((int)(A_3.Y + (A_4.Y - A_1.Y) / 2f)));
				A_0.b().w5(A_5, vector, new Rectangle?(value), Color.White * 0.5f);
				if (num > 0.0)
				{
					Rectangle value2 = rectangle;
					int num2;
					if (num < 1.0)
					{
						num2 = Math.Min((int)(A_1.Y - 1f), (int)((1.0 - num) * (double)A_1.Y));
						value2.Y = num2;
						value2.Height -= num2;
					}
					else
					{
						num2 = 0;
					}
					A_0.b().w5(A_5, vector + new Vector2(0f, (float)num2), new Rectangle?(value2), Color.White * 0.85f);
				}
			}
		}
	}

	// Token: 0x0600BF2E RID: 48942 RVA: 0x00422504 File Offset: 0x00420704
	public static void a(cp9 A_0, Vector2 A_1, Texture2D A_2, coh A_3)
	{
		if (A_3 != null)
		{
			double num = -1.0;
			if (A_3.MaxBattery > 0)
			{
				num = A_3.Battery / (double)A_3.MaxBattery;
			}
			else
			{
				cd1 cd = A_3 as cd1;
				if (cd != null && cd.TypedDefinition.e() != btz.g && cd.TypedDefinition.e() != btz.f && cd.TypedDefinition.f() > 0)
				{
					num = (double)cd.LoadedAmmo.Count / (double)cd.TypedDefinition.f();
				}
			}
			if (num != -1.0)
			{
				if (A_2 == null)
				{
					A_2 = A_0.a.GetResource<Texture2D>(bo1.ad, null);
				}
				if (A_2 != null)
				{
					A_0.b().w5(A_2, A_1 + as6.a, new Rectangle?(as6.b), Color.White * 0.5f);
					if (num > 0.0)
					{
						Rectangle value = as6.c;
						int num2;
						if (num < 1.0)
						{
							num2 = Math.Min(24, (int)((1.0 - num) * (double)as6.b.Height));
							value.Y = num2;
							value.Height -= num2;
						}
						else
						{
							num2 = 0;
						}
						A_0.b().w5(A_2, A_1 + as6.a + new Vector2(0f, (float)num2), new Rectangle?(value), Color.White * 0.85f);
					}
				}
			}
		}
	}

	// Token: 0x0600BF2F RID: 48943 RVA: 0x004226A4 File Offset: 0x004208A4
	public static void a(cp9 A_0, Vector2 A_1, esj A_2, string A_3, coh A_4)
	{
		SpriteFont resource = A_0.a.GetResource<SpriteFont>(A_3, null);
		if (resource != null)
		{
			string text = as6.a(A_4.Stacks);
			Vector2 vector = resource.MeasureString(text);
			Vector2 a_ = new Vector2(A_1.X + (float)A_2.c - vector.X - 3f, A_1.Y + (float)A_2.d - vector.Y - 3f + (float)egg.b(A_3));
			A_0.b().xb(resource, text, a_, Color.White);
		}
	}

	// Token: 0x0600BF30 RID: 48944 RVA: 0x0042273C File Offset: 0x0042093C
	public static string a(int A_0)
	{
		if (A_0 <= 999)
		{
			return A_0.ToString();
		}
		if (A_0 <= 999999)
		{
			return ((double)((int)((double)A_0 / 1000.0 * 10.0)) / 10.0).ToString() + "k";
		}
		return ((double)((int)((double)A_0 / 1000000.0 * 10.0)) / 10.0).ToString() + "m";
	}

	// Token: 0x040044B8 RID: 17592
	private static readonly Vector2 a = new Vector2(26f, 4f);

	// Token: 0x040044B9 RID: 17593
	private static readonly Rectangle b = new Rectangle(3 * eb1.a.c, 0, 4, 25);

	// Token: 0x040044BA RID: 17594
	private static readonly Rectangle c = new Rectangle(3 * eb1.a.c + 4, 0, 4, 25);
}
