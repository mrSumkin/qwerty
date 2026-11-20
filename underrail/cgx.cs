using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200154F RID: 5455
[eiz("SSB1")]
[Serializable]
public sealed class cgx : d64, ISerializable
{
	// Token: 0x060079A1 RID: 31137 RVA: 0x0032E880 File Offset: 0x0032CA80
	private cgx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060079A2 RID: 31138 RVA: 0x0032E88C File Offset: 0x0032CA8C
	public cgx()
	{
	}

	// Token: 0x060079A3 RID: 31139 RVA: 0x0032E898 File Offset: 0x0032CA98
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
			awq.a(base.c(), base.b(), a_3, cd, new cgx.a(this), true, null, null, null, false, false, true, null, null);
			return true;
		}
		return false;
	}

	// Token: 0x02001550 RID: 5456
	[eiz("SSB1a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x060079A4 RID: 31140 RVA: 0x0032EA0C File Offset: 0x0032CC0C
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("SSB1a:P", typeof(cgx)) as cgx);
		}

		// Token: 0x060079A5 RID: 31141 RVA: 0x0032EA34 File Offset: 0x0032CC34
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("SSB1a:P", this.a);
		}

		// Token: 0x060079A6 RID: 31142 RVA: 0x0032EA48 File Offset: 0x0032CC48
		public a(cgx A_0)
		{
			this.a = A_0;
		}

		// Token: 0x060079A7 RID: 31143 RVA: 0x0032EA5C File Offset: 0x0032CC5C
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && !A_1.aa().Dead && A_2.b && A_3.a != null)
			{
				if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(cgx.a.a.a.a)), new Func<csk, int>(cgx.a.a.a.b)) > 0 && this.a.vg().e() != null && this.a.vg().e().b9() is coh)
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
					int num = ezx.i;
					if (A_0 != null && A_0.aa().Feats.Contains<dt>())
					{
						num = (int)((double)num * (1.0 + global::dt.a(A_0.aa())));
					}
					ehp a_2 = new ehp((A_0 != null) ? A_0.aa() : null, ezx.h * d0u.b, num);
					A_1.aa().StatusEffects.a(a_2, false, false, false);
				}
			}
		}

		// Token: 0x040030B5 RID: 12469
		private cgx a;

		// Token: 0x02001551 RID: 5457
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x060079AA RID: 31146 RVA: 0x0032EC2C File Offset: 0x0032CE2C
			internal bool a(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x060079AB RID: 31147 RVA: 0x0032EC38 File Offset: 0x0032CE38
			internal int b(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x040030B6 RID: 12470
			public static readonly cgx.a.a a = new cgx.a.a();

			// Token: 0x040030B7 RID: 12471
			public static Func<csk, bool> b;

			// Token: 0x040030B8 RID: 12472
			public static Func<csk, int> c;
		}
	}
}
