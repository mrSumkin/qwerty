using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Comm;

// Token: 0x02001591 RID: 5521
[eiz("KCSA")]
[Serializable]
public sealed class eat : d64, ISerializable
{
	// Token: 0x06007A98 RID: 31384 RVA: 0x00335280 File Offset: 0x00333480
	private eat(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007A99 RID: 31385 RVA: 0x0033528C File Offset: 0x0033348C
	public eat()
	{
	}

	// Token: 0x06007A9A RID: 31386 RVA: 0x00335294 File Offset: 0x00333494
	protected override bool gq()
	{
		if (!base.gq())
		{
			return false;
		}
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition == null || base.b().a8().j != cgy.b || base.b().a8().Area != base.c().a8().Area)
		{
			return false;
		}
		if (euf.k(cd))
		{
			new ec6().a(base.c(), base.b(), cd, cd.CurrentBullet, 1.0, true, 0.0, false, new eat.a(edd.b, d9w.a(base.vg().e())));
			return true;
		}
		double a_ = aw1.b(base.c().a8(), base.b().a8());
		double a_2 = awq.a(base.vg().e(), base.b(), a_);
		cmn cmn = awq.a(base.c(), base.b(), null, null);
		cmn.b += base.c().aa().Offense.an();
		cwt cwt = euf.a(base.c().aa(), base.b().aa(), a_, cmn, 0.0, base.b().a8().l(), base.c().aa().Darkvision, cd.CurrentBullet, awq.f(base.c()), a_2, false, null, null, true, null);
		cwt.k = "Выстрел в колено";
		eat.a a_3 = new eat.a(edd.b, d9w.a(base.vg().e()));
		awq.a(base.c(), base.b(), cwt, cd, a_3, true, null, null, null, false, false, true, null, null);
		return true;
	}

	// Token: 0x02001592 RID: 5522
	[eiz("KCSACB")]
	[Serializable]
	private new class a : enp, ISerializable
	{
		// Token: 0x06007A9B RID: 31387 RVA: 0x0033549C File Offset: 0x0033369C
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = A_0.GetSingle("KCSACB:BDT");
			this.b = A_0.GetInt32("KCSACB:ED");
		}

		// Token: 0x06007A9C RID: 31388 RVA: 0x003354C8 File Offset: 0x003336C8
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("KCSACB:BDT", this.a);
			info.AddValue("KCSACB:ED", this.b);
		}

		// Token: 0x06007A9D RID: 31389 RVA: 0x003354EC File Offset: 0x003336EC
		public a(int A_0, float A_1)
		{
			this.b = A_0;
			this.a = A_1;
		}

		// Token: 0x06007A9E RID: 31390 RVA: 0x00335504 File Offset: 0x00333704
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && A_2.b)
			{
				if (!A_1.aa().b(d8o.e | d8o.j) && !A_1.aa().d(CharacterImmunities.KneecapShot))
				{
					if (A_3.a != null)
					{
						int num = Enumerable.Sum<csk>(A_3.a, new Func<csk, int>(eat.a.a.a.a));
						if (num > 0)
						{
							int a_ = 0;
							if (this.a > 0f)
							{
								a_ = (int)Math.Max((float)num * this.a / (float)(this.b / d0u.b), 1f);
							}
							cui a_2 = new cui((A_0 != null) ? A_0.aa() : null, this.b, a_, A_0.aa().Offense.u());
							A_1.aa().StatusEffects.a(a_2, false, false, false);
							if (A_1.a8() != null)
							{
								A_1.a8().c().a("kneeCrack" + Guid.NewGuid().ToString(), "KneeCrack", 1f, c9z.a, false, false);
							}
							if (!A_1.aa().SpecialStates.a && !A_1.aa().SpecialStates.h)
							{
								a20.a(A_1.a8(), new ap9(A_0.aa()), new CombatSpeakEvent[]
								{
									CombatSpeakEvent.Hit_Kneecap
								});
								return;
							}
						}
					}
				}
				else
				{
					etm a_3 = new etm(new ap9(A_1.aa()), "выстрелу в колено");
					bey.a(a_3, A_0.aa(), A_1.aa(), A_1);
					a7v.a(a_3);
					bmj.a(A_1.a8(), new ba0());
				}
			}
		}

		// Token: 0x04003105 RID: 12549
		private float a;

		// Token: 0x04003106 RID: 12550
		private int b;

		// Token: 0x02001593 RID: 5523
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007AA1 RID: 31393 RVA: 0x003356F0 File Offset: 0x003338F0
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x04003107 RID: 12551
			public static readonly eat.a.a a = new eat.a.a();

			// Token: 0x04003108 RID: 12552
			public static Func<csk, int> b;
		}
	}
}
