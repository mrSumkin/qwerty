using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000721 RID: 1825
public static class eap
{
	// Token: 0x06002F66 RID: 12134 RVA: 0x0011F234 File Offset: 0x0011D434
	public static void a(cp9 A_0, Rectangle A_1, string A_2, Vector2 A_3, SpriteFont A_4, Color A_5, float A_6, Color A_7)
	{
		Rectangle value = default(Rectangle);
		value.Width = A_1.Width;
		value.Height = A_1.Height;
		if (A_6 != 1f)
		{
			Rectangle a_ = default(Rectangle);
			a_.X = A_1.X + (int)((float)A_1.Width * A_6);
			a_.Y = A_1.Y;
			a_.Width = (int)((float)A_1.Width * (1f - A_6));
			a_.Height = A_1.Height;
			A_0.b().w6(ci7.l(), a_, new Rectangle?(value), new Color(50, 50, 50) * 0.5f);
		}
		if (A_6 != 0f)
		{
			Rectangle a_2 = default(Rectangle);
			a_2.X = A_1.X;
			a_2.Y = A_1.Y;
			a_2.Width = (int)Math.Max(1f, (float)A_1.Width * A_6);
			a_2.Height = A_1.Height;
			A_0.b().w6(ci7.l(), a_2, new Rectangle?(value), A_5 * 0.5f);
		}
		if (!string.IsNullOrEmpty(A_2))
		{
			Vector2 vector = new Vector2((float)A_1.X, (float)A_1.Y);
			vector.Y += (float)((A_1.Height - A_4.LineSpacing) / 2);
			vector += A_3;
			A_0.b().xb(A_4, A_2, vector, A_7);
		}
	}
}
