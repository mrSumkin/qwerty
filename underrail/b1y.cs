using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200153C RID: 5436
[eiz("SHBPBA")]
[Serializable]
public sealed class b1y : d64, ISerializable
{
	// Token: 0x0600795A RID: 31066 RVA: 0x0032D260 File Offset: 0x0032B460
	private b1y(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600795B RID: 31067 RVA: 0x0032D26C File Offset: 0x0032B46C
	public b1y()
	{
	}

	// Token: 0x0600795C RID: 31068 RVA: 0x0032D274 File Offset: 0x0032B474
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
			awq.a(base.c(), base.b(), a_3, cd, new b1y.a(this), true, null, null, null, false, false, true, null, null);
			return true;
		}
		return false;
	}

	// Token: 0x0200153D RID: 5437
	[eiz("SHBPBAa")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x0600795D RID: 31069 RVA: 0x0032D3E8 File Offset: 0x0032B5E8
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("SHBPBAa:P", typeof(b1y)) as b1y);
		}

		// Token: 0x0600795E RID: 31070 RVA: 0x0032D410 File Offset: 0x0032B610
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("SHBPBAa:P", this.a);
		}

		// Token: 0x0600795F RID: 31071 RVA: 0x0032D424 File Offset: 0x0032B624
		public a(b1y A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06007960 RID: 31072 RVA: 0x0032D438 File Offset: 0x0032B638
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && !A_1.aa().Dead && A_2.b && A_3.a != null)
			{
				if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(b1y.a.a.a.a)), new Func<csk, int>(b1y.a.a.a.b)) > 0 && this.a.vg().e() != null && this.a.vg().e().b9() is coh)
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
					int num = ezx.v;
					if (A_0 != null && A_0.aa().Feats.Contains<dt>())
					{
						num = (int)((double)num * (1.0 + global::dt.a(A_0.aa())));
					}
					ef5 a_2 = new ef5((A_0 != null) ? A_0.aa() : null, ezx.y * d0u.b, num);
					A_1.aa().StatusEffects.a(a_2, false, false, false);
				}
			}
		}

		// Token: 0x0400309F RID: 12447
		private b1y a;

		// Token: 0x0200153E RID: 5438
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007963 RID: 31075 RVA: 0x0032D608 File Offset: 0x0032B808
			internal bool a(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x06007964 RID: 31076 RVA: 0x0032D614 File Offset: 0x0032B814
			internal int b(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x040030A0 RID: 12448
			public static readonly b1y.a.a a = new b1y.a.a();

			// Token: 0x040030A1 RID: 12449
			public static Func<csk, bool> b;

			// Token: 0x040030A2 RID: 12450
			public static Func<csk, int> c;
		}
	}
}
