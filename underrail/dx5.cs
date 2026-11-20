using System;

// Token: 0x02001F5E RID: 8030
[ayj("PlaceHeMine")]
public sealed class dx5 : dg1
{
	// Token: 0x0600BB7B RID: 47995 RVA: 0x00414E1C File Offset: 0x0041301C
	public override string y8()
	{
		return "Place HE Mine";
	}

	// Token: 0x0600BB7C RID: 47996 RVA: 0x00414E24 File Offset: 0x00413024
	public override string os()
	{
		return "PlaceHeMine";
	}

	// Token: 0x0600BB7D RID: 47997 RVA: 0x00414E2C File Offset: 0x0041302C
	public override bool ds()
	{
		return true;
	}

	// Token: 0x0600BB7E RID: 47998 RVA: 0x00414E30 File Offset: 0x00413030
	public override string bp(cnm A_0)
	{
		int a_ = c18.a(A_0);
		return qv.a("Traps/HeMine", new object[]
		{
			c18.r(a_).a(true),
			c18.q(a_).a(true),
			(int)(c18.g * 100.0)
		});
	}

	// Token: 0x0600BB7F RID: 47999 RVA: 0x00414E90 File Offset: 0x00413090
	protected override int d2(cnm A_0)
	{
		return c18.i();
	}
}
