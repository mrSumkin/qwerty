using System;

// Token: 0x02001D9F RID: 7583
public sealed class c70 : apq
{
	// Token: 0x0600A780 RID: 42880 RVA: 0x003EE04C File Offset: 0x003EC24C
	public override Type e3()
	{
		return typeof(zf);
	}

	// Token: 0x0600A781 RID: 42881 RVA: 0x003EE058 File Offset: 0x003EC258
	public override string e4()
	{
		return "OpportunistSlowedTarget";
	}

	// Token: 0x0600A782 RID: 42882 RVA: 0x003EE060 File Offset: 0x003EC260
	public override string e5()
	{
		return "Оппортунист: урон медленным";
	}

	// Token: 0x0600A783 RID: 42883 RVA: 0x003EE068 File Offset: 0x003EC268
	public override int e6()
	{
		return 3;
	}

	// Token: 0x0600A784 RID: 42884 RVA: 0x003EE06C File Offset: 0x003EC26C
	public override object[] e7()
	{
		return new object[]
		{
			(int)(c70.a * 100.0)
		};
	}

	// Token: 0x04003EF4 RID: 16116
	public new static readonly double a = 0.03;
}
