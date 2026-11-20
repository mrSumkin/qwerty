using System;

// Token: 0x02001D76 RID: 7542
public sealed class ed8 : apq
{
	// Token: 0x0600A661 RID: 42593 RVA: 0x003ED244 File Offset: 0x003EB444
	public override Type e3()
	{
		return typeof(dws);
	}

	// Token: 0x0600A662 RID: 42594 RVA: 0x003ED250 File Offset: 0x003EB450
	public override string e4()
	{
		return "ThreePointerCritChance";
	}

	// Token: 0x0600A663 RID: 42595 RVA: 0x003ED258 File Offset: 0x003EB458
	public override string e5()
	{
		return "Трёхочковый";
	}

	// Token: 0x0600A664 RID: 42596 RVA: 0x003ED260 File Offset: 0x003EB460
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A665 RID: 42597 RVA: 0x003ED264 File Offset: 0x003EB464
	public override object[] e7()
	{
		return new object[]
		{
			Math.Round(ed8.a * 100.0, 1)
		};
	}

	// Token: 0x04003ECA RID: 16074
	public new static readonly double a = 0.001;
}
