using System;

// Token: 0x020008B1 RID: 2225
public sealed class dr6 : el4
{
	// Token: 0x06003754 RID: 14164 RVA: 0x0014C098 File Offset: 0x0014A298
	protected override esj a3()
	{
		return new esj(3, 3);
	}

	// Token: 0x06003755 RID: 14165 RVA: 0x0014C0A4 File Offset: 0x0014A2A4
	public override string a4()
	{
		return "XPBL_LE_SIPHCALF";
	}

	// Token: 0x06003756 RID: 14166 RVA: 0x0014C0AC File Offset: 0x0014A2AC
	public override string a5()
	{
		return "Global Event - Siphoner-swallowed Calf";
	}

	// Token: 0x06003757 RID: 14167 RVA: 0x0014C0B4 File Offset: 0x0014A2B4
	public override string ix()
	{
		return "xpbl";
	}

	// Token: 0x06003758 RID: 14168 RVA: 0x0014C0BC File Offset: 0x0014A2BC
	public override double ke()
	{
		return 0.1;
	}

	// Token: 0x06003759 RID: 14169 RVA: 0x0014C0C8 File Offset: 0x0014A2C8
	public override bool fk()
	{
		return true;
	}

	// Token: 0x0600375A RID: 14170 RVA: 0x0014C0CC File Offset: 0x0014A2CC
	public override bool fl()
	{
		return true;
	}

	// Token: 0x0600375B RID: 14171 RVA: 0x0014C0D0 File Offset: 0x0014A2D0
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(30.0));
	}

	// Token: 0x0600375C RID: 14172 RVA: 0x0014C0E8 File Offset: 0x0014A2E8
	public dr6() : base(new string[]
	{
		ega.a8
	})
	{
	}
}
