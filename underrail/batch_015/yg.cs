using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000B48 RID: 2888
[eiz("S32")]
[Serializable]
public sealed class yg : cze, ISerializable
{
	// Token: 0x06004255 RID: 16981 RVA: 0x0019B26C File Offset: 0x0019946C
	private yg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004256 RID: 16982 RVA: 0x0019B278 File Offset: 0x00199478
	public yg()
	{
	}

	// Token: 0x06004257 RID: 16983 RVA: 0x0019B284 File Offset: 0x00199484
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null)
		{
			aud aud = A_0.Area;
			if (aud != null && aud.Zone != null)
			{
				ar7 ar = new ar7(new Guid("e958bb4c-4534-4dc4-bbdd-e16971bcebe9"), aud);
				ar7 ar2 = new ar7(new Guid("74b88ff4-bde8-4355-9458-ab05c3a7e89f"), aud);
				ar7 ar3 = new ar7(new Guid("2434406e-63dc-4d51-a61c-fc0a9edb678b"), aud);
				EntityAspectReference<amc, amc> entityAspectReference = new EntityAspectReference<amc, amc>(aud, new Guid("bbefcce5-0d54-4602-9bb3-25e6f4e317a4"));
				if (entityAspectReference.ao() != null)
				{
					cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
					if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && !entityAspectReference.ao().aa().Dead && entityAspectReference.ao().aa().a(serviceOrThrow.aqu().ac(), asp.a) != h.a && ar.ao() != null && ar2.ao() != null)
					{
						dtb dtb = new dtb();
						Dictionary<string, object> dictionary = new Dictionary<string, object>();
						dictionary[dmh.e] = new e6z(aud);
						cd0 aspect = ar.ao().GetAspect<cd0>();
						cd0 aspect2 = ar2.ao().GetAspect<cd0>();
						if (aspect.b.X == 5 && aspect2.b.X == 0)
						{
							b6r b6r = new b6r();
							b6r.b(aud.y8());
							b6r.b(new Guid("e958bb4c-4534-4dc4-bbdd-e16971bcebe9"));
							b6r.a(new Guid("112b251a-1f09-479b-82f2-ace0ebe0816c"));
							b6r.a(bbo.c);
							b6r b6r2 = new b6r();
							b6r2.b(aud.y8());
							b6r2.b(new Guid("74b88ff4-bde8-4355-9458-ab05c3a7e89f"));
							b6r2.a(new Guid("5cbed1a5-7b1f-421c-889f-acce128b26d1"));
							b6r2.a(bbo.b);
							dtb.ad().Add(new a4s(b6r, null, null, dictionary));
							dtb.ad().Add(new bm3(2000));
							dtb.ad().Add(new a4s(b6r2, null, null, dictionary));
						}
						else if (aspect.b.X == 0 && aspect2.b.X == 5 && ar3.ao() != null)
						{
							b6r b6r3 = new b6r();
							b6r3.b(aud.y8());
							b6r3.b(new Guid("74b88ff4-bde8-4355-9458-ab05c3a7e89f"));
							b6r3.a(new Guid("5cbed1a5-7b1f-421c-889f-acce128b26d1"));
							b6r3.a(bbo.c);
							b6r b6r4 = new b6r();
							b6r4.b(aud.y8());
							b6r4.b(new Guid("e958bb4c-4534-4dc4-bbdd-e16971bcebe9"));
							b6r4.a(new Guid("112b251a-1f09-479b-82f2-ace0ebe0816c"));
							b6r4.a(bbo.b);
							dtb.ad().Add(new a4s(b6r3, null, null, dictionary));
							dtb.ad().Add(new bm3(2000));
							dtb.ad().Add(new a4s(b6r4, null, null, dictionary));
						}
						aud.Zone.ActionManager.g9(dtb, atp.a);
						dz6.a(dtb);
					}
				}
			}
		}
	}
}
