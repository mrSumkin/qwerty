using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200138A RID: 5002
[eiz("IND")]
[bs6("HFX:intimidate")]
[Serializable]
public sealed class cjm : cpl, ISerializable
{
	// Token: 0x0600712A RID: 28970 RVA: 0x002F81D4 File Offset: 0x002F63D4
	private cjm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600712B RID: 28971 RVA: 0x002F81E0 File Offset: 0x002F63E0
	public cjm()
	{
	}

	// Token: 0x0600712C RID: 28972 RVA: 0x002F81EC File Offset: 0x002F63EC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.b() == null || base.agu() == null || base.b() == null || base.b().aa() == null || base.b().aa().Dead)
		{
			return dc4.e;
		}
		if (!base.agw().b || base.agw().c.GetValueOrDefault())
		{
			return dc4.c;
		}
		if (base.agy().a != null)
		{
			if (Enumerable.Sum<csk>(base.agy().a, new Func<csk, int>(cjm.a.a.a)) > 0 && !base.b().aa().Passive && !base.b().aa().b(d8o.e))
			{
				if (base.b().aa().d(CharacterImmunities.Fear))
				{
					etm a_ = new etm(new ap9(base.b().aa()), "запугиванию");
					bey.a(a_, base.agw(), base.b());
					a7v.a(a_);
					bmj.a(base.b().a8(), new ba0());
				}
				else
				{
					int a_2 = euf.n(base.b().aa());
					if (euf.f(a_2, base.b().aa()))
					{
						c6f a_3 = new c6f(new ap9(base.b().aa()), new ap9(base.a().aa()), "запугиванию");
						bey.a(a_3, base.a().aa(), base.b().aa(), base.b());
						a7v.a(a_3);
						bmj.a(base.b().a8(), new dym());
					}
					else
					{
						double num = euf.d(a_2, base.b().aa());
						int a_4 = (int)d05.b((double)d0u.b, Math.Ceiling((1.0 - num) * (double)ano.a * (double)d0u.b / (double)d0u.b) * (double)d0u.b, (double)(ano.a * d0u.b));
						base.b().aa().StatusEffects.a(new ef2(a_4, base.agu().Power), false, false, false);
					}
				}
			}
		}
		return dc4.c;
	}

	// Token: 0x0200138B RID: 5003
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600712F RID: 28975 RVA: 0x002F846C File Offset: 0x002F666C
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E42 RID: 11842
		public static readonly cjm.a a = new cjm.a();

		// Token: 0x04002E43 RID: 11843
		public static Func<csk, int> b;
	}
}
