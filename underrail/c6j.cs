using System;

// Token: 0x02001D62 RID: 7522
public sealed class c6j : apq
{
	// Token: 0x0600A5D9 RID: 42457 RVA: 0x003ECBC8 File Offset: 0x003EADC8
	public override Type e3()
	{
		return typeof(cvk);
	}

	// Token: 0x0600A5DA RID: 42458 RVA: 0x003ECBD4 File Offset: 0x003EADD4
	public override string e4()
	{
		return "HeavyMetalDamageBonus";
	}

	// Token: 0x0600A5DB RID: 42459 RVA: 0x003ECBDC File Offset: 0x003EADDC
	public override string e5()
	{
		return "Тяжёлый металл: доп. урон";
	}

	// Token: 0x0600A5DC RID: 42460 RVA: 0x003ECBE4 File Offset: 0x003EADE4
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A5DD RID: 42461 RVA: 0x003ECBE8 File Offset: 0x003EADE8
	public override object[] e7()
	{
		return new object[]
		{
			Convert.ToInt32(c6j.a * 100.0)
		};
	}

	// Token: 0x04003EB8 RID: 16056
	public new static readonly double a = 0.05;
}
