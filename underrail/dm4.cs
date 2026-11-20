using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200158E RID: 5518
[eiz("R9")]
[Serializable]
public sealed class dm4 : d64, ISerializable
{
	// Token: 0x06007A8D RID: 31373 RVA: 0x00334F60 File Offset: 0x00333160
	private dm4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007A8E RID: 31374 RVA: 0x00334F6C File Offset: 0x0033316C
	public dm4()
	{
	}

	// Token: 0x06007A8F RID: 31375 RVA: 0x00334F78 File Offset: 0x00333178
	protected override void bf()
	{
		base.bf();
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), awq.b(base.c(), base.b(), null), 0.0, null, 1.0, null, true);
			cwt.k = "Rend";
			dm4.a a_ = new dm4.a();
			awq.a(base.c(), base.b(), cwt, cd, a_);
		}
	}

	// Token: 0x0200158F RID: 5519
	[eiz("R9A")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x06007A90 RID: 31376 RVA: 0x00335058 File Offset: 0x00333258
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
		}

		// Token: 0x06007A91 RID: 31377 RVA: 0x00335060 File Offset: 0x00333260
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06007A92 RID: 31378 RVA: 0x00335064 File Offset: 0x00333264
		public a()
		{
		}

		// Token: 0x06007A93 RID: 31379 RVA: 0x00335070 File Offset: 0x00333270
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && A_1.a8() != null && A_2.b)
			{
				c5x a_ = A_1.a8();
				string a_2 = "Rend";
				int a_3 = 1;
				double maxValue = double.MaxValue;
				bool a_4 = true;
				bool a_5 = true;
				float? a_6 = dz6.b();
				boj.a(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false);
				A_1.a8().c().a(Guid.NewGuid().ToString(), "Разрывание", 1f, c9z.a, false, false);
				if (A_3.a != null)
				{
					int num = Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(dm4.a.a.a.b)), new Func<csk, int>(dm4.a.a.a.a));
					if (num > 0)
					{
						if (A_1.aa().c(d8o.e) || A_1.aa().a(CharacterImmunities.Bleeding))
						{
							etm a_7 = new etm(new ap9(A_1.aa()), "кровотечению");
							bey.a(a_7, A_0.aa(), A_1.aa(), A_1);
							a7v.a(a_7);
							bmj.a(A_1.a8(), new ba0());
							return;
						}
						double num2 = (double)num / 5.0;
						if (num2 < 1.0)
						{
							num2 = 1.0;
						}
						a5e a_8 = new a5e((A_0 != null) ? A_0.aa().FactionId : null, 5 * d0u.b, (int)num2, "bleedingWound", null);
						A_1.aa().StatusEffects.a(a_8, false, false, false);
						awq.c(A_0, A_1);
					}
				}
			}
		}

		// Token: 0x02001590 RID: 5520
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007A96 RID: 31382 RVA: 0x00335268 File Offset: 0x00333468
			internal bool b(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x06007A97 RID: 31383 RVA: 0x00335274 File Offset: 0x00333474
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x04003102 RID: 12546
			public static readonly dm4.a.a a = new dm4.a.a();

			// Token: 0x04003103 RID: 12547
			public static Func<csk, bool> b;

			// Token: 0x04003104 RID: 12548
			public static Func<csk, int> c;
		}
	}
}
