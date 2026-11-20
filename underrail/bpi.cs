using System;

// Token: 0x02001880 RID: 6272
public sealed class bpi : btm
{
	// Token: 0x06008545 RID: 34117 RVA: 0x00375EE8 File Offset: 0x003740E8
	public bpi(euz A_0) : base(null)
	{
		this.a = A_0;
	}

	// Token: 0x06008546 RID: 34118 RVA: 0x00375EF8 File Offset: 0x003740F8
	protected override bool b4(e6d A_0)
	{
		bpo.GetServiceOrThrow<bcm>().aav(this.a);
		return true;
	}

	// Token: 0x04003307 RID: 13063
	private euz a;
}
