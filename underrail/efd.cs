using System;
using System.Runtime.Serialization;

// Token: 0x0200093C RID: 2364
[eiz("XPBLASFTLFS")]
[Serializable]
public sealed class efd : bdw, ISerializable
{
	// Token: 0x060039E6 RID: 14822 RVA: 0x001566D8 File Offset: 0x001548D8
	private efd(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060039E7 RID: 14823 RVA: 0x001566E0 File Offset: 0x001548E0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060039E8 RID: 14824 RVA: 0x001566E4 File Offset: 0x001548E4
	public efd()
	{
	}

	// Token: 0x060039E9 RID: 14825 RVA: 0x001566F0 File Offset: 0x001548F0
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("xpbl_ds2");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("8b993b71-2472-446c-a9ba-30099404c50d"), aud).ao() as c5x;
			if (c5x != null && A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_as_todd_unlockedWillingly", new bool?(false)).Value && A_1.r().GetPrimitivePropertyValue<bool>("xpbl_ds3_acornTaken", new bool?(false)).Value)
			{
				A_1.r()["npc_xpbl_as_todd_goToSubmarine"] = true;
				c5x.w();
				c5x.an();
			}
		}
	}
}
