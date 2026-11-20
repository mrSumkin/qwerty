using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200156D RID: 5485
[eiz("SCPB1")]
[Serializable]
public sealed class azk : d64, ISerializable
{
	// Token: 0x06007A11 RID: 31249 RVA: 0x003310BC File Offset: 0x0032F2BC
	private azk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007A12 RID: 31250 RVA: 0x003310C8 File Offset: 0x0032F2C8
	public azk()
	{
	}

	// Token: 0x06007A13 RID: 31251 RVA: 0x003310D4 File Offset: 0x0032F2D4
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
			awq.a(base.c(), base.b(), a_3, cd, new azk.a(this), true, null, null, null, false, false, true, null, null);
			return true;
		}
		return false;
	}

	// Token: 0x0200156E RID: 5486
	[eiz("SCPB1a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x06007A14 RID: 31252 RVA: 0x00331248 File Offset: 0x0032F448
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("SCPB1a:P", typeof(azk)) as azk);
		}

		// Token: 0x06007A15 RID: 31253 RVA: 0x00331270 File Offset: 0x0032F470
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("SCPB1a:P", this.a);
		}

		// Token: 0x06007A16 RID: 31254 RVA: 0x00331284 File Offset: 0x0032F484
		public a(azk A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06007A17 RID: 31255 RVA: 0x00331298 File Offset: 0x0032F498
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && !A_1.aa().Dead && A_2.b && A_3.a != null)
			{
				if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(azk.a.a.a.a)), new Func<csk, int>(azk.a.a.a.b)) > 0 && this.a.vg().e() != null && this.a.vg().e().b9() is coh)
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
					int num = ezx.e;
					if (A_0 != null && A_0.aa().Feats.Contains<dt>())
					{
						num = (int)((double)num * (1.0 + global::dt.a(A_0.aa())));
					}
					ddr a_2 = new ddr((A_0 != null) ? A_0.aa() : null, ezx.d * d0u.b, num);
					A_1.aa().StatusEffects.a(a_2, false, false, false);
				}
			}
		}

		// Token: 0x040030D1 RID: 12497
		private azk a;

		// Token: 0x0200156F RID: 5487
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007A1A RID: 31258 RVA: 0x00331468 File Offset: 0x0032F668
			internal bool a(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x06007A1B RID: 31259 RVA: 0x00331474 File Offset: 0x0032F674
			internal int b(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x040030D2 RID: 12498
			public static readonly azk.a.a a = new azk.a.a();

			// Token: 0x040030D3 RID: 12499
			public static Func<csk, bool> b;

			// Token: 0x040030D4 RID: 12500
			public static Func<csk, int> c;
		}
	}
}
