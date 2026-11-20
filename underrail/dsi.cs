using System;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common;

// Token: 0x0200185F RID: 6239
[e79(TimelapseWorkflows.ExportCharacter)]
public sealed class dsi : b8q
{
	// Token: 0x060084FB RID: 34043 RVA: 0x003745B0 File Offset: 0x003727B0
	public dsi()
	{
		wj wj = wj.a();
		base.ErrorHandling = d3s.c;
		base.f().Add(new e55());
		base.f().Add(new cqx());
		base.f().Add(new bge());
		base.f().Add(new d08());
		if (wj.c())
		{
			base.f().Add(this.a = new b4r(bo1.bp, dh9.c("Msg_Exporting")));
		}
		else
		{
			base.f().Add(this.a = new b4r(wj.f, dh9.c("Msg_Exporting"), new Rectangle?(wj.ak)));
		}
		base.f().Add(new b7j());
		base.f().Add(new elc(this.a));
		base.f().Add(new b1d());
		base.f().Add(new by());
		base.f().Add(new ash());
	}

	// Token: 0x060084FC RID: 34044 RVA: 0x003746D4 File Offset: 0x003728D4
	public override btm ev(Exception A_0, btm A_1)
	{
		return new v1(this);
	}

	// Token: 0x040032F8 RID: 13048
	public new b4r a;
}
