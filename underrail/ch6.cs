using System;

// Token: 0x0200020B RID: 523
public sealed class ch6
{
	// Token: 0x06000ECC RID: 3788 RVA: 0x0003E1D8 File Offset: 0x0003C3D8
	public ch6(int A_0 = 7)
	{
		this.a = new bool[A_0, cb4.a.c, cb4.a.d];
	}

	// Token: 0x06000ECD RID: 3789 RVA: 0x0003E200 File Offset: 0x0003C400
	public ch6(bool[,,] A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000ECE RID: 3790 RVA: 0x0003E214 File Offset: 0x0003C414
	public void a()
	{
		for (int i = 0; i < this.a.GetLength(0); i++)
		{
			for (int j = 0; j < cb4.a.c; j++)
			{
				for (int k = 0; k < cb4.a.d; k++)
				{
					this.a[i, j, k] = false;
				}
			}
		}
	}

	// Token: 0x040008D8 RID: 2264
	public bool[,,] a;
}
