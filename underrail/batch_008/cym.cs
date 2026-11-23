using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000A71 RID: 2673
[eiz("DCUSOEBJ")]
[Serializable]
public sealed class cym : cze, ISerializable
{
	// Token: 0x06003F08 RID: 16136 RVA: 0x0017D57C File Offset: 0x0017B77C
	private cym(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F09 RID: 16137 RVA: 0x0017D588 File Offset: 0x0017B788
	public cym()
	{
	}

	// Token: 0x06003F0A RID: 16138 RVA: 0x0017D594 File Offset: 0x0017B794
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
				if (value != 0 || value3 != 0)
				{
					if (value2 != 0)
					{
						serviceOrThrow.aqu().r()["loc_dc_elevator_target"] = 0;
						return;
					}
				}
				else if (value2 == 0)
				{
					b0e b0e = new EntityAspectReference<b0e, bim>(c5x.Area, new Guid("1d126757-20f1-4fbc-89d6-b51fb843b45b")).ao();
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
