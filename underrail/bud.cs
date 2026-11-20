using System;
using System.Collections.Generic;

// Token: 0x0200035E RID: 862
public sealed class bud : abg
{
	// Token: 0x06001835 RID: 6197 RVA: 0x0007B200 File Offset: 0x00079400
	public bud(Func<bud, int> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001836 RID: 6198 RVA: 0x0007B21C File Offset: 0x0007941C
	public bud()
	{
	}

	// Token: 0x06001837 RID: 6199 RVA: 0x0007B234 File Offset: 0x00079434
	public override abg f7()
	{
		if (this.b != null)
		{
			int num = this.b(this);
			if (num >= 0 && num < this.a.Count)
			{
				return this.a[num];
			}
		}
		return null;
	}

	// Token: 0x04000E35 RID: 3637
	public List<abg> a = new List<abg>();

	// Token: 0x04000E36 RID: 3638
	public Func<bud, int> b;
}
