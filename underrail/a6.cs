using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001567 RID: 5479
[eiz("CX")]
[Serializable]
public sealed class a6 : d64, ISerializable
{
	// Token: 0x060079FB RID: 31227 RVA: 0x00330950 File Offset: 0x0032EB50
	private a6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060079FC RID: 31228 RVA: 0x0033095C File Offset: 0x0032EB5C
	public override CharacterState? q1()
	{
		return new CharacterState?(CharacterState.Attack2);
	}

	// Token: 0x060079FD RID: 31229 RVA: 0x00330968 File Offset: 0x0032EB68
	public a6()
	{
	}

	// Token: 0x060079FE RID: 31230 RVA: 0x00330970 File Offset: 0x0032EB70
	protected override void bf()
	{
		base.bf();
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.c() != null && base.c().a8() != null && base.b() != null && base.b().a8() != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			cmn cmn = awq.b(base.c(), base.b(), null);
			cmn.b += base.c().aa().Offense.an();
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), cmn, 0.0, null, 1.0, null, true);
			double num = fz.a(base.vg().e());
			for (int i = 0; i < cwt.f.Count; i++)
			{
				csk csk = cwt.f[i];
				if (csk.DamageType == DamageType.Mechanical)
				{
					cwt.f[i] = new csk(csk.DamageType, (int)Math.Max(1.0, (double)csk.Amount * num));
				}
			}
			cwt.k = "Калечащий удар";
			awq.a(base.c(), base.b(), cwt, cd, new a6.a(this));
		}
	}

	// Token: 0x02001568 RID: 5480
	[eiz("CXa")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x060079FF RID: 31231 RVA: 0x00330B28 File Offset: 0x0032ED28
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("CXa:P", typeof(a6)) as a6);
		}

		// Token: 0x06007A00 RID: 31232 RVA: 0x00330B50 File Offset: 0x0032ED50
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("CXa:P", this.a);
		}

		// Token: 0x06007A01 RID: 31233 RVA: 0x00330B64 File Offset: 0x0032ED64
		public a(a6 A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06007A02 RID: 31234 RVA: 0x00330B74 File Offset: 0x0032ED74
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && A_2.b && this.a.b() != null && !this.a.b().aa().Dead && A_3.a != null)
			{
				if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(a6.a.a.a.a)), new Func<csk, int>(a6.a.a.a.b)) > 0)
				{
					if (A_1.aa().b(d8o.e) || A_1.aa().d(CharacterImmunities.CriticalHits))
					{
						etm a_ = new etm(new ap9(A_1.aa()), "калечащему удару");
						bey.a(a_, A_0.aa(), A_1.aa(), A_1);
						a7v.a(a_);
						return;
					}
					cgs cgs = new cgs(fz.c);
					if (A_2.e)
					{
						cgs.Stacks = 2;
					}
					A_1.aa().StatusEffects.a(cgs, false, false, false);
					A_1.a8().c().a(Guid.NewGuid().ToString(), "KneeCrack", 1f, c9z.a, false, false);
				}
			}
		}

		// Token: 0x040030CA RID: 12490
		private a6 a;

		// Token: 0x02001569 RID: 5481
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007A05 RID: 31237 RVA: 0x00330CF0 File Offset: 0x0032EEF0
			internal bool a(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x06007A06 RID: 31238 RVA: 0x00330CFC File Offset: 0x0032EEFC
			internal int b(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x040030CB RID: 12491
			public static readonly a6.a.a a = new a6.a.a();

			// Token: 0x040030CC RID: 12492
			public static Func<csk, bool> b;

			// Token: 0x040030CD RID: 12493
			public static Func<csk, int> c;
		}
	}
}
