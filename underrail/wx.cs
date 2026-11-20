using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010D7 RID: 4311
[eiz("SM1")]
[Serializable]
public sealed class wx : cze, ISerializable
{
	// Token: 0x06005AD4 RID: 23252 RVA: 0x002721FC File Offset: 0x002703FC
	private wx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005AD5 RID: 23253 RVA: 0x00272208 File Offset: 0x00270408
	public wx()
	{
	}

	// Token: 0x06005AD6 RID: 23254 RVA: 0x00272214 File Offset: 0x00270414
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null)
		{
			c5x.c().a("steam_loop", false);
		}
	}
}
