using System;

// Token: 0x02000270 RID: 624
public sealed class etl : b76
{
	// Token: 0x06001258 RID: 4696 RVA: 0x0004BFB4 File Offset: 0x0004A1B4
	public bsf a()
	{
		return this.a;
	}

	// Token: 0x06001259 RID: 4697 RVA: 0x0004BFBC File Offset: 0x0004A1BC
	public etl(bsf A_0) : base((A_0 != null) ? A_0.Carrier : null)
	{
		czh.a(A_0, "lantern");
		this.a = A_0;
	}

	// Token: 0x0600125A RID: 4698 RVA: 0x0004BFEC File Offset: 0x0004A1EC
	public override string ToString()
	{
		return string.Format("Entity '{0}'(L{1}) carries a lantern '{2}' which definition is not in the same layer (L{3}).", new object[]
		{
			this.a.Carrier,
			this.a.Carrier.Layer,
			this.a,
			this.a.Definition.Layer
		});
	}

	// Token: 0x04000A2C RID: 2604
	private bsf a;
}
