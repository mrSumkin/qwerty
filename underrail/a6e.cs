using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001573 RID: 5491
[eiz("S28")]
[Serializable]
public sealed class a6e : d64, ISerializable
{
	// Token: 0x06007A27 RID: 31271 RVA: 0x00331828 File Offset: 0x0032FA28
	private a6e(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007A28 RID: 31272 RVA: 0x00331834 File Offset: 0x0032FA34
	public a6e()
	{
	}

	// Token: 0x06007A29 RID: 31273 RVA: 0x0033183C File Offset: 0x0032FA3C
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
			cwt.x = AmmoType.SerratedBolts;
			awq.a(base.c(), base.b(), cwt, cd, new a6e.a(this), true, null, "serratedBolt", null, false, false, true, null, null);
			return true;
		}
		return false;
	}

	// Token: 0x02001574 RID: 5492
	[eiz("S28a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x06007A2A RID: 31274 RVA: 0x003319C0 File Offset: 0x0032FBC0
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("S28a:P", typeof(a6e)) as a6e);
		}

		// Token: 0x06007A2B RID: 31275 RVA: 0x003319E8 File Offset: 0x0032FBE8
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("S28a:P", this.a);
		}

		// Token: 0x06007A2C RID: 31276 RVA: 0x003319FC File Offset: 0x0032FBFC
		public a(a6e A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06007A2D RID: 31277 RVA: 0x00331A10 File Offset: 0x0032FC10
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && !A_1.aa().Passive && !A_1.aa().b(d8o.e) && !A_1.aa().d(CharacterImmunities.Bleeding) && A_2.b && A_3.a != null && A_3.a.Count > 0)
			{
				int num = Enumerable.Sum<csk>(A_3.a, new Func<csk, int>(a6e.a.a.a.a));
				if (num > 0)
				{
					int a_ = (int)Math.Max(emf.a * (double)num / (double)emf.b, 1.0);
					a5e a_2 = new a5e((A_0 != null) ? A_0.aa().FactionId : null, emf.b * d0u.b, a_, "bleedingWound", (A_0 != null) ? A_0.aa().Offense.u() : null);
					A_1.aa().StatusEffects.a(a_2, false, false, false);
					awq.c(A_0, A_1);
				}
			}
		}

		// Token: 0x040030D9 RID: 12505
		private a6e a;

		// Token: 0x02001575 RID: 5493
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007A30 RID: 31280 RVA: 0x00331B54 File Offset: 0x0032FD54
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x040030DA RID: 12506
			public static readonly a6e.a.a a = new a6e.a.a();

			// Token: 0x040030DB RID: 12507
			public static Func<csk, int> b;
		}
	}
}
