using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B54 RID: 2900
[eiz("CVW17XSUBHJ")]
[Serializable]
public sealed class eek : cze, ISerializable
{
	// Token: 0x06004285 RID: 17029 RVA: 0x0019CBE4 File Offset: 0x0019ADE4
	private eek(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004286 RID: 17030 RVA: 0x0019CBF0 File Offset: 0x0019ADF0
	public eek()
	{
	}

	// Token: 0x06004287 RID: 17031 RVA: 0x0019CBFC File Offset: 0x0019ADFC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			c5x c5x = new ar7(new Guid("0ae0f312-c4d8-481e-b34d-848f489d50a0"), serviceOrThrow.aqw().n("cvw17x")).ao() as c5x;
			if (c5x != null && c5x.h.b != null)
			{
				c5x.h.b.aa().Defense.q().zp(70f);
			}
		}
	}
}
