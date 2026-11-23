using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A97 RID: 2711
[eiz("LUSAZFL")]
[Serializable]
public sealed class b0r : cze, ISerializable
{
	// Token: 0x06003F8E RID: 16270 RVA: 0x00181EBC File Offset: 0x001800BC
	private b0r(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F8F RID: 16271 RVA: 0x00181EC8 File Offset: 0x001800C8
	public b0r()
	{
	}

	// Token: 0x06003F90 RID: 16272 RVA: 0x00181ED4 File Offset: 0x001800D4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.h.b != null && c5x.h.b.aa().Id == "azif" && c5x.t.b != null)
		{
			c5x.t.b.y6()[ddq.ay] = new bt4("azifExit");
		}
	}
}
