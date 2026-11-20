using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A94 RID: 2708
[eiz("LUDBA1J")]
[Serializable]
public sealed class c0d : cze, ISerializable
{
	// Token: 0x06003F82 RID: 16258 RVA: 0x001819EC File Offset: 0x0017FBEC
	private c0d(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F83 RID: 16259 RVA: 0x001819F8 File Offset: 0x0017FBF8
	public c0d()
	{
	}

	// Token: 0x06003F84 RID: 16260 RVA: 0x00181A04 File Offset: 0x0017FC04
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_prmutation_toldYouToPlaceIt", new bool?(false)).Value)
		{
			c5x c5x = A_0 as c5x;
			if (c5x != null && c5x.qe() == new Guid("06b7c193-a583-4152-85c0-b9ae228d6413") && c5x.h.b != null && !c5x.h.b.aa().Dead && !c5x.h.b.aa().IsInCombat)
			{
				serviceOrThrow.aqu().r()["quest_prmutation_toldYouToPlaceIt"] = true;
				if (c5x.u.b != null)
				{
					c5x.u.b.a("Найдите способ ввести мутаген в вентиляцию. Я посторожу.", true, null, null);
				}
			}
		}
	}
}
