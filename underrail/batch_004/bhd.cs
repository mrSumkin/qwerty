using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001623 RID: 5667
public static class bhd
{
	// Token: 0x06007C8D RID: 31885 RVA: 0x00347D70 File Offset: 0x00345F70
	public static void a(amc A_0, amc A_1, List<csk> A_2, double A_3, double A_4, int A_5 = 3)
	{
		if (A_2 != null && !A_1.aa().Passive)
		{
			int num = Enumerable.Sum<csk>(Enumerable.Where<csk>(A_2, new Func<csk, bool>(bhd.a.a.b)), new Func<csk, int>(bhd.a.a.a));
			num = Convert.ToInt32((double)num * A_4);
			if (num >= A_5 && cuo.a.NextDouble() < A_3)
			{
				if (A_1.aa().d(CharacterImmunities.Burning))
				{
					etm a_ = new etm(new ap9(A_1.aa()), "burning");
					bey.a(a_, ((A_0 != null) ? A_0.aa() : null) ?? null, A_1.aa(), A_1);
					a7v.a(a_);
					bmj.a(A_1.a8(), new ba0());
				}
				else
				{
					int a_2 = num / A_5;
					bk9 bk = Enumerable.FirstOrDefault<bk9>(A_1.aa().StatusEffects.Get<bk9>());
					if (bk != null)
					{
						dd5.a(bk, ((A_0 != null) ? A_0.aa() : null) ?? null, a_2, A_5 * d0u.b);
					}
					else
					{
						bk = new bk9(((A_0 != null) ? A_0.aa() : null) ?? null, A_5 * d0u.b, a_2, true);
						A_1.aa().StatusEffects.a(bk, false, false, false);
						dd5.a(A_1.aa());
					}
					if (A_0 != null && A_0.aa() is e3q && !(A_1.aa() is e3q))
					{
						cxc.a(eyy.b1);
					}
				}
			}
		}
		awq.a(A_1, true);
	}

	// Token: 0x02001624 RID: 5668
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06007C90 RID: 31888 RVA: 0x00347F58 File Offset: 0x00346158
		internal bool b(csk A_0)
		{
			return A_0.DamageType == DamageType.Heat;
		}

		// Token: 0x06007C91 RID: 31889 RVA: 0x00347F64 File Offset: 0x00346164
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x0400317D RID: 12669
		public static readonly bhd.a a = new bhd.a();

		// Token: 0x0400317E RID: 12670
		public static Func<csk, bool> b;

		// Token: 0x0400317F RID: 12671
		public static Func<csk, int> c;
	}
}
