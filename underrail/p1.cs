using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B22 RID: 2850
[eiz("BLO5")]
[Serializable]
public sealed class p1 : cze, ISerializable
{
	// Token: 0x060041CE RID: 16846 RVA: 0x00197090 File Offset: 0x00195290
	private p1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060041CF RID: 16847 RVA: 0x0019709C File Offset: 0x0019529C
	public p1()
	{
	}

	// Token: 0x060041D0 RID: 16848 RVA: 0x001970A8 File Offset: 0x001952A8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.Area != null && c5x.Zone != null)
		{
			new e3d(new edx(Enumerable.FirstOrDefault<ak1>(c5x.l)), null, false, true).ym(A_0, A_1, A_2);
			c5x c5x2 = vq.a("object\\obstacles\\LeakingBlackOilBarrel", c5x.Zone, new bt4(c5x.Area.y8(), c5x.Location), false);
			if (c5x2 != null)
			{
				c5x2.VisualPriority = c5x.VisualPriority;
			}
		}
	}
}
