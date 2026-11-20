using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001524 RID: 5412
[eiz("BRA")]
[Serializable]
public sealed class afr : d64, ISerializable, enp
{
	// Token: 0x06007903 RID: 30979 RVA: 0x0032AB1C File Offset: 0x00328D1C
	private afr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007904 RID: 30980 RVA: 0x0032AB28 File Offset: 0x00328D28
	public afr()
	{
	}

	// Token: 0x06007905 RID: 30981 RVA: 0x0032AB34 File Offset: 0x00328D34
	protected override void bf()
	{
		base.bf();
		cd1 cd = base.c().aa().Offense.u();
		bke bke = cd.TypedDefinition;
		if (bke != null && base.c() != null && base.c().a8() != null && base.b() != null && base.b().a8() != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			cmn cmn = awq.b(base.c(), base.b(), null);
			cmn.b += base.c().aa().Offense.an();
			cmn.j = nd.a;
			double num = awq.a(base.vg().e(), base.b(), 0.0);
			efk a_ = base.c().aa();
			efk a_2 = base.b().aa();
			cmn a_3 = cmn;
			double a_4 = 0.0;
			double a_5 = num;
			cwt cwt = euf.a(a_, a_2, a_3, a_4, null, a_5, null, true);
			cwt.f.Clear();
			bke = (bke.tw() as bke);
			bke.a(bhx.c);
			bke.a(esu.d);
			cd = new cd1(new IndependentItemDefinitionProvider<bke>(bke));
			cwt.e = false;
			cwt.f.Add(euf.a(nd.b, 1.0));
			cwt.g.Clear();
			cwt.k = "Клеймение";
			cwt.ai = cd;
			awq.a(base.c(), base.b(), cwt, cd, this);
		}
	}

	// Token: 0x06007906 RID: 30982 RVA: 0x0032AD04 File Offset: 0x00328F04
	public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		if (A_3 == null || A_3.a == null || A_2 == null || A_1 == null || !A_2.b || A_1.aa().b(d8o.e) || A_1.aa().Passive)
		{
			return;
		}
		if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(afr.a.a.b)), new Func<csk, int>(afr.a.a.a)) > 0)
		{
			boj.a(A_1.a8(), "ExplosionSmall", 1, double.MaxValue, true, true, null, null, null, null, false);
			A_1.a8().c().a("Searing");
			if (A_1.aa().b(d8o.b | d8o.c) && !A_1.aa().d(CharacterImmunities.MindAffecting | CharacterImmunities.Fear))
			{
				c4z a_ = new c4z(nd.d * d0u.b, nd.c);
				A_1.aa().StatusEffects.a(a_, false, false, false);
			}
		}
	}

	// Token: 0x02001525 RID: 5413
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007909 RID: 30985 RVA: 0x0032AE78 File Offset: 0x00329078
		internal bool b(csk A_0)
		{
			return A_0.DamageType == DamageType.Heat;
		}

		// Token: 0x0600790A RID: 30986 RVA: 0x0032AE84 File Offset: 0x00329084
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04003087 RID: 12423
		public static readonly afr.a a = new afr.a();

		// Token: 0x04003088 RID: 12424
		public static Func<csk, bool> b;

		// Token: 0x04003089 RID: 12425
		public static Func<csk, int> c;
	}
}
