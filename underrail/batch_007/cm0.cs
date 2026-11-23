using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000ACB RID: 2763
[eiz("XPHWEBSDJ")]
[Serializable]
public sealed class cm0 : cze, ISerializable
{
	// Token: 0x0600406E RID: 16494 RVA: 0x0018816C File Offset: 0x0018636C
	private cm0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600406F RID: 16495 RVA: 0x00188178 File Offset: 0x00186378
	public cm0()
	{
	}

	// Token: 0x06004070 RID: 16496 RVA: 0x00188180 File Offset: 0x00186380
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_1 != null && A_1.GetAspect<amc>() != null)
		{
			string str = "faction_xphw_exoBase_";
			if ((A_1 as c5x).a("SuperExosoldier"))
			{
				serviceOrThrow.aqu().r()[str + "superExosoldiers_killed"] = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>(str + "superExosoldiers_killed", new int?(0)).Value + 1;
				return;
			}
			int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>(str + "exosoldiers_killed", new int?(0)).Value + 1;
			serviceOrThrow.aqu().r()[str + "exosoldiers_killed"] = num;
			if (num >= 12)
			{
				serviceOrThrow.aqu().r()[str + "exosoldiers_tooManyKilled"] = true;
			}
		}
	}
}
