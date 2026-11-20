using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F00 RID: 7936
[ayj("SpecialTactics")]
public sealed class ezf : c0z
{
	// Token: 0x0600B5CB RID: 46539 RVA: 0x0040A188 File Offset: 0x00408388
	public override string y8()
	{
		return "Особая тактика";
	}

	// Token: 0x0600B5CC RID: 46540 RVA: 0x0040A190 File Offset: 0x00408390
	public override string os()
	{
		return "SpecialTactics";
	}

	// Token: 0x0600B5CD RID: 46541 RVA: 0x0040A198 File Offset: 0x00408398
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B5CE RID: 46542 RVA: 0x0040A19C File Offset: 0x0040839C
	public override int e8()
	{
		return 2;
	}

	// Token: 0x0600B5CF RID: 46543 RVA: 0x0040A1A0 File Offset: 0x004083A0
	public override a3b c0()
	{
		return new a3b
		{
			c = c0e.d
		};
	}

	// Token: 0x0600B5D0 RID: 46544 RVA: 0x0040A1B4 File Offset: 0x004083B4
	public ezf()
	{
		this.b = new List<string>();
		this.b.Add("SA.SpecialTactics");
	}

	// Token: 0x0600B5D1 RID: 46545 RVA: 0x0040A1D8 File Offset: 0x004083D8
	public override string bm(cnm A_0)
	{
		return "SpecialTactics";
	}

	// Token: 0x0600B5D2 RID: 46546 RVA: 0x0040A1E0 File Offset: 0x004083E0
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600B5D3 RID: 46547 RVA: 0x0040A1E4 File Offset: 0x004083E4
	public override string bo(cnm A_0)
	{
		return qv.b("SpecialAbilities/SpecialTactics");
	}

	// Token: 0x0600B5D4 RID: 46548 RVA: 0x0040A1F0 File Offset: 0x004083F0
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		int num = y6.a;
		if (A_0 != null && A_0.b8() != null)
		{
			num -= A_0.b8().GetSpecializationValue<bvv>(true) * bvv.a * d0u.b;
		}
		return new List<cfd>
		{
			new cfd("SA.SpecialTactics", num, false, false)
		};
	}

	// Token: 0x0600B5D5 RID: 46549 RVA: 0x0040A248 File Offset: 0x00408448
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null) && !A_0.b8().IsInCombat;
	}

	// Token: 0x0600B5D6 RID: 46550 RVA: 0x0040A27C File Offset: 0x0040847C
	public override IList<string> bi()
	{
		return this.b;
	}

	// Token: 0x0600B5D7 RID: 46551 RVA: 0x0040A284 File Offset: 0x00408484
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600B5D8 RID: 46552 RVA: 0x0040A288 File Offset: 0x00408488
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x04004231 RID: 16945
	private new const string a = "SA.SpecialTactics";

	// Token: 0x04004232 RID: 16946
	private List<string> b;
}
