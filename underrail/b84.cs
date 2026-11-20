using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001EE9 RID: 7913
[ayj("Fend")]
public sealed class b84 : c0z
{
	// Token: 0x0600B45D RID: 46173 RVA: 0x004083BC File Offset: 0x004065BC
	public override string y8()
	{
		return "Отражение";
	}

	// Token: 0x0600B45E RID: 46174 RVA: 0x004083C4 File Offset: 0x004065C4
	public override string os()
	{
		return "Fend";
	}

	// Token: 0x0600B45F RID: 46175 RVA: 0x004083CC File Offset: 0x004065CC
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B460 RID: 46176 RVA: 0x004083D0 File Offset: 0x004065D0
	public override int e8()
	{
		return 2;
	}

	// Token: 0x0600B461 RID: 46177 RVA: 0x004083D4 File Offset: 0x004065D4
	public override bool hl()
	{
		return true;
	}

	// Token: 0x0600B462 RID: 46178 RVA: 0x004083D8 File Offset: 0x004065D8
	public b84()
	{
		this.e = new List<string>();
		this.e.Add("SA.Fend");
	}

	// Token: 0x0600B463 RID: 46179 RVA: 0x004083FC File Offset: 0x004065FC
	public override string bm(cnm A_0)
	{
		return "xpbl_Abilities.11";
	}

	// Token: 0x0600B464 RID: 46180 RVA: 0x00408404 File Offset: 0x00406604
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600B465 RID: 46181 RVA: 0x00408408 File Offset: 0x00406608
	public override string bo(cnm A_0)
	{
		int num = 0;
		if (A_0 != null && A_0.b8() != null)
		{
			num = euf.a(A_0.b8(), 1.0 + b84.a(A_0));
		}
		return qv.a("SpecialAbilities/Fend", new object[]
		{
			(int)(b84.a(A_0) * 100.0),
			num
		});
	}

	// Token: 0x0600B466 RID: 46182 RVA: 0x00408478 File Offset: 0x00406678
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("SA.Fend", b84.b * d0u.b, false, false)
		};
	}

	// Token: 0x0600B467 RID: 46183 RVA: 0x0040849C File Offset: 0x0040669C
	public override IList<string> bi()
	{
		return this.e;
	}

	// Token: 0x0600B468 RID: 46184 RVA: 0x004084A4 File Offset: 0x004066A4
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600B469 RID: 46185 RVA: 0x004084AC File Offset: 0x004066AC
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null) && euf.d(A_0.b8().Offense.u().TypedDefinition).GetValueOrDefault() == WeaponSubtype.Spear;
	}

	// Token: 0x0600B46A RID: 46186 RVA: 0x00408504 File Offset: 0x00406704
	public new static double a(cnm A_0)
	{
		double num = b84.c;
		if (A_0 != null && A_0.b8() != null)
		{
			num += (double)A_0.b8().GetSpecializationValue<i9>(true) * i9.a;
		}
		return num;
	}

	// Token: 0x0600B46B RID: 46187 RVA: 0x00408540 File Offset: 0x00406740
	protected override int hi(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			double num = b84.d - (double)A_0.b8().GetSpecializationValue<ebb>(true) * ebb.a;
			return (int)((double)A_0.b8().Offense.av() * num);
		}
		return 0;
	}

	// Token: 0x040041D0 RID: 16848
	private new const string a = "SA.Fend";

	// Token: 0x040041D1 RID: 16849
	public static readonly int b = 2;

	// Token: 0x040041D2 RID: 16850
	public static readonly double c = 1.5;

	// Token: 0x040041D3 RID: 16851
	public static readonly double d = 0.6;

	// Token: 0x040041D4 RID: 16852
	private new List<string> e;
}
