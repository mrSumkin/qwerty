using System;

// Token: 0x02001D1D RID: 7453
public sealed class cxr : apq
{
	// Token: 0x0600A3FE RID: 41982 RVA: 0x003EB51C File Offset: 0x003E971C
	public override Type e3()
	{
		return typeof(bo8);
	}

	// Token: 0x0600A3FF RID: 41983 RVA: 0x003EB528 File Offset: 0x003E9728
	public override string e4()
	{
		return "ConcussiveShotsDazeChance";
	}

	// Token: 0x0600A400 RID: 41984 RVA: 0x003EB530 File Offset: 0x003E9730
	public override string e5()
	{
		return "Контузящие стрелы";
	}

	// Token: 0x0600A401 RID: 41985 RVA: 0x003EB538 File Offset: 0x003E9738
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A402 RID: 41986 RVA: 0x003EB53C File Offset: 0x003E973C
	public override object[] e7()
	{
		return new object[]
		{
			(int)(cxr.a * 100.0)
		};
	}

	// Token: 0x04003E76 RID: 15990
	public new static readonly double a = 0.04;
}
