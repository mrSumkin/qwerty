using System;
using System.Collections.Generic;

// Token: 0x02001B68 RID: 7016
public sealed class c6s : cb6
{
	// Token: 0x060097F6 RID: 38902 RVA: 0x003B2EF8 File Offset: 0x003B10F8
	public int aha()
	{
		return this.a;
	}

	// Token: 0x060097F7 RID: 38903 RVA: 0x003B2F04 File Offset: 0x003B1104
	public bool ahb(coh A_0)
	{
		if (A_0 != null)
		{
			a1k a1k = A_0.Definition as a1k;
			if (a1k != null && this.b.Contains(a1k.i()))
			{
				return true;
			}
			if (this.c != null && A_0.Definition != null && A_0.Definition.a5() != null && this.c.Contains(A_0.Definition.a5()))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060097F8 RID: 38904 RVA: 0x003B2F88 File Offset: 0x003B1188
	public c6s(ms A_0, int A_1)
	{
		HashSet<ms> hashSet = new HashSet<ms>();
		hashSet.Add(A_0);
		this.b = hashSet;
		this.a = A_1;
	}

	// Token: 0x060097F9 RID: 38905 RVA: 0x003B2FAC File Offset: 0x003B11AC
	public c6s(ms[] A_0, int A_1)
	{
		this.b = new HashSet<ms>(A_0);
		this.a = A_1;
	}

	// Token: 0x060097FA RID: 38906 RVA: 0x003B2FCC File Offset: 0x003B11CC
	public c6s(ms[] A_0, string[] A_1, int A_2)
	{
		this.b = new HashSet<ms>(A_0);
		if (A_1 != null && A_1.Length != 0)
		{
			this.c = new HashSet<string>();
			foreach (string text in A_1)
			{
				this.c.Add(text);
			}
		}
		this.a = A_2;
	}

	// Token: 0x04003A54 RID: 14932
	private int a;

	// Token: 0x04003A55 RID: 14933
	private HashSet<ms> b;

	// Token: 0x04003A56 RID: 14934
	private HashSet<string> c;
}
