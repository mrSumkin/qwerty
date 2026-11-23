using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000A6F RID: 2671
[eiz("CVUSOEBJ")]
[Serializable]
public sealed class a9x : cze, ISerializable
{
	// Token: 0x06003F02 RID: 16130 RVA: 0x0017D3B4 File Offset: 0x0017B5B4
	private a9x(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F03 RID: 16131 RVA: 0x0017D3C0 File Offset: 0x0017B5C0
	public a9x()
	{
	}

	// Token: 0x06003F04 RID: 16132 RVA: 0x0017D3CC File Offset: 0x0017B5CC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			c5x c5x = A_1 as c5x;
			if (c5x != null)
			{
				c5x.c().a("ElevatorRespond");
				int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_elevator_position", new int?(0)).Value;
				int value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_elevator_target", new int?(0)).Value;
				int value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_dc_elevatorStage", new int?(0)).Value;
				if (value != 1 || value3 != afi.a)
				{
					if (value2 != 1)
					{
						serviceOrThrow.aqu().r()["loc_dc_elevator_target"] = 1;
						return;
					}
				}
				else if (value2 == 1)
				{
					b0e b0e = new EntityAspectReference<b0e, bim>(c5x.Area, new Guid("40e5f4e1-9429-4702-95a4-c69757eb67a5")).ao();
					if (b0e != null && !b0e.q())
					{
						b0e.g(true);
						b0e.a(null, null, false, false);
						b0e.g(false);
						b0e.a8().c().a("InstituteElevatorGate");
					}
				}
			}
		}
	}
}
