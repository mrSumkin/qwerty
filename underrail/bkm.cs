using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A87 RID: 2695
[eiz("TCHAE")]
[Serializable]
public sealed class bkm : cze, ISerializable
{
	// Token: 0x06003F57 RID: 16215 RVA: 0x0017FB98 File Offset: 0x0017DD98
	private bkm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F58 RID: 16216 RVA: 0x0017FBA4 File Offset: 0x0017DDA4
	public bkm()
	{
	}

	// Token: 0x06003F59 RID: 16217 RVA: 0x0017FBB0 File Offset: 0x0017DDB0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			c5x c5x = A_1 as c5x;
			if (c5x != null)
			{
				c5x.c().a("ElevatorRespond");
			}
			if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_tch_elevatorCalled", new bool?(false)).Value)
			{
				bpo.GetServiceOrThrow<ps>().am3("Tch_RitualRoomInvasion");
			}
		}
	}
}
