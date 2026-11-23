using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A84 RID: 2692
[eiz("TCHUEICJ")]
[Serializable]
public sealed class kf : cze, ISerializable
{
	// Token: 0x06003F4E RID: 16206 RVA: 0x0017F894 File Offset: 0x0017DA94
	private kf(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F4F RID: 16207 RVA: 0x0017F8A0 File Offset: 0x0017DAA0
	public kf()
	{
	}

	// Token: 0x06003F50 RID: 16208 RVA: 0x0017F8AC File Offset: 0x0017DAAC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null)
		{
			c5x c5x = A_1 as c5x;
			if (c5x != null)
			{
				c5x.c().a("ElevatorRespond");
				bpo.GetServiceOrThrow<ps>().am3("Tch_ElevatorDescends");
			}
		}
	}
}
