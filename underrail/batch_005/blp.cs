using System;

// Token: 0x02001D7E RID: 7550
public sealed class blp : apq
{
	// Token: 0x0600A699 RID: 42649 RVA: 0x003ED4F4 File Offset: 0x003EB6F4
	public override Type e3()
	{
		return typeof(be1);
	}

	// Token: 0x0600A69A RID: 42650 RVA: 0x003ED500 File Offset: 0x003EB700
	public override string e4()
	{
		return "SuppressiveFireHitChanceRed";
	}

	// Token: 0x0600A69B RID: 42651 RVA: 0x003ED508 File Offset: 0x003EB708
	public override string e5()
	{
		return "Огонь на подавление: меньше точность";
	}

	// Token: 0x0600A69C RID: 42652 RVA: 0x003ED510 File Offset: 0x003EB710
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A69D RID: 42653 RVA: 0x003ED514 File Offset: 0x003EB714
	public override object[] e7()
	{
		return new object[]
		{
			(int)(blp.a * 100.0)
		};
	}

	// Token: 0x04003ED2 RID: 16082
	public new static readonly double a = 0.02;
}
