using System;

// Token: 0x02001D88 RID: 7560
public sealed class ddy : apq
{
	// Token: 0x0600A6DF RID: 42719 RVA: 0x003ED87C File Offset: 0x003EBA7C
	public override Type e3()
	{
		return typeof(dfb);
	}

	// Token: 0x0600A6E0 RID: 42720 RVA: 0x003ED888 File Offset: 0x003EBA88
	public override string e4()
	{
		return "RecklessnessCritChance";
	}

	// Token: 0x0600A6E1 RID: 42721 RVA: 0x003ED890 File Offset: 0x003EBA90
	public override string e5()
	{
		return "Безрассудство";
	}

	// Token: 0x0600A6E2 RID: 42722 RVA: 0x003ED898 File Offset: 0x003EBA98
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A6E3 RID: 42723 RVA: 0x003ED89C File Offset: 0x003EBA9C
	public override object[] e7()
	{
		return new object[]
		{
			(int)(ddy.a * 100.0),
			(int)(ddy.b * 100.0)
		};
	}

	// Token: 0x04003EDC RID: 16092
	public new static readonly double a = 0.01;

	// Token: 0x04003EDD RID: 16093
	public static readonly double b = 0.01;
}
