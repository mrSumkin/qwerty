using System;

// Token: 0x02000570 RID: 1392
public abstract class d2e : c47
{
	// Token: 0x060023F0 RID: 9200 RVA: 0x000C7024 File Offset: 0x000C5224
	public c7j c()
	{
		return this.a;
	}

	// Token: 0x060023F1 RID: 9201 RVA: 0x000C702C File Offset: 0x000C522C
	public c5x d()
	{
		return this.b;
	}

	// Token: 0x060023F2 RID: 9202 RVA: 0x000C7034 File Offset: 0x000C5234
	public d2e(c5x A_0, c7j A_1)
	{
		czh.a(A_0, "opener");
		czh.a(A_1, "container");
		this.b = A_0;
		this.a = A_1;
	}

	// Token: 0x040014CE RID: 5326
	private c7j a;

	// Token: 0x040014CF RID: 5327
	private c5x b;
}
