using System;
using System.Collections.Generic;

// Token: 0x020006B8 RID: 1720
public sealed class bny
{
	// Token: 0x06002CA0 RID: 11424 RVA: 0x000FF338 File Offset: 0x000FD538
	public bny()
	{
	}

	// Token: 0x06002CA1 RID: 11425 RVA: 0x000FF34C File Offset: 0x000FD54C
	public bny(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002CA2 RID: 11426 RVA: 0x000FF36C File Offset: 0x000FD56C
	public bny(string A_0, params string[] A_1)
	{
		this.a = A_0;
		if (A_1 != null)
		{
			foreach (string a_ in A_1)
			{
				this.b.Add(new apr(a_, null));
			}
		}
	}

	// Token: 0x06002CA3 RID: 11427 RVA: 0x000FF3CC File Offset: 0x000FD5CC
	public bny(string A_0, params apr[] A_1)
	{
		this.a = A_0;
		this.b.AddRange(A_1);
	}

	// Token: 0x04001952 RID: 6482
	public string a;

	// Token: 0x04001953 RID: 6483
	public List<apr> b = new List<apr>();
}
