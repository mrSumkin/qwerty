using System;
using System.Collections.Generic;

// Token: 0x02001C31 RID: 7217
[d29("ExpandedPsiCapacitance", "Expanded Psi Capacitance")]
public sealed class eqt : ai8
{
	// Token: 0x06009E88 RID: 40584 RVA: 0x003E2290 File Offset: 0x003E0490
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009E89 RID: 40585 RVA: 0x003E2294 File Offset: 0x003E0494
	public eqt() : base("臚Расширенный пси-резерв")
	{
	}

	// Token: 0x06009E8A RID: 40586 RVA: 0x003E22A4 File Offset: 0x003E04A4
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(eqt.a * 100.0),
			Convert.ToInt32(eqt.b * 100.0)
		};
	}

	// Token: 0x06009E8B RID: 40587 RVA: 0x003E22E4 File Offset: 0x003E04E4
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(av8), 5),
			new db7(25),
			new b4k(new Type[]
			{
				typeof(c3v)
			})
		};
	}

	// Token: 0x04003D72 RID: 15730
	public new static readonly double a = 0.3;

	// Token: 0x04003D73 RID: 15731
	public new static readonly double b = 0.01;
}
