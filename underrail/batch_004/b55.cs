using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200137B RID: 4987
[eiz("BP03")]
[bs6("HFX:BlindingPoison")]
[Serializable]
public sealed class b55 : cpl, ISerializable
{
	// Token: 0x060070F7 RID: 28919 RVA: 0x002F7150 File Offset: 0x002F5350
	private b55(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060070F8 RID: 28920 RVA: 0x002F715C File Offset: 0x002F535C
	public b55()
	{
	}

	// Token: 0x060070F9 RID: 28921 RVA: 0x002F7164 File Offset: 0x002F5364
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.b() == null || base.agu() == null || base.b() == null || base.b().aa() == null || base.b().aa().Dead)
		{
			return dc4.e;
		}
		if (!base.agw().b || base.agy() == null || base.agy().a == null || base.agw().c.GetValueOrDefault())
		{
			return dc4.c;
		}
		if (Enumerable.Sum<csk>(Enumerable.Where<csk>(base.agy().a, new Func<csk, bool>(b55.a.a.a)), new Func<csk, int>(b55.a.a.b)) > 0)
		{
			if (base.b().aa().Passive || base.b().aa().b(d8o.e) || base.b().aa().d(CharacterImmunities.Poison))
			{
				if (base.a() != null)
				{
					etm a_ = new etm(new ap9(base.b().aa()), "яду");
					bey.a(a_, base.a().aa(), base.b().aa(), base.b());
					a7v.a(a_);
				}
				bmj.a(base.b().a8(), new ba0());
			}
			else
			{
				double num = euf.d(base.b().aa(), 1.0);
				int num2 = (int)Math.Max(1.0, (double)ezx.o * (1.0 - num));
				int num3 = ezx.l;
				if (base.a() != null && base.a().aa().Feats.Contains<dt>())
				{
					num3 = (int)((double)num3 * (1.0 + global::dt.a(base.a().aa())));
				}
				vs a_2 = new vs(base.a().aa(), num2 * d0u.b, num3);
				base.b().aa().StatusEffects.a(a_2, false, false, false);
			}
		}
		return dc4.c;
	}

	// Token: 0x0200137C RID: 4988
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060070FC RID: 28924 RVA: 0x002F73D8 File Offset: 0x002F55D8
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x060070FD RID: 28925 RVA: 0x002F73E4 File Offset: 0x002F55E4
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E30 RID: 11824
		public static readonly b55.a a = new b55.a();

		// Token: 0x04002E31 RID: 11825
		public static Func<csk, bool> b;

		// Token: 0x04002E32 RID: 11826
		public static Func<csk, int> c;
	}
}
