using System;

// Token: 0x02001F68 RID: 8040
[ayj("CaveEarPoisonCaltropsThrow")]
public sealed class a5n : b4f
{
	// Token: 0x0600BC05 RID: 48133 RVA: 0x004157B4 File Offset: 0x004139B4
	public override string y8()
	{
		return "Бросок колючек с ядом пещерного уха";
	}

	// Token: 0x0600BC06 RID: 48134 RVA: 0x004157BC File Offset: 0x004139BC
	public override string os()
	{
		return "CaveEarPoisonCaltropsThrow";
	}

	// Token: 0x0600BC07 RID: 48135 RVA: 0x004157C4 File Offset: 0x004139C4
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600BC08 RID: 48136 RVA: 0x004157CC File Offset: 0x004139CC
	public override string bp(cnm A_0)
	{
		c18.a(A_0);
		coh a_ = (A_0 != null) ? (A_0.b9() as coh) : null;
		return qv.a("Caltrops/CaveEarPoison", new object[]
		{
			c18.f().a(true),
			c18.b1,
			(int)(ezx.a * 100.0),
			ezx.b,
			l4.a(cl5.d(a_), false)
		});
	}
}
