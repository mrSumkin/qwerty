using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010AA RID: 4266
[eiz("RGMPJ")]
[Serializable]
public sealed class baq : cze, ISerializable
{
	// Token: 0x0600598E RID: 22926 RVA: 0x0026B12C File Offset: 0x0026932C
	private baq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600598F RID: 22927 RVA: 0x0026B138 File Offset: 0x00269338
	public baq()
	{
	}

	// Token: 0x06005990 RID: 22928 RVA: 0x0026B144 File Offset: 0x00269344
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_0 as c5x;
		if (c5x != null && c5x.Zone != null && c5x.IsPlayer)
		{
			cxc.a(eyy.bv);
		}
	}
}
