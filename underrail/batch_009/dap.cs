using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B77 RID: 2935
[eiz("FOUCBJ")]
[Serializable]
public sealed class dap : cze, ISerializable
{
	// Token: 0x06004318 RID: 17176 RVA: 0x001A36D0 File Offset: 0x001A18D0
	private dap(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004319 RID: 17177 RVA: 0x001A36DC File Offset: 0x001A18DC
	public dap()
	{
	}

	// Token: 0x0600431A RID: 17178 RVA: 0x001A36E8 File Offset: 0x001A18E8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0 != null)
		{
			etz etz = A_0.GetAspect<cd0>() as etz;
			if (etz != null)
			{
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_fo5_meltingStarted", new bool?(false)).Value)
				{
					serviceOrThrow.aqu().r()["loc_fo5_conveyorStatus"] = "off";
				}
				if (serviceOrThrow.aqu().r()["loc_fo5_conveyorStatus"] as string == "on")
				{
					etz.b(1);
					int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_fo5_storedOre", new int?(0)).Value;
					int num2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_fo5_loadedOre", new int?(0)).Value;
					if (num > 0)
					{
						num--;
						num2++;
						serviceOrThrow.aqu().r()["loc_fo5_loadedOre"] = num2;
						serviceOrThrow.aqu().r()["loc_fo5_storedOre"] = num;
						if (num2 >= 30)
						{
							serviceOrThrow.aqu().r()["loc_fo5_fullyLoaded"] = true;
							return;
						}
					}
				}
				else
				{
					etz.b(0);
				}
			}
		}
	}
}
