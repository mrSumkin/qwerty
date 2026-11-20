using System;
using System.Collections.Generic;

// Token: 0x02001EB0 RID: 7856
[ayj("ShootBlackDragonPoisonBolt")]
public sealed class dby : eyv
{
	// Token: 0x0600B0CA RID: 45258 RVA: 0x00400800 File Offset: 0x003FEA00
	public override string y8()
	{
		return "Запустить отравленный болт";
	}

	// Token: 0x0600B0CB RID: 45259 RVA: 0x00400808 File Offset: 0x003FEA08
	public override string os()
	{
		return "ShootBlackDragonPoisonBolt";
	}

	// Token: 0x0600B0CC RID: 45260 RVA: 0x00400810 File Offset: 0x003FEA10
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B0CD RID: 45261 RVA: 0x00400814 File Offset: 0x003FEA14
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B0CE RID: 45262 RVA: 0x00400818 File Offset: 0x003FEA18
	public dby()
	{
		this.a = new List<string>();
		this.a.Add(d7f.a);
	}

	// Token: 0x0600B0CF RID: 45263 RVA: 0x0040083C File Offset: 0x003FEA3C
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAttacks/ShootBlackDragonPoisonBolt", new object[]
		{
			l4.a(ezx.g, false)
		});
	}

	// Token: 0x0600B0D0 RID: 45264 RVA: 0x0040085C File Offset: 0x003FEA5C
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600B0D1 RID: 45265 RVA: 0x00400868 File Offset: 0x003FEA68
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B0D2 RID: 45266 RVA: 0x0040089C File Offset: 0x003FEA9C
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x040040ED RID: 16621
	private new List<string> a;
}
