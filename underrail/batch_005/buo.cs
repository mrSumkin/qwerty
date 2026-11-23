using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000A75 RID: 2677
[eiz("DCTOMTGJ")]
[Serializable]
public sealed class buo : cze, ISerializable
{
	// Token: 0x06003F15 RID: 16149 RVA: 0x0017DD0C File Offset: 0x0017BF0C
	private buo(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F16 RID: 16150 RVA: 0x0017DD18 File Offset: 0x0017BF18
	public buo()
	{
	}

	// Token: 0x06003F17 RID: 16151 RVA: 0x0017DD24 File Offset: 0x0017BF24
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_dc_repairGateCompleted", new bool?(false)).Value;
			bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_dc_gateSlimeRemoved", new bool?(false)).Value;
			c5x c5x = A_1 as c5x;
			if (c5x != null && c5x.u.b != null)
			{
				c5x c5x2 = new ar7(new Guid("5b03c5ff-d422-41a8-86f0-1e4b01212a44"), A_1.Area).ao() as c5x;
				if (c5x2 != null && c5x2.o.b != null)
				{
					bool flag = c5x2.o.b.b == Point.Zero;
					if (!value)
					{
						c5x.u.b.a("Ничего не происходит.", true, null, null);
						return;
					}
					if (!value2)
					{
						c5x.u.b.a("Биомасса препятствует открытию ворот.", true, null, null);
						return;
					}
					if (!flag)
					{
						c5x.u.b.a("Ворота не закрываются.", true, null, null);
						return;
					}
					egn egn = new egn();
					egn.b(new Guid("5b03c5ff-d422-41a8-86f0-1e4b01212a44"));
					egn.a(new Guid("99826dd6-e798-4d08-9395-bad82a934e17"));
					egn.a("dc-de2");
					egn.a(bbo.b);
					egn.ym(A_0, A_1, null);
					serviceOrThrow.aqu().r()["loc_dc_gateOpened"] = true;
					if (serviceOrThrow.aqz() != null)
					{
						serviceOrThrow.aqz().atc("dc_getPastGate", true);
					}
				}
			}
		}
	}
}
