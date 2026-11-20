using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200152A RID: 5418
[eiz("SWAC")]
[Serializable]
public sealed class e7h : d64, ISerializable
{
	// Token: 0x0600791A RID: 31002 RVA: 0x0032B33C File Offset: 0x0032953C
	private e7h(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600791B RID: 31003 RVA: 0x0032B348 File Offset: 0x00329548
	public e7h()
	{
	}

	// Token: 0x0600791C RID: 31004 RVA: 0x0032B350 File Offset: 0x00329550
	protected override void bf()
	{
		base.bf();
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.c() != null && base.c().a8() != null)
		{
			base.c().a8().c().a("Xpbl_SweepAttack");
			boj.a(base.c().a8(), "SweepAttackBack", 1, double.MaxValue, false, true, null, null, null, null, false);
			boj.a(base.c().a8(), "SweepAttackFront", 1, double.MaxValue, false, true, null, null, null, null, false);
			List<amc> list = aw1.a(base.c().a8(), 1);
			foreach (amc amc in aw1.a(base.c().a8(), 2))
			{
				if (!list.Contains(amc) && aw1.b(base.c().a8(), amc.a8()) <= 1.5)
				{
					list.Add(amc);
				}
			}
			bool flag = false;
			double num = 0.0;
			ert ert = Enumerable.FirstOrDefault<ert>(base.c().aa().StatusEffects.Get<ert>());
			if (ert != null)
			{
				num = ert.c * (double)ert.Stacks;
			}
			foreach (amc amc2 in list)
			{
				if (base.c().a(amc2) == h.a && amc2.a8() != null && amc2.a8().j == cgy.b && !amc2.aa().Dead)
				{
					cmn cmn = awq.b(base.c(), amc2, null);
					cmn.b += base.c().aa().Offense.an() + num;
					cwt cwt = euf.a(base.c().aa(), amc2.aa(), cmn, 0.0, null, 1.0, null, true);
					double num2 = d2g.a(base.vg().e());
					for (int i = 0; i < cwt.f.Count; i++)
					{
						csk csk = cwt.f[i];
						if (csk.DamageType == DamageType.Mechanical)
						{
							cwt.f[i] = new csk(csk.DamageType, (int)Math.Max(1.0, (double)csk.Amount * num2));
						}
					}
					cwt.k = "Подсечение";
					awq.a(base.c(), amc2, cwt, cd, new e7h.a());
					flag = true;
				}
			}
			if (flag)
			{
				erk microfeat = base.c().aa().GetMicrofeat<erk>();
				if (microfeat != null)
				{
					ert a_ = new ert(microfeat.a());
					base.c().aa().StatusEffects.a(a_, false, false, false);
				}
			}
		}
	}

	// Token: 0x0200152B RID: 5419
	[eiz("SWACa")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x0600791D RID: 31005 RVA: 0x0032B724 File Offset: 0x00329924
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
		}

		// Token: 0x0600791E RID: 31006 RVA: 0x0032B72C File Offset: 0x0032992C
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x0600791F RID: 31007 RVA: 0x0032B730 File Offset: 0x00329930
		public a()
		{
		}

		// Token: 0x06007920 RID: 31008 RVA: 0x0032B73C File Offset: 0x0032993C
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && A_2.b && A_1 != null && !A_1.aa().Dead && !A_1.aa().c(d8o.e) && !A_1.aa().Passive)
			{
				int num;
				if (A_3.b == null)
				{
					num = 0;
				}
				else
				{
					num = Enumerable.Sum<csk>(A_3.b, new Func<csk, int>(e7h.a.a.a.a));
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
					if (!A_1.aa().SpecialStates.k)
					{
						elk a_2 = new elk(Convert.ToInt32(d2g.a(A_0.aa()) * (double)d0u.b));
						A_1.aa().StatusEffects.a(a_2, false, false, false);
					}
				}
			}
		}

		// Token: 0x0200152C RID: 5420
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007923 RID: 31011 RVA: 0x0032B888 File Offset: 0x00329A88
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x0400308F RID: 12431
			public static readonly e7h.a.a a = new e7h.a.a();

			// Token: 0x04003090 RID: 12432
			public static Func<csk, int> b;
		}
	}
}
