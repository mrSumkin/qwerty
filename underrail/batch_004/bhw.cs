using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001EB6 RID: 7862
[ayj("Eviscerate")]
public sealed class bhw : bon
{
	// Token: 0x0600B123 RID: 45347 RVA: 0x00401838 File Offset: 0x003FFA38
	public override string y8()
	{
		return "Мясорубка";
	}

	// Token: 0x0600B124 RID: 45348 RVA: 0x00401840 File Offset: 0x003FFA40
	public override string os()
	{
		return "Eviscerate";
	}

	// Token: 0x0600B125 RID: 45349 RVA: 0x00401848 File Offset: 0x003FFA48
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B126 RID: 45350 RVA: 0x0040184C File Offset: 0x003FFA4C
	public override bool cs()
	{
		return true;
	}

	// Token: 0x0600B127 RID: 45351 RVA: 0x00401850 File Offset: 0x003FFA50
	public override int ct()
	{
		return 4;
	}

	// Token: 0x0600B128 RID: 45352 RVA: 0x00401854 File Offset: 0x003FFA54
	public bhw()
	{
		this.d = new List<string>();
		this.d.Add(d7f.a);
		this.d.Add("SAt.Eviscerate");
	}

	// Token: 0x0600B129 RID: 45353 RVA: 0x00401888 File Offset: 0x003FFA88
	public override string bm(cnm A_0)
	{
		return "SpecialAttack.Eviscerate";
	}

	// Token: 0x0600B12A RID: 45354 RVA: 0x00401890 File Offset: 0x003FFA90
	public override bool hm(cnm A_0)
	{
		if (base.hm(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() == btz.g)
		{
			WeaponSubtype? weaponSubtype = euf.d(A_0.b8().Offense.u().TypedDefinition);
			return weaponSubtype != null && weaponSubtype.Value / (WeaponSubtype)100 == WeaponSubtype.Pistol_762;
		}
		return false;
	}

	// Token: 0x0600B12B RID: 45355 RVA: 0x00401944 File Offset: 0x003FFB44
	public override bool cu(cnm A_0)
	{
		if (base.cu(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() == btz.g)
		{
			WeaponSubtype? weaponSubtype = euf.d(A_0.b8().Offense.u().TypedDefinition);
			return weaponSubtype != null && weaponSubtype.Value / (WeaponSubtype)100 == WeaponSubtype.Pistol_762;
		}
		return false;
	}

	// Token: 0x0600B12C RID: 45356 RVA: 0x004019F8 File Offset: 0x003FFBF8
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B12D RID: 45357 RVA: 0x004019FC File Offset: 0x003FFBFC
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAttacks/Eviscerate", new object[]
		{
			(int)(bhw.a(A_0) * 100.0)
		});
	}

	// Token: 0x0600B12E RID: 45358 RVA: 0x00401A28 File Offset: 0x003FFC28
	public new static double a(cnm A_0)
	{
		double num = bhw.b;
		if (A_0 != null && A_0.b8() != null)
		{
			num += (double)A_0.b8().GetSpecializationValue<dqk>(true) * dqk.a;
		}
		return num;
	}

	// Token: 0x0600B12F RID: 45359 RVA: 0x00401A64 File Offset: 0x003FFC64
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		list.Add(new cfd("SAt.Eviscerate", bhw.c * d0u.b, false, false));
		return list;
	}

	// Token: 0x0600B130 RID: 45360 RVA: 0x00401AB4 File Offset: 0x003FFCB4
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x0600B131 RID: 45361 RVA: 0x00401ABC File Offset: 0x003FFCBC
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0600B132 RID: 45362 RVA: 0x00401AC4 File Offset: 0x003FFCC4
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x04004103 RID: 16643
	private new const string a = "SAt.Eviscerate";

	// Token: 0x04004104 RID: 16644
	public static readonly double b = 0.5;

	// Token: 0x04004105 RID: 16645
	public static readonly int c = 1;

	// Token: 0x04004106 RID: 16646
	private List<string> d;
}
