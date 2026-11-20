using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001383 RID: 4995
[bs6("HFX:SpiritPoison")]
[eiz("B59D")]
[Serializable]
public sealed class e1r : cpl, ISerializable
{
	// Token: 0x06007112 RID: 28946 RVA: 0x002F78F0 File Offset: 0x002F5AF0
	private e1r(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007113 RID: 28947 RVA: 0x002F78FC File Offset: 0x002F5AFC
	public e1r()
	{
	}

	// Token: 0x06007114 RID: 28948 RVA: 0x002F7908 File Offset: 0x002F5B08
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
		if (Enumerable.Sum<csk>(Enumerable.Where<csk>(base.agy().a, new Func<csk, bool>(e1r.a.a.a)), new Func<csk, int>(e1r.a.a.b)) > 0)
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
				int num = ezx.i;
				if (base.a() != null && base.a().aa().Feats.Contains<dt>())
				{
					num = (int)((double)num * (1.0 + global::dt.a(base.a().aa())));
				}
				ehp a_2 = new ehp((base.a() != null) ? base.a().aa() : null, ezx.h * d0u.b, num);
				base.b().aa().StatusEffects.a(a_2, false, false, false);
			}
		}
		return dc4.c;
	}

	// Token: 0x02001384 RID: 4996
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007117 RID: 28951 RVA: 0x002F7B54 File Offset: 0x002F5D54
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x06007118 RID: 28952 RVA: 0x002F7B60 File Offset: 0x002F5D60
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E39 RID: 11833
		public static readonly e1r.a a = new e1r.a();

		// Token: 0x04002E3A RID: 11834
		public static Func<csk, bool> b;

		// Token: 0x04002E3B RID: 11835
		public static Func<csk, int> c;
	}
}
