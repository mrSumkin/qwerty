using System;

// Token: 0x02000879 RID: 2169
public sealed class ala : el4
{
	// Token: 0x06003567 RID: 13671 RVA: 0x00146C98 File Offset: 0x00144E98
	protected override esj a3()
	{
		return new esj(11, 9);
	}

	// Token: 0x06003568 RID: 13672 RVA: 0x00146CA4 File Offset: 0x00144EA4
	public override string a4()
	{
		return "xpbl_ww_party";
	}

	// Token: 0x06003569 RID: 13673 RVA: 0x00146CAC File Offset: 0x00144EAC
	public override string a5()
	{
		return "Drag and Drop";
	}

	// Token: 0x0600356A RID: 13674 RVA: 0x00146CB4 File Offset: 0x00144EB4
	public override string ix()
	{
		return "xpbl";
	}

	// Token: 0x0600356B RID: 13675 RVA: 0x00146CBC File Offset: 0x00144EBC
	public override double ke()
	{
		return 0.07;
	}

	// Token: 0x0600356C RID: 13676 RVA: 0x00146CC8 File Offset: 0x00144EC8
	protected override bool a6()
	{
		return false;
	}

	// Token: 0x0600356D RID: 13677 RVA: 0x00146CCC File Offset: 0x00144ECC
	protected override bool a7()
	{
		return false;
	}

	// Token: 0x0600356E RID: 13678 RVA: 0x00146CD4 File Offset: 0x00144ED4
	protected override TimeSpan? a8()
	{
		return null;
	}

	// Token: 0x0600356F RID: 13679 RVA: 0x00146CEC File Offset: 0x00144EEC
	public override bool a9()
	{
		return true;
	}

	// Token: 0x06003571 RID: 13681 RVA: 0x00146CFC File Offset: 0x00144EFC
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		A_0.a(new bw0("Xpbl_ww_DragNDrop", new bwz(new c2w(A_1.y8(), "randomEvents_DnD_exit"), "xpbl_ww_DragNDrop_exit"), 1));
	}
}
