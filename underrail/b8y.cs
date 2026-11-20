using System;

// Token: 0x0200187D RID: 6269
public sealed class b8y : btm
{
	// Token: 0x06008537 RID: 34103 RVA: 0x00375C7C File Offset: 0x00373E7C
	public b8y() : base(null)
	{
	}

	// Token: 0x06008538 RID: 34104 RVA: 0x00375C88 File Offset: 0x00373E88
	protected sealed override bool b4(e6d A_0)
	{
		bcm serviceOrThrow = bpo.GetServiceOrThrow<bcm>();
		bef serviceOrThrow2 = bpo.GetServiceOrThrow<bef>();
		serviceOrThrow.aav(new daj
		{
			Size = serviceOrThrow2.k0()
		});
		return true;
	}
}
