using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010C6 RID: 4294
[eiz("MEFEJ")]
[Serializable]
public sealed class akw : cze
{
	// Token: 0x06005A55 RID: 23125 RVA: 0x0026FF74 File Offset: 0x0026E174
	private akw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005A56 RID: 23126 RVA: 0x0026FF80 File Offset: 0x0026E180
	public akw()
	{
	}

	// Token: 0x06005A57 RID: 23127 RVA: 0x0026FF88 File Offset: 0x0026E188
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null && A_1 != null)
		{
			aw1.b(A_0, A_1, false);
		}
	}
}
