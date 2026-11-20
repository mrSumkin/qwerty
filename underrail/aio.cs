using System;
using System.Collections.Generic;

// Token: 0x02001E08 RID: 7688
[d29("CT", "Cerebral Trauma")]
public sealed class aio : ai8
{
	// Token: 0x0600AA3F RID: 43583 RVA: 0x003F37F4 File Offset: 0x003F19F4
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600AA40 RID: 43584 RVA: 0x003F37F8 File Offset: 0x003F19F8
	public aio() : base("臡Мозговая травма")
	{
	}

	// Token: 0x0600AA41 RID: 43585 RVA: 0x003F3808 File Offset: 0x003F1A08
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(25, new Type[]
			{
				typeof(dql)
			}),
			new b6h(new Type[]
			{
				typeof(dzs)
			})
		};
	}

	// Token: 0x0600AA42 RID: 43586 RVA: 0x003F385C File Offset: 0x003F1A5C
	public override object[] at()
	{
		return new object[]
		{
			(int)(aio.a * 100.0),
			(int)(aio.b * 100.0)
		};
	}

	// Token: 0x04003FBB RID: 16315
	public new static readonly double a = 0.2;

	// Token: 0x04003FBC RID: 16316
	public new static readonly double b = 0.1;
}
