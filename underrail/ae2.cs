using System;
using System.Runtime.Serialization;

// Token: 0x02000A40 RID: 2624
[eiz("XPBLLECUC")]
[Serializable]
public sealed class ae2 : bdw, ISerializable
{
	// Token: 0x06003E33 RID: 15923 RVA: 0x00176C3C File Offset: 0x00174E3C
	private ae2(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003E34 RID: 15924 RVA: 0x00176C44 File Offset: 0x00174E44
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003E35 RID: 15925 RVA: 0x00176C48 File Offset: 0x00174E48
	public ae2()
	{
	}

	// Token: 0x06003E36 RID: 15926 RVA: 0x00176C54 File Offset: 0x00174E54
	public void av(c1a A_0, cyt A_1)
	{
		if (A_1.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionshouldUndeploy", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionUndeployed", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionDestroyed", new bool?(false)).Value && dh7.a != null && dh7.a.c != null)
		{
			if (dh7.a.c.Contains("xpbl_d5") || dh7.a.c.Contains("xpbl_d6") || dh7.a.c.Contains("xpbl_e5") || dh7.a.c.Contains("xpbl_e6") || dh7.a.c.Contains("xpbl_fu"))
			{
				return;
			}
			new e39().ym(null, null, null);
		}
	}
}
