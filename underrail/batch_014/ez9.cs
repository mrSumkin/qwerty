using System;
using System.Collections.Generic;

// Token: 0x02001C44 RID: 7236
[d29("TattooPraetorianSecurity", "Tattoo: Praetorian Security")]
public sealed class ez9 : e33
{
	// Token: 0x06009ED2 RID: 40658 RVA: 0x003E2B8C File Offset: 0x003E0D8C
	public ez9() : base("Татуировка: Преторианец")
	{
	}

	// Token: 0x06009ED3 RID: 40659 RVA: 0x003E2B9C File Offset: 0x003E0D9C
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new l5(-ez9.a)
		};
	}

	// Token: 0x06009ED4 RID: 40660 RVA: 0x003E2BB4 File Offset: 0x003E0DB4
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(ez9.a * 100.0)
		};
	}

	// Token: 0x04003D86 RID: 15750
	public new static readonly double a = 0.02;
}
