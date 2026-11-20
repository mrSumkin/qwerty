using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001082 RID: 4226
[eiz("RSIBJ")]
[Serializable]
public sealed class ara : cze, ISerializable
{
	// Token: 0x06005814 RID: 22548 RVA: 0x00264384 File Offset: 0x00262584
	private ara(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005815 RID: 22549 RVA: 0x00264390 File Offset: 0x00262590
	public ara()
	{
	}

	// Token: 0x06005816 RID: 22550 RVA: 0x0026439C File Offset: 0x0026259C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x == null || c5x.Area == null || c5x.o.b == null)
		{
			return;
		}
		dtb dtb = new dtb();
		dtb.ad().Add(new bm3(250));
		dtb.ad().Add(new ben(c5x.o.b, new Point(c5x.o.b.b.X - 1, c5x.o.b.b.Y)));
		c5x.Zone.ActionManager.g9(dtb, atp.a);
	}
}
