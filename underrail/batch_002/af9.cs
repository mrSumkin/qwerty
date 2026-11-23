using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x02000123 RID: 291
internal class af9 : aq5
{
	// Token: 0x06000707 RID: 1799 RVA: 0x0001CA4C File Offset: 0x0001AC4C
	public af9() : base(113)
	{
	}

	// Token: 0x06000708 RID: 1800 RVA: 0x0001CA5C File Offset: 0x0001AC5C
	protected override Dictionary<string, SearchOption> oo()
	{
		Dictionary<string, SearchOption> dictionary = new Dictionary<string, SearchOption>();
		d67 d = dr3.d();
		if (d != null)
		{
			dictionary.Add(d.le(), 0);
		}
		return dictionary;
	}
}
