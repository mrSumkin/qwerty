using System;

// Token: 0x020008A8 RID: 2216
public sealed class sc : el4
{
	// Token: 0x06003712 RID: 14098 RVA: 0x0014B9D8 File Offset: 0x00149BD8
	protected override esj a3()
	{
		return new esj(4, 4);
	}

	// Token: 0x06003713 RID: 14099 RVA: 0x0014B9E4 File Offset: 0x00149BE4
	public override string a4()
	{
		return "GE_BB";
	}

	// Token: 0x06003714 RID: 14100 RVA: 0x0014B9EC File Offset: 0x00149BEC
	public override string a5()
	{
		return "Global Event - Broken Bot";
	}

	// Token: 0x06003715 RID: 14101 RVA: 0x0014B9F4 File Offset: 0x00149BF4
	public override bool fk()
	{
		return true;
	}

	// Token: 0x06003716 RID: 14102 RVA: 0x0014B9F8 File Offset: 0x00149BF8
	public override bool fl()
	{
		return true;
	}

	// Token: 0x06003717 RID: 14103 RVA: 0x0014B9FC File Offset: 0x00149BFC
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(60.0));
	}

	// Token: 0x06003718 RID: 14104 RVA: 0x0014BA14 File Offset: 0x00149C14
	public sc() : base(new string[]
	{
		ega.g,
		ega.h,
		ega.b,
		ega.bw
	})
	{
	}
}
