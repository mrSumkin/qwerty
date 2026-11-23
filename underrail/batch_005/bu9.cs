using System;

// Token: 0x02001D6F RID: 7535
public sealed class bu9 : apq
{
	// Token: 0x0600A630 RID: 42544 RVA: 0x003ECFE4 File Offset: 0x003EB1E4
	public override Type e3()
	{
		return typeof(e8m);
	}

	// Token: 0x0600A631 RID: 42545 RVA: 0x003ECFF0 File Offset: 0x003EB1F0
	public override string e4()
	{
		return "WeaponsmithCritChance";
	}

	// Token: 0x0600A632 RID: 42546 RVA: 0x003ECFF8 File Offset: 0x003EB1F8
	public override string e5()
	{
		return "Кузнец";
	}

	// Token: 0x0600A633 RID: 42547 RVA: 0x003ED000 File Offset: 0x003EB200
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A634 RID: 42548 RVA: 0x003ED004 File Offset: 0x003EB204
	public override object[] e7()
	{
		return new object[]
		{
			Math.Round(bu9.a * 100.0, 1)
		};
	}

	// Token: 0x04003EC3 RID: 16067
	public new static readonly double a = 0.005;
}
