using System;
using System.Collections.ObjectModel;
using Ouroboros.Common.Data;

// Token: 0x02000075 RID: 117
public abstract class exy : eu
{
	// Token: 0x06000242 RID: 578 RVA: 0x0000B7C0 File Offset: 0x000099C0
	public PropertyCollection au8()
	{
		return this.a;
	}

	// Token: 0x06000243 RID: 579 RVA: 0x0000B7C8 File Offset: 0x000099C8
	public void au9(PropertyCollection A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000244 RID: 580 RVA: 0x0000B7D4 File Offset: 0x000099D4
	public virtual void qf()
	{
	}

	// Token: 0x06000245 RID: 581 RVA: 0x0000B7D8 File Offset: 0x000099D8
	public virtual void xd()
	{
	}

	// Token: 0x06000246 RID: 582 RVA: 0x0000B7DC File Offset: 0x000099DC
	public virtual void qg()
	{
	}

	// Token: 0x06000247 RID: 583 RVA: 0x0000B7E0 File Offset: 0x000099E0
	public virtual ReadOnlyCollection<dyx> ava()
	{
		return null;
	}

	// Token: 0x06000248 RID: 584 RVA: 0x0000B7E4 File Offset: 0x000099E4
	public virtual ReadOnlyCollection<ajx> qh()
	{
		return null;
	}

	// Token: 0x06000249 RID: 585 RVA: 0x0000B7E8 File Offset: 0x000099E8
	public virtual ReadOnlyCollection<z6> qi()
	{
		return null;
	}

	// Token: 0x0600024A RID: 586
	public abstract Guid qe();

	// Token: 0x0600024B RID: 587
	public abstract string y8();

	// Token: 0x0600024C RID: 588 RVA: 0x0000B7F0 File Offset: 0x000099F0
	public override string ToString()
	{
		string text = (this.y8() != null) ? this.y8() : "Unnamed";
		return string.Concat(new string[]
		{
			"[Id=",
			this.qe().ToString(),
			", Name=",
			text,
			"]"
		});
	}

	// Token: 0x0400039A RID: 922
	private PropertyCollection a;
}
