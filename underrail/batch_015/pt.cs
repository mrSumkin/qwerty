using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000A85 RID: 2693
[eiz("TCHUEJ")]
[Serializable]
public sealed class pt : cze, ISerializable
{
	// Token: 0x06003F51 RID: 16209 RVA: 0x0017F8F8 File Offset: 0x0017DAF8
	private pt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F52 RID: 16210 RVA: 0x0017F904 File Offset: 0x0017DB04
	public pt()
	{
	}

	// Token: 0x06003F53 RID: 16211 RVA: 0x0017F910 File Offset: 0x0017DB10
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_1 != null && A_1.Zone != null)
		{
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_tch_elevatorCalled", new bool?(false)).Value;
			bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_tch_elevatorArrived", new bool?(false)).Value;
			int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_tch_elevatorLocation", new int?(0)).Value;
			if (value && !value2)
			{
				num++;
				c5x c5x = new ar7(new Guid("f9d7c7b8-9afd-45c3-b488-e41002788ec9"), A_1.Area).ao() as c5x;
				if (c5x != null && c5x.p.b != null)
				{
					foreach (cd0 cd in c5x.p.b.a)
					{
						cd.b = new Point(num, cd.b.Y);
					}
				}
				serviceOrThrow.aqu().r()["loc_tch_elevatorLocation"] = num;
				if (num >= 6)
				{
					serviceOrThrow.aqu().r()["loc_tch_elevatorArrived"] = true;
					bpo.GetServiceOrThrow<ps>().am3("Tch_ElevatorArrives");
				}
			}
		}
	}
}
