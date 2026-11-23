using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F1F RID: 7967
[ayj("ExothermicAura")]
public sealed class eod : ce5
{
	// Token: 0x0600B7DB RID: 47067 RVA: 0x0040EA70 File Offset: 0x0040CC70
	public override string y8()
	{
		return "Экзотермическая аура";
	}

	// Token: 0x0600B7DC RID: 47068 RVA: 0x0040EA78 File Offset: 0x0040CC78
	public override string os()
	{
		return "ExothermicAura";
	}

	// Token: 0x0600B7DD RID: 47069 RVA: 0x0040EA80 File Offset: 0x0040CC80
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B7DE RID: 47070 RVA: 0x0040EA84 File Offset: 0x0040CC84
	public override PsiSchool ch()
	{
		return PsiSchool.Metathermics;
	}

	// Token: 0x0600B7DF RID: 47071 RVA: 0x0040EA88 File Offset: 0x0040CC88
	public override int ci()
	{
		return 8;
	}

	// Token: 0x0600B7E0 RID: 47072 RVA: 0x0040EA8C File Offset: 0x0040CC8C
	public eod()
	{
		this.d = new List<string>
		{
			"Psi.ExothermicAura"
		};
	}

	// Token: 0x0600B7E1 RID: 47073 RVA: 0x0040EAAC File Offset: 0x0040CCAC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600B7E2 RID: 47074 RVA: 0x0040EAB0 File Offset: 0x0040CCB0
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x0600B7E3 RID: 47075 RVA: 0x0040EAB8 File Offset: 0x0040CCB8
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("Psi.ExothermicAura", 12 * d0u.b, false, false)
		};
	}

	// Token: 0x0600B7E4 RID: 47076 RVA: 0x0040EADC File Offset: 0x0040CCDC
	public override string bo(cnm A_0)
	{
		b1j b1j = c18.d();
		b1j b1j2 = c18.b();
		b1j b1j3 = c18.c();
		return qv.a("Psi/ExothermicAura", new object[]
		{
			l4.a(eod.c, false),
			(int)(b1j.b * 100.0),
			(int)(b1j.c * 100.0),
			(int)b1j2.b,
			(int)b1j2.c,
			(int)b1j3.b,
			(int)b1j3.c
		});
	}

	// Token: 0x0600B7E5 RID: 47077 RVA: 0x0040EB88 File Offset: 0x0040CD88
	protected override float cj(cnm A_0)
	{
		return 40f;
	}

	// Token: 0x0600B7E6 RID: 47078 RVA: 0x0040EB94 File Offset: 0x0040CD94
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new bap(70, new Type[]
			{
				typeof(rs)
			})
		};
	}

	// Token: 0x0600B7E7 RID: 47079 RVA: 0x0040EBE8 File Offset: 0x0040CDE8
	protected override float cl(cnm A_0)
	{
		float num = base.cl(A_0);
		if ((A_0.b8().bb & eom.b) != eom.a)
		{
			num *= (float)(1.0 - dyi.a(A_0.b8()));
		}
		return num;
	}

	// Token: 0x0600B7E8 RID: 47080 RVA: 0x0040EC2C File Offset: 0x0040CE2C
	protected override int hi(cnm A_0)
	{
		return 25;
	}

	// Token: 0x0600B7E9 RID: 47081 RVA: 0x0040EC30 File Offset: 0x0040CE30
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.Damaging;
	}

	// Token: 0x040042E8 RID: 17128
	public new const string a = "Psi.ExothermicAura";

	// Token: 0x040042E9 RID: 17129
	private const int b = 12;

	// Token: 0x040042EA RID: 17130
	public static readonly int c = 4;

	// Token: 0x040042EB RID: 17131
	private List<string> d;
}
