using System;
using System.Collections.Generic;

// Token: 0x020006C6 RID: 1734
public sealed class cmh
{
	// Token: 0x06002CC4 RID: 11460 RVA: 0x000FF6EC File Offset: 0x000FD8EC
	public b0b a()
	{
		return this.a;
	}

	// Token: 0x06002CC5 RID: 11461 RVA: 0x000FF6F4 File Offset: 0x000FD8F4
	public void a(b0b A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002CC6 RID: 11462 RVA: 0x000FF700 File Offset: 0x000FD900
	public List<a7b> c()
	{
		return this.b;
	}

	// Token: 0x06002CC7 RID: 11463 RVA: 0x000FF708 File Offset: 0x000FD908
	public TimeSpan b()
	{
		return this.d;
	}

	// Token: 0x06002CC8 RID: 11464 RVA: 0x000FF710 File Offset: 0x000FD910
	public cmh(b0b A_0)
	{
		czh.a(A_0, "source");
		this.a = A_0;
	}

	// Token: 0x06002CC9 RID: 11465 RVA: 0x000FF744 File Offset: 0x000FD944
	public bool a(TimeSpan A_0, TimeSpan A_1, TimeSpan A_2)
	{
		while (this.b.Count > 0 && this.b[0].a() + A_2 <= A_0)
		{
			this.b.RemoveAt(0);
		}
		if (this.d < A_0 && this.c.Count > 0)
		{
			c3r c3r = this.c.Dequeue();
			if (c3r != null)
			{
				a7b item = new a7b(c3r, A_0);
				this.b.Add(item);
				this.d = A_0 + A_1;
			}
		}
		return this.b.Count == 0 && this.c.Count == 0;
	}

	// Token: 0x06002CCA RID: 11466 RVA: 0x000FF808 File Offset: 0x000FDA08
	public void a(c3r A_0)
	{
		this.c.Enqueue(A_0);
	}

	// Token: 0x0400196E RID: 6510
	private b0b a;

	// Token: 0x0400196F RID: 6511
	private List<a7b> b = new List<a7b>();

	// Token: 0x04001970 RID: 6512
	private Queue<c3r> c = new Queue<c3r>();

	// Token: 0x04001971 RID: 6513
	private TimeSpan d;
}
