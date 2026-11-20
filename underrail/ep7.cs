using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F72 RID: 8050
[ayj("cryogasGrenade")]
public sealed class ep7 : ami
{
	// Token: 0x0600BC59 RID: 48217 RVA: 0x0041617C File Offset: 0x0041437C
	public override string y8()
	{
		return "Бросок криогазовой гранаты";
	}

	// Token: 0x0600BC5A RID: 48218 RVA: 0x00416184 File Offset: 0x00414384
	public override string os()
	{
		return "cryogasGrenade";
	}

	// Token: 0x0600BC5B RID: 48219 RVA: 0x0041618C File Offset: 0x0041438C
	public override bool ds()
	{
		return true;
	}

	// Token: 0x0600BC5C RID: 48220 RVA: 0x00416190 File Offset: 0x00414390
	public override IList<string> bi()
	{
		return new List<string>
		{
			d7f.m
		};
	}

	// Token: 0x0600BC5D RID: 48221 RVA: 0x004161A4 File Offset: 0x004143A4
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600BC5E RID: 48222 RVA: 0x004161B0 File Offset: 0x004143B0
	public override string bp(cnm A_0)
	{
		a1q a1q = c18.b(1);
		a1q a1q2 = c18.b(c18.aq);
		return qv.a("Grenades/Cryogas", new object[]
		{
			l4.a(c18.ag, false),
			new a1q(DamageType.Cold, a1q.LowerBoundary, a1q2.UpperBoundary),
			b34.a,
			l4.a(4, false),
			h7.i,
			qz.a,
			qz.b,
			l4.a((double)qz.c, false),
			l4.a(2, false)
		});
	}

	// Token: 0x0600BC5F RID: 48223 RVA: 0x00416264 File Offset: 0x00414464
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredTraversableSpot;
	}

	// Token: 0x0600BC60 RID: 48224 RVA: 0x00416268 File Offset: 0x00414468
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(d7f.m, ep7.a(A_0), false, false)
		};
	}

	// Token: 0x0600BC61 RID: 48225 RVA: 0x00416288 File Offset: 0x00414488
	protected override int d2(cnm A_0)
	{
		return 3;
	}

	// Token: 0x0600BC62 RID: 48226 RVA: 0x0041628C File Offset: 0x0041448C
	private new static int a(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			return c18.a(A_0.b8(), as3.av);
		}
		return as3.av * d0u.b;
	}
}
