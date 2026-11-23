using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B46 RID: 2886
[eiz("S33")]
[Serializable]
public sealed class e3g : cze, ISerializable
{
	// Token: 0x0600424F RID: 16975 RVA: 0x0019AF88 File Offset: 0x00199188
	private e3g(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004250 RID: 16976 RVA: 0x0019AF94 File Offset: 0x00199194
	public e3g()
	{
	}

	// Token: 0x06004251 RID: 16977 RVA: 0x0019AF9C File Offset: 0x0019919C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_0 as c5x;
		if (c5x != null && c5x.h.b != null)
		{
			aud aud = A_0.Area;
			if (aud != null && aud.Zone != null)
			{
				if (Enumerable.Any<coh>(c5x.h.b.aa().Bag.b("key.sgsCaveAccess")))
				{
					c5x.c().a(Guid.NewGuid().ToString(), "UnlockDigi", 1f, c9z.a, false, false);
					dtb dtb = new dtb();
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					dictionary[dmh.e] = new e6z(aud);
					b6r b6r = new b6r();
					b6r.b(aud.y8());
					b6r.b(new Guid("74b88ff4-bde8-4355-9458-ab05c3a7e89f"));
					b6r.a(new Guid("5cbed1a5-7b1f-421c-889f-acce128b26d1"));
					b6r.a(bbo.b);
					dtb.ad().Add(new a4s(b6r, null, null, dictionary));
					aud.Zone.ActionManager.g9(dtb, atp.a);
					dz6.a(dtb);
					return;
				}
				if (A_1 != null)
				{
					bmj.a(A_1, new d53("Требуется ключ-карта", adi.l, null, true));
				}
				c5x.c().a(Guid.NewGuid().ToString(), "HackingFailure", 1f, c9z.a, false, false);
			}
		}
	}
}
