using System;

// Token: 0x02001D61 RID: 7521
public sealed class das : apq
{
	// Token: 0x0600A5D2 RID: 42450 RVA: 0x003ECB58 File Offset: 0x003EAD58
	public override Type e3()
	{
		return typeof(cvk);
	}

	// Token: 0x0600A5D3 RID: 42451 RVA: 0x003ECB64 File Offset: 0x003EAD64
	public override string e4()
	{
		return "HeavyMetalDamageReduction";
	}

	// Token: 0x0600A5D4 RID: 42452 RVA: 0x003ECB6C File Offset: 0x003EAD6C
	public override string e5()
	{
		return "Тяжёлый металл: снижение урона";
	}

	// Token: 0x0600A5D5 RID: 42453 RVA: 0x003ECB74 File Offset: 0x003EAD74
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A5D6 RID: 42454 RVA: 0x003ECB7C File Offset: 0x003EAD7C
	public override object[] e7()
	{
		return new object[]
		{
			(das.a * 100.0).ToString("0.0")
		};
	}

	// Token: 0x04003EB7 RID: 16055
	public new static readonly double a = 0.001;
}
