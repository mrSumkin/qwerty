using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000AEA RID: 2794
[eiz("XPBLSGSHFJ")]
[Serializable]
public sealed class du1 : cze, ISerializable
{
	// Token: 0x060040F6 RID: 16630 RVA: 0x0018C3F0 File Offset: 0x0018A5F0
	private du1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060040F7 RID: 16631 RVA: 0x0018C3FC File Offset: 0x0018A5FC
	public du1()
	{
	}

	// Token: 0x060040F8 RID: 16632 RVA: 0x0018C408 File Offset: 0x0018A608
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null)
		{
			cd0 aspect = A_0.GetAspect<cd0>();
			if (aspect != null)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null)
				{
					int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>(bp5.l, new int?(0)).Value;
					aspect.b = new Point(value, aspect.b.Y);
				}
			}
		}
	}
}
