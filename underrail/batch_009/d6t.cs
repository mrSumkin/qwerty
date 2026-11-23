using System;
using System.Collections.Generic;

// Token: 0x02001C61 RID: 7265
[d29("CorporealProjection", "Corporeal Projection")]
public sealed class d6t : ai8
{
	// Token: 0x06009F48 RID: 40776 RVA: 0x003E372C File Offset: 0x003E192C
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009F49 RID: 40777 RVA: 0x003E3730 File Offset: 0x003E1930
	public d6t() : base("臨Телесная проекция")
	{
	}

	// Token: 0x06009F4A RID: 40778 RVA: 0x003E3740 File Offset: 0x003E1940
	public override void ar(efk A_0)
	{
	}

	// Token: 0x06009F4B RID: 40779 RVA: 0x003E3744 File Offset: 0x003E1944
	public override void @as(efk A_0)
	{
	}

	// Token: 0x06009F4C RID: 40780 RVA: 0x003E3748 File Offset: 0x003E1948
	public override object[] at()
	{
		return new object[]
		{
			(int)(d6t.a * 100.0),
			d6t.b
		};
	}

	// Token: 0x06009F4D RID: 40781 RVA: 0x003E3778 File Offset: 0x003E1978
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(d3m), 6),
			new b6h(new Type[]
			{
				typeof(dxh),
				typeof(e5o)
			})
		};
	}

	// Token: 0x04003D97 RID: 15767
	public new static readonly double a = 0.05;

	// Token: 0x04003D98 RID: 15768
	public new static readonly int b = 5;
}
