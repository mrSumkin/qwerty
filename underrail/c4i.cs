using System;

// Token: 0x0200024C RID: 588
public sealed class c4i : EventArgs
{
	// Token: 0x060010BE RID: 4286 RVA: 0x00044FF4 File Offset: 0x000431F4
	public c4i(TimeSpan A_0)
	{
		this.a = A_0;
	}

	// Token: 0x040009A2 RID: 2466
	public TimeSpan a;
}
