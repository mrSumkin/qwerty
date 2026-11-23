using System;
using System.Collections.Generic;

// Token: 0x020005C7 RID: 1479
public sealed class cqd : ae1
{
	// Token: 0x06002745 RID: 10053 RVA: 0x000E4468 File Offset: 0x000E2668
	public override string gr()
	{
		return "localeId";
	}

	// Token: 0x06002746 RID: 10054 RVA: 0x000E4470 File Offset: 0x000E2670
	public override object gs(string A_0)
	{
		if (A_0 != null)
		{
			return c2w.a(A_0);
		}
		return null;
	}

	// Token: 0x06002747 RID: 10055 RVA: 0x000E4484 File Offset: 0x000E2684
	protected override List<object> gt()
	{
		List<object> list = new List<object>();
		foreach (bfc bfc in bpo.GetServiceOrThrow<cnk>().aq0().a())
		{
			list.Add(bfc.Id.ToLowerInvariant());
		}
		return list;
	}
}
