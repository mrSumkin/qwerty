using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A86 RID: 2694
[eiz("TCHCE")]
[Serializable]
public sealed class a9r : cze, ISerializable
{
	// Token: 0x06003F54 RID: 16212 RVA: 0x0017FAB4 File Offset: 0x0017DCB4
	private a9r(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F55 RID: 16213 RVA: 0x0017FAC0 File Offset: 0x0017DCC0
	public a9r()
	{
	}

	// Token: 0x06003F56 RID: 16214 RVA: 0x0017FACC File Offset: 0x0017DCCC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0 != null && A_0.Area != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_tch_elevatorCalled", new bool?(false)).Value)
		{
			c5x c5x = new ar7(new Guid("4a06d414-a0a5-4f6e-a0c4-0de681b2d2c8"), A_0.Area).ao() as c5x;
			if (c5x != null)
			{
				etz etz = c5x.o.b as etz;
				if (etz != null)
				{
					etz.c(3);
				}
				c5x.c().a("elevator", false);
				c5x.c().a("elevator", "InstituteElevatorLoop", 1f, c9z.a, true, false);
			}
		}
	}
}
