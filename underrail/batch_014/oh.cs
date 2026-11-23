using System;
using System.Collections.Generic;

// Token: 0x02001CD1 RID: 7377
[d29("Blindsiding", "Blindsiding")]
public sealed class oh : ai8
{
	// Token: 0x0600A1E4 RID: 41444 RVA: 0x003E8318 File Offset: 0x003E6518
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A1E5 RID: 41445 RVA: 0x003E8320 File Offset: 0x003E6520
	public oh() : base("胖Неожиданный удар")
	{
	}

	// Token: 0x0600A1E6 RID: 41446 RVA: 0x003E8330 File Offset: 0x003E6530
	public override object[] at()
	{
		return new object[]
		{
			(int)(oh.a * 100.0)
		};
	}

	// Token: 0x0600A1E7 RID: 41447 RVA: 0x003E8354 File Offset: 0x003E6554
	public static double a(efk A_0)
	{
		double num = oh.a;
		if (A_0 != null)
		{
			num += (double)A_0.GetSpecializationValue<cbc>(true) * cbc.a;
		}
		return num;
	}

	// Token: 0x0600A1E8 RID: 41448 RVA: 0x003E8380 File Offset: 0x003E6580
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(80, new Type[]
			{
				typeof(a2n)
			})
		};
	}

	// Token: 0x04003E1A RID: 15898
	public new static readonly double a = 0.15;
}
