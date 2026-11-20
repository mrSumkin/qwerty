using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EDD RID: 7901
[ayj("TowJetSki")]
public sealed class apx : elr
{
	// Token: 0x0600B377 RID: 45943 RVA: 0x00406918 File Offset: 0x00404B18
	public override string y8()
	{
		return "Буксир";
	}

	// Token: 0x0600B378 RID: 45944 RVA: 0x00406920 File Offset: 0x00404B20
	public override string os()
	{
		return "TowJetSki";
	}

	// Token: 0x0600B379 RID: 45945 RVA: 0x00406928 File Offset: 0x00404B28
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600B37A RID: 45946 RVA: 0x0040692C File Offset: 0x00404B2C
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600B37B RID: 45947 RVA: 0x00406930 File Offset: 0x00404B30
	public override bool hl()
	{
		return true;
	}

	// Token: 0x0600B37C RID: 45948 RVA: 0x00406934 File Offset: 0x00404B34
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeSpell);
	}

	// Token: 0x0600B37D RID: 45949 RVA: 0x0040693C File Offset: 0x00404B3C
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x0600B37E RID: 45950 RVA: 0x00406944 File Offset: 0x00404B44
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600B37F RID: 45951 RVA: 0x00406948 File Offset: 0x00404B48
	public apx()
	{
		this.a = new List<string>();
	}

	// Token: 0x0600B380 RID: 45952 RVA: 0x0040695C File Offset: 0x00404B5C
	public override string bm(cnm A_0)
	{
		return "xpbl_Abilities.6";
	}

	// Token: 0x0600B381 RID: 45953 RVA: 0x00406964 File Offset: 0x00404B64
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.TowableNavalObject;
	}

	// Token: 0x0600B382 RID: 45954 RVA: 0x0040696C File Offset: 0x00404B6C
	public override string bo(cnm A_0)
	{
		return qv.b("SpecialAbilities/TowJetSki");
	}

	// Token: 0x0600B383 RID: 45955 RVA: 0x00406978 File Offset: 0x00404B78
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600B384 RID: 45956 RVA: 0x00406984 File Offset: 0x00404B84
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null && !A_0.b8().IsInCombat && A_0.b8().Vehicle != null);
	}

	// Token: 0x0600B385 RID: 45957 RVA: 0x004069D4 File Offset: 0x00404BD4
	protected override int br(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0600B386 RID: 45958 RVA: 0x004069D8 File Offset: 0x00404BD8
	protected override float f0(cnm A_0)
	{
		return 2f;
	}

	// Token: 0x0400419A RID: 16794
	private new List<string> a;
}
