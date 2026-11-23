using System;
using Microsoft.Xna.Framework;

// Token: 0x020000EE RID: 238
public struct etd
{
	// Token: 0x06000565 RID: 1381 RVA: 0x00017AF0 File Offset: 0x00015CF0
	public int e()
	{
		return this.a;
	}

	// Token: 0x06000566 RID: 1382 RVA: 0x00017AF8 File Offset: 0x00015CF8
	public void c(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000567 RID: 1383 RVA: 0x00017B04 File Offset: 0x00015D04
	public int a()
	{
		return this.b;
	}

	// Token: 0x06000568 RID: 1384 RVA: 0x00017B0C File Offset: 0x00015D0C
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06000569 RID: 1385 RVA: 0x00017B18 File Offset: 0x00015D18
	public int d()
	{
		return this.c;
	}

	// Token: 0x0600056A RID: 1386 RVA: 0x00017B20 File Offset: 0x00015D20
	public void d(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600056B RID: 1387 RVA: 0x00017B2C File Offset: 0x00015D2C
	public int b()
	{
		return this.d;
	}

	// Token: 0x0600056C RID: 1388 RVA: 0x00017B34 File Offset: 0x00015D34
	public void b(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600056D RID: 1389 RVA: 0x00017B40 File Offset: 0x00015D40
	public static etd a(etd A_0, double A_1)
	{
		if (A_1 == 0.0)
		{
			throw new DivideByZeroException();
		}
		etd result = A_0;
		result.c((int)((double)result.e() / A_1));
		result.a((int)((double)result.a() / A_1));
		result.d((int)((double)result.d() / A_1));
		result.b((int)((double)result.b() / A_1));
		return result;
	}

	// Token: 0x0600056E RID: 1390 RVA: 0x00017BB0 File Offset: 0x00015DB0
	public static etd a(etd A_0, Color A_1)
	{
		etd result = A_0;
		result.c(result.e() + (int)A_1.R);
		result.a(result.a() + (int)A_1.G);
		result.d(result.d() + (int)A_1.B);
		result.b(result.b() + (int)A_1.A);
		return result;
	}

	// Token: 0x0600056F RID: 1391 RVA: 0x00017C14 File Offset: 0x00015E14
	public static bool b(etd A_0, etd A_1)
	{
		return A_0.Equals(A_1);
	}

	// Token: 0x06000570 RID: 1392 RVA: 0x00017C2C File Offset: 0x00015E2C
	public static bool a(etd A_0, etd A_1)
	{
		return !A_0.Equals(A_1);
	}

	// Token: 0x06000571 RID: 1393 RVA: 0x00017C48 File Offset: 0x00015E48
	public Color c()
	{
		return new Color
		{
			R = (byte)Math.Min(255, Math.Max(0, this.e())),
			G = (byte)Math.Min(255, Math.Max(0, this.a())),
			B = (byte)Math.Min(255, Math.Max(0, this.d())),
			A = (byte)Math.Min(255, Math.Max(0, this.b()))
		};
	}

	// Token: 0x06000572 RID: 1394 RVA: 0x00017CD8 File Offset: 0x00015ED8
	public override bool Equals(object obj)
	{
		if (obj is etd)
		{
			etd etd = (etd)obj;
			return this.a == etd.a && this.b == etd.b && this.c == etd.c && this.d == etd.d;
		}
		return false;
	}

	// Token: 0x06000573 RID: 1395 RVA: 0x00017D3C File Offset: 0x00015F3C
	public override int GetHashCode()
	{
		return this.a.GetHashCode() + this.c.GetHashCode() + this.b.GetHashCode() + this.d.GetHashCode();
	}

	// Token: 0x0400048F RID: 1167
	private int a;

	// Token: 0x04000490 RID: 1168
	private int b;

	// Token: 0x04000491 RID: 1169
	private int c;

	// Token: 0x04000492 RID: 1170
	private int d;
}
