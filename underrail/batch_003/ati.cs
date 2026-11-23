using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F24 RID: 7972
[ayj("NeurovisualDisruption")]
public sealed class ati : ce5
{
	// Token: 0x0600B83A RID: 47162 RVA: 0x0040F5FC File Offset: 0x0040D7FC
	public override string y8()
	{
		return "Нейровизуальная помеха";
	}

	// Token: 0x0600B83B RID: 47163 RVA: 0x0040F604 File Offset: 0x0040D804
	public override string os()
	{
		return "NeurovisualDisruption";
	}

	// Token: 0x0600B83C RID: 47164 RVA: 0x0040F60C File Offset: 0x0040D80C
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B83D RID: 47165 RVA: 0x0040F610 File Offset: 0x0040D810
	public override PsiSchool ch()
	{
		return PsiSchool.ThoughtControl;
	}

	// Token: 0x0600B83E RID: 47166 RVA: 0x0040F614 File Offset: 0x0040D814
	public override int ci()
	{
		return 8;
	}

	// Token: 0x0600B83F RID: 47167 RVA: 0x0040F61C File Offset: 0x0040D81C
	public ati()
	{
		this.g = new List<string>
		{
			d7f.b,
			"Psi.NeurovisualDisruption"
		};
	}

	// Token: 0x0600B840 RID: 47168 RVA: 0x0040F650 File Offset: 0x0040D850
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
				typeof(dql)
			})
		};
	}

	// Token: 0x0600B841 RID: 47169 RVA: 0x0040F6A4 File Offset: 0x0040D8A4
	public override SpellTargetType bn(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(bgo.a))
		{
			return SpellTargetType.DiscoveredPenetrableSpot;
		}
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B842 RID: 47170 RVA: 0x0040F6D8 File Offset: 0x0040D8D8
	public override IList<string> bi()
	{
		return this.g;
	}

	// Token: 0x0600B843 RID: 47171 RVA: 0x0040F6E0 File Offset: 0x0040D8E0
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("Psi.NeurovisualDisruption", 10 * d0u.b, false, false)
		};
	}

	// Token: 0x0600B844 RID: 47172 RVA: 0x0040F704 File Offset: 0x0040D904
	public override string bo(cnm A_0)
	{
		return qv.a("Psi/NeurovisualDisruption", new object[]
		{
			l4.a(ati.e, false),
			ak2.a,
			(int)(ak2.b * 100.0),
			l4.a(ati.f, false)
		});
	}

	// Token: 0x0600B845 RID: 47173 RVA: 0x0040F764 File Offset: 0x0040D964
	public override bool hm(cnm A_0)
	{
		if (!base.hm(A_0))
		{
			return false;
		}
		io service = bpo.GetService<io>();
		return service != null && service.ahh();
	}

	// Token: 0x0600B846 RID: 47174 RVA: 0x0040F794 File Offset: 0x0040D994
	protected override int hi(cnm A_0)
	{
		return 10;
	}

	// Token: 0x0600B847 RID: 47175 RVA: 0x0040F798 File Offset: 0x0040D998
	protected override int d2(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(bgo.a))
		{
			return bgo.b;
		}
		return 0;
	}

	// Token: 0x0600B848 RID: 47176 RVA: 0x0040F7CC File Offset: 0x0040D9CC
	protected override float f0(cnm A_0)
	{
		return 5f;
	}

	// Token: 0x0600B849 RID: 47177 RVA: 0x0040F7D4 File Offset: 0x0040D9D4
	protected override float cj(cnm A_0)
	{
		return 40f;
	}

	// Token: 0x0600B84A RID: 47178 RVA: 0x0040F7DC File Offset: 0x0040D9DC
	protected override int br(cnm A_0)
	{
		return 1500;
	}

	// Token: 0x0600B84B RID: 47179 RVA: 0x0040F7E4 File Offset: 0x0040D9E4
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.NonDamaging;
	}

	// Token: 0x04004310 RID: 17168
	public new const string a = "Psi.NeurovisualDisruption";

	// Token: 0x04004311 RID: 17169
	private const int b = 10;

	// Token: 0x04004312 RID: 17170
	private const string c = "Neurovisual Disruption";

	// Token: 0x04004313 RID: 17171
	private const string d = "NeurovisualDisruption";

	// Token: 0x04004314 RID: 17172
	public new static readonly int e = 2;

	// Token: 0x04004315 RID: 17173
	public new static readonly int f = 5;

	// Token: 0x04004316 RID: 17174
	private new List<string> g;
}
