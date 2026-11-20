using System;
using System.Runtime.Serialization;

// Token: 0x02001391 RID: 5009
[bs6("HFX:polarize")]
[eiz("PXHEA")]
[Serializable]
public sealed class dje : cpl, ISerializable
{
	// Token: 0x06007140 RID: 28992 RVA: 0x002F8B94 File Offset: 0x002F6D94
	private dje(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007141 RID: 28993 RVA: 0x002F8BA0 File Offset: 0x002F6DA0
	public dje()
	{
	}

	// Token: 0x06007142 RID: 28994 RVA: 0x002F8BAC File Offset: 0x002F6DAC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.b() == null || base.agu() == null || base.b() == null || base.b().aa() == null || base.b().aa().Dead)
		{
			return dc4.e;
		}
		if (!base.agw().b || base.agw().c.GetValueOrDefault())
		{
			return dc4.c;
		}
		base.b().a8().c().a("xpbl_polarization");
		boj.a(base.b().a8(), "xpbl_PolarizationHit", 1, double.MaxValue, true, true, null, null, null, null, false);
		di1 di = new di1();
		di.Stacks = base.agu().Power;
		base.b().aa().StatusEffects.a(di, false, false, false);
		return dc4.c;
	}
}
