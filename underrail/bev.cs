using System;

// Token: 0x02001F52 RID: 8018
[ayj("PlacePlasmaMine")]
public sealed class bev : dg1
{
	// Token: 0x0600BB40 RID: 47936 RVA: 0x004145DC File Offset: 0x004127DC
	public override string y8()
	{
		return "Place Plasma Mine";
	}

	// Token: 0x0600BB41 RID: 47937 RVA: 0x004145E4 File Offset: 0x004127E4
	public override string os()
	{
		return "PlacePlasmaMine";
	}

	// Token: 0x0600BB42 RID: 47938 RVA: 0x004145EC File Offset: 0x004127EC
	public override bool ds()
	{
		return true;
	}

	// Token: 0x0600BB43 RID: 47939 RVA: 0x004145F4 File Offset: 0x004127F4
	public override string bp(cnm A_0)
	{
		int a_ = c18.a(A_0);
		return qv.a("Traps/PlasmaMine", new object[]
		{
			c18.o(a_).a(true),
			c18.p(a_).a(true)
		});
	}

	// Token: 0x0600BB44 RID: 47940 RVA: 0x0041463C File Offset: 0x0041283C
	protected override int d2(cnm A_0)
	{
		return c18.h();
	}
}
