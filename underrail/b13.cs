using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001EC8 RID: 7880
[ayj("Execute")]
public sealed class b13 : bon
{
	// Token: 0x0600B224 RID: 45604 RVA: 0x00403F90 File Offset: 0x00402190
	public override string y8()
	{
		return "Казнь";
	}

	// Token: 0x0600B225 RID: 45605 RVA: 0x00403F98 File Offset: 0x00402198
	public override string os()
	{
		return "Execute";
	}

	// Token: 0x0600B226 RID: 45606 RVA: 0x00403FA0 File Offset: 0x004021A0
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B227 RID: 45607 RVA: 0x00403FA4 File Offset: 0x004021A4
	public override bool cs()
	{
		return false;
	}

	// Token: 0x0600B228 RID: 45608 RVA: 0x00403FA8 File Offset: 0x004021A8
	public override int ct()
	{
		return 2;
	}

	// Token: 0x0600B229 RID: 45609 RVA: 0x00403FAC File Offset: 0x004021AC
	public b13()
	{
		this.b = new List<string>();
		this.b.Add(d7f.a);
		this.b.Add("SAt.Execute");
	}

	// Token: 0x0600B22A RID: 45610 RVA: 0x00403FE0 File Offset: 0x004021E0
	public override string bm(cnm A_0)
	{
		return "SpecialAttack.Execute";
	}

	// Token: 0x0600B22B RID: 45611 RVA: 0x00403FEC File Offset: 0x004021EC
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() == btz.a && euf.d(A_0.b8().Offense.u().TypedDefinition).GetValueOrDefault() != WeaponSubtype.Pistol_Electro && euf.d(A_0.b8().Offense.u().TypedDefinition).GetValueOrDefault() != WeaponSubtype.Pistol_Sonic;
	}

	// Token: 0x0600B22C RID: 45612 RVA: 0x004040B8 File Offset: 0x004022B8
	public override bool cu(cnm A_0)
	{
		return A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() == btz.a && euf.d(A_0.b8().Offense.u().TypedDefinition).GetValueOrDefault() != WeaponSubtype.Pistol_Electro && euf.d(A_0.b8().Offense.u().TypedDefinition).GetValueOrDefault() != WeaponSubtype.Pistol_Sonic;
	}

	// Token: 0x0600B22D RID: 45613 RVA: 0x00404178 File Offset: 0x00402378
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B22E RID: 45614 RVA: 0x0040417C File Offset: 0x0040237C
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAttacks/Execute", new object[]
		{
			(int)(b13.a(A_0) * 100.0)
		});
	}

	// Token: 0x0600B22F RID: 45615 RVA: 0x004041A8 File Offset: 0x004023A8
	public new static double a(cnm A_0)
	{
		double num = akv.a;
		if (A_0 != null && A_0.b8() != null)
		{
			num += (double)A_0.b8().GetSpecializationValue<ao7>(true) * ao7.a;
		}
		return num;
	}

	// Token: 0x0600B230 RID: 45616 RVA: 0x004041E4 File Offset: 0x004023E4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		list.Add(new cfd("SAt.Execute", (akv.b - c3n.GetSpecSafe<bqw>(A_0) * bqw.a) * d0u.b, false, false));
		return list;
	}

	// Token: 0x0600B231 RID: 45617 RVA: 0x00404240 File Offset: 0x00402440
	public override IList<string> bi()
	{
		return this.b;
	}

	// Token: 0x0600B232 RID: 45618 RVA: 0x00404248 File Offset: 0x00402448
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0600B233 RID: 45619 RVA: 0x00404250 File Offset: 0x00402450
	protected override int hi(cnm A_0)
	{
		return base.hi(A_0) + 5;
	}

	// Token: 0x0600B234 RID: 45620 RVA: 0x0040425C File Offset: 0x0040245C
	protected override float f0(cnm A_0)
	{
		return 2f;
	}

	// Token: 0x04004148 RID: 16712
	private new const string a = "SAt.Execute";

	// Token: 0x04004149 RID: 16713
	private List<string> b;
}
