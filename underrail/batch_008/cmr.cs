using System;
using System.Collections.Generic;

// Token: 0x02001C82 RID: 7298
[d29("GunNut", "Gun Nut")]
public sealed class cmr : ai8
{
	// Token: 0x06009FEA RID: 40938 RVA: 0x003E4900 File Offset: 0x003E2B00
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009FEB RID: 40939 RVA: 0x003E4904 File Offset: 0x003E2B04
	public cmr() : base("胠Оружейник")
	{
	}

	// Token: 0x06009FEC RID: 40940 RVA: 0x003E4914 File Offset: 0x003E2B14
	public override void ar(efk A_0)
	{
	}

	// Token: 0x06009FED RID: 40941 RVA: 0x003E4918 File Offset: 0x003E2B18
	public override void @as(efk A_0)
	{
	}

	// Token: 0x06009FEE RID: 40942 RVA: 0x003E491C File Offset: 0x003E2B1C
	public override object[] at()
	{
		return new object[]
		{
			(int)(cmr.a * 100.0)
		};
	}

	// Token: 0x06009FEF RID: 40943 RVA: 0x003E4940 File Offset: 0x003E2B40
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(av8), 7),
			new bap(15, new Type[]
			{
				typeof(eq1)
			})
		};
	}

	// Token: 0x04003DBA RID: 15802
	public new static readonly double a = 0.15;
}
