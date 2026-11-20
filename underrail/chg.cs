using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020008FD RID: 2301
[eiz("CCGAUNT7")]
[Serializable]
public sealed class chg : bdw, ISerializable
{
	// Token: 0x060038E3 RID: 14563 RVA: 0x00151448 File Offset: 0x0014F648
	private chg(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060038E4 RID: 14564 RVA: 0x00151450 File Offset: 0x0014F650
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060038E5 RID: 14565 RVA: 0x00151454 File Offset: 0x0014F654
	public chg()
	{
	}

	// Token: 0x060038E6 RID: 14566 RVA: 0x0015145C File Offset: 0x0014F65C
	public void av(c1a A_0, cyt A_1)
	{
		int num = dkr.f();
		if (A_0 != null)
		{
			aud aud = Enumerable.FirstOrDefault<aud>(A_0.Areas);
			if (aud != null)
			{
				dkr.a(aud, new string[]
				{
					"d11471d4-943f-4750-85c5-3fad3c6c1581",
					"08ba6812-0468-495f-9ce3-942f03582a88",
					"da33b24c-c115-46dd-8eb4-0b7460d1d3af",
					"50103f1a-5b55-488a-95b8-5ead40fa324e",
					"d21502df-17ed-4e56-9d86-f0e4cc3e374a",
					"5535018d-6195-4626-8d88-187e8927e313"
				});
				List<csd> list = new List<csd>();
				foreach (csd csd in aud.Zone.Waypoints)
				{
					if (csd.Name.StartsWith("g"))
					{
						list.Add(csd);
					}
				}
				int num2 = 1;
				while (num2 <= 2 + num && list.Count != 0)
				{
					int index = cuo.a.Next(list.Count);
					csd csd2 = list[index];
					c5x c5x = vq.a("creatures\\coilSpider", csd2, false);
					if (c5x != null && c5x.t.b != null)
					{
						c5x.t.b.y6()[ddq.ay] = new bt4(csd2.Name);
					}
					list.RemoveAt(index);
					num2++;
				}
			}
		}
	}
}
