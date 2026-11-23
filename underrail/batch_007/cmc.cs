using System;
using Microsoft.Xna.Framework;

// Token: 0x020018B2 RID: 6322
public sealed class cmc : btm
{
	// Token: 0x0600862F RID: 34351 RVA: 0x00378C38 File Offset: 0x00376E38
	public cmc(Color? A_0) : base(null)
	{
		this.a = A_0;
	}

	// Token: 0x06008630 RID: 34352 RVA: 0x00378C48 File Offset: 0x00376E48
	protected override bool aen(e6d A_0)
	{
		bpo.GetServiceOrThrow<ps>().and(this.a);
		return true;
	}

	// Token: 0x04003355 RID: 13141
	public Color? a;
}
