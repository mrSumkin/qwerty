using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A6E RID: 2670
[eiz("CVUSIEBJ")]
[Serializable]
public sealed class ckz : cze, ISerializable
{
	// Token: 0x06003EFF RID: 16127 RVA: 0x0017D350 File Offset: 0x0017B550
	private ckz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F00 RID: 16128 RVA: 0x0017D35C File Offset: 0x0017B55C
	public ckz()
	{
	}

	// Token: 0x06003F01 RID: 16129 RVA: 0x0017D368 File Offset: 0x0017B568
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null)
		{
			c5x c5x = A_1 as c5x;
			if (c5x != null)
			{
				c5x.c().a("ElevatorRespond");
			}
			bpo.GetServiceOrThrow<ps>().am3("Cv_ElevatorDescends");
		}
	}
}
