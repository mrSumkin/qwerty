using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A9C RID: 2716
[eiz("LUDLPJ")]
[Serializable]
public sealed class do9 : cze, ISerializable
{
	// Token: 0x06003F9D RID: 16285 RVA: 0x001826D4 File Offset: 0x001808D4
	private do9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F9E RID: 16286 RVA: 0x001826E0 File Offset: 0x001808E0
	public do9()
	{
	}

	// Token: 0x06003F9F RID: 16287 RVA: 0x001826EC File Offset: 0x001808EC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			c5x c5x = A_0 as c5x;
			if (c5x != null && c5x.h.b != null && !c5x.h.b.aa().Dead && (c5x.h.b.aa().FactionId == asp.b7 || c5x.h.b.aa().FactionId == asp.b8))
			{
				List<string> list = serviceOrThrow.aqu().r().GetClassPropertyValue<List<string>>("loc_lup-a8prison_escapedPrisonerModels");
				if (list == null)
				{
					list = new List<string>();
					serviceOrThrow.aqu().r()["loc_lup-a8prison_escapedPrisonerModels"] = list;
				}
				list.Add(c5x.h.b.am());
				if (c5x.i.b != null)
				{
					c5x.i.b.a(true, false);
					qy qy = new qy();
					qy.b(false);
					qy.c(false);
					List<auv> list2 = qy.ad();
					a4s a4s = new a4s(new uk(), null, null, null);
					a4s.b(new ar7(c5x));
					list2.Add(a4s);
					c5x.Zone.ActionManager.g9(qy, atp.a);
				}
			}
		}
	}
}
