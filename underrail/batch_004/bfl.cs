using System;

// Token: 0x020018AD RID: 6317
public sealed class bfl : btm
{
	// Token: 0x06008625 RID: 34341 RVA: 0x00378B64 File Offset: 0x00376D64
	protected override bool b4(e6d A_0)
	{
		bpo.GetServiceOrThrow<cnk>().arq();
		return true;
	}

	// Token: 0x06008626 RID: 34342 RVA: 0x00378B74 File Offset: 0x00376D74
	public bfl() : base(null)
	{
	}
}
