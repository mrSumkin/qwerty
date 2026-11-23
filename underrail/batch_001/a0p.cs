using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001546 RID: 5446
[eiz("CAX4")]
[Serializable]
public sealed class a0p : d64, ISerializable
{
	// Token: 0x06007980 RID: 31104 RVA: 0x0032DEF0 File Offset: 0x0032C0F0
	private a0p(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007981 RID: 31105 RVA: 0x0032DEFC File Offset: 0x0032C0FC
	public override CharacterState? q1()
	{
		return new CharacterState?(CharacterState.Attack2);
	}

	// Token: 0x06007982 RID: 31106 RVA: 0x0032DF08 File Offset: 0x0032C108
	public a0p()
	{
	}

	// Token: 0x06007983 RID: 31107 RVA: 0x0032DF14 File Offset: 0x0032C114
	protected override void bf()
	{
		base.bf();
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			cmn cmn = awq.b(base.c(), base.b(), null);
			cmn.b += 0.5;
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), cmn, 0.0, null, 1.0, null, true);
			cwt.o = 0.4;
			cwt.k = "Удар в прыжке";
			awq.a(base.c(), base.b(), cwt, cd, new a0p.a());
		}
	}

	// Token: 0x02001547 RID: 5447
	[eiz("CAX4a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x06007984 RID: 31108 RVA: 0x0032E018 File Offset: 0x0032C218
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
		}

		// Token: 0x06007985 RID: 31109 RVA: 0x0032E020 File Offset: 0x0032C220
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06007986 RID: 31110 RVA: 0x0032E024 File Offset: 0x0032C224
		public a()
		{
		}

		// Token: 0x06007987 RID: 31111 RVA: 0x0032E030 File Offset: 0x0032C230
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && A_1.a8() != null && A_2.b && !A_1.aa().c(d8o.e) && !A_1.aa().Passive && A_3.a != null)
			{
				if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(a0p.a.a.a.b)), new Func<csk, int>(a0p.a.a.a.a)) > 0)
				{
					if (A_1.aa().d(CharacterImmunities.Unbalancing))
					{
						etm a_ = new etm(new ap9(A_1.aa()), "неустойчивости");
						bey.a(a_, A_0.aa(), A_1.aa(), A_1);
						a7v.a(a_);
						bmj.a(A_1.a8(), new ba0());
						return;
					}
					elk a_2 = new elk(2 * d0u.b);
					A_1.aa().StatusEffects.a(a_2, false, false, false);
				}
			}
		}

		// Token: 0x02001548 RID: 5448
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x0600798A RID: 31114 RVA: 0x0032E16C File Offset: 0x0032C36C
			internal bool b(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x0600798B RID: 31115 RVA: 0x0032E178 File Offset: 0x0032C378
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x040030AB RID: 12459
			public static readonly a0p.a.a a = new a0p.a.a();

			// Token: 0x040030AC RID: 12460
			public static Func<csk, bool> b;

			// Token: 0x040030AD RID: 12461
			public static Func<csk, int> c;
		}
	}
}
