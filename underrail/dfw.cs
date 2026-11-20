using System;
using System.Collections.Generic;

// Token: 0x02001B62 RID: 7010
public sealed class dfw : cb6
{
	// Token: 0x060097E2 RID: 38882 RVA: 0x003B2C94 File Offset: 0x003B0E94
	public List<cb6> a()
	{
		return this.a;
	}

	// Token: 0x060097E3 RID: 38883 RVA: 0x003B2C9C File Offset: 0x003B0E9C
	public int aha()
	{
		return 0;
	}

	// Token: 0x060097E4 RID: 38884 RVA: 0x003B2CA4 File Offset: 0x003B0EA4
	public bool ahb(coh A_0)
	{
		using (List<cb6>.Enumerator enumerator = this.a.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.ahb(A_0))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x04003A4E RID: 14926
	private List<cb6> a = new List<cb6>();
}
