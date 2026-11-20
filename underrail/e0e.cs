using System;
using System.Runtime.Serialization;

// Token: 0x02000934 RID: 2356
[eiz("SGSDWWC")]
[Serializable]
public sealed class e0e : bdw, ISerializable
{
	// Token: 0x060039C6 RID: 14790 RVA: 0x00155AF8 File Offset: 0x00153CF8
	private e0e(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060039C7 RID: 14791 RVA: 0x00155B00 File Offset: 0x00153D00
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060039C8 RID: 14792 RVA: 0x00155B04 File Offset: 0x00153D04
	public e0e()
	{
	}

	// Token: 0x060039C9 RID: 14793 RVA: 0x00155B10 File Offset: 0x00153D10
	public void av(c1a A_0, cyt A_1)
	{
		if (A_1.r().GetPrimitivePropertyValue<bool>("frag_dun_wasteWater", new bool?(false)).Value && A_1.r().GetPrimitivePropertyValue<bool>("gorsky_GMS_Completed", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("frag_dun_wasteWater_sgsBodiesRemoved", new bool?(false)).Value)
		{
			d60 d = A_0.a();
			if (d != null)
			{
				foreach (b0b b0b in d.ab4(new string[]
				{
					"frag_dun_wasteWater"
				}))
				{
					c5x c5x = (c5x)b0b;
					c5x.w();
					c5x.an();
				}
				A_1.r()["frag_dun_wasteWater_sgsBodiesRemoved"] = true;
			}
		}
	}
}
