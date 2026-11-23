using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000BA1 RID: 2977
[eiz("XPBLPIRBP")]
[Serializable]
public sealed class dsq : cze, ISerializable
{
	// Token: 0x060043AA RID: 17322 RVA: 0x001A95E4 File Offset: 0x001A77E4
	private dsq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060043AB RID: 17323 RVA: 0x001A95F0 File Offset: 0x001A77F0
	public dsq()
	{
	}

	// Token: 0x060043AC RID: 17324 RVA: 0x001A95FC File Offset: 0x001A77FC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				c5x c5x = new ar7(new Guid("d4ac396e-10f7-4a61-8f0e-941c31813923"), aud).ao() as c5x;
				int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("npc_xpbl_le_oldfield_timesHit", new int?(0)).Value;
				if (c5x != null && c5x.h.b != null)
				{
					if (value >= 3)
					{
						serviceOrThrow.aqu().r()["npc_xpbl_le_oldfield_beatenProfessorToDeath"] = true;
						return;
					}
					if (value == 2)
					{
						c5x.h.b.a(bln.ia);
						c5x.h.b.aa().Defense.q().zp(c5x.h.b.aa().Defense.q().zo() * 0.33f);
						return;
					}
					if (value == 1)
					{
						c5x.h.b.a(bln.h9);
						c5x.h.b.aa().Defense.q().zp(c5x.h.b.aa().Defense.q().zo() * 0.66f);
					}
				}
			}
		}
	}
}
