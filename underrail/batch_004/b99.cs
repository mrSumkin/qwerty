using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000AA1 RID: 2721
[eiz("RSJ")]
[Serializable]
public sealed class b99 : cze, ISerializable
{
	// Token: 0x06003FB1 RID: 16305 RVA: 0x00182E40 File Offset: 0x00181040
	private b99(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003FB2 RID: 16306 RVA: 0x00182E4C File Offset: 0x0018104C
	public b99()
	{
	}

	// Token: 0x06003FB3 RID: 16307 RVA: 0x00182E54 File Offset: 0x00181054
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x == null || c5x.Area == null || c5x.o.b == null)
		{
			return;
		}
		dtb dtb = new dtb();
		dtb.ad().Add(new bm3(350));
		dtb.ad().Add(new ben(c5x.o.b, new Point(0, 0)));
		dtb.ad().Add(new a4s(new bfq("LeverSwitchSnapBack"), null, new ar7(c5x), null));
		c5x.Zone.ActionManager.g9(dtb, atp.a);
	}
}
