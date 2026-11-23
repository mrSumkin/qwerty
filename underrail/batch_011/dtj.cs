using System;

// Token: 0x02001882 RID: 6274
public sealed class dtj : btm
{
	// Token: 0x06008549 RID: 34121 RVA: 0x00375F2C File Offset: 0x0037412C
	public dtj(string A_0, bool A_1) : base(null)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x0600854A RID: 34122 RVA: 0x00375F44 File Offset: 0x00374144
	protected override bool aen(e6d A_0)
	{
		bpo.GetServiceOrThrow<cnk>().ari(this.a, this.b);
		kl.a();
		return true;
	}

	// Token: 0x04003308 RID: 13064
	private string a;

	// Token: 0x04003309 RID: 13065
	private bool b;
}
