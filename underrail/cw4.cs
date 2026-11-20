using System;
using System.Collections.Generic;

// Token: 0x020005B8 RID: 1464
public sealed class cw4 : ae1
{
	// Token: 0x0600270B RID: 9995 RVA: 0x000E3554 File Offset: 0x000E1754
	public override string gr()
	{
		return "blueprint";
	}

	// Token: 0x0600270C RID: 9996 RVA: 0x000E355C File Offset: 0x000E175C
	public override object gs(string A_0)
	{
		return d79.a(A_0);
	}

	// Token: 0x0600270D RID: 9997 RVA: 0x000E3568 File Offset: 0x000E1768
	protected override List<object> gt()
	{
		List<object> list = new List<object>();
		foreach (cwp cwp in d79.a())
		{
			list.Add(cwp.TechnicalName);
		}
		return list;
	}
}
