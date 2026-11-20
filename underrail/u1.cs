using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B43 RID: 2883
[eiz("SGSTBAJ")]
[Serializable]
public sealed class u1 : cze, ISerializable
{
	// Token: 0x06004246 RID: 16966 RVA: 0x0019ACFC File Offset: 0x00198EFC
	private u1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004247 RID: 16967 RVA: 0x0019AD08 File Offset: 0x00198F08
	public u1()
	{
	}

	// Token: 0x06004248 RID: 16968 RVA: 0x0019AD14 File Offset: 0x00198F14
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.h.b != null && A_2 != null)
		{
			object obj;
			A_2.TryGetValue("damage", out obj);
			List<csk> list = obj as List<csk>;
			if (list != null && list.Count > 0)
			{
				if (c5x.t.b != null)
				{
					new bzv(c5x.t.b.y6()).e();
				}
				c5x.h.b.aa().c(asp.a);
				c5x.h.b.aa().FactionId = asp.a3;
				c5x.h.b.aa().Passive = true;
				clt a_ = new clt(0);
				c5x.h.b.aa().StatusEffects.a(a_, false, false, false);
			}
		}
	}
}
