using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B0A RID: 2826
[eiz("XPBLL12SEPJ")]
[Serializable]
public sealed class cbq : cze, ISerializable
{
	// Token: 0x06004167 RID: 16743 RVA: 0x00190744 File Offset: 0x0018E944
	private cbq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004168 RID: 16744 RVA: 0x00190750 File Offset: 0x0018E950
	public cbq()
	{
	}

	// Token: 0x06004169 RID: 16745 RVA: 0x0019075C File Offset: 0x0018E95C
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
		if (aud != null && bpo.GetServiceOrThrow<cnk>().aqu() != null)
		{
			c5x c5x = new ar7(new Guid("5a9ccd90-e7b4-4ef9-9eb1-27771a18d6cd"), aud).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("6a3e41ad-970a-43d2-bd20-ee4d38d2abc2"), aud).ao() as c5x;
			if (c5x != null && c5x.p.b != null)
			{
				c5x.p.b.a[1].b.X = 1;
			}
			if (c5x2 != null && c5x2.p.b != null)
			{
				c5x2.p.b.a[1].b.X = 1;
			}
		}
	}
}
