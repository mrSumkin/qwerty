using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001558 RID: 5464
[eiz("CAX1")]
[Serializable]
public sealed class ew : d64, ISerializable
{
	// Token: 0x060079C2 RID: 31170 RVA: 0x0032F3E8 File Offset: 0x0032D5E8
	private ew(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060079C3 RID: 31171 RVA: 0x0032F3F4 File Offset: 0x0032D5F4
	public override CharacterState? q1()
	{
		return new CharacterState?(CharacterState.FinishPsi);
	}

	// Token: 0x060079C4 RID: 31172 RVA: 0x0032F3FC File Offset: 0x0032D5FC
	public ew()
	{
	}

	// Token: 0x060079C5 RID: 31173 RVA: 0x0032F404 File Offset: 0x0032D604
	protected override void bf()
	{
		base.bf();
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			cmn cmn = awq.b(base.c(), base.b(), null);
			da6 da = Enumerable.FirstOrDefault<da6>(base.c().aa().StatusEffects.Get<da6>());
			if (da != null)
			{
				cmn.b += da.BonusDamage;
				base.c().aa().StatusEffects.d(da);
			}
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), cmn, 0.0, null, 1.0, null, true);
			cwt.k = "Напор";
			enp a_ = null;
			if (da.Stun)
			{
				a_ = new ew.a();
			}
			awq.a(base.c(), base.b(), cwt, cd, a_);
		}
	}

	// Token: 0x02001559 RID: 5465
	[eiz("CAX1a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x060079C6 RID: 31174 RVA: 0x0032F544 File Offset: 0x0032D744
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
		}

		// Token: 0x060079C7 RID: 31175 RVA: 0x0032F54C File Offset: 0x0032D74C
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x060079C8 RID: 31176 RVA: 0x0032F550 File Offset: 0x0032D750
		public a()
		{
		}

		// Token: 0x060079C9 RID: 31177 RVA: 0x0032F558 File Offset: 0x0032D758
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && A_1.a8() != null && A_2.b && A_3.a != null)
			{
				if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(ew.a.a.a.b)), new Func<csk, int>(ew.a.a.a.a)) > 0)
				{
					if (A_1.aa().c(d8o.e) || A_1.aa().a(CharacterImmunities.Stun))
					{
						etm a_ = new etm(new ap9(A_1.aa()), "эффекту оглушения");
						bey.a(a_, A_0.aa(), A_1.aa(), A_1);
						a7v.a(a_);
						bmj.a(A_1.a8(), new ba0());
						return;
					}
					if (euf.l(A_1.aa()))
					{
						c6f a_2 = new c6f(new ap9(A_1.aa()), (A_0 != null) ? new ap9(A_0.aa()) : null, "оглушению");
						bey.a(a_2, A_2, A_1);
						a7v.a(a_2);
						bmj.a(A_1.a8(), new dym());
						return;
					}
					string str;
					els els = awq.a(A_1.aa(), d0u.b, out str);
					A_1.aa().StatusEffects.a(els, false, false, false);
					vr a_3 = new vr(new ap9(A_1.aa()), (A_0 != null) ? new ap9(A_0.aa()) : null, "{0}: " + str + ".", new Color?(adi.j), null);
					A_1.a8().c().a(Guid.NewGuid().ToString(), "Stun", 1f, c9z.a, false, false);
					bey.a(a_3, A_2, A_1);
					a7v.a(a_3);
					if (A_0.aa() is e3q && !(A_1.aa() is e3q) && els is ab3)
					{
						cxc.a(eyy.by);
					}
				}
			}
		}

		// Token: 0x0200155A RID: 5466
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x060079CC RID: 31180 RVA: 0x0032F798 File Offset: 0x0032D998
			internal bool b(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x060079CD RID: 31181 RVA: 0x0032F7A4 File Offset: 0x0032D9A4
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x040030C2 RID: 12482
			public static readonly ew.a.a a = new ew.a.a();

			// Token: 0x040030C3 RID: 12483
			public static Func<csk, bool> b;

			// Token: 0x040030C4 RID: 12484
			public static Func<csk, int> c;
		}
	}
}
