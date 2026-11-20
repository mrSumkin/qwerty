using System;

// Token: 0x02001D98 RID: 7576
public sealed class d84 : apq
{
	// Token: 0x0600A74F RID: 42831 RVA: 0x003EDDFC File Offset: 0x003EBFFC
	public override Type e3()
	{
		return typeof(cld);
	}

	// Token: 0x0600A750 RID: 42832 RVA: 0x003EDE08 File Offset: 0x003EC008
	public override string e4()
	{
		return "PointShotApCost";
	}

	// Token: 0x0600A751 RID: 42833 RVA: 0x003EDE10 File Offset: 0x003EC010
	public override string e5()
	{
		return "Выстрел навскидку";
	}

	// Token: 0x0600A752 RID: 42834 RVA: 0x003EDE18 File Offset: 0x003EC018
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A753 RID: 42835 RVA: 0x003EDE1C File Offset: 0x003EC01C
	public override object[] e7()
	{
		return new object[]
		{
			(int)(d84.a * 100.0)
		};
	}

	// Token: 0x04003EED RID: 16109
	public new static readonly double a = 0.02;
}
