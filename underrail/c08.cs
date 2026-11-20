using System;

// Token: 0x0200020C RID: 524
public sealed class c08
{
	// Token: 0x06000ECF RID: 3791 RVA: 0x0003E27C File Offset: 0x0003C47C
	public c08(int A_0 = 7)
	{
		this.a = new br[A_0, cb4.a.c, cb4.a.d];
	}

	// Token: 0x06000ED0 RID: 3792 RVA: 0x0003E2A4 File Offset: 0x0003C4A4
	public c08(br[,,] A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000ED1 RID: 3793 RVA: 0x0003E2B8 File Offset: 0x0003C4B8
	public void a()
	{
		for (int i = 0; i < this.a.GetLength(0); i++)
		{
			for (int j = 0; j < cb4.a.c; j++)
			{
				for (int k = 0; k < cb4.a.d; k++)
				{
					this.a[i, j, k] = null;
				}
			}
		}
	}

	// Token: 0x040008D9 RID: 2265
	public br[,,] a;
}
