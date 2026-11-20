using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010BC RID: 4284
[eiz("EKIDJ")]
[Serializable]
public sealed class asz : cze, ISerializable
{
	// Token: 0x06005A08 RID: 23048 RVA: 0x0026DD68 File Offset: 0x0026BF68
	private asz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005A09 RID: 23049 RVA: 0x0026DD74 File Offset: 0x0026BF74
	public asz()
	{
	}

	// Token: 0x06005A0A RID: 23050 RVA: 0x0026DD80 File Offset: 0x0026BF80
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_0 as c5x;
		if (c5x != null && c5x.l.Count > 0)
		{
			foreach (bqt bqt in c5x.l[0].TriggerProxies)
			{
				ba9 ba = bqt.Trigger as ba9;
				if (ba != null && ba.TrapEntity != null)
				{
					ed2 ed = ba.TrapEntity.GetAspect<b4h>() as ed2;
					if (ed != null && ed.a8() == c5x)
					{
						ba.o();
						dtb dtb = new dtb();
						dtb.b(false);
						dtb.c(false);
						List<auv> list = dtb.ad();
						ad6 ad = new ad6(ba.TrapEntity);
						ad.b(1.0);
						ad.c(0.0);
						ad.a(dz6.a(0.003));
						list.Add(ad);
						dtb.ad().Add(new c7(ba.TrapEntity, false, false, true, false));
						c5x.Zone.ActionManager.g9(dtb, atp.a);
						dz6.a(dtb);
						break;
					}
				}
			}
		}
	}
}
