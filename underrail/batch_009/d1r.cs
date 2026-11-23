using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000AE6 RID: 2790
[eiz("XPBLSSDJ")]
[Serializable]
public sealed class d1r : cze, ISerializable
{
	// Token: 0x060040EA RID: 16618 RVA: 0x0018BE40 File Offset: 0x0018A040
	private d1r(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060040EB RID: 16619 RVA: 0x0018BE4C File Offset: 0x0018A04C
	public d1r()
	{
	}

	// Token: 0x060040EC RID: 16620 RVA: 0x0018BE58 File Offset: 0x0018A058
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.Area != null && c5x.Zone != null)
		{
			b6j a_ = new b6j(new ar7(c5x), "voidUnlight", null, 0f, (float)dz6.a(-0.00055), false);
			c5x.Zone.ActionManager.g9(a_, atp.a);
			aex.a(c5x.Area, c5x.aj(), 200, 700, 1.5f, 4.25f, false, true);
			c5x.c().a("Xpbl_SpaceSnakeHit");
		}
	}
}
