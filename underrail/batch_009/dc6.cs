using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010CB RID: 4299
[eiz("HEJX0")]
[Serializable]
public sealed class dc6 : cze
{
	// Token: 0x06005A93 RID: 23187 RVA: 0x00271468 File Offset: 0x0026F668
	private dc6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005A94 RID: 23188 RVA: 0x00271474 File Offset: 0x0026F674
	public dc6()
	{
	}

	// Token: 0x06005A95 RID: 23189 RVA: 0x00271480 File Offset: 0x0026F680
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.h.b != null)
		{
			duj a_ = new duj();
			c5x.h.b.aa().StatusEffects.a(a_, false, false, false);
			if (c5x.h.b.aa().FactionId == asp.a)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null)
				{
					serviceOrThrow.aqu().r()["npc_cc_daniel_triedHercules"] = true;
				}
			}
		}
	}
}
