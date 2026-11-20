using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F73 RID: 8051
[ayj("psimorphicBiocideGrenade")]
public sealed class bmc : ami
{
	// Token: 0x0600BC64 RID: 48228 RVA: 0x004162C4 File Offset: 0x004144C4
	public override string y8()
	{
		return "Псиморфибиоцидная граната";
	}

	// Token: 0x0600BC65 RID: 48229 RVA: 0x004162CC File Offset: 0x004144CC
	public override string os()
	{
		return "psimorphicBiocideGrenade";
	}

	// Token: 0x0600BC66 RID: 48230 RVA: 0x004162D4 File Offset: 0x004144D4
	public override bool ds()
	{
		return true;
	}

	// Token: 0x0600BC67 RID: 48231 RVA: 0x004162D8 File Offset: 0x004144D8
	public override IList<string> bi()
	{
		return new List<string>
		{
			d7f.m
		};
	}

	// Token: 0x0600BC68 RID: 48232 RVA: 0x004162EC File Offset: 0x004144EC
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600BC69 RID: 48233 RVA: 0x004162F4 File Offset: 0x004144F4
	public override string bp(cnm A_0)
	{
		a1q a1q = c18.a(1);
		a1q a1q2 = c18.a(c18.aq);
		return qv.a("Grenades/PsimorphicBiocide", new object[]
		{
			l4.a(c18.ak, false),
			new a1q(DamageType.Bio, a1q.LowerBoundary, a1q2.UpperBoundary)
		});
	}

	// Token: 0x0600BC6A RID: 48234 RVA: 0x00416350 File Offset: 0x00414550
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredTraversableSpot;
	}

	// Token: 0x0600BC6B RID: 48235 RVA: 0x00416354 File Offset: 0x00414554
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(d7f.m, bmc.a(A_0), false, false)
		};
	}

	// Token: 0x0600BC6C RID: 48236 RVA: 0x00416374 File Offset: 0x00414574
	protected override int d2(cnm A_0)
	{
		return 3;
	}

	// Token: 0x0600BC6D RID: 48237 RVA: 0x00416378 File Offset: 0x00414578
	private new static int a(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			return c18.a(A_0.b8(), as3.av);
		}
		return as3.av * d0u.b;
	}
}
