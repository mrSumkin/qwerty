using System;

// Token: 0x0200056C RID: 1388
public abstract class epm : c47
{
	// Token: 0x060023E7 RID: 9191 RVA: 0x000C6EC8 File Offset: 0x000C50C8
	public akr c()
	{
		return this.a;
	}

	// Token: 0x060023E8 RID: 9192 RVA: 0x000C6ED0 File Offset: 0x000C50D0
	public c5x d()
	{
		return this.b;
	}

	// Token: 0x060023E9 RID: 9193 RVA: 0x000C6ED8 File Offset: 0x000C50D8
	public epm(c5x A_0, akr A_1)
	{
		czh.a(A_0, "opener");
		czh.a(A_1, "camera");
		this.b = A_0;
		this.a = A_1;
	}

	// Token: 0x040014CC RID: 5324
	private akr a;

	// Token: 0x040014CD RID: 5325
	private c5x b;
}
