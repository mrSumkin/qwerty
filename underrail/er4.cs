using System;
using System.Collections.Generic;

// Token: 0x02001C8D RID: 7309
[d29("SurvivalInstincts", "Survival Instincts")]
public sealed class er4 : ai8
{
	// Token: 0x0600A029 RID: 41001 RVA: 0x003E50EC File Offset: 0x003E32EC
	public er4() : base("肵Инстинкт выживания")
	{
	}

	// Token: 0x0600A02A RID: 41002 RVA: 0x003E50FC File Offset: 0x003E32FC
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A02B RID: 41003 RVA: 0x003E5100 File Offset: 0x003E3300
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A02C RID: 41004 RVA: 0x003E5104 File Offset: 0x003E3304
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(er4.b * 100.0),
			Convert.ToInt32(er4.a * 100.0)
		};
	}

	// Token: 0x0600A02D RID: 41005 RVA: 0x003E5148 File Offset: 0x003E3348
	public override List<d3e> cy(efk A_0)
	{
		if (A_0 != null)
		{
			double num = er4.b + (double)A_0.GetSpecializationValue<rn>(true) * rn.a;
			if ((double)euf.f(A_0) < er4.a + (double)A_0.GetSpecializationValue<aa4>(true) * aa4.a)
			{
				return new List<d3e>
				{
					new bi0(null, (float)num),
					new dvq(num, cs5.a)
				};
			}
		}
		return null;
	}

	// Token: 0x0600A02E RID: 41006 RVA: 0x003E51BC File Offset: 0x003E33BC
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(axa), 9)
		};
	}

	// Token: 0x04003DC2 RID: 15810
	public new static readonly double a = 0.3;

	// Token: 0x04003DC3 RID: 15811
	public new static readonly double b = 0.3;
}
