using System;
using System.Collections.Generic;

// Token: 0x020005BB RID: 1467
public sealed class exv : ae1
{
	// Token: 0x06002717 RID: 10007 RVA: 0x000E38E4 File Offset: 0x000E1AE4
	public override string gr()
	{
		return "joblet";
	}

	// Token: 0x06002718 RID: 10008 RVA: 0x000E38EC File Offset: 0x000E1AEC
	public override object gs(string A_0)
	{
		if (A_0 != null)
		{
			return A_0.Trim();
		}
		return null;
	}

	// Token: 0x06002719 RID: 10009 RVA: 0x000E3900 File Offset: 0x000E1B00
	protected override List<object> gt()
	{
		List<object> list = new List<object>();
		foreach (string item in ea5.b().Keys)
		{
			list.Add(item);
		}
		return list;
	}
}
