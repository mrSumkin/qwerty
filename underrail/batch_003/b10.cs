using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000955 RID: 2389
[eiz("XPBLDAATD")]
[Serializable]
public sealed class b10 : bdw, ISerializable
{
	// Token: 0x06003A4E RID: 14926 RVA: 0x00159D40 File Offset: 0x00157F40
	private b10(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A4F RID: 14927 RVA: 0x00159D48 File Offset: 0x00157F48
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A50 RID: 14928 RVA: 0x00159D4C File Offset: 0x00157F4C
	public b10()
	{
	}

	// Token: 0x06003A51 RID: 14929 RVA: 0x00159D58 File Offset: 0x00157F58
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("xpbl_cc-dock2");
		if (aud != null)
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x != null)
				{
					if (c5x.h.b != null && (c5x.h.b.aa().FactionId == asp.f5 || c5x.h.b.aa().FactionId == asp.f6 || c5x.h.b.aa().FactionId == asp.f7))
					{
						c5x.w();
						c5x.an();
					}
					else if (c5x.a("xpbl_cc_dock2_aegisRemove"))
					{
						c5x.w();
						c5x.an();
					}
				}
			}
			if (A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_cc_dock2_aegisBoatsPresent", new bool?(false)).Value)
			{
				erb.a("xpbl_agsBoat1_dirty", A_0.g("AegisBoat1"));
				erb.a("xpbl_agsBoat2_dirty", A_0.g("AegisBoat2"));
				erb.a("xpbl_agsBoat3_dirty", A_0.g("AegisBoat3"));
			}
		}
		doq a_ = doq.a(Path.Combine(d5x.q(), "xpbl_cc-dock2_L3") + ".uzl");
		aud.Zone.a(a_, 1, null);
	}
}
