using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200153F RID: 5439
[eiz("SLPBA")]
[Serializable]
public sealed class dkd : d64, ISerializable
{
	// Token: 0x06007965 RID: 31077 RVA: 0x0032D620 File Offset: 0x0032B820
	private dkd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007966 RID: 31078 RVA: 0x0032D62C File Offset: 0x0032B82C
	public dkd()
	{
	}

	// Token: 0x06007967 RID: 31079 RVA: 0x0032D634 File Offset: 0x0032B834
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
			awq.a(base.c(), base.b(), a_3, cd, new dkd.a(this), true, null, null, null, false, false, true, null, null);
			return true;
		}
		return false;
	}

	// Token: 0x02001540 RID: 5440
	[eiz("SLPBAa")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x06007968 RID: 31080 RVA: 0x0032D7A8 File Offset: 0x0032B9A8
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("SLPBAa:P", typeof(dkd)) as dkd);
		}

		// Token: 0x06007969 RID: 31081 RVA: 0x0032D7D0 File Offset: 0x0032B9D0
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("SLPBAa:P", this.a);
		}

		// Token: 0x0600796A RID: 31082 RVA: 0x0032D7E4 File Offset: 0x0032B9E4
		public a(dkd A_0)
		{
			this.a = A_0;
		}

		// Token: 0x0600796B RID: 31083 RVA: 0x0032D7F8 File Offset: 0x0032B9F8
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && !A_1.aa().Dead && A_2.b && A_3.a != null)
			{
				if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(dkd.a.a.a.a)), new Func<csk, int>(dkd.a.a.a.b)) > 0 && this.a.vg().e() != null && this.a.vg().e().b9() is coh)
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
					int num = ezx.q;
					if (A_0 != null && A_0.aa().Feats.Contains<dt>())
					{
						num = (int)((double)num * (1.0 + global::dt.a(A_0.aa())));
					}
					ab6 a_2 = new ab6((A_0 != null) ? A_0.aa() : null, ezx.t * d0u.b, num);
					A_1.aa().StatusEffects.a(a_2, false, false, false);
				}
			}
		}

		// Token: 0x040030A3 RID: 12451
		private dkd a;

		// Token: 0x02001541 RID: 5441
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x0600796E RID: 31086 RVA: 0x0032D9C8 File Offset: 0x0032BBC8
			internal bool a(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x0600796F RID: 31087 RVA: 0x0032D9D4 File Offset: 0x0032BBD4
			internal int b(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x040030A4 RID: 12452
			public static readonly dkd.a.a a = new dkd.a.a();

			// Token: 0x040030A5 RID: 12453
			public static Func<csk, bool> b;

			// Token: 0x040030A6 RID: 12454
			public static Func<csk, int> c;
		}
	}
}
