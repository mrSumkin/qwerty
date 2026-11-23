using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001EA2 RID: 7842
[ayj("Impale")]
public sealed class e21 : bon
{
	// Token: 0x0600B00E RID: 45070 RVA: 0x003FF590 File Offset: 0x003FD790
	public override string y8()
	{
		return "Пронзение";
	}

	// Token: 0x0600B00F RID: 45071 RVA: 0x003FF598 File Offset: 0x003FD798
	public override string os()
	{
		return "Impale";
	}

	// Token: 0x0600B010 RID: 45072 RVA: 0x003FF5A0 File Offset: 0x003FD7A0
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B011 RID: 45073 RVA: 0x003FF5A4 File Offset: 0x003FD7A4
	public override bool cs()
	{
		return true;
	}

	// Token: 0x0600B012 RID: 45074 RVA: 0x003FF5A8 File Offset: 0x003FD7A8
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B013 RID: 45075 RVA: 0x003FF5AC File Offset: 0x003FD7AC
	public e21()
	{
		this.c = new List<string>();
		this.c.Add(d7f.a);
		this.c.Add("SAt.Impale");
	}

	// Token: 0x0600B014 RID: 45076 RVA: 0x003FF5E0 File Offset: 0x003FD7E0
	public override string bm(cnm A_0)
	{
		return "xpbl_Abilities.12";
	}

	// Token: 0x0600B015 RID: 45077 RVA: 0x003FF5EC File Offset: 0x003FD7EC
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() == btz.g && euf.d(A_0.b8().Offense.u().TypedDefinition).GetValueOrDefault() == WeaponSubtype.Spear;
	}

	// Token: 0x0600B016 RID: 45078 RVA: 0x003FF690 File Offset: 0x003FD890
	public override bool cu(cnm A_0)
	{
		return base.cu(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() == btz.g && euf.d(A_0.b8().Offense.u().TypedDefinition).GetValueOrDefault() == WeaponSubtype.Spear;
	}

	// Token: 0x0600B017 RID: 45079 RVA: 0x003FF734 File Offset: 0x003FD934
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B018 RID: 45080 RVA: 0x003FF738 File Offset: 0x003FD938
	public override string bo(cnm A_0)
	{
		return qv.b("SpecialAttacks/Impale");
	}

	// Token: 0x0600B019 RID: 45081 RVA: 0x003FF744 File Offset: 0x003FD944
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		list.Add(new cfd("SAt.Impale", e21.b * d0u.b, false, false));
		return list;
	}

	// Token: 0x0600B01A RID: 45082 RVA: 0x003FF794 File Offset: 0x003FD994
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600B01B RID: 45083 RVA: 0x003FF79C File Offset: 0x003FD99C
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0600B01C RID: 45084 RVA: 0x003FF7A4 File Offset: 0x003FD9A4
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x040040CF RID: 16591
	private new const string a = "SAt.Impale";

	// Token: 0x040040D0 RID: 16592
	public static readonly int b = 3;

	// Token: 0x040040D1 RID: 16593
	private List<string> c;
}
