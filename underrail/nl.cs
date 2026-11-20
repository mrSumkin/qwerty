using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x02000B4C RID: 2892
[eiz("DCSIFBB")]
[Serializable]
public sealed class nl : cze, ISerializable
{
	// Token: 0x06004261 RID: 16993 RVA: 0x0019BAF8 File Offset: 0x00199CF8
	private nl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004262 RID: 16994 RVA: 0x0019BB04 File Offset: 0x00199D04
	public nl()
	{
	}

	// Token: 0x06004263 RID: 16995 RVA: 0x0019BB10 File Offset: 0x00199D10
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = A_0.Area;
		if (aud != null)
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "dc-pp_c_l" + 2.ToString()) + ".uzl");
			aud.Zone.a(a_, 1, null);
			b6r b6r = new b6r();
			b6r.b(aud.y8());
			b6r.b(new Guid("882d3e9b-f0fe-4a76-941e-a02b365b30b9"));
			b6r.a(new Guid("2d37dc6d-30b3-4f3c-a7e4-a7dd4cb9c3f2"));
			b6r.a(bbo.b);
			b6r.ym(A_0, A_1, null);
			b6r b6r2 = new b6r();
			b6r2.b(aud.y8());
			b6r2.b(new Guid("46f1f1a1-2b20-4844-94ef-6191003a4340"));
			b6r2.a(new Guid("6782c324-8645-47fd-9750-c4f881cc565c"));
			b6r2.a(bbo.b);
			b6r2.ym(A_0, A_1, null);
		}
	}
}
