using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001EFE RID: 7934
[ayj("SiphonerHeadbuttAttack")]
public sealed class aso : c0z
{
	// Token: 0x0600B5AC RID: 46508 RVA: 0x00409E28 File Offset: 0x00408028
	public override string y8()
	{
		return "Таран головой";
	}

	// Token: 0x0600B5AD RID: 46509 RVA: 0x00409E30 File Offset: 0x00408030
	public override string os()
	{
		return "SiphonerHeadbuttAttack";
	}

	// Token: 0x0600B5AE RID: 46510 RVA: 0x00409E38 File Offset: 0x00408038
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B5AF RID: 46511 RVA: 0x00409E3C File Offset: 0x0040803C
	public override int e8()
	{
		return 1;
	}

	// Token: 0x0600B5B0 RID: 46512 RVA: 0x00409E40 File Offset: 0x00408040
	public override a3b c0()
	{
		return new a3b
		{
			c = c0e.g
		};
	}

	// Token: 0x0600B5B1 RID: 46513 RVA: 0x00409E54 File Offset: 0x00408054
	public aso()
	{
		this.e = new List<string>();
		this.e.Add("SA.SiphonerHeadbuttAttack");
	}

	// Token: 0x0600B5B2 RID: 46514 RVA: 0x00409E78 File Offset: 0x00408078
	public override string bm(cnm A_0)
	{
		return "SpecialAttacks.0";
	}

	// Token: 0x0600B5B3 RID: 46515 RVA: 0x00409E80 File Offset: 0x00408080
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B5B4 RID: 46516 RVA: 0x00409E84 File Offset: 0x00408084
	public override string bo(cnm A_0)
	{
		return "";
	}

	// Token: 0x0600B5B5 RID: 46517 RVA: 0x00409E8C File Offset: 0x0040808C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("SA.SiphonerHeadbuttAttack", aso.b, false, false)
		};
	}

	// Token: 0x0600B5B6 RID: 46518 RVA: 0x00409EAC File Offset: 0x004080AC
	public override IList<string> bi()
	{
		return this.e;
	}

	// Token: 0x0600B5B7 RID: 46519 RVA: 0x00409EB4 File Offset: 0x004080B4
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0600B5B8 RID: 46520 RVA: 0x00409EBC File Offset: 0x004080BC
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600B5B9 RID: 46521 RVA: 0x00409EC4 File Offset: 0x004080C4
	protected override int hi(cnm A_0)
	{
		return 30;
	}

	// Token: 0x04004225 RID: 16933
	private new const string a = "SA.SiphonerHeadbuttAttack";

	// Token: 0x04004226 RID: 16934
	public static readonly int b = d0u.b * 2;

	// Token: 0x04004227 RID: 16935
	public static readonly a1q c = new a1q(DamageType.Mechanical, 25, 40);

	// Token: 0x04004228 RID: 16936
	public static readonly double d = 0.2;

	// Token: 0x04004229 RID: 16937
	private new List<string> e;
}
