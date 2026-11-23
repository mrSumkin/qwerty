using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A9F RID: 2719
[eiz("LUDFDTHJ")]
[Serializable]
public sealed class a66 : cze, ISerializable
{
	// Token: 0x06003FAB RID: 16299 RVA: 0x00182C54 File Offset: 0x00180E54
	private a66(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003FAC RID: 16300 RVA: 0x00182C60 File Offset: 0x00180E60
	public a66()
	{
	}

	// Token: 0x06003FAD RID: 16301 RVA: 0x00182C6C File Offset: 0x00180E6C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			aud aud = serviceOrThrow.aqw().n("lu-b29");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("646766CB-7675-4567-B122-F58903C2DB81"), aud).ao() as c5x;
				if (c5x != null)
				{
					c5x.RemoveAspect<bim>();
					c5x.RemoveAspect<cij>();
				}
				if (c5x.p.b != null && c5x.p.b.a.Count > 1)
				{
					c5x.p.b.a.RemoveAt(1);
				}
			}
		}
	}
}
