using System;

// Token: 0x02001D34 RID: 7476
public sealed class czb : apq
{
	// Token: 0x0600A49F RID: 42143 RVA: 0x003EBCF0 File Offset: 0x003E9EF0
	public override Type e3()
	{
		return typeof(eb9);
	}

	// Token: 0x0600A4A0 RID: 42144 RVA: 0x003EBCFC File Offset: 0x003E9EFC
	public override string e4()
	{
		return "SixthShellDamage";
	}

	// Token: 0x0600A4A1 RID: 42145 RVA: 0x003EBD04 File Offset: 0x003E9F04
	public override string e5()
	{
		return "Шесть дробин";
	}

	// Token: 0x0600A4A2 RID: 42146 RVA: 0x003EBD0C File Offset: 0x003E9F0C
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A4A3 RID: 42147 RVA: 0x003EBD10 File Offset: 0x003E9F10
	public override object[] e7()
	{
		return new object[]
		{
			Convert.ToInt32(czb.a * 100.0),
			Convert.ToInt32(czb.b * 100.0)
		};
	}

	// Token: 0x04003E8D RID: 16013
	public new static readonly double a = 0.02;

	// Token: 0x04003E8E RID: 16014
	public static readonly double b = 0.2;
}
