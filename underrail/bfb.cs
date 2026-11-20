using System;
using Microsoft.Xna.Framework;

// Token: 0x020000C7 RID: 199
public static class bfb
{
	// Token: 0x0600046D RID: 1133 RVA: 0x000143FC File Offset: 0x000125FC
	public static Vector2 b(this Point A_0)
	{
		return new Vector2((float)A_0.X, (float)A_0.Y);
	}

	// Token: 0x0600046E RID: 1134 RVA: 0x00014414 File Offset: 0x00012614
	public static Vector3 a(this Point A_0, float A_1)
	{
		return new Vector3((float)A_0.X, (float)A_0.Y, A_1);
	}

	// Token: 0x0600046F RID: 1135 RVA: 0x0001442C File Offset: 0x0001262C
	public static Vector3 a(this Point A_0)
	{
		return A_0.a(0f);
	}
}
