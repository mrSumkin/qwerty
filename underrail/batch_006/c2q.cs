using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F14 RID: 7956
[ayj("ElectromagneticBurst")]
public sealed class c2q : ce5
{
	// Token: 0x0600B71B RID: 46875 RVA: 0x0040CFF0 File Offset: 0x0040B1F0
	public override string y8()
	{
		return "Электромагнитная очередь";
	}

	// Token: 0x0600B71C RID: 46876 RVA: 0x0040CFF8 File Offset: 0x0040B1F8
	public override string os()
	{
		return "ElectromagneticBurst";
	}

	// Token: 0x0600B71D RID: 46877 RVA: 0x0040D000 File Offset: 0x0040B200
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B71E RID: 46878 RVA: 0x0040D004 File Offset: 0x0040B204
	public override int ci()
	{
		return 2;
	}

	// Token: 0x0600B71F RID: 46879 RVA: 0x0040D008 File Offset: 0x0040B208
	public override PsiSchool ch()
	{
		return PsiSchool.Psychokinesis;
	}

	// Token: 0x0600B720 RID: 46880 RVA: 0x0040D00C File Offset: 0x0040B20C
	public c2q()
	{
		this.d = new List<string>
		{
			d7f.b,
			"Psi.EmpBlast"
		};
	}

	// Token: 0x0600B721 RID: 46881 RVA: 0x0040D040 File Offset: 0x0040B240
	public override string bm(cnm A_0)
	{
		return "Misc.0";
	}

	// Token: 0x0600B722 RID: 46882 RVA: 0x0040D048 File Offset: 0x0040B248
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredPenetrableSpot;
	}

	// Token: 0x0600B723 RID: 46883 RVA: 0x0040D04C File Offset: 0x0040B24C
	public override string bo(cnm A_0)
	{
		return "";
	}

	// Token: 0x0600B724 RID: 46884 RVA: 0x0040D054 File Offset: 0x0040B254
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("Psi.EmpBlast", c2q.b, false, false)
		};
	}

	// Token: 0x0600B725 RID: 46885 RVA: 0x0040D074 File Offset: 0x0040B274
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x0600B726 RID: 46886 RVA: 0x0040D07C File Offset: 0x0040B27C
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new bap(50, new Type[]
			{
				typeof(fd)
			})
		};
	}

	// Token: 0x0600B727 RID: 46887 RVA: 0x0040D0D0 File Offset: 0x0040B2D0
	protected override int br(cnm A_0)
	{
		return 1500;
	}

	// Token: 0x0600B728 RID: 46888 RVA: 0x0040D0D8 File Offset: 0x0040B2D8
	protected override float f0(cnm A_0)
	{
		return (float)c2q.c;
	}

	// Token: 0x0600B729 RID: 46889 RVA: 0x0040D0E0 File Offset: 0x0040B2E0
	protected override int d2(cnm A_0)
	{
		return c18.e();
	}

	// Token: 0x0600B72A RID: 46890 RVA: 0x0040D0E8 File Offset: 0x0040B2E8
	protected override int hi(cnm A_0)
	{
		return 25;
	}

	// Token: 0x0600B72B RID: 46891 RVA: 0x0040D0EC File Offset: 0x0040B2EC
	protected override float cj(cnm A_0)
	{
		return 50f;
	}

	// Token: 0x0600B72C RID: 46892 RVA: 0x0040D0F4 File Offset: 0x0040B2F4
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.Damaging;
	}

	// Token: 0x0400428E RID: 17038
	private new const string a = "Psi.EmpBlast";

	// Token: 0x0400428F RID: 17039
	public static readonly int b = d0u.b * 3;

	// Token: 0x04004290 RID: 17040
	public static readonly int c = 8;

	// Token: 0x04004291 RID: 17041
	private List<string> d;
}
