using System;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common;

// Token: 0x02001864 RID: 6244
[e79(TimelapseWorkflows.SaveGame)]
public sealed class al1 : b8q
{
	// Token: 0x06008503 RID: 34051 RVA: 0x00374A04 File Offset: 0x00372C04
	public al1(string A_0) : this(A_0, null, false)
	{
	}

	// Token: 0x06008504 RID: 34052 RVA: 0x00374A10 File Offset: 0x00372C10
	public al1(string A_0, string A_1) : this(A_0, A_1, false)
	{
	}

	// Token: 0x06008505 RID: 34053 RVA: 0x00374A1C File Offset: 0x00372C1C
	public al1(string A_0, string A_1, bool A_2)
	{
		wj wj = wj.a();
		base.ErrorHandling = d3s.c;
		base.f().Add(new e55());
		base.f().Add(new cqx());
		base.f().Add(new bge());
		base.f().Add(new on());
		base.f().Add(new d08());
		base.f().Add(new eet());
		if (wj.c())
		{
			base.f().Add(this.a = new b4r(bo1.bp, dh9.c("Msg_Saving")));
		}
		else
		{
			base.f().Add(this.a = new b4r(wj.f, dh9.c("Msg_Saving"), new Rectangle?(wj.ak)));
		}
		if (!string.IsNullOrEmpty(A_1))
		{
			base.f().Add(new avn(A_1));
		}
		base.f().Add(new b19(A_0, false, A_2));
		base.f().Add(new elc(this.a));
		base.f().Add(new b1d());
		base.f().Add(new by());
		base.f().Add(new ash());
	}

	// Token: 0x06008506 RID: 34054 RVA: 0x00374B80 File Offset: 0x00372D80
	public override btm ev(Exception A_0, btm A_1)
	{
		return new bc3(this);
	}

	// Token: 0x040032F9 RID: 13049
	public new b4r a;
}
