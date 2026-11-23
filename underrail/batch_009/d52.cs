using System;
using System.Collections.Generic;

// Token: 0x02001CAB RID: 7339
[d29("Paranoia", "Paranoia")]
public sealed class d52 : ai8
{
	// Token: 0x0600A0D9 RID: 41177 RVA: 0x003E6780 File Offset: 0x003E4980
	public d52() : base("肍Паранойя")
	{
	}

	// Token: 0x0600A0DA RID: 41178 RVA: 0x003E6790 File Offset: 0x003E4990
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new d0d((float)(d52.a + (double)A_0.GetSpecializationValue<eou>(true) * eou.a))
			{
				Priority = int.MaxValue
			},
			new l5(-(d52.b + (double)A_0.GetSpecializationValue<d7n>(true) * d7n.a)),
			new b5x(d52.d + A_0.GetSpecializationValue<pc>(true) * pc.a)
		};
	}

	// Token: 0x0600A0DB RID: 41179 RVA: 0x003E680C File Offset: 0x003E4A0C
	public override object[] at()
	{
		return new object[]
		{
			(int)(d52.a * 100.0),
			d52.d,
			(int)(d52.b * 100.0),
			(int)(d52.c * 100.0)
		};
	}

	// Token: 0x0600A0DC RID: 41180 RVA: 0x003E6874 File Offset: 0x003E4A74
	public override List<brl> j0()
	{
		return new List<brl>();
	}

	// Token: 0x04003DF2 RID: 15858
	public new static readonly double a = 0.2;

	// Token: 0x04003DF3 RID: 15859
	public new static readonly double b = 0.03;

	// Token: 0x04003DF4 RID: 15860
	public static readonly double c = 0.3;

	// Token: 0x04003DF5 RID: 15861
	public new static readonly int d = 5;
}
