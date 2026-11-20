using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001369 RID: 4969
[eiz("CMN5Y")]
[bs6("HFX:contaminate")]
[Serializable]
public sealed class dsn : cpl, ISerializable
{
	// Token: 0x060070B3 RID: 28851 RVA: 0x002F511C File Offset: 0x002F331C
	private dsn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060070B4 RID: 28852 RVA: 0x002F5128 File Offset: 0x002F3328
	public dsn()
	{
	}

	// Token: 0x060070B5 RID: 28853 RVA: 0x002F5134 File Offset: 0x002F3334
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.b() == null || base.agu() == null || base.b() == null || base.b().aa() == null || base.b().aa().Dead || base.b().aa().b(d8o.e))
		{
			return dc4.e;
		}
		if (!base.agw().b || base.agw().c.GetValueOrDefault())
		{
			return dc4.c;
		}
		if (!base.b().aa().Passive && !base.b().aa().b(d8o.e))
		{
			int num;
			if (base.agy() == null || base.agy().a == null)
			{
				num = 0;
			}
			else
			{
				num = Enumerable.Sum<csk>(base.agy().a, new Func<csk, int>(dsn.a.a.a));
			}
			if (num > 0)
			{
				if (base.b().aa().Defense.af()[DamageType.Bio].c() >= 1.0 || base.b().aa().d(CharacterImmunities.Biohazard))
				{
					etm a_ = new etm(new ap9(base.b().aa()), "загрязнение");
					bey.a(a_, base.agw(), base.b());
					a7v.a(a_);
					bmj.a(base.b().a8(), new ba0());
				}
				else
				{
					base.b().aa().StatusEffects.a(new a8l(1), false, false, false);
				}
			}
		}
		return dc4.c;
	}

	// Token: 0x0200136A RID: 4970
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060070B8 RID: 28856 RVA: 0x002F5318 File Offset: 0x002F3518
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E1B RID: 11803
		public static readonly dsn.a a = new dsn.a();

		// Token: 0x04002E1C RID: 11804
		public static Func<csk, int> b;
	}
}
