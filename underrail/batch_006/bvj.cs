using System;
using System.Runtime.Serialization;

// Token: 0x020007A8 RID: 1960
[eiz("XPBLRIGMurkyRF")]
[Serializable]
public sealed class bvj : egv, ISerializable
{
	// Token: 0x06003139 RID: 12601 RVA: 0x0012E604 File Offset: 0x0012C804
	private bvj(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600313A RID: 12602 RVA: 0x0012E60C File Offset: 0x0012C80C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x0600313B RID: 12603 RVA: 0x0012E610 File Offset: 0x0012C810
	public bvj()
	{
	}

	// Token: 0x0600313C RID: 12604 RVA: 0x0012E61C File Offset: 0x0012C81C
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 != null && A_0.ap9() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_firstRaid_completed", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_completed", new bool?(false)).Value;
				bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_completed", new bool?(false)).Value;
				bool value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_sonarDestroyed", new bool?(false)).Value;
				bool value5 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_attacked", new bool?(false)).Value;
				bool value6 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_plentyKilled", new bool?(false)).Value;
				bool value7 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_rig_blackEels_wipedOut", new bool?(false)).Value;
				float result = 2.7f;
				if (value3 || value4 || value7)
				{
					result = bhm.b;
				}
				else if (value2 || value6)
				{
					result = 3.2f;
				}
				else if (value5 || value)
				{
					result = 3f;
				}
				return result;
			}
		}
		return bhm.a;
	}
}
