using System;

// Token: 0x0200192B RID: 6443
[AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
internal sealed class elw : Attribute
{
	// Token: 0x060088BD RID: 35005 RVA: 0x00388578 File Offset: 0x00386778
	public Type a()
	{
		return this.a;
	}

	// Token: 0x060088BE RID: 35006 RVA: 0x00388580 File Offset: 0x00386780
	public elw(Type A_0)
	{
		this.a = A_0;
	}

	// Token: 0x04003692 RID: 13970
	private Type a;
}
