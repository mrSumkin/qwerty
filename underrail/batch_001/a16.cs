using System;

// Token: 0x02001CFD RID: 7421
public sealed class a16 : apq
{
	// Token: 0x0600A31F RID: 41759 RVA: 0x003EAAB0 File Offset: 0x003E8CB0
	public override Type e3()
	{
		return typeof(dbe);
	}

	// Token: 0x0600A320 RID: 41760 RVA: 0x003EAABC File Offset: 0x003E8CBC
	public override string e4()
	{
		return "AmbushCritChance";
	}

	// Token: 0x0600A321 RID: 41761 RVA: 0x003EAAC4 File Offset: 0x003E8CC4
	public override string e5()
	{
		return "Засада";
	}

	// Token: 0x0600A322 RID: 41762 RVA: 0x003EAACC File Offset: 0x003E8CCC
	public override int e6()
	{
		return 10;
	}

	// Token: 0x0600A323 RID: 41763 RVA: 0x003EAAD0 File Offset: 0x003E8CD0
	public override object[] e7()
	{
		return new object[]
		{
			(int)(a16.a * 100.0)
		};
	}

	// Token: 0x04003E56 RID: 15958
	public new static readonly double a = 0.02;
}
