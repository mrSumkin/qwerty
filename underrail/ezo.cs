using System;

// Token: 0x020018AC RID: 6316
public sealed class ezo : btm
{
	// Token: 0x06008623 RID: 34339 RVA: 0x00378B38 File Offset: 0x00376D38
	public ezo(bool A_0) : base(null)
	{
		this.a = A_0;
	}

	// Token: 0x06008624 RID: 34340 RVA: 0x00378B48 File Offset: 0x00376D48
	protected override bool b4(e6d A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		serviceOrThrow.arp(this.a, false);
		serviceOrThrow.ars();
		return true;
	}

	// Token: 0x04003352 RID: 13138
	private bool a;
}
