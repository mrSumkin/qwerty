using System;

// Token: 0x02000897 RID: 2199
public sealed class bmh : el4
{
	// Token: 0x06003698 RID: 13976 RVA: 0x0014B410 File Offset: 0x00149610
	protected override esj a3()
	{
		return new esj(1, 1);
	}

	// Token: 0x06003699 RID: 13977 RVA: 0x0014B41C File Offset: 0x0014961C
	public override string a4()
	{
		return "Xpbl_GC_PRIS";
	}

	// Token: 0x0600369A RID: 13978 RVA: 0x0014B424 File Offset: 0x00149624
	public override string a5()
	{
		return "Global Commoner - Prisoner";
	}

	// Token: 0x0600369B RID: 13979 RVA: 0x0014B42C File Offset: 0x0014962C
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x0600369C RID: 13980 RVA: 0x0014B430 File Offset: 0x00149630
	public override string ix()
	{
		return "xpbl";
	}

	// Token: 0x0600369D RID: 13981 RVA: 0x0014B438 File Offset: 0x00149638
	public override bool fk()
	{
		return true;
	}

	// Token: 0x0600369E RID: 13982 RVA: 0x0014B43C File Offset: 0x0014963C
	public override bool fl()
	{
		return true;
	}

	// Token: 0x0600369F RID: 13983 RVA: 0x0014B440 File Offset: 0x00149640
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(5.0));
	}

	// Token: 0x060036A0 RID: 13984 RVA: 0x0014B458 File Offset: 0x00149658
	protected override int? g2()
	{
		return new int?(10);
	}

	// Token: 0x060036A1 RID: 13985 RVA: 0x0014B464 File Offset: 0x00149664
	public bmh() : base(new string[]
	{
		ega.g,
		ega.h,
		ega.a
	})
	{
	}
}
