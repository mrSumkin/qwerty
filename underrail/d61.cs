using System;
using System.Collections.Generic;

// Token: 0x02001EAF RID: 7855
[ayj("ShootSpiritPoisonBolt")]
public sealed class d61 : eyv
{
	// Token: 0x0600B0C1 RID: 45249 RVA: 0x004006E8 File Offset: 0x003FE8E8
	public override string y8()
	{
		return "Запустить отравленный болт";
	}

	// Token: 0x0600B0C2 RID: 45250 RVA: 0x004006F0 File Offset: 0x003FE8F0
	public override string os()
	{
		return "ShootSpiritPoisonBolt";
	}

	// Token: 0x0600B0C3 RID: 45251 RVA: 0x004006F8 File Offset: 0x003FE8F8
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B0C4 RID: 45252 RVA: 0x004006FC File Offset: 0x003FE8FC
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B0C5 RID: 45253 RVA: 0x00400700 File Offset: 0x003FE900
	public d61()
	{
		this.a = new List<string>();
		this.a.Add(d7f.a);
	}

	// Token: 0x0600B0C6 RID: 45254 RVA: 0x00400728 File Offset: 0x003FE928
	public override string bo(cnm A_0)
	{
		int num = ezx.i;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return qv.a("SpecialAttacks/ShootSpiritPoisonBolt", new object[]
		{
			num,
			l4.a(ezx.h, false),
			(int)(ezx.j * 100.0)
		});
	}

	// Token: 0x0600B0C7 RID: 45255 RVA: 0x004007B8 File Offset: 0x003FE9B8
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600B0C8 RID: 45256 RVA: 0x004007C4 File Offset: 0x003FE9C4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B0C9 RID: 45257 RVA: 0x004007F8 File Offset: 0x003FE9F8
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x040040EC RID: 16620
	private new List<string> a;
}
