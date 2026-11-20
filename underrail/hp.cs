using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x0200156A RID: 5482
[eiz("P73")]
[Serializable]
public sealed class hp : d64, ISerializable
{
	// Token: 0x06007A07 RID: 31239 RVA: 0x00330D08 File Offset: 0x0032EF08
	private hp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007A08 RID: 31240 RVA: 0x00330D14 File Offset: 0x0032EF14
	public hp()
	{
	}

	// Token: 0x06007A09 RID: 31241 RVA: 0x00330D20 File Offset: 0x0032EF20
	protected override void bf()
	{
		base.bf();
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.c() != null && base.c().a8() != null && base.b() != null && base.b().a8() != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			cmn cmn = awq.b(base.c(), base.b(), null);
			cmn.b += base.c().aa().Offense.an();
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), cmn, 0.0, null, 1.0, null, true);
			for (int i = 0; i < cwt.f.Count; i++)
			{
				csk csk = cwt.f[i];
				if (csk.DamageType == DamageType.Mechanical)
				{
					cwt.f[i] = new csk(csk.DamageType, (int)Math.Max(1.0, (double)csk.Amount * bho.a(base.vg().e())));
				}
			}
			cwt.x = AmmoType.None;
			hp.a a_ = null;
			if (!base.b().aa().c(d8o.e))
			{
				a_ = new hp.a(this);
			}
			cwt.k = "Избиение";
			awq.a(base.c(), base.b(), cwt, cd, a_);
		}
	}

	// Token: 0x0200156B RID: 5483
	[eiz("P73a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x06007A0A RID: 31242 RVA: 0x00330EF8 File Offset: 0x0032F0F8
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("P73a:P", typeof(hp)) as hp);
		}

		// Token: 0x06007A0B RID: 31243 RVA: 0x00330F20 File Offset: 0x0032F120
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("P73a:P", this.a);
		}

		// Token: 0x06007A0C RID: 31244 RVA: 0x00330F34 File Offset: 0x0032F134
		public a(hp A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06007A0D RID: 31245 RVA: 0x00330F44 File Offset: 0x0032F144
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (this.a.b() != null && A_2.b && this.a.b() != null && !this.a.b().aa().Dead && !A_1.aa().c(d8o.e) && !A_1.aa().Passive)
			{
				int num;
				if (A_3.b == null)
				{
					num = 0;
				}
				else
				{
					num = Enumerable.Sum<csk>(A_3.b, new Func<csk, int>(hp.a.a.a.a));
				}
				if (num > 0)
				{
					if (A_1.aa().d(CharacterImmunities.Unbalancing))
					{
						etm a_ = new etm(new ap9(A_1.aa()), "неустойчивости");
						bey.a(a_, A_0.aa(), A_1.aa(), A_1);
						a7v.a(a_);
						bmj.a(A_1.a8(), new ba0());
						return;
					}
					if (!this.a.b().aa().SpecialStates.k)
					{
						elk a_2 = new elk(bho.c);
						this.a.b().aa().StatusEffects.a(a_2, false, false, false);
					}
				}
			}
		}

		// Token: 0x040030CE RID: 12494
		private hp a;

		// Token: 0x0200156C RID: 5484
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007A10 RID: 31248 RVA: 0x003310B0 File Offset: 0x0032F2B0
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x040030CF RID: 12495
			public static readonly hp.a.a a = new hp.a.a();

			// Token: 0x040030D0 RID: 12496
			public static Func<csk, int> b;
		}
	}
}
