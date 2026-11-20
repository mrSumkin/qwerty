using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001EA0 RID: 7840
[ayj("Decapitate")]
public sealed class bwh : bon
{
	// Token: 0x0600AFE9 RID: 45033 RVA: 0x003FEE6C File Offset: 0x003FD06C
	public override string y8()
	{
		return "Обезглавливание";
	}

	// Token: 0x0600AFEA RID: 45034 RVA: 0x003FEE74 File Offset: 0x003FD074
	public override string os()
	{
		return "Decapitate";
	}

	// Token: 0x0600AFEB RID: 45035 RVA: 0x003FEE7C File Offset: 0x003FD07C
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600AFEC RID: 45036 RVA: 0x003FEE80 File Offset: 0x003FD080
	public override bool cs()
	{
		return true;
	}

	// Token: 0x0600AFED RID: 45037 RVA: 0x003FEE84 File Offset: 0x003FD084
	public override int ct()
	{
		return 5;
	}

	// Token: 0x0600AFEE RID: 45038 RVA: 0x003FEE88 File Offset: 0x003FD088
	public bwh()
	{
		this.e = new List<string>();
		this.e.Add(d7f.a);
		this.e.Add("SAt.Decapitate");
	}

	// Token: 0x0600AFEF RID: 45039 RVA: 0x003FEEBC File Offset: 0x003FD0BC
	public override string bm(cnm A_0)
	{
		return "xpbl_Abilities.15";
	}

	// Token: 0x0600AFF0 RID: 45040 RVA: 0x003FEEC4 File Offset: 0x003FD0C4
	public override bool hm(cnm A_0)
	{
		if (base.hm(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() == btz.g)
		{
			WeaponSubtype? weaponSubtype = euf.d(A_0.b8().Offense.u().TypedDefinition);
			return weaponSubtype != null && weaponSubtype.Value / (WeaponSubtype)100 == WeaponSubtype.Pistol_Laser;
		}
		return false;
	}

	// Token: 0x0600AFF1 RID: 45041 RVA: 0x003FEF78 File Offset: 0x003FD178
	public override bool cu(cnm A_0)
	{
		if (base.cu(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() == btz.g)
		{
			WeaponSubtype? weaponSubtype = euf.d(A_0.b8().Offense.u().TypedDefinition);
			return weaponSubtype != null && weaponSubtype.Value / (WeaponSubtype)100 == WeaponSubtype.Pistol_Laser;
		}
		return false;
	}

	// Token: 0x0600AFF2 RID: 45042 RVA: 0x003FF02C File Offset: 0x003FD22C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600AFF3 RID: 45043 RVA: 0x003FF034 File Offset: 0x003FD234
	public override string bo(cnm A_0)
	{
		string text = qv.a("SpecialAttacks/Decapitate", new object[]
		{
			(int)(bwh.b(A_0) * 100.0),
			(int)(bwh.a(A_0) * 100.0)
		});
		if (A_0 != null && A_0.b8() != null)
		{
			apj microfeat = A_0.b8().GetMicrofeat<apj>();
			if (microfeat != null && microfeat.a() != 0.0)
			{
				text += "\r\n\r\n";
				if (microfeat.a() < 0.0)
				{
					text += qv.a("SpecialAttacks/DecapitateCritModDecreased", new object[]
					{
						microfeat.a()
					});
				}
				else
				{
					text += qv.a("SpecialAttacks/DecapitateCritModIncreased", new object[]
					{
						microfeat.a()
					});
				}
			}
		}
		return text;
	}

	// Token: 0x0600AFF4 RID: 45044 RVA: 0x003FF12C File Offset: 0x003FD32C
	public static double b(cnm A_0)
	{
		double num = bwh.d;
		if (A_0 != null && A_0.b8() != null)
		{
			num += (double)A_0.b8().GetSpecializationValue<b5d>(true) * b5d.a;
		}
		return num;
	}

	// Token: 0x0600AFF5 RID: 45045 RVA: 0x003FF168 File Offset: 0x003FD368
	public new static double a(cnm A_0)
	{
		double num = bwh.c;
		if (A_0 != null && A_0.b8() != null)
		{
			num -= (double)A_0.b8().GetSpecializationValue<aqp>(true) * aqp.a;
		}
		return num;
	}

	// Token: 0x0600AFF6 RID: 45046 RVA: 0x003FF1A4 File Offset: 0x003FD3A4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		list.Add(new cfd("SAt.Decapitate", bwh.b * d0u.b, false, false));
		return list;
	}

	// Token: 0x0600AFF7 RID: 45047 RVA: 0x003FF1F4 File Offset: 0x003FD3F4
	public override IList<string> bi()
	{
		return this.e;
	}

	// Token: 0x0600AFF8 RID: 45048 RVA: 0x003FF1FC File Offset: 0x003FD3FC
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0600AFF9 RID: 45049 RVA: 0x003FF204 File Offset: 0x003FD404
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x040040C1 RID: 16577
	private new const string a = "SAt.Decapitate";

	// Token: 0x040040C2 RID: 16578
	public static readonly int b = 5;

	// Token: 0x040040C3 RID: 16579
	public static readonly double c = 0.5;

	// Token: 0x040040C4 RID: 16580
	public static readonly double d = 1.5;

	// Token: 0x040040C5 RID: 16581
	private new List<string> e;
}
