using System;
using System.Collections.Generic;

// Token: 0x02001CA1 RID: 7329
[d29("SuppressiveFire", "Suppressive Fire")]
public sealed class be1 : ai8
{
	// Token: 0x0600A0A6 RID: 41126 RVA: 0x003E5EEC File Offset: 0x003E40EC
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A0A7 RID: 41127 RVA: 0x003E5EF0 File Offset: 0x003E40F0
	public be1() : base("胤Огонь на подавление")
	{
	}

	// Token: 0x0600A0A8 RID: 41128 RVA: 0x003E5F00 File Offset: 0x003E4100
	public override object[] at()
	{
		return new object[]
		{
			(int)(be1.a * 100.0),
			be1.b,
			be1.c,
			l4.a((double)be1.d, false)
		};
	}

	// Token: 0x0600A0A9 RID: 41129 RVA: 0x003E5F54 File Offset: 0x003E4154
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(eav), 6),
			new bap(10, new Type[]
			{
				typeof(ct7),
				typeof(e8k)
			})
		};
	}

	// Token: 0x04003DDD RID: 15837
	public new static readonly double a = 0.1;

	// Token: 0x04003DDE RID: 15838
	public new static readonly int b = 5;

	// Token: 0x04003DDF RID: 15839
	public static readonly int c = 10;

	// Token: 0x04003DE0 RID: 15840
	public new static readonly int d = 1;
}
