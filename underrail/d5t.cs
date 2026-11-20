using System;
using System.Collections.Generic;

// Token: 0x02001C33 RID: 7219
[d29("PsychoNeuralOptimization", "Psycho-neural Optimization")]
public sealed class d5t : ai8
{
	// Token: 0x06009E90 RID: 40592 RVA: 0x003E23E4 File Offset: 0x003E05E4
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009E91 RID: 40593 RVA: 0x003E23E8 File Offset: 0x003E05E8
	public d5t() : base("臘Психоневральная оптимизация")
	{
	}

	// Token: 0x06009E92 RID: 40594 RVA: 0x003E23F8 File Offset: 0x003E05F8
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(axr), 8),
			new db7(55),
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new c2y(new Type[]
			{
				typeof(e0z)
			})
		};
	}

	// Token: 0x06009E93 RID: 40595 RVA: 0x003E246C File Offset: 0x003E066C
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(d5t.a * 100.0)
		};
	}

	// Token: 0x04003D74 RID: 15732
	public new static readonly double a = 0.10000000149011612;
}
