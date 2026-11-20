using System;
using System.Collections.Generic;

// Token: 0x020006BD RID: 1725
public sealed class euy
{
	// Token: 0x06002CA8 RID: 11432 RVA: 0x000FF428 File Offset: 0x000FD628
	public euy(string A_0, euy A_1 = null, bool A_2 = true)
	{
		this.d = A_2;
		this.a = A_0.Replace(" ", "_").ToLowerInvariant();
		if (A_1 != null)
		{
			this.a = A_1.a + "." + this.a;
		}
		this.b = A_0;
	}

	// Token: 0x06002CA9 RID: 11433 RVA: 0x000FF494 File Offset: 0x000FD694
	public euy a(string A_0, bool A_1 = true)
	{
		euy euy = new euy(A_0, this, A_1);
		this.c.Add(euy);
		return euy;
	}

	// Token: 0x04001960 RID: 6496
	public string a;

	// Token: 0x04001961 RID: 6497
	public string b;

	// Token: 0x04001962 RID: 6498
	public List<euy> c = new List<euy>();

	// Token: 0x04001963 RID: 6499
	public bool d;
}
