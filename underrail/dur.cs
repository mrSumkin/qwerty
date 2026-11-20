using System;

// Token: 0x02001D46 RID: 7494
public sealed class dur : apq
{
	// Token: 0x0600A51D RID: 42269 RVA: 0x003EC31C File Offset: 0x003EA51C
	public override Type e3()
	{
		return typeof(e8);
	}

	// Token: 0x0600A51E RID: 42270 RVA: 0x003EC328 File Offset: 0x003EA528
	public override string e4()
	{
		return "OnslaughtDamage";
	}

	// Token: 0x0600A51F RID: 42271 RVA: 0x003EC330 File Offset: 0x003EA530
	public override string e5()
	{
		return "Натиск";
	}

	// Token: 0x0600A520 RID: 42272 RVA: 0x003EC338 File Offset: 0x003EA538
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A521 RID: 42273 RVA: 0x003EC33C File Offset: 0x003EA53C
	public override object[] e7()
	{
		return new object[]
		{
			Math.Round(dur.a * 100.0, 1)
		};
	}

	// Token: 0x04003EA0 RID: 16032
	public new static readonly double a = 0.005;
}
