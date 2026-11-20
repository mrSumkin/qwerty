using System;

// Token: 0x02001DB1 RID: 7601
public sealed class n6 : apq
{
	// Token: 0x0600A7FE RID: 43006 RVA: 0x003EE630 File Offset: 0x003EC830
	public override Type e3()
	{
		return typeof(dt);
	}

	// Token: 0x0600A7FF RID: 43007 RVA: 0x003EE63C File Offset: 0x003EC83C
	public override string e4()
	{
		return "HypertoxicityDamage";
	}

	// Token: 0x0600A800 RID: 43008 RVA: 0x003EE644 File Offset: 0x003EC844
	public override string e5()
	{
		return "Гипертоксичность";
	}

	// Token: 0x0600A801 RID: 43009 RVA: 0x003EE64C File Offset: 0x003EC84C
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A802 RID: 43010 RVA: 0x003EE650 File Offset: 0x003EC850
	public override object[] e7()
	{
		return new object[]
		{
			(int)(n6.a * 100.0)
		};
	}

	// Token: 0x04003F07 RID: 16135
	public new static readonly double a = 0.05;
}
