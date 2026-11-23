using System;

// Token: 0x02001D7B RID: 7547
public sealed class aa4 : apq
{
	// Token: 0x0600A684 RID: 42628 RVA: 0x003ED40C File Offset: 0x003EB60C
	public override Type e3()
	{
		return typeof(er4);
	}

	// Token: 0x0600A685 RID: 42629 RVA: 0x003ED418 File Offset: 0x003EB618
	public override string e4()
	{
		return "SurvivalInstinctsHealthThreshold";
	}

	// Token: 0x0600A686 RID: 42630 RVA: 0x003ED420 File Offset: 0x003EB620
	public override string e5()
	{
		return "Инстинкт выживания: порог здоровья";
	}

	// Token: 0x0600A687 RID: 42631 RVA: 0x003ED428 File Offset: 0x003EB628
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A688 RID: 42632 RVA: 0x003ED42C File Offset: 0x003EB62C
	public override object[] e7()
	{
		return new object[]
		{
			(int)(aa4.a * 100.0)
		};
	}

	// Token: 0x04003ECF RID: 16079
	public new static readonly double a = 0.02;
}
