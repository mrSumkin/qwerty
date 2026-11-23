using System;
using System.Collections.Generic;

// Token: 0x02001CE8 RID: 7400
[d29("Nimble", "Nimble")]
public sealed class enb : ai8
{
	// Token: 0x0600A28A RID: 41610 RVA: 0x003E96BC File Offset: 0x003E78BC
	public enb() : base("胆Шустрый")
	{
	}

	// Token: 0x0600A28B RID: 41611 RVA: 0x003E96CC File Offset: 0x003E78CC
	public override List<d3e> cy(efk A_0)
	{
		double num = enb.a + (double)A_0.GetSpecializationValue<eo>(true) * eo.a;
		return new List<d3e>
		{
			new caz(-enb.b)
			{
				Priority = 1073741823
			},
			new d19((float)num)
			{
				Priority = int.MaxValue,
				Condition = new cqk(0.0)
			},
			new e15((float)num)
			{
				Priority = int.MaxValue,
				Condition = new cqk(0.0)
			}
		};
	}

	// Token: 0x0600A28C RID: 41612 RVA: 0x003E9768 File Offset: 0x003E7968
	public override object[] at()
	{
		return new object[]
		{
			(int)(enb.b * 100.0),
			(int)(enb.a * 100.0)
		};
	}

	// Token: 0x04003E3F RID: 15935
	public new static readonly double a = 0.15;

	// Token: 0x04003E40 RID: 15936
	public new static readonly double b = 0.15;
}
