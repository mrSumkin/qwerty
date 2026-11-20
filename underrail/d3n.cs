using System;
using System.Collections.Generic;

// Token: 0x02001C5D RID: 7261
[d29("Scrutinous", "Scrutinous")]
public sealed class d3n : aw2
{
	// Token: 0x06009F31 RID: 40753 RVA: 0x003E354C File Offset: 0x003E174C
	public d3n() : base("肚Белке в глаз")
	{
	}

	// Token: 0x06009F32 RID: 40754 RVA: 0x003E355C File Offset: 0x003E175C
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(d3n.a * 100.0)
		};
	}

	// Token: 0x06009F33 RID: 40755 RVA: 0x003E3580 File Offset: 0x003E1780
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new dvq(d3n.a, cs5.a)
		};
	}

	// Token: 0x06009F34 RID: 40756 RVA: 0x003E359C File Offset: 0x003E179C
	public override List<brl> j0()
	{
		List<brl> list = base.j0();
		list.Add(new awr(typeof(eav), 11));
		list.Add(new bap(120, new Type[]
		{
			typeof(jk),
			typeof(ct7),
			typeof(e8k),
			typeof(e5n)
		}));
		return list;
	}

	// Token: 0x04003D96 RID: 15766
	public new static readonly double a = 0.07;
}
