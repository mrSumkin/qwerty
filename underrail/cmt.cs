using System;

// Token: 0x02001D6A RID: 7530
public sealed class cmt : apq
{
	// Token: 0x0600A60D RID: 42509 RVA: 0x003ECE38 File Offset: 0x003EB038
	public override Type e3()
	{
		return typeof(d1p);
	}

	// Token: 0x0600A60E RID: 42510 RVA: 0x003ECE44 File Offset: 0x003EB044
	public override string e4()
	{
		return "PracticedParabola";
	}

	// Token: 0x0600A60F RID: 42511 RVA: 0x003ECE4C File Offset: 0x003EB04C
	public override string e5()
	{
		return "Практическая парабола";
	}

	// Token: 0x0600A610 RID: 42512 RVA: 0x003ECE54 File Offset: 0x003EB054
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A611 RID: 42513 RVA: 0x003ECE58 File Offset: 0x003EB058
	public override object[] e7()
	{
		return new object[]
		{
			Convert.ToInt32(cmt.a * 100.0)
		};
	}

	// Token: 0x04003EBE RID: 16062
	public new static readonly double a = 0.01;
}
