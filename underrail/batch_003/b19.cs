using System;

// Token: 0x02001885 RID: 6277
public sealed class b19 : btm
{
	// Token: 0x0600854F RID: 34127 RVA: 0x00375FE8 File Offset: 0x003741E8
	public b19(string A_0, bool A_1 = false, bool A_2 = false) : base(null)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x06008550 RID: 34128 RVA: 0x00376008 File Offset: 0x00374208
	protected override bool aen(e6d A_0)
	{
		bpo.GetServiceOrThrow<cnk>().arg(this.a, this.b, this.c);
		return true;
	}

	// Token: 0x0400330B RID: 13067
	private string a;

	// Token: 0x0400330C RID: 13068
	private bool b;

	// Token: 0x0400330D RID: 13069
	private bool c;
}
