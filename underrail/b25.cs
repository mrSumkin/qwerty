using System;
using Microsoft.Xna.Framework;

// Token: 0x0200019B RID: 411
public class b25 : EventArgs
{
	// Token: 0x06000BDB RID: 3035 RVA: 0x00030060 File Offset: 0x0002E260
	public Point a()
	{
		return this.a;
	}

	// Token: 0x06000BDC RID: 3036 RVA: 0x00030068 File Offset: 0x0002E268
	public int c()
	{
		return this.b;
	}

	// Token: 0x06000BDD RID: 3037 RVA: 0x00030070 File Offset: 0x0002E270
	public eoo b()
	{
		return this.c;
	}

	// Token: 0x06000BDE RID: 3038 RVA: 0x00030078 File Offset: 0x0002E278
	public b25()
	{
	}

	// Token: 0x06000BDF RID: 3039 RVA: 0x00030080 File Offset: 0x0002E280
	public b25(Point A_0) : this()
	{
		this.a = A_0;
	}

	// Token: 0x06000BE0 RID: 3040 RVA: 0x00030090 File Offset: 0x0002E290
	public b25(Point A_0, int A_1) : this()
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06000BE1 RID: 3041 RVA: 0x000300A8 File Offset: 0x0002E2A8
	public b25(Point A_0, eoo A_1) : this()
	{
		this.a = A_0;
		this.c = A_1;
	}

	// Token: 0x06000BE2 RID: 3042 RVA: 0x000300C0 File Offset: 0x0002E2C0
	public b25(Point A_0, int A_1, eoo A_2) : this()
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x04000715 RID: 1813
	private Point a;

	// Token: 0x04000716 RID: 1814
	private int b;

	// Token: 0x04000717 RID: 1815
	private eoo c;
}
