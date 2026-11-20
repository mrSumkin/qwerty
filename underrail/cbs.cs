using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x0200094C RID: 2380
[eiz("CVSCC")]
[Serializable]
public sealed class cbs : bdw, ISerializable
{
	// Token: 0x06003A27 RID: 14887 RVA: 0x00157D4C File Offset: 0x00155F4C
	private cbs(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A28 RID: 14888 RVA: 0x00157D54 File Offset: 0x00155F54
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A29 RID: 14889 RVA: 0x00157D58 File Offset: 0x00155F58
	public cbs()
	{
	}

	// Token: 0x06003A2A RID: 14890 RVA: 0x00157D64 File Offset: 0x00155F64
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null && A_1.r().GetPrimitivePropertyValue<bool>("burrowerEradicationEnded", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("loc_cv17_cleanupDone", new bool?(false)).Value)
		{
			aud aud = A_0.n("cv17");
			if (aud != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "cv17_l2") + ".uzl");
				aud.Zone.a(a_, 1, null);
				if (dk2.b("xpbl"))
				{
					doq a_2 = doq.a(Path.Combine(d5x.q(), "cv17_l4") + ".uzl");
					aud.Zone.a(a_2, 1, null);
				}
			}
			c5x c5x = new ar7(new Guid("cb3d22af-394b-4b20-9110-aee3cab0531d"), aud).ao() as c5x;
			cnb cnb = new EntityAspectReference<cnb, bim>(aud, new Guid("8eb0d596-9b82-4af7-9177-b121f863f340")).ao();
			if (cnb != null && !cnb.q())
			{
				cnb.d(true);
			}
			new dat().ym(null, null, null);
			if (c5x != null)
			{
				c5x.an();
				c5x.w();
			}
			foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
			{
				c5x c5x2 = (c5x)b0b;
				if (c5x2 != null)
				{
					if (c5x2.Layer == aju.x && c5x2.o.b != null && (c5x2.o.b.a.StartsWith("Objects\\Natural\\BurrowerEgg") || c5x2.o.b.a.StartsWith("Objects\\Natural\\BurrowerWeb")))
					{
						c5x2.an();
						c5x2.w();
					}
					else if (c5x2.h.b != null && c5x2.h.b.aa().FactionId == "burrowers")
					{
						c5x2.an();
						c5x2.w();
					}
				}
			}
			A_1.r()["loc_cv17_cleanupDone"] = true;
		}
	}
}
