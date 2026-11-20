using System;
using System.Collections.Generic;

// Token: 0x020005B6 RID: 1462
public abstract class ae1
{
	// Token: 0x06002702 RID: 9986
	public abstract string gr();

	// Token: 0x06002703 RID: 9987 RVA: 0x000E34DC File Offset: 0x000E16DC
	protected virtual bool at0()
	{
		return true;
	}

	// Token: 0x06002704 RID: 9988 RVA: 0x000E34E0 File Offset: 0x000E16E0
	public List<object> a()
	{
		if (this.at0())
		{
			if (this.a == null)
			{
				this.a = this.gt();
			}
			return this.a;
		}
		return this.gt();
	}

	// Token: 0x06002705 RID: 9989 RVA: 0x000E3514 File Offset: 0x000E1714
	protected virtual List<object> gt()
	{
		return null;
	}

	// Token: 0x06002706 RID: 9990 RVA: 0x000E3518 File Offset: 0x000E1718
	public virtual object gs(string A_0)
	{
		return A_0;
	}

	// Token: 0x0400163B RID: 5691
	private List<object> a;
}
