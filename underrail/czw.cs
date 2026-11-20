using System;

// Token: 0x02001F67 RID: 8039
[ayj("BurrowerPoisonCaltropsThrow")]
public sealed class czw : b4f
{
	// Token: 0x0600BBFF RID: 48127 RVA: 0x004156D8 File Offset: 0x004138D8
	public override string y8()
	{
		return "Бросок колючек с ядом могильщика";
	}

	// Token: 0x0600BC00 RID: 48128 RVA: 0x004156E0 File Offset: 0x004138E0
	public override string os()
	{
		return "BurrowerPoisonCaltropsThrow";
	}

	// Token: 0x0600BC01 RID: 48129 RVA: 0x004156E8 File Offset: 0x004138E8
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600BC02 RID: 48130 RVA: 0x004156F0 File Offset: 0x004138F0
	public override string bp(cnm A_0)
	{
		int num = czw.b;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		c18.a(A_0);
		return qv.a("Caltrops/BurrowerPoison", new object[]
		{
			c18.f().a(true),
			c18.b1,
			num,
			l4.a(czw.a, false),
			czw.c
		});
	}

	// Token: 0x040043F7 RID: 17399
	public new static readonly int a = 5;

	// Token: 0x040043F8 RID: 17400
	public new static readonly int b = 2;

	// Token: 0x040043F9 RID: 17401
	public static readonly int c = 5;
}
