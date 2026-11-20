using System;
using System.Collections.Generic;

// Token: 0x02001C30 RID: 7216
[d29("ForcefullInnervation", "Forceful Innervation")]
public sealed class ck5 : ai8
{
	// Token: 0x06009E82 RID: 40578 RVA: 0x003E2230 File Offset: 0x003E0430
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009E83 RID: 40579 RVA: 0x003E2234 File Offset: 0x003E0434
	public override bool aq()
	{
		return false;
	}

	// Token: 0x06009E84 RID: 40580 RVA: 0x003E2238 File Offset: 0x003E0438
	public ck5() : base("Волевая иннервация")
	{
	}

	// Token: 0x06009E85 RID: 40581 RVA: 0x003E2248 File Offset: 0x003E0448
	public override object[] at()
	{
		return new object[]
		{
			ck5.a
		};
	}

	// Token: 0x06009E86 RID: 40582 RVA: 0x003E2260 File Offset: 0x003E0460
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new d72(-ck5.a)
			{
				Priority = int.MaxValue
			}
		};
	}

	// Token: 0x04003D71 RID: 15729
	public new static readonly int a = 10;
}
