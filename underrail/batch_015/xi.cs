using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A48 RID: 2632
[eiz("DCDEBAVPJ")]
[Serializable]
public sealed class xi : cze
{
	// Token: 0x06003E55 RID: 15957 RVA: 0x00178430 File Offset: 0x00176630
	private xi(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003E56 RID: 15958 RVA: 0x0017843C File Offset: 0x0017663C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06003E57 RID: 15959 RVA: 0x00178448 File Offset: 0x00176648
	public xi()
	{
	}

	// Token: 0x06003E58 RID: 15960 RVA: 0x00178454 File Offset: 0x00176654
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			c5x c5x = new ar7(new Guid("2133a532-0c38-45f0-89a8-4fe6819272d0"), serviceOrThrow.aqw().n("dc-vp")).ao() as c5x;
			if (c5x != null && c5x.h.b != null)
			{
				c5x.h.b.a(null, false);
			}
		}
	}
}
