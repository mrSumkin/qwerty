using System;

// Token: 0x02001D9D RID: 7581
public sealed class eou : apq
{
	// Token: 0x0600A772 RID: 42866 RVA: 0x003EDFAC File Offset: 0x003EC1AC
	public override Type e3()
	{
		return typeof(d52);
	}

	// Token: 0x0600A773 RID: 42867 RVA: 0x003EDFB8 File Offset: 0x003EC1B8
	public override string e4()
	{
		return "ParanoiaDetectionBonus";
	}

	// Token: 0x0600A774 RID: 42868 RVA: 0x003EDFC0 File Offset: 0x003EC1C0
	public override string e5()
	{
		return "Паранойя: обнаружение";
	}

	// Token: 0x0600A775 RID: 42869 RVA: 0x003EDFC8 File Offset: 0x003EC1C8
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A776 RID: 42870 RVA: 0x003EDFCC File Offset: 0x003EC1CC
	public override object[] e7()
	{
		return new object[]
		{
			(int)(eou.a * 100.0)
		};
	}

	// Token: 0x04003EF2 RID: 16114
	public new static readonly double a = 0.02;
}
