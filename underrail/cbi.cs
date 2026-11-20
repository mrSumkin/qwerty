using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001EB2 RID: 7858
[ayj("SuperSlam")]
public sealed class cbi : bon
{
	// Token: 0x0600B0DD RID: 45277 RVA: 0x00400A20 File Offset: 0x003FEC20
	public override string y8()
	{
		return "Вразнос";
	}

	// Token: 0x0600B0DE RID: 45278 RVA: 0x00400A28 File Offset: 0x003FEC28
	public override string os()
	{
		return "SuperSlam";
	}

	// Token: 0x0600B0DF RID: 45279 RVA: 0x00400A30 File Offset: 0x003FEC30
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B0E0 RID: 45280 RVA: 0x00400A34 File Offset: 0x003FEC34
	public override bool cs()
	{
		return true;
	}

	// Token: 0x0600B0E1 RID: 45281 RVA: 0x00400A38 File Offset: 0x003FEC38
	public override int ct()
	{
		return 3;
	}

	// Token: 0x0600B0E2 RID: 45282 RVA: 0x00400A3C File Offset: 0x003FEC3C
	public cbi()
	{
		this.d = new List<string>();
		this.d.Add(d7f.a);
		this.d.Add("SAt.SuperSlam");
	}

	// Token: 0x0600B0E3 RID: 45283 RVA: 0x00400A70 File Offset: 0x003FEC70
	public override string bm(cnm A_0)
	{
		return "SuperSlam";
	}

	// Token: 0x0600B0E4 RID: 45284 RVA: 0x00400A78 File Offset: 0x003FEC78
	public override bool hm(cnm A_0)
	{
		if (base.hm(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() == btz.g)
		{
			WeaponSubtype? weaponSubtype = euf.d(A_0.b8().Offense.u().TypedDefinition);
			return weaponSubtype != null && weaponSubtype.Value == WeaponSubtype.Sledgehammer;
		}
		return false;
	}

	// Token: 0x0600B0E5 RID: 45285 RVA: 0x00400B28 File Offset: 0x003FED28
	public override bool cu(cnm A_0)
	{
		if (base.cu(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() == btz.g)
		{
			WeaponSubtype? weaponSubtype = euf.d(A_0.b8().Offense.u().TypedDefinition);
			return weaponSubtype != null && weaponSubtype.Value == WeaponSubtype.Sledgehammer;
		}
		return false;
	}

	// Token: 0x0600B0E6 RID: 45286 RVA: 0x00400BD8 File Offset: 0x003FEDD8
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B0E7 RID: 45287 RVA: 0x00400BE0 File Offset: 0x003FEDE0
	public override string bo(cnm A_0)
	{
		int num = 0;
		if (A_0 != null && A_0.b8() != null)
		{
			num = (int)(cbi.a(A_0) * (double)A_0.b8().Defense.q().zm());
		}
		return qv.a("SpecialAttacks/SuperSlam", new object[]
		{
			num,
			(int)(cbi.a(A_0) * 100.0)
		});
	}

	// Token: 0x0600B0E8 RID: 45288 RVA: 0x00400C54 File Offset: 0x003FEE54
	public new static double a(cnm A_0)
	{
		double num = cbi.b;
		if (A_0 != null && A_0.b8() != null)
		{
			num += (double)A_0.b8().GetSpecializationValue<a0g>(true) * a0g.a;
		}
		return num;
	}

	// Token: 0x0600B0E9 RID: 45289 RVA: 0x00400C90 File Offset: 0x003FEE90
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		list.Add(new cfd("SAt.SuperSlam", cbi.c * d0u.b, false, false));
		return list;
	}

	// Token: 0x0600B0EA RID: 45290 RVA: 0x00400CE0 File Offset: 0x003FEEE0
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x0600B0EB RID: 45291 RVA: 0x00400CE8 File Offset: 0x003FEEE8
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0600B0EC RID: 45292 RVA: 0x00400CF0 File Offset: 0x003FEEF0
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x040040F3 RID: 16627
	private new const string a = "SAt.SuperSlam";

	// Token: 0x040040F4 RID: 16628
	public static readonly double b = 0.2;

	// Token: 0x040040F5 RID: 16629
	public static readonly int c = 3;

	// Token: 0x040040F6 RID: 16630
	private List<string> d;
}
