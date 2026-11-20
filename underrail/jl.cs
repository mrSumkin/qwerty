using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EDC RID: 7900
[ayj("StopTowingJetSki")]
public sealed class jl : elr
{
	// Token: 0x0600B369 RID: 45929 RVA: 0x00406880 File Offset: 0x00404A80
	public override string y8()
	{
		return "Остановить буксировку";
	}

	// Token: 0x0600B36A RID: 45930 RVA: 0x00406888 File Offset: 0x00404A88
	public override string os()
	{
		return "StopTowingJetSki";
	}

	// Token: 0x0600B36B RID: 45931 RVA: 0x00406890 File Offset: 0x00404A90
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600B36C RID: 45932 RVA: 0x00406894 File Offset: 0x00404A94
	public override int e8()
	{
		return 2;
	}

	// Token: 0x0600B36D RID: 45933 RVA: 0x00406898 File Offset: 0x00404A98
	public override bool hl()
	{
		return true;
	}

	// Token: 0x0600B36E RID: 45934 RVA: 0x0040689C File Offset: 0x00404A9C
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeSpell);
	}

	// Token: 0x0600B36F RID: 45935 RVA: 0x004068A4 File Offset: 0x00404AA4
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x0600B370 RID: 45936 RVA: 0x004068AC File Offset: 0x00404AAC
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600B371 RID: 45937 RVA: 0x004068B0 File Offset: 0x00404AB0
	public jl()
	{
		this.a = new List<string>();
	}

	// Token: 0x0600B372 RID: 45938 RVA: 0x004068C4 File Offset: 0x00404AC4
	public override string bm(cnm A_0)
	{
		return "xpbl_Abilities.7";
	}

	// Token: 0x0600B373 RID: 45939 RVA: 0x004068CC File Offset: 0x00404ACC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600B374 RID: 45940 RVA: 0x004068D0 File Offset: 0x00404AD0
	public override string bo(cnm A_0)
	{
		return qv.b("SpecialAbilities/StopTowingJetSki");
	}

	// Token: 0x0600B375 RID: 45941 RVA: 0x004068DC File Offset: 0x00404ADC
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600B376 RID: 45942 RVA: 0x004068E4 File Offset: 0x00404AE4
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null && A_0.b8().Vehicle != null);
	}

	// Token: 0x04004199 RID: 16793
	private new List<string> a;
}
