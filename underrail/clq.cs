using System;

// Token: 0x020008AC RID: 2220
public sealed class clq : el4
{
	// Token: 0x06003725 RID: 14117 RVA: 0x0014BAB0 File Offset: 0x00149CB0
	protected override esj a3()
	{
		return new esj(3, 3);
	}

	// Token: 0x06003726 RID: 14118 RVA: 0x0014BABC File Offset: 0x00149CBC
	public override string a4()
	{
		return "GE_WM";
	}

	// Token: 0x06003727 RID: 14119 RVA: 0x0014BAC4 File Offset: 0x00149CC4
	public override string a5()
	{
		return "Wounded Man";
	}

	// Token: 0x06003728 RID: 14120 RVA: 0x0014BACC File Offset: 0x00149CCC
	protected override bool a6()
	{
		return false;
	}

	// Token: 0x06003729 RID: 14121 RVA: 0x0014BAD0 File Offset: 0x00149CD0
	public override bool fk()
	{
		return true;
	}

	// Token: 0x0600372A RID: 14122 RVA: 0x0014BAD4 File Offset: 0x00149CD4
	public override bool fl()
	{
		return true;
	}

	// Token: 0x0600372B RID: 14123 RVA: 0x0014BAD8 File Offset: 0x00149CD8
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(10.0));
	}

	// Token: 0x0600372C RID: 14124 RVA: 0x0014BAF0 File Offset: 0x00149CF0
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		A_0.a(new bw0(A_1.ToString(), new dv3(), 1));
	}

	// Token: 0x0600372D RID: 14125 RVA: 0x0014BB20 File Offset: 0x00149D20
	public clq() : base(new string[]
	{
		ega.ay
	})
	{
	}
}
