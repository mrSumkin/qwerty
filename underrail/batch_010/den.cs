using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001381 RID: 4993
[eiz("B59C")]
[bs6("HFX:BlackDragonPoison")]
[Serializable]
public sealed class den : cpl, ISerializable
{
	// Token: 0x0600710B RID: 28939 RVA: 0x002F76DC File Offset: 0x002F58DC
	private den(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600710C RID: 28940 RVA: 0x002F76E8 File Offset: 0x002F58E8
	public den()
	{
	}

	// Token: 0x0600710D RID: 28941 RVA: 0x002F76F4 File Offset: 0x002F58F4
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
		if (Enumerable.Sum<csk>(Enumerable.Where<csk>(base.agy().a, new Func<csk, bool>(den.a.a.a)), new Func<csk, int>(den.a.a.b)) > 0)
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
				dns a_2 = new dns(ezx.g * d0u.b);
				base.b().aa().StatusEffects.a(a_2, false, false, false);
			}
		}
		return dc4.c;
	}

	// Token: 0x02001382 RID: 4994
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007110 RID: 28944 RVA: 0x002F78D8 File Offset: 0x002F5AD8
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x06007111 RID: 28945 RVA: 0x002F78E4 File Offset: 0x002F5AE4
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E36 RID: 11830
		public static readonly den.a a = new den.a();

		// Token: 0x04002E37 RID: 11831
		public static Func<csk, bool> b;

		// Token: 0x04002E38 RID: 11832
		public static Func<csk, int> c;
	}
}
