using System;

// Token: 0x02001DD0 RID: 7632
public sealed class wp : apq
{
	// Token: 0x0600A8D7 RID: 43223 RVA: 0x003EF03C File Offset: 0x003ED23C
	public override Type e3()
	{
		return typeof(eg1);
	}

	// Token: 0x0600A8D8 RID: 43224 RVA: 0x003EF048 File Offset: 0x003ED248
	public override string e4()
	{
		return "CripplingStrikeDamage";
	}

	// Token: 0x0600A8D9 RID: 43225 RVA: 0x003EF050 File Offset: 0x003ED250
	public override string e5()
	{
		return "Калечащий удар";
	}

	// Token: 0x0600A8DA RID: 43226 RVA: 0x003EF058 File Offset: 0x003ED258
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A8DB RID: 43227 RVA: 0x003EF05C File Offset: 0x003ED25C
	public override object[] e7()
	{
		return new object[]
		{
			(int)(wp.a * 100.0)
		};
	}

	// Token: 0x04003F26 RID: 16166
	public new static readonly double a = 0.05;
}
