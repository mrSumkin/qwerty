using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000919 RID: 2329
[eiz("CCRTFCC")]
[Serializable]
public sealed class dut : bdw, ISerializable
{
	// Token: 0x06003953 RID: 14675 RVA: 0x00153308 File Offset: 0x00151508
	private dut(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003954 RID: 14676 RVA: 0x00153310 File Offset: 0x00151510
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003955 RID: 14677 RVA: 0x00153314 File Offset: 0x00151514
	public dut()
	{
	}

	// Token: 0x06003956 RID: 14678 RVA: 0x00153320 File Offset: 0x00151520
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null && A_1 != null)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
				{
					if (d4n.b.aa().FactionId == asp.ea && !d4n.b.aa().Dead)
					{
						d4n.b.a8().w();
						d4n.b.a8().an();
					}
				}
				if (A_0.y8() == "cc20")
				{
					aud aud = A_0.n("cc20");
					if (aud != null)
					{
						foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
						{
							c5x c5x = (c5x)b0b;
							c7j c7j = c5x.GetAspect<bim>() as c7j;
							if (c7j != null)
							{
								c3g aspect = c5x.GetAspect<c3g>();
								if (aspect != null && aspect.d().Contains(asp.ea))
								{
									c7j.ItemContainer.z2().Clear();
								}
							}
						}
					}
				}
			}
		}
	}
}
