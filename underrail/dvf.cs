using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001E97 RID: 7831
[ayj("Sap")]
public sealed class dvf : bon
{
	// Token: 0x0600AF51 RID: 44881 RVA: 0x003FDA30 File Offset: 0x003FBC30
	public override string y8()
	{
		return "Ломом по башке";
	}

	// Token: 0x0600AF52 RID: 44882 RVA: 0x003FDA38 File Offset: 0x003FBC38
	public override string os()
	{
		return "Sap";
	}

	// Token: 0x0600AF53 RID: 44883 RVA: 0x003FDA40 File Offset: 0x003FBC40
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600AF54 RID: 44884 RVA: 0x003FDA44 File Offset: 0x003FBC44
	public override bool cs()
	{
		return true;
	}

	// Token: 0x0600AF55 RID: 44885 RVA: 0x003FDA48 File Offset: 0x003FBC48
	public override int ct()
	{
		return 4;
	}

	// Token: 0x0600AF56 RID: 44886 RVA: 0x003FDA4C File Offset: 0x003FBC4C
	public dvf()
	{
		this.b = new List<string>();
		this.b.Add(d7f.a);
		this.b.Add("SAt.Sap");
	}

	// Token: 0x0600AF57 RID: 44887 RVA: 0x003FDA80 File Offset: 0x003FBC80
	public override string bm(cnm A_0)
	{
		return "Attacks.29";
	}

	// Token: 0x0600AF58 RID: 44888 RVA: 0x003FDA8C File Offset: 0x003FBC8C
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.ae().GetValueOrDefault() == WeaponSubtype.Crowbar;
	}

	// Token: 0x0600AF59 RID: 44889 RVA: 0x003FDB14 File Offset: 0x003FBD14
	public override bool cu(cnm A_0)
	{
		return this.hm(A_0);
	}

	// Token: 0x0600AF5A RID: 44890 RVA: 0x003FDB20 File Offset: 0x003FBD20
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.HumanoidNotSelf;
	}

	// Token: 0x0600AF5B RID: 44891 RVA: 0x003FDB28 File Offset: 0x003FBD28
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAttacks/Sap", new object[]
		{
			l4.a(e0f.b((A_0 != null) ? A_0.b8() : null), false)
		});
	}

	// Token: 0x0600AF5C RID: 44892 RVA: 0x003FDB68 File Offset: 0x003FBD68
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		int a_ = e0f.a((A_0 != null) ? A_0.b8() : null);
		list.Add(new cfd("SAt.Sap", a_, false, false));
		return list;
	}

	// Token: 0x0600AF5D RID: 44893 RVA: 0x003FDBC8 File Offset: 0x003FBDC8
	public override IList<string> bi()
	{
		return this.b;
	}

	// Token: 0x0600AF5E RID: 44894 RVA: 0x003FDBD0 File Offset: 0x003FBDD0
	public override dsk cv(cnm A_0)
	{
		return dsk.d;
	}

	// Token: 0x0600AF5F RID: 44895 RVA: 0x003FDBD4 File Offset: 0x003FBDD4
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0600AF60 RID: 44896 RVA: 0x003FDBDC File Offset: 0x003FBDDC
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x040040A3 RID: 16547
	private new const string a = "SAt.Sap";

	// Token: 0x040040A4 RID: 16548
	private List<string> b;
}
