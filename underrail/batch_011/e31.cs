using System;

// Token: 0x02001DD1 RID: 7633
public sealed class e31 : apq
{
	// Token: 0x0600A8DE RID: 43230 RVA: 0x003EF094 File Offset: 0x003ED294
	public override Type e3()
	{
		return typeof(d6t);
	}

	// Token: 0x0600A8DF RID: 43231 RVA: 0x003EF0A0 File Offset: 0x003ED2A0
	public override string e4()
	{
		return "CorporealProjectionDamage";
	}

	// Token: 0x0600A8E0 RID: 43232 RVA: 0x003EF0A8 File Offset: 0x003ED2A8
	public override string e5()
	{
		return "Телесная проекция";
	}

	// Token: 0x0600A8E1 RID: 43233 RVA: 0x003EF0B0 File Offset: 0x003ED2B0
	public override int e6()
	{
		return 6;
	}

	// Token: 0x0600A8E2 RID: 43234 RVA: 0x003EF0B4 File Offset: 0x003ED2B4
	public override object[] e7()
	{
		return new object[]
		{
			Math.Round(e31.a * 100.0, 1),
			d6t.b
		};
	}

	// Token: 0x04003F27 RID: 16167
	public new static readonly double a = 0.005;
}
