using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B5C RID: 2908
[eiz("JYHCJ")]
[Serializable]
public sealed class bt0 : cze, ISerializable
{
	// Token: 0x0600429E RID: 17054 RVA: 0x0019D704 File Offset: 0x0019B904
	private bt0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600429F RID: 17055 RVA: 0x0019D710 File Offset: 0x0019B910
	public bt0()
	{
	}

	// Token: 0x060042A0 RID: 17056 RVA: 0x0019D71C File Offset: 0x0019B91C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null)
		{
			aud aud = A_0.Area;
			if (aud != null && aud.Zone != null)
			{
				c5x c5x = new ar7(new Guid("fcff4afa-7bff-4b30-a30f-2dac18483fd1"), aud).ao() as c5x;
				if (c5x != null && c5x.h.b != null)
				{
					foreach (a5e a_ in Enumerable.ToList<a5e>(c5x.h.b.aa().StatusEffects.Get<a5e>()))
					{
						c5x.h.b.aa().StatusEffects.d(a_);
					}
					if (c5x.h.b.aa().Defense.q().zo() / Math.Max(1f, c5x.h.b.aa().Defense.q().zm()) < 0.5f)
					{
						c5x.h.b.aa().Defense.q().zp(c5x.h.b.aa().Defense.q().zm() * 0.5f);
					}
				}
			}
		}
	}
}
