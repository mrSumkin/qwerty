using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001376 RID: 4982
[eiz("EXWKA")]
[bs6("HFX:exposeWeakness")]
[Serializable]
public sealed class b5k : cpl, ISerializable
{
	// Token: 0x060070E5 RID: 28901 RVA: 0x002F6784 File Offset: 0x002F4984
	private b5k(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060070E6 RID: 28902 RVA: 0x002F6790 File Offset: 0x002F4990
	public b5k()
	{
	}

	// Token: 0x060070E7 RID: 28903 RVA: 0x002F679C File Offset: 0x002F499C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.b() == null || base.agu() == null || base.b() == null || base.b().aa() == null || base.b().aa().Dead)
		{
			return dc4.e;
		}
		if (!base.agw().b || base.agy().a == null || base.agw().c.GetValueOrDefault())
		{
			return dc4.c;
		}
		if (base.b().aa().Passive || base.b().aa().d(CharacterImmunities.Dismantle))
		{
			etm a_ = new etm(new ap9(base.b().aa()), "эффекту разборки");
			bey.a(a_, base.a().aa(), base.b().aa(), base.b());
			a7v.a(a_);
			bmj.a(base.b().a8(), new ba0());
		}
		else
		{
			double num = (double)base.agu().Power * 0.01;
			if (base.b().aa().b(d8o.e))
			{
				num *= 0.5;
			}
			base.b().aa().StatusEffects.a(new ht(csr.d * d0u.b, num), false, false, false);
		}
		return dc4.c;
	}
}
