using System;

// Token: 0x0200187F RID: 6271
public sealed class avn : btm
{
	// Token: 0x06008543 RID: 34115 RVA: 0x00375EB4 File Offset: 0x003740B4
	public avn(string A_0) : base(null)
	{
		this.a = A_0;
	}

	// Token: 0x06008544 RID: 34116 RVA: 0x00375EC4 File Offset: 0x003740C4
	protected override bool aen(e6d A_0)
	{
		if (!string.IsNullOrEmpty(this.a))
		{
			bpo.GetServiceOrThrow<cnk>().arn(this.a);
		}
		return true;
	}

	// Token: 0x04003306 RID: 13062
	private string a;
}
