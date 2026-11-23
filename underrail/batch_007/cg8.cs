using System;

// Token: 0x02001D9B RID: 7579
public sealed class cg8 : apq
{
	// Token: 0x0600A764 RID: 42852 RVA: 0x003EDEF4 File Offset: 0x003EC0F4
	public override Type e3()
	{
		return typeof(d52);
	}

	// Token: 0x0600A765 RID: 42853 RVA: 0x003EDF00 File Offset: 0x003EC100
	public override string e4()
	{
		return "ParanoiaDamage";
	}

	// Token: 0x0600A766 RID: 42854 RVA: 0x003EDF08 File Offset: 0x003EC108
	public override string e5()
	{
		return "Паранойя: урон";
	}

	// Token: 0x0600A767 RID: 42855 RVA: 0x003EDF10 File Offset: 0x003EC110
	public override int e6()
	{
		return 3;
	}

	// Token: 0x0600A768 RID: 42856 RVA: 0x003EDF14 File Offset: 0x003EC114
	public override object[] e7()
	{
		return new object[]
		{
			(int)(cg8.a * 100.0)
		};
	}

	// Token: 0x04003EF0 RID: 16112
	public new static readonly double a = 0.05;
}
