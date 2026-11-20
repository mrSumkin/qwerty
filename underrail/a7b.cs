using System;

// Token: 0x020006C3 RID: 1731
public sealed class a7b
{
	// Token: 0x06002CB7 RID: 11447 RVA: 0x000FF610 File Offset: 0x000FD810
	public c3r b()
	{
		return this.a;
	}

	// Token: 0x06002CB8 RID: 11448 RVA: 0x000FF618 File Offset: 0x000FD818
	public TimeSpan a()
	{
		return this.b;
	}

	// Token: 0x06002CB9 RID: 11449 RVA: 0x000FF620 File Offset: 0x000FD820
	public a7b(c3r A_0, TimeSpan A_1)
	{
		czh.a(A_0, "notification");
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06002CBA RID: 11450 RVA: 0x000FF644 File Offset: 0x000FD844
	public double a(TimeSpan A_0)
	{
		return (A_0 - this.b).TotalMilliseconds;
	}

	// Token: 0x06002CBB RID: 11451 RVA: 0x000FF668 File Offset: 0x000FD868
	public double a(TimeSpan A_0, double A_1)
	{
		double num = this.a(A_0);
		return d05.b(0.0, num / A_1, 1.0);
	}

	// Token: 0x0400196C RID: 6508
	private c3r a;

	// Token: 0x0400196D RID: 6509
	private TimeSpan b;
}
