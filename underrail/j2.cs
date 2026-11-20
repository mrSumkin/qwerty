using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A76 RID: 2678
[eiz("DCRTC")]
[Serializable]
public sealed class j2 : cze, ISerializable
{
	// Token: 0x06003F18 RID: 16152 RVA: 0x0017DF14 File Offset: 0x0017C114
	private j2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F19 RID: 16153 RVA: 0x0017DF20 File Offset: 0x0017C120
	public j2()
	{
	}

	// Token: 0x06003F1A RID: 16154 RVA: 0x0017DF2C File Offset: 0x0017C12C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		eaq eaq = new eaq();
		eaq.b(asp.ch);
		eaq.a(asp.e5);
		eaq.a(h.a);
		eaq.a(true);
		eaq.ym(null, null, null);
		foreach (d4n d4n in bpo.GetServiceOrThrow<d02>().ahl())
		{
			if (d4n.b != null && d4n.b.aa().FactionId == asp.e5 && d4n.b.a8().t.b != null)
			{
				d4n.b.a8().t.b.y6()[ddq.ay] = new bt4("TchortistsEscape");
			}
		}
	}
}
