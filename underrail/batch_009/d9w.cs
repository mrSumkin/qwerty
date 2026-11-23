using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001ECC RID: 7884
[ayj("kcs")]
public sealed class d9w : bon
{
	// Token: 0x0600B259 RID: 45657 RVA: 0x00404650 File Offset: 0x00402850
	public override string y8()
	{
		return "Выстрел в колено";
	}

	// Token: 0x0600B25A RID: 45658 RVA: 0x00404658 File Offset: 0x00402858
	public override string os()
	{
		return "sa.kcs";
	}

	// Token: 0x0600B25B RID: 45659 RVA: 0x00404660 File Offset: 0x00402860
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B25C RID: 45660 RVA: 0x00404664 File Offset: 0x00402864
	public override bool cs()
	{
		return false;
	}

	// Token: 0x0600B25D RID: 45661 RVA: 0x00404668 File Offset: 0x00402868
	public override int ct()
	{
		return 2;
	}

	// Token: 0x0600B25E RID: 45662 RVA: 0x0040466C File Offset: 0x0040286C
	public override bool j7()
	{
		return true;
	}

	// Token: 0x0600B25F RID: 45663 RVA: 0x00404670 File Offset: 0x00402870
	public d9w()
	{
		this.c = new List<string>();
		this.c.Add(d7f.a);
		this.c.Add("SAt.KCS");
	}

	// Token: 0x0600B260 RID: 45664 RVA: 0x004046A4 File Offset: 0x004028A4
	public override string bm(cnm A_0)
	{
		return "sa.kcs";
	}

	// Token: 0x0600B261 RID: 45665 RVA: 0x004046AC File Offset: 0x004028AC
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && (A_0.b8().Offense.u().TypedDefinition.e() == btz.a || A_0.b8().Offense.u().TypedDefinition.e() == btz.f || A_0.b8().Offense.u().TypedDefinition.e() == btz.b || euf.k(A_0.b8().Offense.u())) && euf.d(A_0.b8().Offense.u().TypedDefinition).GetValueOrDefault() != WeaponSubtype.Pistol_Sonic;
	}

	// Token: 0x0600B262 RID: 45666 RVA: 0x004047AC File Offset: 0x004029AC
	public override bool cu(cnm A_0)
	{
		return A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && (A_0.b8().Offense.u().TypedDefinition.e() == btz.a || A_0.b8().Offense.u().TypedDefinition.e() == btz.f || A_0.b8().Offense.u().TypedDefinition.e() == btz.b || euf.k(A_0.b8().Offense.u())) && euf.d(A_0.b8().Offense.u().TypedDefinition).GetValueOrDefault() != WeaponSubtype.Pistol_Sonic;
	}

	// Token: 0x0600B263 RID: 45667 RVA: 0x004048A0 File Offset: 0x00402AA0
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B264 RID: 45668 RVA: 0x004048A8 File Offset: 0x00402AA8
	public override string bo(cnm A_0)
	{
		string a_;
		if (dk2.f())
		{
			a_ = "SpecialAttacks/KCS-XPBL";
		}
		else
		{
			a_ = "SpecialAttacks/KCS";
		}
		return qv.a(a_, new object[]
		{
			(int)(d9w.a(A_0) * 100f),
			l4.a((double)edd.b, false)
		});
	}

	// Token: 0x0600B265 RID: 45669 RVA: 0x00404900 File Offset: 0x00402B00
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		int num = edd.c;
		if (A_0 != null && A_0.b8() != null)
		{
			num -= (int)((double)A_0.b8().GetSpecializationValue<dig>(true) * dig.a * (double)d0u.b);
		}
		list.Add(new cfd("SAt.KCS", num, false, false));
		return list;
	}

	// Token: 0x0600B266 RID: 45670 RVA: 0x0040497C File Offset: 0x00402B7C
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600B267 RID: 45671 RVA: 0x00404984 File Offset: 0x00402B84
	public new static float a(cnm A_0)
	{
		return (float)(edd.d + (double)A_0.b8().GetSpecializationValue<byp>(true) * byp.a);
	}

	// Token: 0x0600B268 RID: 45672 RVA: 0x004049A0 File Offset: 0x00402BA0
	public static double a(efk A_0, int A_1)
	{
		return qw.a((double)A_1, (double)A_0.Defense.ab());
	}

	// Token: 0x0600B269 RID: 45673 RVA: 0x004049B8 File Offset: 0x00402BB8
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0600B26A RID: 45674 RVA: 0x004049C4 File Offset: 0x00402BC4
	protected override float f0(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null)
		{
			return Math.Min(d9w.b, A_0.b8().Offense.u().TypedDefinition.ad());
		}
		return 0f;
	}

	// Token: 0x04004152 RID: 16722
	private new const string a = "SAt.KCS";

	// Token: 0x04004153 RID: 16723
	public static readonly float b = 7f;

	// Token: 0x04004154 RID: 16724
	private List<string> c;
}
