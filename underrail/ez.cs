using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02001102 RID: 4354
[eiz("F66")]
[Serializable]
public sealed class ez : cze, ISerializable
{
	// Token: 0x06005C62 RID: 23650 RVA: 0x00277D60 File Offset: 0x00275F60
	private ez(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005C63 RID: 23651 RVA: 0x00277D6C File Offset: 0x00275F6C
	public ez()
	{
	}

	// Token: 0x06005C64 RID: 23652 RVA: 0x00277D78 File Offset: 0x00275F78
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && A_2 != null)
		{
			object obj;
			A_2.TryGetValue("tickCount", out obj);
			if (obj is int && (int)obj >= kh.c / d0u.b)
			{
				if (c5x.i.b != null)
				{
					c5x.i.b.a(true, false);
				}
				qy qy = new qy();
				qy.b(false);
				qy.c(false);
				ad6 ad = new ad6(c5x);
				ad.b(1.0);
				ad.c(0.0);
				ad.a(dz6.a(0.00075));
				qy.ad().Add(ad);
				List<auv> list = qy.ad();
				c7 c = new c7(c5x, false, false, true, false);
				c.a(true);
				list.Add(c);
				c5x.Zone.ActionManager.g9(qy, atp.a);
				dz6.a(qy);
				ah7 ah = null;
				foreach (bsf bsf in Enumerable.OfType<bsf>(c5x.RaysEmitters))
				{
					if (bsf != null && bsf.Definition != null && bsf.Definition.Name.StartsWith("flareLantern"))
					{
						ah = bsf.Definition;
					}
				}
				if (ah != null)
				{
					c5x.Zone.ActionManager.g9(new fx(ah, ah.Light.c(), 0f, -0.00075f, false), atp.a);
				}
			}
		}
	}
}
