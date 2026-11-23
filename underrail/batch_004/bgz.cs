using System;

// Token: 0x020008B5 RID: 2229
public sealed class bgz : el4
{
	// Token: 0x06003777 RID: 14199 RVA: 0x0014C230 File Offset: 0x0014A430
	protected override esj a3()
	{
		return new esj(5, 5);
	}

	// Token: 0x06003778 RID: 14200 RVA: 0x0014C23C File Offset: 0x0014A43C
	public override string a4()
	{
		return "GG_ARDA";
	}

	// Token: 0x06003779 RID: 14201 RVA: 0x0014C244 File Offset: 0x0014A444
	public override string a5()
	{
		return "Arda's Gangsters";
	}

	// Token: 0x0600377A RID: 14202 RVA: 0x0014C24C File Offset: 0x0014A44C
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x0600377B RID: 14203 RVA: 0x0014C254 File Offset: 0x0014A454
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_daniel_exposed", new bool?(false)).Value;
	}

	// Token: 0x0600377C RID: 14204 RVA: 0x0014C298 File Offset: 0x0014A498
	public override bool fk()
	{
		return true;
	}

	// Token: 0x0600377D RID: 14205 RVA: 0x0014C29C File Offset: 0x0014A49C
	public override bool fl()
	{
		return true;
	}

	// Token: 0x0600377E RID: 14206 RVA: 0x0014C2A0 File Offset: 0x0014A4A0
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(60.0));
	}

	// Token: 0x0600377F RID: 14207 RVA: 0x0014C2B8 File Offset: 0x0014A4B8
	public bgz() : base(new string[]
	{
		ega.ay,
		ega.a1,
		ega.h
	})
	{
	}
}
