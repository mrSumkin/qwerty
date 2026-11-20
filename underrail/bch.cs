using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001E9F RID: 7839
[ayj("Riposte")]
public sealed class bch : bon
{
	// Token: 0x0600AFD7 RID: 45015 RVA: 0x003FEBB4 File Offset: 0x003FCDB4
	public override string y8()
	{
		return "Ответный удар";
	}

	// Token: 0x0600AFD8 RID: 45016 RVA: 0x003FEBBC File Offset: 0x003FCDBC
	public override string os()
	{
		return "Riposte";
	}

	// Token: 0x0600AFD9 RID: 45017 RVA: 0x003FEBC4 File Offset: 0x003FCDC4
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600AFDA RID: 45018 RVA: 0x003FEBC8 File Offset: 0x003FCDC8
	public override bool cs()
	{
		return true;
	}

	// Token: 0x0600AFDB RID: 45019 RVA: 0x003FEBCC File Offset: 0x003FCDCC
	public override int ct()
	{
		return 4;
	}

	// Token: 0x0600AFDC RID: 45020 RVA: 0x003FEBD0 File Offset: 0x003FCDD0
	public bch()
	{
		this.b = new List<string>();
		this.b.Add(d7f.a);
	}

	// Token: 0x0600AFDD RID: 45021 RVA: 0x003FEBF4 File Offset: 0x003FCDF4
	public override string bm(cnm A_0)
	{
		return "xpbl_Abilities.4";
	}

	// Token: 0x0600AFDE RID: 45022 RVA: 0x003FEC00 File Offset: 0x003FCE00
	public override bool hm(cnm A_0)
	{
		if (base.hm(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() == btz.g && A_0.b8().StatusEffects.a(edz.a))
		{
			WeaponSubtype? weaponSubtype = euf.d(A_0.b8().Offense.u().TypedDefinition);
			return weaponSubtype != null && weaponSubtype.Value / (WeaponSubtype)100 == WeaponSubtype.Pistol_Laser;
		}
		return false;
	}

	// Token: 0x0600AFDF RID: 45023 RVA: 0x003FECCC File Offset: 0x003FCECC
	public override bool cu(cnm A_0)
	{
		if (base.cu(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() == btz.g)
		{
			WeaponSubtype? weaponSubtype = euf.d(A_0.b8().Offense.u().TypedDefinition);
			return weaponSubtype != null && weaponSubtype.Value / (WeaponSubtype)100 == WeaponSubtype.Pistol_Laser;
		}
		return false;
	}

	// Token: 0x0600AFE0 RID: 45024 RVA: 0x003FED80 File Offset: 0x003FCF80
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600AFE1 RID: 45025 RVA: 0x003FED88 File Offset: 0x003FCF88
	public override string bo(cnm A_0)
	{
		double num = 0.0;
		if (A_0 != null && A_0.b8() != null)
		{
			num = (double)A_0.b8().GetSpecializationValue<dk9>(true) * dk9.a;
		}
		if (num > 0.0)
		{
			return qv.a("SpecialAttacks/RiposteWithCrit", new object[]
			{
				(int)(num * 100.0)
			});
		}
		return qv.b("SpecialAttacks/Riposte");
	}

	// Token: 0x0600AFE2 RID: 45026 RVA: 0x003FEE04 File Offset: 0x003FD004
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600AFE3 RID: 45027 RVA: 0x003FEE38 File Offset: 0x003FD038
	public override IList<string> bi()
	{
		return this.b;
	}

	// Token: 0x0600AFE4 RID: 45028 RVA: 0x003FEE40 File Offset: 0x003FD040
	public override double l9(cnm A_0, double A_1)
	{
		return bch.a;
	}

	// Token: 0x0600AFE5 RID: 45029 RVA: 0x003FEE48 File Offset: 0x003FD048
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0600AFE6 RID: 45030 RVA: 0x003FEE50 File Offset: 0x003FD050
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600AFE7 RID: 45031 RVA: 0x003FEE58 File Offset: 0x003FD058
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x040040BF RID: 16575
	public new static readonly double a = 1.25;

	// Token: 0x040040C0 RID: 16576
	private List<string> b;
}
