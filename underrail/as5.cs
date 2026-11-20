using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001398 RID: 5016
[eiz("HB6")]
[bs6("HFX:HeartbreakPoison")]
[Serializable]
public sealed class as5 : cpl, ISerializable
{
	// Token: 0x06007159 RID: 29017 RVA: 0x002F95AC File Offset: 0x002F77AC
	private as5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600715A RID: 29018 RVA: 0x002F95B8 File Offset: 0x002F77B8
	public as5()
	{
	}

	// Token: 0x0600715B RID: 29019 RVA: 0x002F95C4 File Offset: 0x002F77C4
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
		int num = Enumerable.Sum<csk>(Enumerable.Where<csk>(base.agy().a, new Func<csk, bool>(as5.a.a.a)), new Func<csk, int>(as5.a.a.b));
		int num2 = Enumerable.Sum<csk>(Enumerable.Where<csk>(base.agy().a, new Func<csk, bool>(as5.a.a.c)), new Func<csk, int>(as5.a.a.d));
		if (num > 0 || num2 > 0)
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
				int num3 = ezx.v;
				if (base.a() != null && base.a().aa().Feats.Contains<dt>())
				{
					num3 = (int)((double)num3 * (1.0 + global::dt.a(base.a().aa())));
				}
				ef5 a_2 = new ef5(base.a().aa(), ezx.y * d0u.b, num3);
				base.b().aa().StatusEffects.a(a_2, false, false, false);
			}
		}
		return dc4.c;
	}

	// Token: 0x02001399 RID: 5017
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600715E RID: 29022 RVA: 0x002F9860 File Offset: 0x002F7A60
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x0600715F RID: 29023 RVA: 0x002F986C File Offset: 0x002F7A6C
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x06007160 RID: 29024 RVA: 0x002F9878 File Offset: 0x002F7A78
		internal bool c(csk A_0)
		{
			return A_0.DamageType == DamageType.Bio;
		}

		// Token: 0x06007161 RID: 29025 RVA: 0x002F9884 File Offset: 0x002F7A84
		internal int d(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E4D RID: 11853
		public static readonly as5.a a = new as5.a();

		// Token: 0x04002E4E RID: 11854
		public static Func<csk, bool> b;

		// Token: 0x04002E4F RID: 11855
		public static Func<csk, int> c;

		// Token: 0x04002E50 RID: 11856
		public static Func<csk, bool> d;

		// Token: 0x04002E51 RID: 11857
		public static Func<csk, int> e;
	}
}
