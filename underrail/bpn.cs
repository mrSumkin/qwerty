using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B33 RID: 2867
[eiz("S77")]
[Serializable]
public sealed class bpn : cze, ISerializable
{
	// Token: 0x0600420C RID: 16908 RVA: 0x001995DC File Offset: 0x001977DC
	private bpn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600420D RID: 16909 RVA: 0x001995E8 File Offset: 0x001977E8
	public bpn()
	{
	}

	// Token: 0x0600420E RID: 16910 RVA: 0x001995F4 File Offset: 0x001977F4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_0 as c5x;
		if (c5x != null && c5x.h.b != null)
		{
			aud aud = A_0.Area;
			if (aud != null && aud.Zone != null)
			{
				if (Enumerable.Any<coh>(c5x.h.b.aa().Bag.b("key_gms_sealedDoor")))
				{
					c5x.c().a(Guid.NewGuid().ToString(), "UnlockDigi", 1f, c9z.a, false, false);
					dtb dtb = new dtb();
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					dictionary[dmh.e] = new e6z(aud);
					b6r b6r = new b6r();
					b6r.b(aud.y8());
					b6r.b(new Guid("c6d0ca09-2f1d-4e4a-ad15-35268180a2d5"));
					b6r.a(new Guid("75d277cb-7c7b-40f8-9d76-8e7ce7be0d91"));
					b6r.a(bbo.a);
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
