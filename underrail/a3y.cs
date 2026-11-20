using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200139A RID: 5018
[eiz("LP03")]
[bs6("HFX:LeperPoison")]
[Serializable]
public sealed class a3y : cpl, ISerializable
{
	// Token: 0x06007162 RID: 29026 RVA: 0x002F9890 File Offset: 0x002F7A90
	private a3y(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007163 RID: 29027 RVA: 0x002F989C File Offset: 0x002F7A9C
	public a3y()
	{
	}

	// Token: 0x06007164 RID: 29028 RVA: 0x002F98A8 File Offset: 0x002F7AA8
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
		if (Enumerable.Sum<csk>(Enumerable.Where<csk>(base.agy().a, new Func<csk, bool>(a3y.a.a.a)), new Func<csk, int>(a3y.a.a.b)) > 0)
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
				int num2 = (int)Math.Max(1.0, (double)ezx.t * (1.0 - num));
				int num3 = ezx.q;
				if (base.a() != null && base.a().aa().Feats.Contains<dt>())
				{
					num3 = (int)((double)num3 * (1.0 + global::dt.a(base.a().aa())));
				}
				ab6 a_2 = new ab6(base.a().aa(), num2 * d0u.b, num3);
				base.b().aa().StatusEffects.a(a_2, false, false, false);
			}
		}
		return dc4.c;
	}

	// Token: 0x0200139B RID: 5019
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007167 RID: 29031 RVA: 0x002F9B1C File Offset: 0x002F7D1C
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x06007168 RID: 29032 RVA: 0x002F9B28 File Offset: 0x002F7D28
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E52 RID: 11858
		public static readonly a3y.a a = new a3y.a();

		// Token: 0x04002E53 RID: 11859
		public static Func<csk, bool> b;

		// Token: 0x04002E54 RID: 11860
		public static Func<csk, int> c;
	}
}
