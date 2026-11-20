using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010EA RID: 4330
[eiz("RDJB")]
[Serializable]
public sealed class anv : cze, ISerializable
{
	// Token: 0x06005B89 RID: 23433 RVA: 0x00274D88 File Offset: 0x00272F88
	private anv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005B8A RID: 23434 RVA: 0x00274D94 File Offset: 0x00272F94
	public anv()
	{
	}

	// Token: 0x06005B8B RID: 23435 RVA: 0x00274DA0 File Offset: 0x00272FA0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_2 != null)
		{
			object obj;
			A_2.TryGetValue("killingBlow", out obj);
			cwt cwt = obj as cwt;
			if (cwt != null && cwt.i != null && cwt.i.b == asp.a)
			{
				cxc.a(eyy.a3);
			}
		}
	}
}
