using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010A7 RID: 4263
[eiz("SI6T")]
[Serializable]
public sealed class eyh : cze
{
	// Token: 0x0600596F RID: 22895 RVA: 0x0026A3AC File Offset: 0x002685AC
	private eyh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005970 RID: 22896 RVA: 0x0026A3B8 File Offset: 0x002685B8
	public eyh()
	{
	}

	// Token: 0x06005971 RID: 22897 RVA: 0x0026A3C0 File Offset: 0x002685C0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null && !dz6.e())
		{
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("dc_mushroomDream", new bool?(false)).Value;
			bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("dc_mushroomHeartDestroyed", new bool?(false)).Value;
			if (!value && !value2 && serviceOrThrow.aqw().y8().StartsWith("dc-f", StringComparison.OrdinalIgnoreCase))
			{
				c5x c5x = A_1 as c5x;
				if (c5x != null && c5x.IsPlayer && c5x.h.b != null && !c5x.h.b.aa().IsInCombat)
				{
					c1c c1c = A_2["StatusEffect"] as c1c;
					if (c1c != null && c1c.Stacks == c1c.b)
					{
						serviceOrThrow.aqu().r()["dc_mushroomDream"] = true;
						if (serviceOrThrow.aqw().y8().StartsWith("dc-fs", StringComparison.OrdinalIgnoreCase))
						{
							serviceOrThrow.aqu().r()["dc_mushroomDream_reachedLowerCaves"] = true;
						}
						bpo.GetServiceOrThrow<ps>().am3("Dc_MushroomDream");
					}
				}
			}
		}
	}
}
