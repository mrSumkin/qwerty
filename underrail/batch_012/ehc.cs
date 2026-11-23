using System;
using System.Collections.Generic;

// Token: 0x02001C1A RID: 7194
[d29("FineTuned", "Fine Tuned")]
public sealed class ehc : ai8
{
	// Token: 0x06009DFE RID: 40446 RVA: 0x003E1200 File Offset: 0x003DF400
	public override bool ap()
	{
		return true;
	}

	// Token: 0x06009DFF RID: 40447 RVA: 0x003E1204 File Offset: 0x003DF404
	public override bool aq()
	{
		return false;
	}

	// Token: 0x06009E00 RID: 40448 RVA: 0x003E1208 File Offset: 0x003DF408
	public ehc() : base("Тонкая настройка")
	{
	}

	// Token: 0x06009E01 RID: 40449 RVA: 0x003E1218 File Offset: 0x003DF418
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new d0d(ehc.a)
			{
				Priority = 2147483646
			}
		};
	}

	// Token: 0x06009E02 RID: 40450 RVA: 0x003E123C File Offset: 0x003DF43C
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(ehc.a * 100f)
		};
	}

	// Token: 0x04003D4A RID: 15690
	public new static readonly float a = 0.15f;
}
