using System;
using System.Runtime.Serialization;

// Token: 0x0200094A RID: 2378
[eiz("XPBLAES")]
[Serializable]
public sealed class a8c : bdw, ISerializable
{
	// Token: 0x06003A1F RID: 14879 RVA: 0x00157B28 File Offset: 0x00155D28
	private a8c(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A20 RID: 14880 RVA: 0x00157B30 File Offset: 0x00155D30
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A21 RID: 14881 RVA: 0x00157B34 File Offset: 0x00155D34
	public a8c()
	{
	}

	// Token: 0x06003A22 RID: 14882 RVA: 0x00157B40 File Offset: 0x00155D40
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("xpbl_sc");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("ab5c97db-3246-4f29-b7e4-b5c89e73245a"), aud).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("61eb579c-e4c0-4ef6-ba10-7d54ecb576f3"), aud).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("b77c5fc5-cb78-47fb-9ea0-db9735d9b3d7"), aud).ao() as c5x;
			c5x c5x4 = new ar7(new Guid("69efbfff-9e96-46d4-9ecd-c5e11001c2fb"), aud).ao() as c5x;
			if (c5x != null && c5x.GetAspect<dg2>() != null)
			{
				dqs dqs = new dqs();
				dqs.a(aud.y8());
				dqs.a(new Guid?(c5x.qe()));
				dqs.ym(A_1.v().b(), c5x, null);
			}
			if (c5x2 != null && c5x2.GetAspect<dg2>() != null)
			{
				dqs dqs2 = new dqs();
				dqs2.a(aud.y8());
				dqs2.a(new Guid?(c5x2.qe()));
				dqs2.ym(A_1.v().b(), c5x2, null);
			}
			if (c5x3 != null && c5x3.GetAspect<dg2>() != null)
			{
				dqs dqs3 = new dqs();
				dqs3.a(aud.y8());
				dqs3.a(new Guid?(c5x3.qe()));
				dqs3.ym(A_1.v().b(), c5x3, null);
			}
			if (c5x4 != null && c5x4.GetAspect<dg2>() != null)
			{
				dqs dqs4 = new dqs();
				dqs4.a(aud.y8());
				dqs4.a(new Guid?(c5x4.qe()));
				dqs4.ym(A_1.v().b(), c5x4, null);
			}
		}
	}
}
