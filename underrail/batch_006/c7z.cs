using System;
using System.Collections.Generic;

// Token: 0x02001CCE RID: 7374
[d29("SpearGuardian", "Spear Guardian")]
public sealed class c7z : ai8
{
	// Token: 0x0600A1D0 RID: 41424 RVA: 0x003E80BC File Offset: 0x003E62BC
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A1D1 RID: 41425 RVA: 0x003E80C4 File Offset: 0x003E62C4
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A1D2 RID: 41426 RVA: 0x003E80C8 File Offset: 0x003E62C8
	public c7z() : base("膙Защитное копьё")
	{
	}

	// Token: 0x0600A1D3 RID: 41427 RVA: 0x003E80D8 File Offset: 0x003E62D8
	public override object[] at()
	{
		return new object[]
		{
			(int)(c7z.a * 100.0)
		};
	}

	// Token: 0x0600A1D4 RID: 41428 RVA: 0x003E80FC File Offset: 0x003E62FC
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(d3m), 6),
			new awr(typeof(cwu), 5),
			new bap(55, new Type[]
			{
				typeof(jk)
			})
		};
	}

	// Token: 0x04003E17 RID: 15895
	public new static readonly double a = 0.3;
}
