using System;

// Token: 0x02001D64 RID: 7524
public sealed class d0y : apq
{
	// Token: 0x0600A5E7 RID: 42471 RVA: 0x003ECC80 File Offset: 0x003EAE80
	public override Type e3()
	{
		return typeof(baj);
	}

	// Token: 0x0600A5E8 RID: 42472 RVA: 0x003ECC8C File Offset: 0x003EAE8C
	public override string e4()
	{
		return "GunnersHighThreshold";
	}

	// Token: 0x0600A5E9 RID: 42473 RVA: 0x003ECC94 File Offset: 0x003EAE94
	public override string e5()
	{
		return "Тяжёлая стрельба: пробитие";
	}

	// Token: 0x0600A5EA RID: 42474 RVA: 0x003ECC9C File Offset: 0x003EAE9C
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A5EB RID: 42475 RVA: 0x003ECCA0 File Offset: 0x003EAEA0
	public override object[] e7()
	{
		return new object[]
		{
			Convert.ToInt32(d0y.a * 100f)
		};
	}

	// Token: 0x04003EBA RID: 16058
	public new static readonly float a = 0.03f;
}
