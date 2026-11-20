using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020012D7 RID: 4823
[eiz("C63")]
[Serializable]
public sealed class ev1 : arn, ISerializable
{
	// Token: 0x06006AAC RID: 27308 RVA: 0x002CEC30 File Offset: 0x002CCE30
	private ev1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006AAD RID: 27309 RVA: 0x002CEC3C File Offset: 0x002CCE3C
	public ev1(c5x A_0, EntityAspectReference<amc, amc> A_1, int A_2, coh A_3) : base(A_0, A_1, A_2, A_3)
	{
	}

	// Token: 0x06006AAE RID: 27310 RVA: 0x002CEC4C File Offset: 0x002CCE4C
	protected override void ed(c5x A_0, int A_1)
	{
		base.ed(A_0, A_1);
		if (A_0 != null && A_0.h.b != null)
		{
			if (A_0.h.b.aa().Passive || A_0.h.b.aa().b(d8o.e) || A_0.h.b.aa().d(CharacterImmunities.Poison))
			{
				if (base.b() != null)
				{
					etm a_ = new etm(new ap9(A_0.h.b.aa()), "яду");
					bey.a(a_, base.b().aa(), A_0.h.b.aa(), A_0.h.b);
					a7v.a(a_);
				}
				bmj.a(A_0, new ba0());
				return;
			}
			int num = ezx.e;
			if (base.b() != null && base.b().aa().Feats.Contains<dt>())
			{
				num = (int)((double)num * (1.0 + dt.a(base.b().aa())));
			}
			ddr a_2 = new ddr((base.b() != null) ? base.b().aa() : null, ezx.d * d0u.b, num);
			A_0.h.b.aa().StatusEffects.a(a_2, false, false, false);
		}
	}
}
