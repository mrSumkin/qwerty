using System;

// Token: 0x02001D86 RID: 7558
public sealed class bco : apq
{
	// Token: 0x0600A6D1 RID: 42705 RVA: 0x003ED7BC File Offset: 0x003EB9BC
	public override Type e3()
	{
		return typeof(euv);
	}

	// Token: 0x0600A6D2 RID: 42706 RVA: 0x003ED7C8 File Offset: 0x003EB9C8
	public override string e4()
	{
		return "Salesman";
	}

	// Token: 0x0600A6D3 RID: 42707 RVA: 0x003ED7D0 File Offset: 0x003EB9D0
	public override string e5()
	{
		return "Продавец";
	}

	// Token: 0x0600A6D4 RID: 42708 RVA: 0x003ED7D8 File Offset: 0x003EB9D8
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A6D5 RID: 42709 RVA: 0x003ED7DC File Offset: 0x003EB9DC
	public override object[] e7()
	{
		return new object[]
		{
			Math.Round(bco.a * 100.0, 1)
		};
	}

	// Token: 0x04003EDA RID: 16090
	public new static readonly double a = 0.001;
}
