using System;
using System.Collections.Generic;

// Token: 0x02001CE2 RID: 7394
[d29("PracticedParabola", "Practiced Parabola")]
public sealed class d1p : ai8
{
	// Token: 0x0600A264 RID: 41572 RVA: 0x003E926C File Offset: 0x003E746C
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A265 RID: 41573 RVA: 0x003E9270 File Offset: 0x003E7470
	public override string au()
	{
		return "xphw";
	}

	// Token: 0x0600A266 RID: 41574 RVA: 0x003E9278 File Offset: 0x003E7478
	public d1p() : base("胮Практическая парабола")
	{
	}

	// Token: 0x0600A267 RID: 41575 RVA: 0x003E9288 File Offset: 0x003E7488
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(d1p.a * 100.0)
		};
	}

	// Token: 0x0600A268 RID: 41576 RVA: 0x003E92B0 File Offset: 0x003E74B0
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(eav), 7),
			new awr(typeof(av8), 5),
			new bap(40, new Type[]
			{
				typeof(ct7)
			})
		};
	}

	// Token: 0x0600A269 RID: 41577 RVA: 0x003E9310 File Offset: 0x003E7510
	public static double a(efk A_0)
	{
		double num = d1p.a;
		if (A_0 != null)
		{
			num += (double)A_0.GetSpecializationValue<cmt>(true) * cmt.a;
		}
		return num;
	}

	// Token: 0x04003E39 RID: 15929
	public new static readonly double a = 0.05;
}
