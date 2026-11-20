using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B4B RID: 2891
[eiz("DCPC")]
[Serializable]
public sealed class bzw : cze, ISerializable
{
	// Token: 0x0600425E RID: 16990 RVA: 0x0019B8A0 File Offset: 0x00199AA0
	private bzw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600425F RID: 16991 RVA: 0x0019B8AC File Offset: 0x00199AAC
	public bzw()
	{
	}

	// Token: 0x06004260 RID: 16992 RVA: 0x0019B8B4 File Offset: 0x00199AB4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
		if (serviceOrThrow.aqu() != null && c5x != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("quest_dc_repairGate_canistersAcquired", new int?(0)).Value < 3)
		{
			c5x c5x2 = new ar7(new Guid("4ddef6c1-46e0-4050-8b38-e655a4d6e863"), c5x.Area).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("65f9243c-ef99-45a3-841d-bed16449e746"), c5x.Area).ao() as c5x;
			c5x c5x4 = new ar7(new Guid("4d46242f-a4da-4a9e-ada5-65ac13a9aab9"), c5x.Area).ao() as c5x;
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("quest_dc_repairGate_canistersAcquired", new int?(0)).Value > 0 && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_dc-door1_placeCanister1", new bool?(false)).Value)
			{
				c5x2.GetAspect<cd0>().d = new float?((float)1);
				serviceOrThrow.aqu().r()["loc_dc-door1_placeCanister1"] = true;
			}
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("quest_dc_repairGate_canistersAcquired", new int?(0)).Value > 1 && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_dc-door1_placeCanister2", new bool?(false)).Value)
			{
				c5x3.GetAspect<cd0>().d = new float?((float)1);
				serviceOrThrow.aqu().r()["loc_dc-door1_placeCanister2"] = true;
			}
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("quest_dc_repairGate_canistersAcquired", new int?(0)).Value > 2 && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_dc-door1_placeCanister3", new bool?(false)).Value)
			{
				c5x4.GetAspect<cd0>().d = new float?((float)1);
				serviceOrThrow.aqu().r()["loc_dc-door1_placeCanister3"] = true;
			}
		}
	}
}
