using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B51 RID: 2897
[eiz("DCPPUEF")]
[Serializable]
public sealed class d7q : cze, ISerializable
{
	// Token: 0x0600427C RID: 17020 RVA: 0x0019C89C File Offset: 0x0019AA9C
	private d7q(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600427D RID: 17021 RVA: 0x0019C8A8 File Offset: 0x0019AAA8
	public d7q()
	{
	}

	// Token: 0x0600427E RID: 17022 RVA: 0x0019C8B4 File Offset: 0x0019AAB4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.Zone != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				axh aspect = (new ar7(new Guid("e615ce22-3c84-4973-a4bd-042ff72b0db8"), A_1.Area).ao() as c5x).GetAspect<axh>();
				int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc-pp_ut_powerSwitchCounter", new int?(2)).Value - 1;
				if (num <= 0)
				{
					if (aspect != null && aspect.i())
					{
						num = 2;
					}
					else
					{
						num = 3;
					}
					if (aspect != null)
					{
						aspect.a(null, !aspect.i(), null);
					}
				}
				serviceOrThrow.aqu().r()["loc_dc-pp_ut_powerSwitchCounter"] = num;
			}
		}
	}
}
