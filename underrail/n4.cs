using System;
using System.Collections.Generic;

// Token: 0x02001C2F RID: 7215
[d29("HighTechnicalities", "High-Technicalities")]
public sealed class n4 : ai8
{
	// Token: 0x06009E7B RID: 40571 RVA: 0x003E20E0 File Offset: 0x003E02E0
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009E7C RID: 40572 RVA: 0x003E20E4 File Offset: 0x003E02E4
	public n4() : base("胰Высокотехнологичность")
	{
	}

	// Token: 0x06009E7D RID: 40573 RVA: 0x003E20F4 File Offset: 0x003E02F4
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(av8), n4.b),
			new bap(25, new Type[]
			{
				typeof(ct7),
				typeof(jk)
			})
		};
	}

	// Token: 0x06009E7E RID: 40574 RVA: 0x003E2150 File Offset: 0x003E0350
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(n4.a * 100.0),
			n4.b
		};
	}

	// Token: 0x06009E7F RID: 40575 RVA: 0x003E2184 File Offset: 0x003E0384
	public static double a(efk A_0)
	{
		if (A_0 != null)
		{
			return (double)Math.Max(0, A_0.BaseAbilities.Intelligence - n4.b) * (n4.a + (double)A_0.GetSpecializationValue<c0f>(true) * c0f.a);
		}
		return 0.0;
	}

	// Token: 0x06009E80 RID: 40576 RVA: 0x003E21D0 File Offset: 0x003E03D0
	public static void a(efk A_0, ref a1q A_1)
	{
		if (A_0 != null && A_0.Feats.Contains<n4>())
		{
			double num = n4.a(A_0);
			A_1 = a1q.a(A_1, 1.0 + num);
		}
	}

	// Token: 0x04003D6F RID: 15727
	public new static readonly double a = 0.08;

	// Token: 0x04003D70 RID: 15728
	public new static readonly int b = 5;
}
