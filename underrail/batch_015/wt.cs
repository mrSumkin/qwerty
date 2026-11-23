using System;
using System.Collections.Generic;

// Token: 0x020005E1 RID: 1505
public sealed class wt : ce8
{
	// Token: 0x0600279C RID: 10140 RVA: 0x000E635C File Offset: 0x000E455C
	public override string[] c6()
	{
		return new string[]
		{
			"revealGlobalMap",
			"revglobm"
		};
	}

	// Token: 0x0600279E RID: 10142 RVA: 0x000E637C File Offset: 0x000E457C
	public override lu c7(List<object> A_0)
	{
		bpo.GetServiceOrThrow<e5f>().aso();
		bdg.a("Global map revealed", new object[0]);
		return null;
	}
}
