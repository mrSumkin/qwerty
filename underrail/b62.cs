using System;

// Token: 0x02001D3F RID: 7487
public sealed class b62 : apq
{
	// Token: 0x0600A4EC RID: 42220 RVA: 0x003EC0B4 File Offset: 0x003EA2B4
	public override Type e3()
	{
		return typeof(etq);
	}

	// Token: 0x0600A4ED RID: 42221 RVA: 0x003EC0C0 File Offset: 0x003EA2C0
	public override string e4()
	{
		return "PelletMayhemDamage";
	}

	// Token: 0x0600A4EE RID: 42222 RVA: 0x003EC0C8 File Offset: 0x003EA2C8
	public override string e5()
	{
		return "Семя раздора";
	}

	// Token: 0x0600A4EF RID: 42223 RVA: 0x003EC0D0 File Offset: 0x003EA2D0
	public override int e6()
	{
		return 4;
	}

	// Token: 0x0600A4F0 RID: 42224 RVA: 0x003EC0D4 File Offset: 0x003EA2D4
	public override object[] e7()
	{
		return new object[]
		{
			Math.Round(b62.a * 100.0, 2)
		};
	}

	// Token: 0x04003E99 RID: 16025
	public new static readonly double a = 0.005;
}
