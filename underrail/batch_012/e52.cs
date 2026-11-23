using System;

// Token: 0x02000830 RID: 2096
public sealed class e52 : el4
{
	// Token: 0x06003454 RID: 13396 RVA: 0x00143354 File Offset: 0x00141554
	protected override esj a3()
	{
		return new esj(3, 3);
	}

	// Token: 0x06003455 RID: 13397 RVA: 0x00143360 File Offset: 0x00141560
	public override string a4()
	{
		return "LUX_HOLETM";
	}

	// Token: 0x06003456 RID: 13398 RVA: 0x00143368 File Offset: 0x00141568
	public override string a5()
	{
		return "Пещера с изменённым временем.";
	}

	// Token: 0x06003457 RID: 13399 RVA: 0x00143370 File Offset: 0x00141570
	public override string ix()
	{
		return "xpbl";
	}

	// Token: 0x06003458 RID: 13400 RVA: 0x00143378 File Offset: 0x00141578
	public override double ke()
	{
		return e3a.d;
	}

	// Token: 0x06003459 RID: 13401 RVA: 0x00143380 File Offset: 0x00141580
	protected override bool a6()
	{
		return false;
	}

	// Token: 0x0600345A RID: 13402 RVA: 0x00143384 File Offset: 0x00141584
	protected override bool a7()
	{
		return false;
	}

	// Token: 0x0600345B RID: 13403 RVA: 0x00143388 File Offset: 0x00141588
	protected override TimeSpan? a8()
	{
		return null;
	}

	// Token: 0x0600345C RID: 13404 RVA: 0x001433A0 File Offset: 0x001415A0
	public override bool a9()
	{
		return true;
	}

	// Token: 0x0600345D RID: 13405 RVA: 0x001433A4 File Offset: 0x001415A4
	public override bool fk()
	{
		return true;
	}

	// Token: 0x0600345E RID: 13406 RVA: 0x001433A8 File Offset: 0x001415A8
	public e52() : base(new string[]
	{
		ega.d
	})
	{
	}

	// Token: 0x0600345F RID: 13407 RVA: 0x001433C0 File Offset: 0x001415C0
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		A_0.a(new bw0("lux-holeTM", new evv(new c2w(A_1.y8(), "randomEvent_lux-holeTM_exit"), "lux-hole_exit"), 1));
	}
}
