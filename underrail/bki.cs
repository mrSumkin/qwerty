using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020013C5 RID: 5061
[eiz("B59")]
[bs6("HFX:BurrowerPoison")]
[Serializable]
public sealed class bki : cpl, ISerializable
{
	// Token: 0x060071FD RID: 29181 RVA: 0x002FE440 File Offset: 0x002FC640
	private bki(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060071FE RID: 29182 RVA: 0x002FE44C File Offset: 0x002FC64C
	public bki()
	{
	}

	// Token: 0x060071FF RID: 29183 RVA: 0x002FE458 File Offset: 0x002FC658
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
		if (Enumerable.Sum<csk>(Enumerable.Where<csk>(base.agy().a, new Func<csk, bool>(bki.a.a.a)), new Func<csk, int>(bki.a.a.b)) > 0)
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
				string a_2 = "BurrowerPoison";
				string a_3 = "Яд могильщика";
				int num2 = Convert.ToInt32(Math.Max(1.0, (double)d6b.b * (1.0 - num)));
				int num3 = d6b.a;
				if (base.a() != null && base.a().aa().Feats.Contains<dt>())
				{
					num3 = (int)((double)num3 * (1.0 + global::dt.a(base.a().aa())));
				}
				c2b a_4 = new c2b(base.a().aa(), a_2, a_3, num2 * d0u.b, num3, d6b.c);
				base.b().aa().StatusEffects.a(a_4, false, false, false);
			}
		}
		return dc4.c;
	}

	// Token: 0x020013C6 RID: 5062
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007202 RID: 29186 RVA: 0x002FE6E8 File Offset: 0x002FC8E8
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x06007203 RID: 29187 RVA: 0x002FE6F4 File Offset: 0x002FC8F4
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E83 RID: 11907
		public static readonly bki.a a = new bki.a();

		// Token: 0x04002E84 RID: 11908
		public static Func<csk, bool> b;

		// Token: 0x04002E85 RID: 11909
		public static Func<csk, int> c;
	}
}
