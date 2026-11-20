using System;

// Token: 0x020006D0 RID: 1744
public sealed class k0 : ds3
{
	// Token: 0x06002CED RID: 11501 RVA: 0x00100958 File Offset: 0x000FEB58
	public k0(czp A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002CEE RID: 11502 RVA: 0x00100968 File Offset: 0x000FEB68
	public void gh(Action<czp> A_0)
	{
		if (A_0 != null)
		{
			A_0(this.a);
		}
	}

	// Token: 0x06002CEF RID: 11503 RVA: 0x0010097C File Offset: 0x000FEB7C
	public void gi()
	{
	}

	// Token: 0x04001996 RID: 6550
	private czp a;
}
