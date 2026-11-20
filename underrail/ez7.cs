using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E9A RID: 7834
[ayj("PiercingShot")]
public sealed class ez7 : bon
{
	// Token: 0x0600AF76 RID: 44918 RVA: 0x003FDF34 File Offset: 0x003FC134
	public override string y8()
	{
		return "Пронзающий выстрел";
	}

	// Token: 0x0600AF77 RID: 44919 RVA: 0x003FDF3C File Offset: 0x003FC13C
	public override string os()
	{
		return "PiercingShot";
	}

	// Token: 0x0600AF78 RID: 44920 RVA: 0x003FDF44 File Offset: 0x003FC144
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600AF79 RID: 44921 RVA: 0x003FDF48 File Offset: 0x003FC148
	public override bool cs()
	{
		return false;
	}

	// Token: 0x0600AF7A RID: 44922 RVA: 0x003FDF4C File Offset: 0x003FC14C
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600AF7B RID: 44923 RVA: 0x003FDF50 File Offset: 0x003FC150
	public override bool j7()
	{
		return true;
	}

	// Token: 0x0600AF7C RID: 44924 RVA: 0x003FDF54 File Offset: 0x003FC154
	public override bool i2()
	{
		return true;
	}

	// Token: 0x0600AF7D RID: 44925 RVA: 0x003FDF58 File Offset: 0x003FC158
	public ez7()
	{
		this.c = new List<string>();
		this.c.Add(d7f.a);
		this.c.Add(ez7.a);
	}

	// Token: 0x0600AF7E RID: 44926 RVA: 0x003FDF8C File Offset: 0x003FC18C
	public override string bm(cnm A_0)
	{
		return "Attacks.26";
	}

	// Token: 0x0600AF7F RID: 44927 RVA: 0x003FDF94 File Offset: 0x003FC194
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600AF80 RID: 44928 RVA: 0x003FDF98 File Offset: 0x003FC198
	public override string bo(cnm A_0)
	{
		return qv.b("SpecialAttacks/PiercingShot");
	}

	// Token: 0x0600AF81 RID: 44929 RVA: 0x003FDFA4 File Offset: 0x003FC1A4
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600AF82 RID: 44930 RVA: 0x003FDFB0 File Offset: 0x003FC1B0
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		list.Add(new cfd(ez7.a, ez7.b, false, false));
		return list;
	}

	// Token: 0x0600AF83 RID: 44931 RVA: 0x003FDFFC File Offset: 0x003FC1FC
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600AF84 RID: 44932 RVA: 0x003FE004 File Offset: 0x003FC204
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x040040AA RID: 16554
	public new static readonly string a = "SAt.PiercingShot";

	// Token: 0x040040AB RID: 16555
	public static readonly int b = 15000;

	// Token: 0x040040AC RID: 16556
	private List<string> c;
}
