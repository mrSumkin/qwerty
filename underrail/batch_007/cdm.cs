using System;

// Token: 0x02001DA2 RID: 7586
public sealed class cdm : apq
{
	// Token: 0x0600A795 RID: 42901 RVA: 0x003EE154 File Offset: 0x003EC354
	public override Type e3()
	{
		return typeof(b1w);
	}

	// Token: 0x0600A796 RID: 42902 RVA: 0x003EE160 File Offset: 0x003EC360
	public override string e4()
	{
		return "NinjaLooterSpeed";
	}

	// Token: 0x0600A797 RID: 42903 RVA: 0x003EE168 File Offset: 0x003EC368
	public override string e5()
	{
		return "Карманник: скорость";
	}

	// Token: 0x0600A798 RID: 42904 RVA: 0x003EE170 File Offset: 0x003EC370
	public override int e6()
	{
		return 3;
	}

	// Token: 0x0600A799 RID: 42905 RVA: 0x003EE174 File Offset: 0x003EC374
	public override object[] e7()
	{
		return new object[]
		{
			(int)(cdm.a * 100.0)
		};
	}

	// Token: 0x04003EF7 RID: 16119
	public new static readonly double a = 0.08;
}
