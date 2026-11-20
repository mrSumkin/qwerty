using System;
using System.Diagnostics;

// Token: 0x02000224 RID: 548
public sealed class ayu : ag5
{
	// Token: 0x06000F40 RID: 3904 RVA: 0x0003FF50 File Offset: 0x0003E150
	public ayu(uint A_0) : base(20)
	{
		this.b = A_0;
	}

	// Token: 0x06000F41 RID: 3905 RVA: 0x0003FF6C File Offset: 0x0003E16C
	public bool a(ref double A_0)
	{
		this.a.Reset();
		this.a.Start();
		if (!base.d() && base.c() == 0)
		{
			return false;
		}
		bool flag = true;
		while ((this.a.Elapsed.TotalMilliseconds < Math.Min(A_0, this.b) || flag) && base.b(1) != 0)
		{
			flag = false;
		}
		this.a.Stop();
		A_0 -= this.a.Elapsed.TotalMilliseconds;
		return true;
	}

	// Token: 0x06000F42 RID: 3906 RVA: 0x00040008 File Offset: 0x0003E208
	public void a()
	{
		while (base.a(1) > 0)
		{
		}
	}

	// Token: 0x0400091A RID: 2330
	private new Stopwatch a = new Stopwatch();

	// Token: 0x0400091B RID: 2331
	private new uint b;

	// Token: 0x0400091C RID: 2332
	private const int c = 20;
}
