using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000B47 RID: 2887
[eiz("S31")]
[Serializable]
public sealed class b9q : cze, ISerializable
{
	// Token: 0x06004252 RID: 16978 RVA: 0x0019B10C File Offset: 0x0019930C
	private b9q(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004253 RID: 16979 RVA: 0x0019B118 File Offset: 0x00199318
	public b9q()
	{
	}

	// Token: 0x06004254 RID: 16980 RVA: 0x0019B124 File Offset: 0x00199324
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null)
		{
			aud aud = A_0.Area;
			if (aud != null && aud.Zone != null)
			{
				EntityAspectReference<amc, amc> entityAspectReference = new EntityAspectReference<amc, amc>(aud, new Guid("bbefcce5-0d54-4602-9bb3-25e6f4e317a4"));
				if (entityAspectReference.ao() != null && bpo.GetServiceOrThrow<cnk>().aqu() != null && !entityAspectReference.ao().aa().Dead)
				{
					dtb dtb = new dtb();
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					dictionary[dmh.e] = new e6z(aud);
					b6r b6r = new b6r();
					b6r.b(aud.y8());
					b6r.b(new Guid("e958bb4c-4534-4dc4-bbdd-e16971bcebe9"));
					b6r.a(new Guid("112b251a-1f09-479b-82f2-ace0ebe0816c"));
					b6r.a(bbo.c);
					b6r b6r2 = new b6r();
					b6r2.b(aud.y8());
					b6r2.b(new Guid("74b88ff4-bde8-4355-9458-ab05c3a7e89f"));
					b6r2.a(new Guid("5cbed1a5-7b1f-421c-889f-acce128b26d1"));
					b6r2.a(bbo.c);
					dtb.ad().Add(new a4s(b6r, null, null, dictionary));
					dtb.ad().Add(new a4s(b6r2, null, null, dictionary));
					aud.Zone.ActionManager.g9(dtb, atp.a);
					dz6.a(dtb);
				}
			}
		}
	}
}
