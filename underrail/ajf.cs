using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000AED RID: 2797
[eiz("XPBLYDRJ")]
[Serializable]
public sealed class ajf : cze, ISerializable
{
	// Token: 0x06004102 RID: 16642 RVA: 0x0018C708 File Offset: 0x0018A908
	private ajf(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004103 RID: 16643 RVA: 0x0018C714 File Offset: 0x0018A914
	public ajf()
	{
	}

	// Token: 0x06004104 RID: 16644 RVA: 0x0018C720 File Offset: 0x0018A920
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>(bp5.l, new int?(0)).Value;
			c5x c5x = new ar7(new Guid("5c676c93-90e9-45cf-93fc-dddfa3940c49"), serviceOrThrow.aqw().n("xpbl_a10U")).ao() as c5x;
			if (c5x != null)
			{
				c5x.ae = new float?((float)1);
				if (c5x.o != null)
				{
					c5x.o.b.b.X = value % 8;
					c5x.o.b.b.Y = value / 8;
				}
			}
		}
	}
}
