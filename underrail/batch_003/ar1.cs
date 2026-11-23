using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x0200118C RID: 4492
public static class ar1
{
	// Token: 0x06005FEA RID: 24554 RVA: 0x0029C48C File Offset: 0x0029A68C
	public static bool a(Point A_0, ICollection<Point> A_1, Vector2? A_2 = null)
	{
		Vector2 vector;
		if (A_2 != null)
		{
			vector = A_2.Value;
		}
		else
		{
			vector = Vector2.One / 2f;
		}
		Point item = new Point((int)((float)A_0.X / 4f + vector.X), (int)((float)A_0.Y / 4f + vector.Y));
		return A_1.Contains(item);
	}
}
