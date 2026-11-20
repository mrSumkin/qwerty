using System;
using System.Collections.Generic;

// Token: 0x02001C34 RID: 7220
[d29("Shoemaker", "Shoemaker")]
public sealed class eck : ai8
{
	// Token: 0x06009E95 RID: 40597 RVA: 0x003E24A0 File Offset: 0x003E06A0
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009E96 RID: 40598 RVA: 0x003E24A4 File Offset: 0x003E06A4
	public override bool aq()
	{
		return false;
	}

	// Token: 0x06009E97 RID: 40599 RVA: 0x003E24A8 File Offset: 0x003E06A8
	public eck() : base("Сапожник")
	{
	}

	// Token: 0x06009E98 RID: 40600 RVA: 0x003E24B8 File Offset: 0x003E06B8
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(eck.a * 100.0)
		};
	}

	// Token: 0x06009E99 RID: 40601 RVA: 0x003E24E0 File Offset: 0x003E06E0
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(60, new Type[]
			{
				typeof(qr)
			})
		};
	}

	// Token: 0x04003D75 RID: 15733
	public new static readonly double a = 0.1;
}
