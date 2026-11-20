using System;

// Token: 0x02001CFF RID: 7423
public sealed class aot : apq
{
	// Token: 0x0600A32D RID: 41773 RVA: 0x003EAB60 File Offset: 0x003E8D60
	public override Type e3()
	{
		return typeof(ku);
	}

	// Token: 0x0600A32E RID: 41774 RVA: 0x003EAB6C File Offset: 0x003E8D6C
	public override string e4()
	{
		return "HeavyPunchActionPoints";
	}

	// Token: 0x0600A32F RID: 41775 RVA: 0x003EAB74 File Offset: 0x003E8D74
	public override string e5()
	{
		return "Тяжёлая рука: цена ОД";
	}

	// Token: 0x0600A330 RID: 41776 RVA: 0x003EAB7C File Offset: 0x003E8D7C
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A331 RID: 41777 RVA: 0x003EAB80 File Offset: 0x003E8D80
	public override object[] e7()
	{
		return new object[]
		{
			Convert.ToInt32(aot.a * 100.0)
		};
	}

	// Token: 0x04003E58 RID: 15960
	public new static readonly double a = 0.1;
}
