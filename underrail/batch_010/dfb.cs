using System;
using System.Collections.Generic;

// Token: 0x02001CE9 RID: 7401
[d29("Recklessness", "Recklessness")]
public sealed class dfb : ai8
{
	// Token: 0x0600A28E RID: 41614 RVA: 0x003E97C0 File Offset: 0x003E79C0
	public dfb() : base("肀Безрассудство")
	{
	}

	// Token: 0x0600A28F RID: 41615 RVA: 0x003E97D0 File Offset: 0x003E79D0
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new dvq(dfb.a + (double)A_0.GetSpecializationValue<ddy>(true) * ddy.a, cs5.a),
			new l5(dfb.b + (double)A_0.GetSpecializationValue<ddy>(true) * ddy.b),
			new e2e(dfb.b + (double)A_0.GetSpecializationValue<ddy>(true) * ddy.b)
		};
	}

	// Token: 0x0600A290 RID: 41616 RVA: 0x003E9840 File Offset: 0x003E7A40
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(dfb.a * 100.0),
			Convert.ToInt32(dfb.b * 100.0)
		};
	}

	// Token: 0x04003E41 RID: 15937
	public new static readonly double a = 0.07;

	// Token: 0x04003E42 RID: 15938
	public new static readonly double b = 0.03;
}
