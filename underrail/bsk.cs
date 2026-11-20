using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001EC7 RID: 7879
[ayj("CutThroat")]
public sealed class bsk : bon
{
	// Token: 0x0600B211 RID: 45585 RVA: 0x00403D48 File Offset: 0x00401F48
	public override string y8()
	{
		return "Перерезать глотку";
	}

	// Token: 0x0600B212 RID: 45586 RVA: 0x00403D50 File Offset: 0x00401F50
	public override string os()
	{
		return "CutThroat";
	}

	// Token: 0x0600B213 RID: 45587 RVA: 0x00403D58 File Offset: 0x00401F58
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B214 RID: 45588 RVA: 0x00403D5C File Offset: 0x00401F5C
	public override bool cs()
	{
		return true;
	}

	// Token: 0x0600B215 RID: 45589 RVA: 0x00403D60 File Offset: 0x00401F60
	public override int ct()
	{
		return 3;
	}

	// Token: 0x0600B216 RID: 45590 RVA: 0x00403D64 File Offset: 0x00401F64
	public bsk()
	{
		this.c = new List<string>();
		this.c.Add(d7f.a);
		this.c.Add("SAt.CutThroat");
	}

	// Token: 0x0600B217 RID: 45591 RVA: 0x00403D98 File Offset: 0x00401F98
	public override string bm(cnm A_0)
	{
		return "SpecialAttack.CutThroat";
	}

	// Token: 0x0600B218 RID: 45592 RVA: 0x00403DA4 File Offset: 0x00401FA4
	public override bool hm(cnm A_0)
	{
		if (base.hm(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() == btz.g)
		{
			WeaponSubtype? weaponSubtype = euf.d(A_0.b8().Offense.u().TypedDefinition);
			return weaponSubtype != null && weaponSubtype.Value / (WeaponSubtype)100 == WeaponSubtype.Pistol_762;
		}
		return false;
	}

	// Token: 0x0600B219 RID: 45593 RVA: 0x00403E58 File Offset: 0x00402058
	public override bool cu(cnm A_0)
	{
		return this.hm(A_0);
	}

	// Token: 0x0600B21A RID: 45594 RVA: 0x00403E64 File Offset: 0x00402064
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.HumanoidNotSelf;
	}

	// Token: 0x0600B21B RID: 45595 RVA: 0x00403E68 File Offset: 0x00402068
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAttacks/CutThroat", new object[]
		{
			(int)Math.Round(bsk.a(A_0) * 100.0, 2),
			l4.a(exo.b, false)
		});
	}

	// Token: 0x0600B21C RID: 45596 RVA: 0x00403EAC File Offset: 0x004020AC
	public new static double a(cnm A_0)
	{
		double num = exo.a;
		if (A_0 != null && A_0.b8() != null)
		{
			num += (double)A_0.b8().GetSpecializationValue<cmj>(true) * cmj.a;
		}
		return num;
	}

	// Token: 0x0600B21D RID: 45597 RVA: 0x00403EE8 File Offset: 0x004020E8
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		int num = exo.c;
		if (A_0 != null && A_0.b8() != null)
		{
			num -= A_0.b8().GetSpecializationValue<bvf>(true) * bvf.a * d0u.b;
		}
		list.Add(new cfd("SAt.CutThroat", num, false, false));
		return list;
	}

	// Token: 0x0600B21E RID: 45598 RVA: 0x00403F60 File Offset: 0x00402160
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600B21F RID: 45599 RVA: 0x00403F68 File Offset: 0x00402168
	public override dsk cv(cnm A_0)
	{
		return dsk.d;
	}

	// Token: 0x0600B220 RID: 45600 RVA: 0x00403F6C File Offset: 0x0040216C
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0600B221 RID: 45601 RVA: 0x00403F74 File Offset: 0x00402174
	protected override int hi(cnm A_0)
	{
		return bsk.b;
	}

	// Token: 0x0600B222 RID: 45602 RVA: 0x00403F7C File Offset: 0x0040217C
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x04004145 RID: 16709
	private new const string a = "SAt.CutThroat";

	// Token: 0x04004146 RID: 16710
	public static readonly int b = 15;

	// Token: 0x04004147 RID: 16711
	private List<string> c;
}
