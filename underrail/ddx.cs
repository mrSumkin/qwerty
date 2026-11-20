using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200158A RID: 5514
[eiz("S07")]
[Serializable]
public sealed class ddx : d64, ISerializable
{
	// Token: 0x06007A7C RID: 31356 RVA: 0x00334288 File Offset: 0x00332488
	private ddx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007A7D RID: 31357 RVA: 0x00334294 File Offset: 0x00332494
	public ddx()
	{
	}

	// Token: 0x06007A7E RID: 31358 RVA: 0x0033429C File Offset: 0x0033249C
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
			awq.a(base.c(), base.b(), a_3, cd, new ddx.a(this), true, null, null, null, false, false, true, null, null);
			return true;
		}
		return false;
	}

	// Token: 0x0200158B RID: 5515
	[eiz("S07a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x06007A7F RID: 31359 RVA: 0x00334410 File Offset: 0x00332610
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("S07a:P", typeof(ddx)) as ddx);
		}

		// Token: 0x06007A80 RID: 31360 RVA: 0x00334438 File Offset: 0x00332638
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("S07a:P", this.a);
		}

		// Token: 0x06007A81 RID: 31361 RVA: 0x0033444C File Offset: 0x0033264C
		public a(ddx A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06007A82 RID: 31362 RVA: 0x00334460 File Offset: 0x00332660
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && !A_1.aa().Dead && A_2.b && A_3.a != null)
			{
				if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(ddx.a.a.a.a)), new Func<csk, int>(ddx.a.a.a.b)) > 0 && this.a.vg().e() != null)
				{
					coh coh = this.a.vg().e().b9() as coh;
					if (coh != null)
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
						double num = euf.d(A_1.aa(), 1.0);
						int num2 = cl5.d(coh);
						int a_2 = cl5.a(coh);
						int a_3 = cl5.a(coh, A_0.aa());
						string a_4 = cl5.c(coh);
						string a_5 = cl5.b(coh);
						int num3 = (int)Math.Max(1.0, (double)num2 * (1.0 - num));
						c2b a_6 = new c2b((A_0 != null) ? A_0.aa() : null, a_4, a_5, num3 * d0u.b, a_3, a_2);
						A_1.aa().StatusEffects.a(a_6, false, false, false);
					}
				}
			}
		}

		// Token: 0x040030FC RID: 12540
		private ddx a;

		// Token: 0x0200158C RID: 5516
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007A85 RID: 31365 RVA: 0x0033465C File Offset: 0x0033285C
			internal bool a(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x06007A86 RID: 31366 RVA: 0x00334668 File Offset: 0x00332868
			internal int b(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x040030FD RID: 12541
			public static readonly ddx.a.a a = new ddx.a.a();

			// Token: 0x040030FE RID: 12542
			public static Func<csk, bool> b;

			// Token: 0x040030FF RID: 12543
			public static Func<csk, int> c;
		}
	}
}
