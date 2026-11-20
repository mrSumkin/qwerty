using System;
using System.Runtime.Serialization;

// Token: 0x0200198B RID: 6539
[dn2("rustingAcidSplash")]
[eiz("RACYX2")]
[Serializable]
public sealed class bo6 : buu, ISerializable
{
	// Token: 0x06008BCE RID: 35790 RVA: 0x003900F4 File Offset: 0x0038E2F4
	private bo6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008BCF RID: 35791 RVA: 0x00390100 File Offset: 0x0038E300
	public bo6()
	{
	}

	// Token: 0x06008BD0 RID: 35792 RVA: 0x00390108 File Offset: 0x0038E308
	public override string e1(edm A_0)
	{
		return qv.a("HitEffects/RustingAcidSplash", new object[]
		{
			ce.c,
			l4.a(ce.b, false),
			ce.a
		});
	}
}
