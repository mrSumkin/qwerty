using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001EBD RID: 7869
[ayj("Pummel")]
public sealed class bho : bon
{
	// Token: 0x0600B18E RID: 45454 RVA: 0x004027F0 File Offset: 0x004009F0
	public override string y8()
	{
		return "Избиение";
	}

	// Token: 0x0600B18F RID: 45455 RVA: 0x004027F8 File Offset: 0x004009F8
	public override string os()
	{
		return "Pummel";
	}

	// Token: 0x0600B190 RID: 45456 RVA: 0x00402800 File Offset: 0x00400A00
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B191 RID: 45457 RVA: 0x00402804 File Offset: 0x00400A04
	public override bool cs()
	{
		return true;
	}

	// Token: 0x0600B192 RID: 45458 RVA: 0x00402808 File Offset: 0x00400A08
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B193 RID: 45459 RVA: 0x0040280C File Offset: 0x00400A0C
	public bho()
	{
		this.f = new List<string>();
		this.f.Add(d7f.a);
		this.f.Add("SAt.Pummel");
	}

	// Token: 0x0600B194 RID: 45460 RVA: 0x00402840 File Offset: 0x00400A40
	public override string bm(cnm A_0)
	{
		return "SpecialAttack.Pummel";
	}

	// Token: 0x0600B195 RID: 45461 RVA: 0x00402848 File Offset: 0x00400A48
	public override bool hm(cnm A_0)
	{
		if (base.hm(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() == btz.g)
		{
			WeaponSubtype? weaponSubtype = euf.d(A_0.b8().Offense.u().TypedDefinition);
			return weaponSubtype != null && weaponSubtype.Value == WeaponSubtype.Sledgehammer;
		}
		return false;
	}

	// Token: 0x0600B196 RID: 45462 RVA: 0x004028F8 File Offset: 0x00400AF8
	public override bool cu(cnm A_0)
	{
		if (base.cu(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() == btz.g)
		{
			WeaponSubtype? weaponSubtype = euf.d(A_0.b8().Offense.u().TypedDefinition);
			return weaponSubtype != null && weaponSubtype.Value == WeaponSubtype.Sledgehammer;
		}
		return false;
	}

	// Token: 0x0600B197 RID: 45463 RVA: 0x004029A8 File Offset: 0x00400BA8
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B198 RID: 45464 RVA: 0x004029AC File Offset: 0x00400BAC
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAttacks/Pummel", new object[]
		{
			Convert.ToInt32(bho.a(A_0) * 100.0),
			l4.a((double)bho.c, false)
		});
	}

	// Token: 0x0600B199 RID: 45465 RVA: 0x004029F0 File Offset: 0x00400BF0
	public new static double a(cnm A_0)
	{
		double num = bho.b;
		if (A_0 != null && A_0.b8() != null)
		{
			num += (double)A_0.b8().GetSpecializationValue<cty>(true) * cty.a;
		}
		return num;
	}

	// Token: 0x0600B19A RID: 45466 RVA: 0x00402A2C File Offset: 0x00400C2C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		list.Add(new cfd("SAt.Pummel", bho.d, false, false));
		return list;
	}

	// Token: 0x0600B19B RID: 45467 RVA: 0x00402A78 File Offset: 0x00400C78
	public override IList<string> bi()
	{
		return this.f;
	}

	// Token: 0x0600B19C RID: 45468 RVA: 0x00402A80 File Offset: 0x00400C80
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0600B19D RID: 45469 RVA: 0x00402A88 File Offset: 0x00400C88
	protected override int hi(cnm A_0)
	{
		int num = bho.e;
		if (A_0 != null && A_0.b8() != null)
		{
			num = Math.Max(0, num - A_0.b8().GetSpecializationValue<auk>(true) * auk.a);
			ol microfeat = A_0.b8().GetMicrofeat<ol>();
			if (microfeat != null)
			{
				num = Math.Max(0, num + microfeat.a());
			}
		}
		return num;
	}

	// Token: 0x0600B19E RID: 45470 RVA: 0x00402AEC File Offset: 0x00400CEC
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x04004124 RID: 16676
	private new const string a = "SAt.Pummel";

	// Token: 0x04004125 RID: 16677
	public static readonly double b = 0.5;

	// Token: 0x04004126 RID: 16678
	public static readonly int c = d0u.b * 2;

	// Token: 0x04004127 RID: 16679
	public static readonly int d = d0u.b;

	// Token: 0x04004128 RID: 16680
	public new static readonly int e = 10;

	// Token: 0x04004129 RID: 16681
	private List<string> f;
}
