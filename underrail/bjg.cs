using System;
using System.Collections.Generic;

// Token: 0x02001CAF RID: 7343
[d29("HitAndRun", "Hit and Run")]
public sealed class bjg : ai8
{
	// Token: 0x0600A0ED RID: 41197 RVA: 0x003E6B20 File Offset: 0x003E4D20
	public bjg() : base("胇Бей и беги")
	{
	}

	// Token: 0x0600A0EE RID: 41198 RVA: 0x003E6B30 File Offset: 0x003E4D30
	public override object[] at()
	{
		return new object[]
		{
			bjg.a
		};
	}

	// Token: 0x0600A0EF RID: 41199 RVA: 0x003E6B48 File Offset: 0x003E4D48
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(dqg), 7)
		};
	}

	// Token: 0x0600A0F0 RID: 41200 RVA: 0x003E6B68 File Offset: 0x003E4D68
	public static int a(efk A_0, int A_1)
	{
		double num = Math.Pow(0.5, (double)A_1);
		return Convert.ToInt32((double)(bjg.a + ((A_0 != null) ? A_0.GetSpecializationValue<ans>(true) : 0) * ans.a) * num);
	}

	// Token: 0x04003DF6 RID: 15862
	private new static readonly int a = 25;
}
