using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B86 RID: 2950
[eiz("CCG8AS")]
[Serializable]
public sealed class eor : cze, ISerializable
{
	// Token: 0x0600434D RID: 17229 RVA: 0x001A4F24 File Offset: 0x001A3124
	private eor(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600434E RID: 17230 RVA: 0x001A4F30 File Offset: 0x001A3130
	public eor()
	{
	}

	// Token: 0x0600434F RID: 17231 RVA: 0x001A4F3C File Offset: 0x001A313C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null)
		{
			c5x c5x = A_0.Area.a(new Guid("b309c915-88da-4d64-b905-181fdb6d92ad")) as c5x;
			if (c5x != null)
			{
				bpq.a(c5x);
			}
		}
	}
}
