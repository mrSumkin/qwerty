using System;
using Microsoft.Xna.Framework;

// Token: 0x020018B1 RID: 6321
public sealed class a5o : btm
{
	// Token: 0x0600862D RID: 34349 RVA: 0x00378BEC File Offset: 0x00376DEC
	public a5o(c2w A_0, Point? A_1 = null) : base(null)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x0600862E RID: 34350 RVA: 0x00378C04 File Offset: 0x00376E04
	protected override bool b4(e6d A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		serviceOrThrow.aqu().a(this.a);
		serviceOrThrow.aqu().a(this.b);
		return true;
	}

	// Token: 0x04003353 RID: 13139
	private c2w a;

	// Token: 0x04003354 RID: 13140
	private Point? b;
}
