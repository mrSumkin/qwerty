using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200102F RID: 4143
[eiz("ARJ")]
[Serializable]
public sealed class d2p : cze, ISerializable
{
	// Token: 0x06005590 RID: 21904 RVA: 0x0025BF24 File Offset: 0x0025A124
	private d2p(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005591 RID: 21905 RVA: 0x0025BF30 File Offset: 0x0025A130
	public d2p()
	{
	}

	// Token: 0x06005592 RID: 21906 RVA: 0x0025BF3C File Offset: 0x0025A13C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			eh6 eh = A_1.GetAspect<bim>() as eh6;
			if (eh != null)
			{
				eh.d();
				bpo.GetServiceOrThrow<e5f>().ash("rift", null);
			}
		}
	}
}
