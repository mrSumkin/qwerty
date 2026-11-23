using System;

// Token: 0x020008B8 RID: 2232
public sealed class h5 : el4
{
	// Token: 0x06003792 RID: 14226 RVA: 0x0014C3B0 File Offset: 0x0014A5B0
	protected override esj a3()
	{
		return new esj(5, 5);
	}

	// Token: 0x06003793 RID: 14227 RVA: 0x0014C3BC File Offset: 0x0014A5BC
	public override string a4()
	{
		return "GG_HHC";
	}

	// Token: 0x06003794 RID: 14228 RVA: 0x0014C3C4 File Offset: 0x0014A5C4
	public override string a5()
	{
		return "Headhunters";
	}

	// Token: 0x06003795 RID: 14229 RVA: 0x0014C3CC File Offset: 0x0014A5CC
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && A_0.r().GetPrimitivePropertyValue<bool>("global_sawTchoristsSnatchCube", new bool?(false)).Value;
	}

	// Token: 0x06003796 RID: 14230 RVA: 0x0014C410 File Offset: 0x0014A610
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x06003797 RID: 14231 RVA: 0x0014C414 File Offset: 0x0014A614
	public override bool fk()
	{
		return true;
	}

	// Token: 0x06003798 RID: 14232 RVA: 0x0014C418 File Offset: 0x0014A618
	public override bool fl()
	{
		return true;
	}

	// Token: 0x06003799 RID: 14233 RVA: 0x0014C41C File Offset: 0x0014A61C
	protected override int? g2()
	{
		return new int?(10);
	}

	// Token: 0x0600379A RID: 14234 RVA: 0x0014C428 File Offset: 0x0014A628
	public h5() : base(new string[]
	{
		ega.g,
		ega.h,
		ega.a1
	})
	{
	}
}
