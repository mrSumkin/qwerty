using System;

// Token: 0x02001DB9 RID: 7609
public sealed class c3o : apq
{
	// Token: 0x0600A836 RID: 43062 RVA: 0x003EE8C8 File Offset: 0x003ECAC8
	public override Type e3()
	{
		return typeof(d2f);
	}

	// Token: 0x0600A837 RID: 43063 RVA: 0x003EE8D4 File Offset: 0x003ECAD4
	public override string e4()
	{
		return "FatalThrowHealthThreshold";
	}

	// Token: 0x0600A838 RID: 43064 RVA: 0x003EE8DC File Offset: 0x003ECADC
	public override string e5()
	{
		return "Смертельный бросок: порог здоровья";
	}

	// Token: 0x0600A839 RID: 43065 RVA: 0x003EE8E4 File Offset: 0x003ECAE4
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A83A RID: 43066 RVA: 0x003EE8E8 File Offset: 0x003ECAE8
	public override object[] e7()
	{
		return new object[]
		{
			(int)(c3o.a * 100.0)
		};
	}

	// Token: 0x04003F0F RID: 16143
	public new static readonly double a = 0.02;
}
