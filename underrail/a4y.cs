using System;
using System.Collections.Generic;
using System.Drawing;

// Token: 0x0200011F RID: 287
public abstract class a4y : dyx
{
	// Token: 0x060006F5 RID: 1781
	public abstract string u3();

	// Token: 0x060006F6 RID: 1782 RVA: 0x0001CA24 File Offset: 0x0001AC24
	public virtual ICollection<string> u4()
	{
		return new string[0];
	}

	// Token: 0x060006F7 RID: 1783
	public abstract string u5();

	// Token: 0x060006F8 RID: 1784
	public abstract void u6(string[] A_0, dk1 A_1);

	// Token: 0x060006F9 RID: 1785 RVA: 0x0001CA2C File Offset: 0x0001AC2C
	protected virtual void a(dk1 A_0)
	{
		A_0.y9(Color.Red, 12, FontStyle.Regular, "Command syntax error.");
	}
}
