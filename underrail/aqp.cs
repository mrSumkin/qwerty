using System;

// Token: 0x02001D45 RID: 7493
public sealed class aqp : apq
{
	// Token: 0x0600A516 RID: 42262 RVA: 0x003EC2C4 File Offset: 0x003EA4C4
	public override Type e3()
	{
		return typeof(bdn);
	}

	// Token: 0x0600A517 RID: 42263 RVA: 0x003EC2D0 File Offset: 0x003EA4D0
	public override string e4()
	{
		return "DecapitateThreshold";
	}

	// Token: 0x0600A518 RID: 42264 RVA: 0x003EC2D8 File Offset: 0x003EA4D8
	public override string e5()
	{
		return "Обезглавливание: порог";
	}

	// Token: 0x0600A519 RID: 42265 RVA: 0x003EC2E0 File Offset: 0x003EA4E0
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A51A RID: 42266 RVA: 0x003EC2E4 File Offset: 0x003EA4E4
	public override object[] e7()
	{
		return new object[]
		{
			(int)(aqp.a * 100.0)
		};
	}

	// Token: 0x04003E9F RID: 16031
	public new static readonly double a = 0.03;
}
