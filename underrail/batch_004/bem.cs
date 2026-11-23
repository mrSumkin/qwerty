using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001806 RID: 6150
[ayj("CombatExoskeletonAura")]
public sealed class bem : cx6
{
	// Token: 0x060082AF RID: 33455 RVA: 0x0036CED0 File Offset: 0x0036B0D0
	public override string y8()
	{
		return "Мощность экзоскелета";
	}

	// Token: 0x060082B0 RID: 33456 RVA: 0x0036CED8 File Offset: 0x0036B0D8
	public override string os()
	{
		return "CombatExoskeletonAura";
	}

	// Token: 0x060082B1 RID: 33457 RVA: 0x0036CEE0 File Offset: 0x0036B0E0
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x060082B2 RID: 33458 RVA: 0x0036CEE4 File Offset: 0x0036B0E4
	public override IList<string> bi()
	{
		return bem.l;
	}

	// Token: 0x060082B3 RID: 33459 RVA: 0x0036CEEC File Offset: 0x0036B0EC
	public override int bh()
	{
		return 5000;
	}

	// Token: 0x060082B4 RID: 33460 RVA: 0x0036CEF4 File Offset: 0x0036B0F4
	public override v5 c2()
	{
		return v5.a;
	}

	// Token: 0x060082B5 RID: 33461 RVA: 0x0036CEF8 File Offset: 0x0036B0F8
	public override bool hl()
	{
		return true;
	}

	// Token: 0x060082B6 RID: 33462 RVA: 0x0036CEFC File Offset: 0x0036B0FC
	public override string bm(cnm A_0)
	{
		return "Abilities.77";
	}

	// Token: 0x060082B7 RID: 33463 RVA: 0x0036CF08 File Offset: 0x0036B108
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/CombatExoskeletonAura", new object[]
		{
			bem.h,
			bem.j,
			bem.e,
			bem.f,
			bem.g.ToString("0.0")
		});
	}

	// Token: 0x060082B8 RID: 33464 RVA: 0x0036CF70 File Offset: 0x0036B170
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x060082B9 RID: 33465 RVA: 0x0036CF7C File Offset: 0x0036B17C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(bem.d, 10000, false, false)
		};
	}

	// Token: 0x060082BA RID: 33466 RVA: 0x0036CFA0 File Offset: 0x0036B1A0
	public override List<els> j8(cnm A_0)
	{
		List<els> list = new List<els>();
		int a_ = 2;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Gear.l().Item != null)
		{
			a_ = -Enumerable.FirstOrDefault<ax6>(Enumerable.Where<ax6>(Enumerable.OfType<ax6>(A_0.b8().Gear.l().Item.fu().ar()), new Func<ax6, bool>(bem.a.a.a))).c();
		}
		list.Add(new bzz(a_));
		return list;
	}

	// Token: 0x060082BB RID: 33467 RVA: 0x0036D044 File Offset: 0x0036B244
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null && A_0.b8().Gear.l().Item != null && Enumerable.Any<aia>(A_0.b8().Gear.l().Item.fu().@as(), new Func<aia, bool>(this.b))) && A_0.b8().Gear.l().Item.Battery >= (double)bem.e;
	}

	// Token: 0x060082BC RID: 33468 RVA: 0x0036D0E8 File Offset: 0x0036B2E8
	public override bool cu(cnm A_0)
	{
		return base.cu(A_0) && (A_0 != null && A_0.b8() != null && A_0.b8().Gear.l().Item != null && Enumerable.Any<aia>(A_0.b8().Gear.l().Item.fu().@as(), new Func<aia, bool>(this.a))) && A_0.b8().Gear.l().Item.Battery > 0.0;
	}

	// Token: 0x060082BD RID: 33469 RVA: 0x0036D18C File Offset: 0x0036B38C
	protected override int hi(cnm A_0)
	{
		return 5;
	}

	// Token: 0x060082C0 RID: 33472 RVA: 0x0036D1FC File Offset: 0x0036B3FC
	[CompilerGenerated]
	private bool b(aia A_0)
	{
		return A_0.Value == this;
	}

	// Token: 0x060082C1 RID: 33473 RVA: 0x0036D208 File Offset: 0x0036B408
	[CompilerGenerated]
	private bool a(aia A_0)
	{
		return A_0.Value == this;
	}

	// Token: 0x04003267 RID: 12903
	private new const string a = "Exoskeleton Power";

	// Token: 0x04003268 RID: 12904
	private const string b = "CombatExoskeletonAura";

	// Token: 0x04003269 RID: 12905
	private const int c = 10000;

	// Token: 0x0400326A RID: 12906
	public static readonly string d = "SA.CombatExoskeletonAura";

	// Token: 0x0400326B RID: 12907
	public new static readonly int e = 10;

	// Token: 0x0400326C RID: 12908
	public new static readonly int f = 3;

	// Token: 0x0400326D RID: 12909
	public static readonly float g = 0.5f;

	// Token: 0x0400326E RID: 12910
	public static readonly int h = 2;

	// Token: 0x0400326F RID: 12911
	public static readonly int i = 2;

	// Token: 0x04003270 RID: 12912
	public static readonly int j = 25;

	// Token: 0x04003271 RID: 12913
	public static readonly float k = 0.15f;

	// Token: 0x04003272 RID: 12914
	public static readonly List<string> l = new List<string>
	{
		bem.d
	};

	// Token: 0x02001807 RID: 6151
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060082C4 RID: 33476 RVA: 0x0036D22C File Offset: 0x0036B42C
		internal bool a(ax6 A_0)
		{
			return A_0.BaseAbilityName == BaseAbilityEnum.Agility.ToString();
		}

		// Token: 0x04003273 RID: 12915
		public static readonly bem.a a = new bem.a();

		// Token: 0x04003274 RID: 12916
		public static Func<ax6, bool> b;
	}
}
