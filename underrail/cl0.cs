using System;
using System.Collections.Generic;

// Token: 0x02001EA9 RID: 7849
[ayj("ShootLeperPoisonBolt")]
public sealed class cl0 : eyv
{
	// Token: 0x0600B072 RID: 45170 RVA: 0x003FFEF8 File Offset: 0x003FE0F8
	public override string y8()
	{
		return "Выстрел болтом с ядом прокажённого змея";
	}

	// Token: 0x0600B073 RID: 45171 RVA: 0x003FFF00 File Offset: 0x003FE100
	public override string os()
	{
		return "ShootLeperPoisonBolt";
	}

	// Token: 0x0600B074 RID: 45172 RVA: 0x003FFF08 File Offset: 0x003FE108
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B075 RID: 45173 RVA: 0x003FFF0C File Offset: 0x003FE10C
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B076 RID: 45174 RVA: 0x003FFF10 File Offset: 0x003FE110
	public cl0()
	{
		this.a = new List<string>();
		this.a.Add(d7f.a);
	}

	// Token: 0x0600B077 RID: 45175 RVA: 0x003FFF38 File Offset: 0x003FE138
	public override string bo(cnm A_0)
	{
		int num = ezx.q;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return qv.a("SpecialAttacks/ShootLeperPoisonBolt", new object[]
		{
			num,
			l4.a(ezx.t, false),
			(int)(ezx.r * 100.0),
			ezx.s
		});
	}

	// Token: 0x0600B078 RID: 45176 RVA: 0x003FFFD4 File Offset: 0x003FE1D4
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600B079 RID: 45177 RVA: 0x003FFFE0 File Offset: 0x003FE1E0
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B07A RID: 45178 RVA: 0x00400014 File Offset: 0x003FE214
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x040040DF RID: 16607
	private new List<string> a;
}
