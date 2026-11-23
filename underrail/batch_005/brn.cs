using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A1C RID: 2588
[eiz("XPBLDHC")]
[Serializable]
public sealed class brn : bdw, ISerializable
{
	// Token: 0x06003D91 RID: 15761 RVA: 0x00170D70 File Offset: 0x0016EF70
	private brn(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D92 RID: 15762 RVA: 0x00170D78 File Offset: 0x0016EF78
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D93 RID: 15763 RVA: 0x00170D7C File Offset: 0x0016EF7C
	public brn()
	{
	}

	// Token: 0x06003D94 RID: 15764 RVA: 0x00170D84 File Offset: 0x0016EF84
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			bpo.GetServiceOrThrow<cnk>();
			aud aud = A_0.n("xpbl_lux_dh");
			c5x c5x = new ar7(new Guid("3fb178ab-ee1d-4ac2-96b1-0f4bcce38750"), aud).ao() as c5x;
			if (aud != null && c5x != null)
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
				{
					c5x c5x2 = (c5x)b0b;
					if (c5x2 != null)
					{
						if (!string.IsNullOrEmpty(c5x2.y8()) && c5x2.h.b == null && c5x2.s.b is c7j && (c5x2.y8().EndsWith("- тело") || c5x2.y8() == "Останки"))
						{
							c5x2.w();
							c5x2.an();
						}
						else if (c5x2.o.b != null && c5x2.Layer == aju.x && (c5x2.o.b.a == "Effects\\BloodPool" || c5x2.o.b.a == "Objects\\Items\\Boxes" || c5x2.o.b.a == "Objects\\Natural\\MushroomPatch" || c5x2.o.b.a == "Objects\\Items\\PaperLitter" || c5x2.o.b.a == "Objects\\Obstacles\\SideJunkPile" || c5x2.o.b.a == "Objects\\Containers\\Remains\\JunkPile2"))
						{
							c5x2.w();
							c5x2.an();
						}
						else if (c5x2.GetAspect<a3f>() != null && c5x2.GetAspect<a3f>().a().GetPrimitivePropertyValue<bool>("IsCorpse", new bool?(false)).Value)
						{
							c5x2.an();
							c5x2.w();
						}
					}
				}
			}
		}
	}
}
