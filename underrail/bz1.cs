using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x0200181A RID: 6170
[ayj("StunningPulse")]
public sealed class bz1 : bon
{
	// Token: 0x0600834D RID: 33613 RVA: 0x0036E21C File Offset: 0x0036C41C
	public override string y8()
	{
		return "Оглушающий импульс";
	}

	// Token: 0x0600834E RID: 33614 RVA: 0x0036E224 File Offset: 0x0036C424
	public override string os()
	{
		return "StunningPulse";
	}

	// Token: 0x0600834F RID: 33615 RVA: 0x0036E22C File Offset: 0x0036C42C
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x06008350 RID: 33616 RVA: 0x0036E230 File Offset: 0x0036C430
	public override bool cs()
	{
		return false;
	}

	// Token: 0x06008351 RID: 33617 RVA: 0x0036E234 File Offset: 0x0036C434
	public override int ct()
	{
		return 2;
	}

	// Token: 0x06008352 RID: 33618 RVA: 0x0036E238 File Offset: 0x0036C438
	public override bool j7()
	{
		return false;
	}

	// Token: 0x06008353 RID: 33619 RVA: 0x0036E23C File Offset: 0x0036C43C
	public override bool bk()
	{
		return true;
	}

	// Token: 0x06008354 RID: 33620 RVA: 0x0036E240 File Offset: 0x0036C440
	public override bool i2()
	{
		return true;
	}

	// Token: 0x06008355 RID: 33621 RVA: 0x0036E244 File Offset: 0x0036C444
	public bz1()
	{
		this.e = new List<string>();
		this.e.Add(d7f.a);
		this.e.Add("SAt.StunningPulse");
	}

	// Token: 0x06008356 RID: 33622 RVA: 0x0036E278 File Offset: 0x0036C478
	public override string bm(cnm A_0)
	{
		return "Attacks.27";
	}

	// Token: 0x06008357 RID: 33623 RVA: 0x0036E280 File Offset: 0x0036C480
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x06008358 RID: 33624 RVA: 0x0036E284 File Offset: 0x0036C484
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAttacks/StunningPulse", new object[]
		{
			bz1.d,
			Convert.ToInt32(bz1.c * 100.0)
		});
	}

	// Token: 0x06008359 RID: 33625 RVA: 0x0036E2C0 File Offset: 0x0036C4C0
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600835A RID: 33626 RVA: 0x0036E2CC File Offset: 0x0036C4CC
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		list.Add(new cfd("SAt.StunningPulse", bz1.b, false, false));
		return list;
	}

	// Token: 0x0600835B RID: 33627 RVA: 0x0036E318 File Offset: 0x0036C518
	public override IList<string> bi()
	{
		return this.e;
	}

	// Token: 0x0600835C RID: 33628 RVA: 0x0036E320 File Offset: 0x0036C520
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0600835D RID: 33629 RVA: 0x0036E328 File Offset: 0x0036C528
	public override bool hm(cnm A_0)
	{
		return (A_0 == null || A_0.b8() == null || A_0.b8().Offense.u().Battery >= (double)bz1.d) && base.hm(A_0);
	}

	// Token: 0x0400327D RID: 12925
	private new const string a = "SAt.StunningPulse";

	// Token: 0x0400327E RID: 12926
	public static readonly int b = 3 * d0u.b;

	// Token: 0x0400327F RID: 12927
	public static readonly double c = 0.5;

	// Token: 0x04003280 RID: 12928
	public static readonly int d = 20;

	// Token: 0x04003281 RID: 12929
	private new List<string> e;
}
