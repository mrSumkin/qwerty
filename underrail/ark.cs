using System;
using System.Collections.Generic;

// Token: 0x02001C37 RID: 7223
[d29("TattooDrifter", "Tattoo: Drifter")]
public sealed class ark : e33
{
	// Token: 0x06009EA1 RID: 40609 RVA: 0x003E25A4 File Offset: 0x003E07A4
	public ark() : base("Татуировка: Скиталец")
	{
	}

	// Token: 0x06009EA2 RID: 40610 RVA: 0x003E25B4 File Offset: 0x003E07B4
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new i0(ark.a, true, false, false),
			new ba(ark.b, true, false, false)
		};
	}

	// Token: 0x06009EA3 RID: 40611 RVA: 0x003E25EC File Offset: 0x003E07EC
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(ark.a * 100f),
			ark.b
		};
	}

	// Token: 0x04003D77 RID: 15735
	public new static readonly float a = 0.02f;

	// Token: 0x04003D78 RID: 15736
	public new static readonly int b = 5;
}
