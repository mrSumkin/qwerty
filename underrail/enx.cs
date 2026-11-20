using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B7A RID: 2938
[eiz("XPBLRFCDJ")]
[Serializable]
public sealed class enx : cze, ISerializable
{
	// Token: 0x06004324 RID: 17188 RVA: 0x001A3CB4 File Offset: 0x001A1EB4
	private enx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004325 RID: 17189 RVA: 0x001A3CC0 File Offset: 0x001A1EC0
	public enx()
	{
	}

	// Token: 0x06004326 RID: 17190 RVA: 0x001A3CCC File Offset: 0x001A1ECC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		object obj;
		if (A_2 != null && A_2.TryGetValue("CameraDestroyed", out obj) && obj is bool && (bool)obj)
		{
			return;
		}
		if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_" + aud.y8() + "_servantsActivated", new bool?(false)).Value)
		{
			dqs dqs = new dqs();
			foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x != null && c5x.y8() == "Statue" && c5x.GetAspect<dg2>() != null)
				{
					dqs.a(aud.y8());
					dqs.a(new Guid?(c5x.qe()));
					dqs.ym(A_0, A_1, null);
				}
			}
			serviceOrThrow.aqu().r()["loc_" + aud.y8() + "_servantsActivated"] = true;
		}
	}
}
