using System;
using System.Collections.Generic;

// Token: 0x02001DF5 RID: 7669
[d29("PM", "Pyromaniac")]
public sealed class xk : ai8
{
	// Token: 0x0600A9C2 RID: 43458 RVA: 0x003F2654 File Offset: 0x003F0854
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A9C3 RID: 43459 RVA: 0x003F2658 File Offset: 0x003F0858
	public xk() : base("臱Пироманьяк")
	{
	}

	// Token: 0x0600A9C4 RID: 43460 RVA: 0x003F2668 File Offset: 0x003F0868
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A9C5 RID: 43461 RVA: 0x003F266C File Offset: 0x003F086C
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A9C6 RID: 43462 RVA: 0x003F2670 File Offset: 0x003F0870
	public override object[] at()
	{
		return new object[]
		{
			(int)(xk.a * 100.0),
			3
		};
	}

	// Token: 0x0600A9C7 RID: 43463 RVA: 0x003F269C File Offset: 0x003F089C
	public static double a(cnm A_0)
	{
		double num = xk.a;
		if (A_0 != null && A_0.b8() != null)
		{
			num += (double)A_0.b8().GetSpecializationValue<efo>(true) * efo.a;
		}
		return num;
	}

	// Token: 0x0600A9C8 RID: 43464 RVA: 0x003F26D8 File Offset: 0x003F08D8
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(35, new Type[]
			{
				typeof(rs)
			}),
			new b6h(new Type[]
			{
				typeof(c67)
			})
		};
	}

	// Token: 0x04003F9B RID: 16283
	public new static readonly double a = 1.0;

	// Token: 0x04003F9C RID: 16284
	public new const int b = 3;
}
