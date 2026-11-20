using System;

// Token: 0x0200020D RID: 525
public sealed class cbn
{
	// Token: 0x06000ED2 RID: 3794 RVA: 0x0003E320 File Offset: 0x0003C520
	public cbn(int A_0 = 7)
	{
		this.a = new eyu[A_0, cb4.a.c, cb4.a.d];
	}

	// Token: 0x06000ED3 RID: 3795 RVA: 0x0003E348 File Offset: 0x0003C548
	public cbn(eyu[,,] A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000ED4 RID: 3796 RVA: 0x0003E35C File Offset: 0x0003C55C
	public void a()
	{
		for (int i = 0; i < this.a.GetLength(0); i++)
		{
			for (int j = 0; j < cb4.a.c; j++)
			{
				for (int k = 0; k < cb4.a.d; k++)
				{
					this.a[i, j, k].f = false;
				}
			}
		}
	}

	// Token: 0x040008DA RID: 2266
	public eyu[,,] a;
}
