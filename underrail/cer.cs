using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001387 RID: 4999
[bs6("HFX:CaveEarPoison")]
[eiz("B59A")]
[Serializable]
public sealed class cer : cpl, ISerializable
{
	// Token: 0x06007120 RID: 28960 RVA: 0x002F7DE8 File Offset: 0x002F5FE8
	private cer(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007121 RID: 28961 RVA: 0x002F7DF4 File Offset: 0x002F5FF4
	public cer()
	{
	}

	// Token: 0x06007122 RID: 28962 RVA: 0x002F7E00 File Offset: 0x002F6000
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
		if (Enumerable.Sum<csk>(Enumerable.Where<csk>(base.agy().a, new Func<csk, bool>(cer.a.a.a)), new Func<csk, int>(cer.a.a.b)) > 0)
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
				bhe a_2 = new bhe((int)Math.Max(1.0, (double)ezx.c * (1.0 - num)) * d0u.b);
				base.b().aa().StatusEffects.a(a_2, false, false, false);
			}
		}
		return dc4.c;
	}

	// Token: 0x02001388 RID: 5000
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007125 RID: 28965 RVA: 0x002F801C File Offset: 0x002F621C
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x06007126 RID: 28966 RVA: 0x002F8028 File Offset: 0x002F6228
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E3F RID: 11839
		public static readonly cer.a a = new cer.a();

		// Token: 0x04002E40 RID: 11840
		public static Func<csk, bool> b;

		// Token: 0x04002E41 RID: 11841
		public static Func<csk, int> c;
	}
}
