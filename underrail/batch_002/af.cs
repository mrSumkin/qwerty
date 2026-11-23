using System;
using System.Collections.Generic;

// Token: 0x020004C0 RID: 1216
[AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
public sealed class af : Attribute
{
	// Token: 0x06001F15 RID: 7957 RVA: 0x000AC284 File Offset: 0x000AA484
	public List<string> a()
	{
		return this.a;
	}

	// Token: 0x06001F16 RID: 7958 RVA: 0x000AC28C File Offset: 0x000AA48C
	public af(params string[] A_0)
	{
		if (A_0 != null)
		{
			this.a = new List<string>(A_0);
			return;
		}
		this.a = new List<string>();
	}

	// Token: 0x040013AD RID: 5037
	private List<string> a;
}
