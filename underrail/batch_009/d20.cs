using System;

// Token: 0x02001D80 RID: 7552
public sealed class d20 : apq
{
	// Token: 0x0600A6A7 RID: 42663 RVA: 0x003ED5A4 File Offset: 0x003EB7A4
	public override Type e3()
	{
		return typeof(c85);
	}

	// Token: 0x0600A6A8 RID: 42664 RVA: 0x003ED5B0 File Offset: 0x003EB7B0
	public override string e4()
	{
		return "Stoicism";
	}

	// Token: 0x0600A6A9 RID: 42665 RVA: 0x003ED5B8 File Offset: 0x003EB7B8
	public override string e5()
	{
		return "Стоицизм";
	}

	// Token: 0x0600A6AA RID: 42666 RVA: 0x003ED5C0 File Offset: 0x003EB7C0
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A6AB RID: 42667 RVA: 0x003ED5C4 File Offset: 0x003EB7C4
	public override object[] e7()
	{
		return new object[]
		{
			Math.Round(d20.a * 100.0, 1)
		};
	}

	// Token: 0x04003ED4 RID: 16084
	public new static readonly double a = 0.001;
}
