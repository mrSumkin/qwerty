using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F44 RID: 8004
[ayj("WildPsionicInnervation")]
public sealed class zw : c0z
{
	// Token: 0x0600BA8B RID: 47755 RVA: 0x004130E0 File Offset: 0x004112E0
	public override string y8()
	{
		return "Эскалация псионической иннервации";
	}

	// Token: 0x0600BA8C RID: 47756 RVA: 0x004130E8 File Offset: 0x004112E8
	public override string os()
	{
		return "WildPsionicInnervation";
	}

	// Token: 0x0600BA8D RID: 47757 RVA: 0x004130F0 File Offset: 0x004112F0
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BA8E RID: 47758 RVA: 0x004130F4 File Offset: 0x004112F4
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.f,
			c = c0e.g
		};
	}

	// Token: 0x0600BA8F RID: 47759 RVA: 0x00413114 File Offset: 0x00411314
	public override bool hl()
	{
		return true;
	}

	// Token: 0x0600BA90 RID: 47760 RVA: 0x00413118 File Offset: 0x00411318
	public override bool bk()
	{
		return true;
	}

	// Token: 0x0600BA91 RID: 47761 RVA: 0x0041311C File Offset: 0x0041131C
	public override IList<string> bi()
	{
		return this.k;
	}

	// Token: 0x0600BA92 RID: 47762 RVA: 0x00413124 File Offset: 0x00411324
	public zw()
	{
		this.k = new List<string>();
		this.k.Add("SA.WildPsionicInnervation");
	}

	// Token: 0x0600BA93 RID: 47763 RVA: 0x00413148 File Offset: 0x00411348
	public override string bm(cnm A_0)
	{
		return "Abilities.110";
	}

	// Token: 0x0600BA94 RID: 47764 RVA: 0x00413150 File Offset: 0x00411350
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BA95 RID: 47765 RVA: 0x00413158 File Offset: 0x00411358
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Utilities/WildPsionicInnervation", new object[]
		{
			zw.e.ToString(),
			zw.g.b("P0"),
			zw.h.b("P0"),
			zw.f.b("P0"),
			zw.i.ToString("P0"),
			zw.c,
			zw.j
		});
	}

	// Token: 0x0600BA96 RID: 47766 RVA: 0x004131FC File Offset: 0x004113FC
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600BA97 RID: 47767 RVA: 0x00413208 File Offset: 0x00411408
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("SA.WildPsionicInnervation", zw.b * d0u.b, false, false)
		};
	}

	// Token: 0x0600BA98 RID: 47768 RVA: 0x0041322C File Offset: 0x0041142C
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600BA99 RID: 47769 RVA: 0x00413230 File Offset: 0x00411430
	protected override int hi(cnm A_0)
	{
		return zw.d;
	}

	// Token: 0x0600BA9A RID: 47770 RVA: 0x00413238 File Offset: 0x00411438
	protected override int br(cnm A_0)
	{
		return 1500;
	}

	// Token: 0x0600BA9B RID: 47771 RVA: 0x00413240 File Offset: 0x00411440
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null && A_0.b8().Gear.l().Item != null && Enumerable.Any<aia>(A_0.b8().Gear.l().Item.fu().@as(), new Func<aia, bool>(this.a))) && A_0.b8().Gear.l().Item.Battery >= (double)zw.j;
	}

	// Token: 0x0600BA9D RID: 47773 RVA: 0x00413388 File Offset: 0x00411588
	[CompilerGenerated]
	private bool a(aia A_0)
	{
		return A_0.Value == this;
	}

	// Token: 0x040043B7 RID: 17335
	private new const string a = "SA.WildPsionicInnervation";

	// Token: 0x040043B8 RID: 17336
	public static readonly int b = 5;

	// Token: 0x040043B9 RID: 17337
	public static readonly int c = 2;

	// Token: 0x040043BA RID: 17338
	public static readonly int d = 10;

	// Token: 0x040043BB RID: 17339
	public new static readonly b1j e = new b1j(15.0, 50.0);

	// Token: 0x040043BC RID: 17340
	public static readonly b1j f = new b1j(0.1, 0.3);

	// Token: 0x040043BD RID: 17341
	public new static readonly b1j g = new b1j(0.01, 0.1);

	// Token: 0x040043BE RID: 17342
	public new static readonly b1j h = new b1j(0.2, 0.5);

	// Token: 0x040043BF RID: 17343
	public new static readonly float i = 0.5f;

	// Token: 0x040043C0 RID: 17344
	public new static readonly int j = 25;

	// Token: 0x040043C1 RID: 17345
	private new List<string> k;
}
