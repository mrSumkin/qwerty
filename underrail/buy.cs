using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x0200103A RID: 4154
[eiz("BAGSJ")]
[Serializable]
public sealed class buy : cze
{
	// Token: 0x060055D6 RID: 21974 RVA: 0x0025D0B4 File Offset: 0x0025B2B4
	private buy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060055D7 RID: 21975 RVA: 0x0025D0C0 File Offset: 0x0025B2C0
	public buy()
	{
	}

	// Token: 0x060055D8 RID: 21976 RVA: 0x0025D0C8 File Offset: 0x0025B2C8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		b4b service = bpo.GetService<b4b>();
		if (service != null && service.yn() != null)
		{
			foreach (aud aud in Enumerable.FirstOrDefault<c1a>(service.yn().Zones).Areas)
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
				{
					c5x c5x = (c5x)b0b;
					if (c5x.j == cgy.b)
					{
						cry aspect = c5x.GetAspect<cry>();
						if (aspect != null)
						{
							aspect.e();
						}
					}
				}
			}
		}
	}
}
