using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B2E RID: 2862
[eiz("GMSJ2")]
[Serializable]
public sealed class aja : cze, ISerializable
{
	// Token: 0x060041FD RID: 16893 RVA: 0x00199110 File Offset: 0x00197310
	private aja(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060041FE RID: 16894 RVA: 0x0019911C File Offset: 0x0019731C
	public aja()
	{
	}

	// Token: 0x060041FF RID: 16895 RVA: 0x00199128 File Offset: 0x00197328
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud a_ = bpo.GetServiceOrThrow<cnk>().aqu().v().b().Area;
		c5x c5x = new ar7(new Guid("93710c5d-93da-4eda-ad7f-9a3e383df839"), a_).ao() as c5x;
		c5x c5x2 = new ar7(new Guid("4eeccca7-07d5-4c58-9d18-0dcb181d6c6a"), a_).ao() as c5x;
		if (c5x != null)
		{
			c5x.t.b.y6()[ddq.ay] = new bt4("guardNew1");
		}
		if (c5x2 != null)
		{
			c5x2.t.b.y6()[ddq.ay] = new bt4("guardNew2");
		}
	}
}
