using System;

// Token: 0x02001D4A RID: 7498
public sealed class du5 : apq
{
	// Token: 0x0600A539 RID: 42297 RVA: 0x003EC45C File Offset: 0x003EA65C
	public override Type e3()
	{
		return typeof(c7n);
	}

	// Token: 0x0600A53A RID: 42298 RVA: 0x003EC468 File Offset: 0x003EA668
	public override string e4()
	{
		return "SpearThrowDamage";
	}

	// Token: 0x0600A53B RID: 42299 RVA: 0x003EC470 File Offset: 0x003EA670
	public override string e5()
	{
		return "Бросок копья: урон";
	}

	// Token: 0x0600A53C RID: 42300 RVA: 0x003EC478 File Offset: 0x003EA678
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A53D RID: 42301 RVA: 0x003EC47C File Offset: 0x003EA67C
	public override object[] e7()
	{
		return new object[]
		{
			(int)(du5.a * 100.0)
		};
	}

	// Token: 0x04003EA4 RID: 16036
	public new static readonly double a = 0.01;
}
