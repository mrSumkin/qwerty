using System;

// Token: 0x02001F69 RID: 8041
[ayj("BlindingPoisonCaltropsThrow")]
public sealed class by7 : b4f
{
	// Token: 0x0600BC0A RID: 48138 RVA: 0x00415864 File Offset: 0x00413A64
	public override string y8()
	{
		return "Бросок колючек с ядом слепитель";
	}

	// Token: 0x0600BC0B RID: 48139 RVA: 0x0041586C File Offset: 0x00413A6C
	public override string os()
	{
		return "BlindingPoisonCaltropsThrow";
	}

	// Token: 0x0600BC0C RID: 48140 RVA: 0x00415874 File Offset: 0x00413A74
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600BC0D RID: 48141 RVA: 0x0041587C File Offset: 0x00413A7C
	public override string bp(cnm A_0)
	{
		c18.a(A_0);
		if (A_0 != null)
		{
			A_0.b9();
		}
		int num = ezx.l;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return qv.a("Caltrops/BlindingPoison", new object[]
		{
			c18.f().a(true),
			c18.b1,
			num,
			l4.a(ezx.o, false),
			ezx.m,
			ezx.n
		});
	}
}
