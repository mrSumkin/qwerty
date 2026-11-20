using System;
using Microsoft.Xna.Framework;

// Token: 0x020000C9 RID: 201
public static class d6e
{
	// Token: 0x06000471 RID: 1137 RVA: 0x0001444C File Offset: 0x0001264C
	public static Vector2 b(this Vector3 A_0)
	{
		return new Vector2(A_0.X, A_0.Y);
	}

	// Token: 0x06000472 RID: 1138 RVA: 0x00014460 File Offset: 0x00012660
	public static Vector3 b(this Vector2 A_0)
	{
		return new Vector3(A_0, 0f);
	}

	// Token: 0x06000473 RID: 1139 RVA: 0x00014470 File Offset: 0x00012670
	public static Point a(this Vector2 A_0)
	{
		return new Point((int)A_0.X, (int)A_0.Y);
	}

	// Token: 0x06000474 RID: 1140 RVA: 0x00014488 File Offset: 0x00012688
	public static Point a(this Vector3 A_0)
	{
		return new Point((int)A_0.X, (int)A_0.Y);
	}
}
