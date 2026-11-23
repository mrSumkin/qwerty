using System;

// Token: 0x02001D2F RID: 7471
public sealed class cyg : apq
{
	// Token: 0x0600A47C RID: 42108 RVA: 0x003EBB34 File Offset: 0x003E9D34
	public override Type e3()
	{
		return typeof(ku);
	}

	// Token: 0x0600A47D RID: 42109 RVA: 0x003EBB40 File Offset: 0x003E9D40
	public override string e4()
	{
		return "HeavyPunchCritDamage";
	}

	// Token: 0x0600A47E RID: 42110 RVA: 0x003EBB48 File Offset: 0x003E9D48
	public override string e5()
	{
		return "Тяжёлая рука: крит. урон";
	}

	// Token: 0x0600A47F RID: 42111 RVA: 0x003EBB50 File Offset: 0x003E9D50
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A480 RID: 42112 RVA: 0x003EBB54 File Offset: 0x003E9D54
	public override object[] e7()
	{
		return new object[]
		{
			(int)(cyg.a * 100.0)
		};
	}

	// Token: 0x04003E88 RID: 16008
	public new static readonly double a = 0.03;
}
