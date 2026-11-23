using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F74 RID: 8052
[ayj("toxicGasGrenade")]
public sealed class a0t : ami
{
	// Token: 0x0600BC6F RID: 48239 RVA: 0x004163B0 File Offset: 0x004145B0
	public override string y8()
	{
		return "Бросок отравляющей гранаты";
	}

	// Token: 0x0600BC70 RID: 48240 RVA: 0x004163B8 File Offset: 0x004145B8
	public override string os()
	{
		return "toxicGasGrenade";
	}

	// Token: 0x0600BC71 RID: 48241 RVA: 0x004163C0 File Offset: 0x004145C0
	public override bool ds()
	{
		return true;
	}

	// Token: 0x0600BC72 RID: 48242 RVA: 0x004163C4 File Offset: 0x004145C4
	public override IList<string> bi()
	{
		return new List<string>
		{
			d7f.m
		};
	}

	// Token: 0x0600BC73 RID: 48243 RVA: 0x004163D8 File Offset: 0x004145D8
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600BC74 RID: 48244 RVA: 0x004163E0 File Offset: 0x004145E0
	public override string bp(cnm A_0)
	{
		a1q a1q = c18.d(1);
		a1q a1q2 = c18.d(c18.aq);
		return qv.a("Grenades/ToxicGas", new object[]
		{
			l4.a(c18.ac, false),
			new a1q(DamageType.Bio, a1q.LowerBoundary, a1q2.UpperBoundary),
			(int)((double)a8l.c * a8l.b * 100.0)
		});
	}

	// Token: 0x0600BC75 RID: 48245 RVA: 0x00416458 File Offset: 0x00414658
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredTraversableSpot;
	}

	// Token: 0x0600BC76 RID: 48246 RVA: 0x0041645C File Offset: 0x0041465C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(d7f.m, a0t.a(A_0), false, false)
		};
	}

	// Token: 0x0600BC77 RID: 48247 RVA: 0x0041647C File Offset: 0x0041467C
	protected override int d2(cnm A_0)
	{
		return 3;
	}

	// Token: 0x0600BC78 RID: 48248 RVA: 0x00416480 File Offset: 0x00414680
	private new static int a(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			return c18.a(A_0.b8(), as3.av);
		}
		return as3.av * d0u.b;
	}
}
