using System;
using System.Collections.Generic;

// Token: 0x02001C73 RID: 7283
[d29("ImprovedThrowing", "Expert Throwing")]
public sealed class b2y : aw2
{
	// Token: 0x06009FAA RID: 40874 RVA: 0x003E4208 File Offset: 0x003E2408
	public b2y() : base("肜Эксперт метания")
	{
	}

	// Token: 0x06009FAB RID: 40875 RVA: 0x003E4218 File Offset: 0x003E2418
	public override object[] at()
	{
		return new object[]
		{
			(int)(b2y.a * 100.0)
		};
	}

	// Token: 0x06009FAC RID: 40876 RVA: 0x003E4238 File Offset: 0x003E2438
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new yt(b2y.a)
		};
	}

	// Token: 0x06009FAD RID: 40877 RVA: 0x003E4250 File Offset: 0x003E2450
	public override List<brl> j0()
	{
		List<brl> list = base.j0();
		list.Add(new awr(typeof(cwu), 10));
		list.Add(new bap(100, new Type[]
		{
			typeof(dei)
		}));
		return list;
	}

	// Token: 0x04003DAF RID: 15791
	public new static readonly double a = 0.1;
}
