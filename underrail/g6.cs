using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

// Token: 0x0200154C RID: 5452
[eiz("S48")]
[Serializable]
public sealed class g6 : d64, ISerializable
{
	// Token: 0x06007997 RID: 31127 RVA: 0x0032E548 File Offset: 0x0032C748
	private g6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007998 RID: 31128 RVA: 0x0032E554 File Offset: 0x0032C754
	public g6()
	{
	}

	// Token: 0x06007999 RID: 31129 RVA: 0x0032E55C File Offset: 0x0032C75C
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
			cwt.x = AmmoType.BroadheadBolts;
			awq.a(base.c(), base.b(), cwt, cd, new g6.a(this), true, null, "xpbl_broadheadBolt", null, false, false, true, null, null);
			return true;
		}
		return false;
	}

	// Token: 0x0200154D RID: 5453
	[eiz("S48a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x0600799A RID: 31130 RVA: 0x0032E6E0 File Offset: 0x0032C8E0
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("S48a:P", typeof(g6)) as g6);
		}

		// Token: 0x0600799B RID: 31131 RVA: 0x0032E708 File Offset: 0x0032C908
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("S48a:P", this.a);
		}

		// Token: 0x0600799C RID: 31132 RVA: 0x0032E71C File Offset: 0x0032C91C
		public a(g6 A_0)
		{
			this.a = A_0;
		}

		// Token: 0x0600799D RID: 31133 RVA: 0x0032E730 File Offset: 0x0032C930
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && !A_1.aa().Passive && !A_1.aa().b(d8o.e) && !A_1.aa().d(CharacterImmunities.Bleeding) && A_2.b && A_3.a != null && A_3.a.Count > 0)
			{
				int num = Enumerable.Sum<csk>(A_3.a, new Func<csk, int>(g6.a.a.a.a));
				if (num > 0)
				{
					int a_ = (int)Math.Max(bka.a * (double)num / (double)bka.b, 1.0);
					a5e a_2 = new a5e((A_0 != null) ? A_0.aa().FactionId : null, bka.b * d0u.b, a_, "bleedingWound", (A_0 != null) ? A_0.aa().Offense.u() : null);
					A_1.aa().StatusEffects.a(a_2, false, false, false);
					awq.c(A_0, A_1);
				}
			}
		}

		// Token: 0x040030B2 RID: 12466
		private g6 a;

		// Token: 0x0200154E RID: 5454
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x060079A0 RID: 31136 RVA: 0x0032E874 File Offset: 0x0032CA74
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x040030B3 RID: 12467
			public static readonly g6.a.a a = new g6.a.a();

			// Token: 0x040030B4 RID: 12468
			public static Func<csk, int> b;
		}
	}
}
