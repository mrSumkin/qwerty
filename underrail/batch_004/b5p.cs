using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020013A9 RID: 5033
[eiz("R59")]
[bs6("HFX:RandomPoison")]
[Serializable]
public sealed class b5p : cpl, ISerializable
{
	// Token: 0x06007193 RID: 29075 RVA: 0x002FAC08 File Offset: 0x002F8E08
	private b5p(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007194 RID: 29076 RVA: 0x002FAC14 File Offset: 0x002F8E14
	public b5p()
	{
	}

	// Token: 0x06007195 RID: 29077 RVA: 0x002FAC20 File Offset: 0x002F8E20
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.b() == null || base.agu() == null || base.b() == null || base.b().aa() == null || base.b().aa().Dead)
		{
			return dc4.e;
		}
		if (!base.agw().b || base.agw().c.GetValueOrDefault() || base.agy() == null || base.agy().a == null)
		{
			return dc4.c;
		}
		if (Enumerable.Sum<csk>(Enumerable.Where<csk>(base.agy().a, new Func<csk, bool>(b5p.a.a.a)), new Func<csk, int>(b5p.a.a.b)) > 0)
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
				double num2;
				if (base.b().aa().StatusEffects.Get<ddr>().Count == 0)
				{
					num2 = 0.0;
				}
				else
				{
					num2 = cuo.a.NextDouble();
				}
				if (num2 < 0.25 && !base.b().aa().StatusEffects.a(ddr.a))
				{
					int num3 = ezx.e;
					if (base.a() != null && base.a().aa().Feats.Contains<dt>())
					{
						num3 = (int)((double)num3 * (1.0 + global::dt.a(base.a().aa())));
					}
					ddr a_2 = new ddr(base.a().aa(), ezx.d * d0u.b, num3);
					base.b().aa().StatusEffects.a(a_2, false, false, false);
				}
				else if (num2 < 0.25 && !base.b().aa().StatusEffects.a(ehp.a))
				{
					int num4 = ezx.i;
					if (base.a() != null && base.a().aa().Feats.Contains<dt>())
					{
						num4 = (int)((double)num4 * (1.0 + global::dt.a(base.a().aa())));
					}
					ehp a_3 = new ehp(base.a().aa(), ezx.h * d0u.b, num4);
					base.b().aa().StatusEffects.a(a_3, false, false, false);
				}
				else if (num2 < 0.5 && !base.b().aa().StatusEffects.a(bhe.a))
				{
					int num5 = 5;
					bhe a_4 = new bhe((int)Math.Max(1.0, (double)num5 * (1.0 - num)) * d0u.b);
					base.b().aa().StatusEffects.a(a_4, false, false, false);
				}
				else if (num2 < 0.5 && !base.b().aa().StatusEffects.a(dns.a))
				{
					dns a_5 = new dns(ezx.g * d0u.b);
					base.b().aa().StatusEffects.a(a_5, false, false, false);
				}
				else
				{
					int num6 = 5;
					int a_6 = 5;
					int num7 = 7;
					if (base.a() != null && base.a().aa().Feats.Contains<dt>())
					{
						num7 = (int)((double)num7 * (1.0 + global::dt.a(base.a().aa())));
					}
					string a_7 = "BurrowerPoison";
					string a_8 = "Яд могильщика";
					int num8 = (int)Math.Max(1.0, (double)num6 * (1.0 - num));
					c2b a_9 = new c2b(base.a().aa(), a_7, a_8, num8 * d0u.b, num7, a_6);
					base.b().aa().StatusEffects.a(a_9, false, false, false);
				}
			}
		}
		return dc4.c;
	}

	// Token: 0x020013AA RID: 5034
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007198 RID: 29080 RVA: 0x002FB130 File Offset: 0x002F9330
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x06007199 RID: 29081 RVA: 0x002FB13C File Offset: 0x002F933C
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E61 RID: 11873
		public static readonly b5p.a a = new b5p.a();

		// Token: 0x04002E62 RID: 11874
		public static Func<csk, bool> b;

		// Token: 0x04002E63 RID: 11875
		public static Func<csk, int> c;
	}
}
