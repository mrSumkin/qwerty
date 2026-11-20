using System;

// Token: 0x02001D9C RID: 7580
public sealed class d7n : apq
{
	// Token: 0x0600A76B RID: 42859 RVA: 0x003EDF4C File Offset: 0x003EC14C
	public override Type e3()
	{
		return typeof(d52);
	}

	// Token: 0x0600A76C RID: 42860 RVA: 0x003EDF58 File Offset: 0x003EC158
	public override string e4()
	{
		return "ParanoiaCritChanceReduction";
	}

	// Token: 0x0600A76D RID: 42861 RVA: 0x003EDF60 File Offset: 0x003EC160
	public override string e5()
	{
		return "Паранойя: меньше крит. шанс";
	}

	// Token: 0x0600A76E RID: 42862 RVA: 0x003EDF68 File Offset: 0x003EC168
	public override int e6()
	{
		return 2;
	}

	// Token: 0x0600A76F RID: 42863 RVA: 0x003EDF6C File Offset: 0x003EC16C
	public override object[] e7()
	{
		return new object[]
		{
			Math.Round(d7n.a * 100.0, 1)
		};
	}

	// Token: 0x04003EF1 RID: 16113
	public new static readonly double a = 0.005;
}
