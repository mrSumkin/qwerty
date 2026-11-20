using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020013C8 RID: 5064
[bs6("HFX:bleedingWound")]
[eiz("B61")]
[Serializable]
public sealed class si : cpl, ISerializable
{
	// Token: 0x06007207 RID: 29191 RVA: 0x002FE91C File Offset: 0x002FCB1C
	private si(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007208 RID: 29192 RVA: 0x002FE928 File Offset: 0x002FCB28
	public si()
	{
	}

	// Token: 0x06007209 RID: 29193 RVA: 0x002FE934 File Offset: 0x002FCB34
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.b() == null || base.agu() == null || base.b() == null || base.b().aa() == null || base.b().aa().Dead || base.b().aa().b(d8o.e) || base.b().aa().d(CharacterImmunities.Bleeding))
		{
			return dc4.e;
		}
		if (!base.agw().b || base.agw().c.GetValueOrDefault())
		{
			return dc4.c;
		}
		int num;
		if (base.agy() == null || base.agy().a == null)
		{
			num = 0;
		}
		else
		{
			num = Enumerable.Sum<csk>(Enumerable.Where<csk>(base.agy().a, new Func<csk, bool>(si.a.a.a)), new Func<csk, int>(si.a.a.b));
		}
		int num2 = num;
		if (num2 > 0)
		{
			int num3 = mi.b(base.agu());
			int num4 = num3 / d0u.b;
			int num5 = (int)((double)num2 * mi.a(base.agu()) / (double)num4);
			if (num5 > 0)
			{
				a5e a_ = new a5e((base.a() != null) ? base.a().aa().FactionId : null, num3, num5, "bleedingWound", base.c());
				base.b().aa().StatusEffects.a(a_, false, false, false);
				if (base.agw() != null && base.agw().ae != null)
				{
					WeaponSubtype value = base.agw().ae.Value;
					if (value != WeaponSubtype.Crossbow && (value < WeaponSubtype.Crowbar || value >= WeaponSubtype.Unarmed))
					{
						return dc4.c;
					}
				}
				awq.c(base.a(), base.b());
			}
		}
		return dc4.c;
	}

	// Token: 0x020013C9 RID: 5065
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600720C RID: 29196 RVA: 0x002FEB5C File Offset: 0x002FCD5C
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x0600720D RID: 29197 RVA: 0x002FEB68 File Offset: 0x002FCD68
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E86 RID: 11910
		public static readonly si.a a = new si.a();

		// Token: 0x04002E87 RID: 11911
		public static Func<csk, bool> b;

		// Token: 0x04002E88 RID: 11912
		public static Func<csk, int> c;
	}
}
