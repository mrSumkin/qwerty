using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020010BE RID: 4286
[eiz("PTTJ")]
[Serializable]
public sealed class bi8 : cze, ISerializable
{
	// Token: 0x06005A15 RID: 23061 RVA: 0x0026E108 File Offset: 0x0026C308
	private bi8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005A16 RID: 23062 RVA: 0x0026E114 File Offset: 0x0026C314
	public bi8()
	{
	}

	// Token: 0x06005A17 RID: 23063 RVA: 0x0026E120 File Offset: 0x0026C320
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.Area != null && c5x.Zone != null && A_2 != null && A_2.ContainsKey("killingBlow"))
		{
			cwt cwt = A_2["killingBlow"] as cwt;
			c5x c5x2 = vq.a("object\\obstacles\\Xpbl_TriggeredPropaneTank", c5x.Zone, new bt4(c5x.Area.y8(), c5x.Location), false);
			if (c5x2 != null)
			{
				c5x2.VisualPriority = c5x.VisualPriority;
				dm aspect = c5x2.GetAspect<dm>();
				if (aspect != null)
				{
					z7 z = Enumerable.FirstOrDefault<z7>(Enumerable.OfType<z7>(aspect.d()));
					if (cwt != null && cwt.i != null && cwt.i.b != null && z != null)
					{
						z.ActivatorFactionId = cwt.i.b;
					}
				}
			}
		}
	}
}
