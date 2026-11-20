using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules;

// Token: 0x02000A59 RID: 2649
[eiz("WHAJ")]
[Serializable]
public sealed class yu : cze, ISerializable
{
	// Token: 0x06003EA0 RID: 16032 RVA: 0x0017A2D0 File Offset: 0x001784D0
	private yu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003EA1 RID: 16033 RVA: 0x0017A2DC File Offset: 0x001784DC
	public yu()
	{
	}

	// Token: 0x06003EA2 RID: 16034 RVA: 0x0017A2E8 File Offset: 0x001784E8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		bu6 serviceOrThrow = bpo.GetServiceOrThrow<bu6>();
		if (serviceOrThrow.aq2() >= GameDifficulty.Hard)
		{
			c5x c5x = A_1 as c5x;
			if (c5x != null && c5x.h.b != null && !c5x.h.b.aa().Dead && euf.f(c5x.h.b.aa()) < 0.5f)
			{
				if (!c5x.h.b.aa().StatusEffects.a(awz.b))
				{
					c5x.h.b.aa().StatusEffects.a(new awz(0, 0.15), false, false, false);
				}
				if (serviceOrThrow.aq2() >= GameDifficulty.Dominating && !c5x.h.b.aa().StatusEffects.a(uj.a))
				{
					c5x.h.b.aa().StatusEffects.a(new uj(0.5f, 0f, 0.1f, 0, 0, 15, 4), false, false, false);
				}
			}
		}
	}
}
