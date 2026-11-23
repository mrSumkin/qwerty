using System;

// Token: 0x02001D3C RID: 7484
public sealed class ese : apq
{
	// Token: 0x0600A4D7 RID: 42199 RVA: 0x003EBFA8 File Offset: 0x003EA1A8
	public override Type e3()
	{
		return typeof(dtr);
	}

	// Token: 0x0600A4D8 RID: 42200 RVA: 0x003EBFB4 File Offset: 0x003EA1B4
	public override string e4()
	{
		return "ShieldBashDamage";
	}

	// Token: 0x0600A4D9 RID: 42201 RVA: 0x003EBFBC File Offset: 0x003EA1BC
	public override string e5()
	{
		return "Удар щитом: урон";
	}

	// Token: 0x0600A4DA RID: 42202 RVA: 0x003EBFC4 File Offset: 0x003EA1C4
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A4DB RID: 42203 RVA: 0x003EBFC8 File Offset: 0x003EA1C8
	public override object[] e7()
	{
		return new object[]
		{
			Convert.ToInt32(ese.a * 100.0)
		};
	}

	// Token: 0x04003E96 RID: 16022
	public new static readonly double a = 0.1;
}
