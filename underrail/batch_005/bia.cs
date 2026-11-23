using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000BA2 RID: 2978
[eiz("XPBLHCSS")]
[Serializable]
public sealed class bia : cze, ISerializable
{
	// Token: 0x060043AD RID: 17325 RVA: 0x001A9780 File Offset: 0x001A7980
	private bia(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060043AE RID: 17326 RVA: 0x001A978C File Offset: 0x001A798C
	public bia()
	{
	}

	// Token: 0x060043AF RID: 17327 RVA: 0x001A9794 File Offset: 0x001A7994
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_hc_statueActivated", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_hc_statueSet", new bool?(false)).Value)
			{
				c5x c5x = Enumerable.FirstOrDefault<b0b>(aud.Zone.a().ab4(new string[]
				{
					"xpbl_hc_strongmanWithFoldM"
				})) as c5x;
				if (c5x != null && c5x.h.b != null)
				{
					coh coh = new d48(ez2.CreateDefinitonProvider<dj3>("plot\\xpbl\\FoldM-Base"));
					if (coh != null)
					{
						coh.c();
						coh.Definition.k("plot.xpbl_mpc_plants");
						coh.Definition.g("Fold-M 7 (Crimson Meadow Horticulture Center)");
						c5x.h.b.aa().Bag.z3(coh, true);
						serviceOrThrow.aqu().r()["loc_xpbl_hc_statueSet"] = true;
					}
				}
			}
		}
	}
}
