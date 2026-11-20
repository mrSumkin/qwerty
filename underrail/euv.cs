using System;
using System.Collections.Generic;

// Token: 0x02001C97 RID: 7319
[d29("Salesman", "Salesman")]
public sealed class euv : ai8
{
	// Token: 0x0600A06B RID: 41067 RVA: 0x003E5874 File Offset: 0x003E3A74
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A06C RID: 41068 RVA: 0x003E5878 File Offset: 0x003E3A78
	public euv() : base("肇Продавец")
	{
	}

	// Token: 0x0600A06D RID: 41069 RVA: 0x003E5888 File Offset: 0x003E3A88
	public override object[] at()
	{
		return new object[]
		{
			(int)(euv.a * 100.0)
		};
	}

	// Token: 0x0600A06E RID: 41070 RVA: 0x003E58AC File Offset: 0x003E3AAC
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(av8), 6),
			new bap(35, new Type[]
			{
				typeof(e70)
			})
		};
	}

	// Token: 0x04003DD1 RID: 15825
	public new static readonly double a = 0.01;
}
