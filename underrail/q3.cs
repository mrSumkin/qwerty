using System;
using System.Collections.Generic;

// Token: 0x02001C9A RID: 7322
[d29("Wrestling", "Wrestling")]
public sealed class q3 : ai8
{
	// Token: 0x0600A079 RID: 41081 RVA: 0x003E59EC File Offset: 0x003E3BEC
	public q3() : base("臆Борьба")
	{
	}

	// Token: 0x0600A07A RID: 41082 RVA: 0x003E59FC File Offset: 0x003E3BFC
	public override object[] at()
	{
		return new object[]
		{
			(int)(q3.a * 100.0),
			s1.a,
			s1.b,
			(int)(s1.c * 100.0),
			s1.d
		};
	}

	// Token: 0x0600A07B RID: 41083 RVA: 0x003E5A68 File Offset: 0x003E3C68
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(d3m), 7),
			new bap(40, new Type[]
			{
				typeof(jk)
			})
		};
	}

	// Token: 0x04003DD3 RID: 15827
	public new static readonly double a = 0.5;
}
