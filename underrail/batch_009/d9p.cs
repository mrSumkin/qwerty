using System;

// Token: 0x02001D1E RID: 7454
public sealed class d9p : apq
{
	// Token: 0x0600A405 RID: 41989 RVA: 0x003EB574 File Offset: 0x003E9774
	public override Type e3()
	{
		return typeof(e6k);
	}

	// Token: 0x0600A406 RID: 41990 RVA: 0x003EB580 File Offset: 0x003E9780
	public override string e4()
	{
		return "Conditioning";
	}

	// Token: 0x0600A407 RID: 41991 RVA: 0x003EB588 File Offset: 0x003E9788
	public override string e5()
	{
		return "Выдержка";
	}

	// Token: 0x0600A408 RID: 41992 RVA: 0x003EB590 File Offset: 0x003E9790
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A409 RID: 41993 RVA: 0x003EB594 File Offset: 0x003E9794
	public override object[] e7()
	{
		return new object[]
		{
			(int)(d9p.a * 100.0)
		};
	}

	// Token: 0x04003E77 RID: 15991
	public new static readonly double a = 0.01;
}
