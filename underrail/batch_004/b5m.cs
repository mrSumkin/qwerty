using System;
using TimelapseVertigo.Rules;

// Token: 0x020008B9 RID: 2233
public sealed class b5m : el4
{
	// Token: 0x0600379B RID: 14235 RVA: 0x0014C450 File Offset: 0x0014A650
	protected override esj a3()
	{
		return new esj(5, 5);
	}

	// Token: 0x0600379C RID: 14236 RVA: 0x0014C45C File Offset: 0x0014A65C
	public override string a4()
	{
		return "GG_CULT";
	}

	// Token: 0x0600379D RID: 14237 RVA: 0x0014C464 File Offset: 0x0014A664
	public override string a5()
	{
		return "Morghrir-Tem Cult";
	}

	// Token: 0x0600379E RID: 14238 RVA: 0x0014C46C File Offset: 0x0014A66C
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x0600379F RID: 14239 RVA: 0x0014C470 File Offset: 0x0014A670
	public override bool fk()
	{
		return true;
	}

	// Token: 0x060037A0 RID: 14240 RVA: 0x0014C474 File Offset: 0x0014A674
	public override bool fl()
	{
		return true;
	}

	// Token: 0x060037A1 RID: 14241 RVA: 0x0014C478 File Offset: 0x0014A678
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(45.0));
	}

	// Token: 0x060037A2 RID: 14242 RVA: 0x0014C490 File Offset: 0x0014A690
	public override GameDifficulty adg()
	{
		return GameDifficulty.Normal;
	}

	// Token: 0x060037A3 RID: 14243 RVA: 0x0014C494 File Offset: 0x0014A694
	public b5m() : base(new string[]
	{
		ega.b
	})
	{
	}

	// Token: 0x060037A4 RID: 14244 RVA: 0x0014C4AC File Offset: 0x0014A6AC
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && am9.c();
	}
}
