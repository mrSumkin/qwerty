using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A7F RID: 2687
[eiz("TCHSRTV")]
[Serializable]
public sealed class d66 : cze, ISerializable
{
	// Token: 0x06003F3C RID: 16188 RVA: 0x0017EECC File Offset: 0x0017D0CC
	private d66(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F3D RID: 16189 RVA: 0x0017EED8 File Offset: 0x0017D0D8
	public d66()
	{
	}

	// Token: 0x06003F3E RID: 16190 RVA: 0x0017EEE4 File Offset: 0x0017D0E4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		eaq eaq = new eaq();
		eaq.b(asp.ev);
		eaq.a(asp.es);
		eaq.a(h.a);
		eaq.a(true);
		eaq.ym(null, null, null);
		foreach (d4n d4n in bpo.GetServiceOrThrow<d02>().ahl())
		{
			if (d4n.b != null && d4n.b.aa().FactionId == asp.ev && d4n.b.a8().t.b != null)
			{
				d4n.b.a8().t.b.y6()[ddq.ay] = new bt4("rejectEscape");
			}
		}
	}
}
