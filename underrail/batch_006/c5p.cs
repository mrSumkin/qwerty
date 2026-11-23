using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001363 RID: 4963
[eiz("HAL0")]
[bs6("HFX:Hyperallergenic")]
[Serializable]
public sealed class c5p : cpl, ISerializable
{
	// Token: 0x0600708D RID: 28813 RVA: 0x002F45D0 File Offset: 0x002F27D0
	private c5p(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600708E RID: 28814 RVA: 0x002F45DC File Offset: 0x002F27DC
	public c5p()
	{
	}

	// Token: 0x0600708F RID: 28815 RVA: 0x002F45E8 File Offset: 0x002F27E8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.b() == null || base.agu() == null || base.b() == null || base.b().aa() == null || base.b().aa().Dead)
		{
			return dc4.e;
		}
		if (base.agw().b && !base.agw().c.GetValueOrDefault() && !base.b().aa().Passive && !base.b().aa().b(d8o.e) && !base.b().aa().d(CharacterImmunities.Poison) && base.agy() != null && base.agy().a != null)
		{
			if (Enumerable.Sum<csk>(Enumerable.Where<csk>(base.agy().a, new Func<csk, bool>(c5p.a.a.a)), new Func<csk, int>(c5p.a.a.b)) > 0)
			{
				int a_ = euf.n(base.b().aa());
				int a_2 = (int)(80.0 - 40.0 * euf.c(a_, base.b().aa()));
				bek a_3 = new bek(bek.c * d0u.b, a_2);
				base.b().aa().StatusEffects.a(a_3, false, false, false);
			}
		}
		return dc4.c;
	}

	// Token: 0x02001365 RID: 4965
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060070A8 RID: 28840 RVA: 0x002F4BF8 File Offset: 0x002F2DF8
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x060070A9 RID: 28841 RVA: 0x002F4C04 File Offset: 0x002F2E04
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E16 RID: 11798
		public static readonly c5p.a a = new c5p.a();

		// Token: 0x04002E17 RID: 11799
		public static Func<csk, bool> b;

		// Token: 0x04002E18 RID: 11800
		public static Func<csk, int> c;
	}
}
