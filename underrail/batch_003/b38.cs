using System;
using TimelapseVertigo.Rules;

// Token: 0x020007FD RID: 2045
public sealed class b38 : el4
{
	// Token: 0x0600338D RID: 13197 RVA: 0x00140DA8 File Offset: 0x0013EFA8
	protected override esj a3()
	{
		return new esj(1, 1);
	}

	// Token: 0x0600338E RID: 13198 RVA: 0x00140DB4 File Offset: 0x0013EFB4
	public override string a4()
	{
		return "JY_THM";
	}

	// Token: 0x0600338F RID: 13199 RVA: 0x00140DBC File Offset: 0x0013EFBC
	public override string a5()
	{
		return "Two-headed Junkyard Mutant";
	}

	// Token: 0x06003390 RID: 13200 RVA: 0x00140DC4 File Offset: 0x0013EFC4
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x06003391 RID: 13201 RVA: 0x00140DC8 File Offset: 0x0013EFC8
	public override bool fk()
	{
		return true;
	}

	// Token: 0x06003392 RID: 13202 RVA: 0x00140DCC File Offset: 0x0013EFCC
	public override bool fl()
	{
		return true;
	}

	// Token: 0x06003393 RID: 13203 RVA: 0x00140DD0 File Offset: 0x0013EFD0
	public override GameDifficulty adg()
	{
		return GameDifficulty.Hard;
	}

	// Token: 0x06003394 RID: 13204 RVA: 0x00140DD4 File Offset: 0x0013EFD4
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(60.0));
	}

	// Token: 0x06003395 RID: 13205 RVA: 0x00140DEC File Offset: 0x0013EFEC
	public override double ke()
	{
		return 0.07;
	}

	// Token: 0x06003396 RID: 13206 RVA: 0x00140DF8 File Offset: 0x0013EFF8
	public b38() : base(new string[]
	{
		ega.ad
	})
	{
	}
}
