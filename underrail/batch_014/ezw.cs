using System;

// Token: 0x02000273 RID: 627
public sealed class ezw : b76
{
	// Token: 0x06001265 RID: 4709 RVA: 0x0004CAD8 File Offset: 0x0004ACD8
	public e4b a()
	{
		return this.a;
	}

	// Token: 0x06001266 RID: 4710 RVA: 0x0004CAE0 File Offset: 0x0004ACE0
	public ezw(e4b A_0) : base(A_0)
	{
		czh.a(A_0, "softLightArea");
		this.a = A_0;
	}

	// Token: 0x06001267 RID: 4711 RVA: 0x0004CAFC File Offset: 0x0004ACFC
	public override string ToString()
	{
		return string.Format("Soft Light Area '{0}'(L{1}) is not in the same layer as it's Soft Light Emitter '{2}'(L{3}).", new object[]
		{
			this.a,
			this.a.m4(),
			this.a.b(),
			this.a.b().Layer
		});
	}

	// Token: 0x04000A31 RID: 2609
	private e4b a;
}
