using System;

// Token: 0x02001DA0 RID: 7584
public sealed class d6q : apq
{
	// Token: 0x0600A787 RID: 42887 RVA: 0x003EE0A4 File Offset: 0x003EC2A4
	public override Type e3()
	{
		return typeof(zf);
	}

	// Token: 0x0600A788 RID: 42888 RVA: 0x003EE0B0 File Offset: 0x003EC2B0
	public override string e4()
	{
		return "OpportunistDisabledTarget";
	}

	// Token: 0x0600A789 RID: 42889 RVA: 0x003EE0B8 File Offset: 0x003EC2B8
	public override string e5()
	{
		return "Оппортунист: урон остановленным";
	}

	// Token: 0x0600A78A RID: 42890 RVA: 0x003EE0C0 File Offset: 0x003EC2C0
	public override int e6()
	{
		return 3;
	}

	// Token: 0x0600A78B RID: 42891 RVA: 0x003EE0C4 File Offset: 0x003EC2C4
	public override object[] e7()
	{
		return new object[]
		{
			(int)(d6q.a * 100.0)
		};
	}

	// Token: 0x04003EF5 RID: 16117
	public new static readonly double a = 0.03;
}
