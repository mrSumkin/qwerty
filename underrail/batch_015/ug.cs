using System;

// Token: 0x02000214 RID: 532
internal class ug
{
	// Token: 0x06000EEB RID: 3819 RVA: 0x0003E734 File Offset: 0x0003C934
	public ug(er0 A_0)
	{
		this.a = A_0;
		this.b = A_0.ag.c.a;
	}

	// Token: 0x06000EEC RID: 3820 RVA: 0x0003E75C File Offset: 0x0003C95C
	public void a(ee4 A_0)
	{
		if (A_0.a.X >= 0 && A_0.a.Y >= 0)
		{
			this.b[this.a.a(A_0.b), A_0.a.X, A_0.a.Y] = true;
		}
	}

	// Token: 0x06000EED RID: 3821 RVA: 0x0003E7C0 File Offset: 0x0003C9C0
	public bool b(ee4 A_0)
	{
		return A_0.a.X >= 0 && A_0.a.Y >= 0 && this.b[this.a.a(A_0.b), A_0.a.X, A_0.a.Y];
	}

	// Token: 0x040008EE RID: 2286
	private er0 a;

	// Token: 0x040008EF RID: 2287
	private bool[,,] b;
}
