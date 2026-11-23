using System;

// Token: 0x02001D73 RID: 7539
public sealed class coi : apq
{
	// Token: 0x0600A64C RID: 42572 RVA: 0x003ED144 File Offset: 0x003EB344
	public override Type e3()
	{
		return typeof(c62);
	}

	// Token: 0x0600A64D RID: 42573 RVA: 0x003ED150 File Offset: 0x003EB350
	public override string e4()
	{
		return "TrapExpertDetection";
	}

	// Token: 0x0600A64E RID: 42574 RVA: 0x003ED158 File Offset: 0x003EB358
	public override string e5()
	{
		return "Траппер: обнаружение";
	}

	// Token: 0x0600A64F RID: 42575 RVA: 0x003ED160 File Offset: 0x003EB360
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A650 RID: 42576 RVA: 0x003ED164 File Offset: 0x003EB364
	public override object[] e7()
	{
		return new object[]
		{
			(int)(coi.a * 100.0)
		};
	}

	// Token: 0x04003EC7 RID: 16071
	public new static readonly double a = 0.03;
}
