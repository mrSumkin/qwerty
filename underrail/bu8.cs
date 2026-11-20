using System;
using System.Collections.Generic;

// Token: 0x02001CD4 RID: 7380
[d29("PsychotemporalAcceleration", "Psycho-temporal Acceleration")]
public sealed class bu8 : ai8
{
	// Token: 0x0600A1F7 RID: 41463 RVA: 0x003E852C File Offset: 0x003E672C
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A1F8 RID: 41464 RVA: 0x003E8534 File Offset: 0x003E6734
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A1F9 RID: 41465 RVA: 0x003E8538 File Offset: 0x003E6738
	public bu8() : base("臹Психо-временное ускорение")
	{
	}

	// Token: 0x0600A1FA RID: 41466 RVA: 0x003E8548 File Offset: 0x003E6748
	public override object[] at()
	{
		return new object[]
		{
			bu8.a,
			l4.a(bu8.b, false)
		};
	}

	// Token: 0x0600A1FB RID: 41467 RVA: 0x003E8570 File Offset: 0x003E6770
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(45, new Type[]
			{
				typeof(p5)
			}),
			new b6h(new Type[]
			{
				typeof(c0o),
				typeof(c4n)
			})
		};
	}

	// Token: 0x04003E1E RID: 15902
	public new static readonly int a = 5;

	// Token: 0x04003E1F RID: 15903
	public new static readonly int b = 1;
}
