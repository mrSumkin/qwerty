using System;

// Token: 0x02000898 RID: 2200
public sealed class aco : el4
{
	// Token: 0x060036A2 RID: 13986 RVA: 0x0014B48C File Offset: 0x0014968C
	protected override esj a3()
	{
		return new esj(4, 4);
	}

	// Token: 0x060036A3 RID: 13987 RVA: 0x0014B498 File Offset: 0x00149698
	public override string a4()
	{
		return "Xpbl_GE_TRAP";
	}

	// Token: 0x060036A4 RID: 13988 RVA: 0x0014B4A0 File Offset: 0x001496A0
	public override string a5()
	{
		return "Global Event - Trappers";
	}

	// Token: 0x060036A5 RID: 13989 RVA: 0x0014B4A8 File Offset: 0x001496A8
	public override string ix()
	{
		return "xpbl";
	}

	// Token: 0x060036A6 RID: 13990 RVA: 0x0014B4B0 File Offset: 0x001496B0
	public override bool fk()
	{
		return true;
	}

	// Token: 0x060036A7 RID: 13991 RVA: 0x0014B4B4 File Offset: 0x001496B4
	public override bool fl()
	{
		return true;
	}

	// Token: 0x060036A8 RID: 13992 RVA: 0x0014B4B8 File Offset: 0x001496B8
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(90.0));
	}

	// Token: 0x060036A9 RID: 13993 RVA: 0x0014B4D0 File Offset: 0x001496D0
	public aco() : base(new string[]
	{
		ega.a
	})
	{
	}
}
