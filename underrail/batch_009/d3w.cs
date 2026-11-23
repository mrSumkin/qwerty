using System;
using System.Collections.Generic;

// Token: 0x02001CD2 RID: 7378
[d29("ContinuumRipple", "Continuum Ripple")]
public sealed class d3w : ai8
{
	// Token: 0x0600A1EA RID: 41450 RVA: 0x003E83C4 File Offset: 0x003E65C4
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A1EB RID: 41451 RVA: 0x003E83CC File Offset: 0x003E65CC
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A1EC RID: 41452 RVA: 0x003E83D0 File Offset: 0x003E65D0
	public d3w() : base("臷Непрерывная пульсация")
	{
	}

	// Token: 0x0600A1ED RID: 41453 RVA: 0x003E83E0 File Offset: 0x003E65E0
	public override object[] at()
	{
		return new object[]
		{
			(int)(d3w.a * 100.0)
		};
	}

	// Token: 0x0600A1EE RID: 41454 RVA: 0x003E8404 File Offset: 0x003E6604
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(30, new Type[]
			{
				typeof(p5)
			}),
			new b6h(new Type[]
			{
				typeof(ed3)
			})
		};
	}

	// Token: 0x04003E1B RID: 15899
	public new static readonly double a = 0.25;
}
