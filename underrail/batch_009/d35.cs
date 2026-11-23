using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EF1 RID: 7921
[ayj("EscapeBonds")]
public sealed class d35 : c0z
{
	// Token: 0x0600B4E4 RID: 46308 RVA: 0x00409034 File Offset: 0x00407234
	public override string y8()
	{
		return "Избавление от пут";
	}

	// Token: 0x0600B4E5 RID: 46309 RVA: 0x0040903C File Offset: 0x0040723C
	public override string os()
	{
		return "EscapeBonds";
	}

	// Token: 0x0600B4E6 RID: 46310 RVA: 0x00409044 File Offset: 0x00407244
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B4E7 RID: 46311 RVA: 0x00409048 File Offset: 0x00407248
	public override int e8()
	{
		return 2;
	}

	// Token: 0x0600B4E8 RID: 46312 RVA: 0x0040904C File Offset: 0x0040724C
	public override a3b c0()
	{
		return new a3b
		{
			c = c0e.d
		};
	}

	// Token: 0x0600B4E9 RID: 46313 RVA: 0x00409060 File Offset: 0x00407260
	public override bool hl()
	{
		return false;
	}

	// Token: 0x0600B4EA RID: 46314 RVA: 0x00409064 File Offset: 0x00407264
	public d35()
	{
		this.c = new List<string>();
		this.c.Add("SA.EscapeBonds");
	}

	// Token: 0x0600B4EB RID: 46315 RVA: 0x00409088 File Offset: 0x00407288
	public override string bm(cnm A_0)
	{
		return "EscapeBonds";
	}

	// Token: 0x0600B4EC RID: 46316 RVA: 0x00409090 File Offset: 0x00407290
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600B4ED RID: 46317 RVA: 0x00409094 File Offset: 0x00407294
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/EscapeBonds", new object[0]);
	}

	// Token: 0x0600B4EE RID: 46318 RVA: 0x004090A8 File Offset: 0x004072A8
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("SA.EscapeBonds", d35.b * d0u.b, false, false)
		};
	}

	// Token: 0x0600B4EF RID: 46319 RVA: 0x004090CC File Offset: 0x004072CC
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600B4F0 RID: 46320 RVA: 0x004090D4 File Offset: 0x004072D4
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600B4F1 RID: 46321 RVA: 0x004090D8 File Offset: 0x004072D8
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null && A_0.b8().SpecialStates.b) && A_0.b8().EncumbranceLevel != db9.d;
	}

	// Token: 0x0600B4F2 RID: 46322 RVA: 0x0040912C File Offset: 0x0040732C
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x040041FC RID: 16892
	private new const string a = "SA.EscapeBonds";

	// Token: 0x040041FD RID: 16893
	public static readonly int b = 2;

	// Token: 0x040041FE RID: 16894
	private List<string> c;
}
