using System;

// Token: 0x020001E9 RID: 489
public class ef : ICloneable
{
	// Token: 0x06000E3B RID: 3643 RVA: 0x0003A258 File Offset: 0x00038458
	public ef a()
	{
		return new ef
		{
			a = this.a,
			b = this.b,
			c = this.c
		};
	}

	// Token: 0x06000E3C RID: 3644 RVA: 0x0003A284 File Offset: 0x00038484
	public object Clone()
	{
		return this.a();
	}

	// Token: 0x04000849 RID: 2121
	public bool a;

	// Token: 0x0400084A RID: 2122
	public e0p b;

	// Token: 0x0400084B RID: 2123
	public float c = 50f;
}
