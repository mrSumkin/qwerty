using System;

// Token: 0x02000832 RID: 2098
public sealed class b7b : el4
{
	// Token: 0x0600346B RID: 13419 RVA: 0x001434D0 File Offset: 0x001416D0
	protected override esj a3()
	{
		return new esj(3, 3);
	}

	// Token: 0x0600346C RID: 13420 RVA: 0x001434DC File Offset: 0x001416DC
	public override string a4()
	{
		return "LUX_HOLEDD";
	}

	// Token: 0x0600346D RID: 13421 RVA: 0x001434E4 File Offset: 0x001416E4
	public override string a5()
	{
		return "Пещера Тёмного обывателя";
	}

	// Token: 0x0600346E RID: 13422 RVA: 0x001434EC File Offset: 0x001416EC
	public override double ke()
	{
		return e3a.d;
	}

	// Token: 0x0600346F RID: 13423 RVA: 0x001434F4 File Offset: 0x001416F4
	protected override bool a6()
	{
		return false;
	}

	// Token: 0x06003470 RID: 13424 RVA: 0x001434F8 File Offset: 0x001416F8
	protected override bool a7()
	{
		return false;
	}

	// Token: 0x06003471 RID: 13425 RVA: 0x00143500 File Offset: 0x00141700
	protected override TimeSpan? a8()
	{
		return null;
	}

	// Token: 0x06003472 RID: 13426 RVA: 0x00143518 File Offset: 0x00141718
	public override bool a9()
	{
		return true;
	}

	// Token: 0x06003473 RID: 13427 RVA: 0x0014351C File Offset: 0x0014171C
	public override bool fk()
	{
		return true;
	}

	// Token: 0x06003474 RID: 13428 RVA: 0x00143520 File Offset: 0x00141720
	public b7b() : base(new string[]
	{
		ega.d
	})
	{
	}

	// Token: 0x06003475 RID: 13429 RVA: 0x00143538 File Offset: 0x00141738
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		A_0.a(new bw0("lux-holeDd", new evv(new c2w(A_1.y8(), "randomEvent_lux-holeDD_exit"), "lux-hole_exit"), 1));
	}
}
