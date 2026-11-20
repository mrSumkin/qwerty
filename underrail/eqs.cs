using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B8A RID: 2954
[eiz("CCSWIPJ")]
[Serializable]
public sealed class eqs : cze, ISerializable
{
	// Token: 0x06004359 RID: 17241 RVA: 0x001A5AA4 File Offset: 0x001A3CA4
	private eqs(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600435A RID: 17242 RVA: 0x001A5AB0 File Offset: 0x001A3CB0
	public eqs()
	{
	}

	// Token: 0x0600435B RID: 17243 RVA: 0x001A5ABC File Offset: 0x001A3CBC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_0 as c5x;
		if (c5x != null && c5x.h.b != null && c5x.h.b.aa().FactionId == asp.d4 && c5x.t.b != null)
		{
			c5x.t.b.y6().RemoveProperty(ddq.k);
			c5x.t.b.y6().RemoveProperty(ddq.l);
			int value = c5x.t.b.y6().GetPrimitivePropertyValue<int>("InvaderNumber", new int?(0)).Value;
			c5x.t.b.y6()[ddq.ay] = new bt4("ig" + value.ToString());
		}
	}

	// Token: 0x04001C40 RID: 7232
	private new const int a = 6;
}
