using System;

// Token: 0x02001D39 RID: 7481
public sealed class b1r : apq
{
	// Token: 0x0600A4C2 RID: 42178 RVA: 0x003EBEB8 File Offset: 0x003EA0B8
	public override Type e3()
	{
		return typeof(dol);
	}

	// Token: 0x0600A4C3 RID: 42179 RVA: 0x003EBEC4 File Offset: 0x003EA0C4
	public override string e4()
	{
		return "SweepDamage";
	}

	// Token: 0x0600A4C4 RID: 42180 RVA: 0x003EBECC File Offset: 0x003EA0CC
	public override string e5()
	{
		return "Подсечение: урон";
	}

	// Token: 0x0600A4C5 RID: 42181 RVA: 0x003EBED4 File Offset: 0x003EA0D4
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A4C6 RID: 42182 RVA: 0x003EBED8 File Offset: 0x003EA0D8
	public override object[] e7()
	{
		return new object[]
		{
			(int)(b1r.a * 100.0)
		};
	}

	// Token: 0x04003E93 RID: 16019
	public new static readonly double a = 0.04;
}
