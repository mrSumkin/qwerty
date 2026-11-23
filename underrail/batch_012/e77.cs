using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001ECE RID: 7886
[ayj("AimedShot")]
public sealed class e77 : bon
{
	// Token: 0x0600B27D RID: 45693 RVA: 0x00404D20 File Offset: 0x00402F20
	public override string y8()
	{
		return "Прицельный выстрел";
	}

	// Token: 0x0600B27E RID: 45694 RVA: 0x00404D28 File Offset: 0x00402F28
	public override string os()
	{
		return "AimedShot";
	}

	// Token: 0x0600B27F RID: 45695 RVA: 0x00404D30 File Offset: 0x00402F30
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B280 RID: 45696 RVA: 0x00404D34 File Offset: 0x00402F34
	public override bool cs()
	{
		return false;
	}

	// Token: 0x0600B281 RID: 45697 RVA: 0x00404D38 File Offset: 0x00402F38
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B282 RID: 45698 RVA: 0x00404D3C File Offset: 0x00402F3C
	public override bool j7()
	{
		return true;
	}

	// Token: 0x0600B283 RID: 45699 RVA: 0x00404D40 File Offset: 0x00402F40
	public e77()
	{
		this.c = new List<string>();
		this.c.Add(d7f.a);
		this.c.Add(e77.a);
	}

	// Token: 0x0600B284 RID: 45700 RVA: 0x00404D74 File Offset: 0x00402F74
	public override string bm(cnm A_0)
	{
		return "AimedShot";
	}

	// Token: 0x0600B285 RID: 45701 RVA: 0x00404D80 File Offset: 0x00402F80
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() != btz.g && euf.d(A_0.b8().Offense.u().TypedDefinition).GetValueOrDefault() != WeaponSubtype.Pistol_Sonic && !euf.k(A_0.b8().Offense.u()) && !euf.i(A_0.b8().Offense.u()) && A_0.b8().Offense.u().TypedDefinition.e() != btz.j && A_0.b8().Offense.u().TypedDefinition.e() != btz.k && A_0.b8().Offense.u().TypedDefinition.e() != btz.i && A_0.b8().Offense.u().TypedDefinition.e() != btz.l;
	}

	// Token: 0x0600B286 RID: 45702 RVA: 0x00404EDC File Offset: 0x004030DC
	public override bool cu(cnm A_0)
	{
		return A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() != btz.g && euf.d(A_0.b8().Offense.u().TypedDefinition).GetValueOrDefault() != WeaponSubtype.Pistol_Sonic && !euf.k(A_0.b8().Offense.u()) && !euf.i(A_0.b8().Offense.u()) && A_0.b8().Offense.u().TypedDefinition.e() != btz.j && A_0.b8().Offense.u().TypedDefinition.e() != btz.k && A_0.b8().Offense.u().TypedDefinition.e() != btz.i && A_0.b8().Offense.u().TypedDefinition.e() != btz.l;
	}

	// Token: 0x0600B287 RID: 45703 RVA: 0x0040502C File Offset: 0x0040322C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B288 RID: 45704 RVA: 0x00405030 File Offset: 0x00403230
	public override string bo(cnm A_0)
	{
		return qv.b("SpecialAttacks/AimedShot");
	}

	// Token: 0x0600B289 RID: 45705 RVA: 0x00405040 File Offset: 0x00403240
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		list.Add(new cfd(e77.a, e77.b, false, false));
		return list;
	}

	// Token: 0x0600B28A RID: 45706 RVA: 0x0040508C File Offset: 0x0040328C
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600B28B RID: 45707 RVA: 0x00405094 File Offset: 0x00403294
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0400415A RID: 16730
	public new static readonly string a = "SAt.AimedShot";

	// Token: 0x0400415B RID: 16731
	public static readonly int b = 15000;

	// Token: 0x0400415C RID: 16732
	private List<string> c;
}
