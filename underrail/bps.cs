using System;
using System.Collections.Generic;

// Token: 0x02001441 RID: 5185
public sealed class bps
{
	// Token: 0x0600749B RID: 29851 RVA: 0x00317638 File Offset: 0x00315838
	public bool b(string A_0)
	{
		return this.a.ContainsKey(A_0);
	}

	// Token: 0x0600749C RID: 29852 RVA: 0x00317648 File Offset: 0x00315848
	public void a(string A_0)
	{
		this.a[A_0] = true;
	}

	// Token: 0x04002FA4 RID: 12196
	public Dictionary<string, object> a = new Dictionary<string, object>();
}
