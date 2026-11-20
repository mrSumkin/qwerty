using System;
using System.Collections.Generic;

// Token: 0x02001CEB RID: 7403
[d29("QuickPockets", "Quick Pockets")]
public sealed class bav : ai8
{
	// Token: 0x0600A295 RID: 41621 RVA: 0x003E98D0 File Offset: 0x003E7AD0
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A296 RID: 41622 RVA: 0x003E98D4 File Offset: 0x003E7AD4
	public bav() : base("肃Быстрые карманы")
	{
	}

	// Token: 0x0600A297 RID: 41623 RVA: 0x003E98E4 File Offset: 0x003E7AE4
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A298 RID: 41624 RVA: 0x003E98E8 File Offset: 0x003E7AE8
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A299 RID: 41625 RVA: 0x003E98EC File Offset: 0x003E7AEC
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new bgr(1)
		};
	}

	// Token: 0x0600A29A RID: 41626 RVA: 0x003E9900 File Offset: 0x003E7B00
	public override object[] at()
	{
		return new object[]
		{
			(int)(bav.a * 100.0)
		};
	}

	// Token: 0x04003E44 RID: 15940
	public new static readonly double a = 0.5;
}
