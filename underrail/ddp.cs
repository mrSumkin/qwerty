using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020012EA RID: 4842
[eiz("IVSA")]
[Serializable]
public sealed class ddp : pa, ISerializable
{
	// Token: 0x06006B77 RID: 27511 RVA: 0x002D2800 File Offset: 0x002D0A00
	private ddp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006B78 RID: 27512 RVA: 0x002D280C File Offset: 0x002D0A0C
	public ddp(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006B79 RID: 27513 RVA: 0x002D2818 File Offset: 0x002D0A18
	protected override void ajy()
	{
		try
		{
			base.a8().o.b.b = new Point((!base.m()) ? 1 : 0, base.a8().o.b.b.Y);
		}
		catch
		{
		}
	}
}
