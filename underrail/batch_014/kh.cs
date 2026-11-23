using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F60 RID: 8032
[ayj("ThrowFlare")]
public sealed class kh : c0r
{
	// Token: 0x0600BB87 RID: 48007 RVA: 0x00414F28 File Offset: 0x00413128
	public override string y8()
	{
		return "Бросок вспышки";
	}

	// Token: 0x0600BB88 RID: 48008 RVA: 0x00414F30 File Offset: 0x00413130
	public override string os()
	{
		return "ThrowFlare";
	}

	// Token: 0x0600BB89 RID: 48009 RVA: 0x00414F38 File Offset: 0x00413138
	public override string c1()
	{
		return "Бросает";
	}

	// Token: 0x0600BB8A RID: 48010 RVA: 0x00414F40 File Offset: 0x00413140
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredTraversableSpot;
	}

	// Token: 0x0600BB8B RID: 48011 RVA: 0x00414F44 File Offset: 0x00413144
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600BB8C RID: 48012 RVA: 0x00414F48 File Offset: 0x00413148
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.GroundAttack);
	}

	// Token: 0x0600BB8D RID: 48013 RVA: 0x00414F54 File Offset: 0x00413154
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.i,
			b = new int?(int.MaxValue),
			c = c0e.i
		};
	}

	// Token: 0x0600BB8E RID: 48014 RVA: 0x00414F84 File Offset: 0x00413184
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600BB8F RID: 48015 RVA: 0x00414F88 File Offset: 0x00413188
	public kh()
	{
		this.d = new List<string>
		{
			"throwFlare"
		};
	}

	// Token: 0x0600BB90 RID: 48016 RVA: 0x00414FA8 File Offset: 0x004131A8
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600BB91 RID: 48017 RVA: 0x00414FB0 File Offset: 0x004131B0
	public override string bp(cnm A_0)
	{
		return qv.a("Items\\Utilities/ThrowFlare", new object[]
		{
			kh.c / 1000
		});
	}

	// Token: 0x0600BB92 RID: 48018 RVA: 0x00414FD8 File Offset: 0x004131D8
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BB93 RID: 48019 RVA: 0x00414FDC File Offset: 0x004131DC
	public override dsk cv(cnm A_0)
	{
		return dsk.b;
	}

	// Token: 0x0600BB94 RID: 48020 RVA: 0x00414FE0 File Offset: 0x004131E0
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("throwFlare", 5000, false, false)
		};
	}

	// Token: 0x0600BB95 RID: 48021 RVA: 0x00415000 File Offset: 0x00413200
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x0600BB96 RID: 48022 RVA: 0x00415008 File Offset: 0x00413208
	protected override int br(cnm A_0)
	{
		return dgk.Get<d1n>().n(A_0);
	}

	// Token: 0x0600BB97 RID: 48023 RVA: 0x00415018 File Offset: 0x00413218
	protected override float f0(cnm A_0)
	{
		return dgk.Get<d1n>().afi(A_0);
	}

	// Token: 0x0600BB98 RID: 48024 RVA: 0x00415028 File Offset: 0x00413228
	protected override int d2(cnm A_0)
	{
		return 3;
	}

	// Token: 0x040043E5 RID: 17381
	private new const string a = "throwFlare";

	// Token: 0x040043E6 RID: 17382
	private const int b = 5000;

	// Token: 0x040043E7 RID: 17383
	public static readonly int c = 30000;

	// Token: 0x040043E8 RID: 17384
	private List<string> d;
}
