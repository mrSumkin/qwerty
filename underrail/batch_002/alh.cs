using System;
using Microsoft.Xna.Framework;

// Token: 0x0200021D RID: 541
public sealed class alh : e0
{
	// Token: 0x06000F17 RID: 3863 RVA: 0x0003F344 File Offset: 0x0003D544
	public static alh a()
	{
		return alh.a;
	}

	// Token: 0x06000F18 RID: 3864 RVA: 0x0003F34C File Offset: 0x0003D54C
	public int p4(Point A_0, Point A_1)
	{
		return (Math.Abs(A_1.X - A_0.X) + Math.Abs(A_1.Y - A_0.Y)) * 10;
	}

	// Token: 0x0400090C RID: 2316
	private static alh a = new alh();
}
