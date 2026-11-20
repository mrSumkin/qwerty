using System;

// Token: 0x020007EF RID: 2031
public sealed class az7 : el4
{
	// Token: 0x06003310 RID: 13072 RVA: 0x0013E734 File Offset: 0x0013C934
	protected override esj a3()
	{
		return new esj(2, 1);
	}

	// Token: 0x06003311 RID: 13073 RVA: 0x0013E740 File Offset: 0x0013C940
	public override string a4()
	{
		return "LUP_GRAMPUS";
	}

	// Token: 0x06003312 RID: 13074 RVA: 0x0013E748 File Offset: 0x0013C948
	public override string a5()
	{
		return "Grampus";
	}

	// Token: 0x06003313 RID: 13075 RVA: 0x0013E754 File Offset: 0x0013C954
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		if (!base.e2(A_0, A_1, A_2))
		{
			return false;
		}
		DateTime t = new DateTime(DateTime.Now.Year, 12, 21);
		DateTime t2 = new DateTime(DateTime.Now.Year, 12, 31);
		return DateTime.Today >= t && DateTime.Today <= t2;
	}

	// Token: 0x06003314 RID: 13076 RVA: 0x0013E7C0 File Offset: 0x0013C9C0
	public override double ke()
	{
		return 1.0;
	}

	// Token: 0x06003315 RID: 13077 RVA: 0x0013E7CC File Offset: 0x0013C9CC
	protected override int? g2()
	{
		return new int?(12);
	}

	// Token: 0x06003316 RID: 13078 RVA: 0x0013E7D8 File Offset: 0x0013C9D8
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x06003317 RID: 13079 RVA: 0x0013E7DC File Offset: 0x0013C9DC
	protected override bool a7()
	{
		return false;
	}

	// Token: 0x06003318 RID: 13080 RVA: 0x0013E7E0 File Offset: 0x0013C9E0
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromDays(3.0));
	}

	// Token: 0x06003319 RID: 13081 RVA: 0x0013E7F8 File Offset: 0x0013C9F8
	public override bool a9()
	{
		return true;
	}

	// Token: 0x0600331A RID: 13082 RVA: 0x0013E7FC File Offset: 0x0013C9FC
	public override bool fk()
	{
		return true;
	}

	// Token: 0x0600331B RID: 13083 RVA: 0x0013E800 File Offset: 0x0013CA00
	public az7() : base(new string[]
	{
		ega.bg
	})
	{
	}

	// Token: 0x0600331C RID: 13084 RVA: 0x0013E81C File Offset: 0x0013CA1C
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		A_0.a(new bw0("lup-grampus", new evv(new c2w(A_1.y8(), "randomEvent_lup_grampus_exit"), "ladder"), 1));
	}
}
