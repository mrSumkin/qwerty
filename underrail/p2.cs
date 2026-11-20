using System;
using System.Collections.ObjectModel;
using Microsoft.Xna.Framework;

// Token: 0x020000F8 RID: 248
public sealed class p2
{
	// Token: 0x060005B9 RID: 1465 RVA: 0x00018584 File Offset: 0x00016784
	public bool b()
	{
		return this.a;
	}

	// Token: 0x060005BA RID: 1466 RVA: 0x0001858C File Offset: 0x0001678C
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060005BB RID: 1467 RVA: 0x00018598 File Offset: 0x00016798
	public Collection<ig> g()
	{
		return this.c;
	}

	// Token: 0x060005BC RID: 1468 RVA: 0x000185A0 File Offset: 0x000167A0
	public Point f()
	{
		return this.b;
	}

	// Token: 0x060005BD RID: 1469 RVA: 0x000185A8 File Offset: 0x000167A8
	public void a(Point A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060005BE RID: 1470 RVA: 0x000185B4 File Offset: 0x000167B4
	public float c()
	{
		return this.d;
	}

	// Token: 0x060005BF RID: 1471 RVA: 0x000185BC File Offset: 0x000167BC
	public void a(float A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060005C0 RID: 1472 RVA: 0x000185C8 File Offset: 0x000167C8
	public beb a()
	{
		return this.e;
	}

	// Token: 0x060005C1 RID: 1473 RVA: 0x000185D0 File Offset: 0x000167D0
	public void a(beb A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060005C2 RID: 1474 RVA: 0x000185DC File Offset: 0x000167DC
	public void e()
	{
		foreach (ig ig in this.c)
		{
			ig.a().q9(this.b, ig.b(), this.d);
		}
	}

	// Token: 0x060005C3 RID: 1475 RVA: 0x00018648 File Offset: 0x00016848
	public void d()
	{
		foreach (ig ig in this.c)
		{
			if (ig.a().ra(this.b, ig.b(), this.d))
			{
				ig.a().rb(this.b, ig.b(), this.d);
			}
		}
	}

	// Token: 0x040004A3 RID: 1187
	private bool a;

	// Token: 0x040004A4 RID: 1188
	private Point b;

	// Token: 0x040004A5 RID: 1189
	private Collection<ig> c = new Collection<ig>();

	// Token: 0x040004A6 RID: 1190
	private float d;

	// Token: 0x040004A7 RID: 1191
	private beb e;
}
