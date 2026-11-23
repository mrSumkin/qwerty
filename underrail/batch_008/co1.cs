using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010CF RID: 4303
[eiz("PMCJ")]
[Serializable]
public sealed class co1 : cze
{
	// Token: 0x06005AAE RID: 23214 RVA: 0x00271974 File Offset: 0x0026FB74
	private co1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005AAF RID: 23215 RVA: 0x00271980 File Offset: 0x0026FB80
	public co1()
	{
	}

	// Token: 0x06005AB0 RID: 23216 RVA: 0x00271988 File Offset: 0x0026FB88
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		d02 service = bpo.GetService<d02>();
		if (service != null)
		{
			service.ahk(10000.0);
		}
	}
}
