using System;
using TimelapseVertigo.Common;

// Token: 0x020005F4 RID: 1524
public abstract class bad
{
	// Token: 0x06002800 RID: 10240 RVA: 0x000E7658 File Offset: 0x000E5858
	public virtual bool io()
	{
		efk efk = ces.c();
		return efk != null && efk.IsInControl;
	}

	// Token: 0x06002801 RID: 10241
	public abstract lu eg();

	// Token: 0x06002802 RID: 10242 RVA: 0x000E767C File Offset: 0x000E587C
	public object a()
	{
		return this.a;
	}

	// Token: 0x06002804 RID: 10244 RVA: 0x000E7690 File Offset: 0x000E5890
	public virtual TimelapseCursor? eh(object A_0)
	{
		return null;
	}

	// Token: 0x06002805 RID: 10245 RVA: 0x000E76A8 File Offset: 0x000E58A8
	public bool a(object A_0)
	{
		czh.a(A_0, "target");
		if (this.eg() == null || !this.eg().cg(A_0))
		{
			return false;
		}
		this.a = A_0;
		return true;
	}

	// Token: 0x06002806 RID: 10246
	public abstract void f1(c1a A_0);

	// Token: 0x0400164D RID: 5709
	private object a;
}
