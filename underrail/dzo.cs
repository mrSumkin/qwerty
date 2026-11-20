using System;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02001347 RID: 4935
public sealed class dzo
{
	// Token: 0x06006FBE RID: 28606 RVA: 0x002EDAD0 File Offset: 0x002EBCD0
	public static void a(c5x A_0, string A_1, bool A_2, float? A_3 = null)
	{
		string a_ = "Firing\\" + A_1;
		int a_2 = 1;
		double maxValue = double.MaxValue;
		bool a_3 = false;
		bool a_4 = true;
		float? a_5 = dz6.b();
		c5x c5x = boj.a(A_0, a_, a_2, maxValue, a_3, a_4, null, null, A_3, a_5, false);
		if (c5x != null)
		{
			c5x.VisualDirection = A_0.VisualDirection;
			if (c5x.VisualDirection == HorizontalDirection.North || c5x.VisualDirection == HorizontalDirection.Northwest || c5x.VisualDirection == HorizontalDirection.West)
			{
				c5x.VisualPriority *= -1;
			}
			if (A_2)
			{
				c5x.ad = new Color?(Color.White);
			}
		}
	}
}
