using System;
using System.Runtime.Serialization;

// Token: 0x020007AE RID: 1966
[eiz("FDBecketRF")]
[Serializable]
public sealed class d9q : egv, ISerializable
{
	// Token: 0x06003151 RID: 12625 RVA: 0x0012EB34 File Offset: 0x0012CD34
	private d9q(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003152 RID: 12626 RVA: 0x0012EB3C File Offset: 0x0012CD3C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x06003153 RID: 12627 RVA: 0x0012EB40 File Offset: 0x0012CD40
	public d9q()
	{
	}

	// Token: 0x06003154 RID: 12628 RVA: 0x0012EB4C File Offset: 0x0012CD4C
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
