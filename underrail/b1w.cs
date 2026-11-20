using System;

// Token: 0x02001CEC RID: 7404
[d29("NinjaLooter", "Ninja Looter")]
public sealed class b1w : ai8
{
	// Token: 0x0600A29C RID: 41628 RVA: 0x003E9930 File Offset: 0x003E7B30
	public b1w() : base("胓Карманник")
	{
	}

	// Token: 0x0600A29D RID: 41629 RVA: 0x003E9940 File Offset: 0x003E7B40
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A29E RID: 41630 RVA: 0x003E9944 File Offset: 0x003E7B44
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A29F RID: 41631 RVA: 0x003E9948 File Offset: 0x003E7B48
	public override object[] at()
	{
		return new object[]
		{
			(int)(b1w.a * 100f),
			(int)(b1w.b * 100f)
		};
	}

	// Token: 0x04003E45 RID: 15941
	public new static readonly float a = 0.5f;

	// Token: 0x04003E46 RID: 15942
	public new static readonly float b = 0.25f;
}
