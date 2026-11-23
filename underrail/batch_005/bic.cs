using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000A65 RID: 2661
[eiz("RSBJ")]
[Serializable]
public sealed class bic : cze, ISerializable
{
	// Token: 0x06003EDE RID: 16094 RVA: 0x0017BFB8 File Offset: 0x0017A1B8
	private bic(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003EDF RID: 16095 RVA: 0x0017BFC4 File Offset: 0x0017A1C4
	public bic()
	{
	}

	// Token: 0x06003EE0 RID: 16096 RVA: 0x0017BFD0 File Offset: 0x0017A1D0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x == null || c5x.Area == null || c5x.o.b == null)
		{
			return;
		}
		dtb dtb = new dtb();
		dtb.ad().Add(new bm3(250));
		dtb.ad().Add(new ben(c5x.o.b, new Point(0, c5x.o.b.b.Y)));
		c5x.Zone.ActionManager.g9(dtb, atp.a);
	}
}
