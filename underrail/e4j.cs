using System;

// Token: 0x02001D78 RID: 7544
public sealed class e4j : apq
{
	// Token: 0x0600A66F RID: 42607 RVA: 0x003ED2FC File Offset: 0x003EB4FC
	public override Type e3()
	{
		return typeof(ns);
	}

	// Token: 0x0600A670 RID: 42608 RVA: 0x003ED308 File Offset: 0x003EB508
	public override string e4()
	{
		return "TelekineticUndulationDazeChance";
	}

	// Token: 0x0600A671 RID: 42609 RVA: 0x003ED310 File Offset: 0x003EB510
	public override string e5()
	{
		return "Телекинетическое возмущение";
	}

	// Token: 0x0600A672 RID: 42610 RVA: 0x003ED318 File Offset: 0x003EB518
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A673 RID: 42611 RVA: 0x003ED31C File Offset: 0x003EB51C
	public override object[] e7()
	{
		return new object[]
		{
			(int)(e4j.a * 100.0)
		};
	}

	// Token: 0x04003ECC RID: 16076
	public new static readonly double a = 0.1;
}
