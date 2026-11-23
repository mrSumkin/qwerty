using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02000B88 RID: 2952
[eiz("CCDAJ")]
[Serializable]
public sealed class bvb : cze, ISerializable
{
	// Token: 0x06004353 RID: 17235 RVA: 0x001A5100 File Offset: 0x001A3300
	private bvb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004354 RID: 17236 RVA: 0x001A510C File Offset: 0x001A330C
	public bvb()
	{
	}

	// Token: 0x06004355 RID: 17237 RVA: 0x001A5118 File Offset: 0x001A3318
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_2 != null && A_1 != null)
		{
			cwt cwt = A_2["attackResult"] as cwt;
			if (cwt != null && cwt.ad != null && cwt.ad.GetPrimitivePropertyValue<PsiSchool>("PsionicSource", null) != null)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				cky cky = serviceOrThrow.aqu().ac().abu(asp.dt, asp.a);
				if (cky != null && cky.a != h.a)
				{
					bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_cc_duff_fistfightStarted", new bool?(false)).Value;
					bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_cc_duff_forfeitFistfight", new bool?(false)).Value;
					if (value && !value2)
					{
						new cct("Он мозговерт! Взять его, девочки!", true, null, bvl.c).ym(null, A_1, null);
						serviceOrThrow.aqu().ac().abw(asp.dt, asp.a, h.a, null, true, true);
					}
				}
			}
		}
	}
}
