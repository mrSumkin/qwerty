using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x020000FC RID: 252
internal class ebo
{
	// Token: 0x060005F1 RID: 1521 RVA: 0x0001A0B0 File Offset: 0x000182B0
	public ebo(Point A_0, beb A_1)
	{
		this.b = A_1;
		this.a = A_1;
		this.d = A_0;
	}

	// Token: 0x060005F2 RID: 1522 RVA: 0x0001A0D8 File Offset: 0x000182D8
	public beb b()
	{
		return this.a;
	}

	// Token: 0x060005F3 RID: 1523 RVA: 0x0001A0E0 File Offset: 0x000182E0
	public beb a()
	{
		return this.b;
	}

	// Token: 0x060005F4 RID: 1524 RVA: 0x0001A0E8 File Offset: 0x000182E8
	public List<p2> d()
	{
		return this.c;
	}

	// Token: 0x060005F5 RID: 1525 RVA: 0x0001A0F0 File Offset: 0x000182F0
	public Point c()
	{
		return this.d;
	}

	// Token: 0x060005F6 RID: 1526 RVA: 0x0001A0F8 File Offset: 0x000182F8
	public bool b(beb A_0)
	{
		return (this.b & A_0) == A_0;
	}

	// Token: 0x060005F7 RID: 1527 RVA: 0x0001A108 File Offset: 0x00018308
	public void a(beb A_0)
	{
		this.b &= ~A_0;
	}

	// Token: 0x040004C3 RID: 1219
	private beb a;

	// Token: 0x040004C4 RID: 1220
	private beb b;

	// Token: 0x040004C5 RID: 1221
	private List<p2> c = new List<p2>();

	// Token: 0x040004C6 RID: 1222
	private Point d;
}
