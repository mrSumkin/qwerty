using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B24 RID: 2852
[eiz("XPBLABDJ")]
[Serializable]
public sealed class vh : cze, ISerializable
{
	// Token: 0x060041D4 RID: 16852 RVA: 0x00197258 File Offset: 0x00195458
	private vh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060041D5 RID: 16853 RVA: 0x00197264 File Offset: 0x00195464
	public vh()
	{
	}

	// Token: 0x060041D6 RID: 16854 RVA: 0x0019726C File Offset: 0x0019546C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.Area != null && c5x.Zone != null)
		{
			c5x c5x2 = vq.a("object\\obstacles\\xpbl_LeakingAcidBarrel", c5x.Zone, new bt4(c5x.Area.y8(), c5x.Location), false);
			if (c5x2 != null)
			{
				c5x2.VisualPriority = c5x.VisualPriority;
			}
		}
	}
}
