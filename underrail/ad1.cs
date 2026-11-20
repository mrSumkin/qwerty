using System;
using System.Runtime.Serialization;

// Token: 0x02000936 RID: 2358
[eiz("CVWPOADI")]
[Serializable]
public sealed class ad1 : bdw, ISerializable
{
	// Token: 0x060039CE RID: 14798 RVA: 0x00155E68 File Offset: 0x00154068
	private ad1(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060039CF RID: 14799 RVA: 0x00155E70 File Offset: 0x00154070
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060039D0 RID: 14800 RVA: 0x00155E74 File Offset: 0x00154074
	public ad1()
	{
	}

	// Token: 0x060039D1 RID: 14801 RVA: 0x00155E7C File Offset: 0x0015407C
	public void av(c1a A_0, cyt A_1)
	{
		string name = "loc_" + A_0.y8() + "_protectorateOutpost_warnedEntrance";
		if (!A_1.r().GetPrimitivePropertyValue<bool>(name, new bool?(false)).Value && A_1.r().GetPrimitivePropertyValue<bool>("faction_protectorate_joined", new bool?(false)).Value)
		{
			A_1.r()[name] = true;
		}
	}
}
