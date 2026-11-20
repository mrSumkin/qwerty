using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001570 RID: 5488
[eiz("SCEP")]
[Serializable]
public sealed class b5w : d64, ISerializable
{
	// Token: 0x06007A1C RID: 31260 RVA: 0x00331480 File Offset: 0x0032F680
	private b5w(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007A1D RID: 31261 RVA: 0x0033148C File Offset: 0x0032F68C
	public b5w()
	{
	}

	// Token: 0x06007A1E RID: 31262 RVA: 0x00331494 File Offset: 0x0032F694
	protected override bool gq()
	{
		if (!base.gq())
		{
			return false;
		}
		awq.a(base.c().aa());
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			double a_ = aw1.b(base.c().a8(), base.b().a8());
			double a_2 = awq.a(base.vg().e(), base.b(), a_);
			cwt a_3 = euf.a(base.c().aa(), base.b().aa(), a_, awq.a(base.c(), base.b(), null, null), 0.0, base.b().a8().l(), base.c().aa().Darkvision, cd.CurrentBullet, awq.f(base.c()), a_2, false, null, null, true, null);
			awq.a(base.c(), base.b(), a_3, cd, new b5w.a(this), true, null, null, null, false, false, true, null, null);
			return true;
		}
		return false;
	}

	// Token: 0x02001571 RID: 5489
	[eiz("SCEPa")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x06007A1F RID: 31263 RVA: 0x00331608 File Offset: 0x0032F808
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("SCEPa:P", typeof(b5w)) as b5w);
		}

		// Token: 0x06007A20 RID: 31264 RVA: 0x00331630 File Offset: 0x0032F830
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("SCEPa:P", this.a);
		}

		// Token: 0x06007A21 RID: 31265 RVA: 0x00331644 File Offset: 0x0032F844
		public a(b5w A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06007A22 RID: 31266 RVA: 0x00331658 File Offset: 0x0032F858
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && !A_1.aa().Dead && A_2.b && A_3.a != null)
			{
				if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(b5w.a.a.a.a)), new Func<csk, int>(b5w.a.a.a.b)) > 0 && this.a.vg().e() != null)
				{
					coh coh = this.a.vg().e().b9() as coh;
					if (coh != null)
					{
						if (A_1.aa().Passive || A_1.aa().b(d8o.e) || A_1.aa().d(CharacterImmunities.Poison))
						{
							if (A_0 != null)
							{
								etm a_ = new etm(new ap9(A_1.aa()), "яду");
								bey.a(a_, A_0.aa(), A_1.aa(), A_1);
								a7v.a(a_);
							}
							bmj.a(A_1.a8(), new ba0());
							return;
						}
						double num = euf.d(A_1.aa(), 1.0);
						int num2 = cl5.d(coh);
						bhe a_2 = new bhe((int)Math.Max(1.0, (double)num2 * (1.0 - num)) * d0u.b);
						A_1.aa().StatusEffects.a(a_2, false, false, false);
					}
				}
			}
		}

		// Token: 0x040030D5 RID: 12501
		private b5w a;

		// Token: 0x02001572 RID: 5490
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007A25 RID: 31269 RVA: 0x00331810 File Offset: 0x0032FA10
			internal bool a(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x06007A26 RID: 31270 RVA: 0x0033181C File Offset: 0x0032FA1C
			internal int b(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x040030D6 RID: 12502
			public static readonly b5w.a.a a = new b5w.a.a();

			// Token: 0x040030D7 RID: 12503
			public static Func<csk, bool> b;

			// Token: 0x040030D8 RID: 12504
			public static Func<csk, int> c;
		}
	}
}
