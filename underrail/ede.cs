using System;

// Token: 0x02001D8F RID: 7567
public sealed class ede : apq
{
	// Token: 0x0600A710 RID: 42768 RVA: 0x003EDAEC File Offset: 0x003EBCEC
	public override Type e3()
	{
		return typeof(e59);
	}

	// Token: 0x0600A711 RID: 42769 RVA: 0x003EDAF8 File Offset: 0x003EBCF8
	public override string e4()
	{
		return "PsychostaticElectricityCritChance";
	}

	// Token: 0x0600A712 RID: 42770 RVA: 0x003EDB00 File Offset: 0x003EBD00
	public override string e5()
	{
		return "Психостатическое электричество: крит. шанс";
	}

	// Token: 0x0600A713 RID: 42771 RVA: 0x003EDB08 File Offset: 0x003EBD08
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A714 RID: 42772 RVA: 0x003EDB0C File Offset: 0x003EBD0C
	public override object[] e7()
	{
		return new object[]
		{
			Math.Round(ede.a * 100.0, 1)
		};
	}

	// Token: 0x04003EE4 RID: 16100
	public new static readonly double a = 0.005;
}
