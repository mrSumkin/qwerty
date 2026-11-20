using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200097F RID: 2431
[eiz("TCHLR")]
[Serializable]
public sealed class a5w : bdw, ISerializable
{
	// Token: 0x06003AF7 RID: 15095 RVA: 0x0015DC04 File Offset: 0x0015BE04
	private a5w(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003AF8 RID: 15096 RVA: 0x0015DC0C File Offset: 0x0015BE0C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003AF9 RID: 15097 RVA: 0x0015DC10 File Offset: 0x0015BE10
	public a5w()
	{
	}

	// Token: 0x06003AFA RID: 15098 RVA: 0x0015DC1C File Offset: 0x0015BE1C
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0.n("tch-rit") != null && !A_1.r().GetPrimitivePropertyValue<bool>("loc_tch_liftReset", new bool?(false)).Value)
		{
			A_1.r()["loc_tch_liftReset"] = true;
			d60 addon = A_0.GetAddon<d60>();
			if (addon != null)
			{
				foreach (b0b b0b in addon.ab4(new string[]
				{
					"lift"
				}))
				{
					b0b.Location = new Vector3(b0b.Location.X, b0b.Location.Y, -5f);
					b0b.ah();
				}
			}
		}
	}
}
