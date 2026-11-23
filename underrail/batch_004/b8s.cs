using System;
using System.Collections.Generic;

// Token: 0x02001C8A RID: 7306
[d29("FastMetabolism", "Fast Metabolism")]
public sealed class b8s : ai8
{
	// Token: 0x0600A013 RID: 40979 RVA: 0x003E4D94 File Offset: 0x003E2F94
	public b8s() : base("育Быстрый метаболизм")
	{
	}

	// Token: 0x0600A014 RID: 40980 RVA: 0x003E4DA4 File Offset: 0x003E2FA4
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A015 RID: 40981 RVA: 0x003E4DA8 File Offset: 0x003E2FA8
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A016 RID: 40982 RVA: 0x003E4DAC File Offset: 0x003E2FAC
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(b8s.a * 100.0),
			b8s.b
		};
	}

	// Token: 0x0600A017 RID: 40983 RVA: 0x003E4DE0 File Offset: 0x003E2FE0
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new b2g(b8s.a + (double)A_0.GetSpecializationValue<jo>(true) * jo.a)
		};
	}

	// Token: 0x0600A018 RID: 40984 RVA: 0x003E4E08 File Offset: 0x003E3008
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(axa), 6)
		};
	}

	// Token: 0x04003DBC RID: 15804
	public new static readonly double a = 0.25;

	// Token: 0x04003DBD RID: 15805
	public new static readonly int b = 25;
}
