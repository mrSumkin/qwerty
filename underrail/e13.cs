using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200109F RID: 4255
[eiz("RLDCP")]
[Serializable]
public sealed class e13 : cze, ISerializable
{
	// Token: 0x06005934 RID: 22836 RVA: 0x00269BDC File Offset: 0x00267DDC
	private e13(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005935 RID: 22837 RVA: 0x00269BE8 File Offset: 0x00267DE8
	public e13()
	{
	}

	// Token: 0x06005936 RID: 22838 RVA: 0x00269BF4 File Offset: 0x00267DF4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.h.b != null)
		{
			c5x.h.b.aa().CustomProperties.RemoveProperty(ddm.g);
		}
	}
}
