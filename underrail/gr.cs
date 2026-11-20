using System;
using System.Collections.Generic;

// Token: 0x0200061B RID: 1563
public sealed class gr : ds3
{
	// Token: 0x0600285A RID: 10330 RVA: 0x000E8534 File Offset: 0x000E6734
	public gr(e1i A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600285B RID: 10331 RVA: 0x000E8544 File Offset: 0x000E6744
	public void gh(Action<czp> A_0)
	{
		this.b = this.a.a(A_0);
	}

	// Token: 0x0600285C RID: 10332 RVA: 0x000E8558 File Offset: 0x000E6758
	public void gi()
	{
		if (this.b != null)
		{
			foreach (anp anp in this.b)
			{
				anp.i();
			}
		}
	}

	// Token: 0x04001654 RID: 5716
	private e1i a;

	// Token: 0x04001655 RID: 5717
	private List<anp> b;
}
