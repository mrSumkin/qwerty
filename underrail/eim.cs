using System;

// Token: 0x02001D6D RID: 7533
public sealed class eim : apq
{
	// Token: 0x0600A622 RID: 42530 RVA: 0x003ECF34 File Offset: 0x003EB134
	public override Type e3()
	{
		return typeof(er5);
	}

	// Token: 0x0600A623 RID: 42531 RVA: 0x003ECF40 File Offset: 0x003EB140
	public override string e4()
	{
		return "YellReduction";
	}

	// Token: 0x0600A624 RID: 42532 RVA: 0x003ECF48 File Offset: 0x003EB148
	public override string e5()
	{
		return "Крик";
	}

	// Token: 0x0600A625 RID: 42533 RVA: 0x003ECF50 File Offset: 0x003EB150
	public override int e6()
	{
		return 3;
	}

	// Token: 0x0600A626 RID: 42534 RVA: 0x003ECF54 File Offset: 0x003EB154
	public override object[] e7()
	{
		return new object[]
		{
			(int)(eim.a * 100.0)
		};
	}

	// Token: 0x04003EC1 RID: 16065
	public new static readonly double a = 0.05;
}
