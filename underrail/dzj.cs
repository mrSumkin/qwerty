using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

// Token: 0x02000074 RID: 116
public sealed class dzj : exy
{
	// Token: 0x0600023C RID: 572 RVA: 0x0000B754 File Offset: 0x00009954
	public override Guid qe()
	{
		return this.b;
	}

	// Token: 0x0600023D RID: 573 RVA: 0x0000B75C File Offset: 0x0000995C
	public override string y8()
	{
		return "OuroborosAudio";
	}

	// Token: 0x0600023E RID: 574 RVA: 0x0000B764 File Offset: 0x00009964
	public override ReadOnlyCollection<z6> qi()
	{
		return new List<z6>
		{
			this.c
		}.AsReadOnly();
	}

	// Token: 0x0600023F RID: 575 RVA: 0x0000B77C File Offset: 0x0000997C
	public override void xd()
	{
		this.c = new b6d();
		bpo.RegisterService<dd7>(this.c);
	}

	// Token: 0x06000240 RID: 576 RVA: 0x0000B794 File Offset: 0x00009994
	public override void qg()
	{
		this.c.adz();
		bpo.UnregisterService<dd7>();
	}

	// Token: 0x04000397 RID: 919
	private const string a = "OuroborosAudio";

	// Token: 0x04000398 RID: 920
	private readonly Guid b = new Guid("{4986406E-6EB4-4ca2-891F-7F6175110CB7}");

	// Token: 0x04000399 RID: 921
	private b6d c;
}
