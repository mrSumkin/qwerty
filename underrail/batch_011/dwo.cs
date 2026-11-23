using System;

// Token: 0x020000F5 RID: 245
internal class dwo : IComparable<dwo>
{
	// Token: 0x06000595 RID: 1429 RVA: 0x00018204 File Offset: 0x00016404
	public int a()
	{
		return this.a;
	}

	// Token: 0x06000596 RID: 1430 RVA: 0x0001820C File Offset: 0x0001640C
	public dwo()
	{
	}

	// Token: 0x06000597 RID: 1431 RVA: 0x00018214 File Offset: 0x00016414
	public dwo(eso A_0)
	{
		this.a = (int)A_0;
	}

	// Token: 0x06000598 RID: 1432 RVA: 0x00018224 File Offset: 0x00016424
	public dwo(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000599 RID: 1433 RVA: 0x00018234 File Offset: 0x00016434
	public void a(eso A_0)
	{
		this.a = (int)A_0;
	}

	// Token: 0x0600059A RID: 1434 RVA: 0x00018240 File Offset: 0x00016440
	public void b(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600059B RID: 1435 RVA: 0x0001824C File Offset: 0x0001644C
	public void a(int A_0)
	{
		if ((this.a += A_0) > 6000)
		{
			this.a(eso.g);
		}
	}

	// Token: 0x0600059C RID: 1436 RVA: 0x00018280 File Offset: 0x00016480
	public void c(int A_0)
	{
		if ((this.a -= A_0) < 0)
		{
			this.a(eso.a);
		}
	}

	// Token: 0x0600059D RID: 1437 RVA: 0x000182AC File Offset: 0x000164AC
	public int CompareTo(dwo other)
	{
		if (other == null)
		{
			return int.MaxValue;
		}
		return this.a().CompareTo(other.a());
	}

	// Token: 0x0400049B RID: 1179
	private int a;
}
