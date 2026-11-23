using System;

// Token: 0x02001894 RID: 6292
public sealed class c6w : dyh
{
	// Token: 0x0600857D RID: 34173 RVA: 0x00376724 File Offset: 0x00374924
	public c6w()
	{
	}

	// Token: 0x0600857E RID: 34174 RVA: 0x0037672C File Offset: 0x0037492C
	public c6w(Func<auv> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600857F RID: 34175 RVA: 0x0037673C File Offset: 0x0037493C
	protected override auv wy()
	{
		if (this.a != null)
		{
			return this.a();
		}
		return null;
	}

	// Token: 0x04003323 RID: 13091
	public Func<auv> a;
}
