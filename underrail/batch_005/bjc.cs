using System;
using Microsoft.Xna.Framework;

// Token: 0x0200021C RID: 540
public sealed class bjc : e0
{
	// Token: 0x06000F13 RID: 3859 RVA: 0x0003F2CC File Offset: 0x0003D4CC
	public static bjc a()
	{
		return bjc.a;
	}

	// Token: 0x06000F14 RID: 3860 RVA: 0x0003F2D8 File Offset: 0x0003D4D8
	public int p4(Point A_0, Point A_1)
	{
		return (int)(Math.Sqrt(Math.Pow((double)(A_1.X - A_0.X), 2.0) + Math.Pow((double)(A_1.Y - A_0.Y), 2.0)) * 10.0);
	}

	// Token: 0x0400090B RID: 2315
	private static bjc a = new bjc();
}
