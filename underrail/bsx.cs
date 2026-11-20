using System;
using System.Collections.Generic;

// Token: 0x02001C1D RID: 7197
[d29("BoneBreaker", "Bone Breaker")]
public sealed class bsx : ai8
{
	// Token: 0x06009E10 RID: 40464 RVA: 0x003E146C File Offset: 0x003DF66C
	public bsx() : base("膲Костолом")
	{
	}

	// Token: 0x06009E11 RID: 40465 RVA: 0x003E147C File Offset: 0x003DF67C
	public override object[] at()
	{
		return new object[]
		{
			(int)(bsx.a * 100.0),
			(int)(bsx.b * 100.0),
			l4.a(bsx.d, false),
			bsx.c
		};
	}

	// Token: 0x06009E12 RID: 40466 RVA: 0x003E14DC File Offset: 0x003DF6DC
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(d3m), 7),
			new bap(45, new Type[]
			{
				typeof(jk)
			})
		};
	}

	// Token: 0x06009E13 RID: 40467 RVA: 0x003E1528 File Offset: 0x003DF728
	public static double a(efk A_0)
	{
		if (A_0 != null)
		{
			return (double)A_0.GetSpecializationValue<bly>(true) * bly.a;
		}
		return 0.0;
	}

	// Token: 0x04003D4D RID: 15693
	public new static readonly double a = 0.04;

	// Token: 0x04003D4E RID: 15694
	public new static readonly double b = 0.25;

	// Token: 0x04003D4F RID: 15695
	public static readonly int c = 2;

	// Token: 0x04003D50 RID: 15696
	public new static readonly int d = 3;
}
