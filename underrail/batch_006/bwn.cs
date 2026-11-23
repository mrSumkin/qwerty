using System;

// Token: 0x02001D92 RID: 7570
public sealed class bwn : apq
{
	// Token: 0x0600A725 RID: 42789 RVA: 0x003EDBFC File Offset: 0x003EBDFC
	public override Type e3()
	{
		return typeof(d11);
	}

	// Token: 0x0600A726 RID: 42790 RVA: 0x003EDC08 File Offset: 0x003EBE08
	public override string e4()
	{
		return "PsionicManiaHealthCostReduction";
	}

	// Token: 0x0600A727 RID: 42791 RVA: 0x003EDC10 File Offset: 0x003EBE10
	public override string e5()
	{
		return "Пси-мания: цена здоровья";
	}

	// Token: 0x0600A728 RID: 42792 RVA: 0x003EDC18 File Offset: 0x003EBE18
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A729 RID: 42793 RVA: 0x003EDC1C File Offset: 0x003EBE1C
	public override object[] e7()
	{
		return new object[]
		{
			(int)(bwn.a * 100.0)
		};
	}

	// Token: 0x04003EE7 RID: 16103
	public new static readonly double a = 0.01;
}
