using System;

// Token: 0x02001D4E RID: 7502
public sealed class eo1 : apq
{
	// Token: 0x0600A555 RID: 42325 RVA: 0x003EC5BC File Offset: 0x003EA7BC
	public override Type e3()
	{
		return typeof(d3w);
	}

	// Token: 0x0600A556 RID: 42326 RVA: 0x003EC5C8 File Offset: 0x003EA7C8
	public override string e4()
	{
		return "ContinuumRippleJumpChance";
	}

	// Token: 0x0600A557 RID: 42327 RVA: 0x003EC5D0 File Offset: 0x003EA7D0
	public override string e5()
	{
		return "Непрерывная пульсация";
	}

	// Token: 0x0600A558 RID: 42328 RVA: 0x003EC5D8 File Offset: 0x003EA7D8
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A559 RID: 42329 RVA: 0x003EC5DC File Offset: 0x003EA7DC
	public override object[] e7()
	{
		return new object[]
		{
			(int)(eo1.a * 100.0)
		};
	}

	// Token: 0x04003EA8 RID: 16040
	public new static readonly double a = 0.02;
}
