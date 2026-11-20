using System;
using System.Collections.Generic;

// Token: 0x02001C29 RID: 7209
[d29("Clothier", "Clothier")]
public sealed class rh : ai8
{
	// Token: 0x06009E57 RID: 40535 RVA: 0x003E1D1C File Offset: 0x003DFF1C
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009E58 RID: 40536 RVA: 0x003E1D20 File Offset: 0x003DFF20
	public rh() : base("胅Портной")
	{
	}

	// Token: 0x06009E59 RID: 40537 RVA: 0x003E1D30 File Offset: 0x003DFF30
	public override void ar(efk A_0)
	{
	}

	// Token: 0x06009E5A RID: 40538 RVA: 0x003E1D34 File Offset: 0x003DFF34
	public override void @as(efk A_0)
	{
	}

	// Token: 0x06009E5B RID: 40539 RVA: 0x003E1D38 File Offset: 0x003DFF38
	public override object[] at()
	{
		return new object[]
		{
			(int)(rh.a * 100.0)
		};
	}

	// Token: 0x06009E5C RID: 40540 RVA: 0x003E1D58 File Offset: 0x003DFF58
	public static double a(efk A_0)
	{
		return rh.a + (double)A_0.GetSpecializationValue<aix>(true) * aix.a;
	}

	// Token: 0x06009E5D RID: 40541 RVA: 0x003E1D70 File Offset: 0x003DFF70
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(av8), 7),
			new bap(15, new Type[]
			{
				typeof(qr)
			})
		};
	}

	// Token: 0x04003D66 RID: 15718
	public new static readonly double a = 0.2;
}
