using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020013BD RID: 5053
[bs6("HFX:Anticoagulation")]
[eiz("3AC")]
[Serializable]
public sealed class bc4 : cpl, ISerializable
{
	// Token: 0x060071D8 RID: 29144 RVA: 0x002FCD7C File Offset: 0x002FAF7C
	private bc4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060071D9 RID: 29145 RVA: 0x002FCD88 File Offset: 0x002FAF88
	public bc4()
	{
	}

	// Token: 0x060071DA RID: 29146 RVA: 0x002FCD94 File Offset: 0x002FAF94
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.b() == null || base.agu() == null || base.b() == null || base.b().aa() == null || base.b().aa().Dead)
		{
			return dc4.e;
		}
		if (base.agw().b && !base.agw().c.GetValueOrDefault() && !base.b().aa().Passive && !base.b().aa().b(d8o.e) && base.agy() != null && base.agy().a != null)
		{
			if (Enumerable.Sum<csk>(Enumerable.Where<csk>(base.agy().a, new Func<csk, bool>(bc4.a.a.a)), new Func<csk, int>(bc4.a.a.b)) > 0)
			{
				euf.g(base.b().aa());
				bfm a_ = new bfm(r6.a(base.agu()));
				base.b().aa().StatusEffects.a(a_, false, false, false);
			}
		}
		return dc4.c;
	}

	// Token: 0x020013BE RID: 5054
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060071DD RID: 29149 RVA: 0x002FCF04 File Offset: 0x002FB104
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x060071DE RID: 29150 RVA: 0x002FCF10 File Offset: 0x002FB110
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E76 RID: 11894
		public static readonly bc4.a a = new bc4.a();

		// Token: 0x04002E77 RID: 11895
		public static Func<csk, bool> b;

		// Token: 0x04002E78 RID: 11896
		public static Func<csk, int> c;
	}
}
