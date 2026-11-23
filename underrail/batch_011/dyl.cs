using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B5D RID: 2909
[eiz("CJJ")]
[Serializable]
public sealed class dyl : cze, ISerializable
{
	// Token: 0x060042A1 RID: 17057 RVA: 0x0019D888 File Offset: 0x0019BA88
	private dyl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060042A2 RID: 17058 RVA: 0x0019D894 File Offset: 0x0019BA94
	public dyl()
	{
	}

	// Token: 0x060042A3 RID: 17059 RVA: 0x0019D8A0 File Offset: 0x0019BAA0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null)
		{
			aud aud = A_0.Area;
			if (aud != null && aud.Zone != null)
			{
				c5x c5x = new ar7(new Guid("693c561f-9abe-419d-8205-9771153a4ea2"), aud).ao() as c5x;
				if (c5x != null && c5x.h.b != null)
				{
					foreach (c2b a_ in Enumerable.ToList<c2b>(c5x.h.b.aa().StatusEffects.Get<c2b>()))
					{
						c5x.h.b.aa().StatusEffects.d(a_);
					}
				}
			}
		}
	}
}
