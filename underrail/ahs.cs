using System;
using System.Runtime.Serialization;

// Token: 0x020013C4 RID: 5060
[eiz("D59")]
[bs6("HFX:DogAttack")]
[Serializable]
public sealed class ahs : cpl, ISerializable
{
	// Token: 0x060071FA RID: 29178 RVA: 0x002FE340 File Offset: 0x002FC540
	private ahs(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060071FB RID: 29179 RVA: 0x002FE34C File Offset: 0x002FC54C
	public ahs()
	{
	}

	// Token: 0x060071FC RID: 29180 RVA: 0x002FE354 File Offset: 0x002FC554
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.b() == null || base.agu() == null || base.b() == null || base.b().aa() == null || base.b().aa().Dead)
		{
			return dc4.e;
		}
		if (base.agw().b && !base.agw().c.GetValueOrDefault() && !base.b().aa().Passive && !base.b().aa().b(d8o.e) && cuo.a.NextDouble() < 0.5)
		{
			s1 a_ = new s1(d0u.b, "Status.Tackled");
			base.b().aa().StatusEffects.a(a_, false, false, false);
		}
		return dc4.c;
	}
}
