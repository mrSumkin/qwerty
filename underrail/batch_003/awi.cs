using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010D6 RID: 4310
[eiz("SM0")]
[Serializable]
public sealed class awi : cze, ISerializable
{
	// Token: 0x06005AD1 RID: 23249 RVA: 0x002721AC File Offset: 0x002703AC
	private awi(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005AD2 RID: 23250 RVA: 0x002721B8 File Offset: 0x002703B8
	public awi()
	{
	}

	// Token: 0x06005AD3 RID: 23251 RVA: 0x002721C4 File Offset: 0x002703C4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null)
		{
			c5x.c().a("steam_loop", "Steaming", 1f, c9z.b, true, false);
		}
	}
}
