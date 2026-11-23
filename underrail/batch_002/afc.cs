using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020009D4 RID: 2516
[eiz("LMLWL")]
[Serializable]
public sealed class afc : bdw, ISerializable
{
	// Token: 0x06003C4B RID: 15435 RVA: 0x00164744 File Offset: 0x00162944
	private afc(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C4C RID: 15436 RVA: 0x0016474C File Offset: 0x0016294C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C4D RID: 15437 RVA: 0x00164750 File Offset: 0x00162950
	public afc()
	{
	}

	// Token: 0x06003C4E RID: 15438 RVA: 0x00164758 File Offset: 0x00162958
	public void av(c1a A_0, cyt A_1)
	{
		if (A_1 != null && !A_1.r().GetPrimitivePropertyValue<bool>("npc_milton_died", new bool?(false)).Value && A_0 != null)
		{
			aud aud = A_0.n("lux-a11");
			if (aud != null)
			{
				bool flag = false;
				c5x c5x = new ar7(new Guid("965ddd62-e732-4331-9c71-3300503847e2"), aud).ao() as c5x;
				if (c5x != null)
				{
					if (c5x.h.b != null && Enumerable.Any<coh>(c5x.h.b.aa().Bag.b("plot.miltonskey")))
					{
						flag = true;
					}
					c5x.w();
					c5x.an();
				}
				if (flag)
				{
					c5x c5x2 = new ar7(new Guid("bfc12582-e79c-40e7-acab-6c8a6bd7e571"), aud).ao() as c5x;
					if (c5x2 != null)
					{
						c7j c7j = c5x2.s.b as c7j;
						if (c7j != null)
						{
							c7j.ItemContainer.z7();
							c7j.d(true);
						}
						d2b aspect = c5x2.GetAspect<d2b>();
						if (aspect != null)
						{
							aspect.a(true, false);
							aspect.a(d1c.a);
						}
					}
				}
			}
		}
	}
}
