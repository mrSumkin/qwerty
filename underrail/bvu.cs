using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F6F RID: 8047
[ayj("herbicideGasGrenade")]
public sealed class bvu : ami
{
	// Token: 0x0600BC39 RID: 48185 RVA: 0x00415E38 File Offset: 0x00414038
	public override string y8()
	{
		return "Бросок газовой гранаты с гербицидом";
	}

	// Token: 0x0600BC3A RID: 48186 RVA: 0x00415E40 File Offset: 0x00414040
	public override string os()
	{
		return "herbicideGasGrenade";
	}

	// Token: 0x0600BC3B RID: 48187 RVA: 0x00415E48 File Offset: 0x00414048
	public override bool ds()
	{
		return true;
	}

	// Token: 0x0600BC3C RID: 48188 RVA: 0x00415E4C File Offset: 0x0041404C
	public override IList<string> bi()
	{
		return new List<string>
		{
			d7f.m
		};
	}

	// Token: 0x0600BC3D RID: 48189 RVA: 0x00415E60 File Offset: 0x00414060
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600BC3E RID: 48190 RVA: 0x00415E6C File Offset: 0x0041406C
	public override string bp(cnm A_0)
	{
		a1q a1q = c18.a(1, false);
		a1q a1q2 = c18.a(c18.aq, false);
		return qv.a("Grenades/HerbicideGas", new object[]
		{
			l4.a(c18.ao, false),
			new a1q(DamageType.Bio, a1q.LowerBoundary, a1q2.UpperBoundary),
			Convert.ToInt32(c18.ap * 100.0)
		});
	}

	// Token: 0x0600BC3F RID: 48191 RVA: 0x00415EE4 File Offset: 0x004140E4
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredTraversableSpot;
	}

	// Token: 0x0600BC40 RID: 48192 RVA: 0x00415EE8 File Offset: 0x004140E8
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(d7f.m, bvu.a(A_0), false, false)
		};
	}

	// Token: 0x0600BC41 RID: 48193 RVA: 0x00415F08 File Offset: 0x00414108
	protected override int d2(cnm A_0)
	{
		return 3;
	}

	// Token: 0x0600BC42 RID: 48194 RVA: 0x00415F0C File Offset: 0x0041410C
	private new static int a(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			return c18.a(A_0.b8(), as3.av);
		}
		return as3.av * d0u.b;
	}
}
