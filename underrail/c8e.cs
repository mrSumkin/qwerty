using System;

// Token: 0x02000829 RID: 2089
public abstract class c8e : el4
{
	// Token: 0x06003443 RID: 13379 RVA: 0x0014320C File Offset: 0x0014140C
	protected override esj a3()
	{
		return new esj(3, 3);
	}

	// Token: 0x06003444 RID: 13380 RVA: 0x00143218 File Offset: 0x00141418
	public override string a4()
	{
		return "Xpbl_LE_SP" + this.a.ToString();
	}

	// Token: 0x06003445 RID: 13381 RVA: 0x00143230 File Offset: 0x00141430
	public override string a5()
	{
		return "Basalt Sandpit " + this.a.ToString();
	}

	// Token: 0x06003446 RID: 13382 RVA: 0x00143248 File Offset: 0x00141448
	public override string ix()
	{
		return "xpbl";
	}

	// Token: 0x06003447 RID: 13383 RVA: 0x00143250 File Offset: 0x00141450
	public override double ke()
	{
		return 0.07;
	}

	// Token: 0x06003448 RID: 13384 RVA: 0x0014325C File Offset: 0x0014145C
	protected override bool a6()
	{
		return false;
	}

	// Token: 0x06003449 RID: 13385 RVA: 0x00143260 File Offset: 0x00141460
	protected override bool a7()
	{
		return false;
	}

	// Token: 0x0600344A RID: 13386 RVA: 0x00143268 File Offset: 0x00141468
	protected override TimeSpan? a8()
	{
		return null;
	}

	// Token: 0x0600344B RID: 13387 RVA: 0x00143280 File Offset: 0x00141480
	public override bool a9()
	{
		return true;
	}

	// Token: 0x0600344C RID: 13388 RVA: 0x00143284 File Offset: 0x00141484
	public c8e(int A_0) : base(new string[]
	{
		ega.a9
	})
	{
		this.a = A_0;
	}

	// Token: 0x0600344D RID: 13389 RVA: 0x001432A4 File Offset: 0x001414A4
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		A_0.a(new bw0("xpbl_sp1", new evv(new c2w(A_1.y8(), "randomEvent_xpbl_le_sp" + this.a.ToString() + "_exit"), "xpbl_sp1_exit" + this.a.ToString()), 1));
	}

	// Token: 0x04001B84 RID: 7044
	private new int a;
}
