using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A77 RID: 2679
[eiz("DCDTE")]
[Serializable]
public sealed class cu6 : cze, ISerializable
{
	// Token: 0x06003F1B RID: 16155 RVA: 0x0017E028 File Offset: 0x0017C228
	private cu6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F1C RID: 16156 RVA: 0x0017E034 File Offset: 0x0017C234
	public cu6()
	{
	}

	// Token: 0x06003F1D RID: 16157 RVA: 0x0017E040 File Offset: 0x0017C240
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_dc_tchoristCaptives_toldToEscape", new bool?(false)).Value;
			int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_tchortistsEscaped", new int?(0)).Value;
			if (value)
			{
				c5x c5x = A_0 as c5x;
				if (c5x != null && c5x.h.b != null && !c5x.h.b.aa().Dead && c5x.h.b.aa().FactionId == asp.e5)
				{
					num++;
					serviceOrThrow.aqu().r()["loc_dc_tchortistsEscaped"] = num;
					if (c5x.i.b != null)
					{
						c5x.i.b.a(true, false);
						qy qy = new qy();
						qy.b(false);
						qy.c(false);
						List<auv> list = qy.ad();
						a4s a4s = new a4s(new uk(), null, null, null);
						a4s.b(new ar7(c5x));
						list.Add(a4s);
						c5x.Zone.ActionManager.g9(qy, atp.a);
					}
				}
			}
		}
	}
}
