using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001385 RID: 4997
[eiz("B59B")]
[bs6("HFX:CrawlerPoison")]
[Serializable]
public sealed class c8k : cpl, ISerializable
{
	// Token: 0x06007119 RID: 28953 RVA: 0x002F7B6C File Offset: 0x002F5D6C
	private c8k(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600711A RID: 28954 RVA: 0x002F7B78 File Offset: 0x002F5D78
	public c8k()
	{
	}

	// Token: 0x0600711B RID: 28955 RVA: 0x002F7B84 File Offset: 0x002F5D84
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
		if (Enumerable.Sum<csk>(Enumerable.Where<csk>(base.agy().a, new Func<csk, bool>(c8k.a.a.a)), new Func<csk, int>(c8k.a.a.b)) > 0)
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
				int num = ezx.e;
				if (base.a() != null && base.a().aa().Feats.Contains<dt>())
				{
					num = (int)((double)num * (1.0 + global::dt.a(base.a().aa())));
				}
				ddr a_2 = new ddr((base.a() != null) ? base.a().aa() : null, ezx.d * d0u.b, num);
				base.b().aa().StatusEffects.a(a_2, false, false, false);
			}
		}
		return dc4.c;
	}

	// Token: 0x02001386 RID: 4998
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600711E RID: 28958 RVA: 0x002F7DD0 File Offset: 0x002F5FD0
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x0600711F RID: 28959 RVA: 0x002F7DDC File Offset: 0x002F5FDC
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E3C RID: 11836
		public static readonly c8k.a a = new c8k.a();

		// Token: 0x04002E3D RID: 11837
		public static Func<csk, bool> b;

		// Token: 0x04002E3E RID: 11838
		public static Func<csk, int> c;
	}
}
