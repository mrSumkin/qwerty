using System;
using System.Runtime.Serialization;

// Token: 0x02000790 RID: 1936
[eiz("FDDarlingRF")]
[Serializable]
public sealed class bm8 : egv, ISerializable
{
	// Token: 0x060030D9 RID: 12505 RVA: 0x0012CB78 File Offset: 0x0012AD78
	private bm8(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060030DA RID: 12506 RVA: 0x0012CB80 File Offset: 0x0012AD80
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x060030DB RID: 12507 RVA: 0x0012CB84 File Offset: 0x0012AD84
	public bm8()
	{
	}

	// Token: 0x060030DC RID: 12508 RVA: 0x0012CB90 File Offset: 0x0012AD90
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 != null && A_0.ap9() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_fd_GetEquipmentFromJunkyardCompleted", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_fd_SabotageElevatorCompleted", new bool?(false)).Value;
				bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_fd_AttackSROCompleted", new bool?(false)).Value;
				bool value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_fd_revealSpyCompleted", new bool?(false)).Value;
				int value5 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_lup-a8prison_prisonersEscaped", new int?(0)).Value;
				float num = bhm.a;
				if (value)
				{
					num -= 0.2f;
				}
				if (value2)
				{
					num -= 0.2f;
				}
				if (value3)
				{
					num -= 0.3f;
				}
				if (value4)
				{
					num -= 0.3f;
				}
				if (value5 >= 1)
				{
					num -= 0.1f * (float)value5;
				}
				return Math.Max(bhm.c, num);
			}
		}
		return bhm.a;
	}
}
