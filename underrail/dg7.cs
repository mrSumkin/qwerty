using System;
using System.Collections.Generic;

// Token: 0x02000279 RID: 633
[edy("ProtoEn")]
public sealed class dg7 : d4x
{
	// Token: 0x06001281 RID: 4737 RVA: 0x0004D598 File Offset: 0x0004B798
	public override Dictionary<string, Type> jn()
	{
		return new Dictionary<string, Type>
		{
			{
				dg7.a,
				typeof(string)
			}
		};
	}

	// Token: 0x06001282 RID: 4738 RVA: 0x0004D5B8 File Offset: 0x0004B7B8
	protected override b0b aj8(c5k A_0, Guid? A_1 = null, bool A_2 = false)
	{
		string param = A_0.GetParam<string>(dg7.a);
		if (!string.IsNullOrEmpty(param))
		{
			b0b b0b = bpo.GetServiceOrThrow<d6j>().dv().b(param);
			if (b0b != null && !A_2)
			{
				if (A_1 != null)
				{
					b0b.h(A_1.Value);
				}
				else
				{
					b0b.h(Guid.NewGuid());
				}
			}
			return b0b;
		}
		return null;
	}

	// Token: 0x04000A3F RID: 2623
	public new static readonly string a = "PrototypePath";
}
