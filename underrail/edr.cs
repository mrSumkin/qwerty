using System;

// Token: 0x02001D79 RID: 7545
public sealed class edr : apq
{
	// Token: 0x0600A676 RID: 42614 RVA: 0x003ED354 File Offset: 0x003EB554
	public override Type e3()
	{
		return typeof(aq0);
	}

	// Token: 0x0600A677 RID: 42615 RVA: 0x003ED360 File Offset: 0x003EB560
	public override string e4()
	{
		return "TasteForBloodDamage";
	}

	// Token: 0x0600A678 RID: 42616 RVA: 0x003ED368 File Offset: 0x003EB568
	public override string e5()
	{
		return "Вкус крови";
	}

	// Token: 0x0600A679 RID: 42617 RVA: 0x003ED370 File Offset: 0x003EB570
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A67A RID: 42618 RVA: 0x003ED374 File Offset: 0x003EB574
	public override object[] e7()
	{
		return new object[]
		{
			Math.Round(edr.a * 100.0, 1)
		};
	}

	// Token: 0x04003ECD RID: 16077
	public new static readonly double a = 0.002;
}
