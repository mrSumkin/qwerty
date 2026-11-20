using System;

// Token: 0x02001DBE RID: 7614
public sealed class etr : apq
{
	// Token: 0x0600A859 RID: 43097 RVA: 0x003EEA58 File Offset: 0x003ECC58
	public override Type e3()
	{
		return typeof(bw3);
	}

	// Token: 0x0600A85A RID: 43098 RVA: 0x003EEA64 File Offset: 0x003ECC64
	public override string e4()
	{
		return "ExposeWeaknessResistReduction";
	}

	// Token: 0x0600A85B RID: 43099 RVA: 0x003EEA6C File Offset: 0x003ECC6C
	public override string e5()
	{
		return "Раскрыть уязвимость: меньше защита";
	}

	// Token: 0x0600A85C RID: 43100 RVA: 0x003EEA74 File Offset: 0x003ECC74
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A85D RID: 43101 RVA: 0x003EEA78 File Offset: 0x003ECC78
	public override object[] e7()
	{
		return new object[]
		{
			(int)(etr.a * 100.0)
		};
	}

	// Token: 0x04003F14 RID: 16148
	public new static readonly double a = 0.02;
}
