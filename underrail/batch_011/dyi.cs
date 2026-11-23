using System;
using System.Collections.Generic;

// Token: 0x02001DF6 RID: 7670
[d29("TD", "Thermodynamicity")]
public sealed class dyi : ai8
{
	// Token: 0x0600A9CA RID: 43466 RVA: 0x003F273C File Offset: 0x003F093C
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A9CB RID: 43467 RVA: 0x003F2740 File Offset: 0x003F0940
	public dyi() : base("臰Термодинамичность")
	{
	}

	// Token: 0x0600A9CC RID: 43468 RVA: 0x003F2750 File Offset: 0x003F0950
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A9CD RID: 43469 RVA: 0x003F2754 File Offset: 0x003F0954
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A9CE RID: 43470 RVA: 0x003F2758 File Offset: 0x003F0958
	public override object[] at()
	{
		return new object[]
		{
			(int)(dyi.b * 100.0),
			l4.a(dyi.a, false)
		};
	}

	// Token: 0x0600A9CF RID: 43471 RVA: 0x003F2788 File Offset: 0x003F0988
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(30, new Type[]
			{
				typeof(rs)
			}),
			new b6h(new Type[]
			{
				typeof(c67)
			}),
			new b6h(new Type[]
			{
				typeof(h7)
			})
		};
	}

	// Token: 0x0600A9D0 RID: 43472 RVA: 0x003F27F8 File Offset: 0x003F09F8
	public static double a(efk A_0)
	{
		double num = dyi.b;
		if (A_0 != null)
		{
			num += (double)A_0.GetSpecializationValue<cuq>(true) * cuq.a;
		}
		return num;
	}

	// Token: 0x04003F9D RID: 16285
	public new static readonly int a = 2;

	// Token: 0x04003F9E RID: 16286
	public new static readonly double b = 0.5;
}
