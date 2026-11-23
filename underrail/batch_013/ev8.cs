using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001ED4 RID: 7892
[ayj("ChangeTrigger")]
public sealed class ev8 : c0z
{
	// Token: 0x0600B2F5 RID: 45813 RVA: 0x00405E7C File Offset: 0x0040407C
	public override string y8()
	{
		return "Change Trigger";
	}

	// Token: 0x0600B2F6 RID: 45814 RVA: 0x00405E84 File Offset: 0x00404084
	public override string os()
	{
		return "ChangeTrigger";
	}

	// Token: 0x0600B2F7 RID: 45815 RVA: 0x00405E8C File Offset: 0x0040408C
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600B2F8 RID: 45816 RVA: 0x00405E90 File Offset: 0x00404090
	public override int e8()
	{
		return 2;
	}

	// Token: 0x0600B2F9 RID: 45817 RVA: 0x00405E94 File Offset: 0x00404094
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x0600B2FA RID: 45818 RVA: 0x00405E9C File Offset: 0x0040409C
	public ev8()
	{
		this.a = new List<string>();
	}

	// Token: 0x0600B2FB RID: 45819 RVA: 0x00405EB0 File Offset: 0x004040B0
	public override string bm(cnm A_0)
	{
		return "xpbl_Abilities.17";
	}

	// Token: 0x0600B2FC RID: 45820 RVA: 0x00405EB8 File Offset: 0x004040B8
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600B2FD RID: 45821 RVA: 0x00405EBC File Offset: 0x004040BC
	public override string bo(cnm A_0)
	{
		return qv.b("SpecialAbilities/ChangeTrigger");
	}

	// Token: 0x0600B2FE RID: 45822 RVA: 0x00405EC8 File Offset: 0x004040C8
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600B2FF RID: 45823 RVA: 0x00405ED4 File Offset: 0x004040D4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600B300 RID: 45824 RVA: 0x00405EE0 File Offset: 0x004040E0
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (base.hm(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && euf.k(A_0.b8().Offense.u()) && A_0.b8().Offense.u().LoadedAmmo.Count == 2) && A_0.b8().Offense.u().TypedDefinition.e("ChangeTrigger");
	}

	// Token: 0x0600B301 RID: 45825 RVA: 0x00405FA4 File Offset: 0x004041A4
	protected override int br(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0600B302 RID: 45826 RVA: 0x00405FA8 File Offset: 0x004041A8
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0400417E RID: 16766
	private new List<string> a;
}
