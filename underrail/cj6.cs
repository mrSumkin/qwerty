using System;
using System.Runtime.Serialization;

// Token: 0x020007AD RID: 1965
[eiz("FOKevinRF")]
[Serializable]
public sealed class cj6 : egv, ISerializable
{
	// Token: 0x0600314D RID: 12621 RVA: 0x0012EA38 File Offset: 0x0012CC38
	private cj6(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600314E RID: 12622 RVA: 0x0012EA40 File Offset: 0x0012CC40
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x0600314F RID: 12623 RVA: 0x0012EA44 File Offset: 0x0012CC44
	public cj6()
	{
	}

	// Token: 0x06003150 RID: 12624 RVA: 0x0012EA50 File Offset: 0x0012CC50
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 != null && A_0.ap9() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_fo_mineReopened", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_fo_chief_killBalorCompleted", new bool?(false)).Value;
				int value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("SpecialMerchandiseLevel_kevin", new int?(-1)).Value;
				if (value)
				{
					return 2f;
				}
				float num = bhm.b;
				if (value2)
				{
					num -= 1f;
				}
				if (value3 >= 0)
				{
					num -= 0.5f;
				}
				return Math.Max(bhm.c, num);
			}
		}
		return bhm.a;
	}
}
