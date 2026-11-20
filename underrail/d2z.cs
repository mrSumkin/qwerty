using System;

// Token: 0x02001D81 RID: 7553
public sealed class d2z : apq
{
	// Token: 0x0600A6AE RID: 42670 RVA: 0x003ED604 File Offset: 0x003EB804
	public override Type e3()
	{
		return typeof(dnd);
	}

	// Token: 0x0600A6AF RID: 42671 RVA: 0x003ED610 File Offset: 0x003EB810
	public override string e4()
	{
		return "SteadfastAimCritChance";
	}

	// Token: 0x0600A6B0 RID: 42672 RVA: 0x003ED618 File Offset: 0x003EB818
	public override string e5()
	{
		return "Уверенный прицел";
	}

	// Token: 0x0600A6B1 RID: 42673 RVA: 0x003ED620 File Offset: 0x003EB820
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A6B2 RID: 42674 RVA: 0x003ED624 File Offset: 0x003EB824
	public override object[] e7()
	{
		return new object[]
		{
			Math.Round(d2z.a * 100.0, 2)
		};
	}

	// Token: 0x04003ED5 RID: 16085
	public new static readonly double a = 0.0005;
}
