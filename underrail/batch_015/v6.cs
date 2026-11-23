using System;

// Token: 0x02001D74 RID: 7540
public sealed class v6 : apq
{
	// Token: 0x0600A653 RID: 42579 RVA: 0x003ED19C File Offset: 0x003EB39C
	public override Type e3()
	{
		return typeof(c62);
	}

	// Token: 0x0600A654 RID: 42580 RVA: 0x003ED1A8 File Offset: 0x003EB3A8
	public override string e4()
	{
		return "TrapExpertSpeed";
	}

	// Token: 0x0600A655 RID: 42581 RVA: 0x003ED1B0 File Offset: 0x003EB3B0
	public override string e5()
	{
		return "Траппер: скорость";
	}

	// Token: 0x0600A656 RID: 42582 RVA: 0x003ED1B8 File Offset: 0x003EB3B8
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A657 RID: 42583 RVA: 0x003ED1BC File Offset: 0x003EB3BC
	public override object[] e7()
	{
		return new object[]
		{
			(int)(v6.a * 100.0)
		};
	}

	// Token: 0x04003EC8 RID: 16072
	public new static readonly double a = 0.03;
}
