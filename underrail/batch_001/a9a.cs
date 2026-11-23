using System;

// Token: 0x0200088C RID: 2188
public sealed class a9a : el4
{
	// Token: 0x06003636 RID: 13878 RVA: 0x0014AEC0 File Offset: 0x001490C0
	protected override esj a3()
	{
		return new esj(2, 2);
	}

	// Token: 0x06003637 RID: 13879 RVA: 0x0014AECC File Offset: 0x001490CC
	public override string a4()
	{
		return "MC_HW";
	}

	// Token: 0x06003638 RID: 13880 RVA: 0x0014AED4 File Offset: 0x001490D4
	public override string a5()
	{
		return "Mushroom Cove Hunter Wolo";
	}

	// Token: 0x06003639 RID: 13881 RVA: 0x0014AEDC File Offset: 0x001490DC
	protected override bool a6()
	{
		return false;
	}

	// Token: 0x0600363A RID: 13882 RVA: 0x0014AEE0 File Offset: 0x001490E0
	public override double ke()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("quest_hopperRoundUpQuest_state", new int?(0)).Value == 1)
		{
			return 0.15;
		}
		return 0.0;
	}

	// Token: 0x0600363B RID: 13883 RVA: 0x0014AF3C File Offset: 0x0014913C
	protected override bool a7()
	{
		return false;
	}

	// Token: 0x0600363C RID: 13884 RVA: 0x0014AF40 File Offset: 0x00149140
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(10.0));
	}

	// Token: 0x0600363D RID: 13885 RVA: 0x0014AF58 File Offset: 0x00149158
	public override bool a9()
	{
		return true;
	}

	// Token: 0x0600363E RID: 13886 RVA: 0x0014AF5C File Offset: 0x0014915C
	public override bool fk()
	{
		return true;
	}

	// Token: 0x0600363F RID: 13887 RVA: 0x0014AF60 File Offset: 0x00149160
	public a9a() : base(new string[]
	{
		ega.be
	})
	{
	}
}
