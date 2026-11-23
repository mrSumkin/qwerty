using System;

// Token: 0x0200189D RID: 6301
public sealed class dtn : btm
{
	// Token: 0x060085DC RID: 34268 RVA: 0x00377A2C File Offset: 0x00375C2C
	public dtn(string A_0, string A_1, string A_2) : base(null)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x060085DD RID: 34269 RVA: 0x00377A4C File Offset: 0x00375C4C
	protected override bool b4(e6d A_0)
	{
		dh7.a = new dh7
		{
			b = this.a,
			c = this.b,
			d = this.c
		};
		return true;
	}

	// Token: 0x0400333F RID: 13119
	private string a;

	// Token: 0x04003340 RID: 13120
	private string b;

	// Token: 0x04003341 RID: 13121
	private string c;
}
