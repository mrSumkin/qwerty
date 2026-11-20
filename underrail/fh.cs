using System;
using System.Collections.Generic;

// Token: 0x02000362 RID: 866
public sealed class fh : abg
{
	// Token: 0x0600183F RID: 6207 RVA: 0x0007B3A0 File Offset: 0x000795A0
	public fh(params arr[] A_0)
	{
		this.a = new List<arr>(A_0);
	}

	// Token: 0x06001840 RID: 6208 RVA: 0x0007B3B4 File Offset: 0x000795B4
	public void a(params arr[] A_0)
	{
		this.a = new List<arr>(A_0);
	}

	// Token: 0x06001841 RID: 6209 RVA: 0x0007B3C4 File Offset: 0x000795C4
	public override abg f7()
	{
		if (this.a != null && this.a.Count > 0)
		{
			foreach (arr arr in this.a)
			{
				if (arr.b == null || arr.b(base.b()))
				{
					return arr.a;
				}
			}
		}
		return null;
	}

	// Token: 0x04000E3B RID: 3643
	public List<arr> a;
}
