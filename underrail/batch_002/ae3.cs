using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F65 RID: 8037
[ayj("ptnt")]
public sealed class ae3 : c0r
{
	// Token: 0x0600BBDC RID: 48092 RVA: 0x004154E8 File Offset: 0x004136E8
	public override string y8()
	{
		return "Place TNT charge";
	}

	// Token: 0x0600BBDD RID: 48093 RVA: 0x004154F0 File Offset: 0x004136F0
	public override string os()
	{
		return "ptnt";
	}

	// Token: 0x0600BBDE RID: 48094 RVA: 0x004154F8 File Offset: 0x004136F8
	public override string c1()
	{
		return "Устанавливает";
	}

	// Token: 0x0600BBDF RID: 48095 RVA: 0x00415500 File Offset: 0x00413700
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredTraversableSpot;
	}

	// Token: 0x0600BBE0 RID: 48096 RVA: 0x00415504 File Offset: 0x00413704
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600BBE1 RID: 48097 RVA: 0x00415508 File Offset: 0x00413708
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.d
		};
	}

	// Token: 0x0600BBE2 RID: 48098 RVA: 0x0041551C File Offset: 0x0041371C
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600BBE3 RID: 48099 RVA: 0x00415520 File Offset: 0x00413720
	public override bool c3(cnm A_0)
	{
		return false;
	}

	// Token: 0x0600BBE4 RID: 48100 RVA: 0x00415524 File Offset: 0x00413724
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600BBE5 RID: 48101 RVA: 0x00415530 File Offset: 0x00413730
	public override string bp(cnm A_0)
	{
		return qv.a("Explosives/TNT", new object[]
		{
			ae3.a / 1000,
			l4.a((double)ae3.a, false),
			c18.r(2).a(true),
			c18.q(2).a(true)
		});
	}

	// Token: 0x0600BBE6 RID: 48102 RVA: 0x00415594 File Offset: 0x00413794
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BBE7 RID: 48103 RVA: 0x00415598 File Offset: 0x00413798
	public static List<csk> a()
	{
		return new List<csk>
		{
			new csk(DamageType.Heat, 30000),
			new csk(DamageType.Mechanical, 30000)
		};
	}

	// Token: 0x0600BBE8 RID: 48104 RVA: 0x004155C4 File Offset: 0x004137C4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600BBE9 RID: 48105 RVA: 0x004155CC File Offset: 0x004137CC
	public override IList<string> bi()
	{
		return new List<string>();
	}

	// Token: 0x0600BBEA RID: 48106 RVA: 0x004155D4 File Offset: 0x004137D4
	protected override int br(cnm A_0)
	{
		return 7000;
	}

	// Token: 0x0600BBEB RID: 48107 RVA: 0x004155DC File Offset: 0x004137DC
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600BBEC RID: 48108 RVA: 0x004155E4 File Offset: 0x004137E4
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x040043F2 RID: 17394
	public new static readonly int a = 10000;

	// Token: 0x040043F3 RID: 17395
	public static readonly float b = 4f;
}
