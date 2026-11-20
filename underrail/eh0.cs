using System;
using System.Collections.Generic;

// Token: 0x02001B67 RID: 7015
public sealed class eh0 : cb6
{
	// Token: 0x060097F1 RID: 38897 RVA: 0x003B2E5C File Offset: 0x003B105C
	public int aha()
	{
		return this.a;
	}

	// Token: 0x060097F2 RID: 38898 RVA: 0x003B2E64 File Offset: 0x003B1064
	public HashSet<string> a()
	{
		return this.b;
	}

	// Token: 0x060097F3 RID: 38899 RVA: 0x003B2E70 File Offset: 0x003B1070
	public bool ahb(coh A_0)
	{
		return A_0 != null && A_0.Definition != null && A_0.Definition.a5() != null && this.b.Contains(A_0.Definition.a5());
	}

	// Token: 0x060097F4 RID: 38900 RVA: 0x003B2EB8 File Offset: 0x003B10B8
	public eh0(string[] A_0, int A_1)
	{
		this.b = new HashSet<string>(A_0);
		this.a = A_1;
	}

	// Token: 0x060097F5 RID: 38901 RVA: 0x003B2ED4 File Offset: 0x003B10D4
	public eh0(string A_0, int A_1)
	{
		HashSet<string> hashSet = new HashSet<string>();
		hashSet.Add(A_0);
		this.b = hashSet;
		this.a = A_1;
	}

	// Token: 0x04003A52 RID: 14930
	private int a;

	// Token: 0x04003A53 RID: 14931
	private HashSet<string> b;
}
