using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Comm;

// Token: 0x02001587 RID: 5511
[eiz("S08")]
[Serializable]
public sealed class d8f : d64, ISerializable
{
	// Token: 0x06007A71 RID: 31345 RVA: 0x00333D8C File Offset: 0x00331F8C
	private d8f(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007A72 RID: 31346 RVA: 0x00333D98 File Offset: 0x00331F98
	public d8f()
	{
	}

	// Token: 0x06007A73 RID: 31347 RVA: 0x00333DA4 File Offset: 0x00331FA4
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
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), a_, awq.a(base.c(), base.b(), null, null), 0.0, base.b().a8().l(), base.c().aa().Darkvision, cd.CurrentBullet, awq.f(base.c()), a_2, false, null, null, true, null);
			for (int i = 0; i < cwt.f.Count; i++)
			{
				if (cwt.f[i].DamageType == DamageType.Mechanical)
				{
					cwt.f[i] = new csk(DamageType.Mechanical, (int)Math.Ceiling((double)cwt.f[i].Amount * b43.a()));
				}
			}
			awq.a(base.c(), base.b(), cwt, cd, new d8f.a(this), true, null, null, null, false, false, true, null, null);
			return true;
		}
		return false;
	}

	// Token: 0x02001588 RID: 5512
	[eiz("S08a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x06007A74 RID: 31348 RVA: 0x00333F8C File Offset: 0x0033218C
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("S08a:P", typeof(d8f)) as d8f);
		}

		// Token: 0x06007A75 RID: 31349 RVA: 0x00333FB4 File Offset: 0x003321B4
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("S08a:P", this.a);
		}

		// Token: 0x06007A76 RID: 31350 RVA: 0x00333FC8 File Offset: 0x003321C8
		public a(d8f A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06007A77 RID: 31351 RVA: 0x00333FD8 File Offset: 0x003321D8
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && !A_1.aa().Dead && A_2.b && A_3.a != null)
			{
				if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(d8f.a.a.a.a)), new Func<csk, int>(d8f.a.a.a.b)) > 0 && this.a.vg().e() != null)
				{
					coh coh = this.a.vg().e().b9() as coh;
					if (coh != null)
					{
						if (A_1.aa().Passive || A_1.aa().b(d8o.e) || A_1.aa().d(CharacterImmunities.Incapacitation | CharacterImmunities.Poison))
						{
							if (A_0 != null)
							{
								etm a_ = new etm(new ap9(A_1.aa()), "транквилизатору");
								bey.a(a_, A_0.aa(), A_1.aa(), A_1);
								a7v.a(a_);
							}
							bmj.a(A_1.a8(), new ba0());
							return;
						}
						int num = b43.b(coh);
						int num2 = b43.a(coh);
						double num3 = euf.d(A_1.aa(), Math.Max(0.2, 1.0 - 0.2 * (double)num2));
						cjy a_2 = new cjy((int)Math.Max(1.0, (double)num * (1.0 - num3)) * d0u.b);
						A_1.aa().StatusEffects.a(a_2, false, false, false);
						if (A_1.a8() != null && A_1.a8().t.b != null)
						{
							A_1.a8().t.b.ah();
						}
						if (A_0.aa() is e3q && !(A_1.aa() is e3q))
						{
							cxc.a(eyy.b0);
						}
						if (!A_1.aa().SpecialStates.a && !A_1.aa().SpecialStates.h)
						{
							a20.a(A_1.a8(), new ap9(this.a.vg().e().b8()), new CombatSpeakEvent[]
							{
								CombatSpeakEvent.Hit_Tranquilized
							});
						}
					}
				}
			}
		}

		// Token: 0x040030F8 RID: 12536
		private d8f a;

		// Token: 0x02001589 RID: 5513
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007A7A RID: 31354 RVA: 0x00334270 File Offset: 0x00332470
			internal bool a(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x06007A7B RID: 31355 RVA: 0x0033427C File Offset: 0x0033247C
			internal int b(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x040030F9 RID: 12537
			public static readonly d8f.a.a a = new d8f.a.a();

			// Token: 0x040030FA RID: 12538
			public static Func<csk, bool> b;

			// Token: 0x040030FB RID: 12539
			public static Func<csk, int> c;
		}
	}
}
