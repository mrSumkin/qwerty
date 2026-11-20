using System;

// Token: 0x02001DC7 RID: 7623
public sealed class aog : apq
{
	// Token: 0x0600A898 RID: 43160 RVA: 0x003EED2C File Offset: 0x003ECF2C
	public override Type e3()
	{
		return typeof(yn);
	}

	// Token: 0x0600A899 RID: 43161 RVA: 0x003EED38 File Offset: 0x003ECF38
	public override string e4()
	{
		return "DoctorHealingBonus";
	}

	// Token: 0x0600A89A RID: 43162 RVA: 0x003EED40 File Offset: 0x003ECF40
	public override string e5()
	{
		return "Доктор";
	}

	// Token: 0x0600A89B RID: 43163 RVA: 0x003EED48 File Offset: 0x003ECF48
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A89C RID: 43164 RVA: 0x003EED4C File Offset: 0x003ECF4C
	public override object[] e7()
	{
		return new object[]
		{
			(int)(aog.a * 100.0)
		};
	}

	// Token: 0x04003F1D RID: 16157
	public new static readonly double a = 0.02;
}
