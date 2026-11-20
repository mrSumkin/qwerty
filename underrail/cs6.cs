using System;

// Token: 0x02001F5F RID: 8031
[ayj("PlaceFragMine")]
public sealed class cs6 : dg1
{
	// Token: 0x0600BB81 RID: 48001 RVA: 0x00414EA0 File Offset: 0x004130A0
	public override string y8()
	{
		return "Place Frag Mine";
	}

	// Token: 0x0600BB82 RID: 48002 RVA: 0x00414EA8 File Offset: 0x004130A8
	public override string os()
	{
		return "PlaceFragMine";
	}

	// Token: 0x0600BB83 RID: 48003 RVA: 0x00414EB0 File Offset: 0x004130B0
	public override bool ds()
	{
		return true;
	}

	// Token: 0x0600BB84 RID: 48004 RVA: 0x00414EB4 File Offset: 0x004130B4
	public override string bp(cnm A_0)
	{
		int a_ = c18.a(A_0);
		return qv.a("Traps/FragMine", new object[]
		{
			c18.s(a_).a(true),
			c18.ar,
			c18.@as,
			c18.t(a_).a(true)
		});
	}

	// Token: 0x0600BB85 RID: 48005 RVA: 0x00414F18 File Offset: 0x00413118
	protected override int d2(cnm A_0)
	{
		return c18.j();
	}
}
