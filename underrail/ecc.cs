using System;

// Token: 0x02001D07 RID: 7431
public sealed class ecc : apq
{
	// Token: 0x0600A365 RID: 41829 RVA: 0x003EAE04 File Offset: 0x003E9004
	public override Type e3()
	{
		return typeof(co4);
	}

	// Token: 0x0600A366 RID: 41830 RVA: 0x003EAE10 File Offset: 0x003E9010
	public override string e4()
	{
		return "CryogenicInductionBarrierHealth";
	}

	// Token: 0x0600A367 RID: 41831 RVA: 0x003EAE18 File Offset: 0x003E9018
	public override string e5()
	{
		return "Криогенная индукция: Прочность барьера";
	}

	// Token: 0x0600A368 RID: 41832 RVA: 0x003EAE20 File Offset: 0x003E9020
	public override int e6()
	{
		return 5;
	}

	// Token: 0x0600A369 RID: 41833 RVA: 0x003EAE24 File Offset: 0x003E9024
	public override object[] e7()
	{
		return new object[]
		{
			(int)(ecc.a * 100.0)
		};
	}

	// Token: 0x04003E60 RID: 15968
	public new static readonly double a = 0.07;
}
