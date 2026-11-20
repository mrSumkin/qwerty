using System;
using System.Collections.Generic;

// Token: 0x02001EAD RID: 7853
[ayj("ShootBlindingPoisonBolt")]
public sealed class cvo : eyv
{
	// Token: 0x0600B0AE RID: 45230 RVA: 0x004004D8 File Offset: 0x003FE6D8
	public override string y8()
	{
		return "Выстрел болтом с ядом слепитель";
	}

	// Token: 0x0600B0AF RID: 45231 RVA: 0x004004E0 File Offset: 0x003FE6E0
	public override string os()
	{
		return "ShootBlindingPoisonBolt";
	}

	// Token: 0x0600B0B0 RID: 45232 RVA: 0x004004E8 File Offset: 0x003FE6E8
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B0B1 RID: 45233 RVA: 0x004004EC File Offset: 0x003FE6EC
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B0B2 RID: 45234 RVA: 0x004004F0 File Offset: 0x003FE6F0
	public cvo()
	{
		this.a = new List<string>();
		this.a.Add(d7f.a);
	}

	// Token: 0x0600B0B3 RID: 45235 RVA: 0x00400514 File Offset: 0x003FE714
	public override string bo(cnm A_0)
	{
		int num = ezx.l;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return qv.a("SpecialAttacks/ShootBlindingPoisonBolt", new object[]
		{
			num,
			l4.a(ezx.o, false),
			ezx.m,
			ezx.n
		});
	}

	// Token: 0x0600B0B4 RID: 45236 RVA: 0x004005A4 File Offset: 0x003FE7A4
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600B0B5 RID: 45237 RVA: 0x004005B0 File Offset: 0x003FE7B0
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B0B6 RID: 45238 RVA: 0x004005E4 File Offset: 0x003FE7E4
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x040040E7 RID: 16615
	private new List<string> a;
}
