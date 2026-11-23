using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A70 RID: 2672
[eiz("DCUSIEBJ")]
[Serializable]
public sealed class duu : cze, ISerializable
{
	// Token: 0x06003F05 RID: 16133 RVA: 0x0017D518 File Offset: 0x0017B718
	private duu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F06 RID: 16134 RVA: 0x0017D524 File Offset: 0x0017B724
	public duu()
	{
	}

	// Token: 0x06003F07 RID: 16135 RVA: 0x0017D530 File Offset: 0x0017B730
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null)
		{
			c5x c5x = A_1 as c5x;
			if (c5x != null)
			{
				c5x.c().a("ElevatorRespond");
			}
			bpo.GetServiceOrThrow<ps>().am3("Dc_ElevatorAscends");
		}
	}
}
