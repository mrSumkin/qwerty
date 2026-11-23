using System;
using System.Runtime.Serialization;

// Token: 0x020009E9 RID: 2537
[eiz("XPHWUP5XF")]
[Serializable]
public sealed class czl : bdw, ISerializable
{
	// Token: 0x06003CAC RID: 15532 RVA: 0x001684F0 File Offset: 0x001666F0
	private czl(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003CAD RID: 15533 RVA: 0x001684F8 File Offset: 0x001666F8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003CAE RID: 15534 RVA: 0x001684FC File Offset: 0x001666FC
	public czl()
	{
	}

	// Token: 0x06003CAF RID: 15535 RVA: 0x00168508 File Offset: 0x00166708
	public void av(c1a A_0, cyt A_1)
	{
		d60 addon = A_0.GetAddon<d60>();
		if (addon != null && dk2.b("xphw") && !A_1.r().GetPrimitivePropertyValue<bool>("loc_up5x_xphwPath_unlocked", new bool?(false)).Value)
		{
			foreach (b0b b0b in addon.ab4(new string[]
			{
				"XPHWFence"
			}))
			{
				b0b.w();
				b0b.an();
			}
			foreach (b0b b0b2 in addon.ab4(new string[]
			{
				"BrokenFence"
			}))
			{
				((c5x)b0b2).ae = null;
			}
			A_1.r()["loc_up5x_xphwPath_unlocked"] = true;
		}
	}
}
