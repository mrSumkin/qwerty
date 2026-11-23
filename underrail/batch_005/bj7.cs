using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;

// Token: 0x020006CE RID: 1742
public sealed class bj7 : bad
{
	// Token: 0x06002CE5 RID: 11493 RVA: 0x00100718 File Offset: 0x000FE918
	public override lu eg()
	{
		return this.c;
	}

	// Token: 0x06002CE6 RID: 11494 RVA: 0x00100720 File Offset: 0x000FE920
	public bj7(lu A_0, ce8 A_1, List<object> A_2)
	{
		this.c = A_0;
		this.a = A_1;
		if (A_2 != null)
		{
			this.b = new List<object>(A_2);
			return;
		}
		this.b = new List<object>();
	}

	// Token: 0x06002CE7 RID: 11495 RVA: 0x00100754 File Offset: 0x000FE954
	public override TimelapseCursor? eh(object A_0)
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeSpell);
	}

	// Token: 0x06002CE8 RID: 11496 RVA: 0x00100760 File Offset: 0x000FE960
	public override void f1(c1a A_0)
	{
		if (this.a != null)
		{
			try
			{
				this.a.wu(this.b, base.a());
			}
			catch (Exception ex)
			{
				bdg.a("[error]Error occurred while executing command: {0}", new object[]
				{
					ex.Message
				});
				this.a.b();
			}
		}
	}

	// Token: 0x04001992 RID: 6546
	public new ce8 a;

	// Token: 0x04001993 RID: 6547
	public List<object> b;

	// Token: 0x04001994 RID: 6548
	private lu c;
}
