using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000AE9 RID: 2793
[eiz("XPBLSCCCFRJ")]
[Serializable]
public sealed class a1b : cze, ISerializable
{
	// Token: 0x060040F3 RID: 16627 RVA: 0x0018C2EC File Offset: 0x0018A4EC
	private a1b(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060040F4 RID: 16628 RVA: 0x0018C2F8 File Offset: 0x0018A4F8
	public a1b()
	{
	}

	// Token: 0x060040F5 RID: 16629 RVA: 0x0018C304 File Offset: 0x0018A504
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			bv9 bv = serviceOrThrow.aqu().ac() as bv9;
			if (bv != null)
			{
				bv.a(asp.f6, asp.d1, h.c, null, true, false, false);
				bv.a(asp.f6, asp.d0, h.c, null, true, false, false);
				bv.a(asp.f6, asp.dz, h.c, null, true, false, false);
				bv.a(asp.f5, asp.d1, h.c, null, true, false, false);
				bv.a(asp.f5, asp.d0, h.c, null, true, false, false);
				bv.a(asp.f5, asp.dz, h.c, null, true, false, false);
			}
		}
	}
}
