using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x02000AFD RID: 2813
[eiz("XPBLCVW17PMOJ")]
[Serializable]
public sealed class c4a : cze, ISerializable
{
	// Token: 0x06004138 RID: 16696 RVA: 0x0018E7E0 File Offset: 0x0018C9E0
	private c4a(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004139 RID: 16697 RVA: 0x0018E7EC File Offset: 0x0018C9EC
	public c4a()
	{
	}

	// Token: 0x0600413A RID: 16698 RVA: 0x0018E7F8 File Offset: 0x0018C9F8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null)
		{
			List<b0b> list = aud.Zone.a().ab4(new string[]
			{
				"pirateParty"
			});
			int num = 0;
			foreach (b0b b0b in list)
			{
				c5x c5x = (c5x)b0b;
				if (c5x != null && c5x.t.b != null)
				{
					PropertyCollection propertyCollection = c5x.t.b.y6();
					string ay = ddq.ay;
					string str = "pirate_leave";
					int num2;
					num = (num2 = num + 1);
					propertyCollection[ay] = new bt4(str + num2.ToString());
					c5x.t.b.y6()[ddq.bg] = true;
				}
			}
			c5x c5x2 = new ar7(new Guid("70cbecc6-ead3-4de3-8a86-008f9b3b30d4"), aud).ao() as c5x;
			if (c5x2 != null)
			{
				c5x2.t.b.y6()[ddq.ay] = new bt4("razor_leave");
				c5x2.t.b.y6()[ddq.bg] = true;
			}
		}
	}
}
