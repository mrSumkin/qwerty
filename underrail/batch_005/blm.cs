using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000AFE RID: 2814
[eiz("XPBLRCJ")]
[Serializable]
public sealed class blm : cze, ISerializable
{
	// Token: 0x0600413B RID: 16699 RVA: 0x0018E96C File Offset: 0x0018CB6C
	private blm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600413C RID: 16700 RVA: 0x0018E978 File Offset: 0x0018CB78
	public blm()
	{
	}

	// Token: 0x0600413D RID: 16701 RVA: 0x0018E984 File Offset: 0x0018CB84
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		d02 service = bpo.GetService<d02>();
		if (serviceOrThrow.aqu() != null && service != null)
		{
			string name = "loc_" + serviceOrThrow.aqw().y8() + "_eelsCleared";
			if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(name, new bool?(false)).Value)
			{
				foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
				{
					if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead && d4n.b.aa().FactionId == asp.gg)
					{
						return;
					}
				}
				serviceOrThrow.aqu().r()[name] = true;
				if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_plentyKilled", new bool?(false)).Value && (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig1_eelsCleared", new bool?(false)).Value || serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig2_eelsCleared", new bool?(false)).Value))
				{
					serviceOrThrow.aqu().r()["loc_xpbl_rig_plentyKilled"] = true;
				}
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig1_eelsCleared", new bool?(false)).Value && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig2_eelsCleared", new bool?(false)).Value)
				{
					serviceOrThrow.aqu().r()["loc_rig_blackEels_wipedOut"] = true;
				}
			}
		}
	}
}
