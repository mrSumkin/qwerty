using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F21 RID: 7969
[ayj("DisruptiveField")]
public sealed class ezt : ce5
{
	// Token: 0x0600B803 RID: 47107 RVA: 0x0040F034 File Offset: 0x0040D234
	public override string y8()
	{
		return "Поле помех";
	}

	// Token: 0x0600B804 RID: 47108 RVA: 0x0040F03C File Offset: 0x0040D23C
	public override string os()
	{
		return "DisruptiveField";
	}

	// Token: 0x0600B805 RID: 47109 RVA: 0x0040F044 File Offset: 0x0040D244
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B806 RID: 47110 RVA: 0x0040F048 File Offset: 0x0040D248
	public override PsiSchool ch()
	{
		return PsiSchool.Psychokinesis;
	}

	// Token: 0x0600B807 RID: 47111 RVA: 0x0040F04C File Offset: 0x0040D24C
	public override int ci()
	{
		return 5;
	}

	// Token: 0x0600B808 RID: 47112 RVA: 0x0040F050 File Offset: 0x0040D250
	public ezt()
	{
		this.i = new List<string>
		{
			d7f.b,
			"Psi.DisruptiveField"
		};
	}

	// Token: 0x0600B809 RID: 47113 RVA: 0x0040F084 File Offset: 0x0040D284
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new bap(40, new Type[]
			{
				typeof(fd)
			})
		};
	}

	// Token: 0x0600B80A RID: 47114 RVA: 0x0040F0D8 File Offset: 0x0040D2D8
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B80B RID: 47115 RVA: 0x0040F0DC File Offset: 0x0040D2DC
	public override IList<string> bi()
	{
		return this.i;
	}

	// Token: 0x0600B80C RID: 47116 RVA: 0x0040F0E4 File Offset: 0x0040D2E4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("Psi.DisruptiveField", 4 * d0u.b, false, false)
		};
	}

	// Token: 0x0600B80D RID: 47117 RVA: 0x0040F104 File Offset: 0x0040D304
	public override string bo(cnm A_0)
	{
		return qv.a("Psi/DisruptiveField", new object[]
		{
			(int)(ezt.a(A_0) * 100.0),
			l4.a(ezt.e, false)
		});
	}

	// Token: 0x0600B80E RID: 47118 RVA: 0x0040F140 File Offset: 0x0040D340
	public new static double a(cnm A_0)
	{
		int effectivePsiSkillLevel = ce5.GetEffectivePsiSkillLevel<fd>(A_0);
		return Math.Min(0.85, 0.25 + 0.003 * (double)effectivePsiSkillLevel);
	}

	// Token: 0x0600B80F RID: 47119 RVA: 0x0040F178 File Offset: 0x0040D378
	protected override int hi(cnm A_0)
	{
		return 10;
	}

	// Token: 0x0600B810 RID: 47120 RVA: 0x0040F17C File Offset: 0x0040D37C
	protected override float f0(cnm A_0)
	{
		return 12f;
	}

	// Token: 0x0600B811 RID: 47121 RVA: 0x0040F184 File Offset: 0x0040D384
	protected override float cj(cnm A_0)
	{
		return 10f;
	}

	// Token: 0x0600B812 RID: 47122 RVA: 0x0040F18C File Offset: 0x0040D38C
	protected override int br(cnm A_0)
	{
		return 1500;
	}

	// Token: 0x0600B813 RID: 47123 RVA: 0x0040F194 File Offset: 0x0040D394
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.NonDamaging | PsiAbilityCategories.Telekinetic;
	}

	// Token: 0x040042F9 RID: 17145
	public new const string a = "Psi.DisruptiveField";

	// Token: 0x040042FA RID: 17146
	private const int b = 4;

	// Token: 0x040042FB RID: 17147
	private const string c = "Disruptive Field";

	// Token: 0x040042FC RID: 17148
	private const string d = "DisruptiveField";

	// Token: 0x040042FD RID: 17149
	public new static readonly int e = 2;

	// Token: 0x040042FE RID: 17150
	private new const double f = 0.25;

	// Token: 0x040042FF RID: 17151
	private new const double g = 0.003;

	// Token: 0x04004300 RID: 17152
	private new const double h = 0.85;

	// Token: 0x04004301 RID: 17153
	private new List<string> i;
}
