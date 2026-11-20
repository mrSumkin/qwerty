using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EA3 RID: 7843
[ayj("DoubleShot")]
public sealed class cxj : bon
{
	// Token: 0x0600B01E RID: 45086 RVA: 0x003FF7B4 File Offset: 0x003FD9B4
	public override string y8()
	{
		return "Двойной выстрел";
	}

	// Token: 0x0600B01F RID: 45087 RVA: 0x003FF7BC File Offset: 0x003FD9BC
	public override string os()
	{
		return "DoubleShot";
	}

	// Token: 0x0600B020 RID: 45088 RVA: 0x003FF7C4 File Offset: 0x003FD9C4
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B021 RID: 45089 RVA: 0x003FF7C8 File Offset: 0x003FD9C8
	public override bool cs()
	{
		return false;
	}

	// Token: 0x0600B022 RID: 45090 RVA: 0x003FF7CC File Offset: 0x003FD9CC
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B023 RID: 45091 RVA: 0x003FF7D0 File Offset: 0x003FD9D0
	public override bool j7()
	{
		return false;
	}

	// Token: 0x0600B024 RID: 45092 RVA: 0x003FF7D4 File Offset: 0x003FD9D4
	public override bool l8()
	{
		return false;
	}

	// Token: 0x0600B025 RID: 45093 RVA: 0x003FF7D8 File Offset: 0x003FD9D8
	public cxj()
	{
		this.a = new List<string>();
		this.a.Add(d7f.a);
	}

	// Token: 0x0600B026 RID: 45094 RVA: 0x003FF7FC File Offset: 0x003FD9FC
	public override string bm(cnm A_0)
	{
		return "xpbl_Abilities.16";
	}

	// Token: 0x0600B027 RID: 45095 RVA: 0x003FF804 File Offset: 0x003FDA04
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && euf.k(A_0.b8().Offense.u()) && A_0.b8().Offense.u().LoadedAmmo.Count == 2 && A_0.b8().Offense.u().TypedDefinition.e("DoubleShot");
	}

	// Token: 0x0600B028 RID: 45096 RVA: 0x003FF8B8 File Offset: 0x003FDAB8
	public override bool cu(cnm A_0)
	{
		return A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && euf.k(A_0.b8().Offense.u()) && A_0.b8().Offense.u().LoadedAmmo.Count == 2 && A_0.b8().Offense.u().TypedDefinition.e("DoubleShot");
	}

	// Token: 0x0600B029 RID: 45097 RVA: 0x003FF960 File Offset: 0x003FDB60
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B02A RID: 45098 RVA: 0x003FF964 File Offset: 0x003FDB64
	public override string bo(cnm A_0)
	{
		return qv.b("SpecialAttacks/DoubleShot");
	}

	// Token: 0x0600B02B RID: 45099 RVA: 0x003FF970 File Offset: 0x003FDB70
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600B02C RID: 45100 RVA: 0x003FF97C File Offset: 0x003FDB7C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B02D RID: 45101 RVA: 0x003FF9B0 File Offset: 0x003FDBB0
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x0600B02E RID: 45102 RVA: 0x003FF9B8 File Offset: 0x003FDBB8
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x040040D2 RID: 16594
	private new List<string> a;
}
