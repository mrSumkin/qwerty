using System;

// Token: 0x02001D87 RID: 7559
public sealed class b9w : apq
{
	// Token: 0x0600A6D8 RID: 42712 RVA: 0x003ED81C File Offset: 0x003EBA1C
	public override Type e3()
	{
		return typeof(cln);
	}

	// Token: 0x0600A6D9 RID: 42713 RVA: 0x003ED828 File Offset: 0x003EBA28
	public override string e4()
	{
		return "RipperCritDamage";
	}

	// Token: 0x0600A6DA RID: 42714 RVA: 0x003ED830 File Offset: 0x003EBA30
	public override string e5()
	{
		return "Потрошитель";
	}

	// Token: 0x0600A6DB RID: 42715 RVA: 0x003ED838 File Offset: 0x003EBA38
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A6DC RID: 42716 RVA: 0x003ED83C File Offset: 0x003EBA3C
	public override object[] e7()
	{
		return new object[]
		{
			Math.Round(b9w.a * 100.0, 1)
		};
	}

	// Token: 0x04003EDB RID: 16091
	public new static readonly double a = 0.001;
}
