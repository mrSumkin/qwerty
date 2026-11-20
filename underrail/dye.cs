using System;

// Token: 0x02000831 RID: 2097
public sealed class dye : el4
{
	// Token: 0x06003460 RID: 13408 RVA: 0x00143404 File Offset: 0x00141604
	protected override esj a3()
	{
		return new esj(3, 3);
	}

	// Token: 0x06003461 RID: 13409 RVA: 0x00143410 File Offset: 0x00141610
	public override string a4()
	{
		return "LUX_HOLEMT";
	}

	// Token: 0x06003462 RID: 13410 RVA: 0x00143418 File Offset: 0x00141618
	public override string a5()
	{
		return "Пещера метатермических пси-жуков.";
	}

	// Token: 0x06003463 RID: 13411 RVA: 0x00143420 File Offset: 0x00141620
	public override double ke()
	{
		return e3a.d;
	}

	// Token: 0x06003464 RID: 13412 RVA: 0x00143428 File Offset: 0x00141628
	protected override bool a6()
	{
		return false;
	}

	// Token: 0x06003465 RID: 13413 RVA: 0x0014342C File Offset: 0x0014162C
	protected override bool a7()
	{
		return false;
	}

	// Token: 0x06003466 RID: 13414 RVA: 0x00143434 File Offset: 0x00141634
	protected override TimeSpan? a8()
	{
		return null;
	}

	// Token: 0x06003467 RID: 13415 RVA: 0x0014344C File Offset: 0x0014164C
	public override bool a9()
	{
		return true;
	}

	// Token: 0x06003468 RID: 13416 RVA: 0x00143450 File Offset: 0x00141650
	public override bool fk()
	{
		return true;
	}

	// Token: 0x06003469 RID: 13417 RVA: 0x00143454 File Offset: 0x00141654
	public dye() : base(new string[]
	{
		ega.d
	})
	{
	}

	// Token: 0x0600346A RID: 13418 RVA: 0x0014346C File Offset: 0x0014166C
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		A_0.a(new bw0("lux-holeMT", new evv(new c2w(A_1.y8(), "randomEvent_lux-holeMT_exit"), "lux-hole_exit"), 1));
		A_0.r()["loc_luxholeMT_randomLoot"] = cuo.a.Next(0, 2);
	}
}
