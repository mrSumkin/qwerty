using System;

// Token: 0x02000470 RID: 1136
public sealed class ce4 : adt
{
	// Token: 0x06001D6C RID: 7532 RVA: 0x000A3058 File Offset: 0x000A1258
	public ce4(string A_0, string A_1, object A_2) : base(A_0)
	{
		this.a = A_1;
		this.b = A_2;
	}

	// Token: 0x06001D6D RID: 7533 RVA: 0x000A3070 File Offset: 0x000A1270
	public override ej1 aci(TimeSpan A_0, double A_1)
	{
		this.Subject.y6()[this.a] = this.b;
		return ej1.b;
	}

	// Token: 0x06001D6E RID: 7534 RVA: 0x000A3090 File Offset: 0x000A1290
	public override bool acj(TimeSpan A_0, double A_1)
	{
		return true;
	}

	// Token: 0x0400103E RID: 4158
	private string a;

	// Token: 0x0400103F RID: 4159
	private new object b;
}
