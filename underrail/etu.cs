using System;
using Microsoft.Xna.Framework;

// Token: 0x02000197 RID: 407
public class etu : EventArgs
{
	// Token: 0x06000BD2 RID: 3026 RVA: 0x0002FFCC File Offset: 0x0002E1CC
	public e08 b()
	{
		return this.a;
	}

	// Token: 0x06000BD3 RID: 3027 RVA: 0x0002FFD4 File Offset: 0x0002E1D4
	public Point a()
	{
		return this.b;
	}

	// Token: 0x06000BD4 RID: 3028 RVA: 0x0002FFDC File Offset: 0x0002E1DC
	public etu(e08 A_0, Point A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x0400070E RID: 1806
	private e08 a;

	// Token: 0x0400070F RID: 1807
	private Point b;
}
