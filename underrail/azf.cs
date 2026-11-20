using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001EF0 RID: 7920
[ayj("TchortGooSpray")]
public sealed class azf : c0z
{
	// Token: 0x0600B4D3 RID: 46291 RVA: 0x00408F58 File Offset: 0x00407158
	public override string y8()
	{
		return "Брызги слизи Чорта";
	}

	// Token: 0x0600B4D4 RID: 46292 RVA: 0x00408F60 File Offset: 0x00407160
	public override string os()
	{
		return "TchortGooSpray";
	}

	// Token: 0x0600B4D5 RID: 46293 RVA: 0x00408F68 File Offset: 0x00407168
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B4D6 RID: 46294 RVA: 0x00408F6C File Offset: 0x0040716C
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600B4D7 RID: 46295 RVA: 0x00408F70 File Offset: 0x00407170
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.a
		};
	}

	// Token: 0x0600B4D8 RID: 46296 RVA: 0x00408F84 File Offset: 0x00407184
	public override string c1()
	{
		return "Засеивает";
	}

	// Token: 0x0600B4D9 RID: 46297 RVA: 0x00408F8C File Offset: 0x0040718C
	public azf()
	{
		this.g = new List<string>();
		this.g.Add("SA.TchortGooSpray");
	}

	// Token: 0x0600B4DA RID: 46298 RVA: 0x00408FB0 File Offset: 0x004071B0
	public override string bm(cnm A_0)
	{
		return "DamageType.Bio";
	}

	// Token: 0x0600B4DB RID: 46299 RVA: 0x00408FB8 File Offset: 0x004071B8
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B4DC RID: 46300 RVA: 0x00408FBC File Offset: 0x004071BC
	public override string bo(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600B4DD RID: 46301 RVA: 0x00408FC0 File Offset: 0x004071C0
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("SA.TchortGooSpray", azf.b, false, false)
		};
	}

	// Token: 0x0600B4DE RID: 46302 RVA: 0x00408FE0 File Offset: 0x004071E0
	public override IList<string> bi()
	{
		return this.g;
	}

	// Token: 0x0600B4DF RID: 46303 RVA: 0x00408FE8 File Offset: 0x004071E8
	public static csk a()
	{
		return euf.a(new a1q(DamageType.Acid, 15, 25), 1.0);
	}

	// Token: 0x0600B4E0 RID: 46304 RVA: 0x00409004 File Offset: 0x00407204
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0600B4E1 RID: 46305 RVA: 0x0040900C File Offset: 0x0040720C
	protected override float f0(cnm A_0)
	{
		return (float)azf.f;
	}

	// Token: 0x0600B4E2 RID: 46306 RVA: 0x00409014 File Offset: 0x00407214
	protected override int hi(cnm A_0)
	{
		return 20;
	}

	// Token: 0x040041F5 RID: 16885
	private new const string a = "SA.TchortGooSpray";

	// Token: 0x040041F6 RID: 16886
	private static readonly int b = d0u.b * 2;

	// Token: 0x040041F7 RID: 16887
	private const int c = 15;

	// Token: 0x040041F8 RID: 16888
	private const int d = 25;

	// Token: 0x040041F9 RID: 16889
	public new static readonly int e = 6;

	// Token: 0x040041FA RID: 16890
	public static readonly int f = 8;

	// Token: 0x040041FB RID: 16891
	private new List<string> g;
}
