using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B42 RID: 2882
[eiz("SGSBSCJ")]
[Serializable]
public sealed class c01 : cze, ISerializable
{
	// Token: 0x06004243 RID: 16963 RVA: 0x0019AB8C File Offset: 0x00198D8C
	private c01(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004244 RID: 16964 RVA: 0x0019AB98 File Offset: 0x00198D98
	public c01()
	{
	}

	// Token: 0x06004245 RID: 16965 RVA: 0x0019ABA4 File Offset: 0x00198DA4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_sgs_tutorial_combatBotsDefeated", new bool?(false)).Value)
		{
			d60 addon = A_1.Zone.GetAddon<d60>();
			if (addon != null)
			{
				foreach (b0b b0b in addon.ab4(new string[]
				{
					"combatBot"
				}))
				{
					c5x c5x = (c5x)b0b;
					if (c5x.h.b != null && !c5x.h.b.aa().Dead && !c5x.h.b.aa().StatusEffects.a(clt.a))
					{
						return;
					}
				}
				serviceOrThrow.aqu().r()["loc_sgs_tutorial_combatBotsDefeated"] = true;
				crx crx = new crx();
				crx.a("sa2");
				crx.c().Add(new Guid("54d8e076-caf0-4c6f-b70d-801c00ad0934"));
				crx.a(bbo.b);
				crx.ym(A_0, A_1, null);
			}
		}
	}
}
