using System;

// Token: 0x02001DAD RID: 7597
public sealed class byp : apq
{
	// Token: 0x0600A7E2 RID: 42978 RVA: 0x003EE4C4 File Offset: 0x003EC6C4
	public override Type e3()
	{
		return typeof(edd);
	}

	// Token: 0x0600A7E3 RID: 42979 RVA: 0x003EE4D0 File Offset: 0x003EC6D0
	public override string e4()
	{
		return "KneecapShotDamage";
	}

	// Token: 0x0600A7E4 RID: 42980 RVA: 0x003EE4D8 File Offset: 0x003EC6D8
	public override string e5()
	{
		return "Выстрел в колено: урон";
	}

	// Token: 0x0600A7E5 RID: 42981 RVA: 0x003EE4E0 File Offset: 0x003EC6E0
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A7E6 RID: 42982 RVA: 0x003EE4E4 File Offset: 0x003EC6E4
	public override object[] e7()
	{
		return new object[]
		{
			(int)(byp.a * 100.0)
		};
	}

	// Token: 0x04003F02 RID: 16130
	public new static readonly double a = 0.2;
}
