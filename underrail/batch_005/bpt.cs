using System;

// Token: 0x0200026E RID: 622
public sealed class bpt : b76
{
	// Token: 0x06001252 RID: 4690 RVA: 0x0004BEFC File Offset: 0x0004A0FC
	public c6g a()
	{
		return this.a;
	}

	// Token: 0x06001253 RID: 4691 RVA: 0x0004BF04 File Offset: 0x0004A104
	public bpt(c6g A_0) : base((A_0 != null) ? A_0.Carrier : null)
	{
		czh.a(A_0, "eye");
		this.a = A_0;
	}

	// Token: 0x06001254 RID: 4692 RVA: 0x0004BF30 File Offset: 0x0004A130
	public override string ToString()
	{
		return string.Format("Entity '{0}'(L{1}) carries an eye '{2}' which definition is not in the same layer (L{3}).", new object[]
		{
			this.a.Carrier,
			this.a.Carrier.Layer,
			this.a,
			this.a.Definition.Layer
		});
	}

	// Token: 0x04000A2A RID: 2602
	private c6g a;
}
