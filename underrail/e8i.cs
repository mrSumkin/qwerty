using System;
using System.Runtime.Serialization;

// Token: 0x02000F66 RID: 3942
[eiz("XPBLF1RBRC")]
[Serializable]
public sealed class e8i : dnh, ISerializable
{
	// Token: 0x06004FEB RID: 20459 RVA: 0x0023DF2C File Offset: 0x0023C12C
	private e8i(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06004FEC RID: 20460 RVA: 0x0023DF34 File Offset: 0x0023C134
	public new void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x06004FED RID: 20461 RVA: 0x0023DF38 File Offset: 0x0023C138
	public e8i()
	{
	}

	// Token: 0x06004FEE RID: 20462 RVA: 0x0023DF40 File Offset: 0x0023C140
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_f1_meltedIceBlock", new bool?(false)).Value;
			bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_f1_canSeeWaterfallRockBridge", new bool?(false)).Value;
			bool flag = serviceOrThrow.aqu().v().Feats.Contains<c3v>();
			int will = serviceOrThrow.aqu().v().BaseAbilities.Will;
			int num = serviceOrThrow.aqu().v().Skills.Get<dql>().g();
			bool flag2 = serviceOrThrow.aqu().v().StatusEffects.a("secondSight");
			if (value || value2 || (flag && (will >= 11 || num >= 130)) || (flag2 && (will >= 7 || num >= 80)))
			{
				return true;
			}
		}
		return false;
	}
}
