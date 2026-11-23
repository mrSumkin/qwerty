using System;

// Token: 0x02001D3E RID: 7486
public sealed class awf : apq
{
	// Token: 0x0600A4E5 RID: 42213 RVA: 0x003EC05C File Offset: 0x003EA25C
	public override Type e3()
	{
		return typeof(du9);
	}

	// Token: 0x0600A4E6 RID: 42214 RVA: 0x003EC068 File Offset: 0x003EA268
	public override string e4()
	{
		return "ParryChance";
	}

	// Token: 0x0600A4E7 RID: 42215 RVA: 0x003EC070 File Offset: 0x003EA270
	public override string e5()
	{
		return "Парирование: шанс";
	}

	// Token: 0x0600A4E8 RID: 42216 RVA: 0x003EC078 File Offset: 0x003EA278
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A4E9 RID: 42217 RVA: 0x003EC07C File Offset: 0x003EA27C
	public override object[] e7()
	{
		return new object[]
		{
			(int)(awf.a * 100.0)
		};
	}

	// Token: 0x04003E98 RID: 16024
	public new static readonly double a = 0.02;
}
