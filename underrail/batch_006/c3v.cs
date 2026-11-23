using System;

// Token: 0x02001E07 RID: 7687
[d29("PE", "Psi Empathy")]
public sealed class c3v : ai8
{
	// Token: 0x0600AA38 RID: 43576 RVA: 0x003F3794 File Offset: 0x003F1994
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600AA39 RID: 43577 RVA: 0x003F3798 File Offset: 0x003F1998
	public override bool aq()
	{
		return false;
	}

	// Token: 0x0600AA3A RID: 43578 RVA: 0x003F379C File Offset: 0x003F199C
	public c3v() : base("Пси-эмпатия")
	{
	}

	// Token: 0x0600AA3B RID: 43579 RVA: 0x003F37AC File Offset: 0x003F19AC
	public override void ar(efk A_0)
	{
		A_0.PsiEmpathy = true;
	}

	// Token: 0x0600AA3C RID: 43580 RVA: 0x003F37B8 File Offset: 0x003F19B8
	public override void @as(efk A_0)
	{
		A_0.PsiEmpathy = false;
	}

	// Token: 0x0600AA3D RID: 43581 RVA: 0x003F37C4 File Offset: 0x003F19C4
	public override object[] at()
	{
		return new object[]
		{
			(int)(c3v.a * 100.0)
		};
	}

	// Token: 0x04003FBA RID: 16314
	public new static readonly double a = 0.2;
}
