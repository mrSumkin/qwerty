using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010D1 RID: 4305
[eiz("EECJ")]
[Serializable]
public sealed class a4v : cze
{
	// Token: 0x06005ABB RID: 23227 RVA: 0x00271B5C File Offset: 0x0026FD5C
	private a4v(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005ABC RID: 23228 RVA: 0x00271B68 File Offset: 0x0026FD68
	public a4v()
	{
	}

	// Token: 0x06005ABD RID: 23229 RVA: 0x00271B70 File Offset: 0x0026FD70
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null)
		{
			bkt.a(A_0 as c5x);
		}
	}
}
