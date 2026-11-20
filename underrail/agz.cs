using System;

// Token: 0x02001F5D RID: 8029
[ayj("PlaceEmpMine")]
public sealed class agz : dg1
{
	// Token: 0x0600BB75 RID: 47989 RVA: 0x00414D9C File Offset: 0x00412F9C
	public override string y8()
	{
		return "Place EMP Mine";
	}

	// Token: 0x0600BB76 RID: 47990 RVA: 0x00414DA4 File Offset: 0x00412FA4
	public override string os()
	{
		return "PlaceEmpMine";
	}

	// Token: 0x0600BB77 RID: 47991 RVA: 0x00414DAC File Offset: 0x00412FAC
	public override bool ds()
	{
		return true;
	}

	// Token: 0x0600BB78 RID: 47992 RVA: 0x00414DB0 File Offset: 0x00412FB0
	public override string bp(cnm A_0)
	{
		int a_ = c18.a(A_0);
		return qv.a("Traps/EmpMine", new object[]
		{
			c18.n(a_).a(true),
			c18.m(a_),
			(int)(c18.a5 * 100.0)
		});
	}

	// Token: 0x0600BB79 RID: 47993 RVA: 0x00414E0C File Offset: 0x0041300C
	protected override int d2(cnm A_0)
	{
		return c18.e();
	}
}
