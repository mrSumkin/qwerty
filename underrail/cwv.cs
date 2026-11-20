using System;
using Microsoft.Xna.Framework.Input;

// Token: 0x02001FFE RID: 8190
public sealed class cwv : bbd
{
	// Token: 0x0600C13B RID: 49467 RVA: 0x0042FDB4 File Offset: 0x0042DFB4
	public cwv(c8r A_0, Keys A_1, bool A_2, int A_3 = 60, string A_4 = null) : base(A_0, A_3)
	{
		this.b = A_1;
		this.a = A_2;
		this.c = A_4;
	}

	// Token: 0x0600C13C RID: 49468 RVA: 0x0042FDD8 File Offset: 0x0042DFD8
	protected override string ri()
	{
		if (this.c != null)
		{
			return this.c;
		}
		return b5u.a(this.b, false, true).ToString();
	}

	// Token: 0x0600C13D RID: 49469 RVA: 0x0042FE0C File Offset: 0x0042E00C
	protected override string aio()
	{
		if (this.c != null)
		{
			return null;
		}
		if (this.a)
		{
			return b5u.a(this.b, true, true).ToString();
		}
		return null;
	}

	// Token: 0x040045ED RID: 17901
	public new bool a;

	// Token: 0x040045EE RID: 17902
	public new Keys b;

	// Token: 0x040045EF RID: 17903
	public new string c;
}
