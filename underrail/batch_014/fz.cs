using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001EBA RID: 7866
[ayj("CripplingStrike")]
public sealed class fz : bon
{
	// Token: 0x0600B166 RID: 45414 RVA: 0x00402068 File Offset: 0x00400268
	public override string y8()
	{
		return "Калечащий удар";
	}

	// Token: 0x0600B167 RID: 45415 RVA: 0x00402070 File Offset: 0x00400270
	public override string os()
	{
		return "CripplingStrike";
	}

	// Token: 0x0600B168 RID: 45416 RVA: 0x00402078 File Offset: 0x00400278
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B169 RID: 45417 RVA: 0x0040207C File Offset: 0x0040027C
	public override bool cs()
	{
		return true;
	}

	// Token: 0x0600B16A RID: 45418 RVA: 0x00402080 File Offset: 0x00400280
	public override int ct()
	{
		return 3;
	}

	// Token: 0x0600B16B RID: 45419 RVA: 0x00402084 File Offset: 0x00400284
	public fz()
	{
		this.g = new List<string>();
		this.g.Add(d7f.a);
		this.g.Add("SAt.CripplingStrike");
	}

	// Token: 0x0600B16C RID: 45420 RVA: 0x004020B8 File Offset: 0x004002B8
	public override string bm(cnm A_0)
	{
		return "SpecialAttack.CripplingStrike";
	}

	// Token: 0x0600B16D RID: 45421 RVA: 0x004020C0 File Offset: 0x004002C0
	public override bool hm(cnm A_0)
	{
		if (!base.hm(A_0) || A_0 == null || A_0.b8() == null || A_0.b8().Offense.u() == null || A_0.b8().Offense.u().TypedDefinition == null || A_0.b8().Offense.u().TypedDefinition.e() != btz.g)
		{
			return false;
		}
		if (euf.o(A_0.b8().Offense.u()) || euf.n(A_0.b8().Offense.u()))
		{
			return true;
		}
		WeaponSubtype? weaponSubtype = euf.d(A_0.b8().Offense.u().TypedDefinition);
		return weaponSubtype != null && weaponSubtype.Value / (WeaponSubtype)100 == WeaponSubtype.Pistol_762;
	}

	// Token: 0x0600B16E RID: 45422 RVA: 0x004021A8 File Offset: 0x004003A8
	public override bool cu(cnm A_0)
	{
		if (!base.cu(A_0) || A_0 == null || A_0.b8() == null || A_0.b8().Offense.u() == null || A_0.b8().Offense.u().TypedDefinition == null || A_0.b8().Offense.u().TypedDefinition.e() != btz.g)
		{
			return false;
		}
		if (euf.o(A_0.b8().Offense.u()) || euf.n(A_0.b8().Offense.u()))
		{
			return true;
		}
		WeaponSubtype? weaponSubtype = euf.d(A_0.b8().Offense.u().TypedDefinition);
		return weaponSubtype != null && weaponSubtype.Value / (WeaponSubtype)100 == WeaponSubtype.Pistol_762;
	}

	// Token: 0x0600B16F RID: 45423 RVA: 0x00402290 File Offset: 0x00400490
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B170 RID: 45424 RVA: 0x00402298 File Offset: 0x00400498
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAttacks/CripplingStrike", new object[]
		{
			(int)(fz.a(A_0) * 100.0),
			fz.e,
			l4.a((double)fz.c, false),
			fz.d
		});
	}

	// Token: 0x0600B171 RID: 45425 RVA: 0x004022F8 File Offset: 0x004004F8
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		list.Add(new cfd("SAt.CripplingStrike", fz.f * d0u.b, false, false));
		return list;
	}

	// Token: 0x0600B172 RID: 45426 RVA: 0x00402348 File Offset: 0x00400548
	public override IList<string> bi()
	{
		return this.g;
	}

	// Token: 0x0600B173 RID: 45427 RVA: 0x00402354 File Offset: 0x00400554
	public new static double a(cnm A_0)
	{
		double num = fz.b;
		if (A_0 != null && A_0.b8() != null)
		{
			num += (double)A_0.b8().GetSpecializationValue<wp>(true) * wp.a;
			erz microfeat = A_0.b8().GetMicrofeat<erz>();
			if (microfeat != null)
			{
				num = Math.Max(0.1, num + microfeat.DamageBonus);
			}
		}
		return num;
	}

	// Token: 0x0600B174 RID: 45428 RVA: 0x004023B8 File Offset: 0x004005B8
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0600B175 RID: 45429 RVA: 0x004023C0 File Offset: 0x004005C0
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x04004115 RID: 16661
	private new const string a = "SAt.CripplingStrike";

	// Token: 0x04004116 RID: 16662
	public static readonly double b = 1.5;

	// Token: 0x04004117 RID: 16663
	public static readonly int c = d0u.b * 5;

	// Token: 0x04004118 RID: 16664
	public static readonly int d = 3;

	// Token: 0x04004119 RID: 16665
	public new static readonly int e = 2;

	// Token: 0x0400411A RID: 16666
	public static readonly int f = 1;

	// Token: 0x0400411B RID: 16667
	private new List<string> g;
}
