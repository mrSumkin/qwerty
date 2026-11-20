using System;

// Token: 0x020001C6 RID: 454
public class bw7 : a3u
{
	// Token: 0x06000D64 RID: 3428 RVA: 0x00038FE0 File Offset: 0x000371E0
	protected override void aca(float A_0)
	{
		if (this.f.X > base.t4().X)
		{
			this.f.X = Math.Max(this.f.X - A_0, base.t4().X);
		}
		if (this.f.Y > base.t4().Y)
		{
			this.f.Y = Math.Max(this.f.Y - A_0, base.t4().Y);
		}
	}

	// Token: 0x06000D65 RID: 3429 RVA: 0x00039074 File Offset: 0x00037274
	protected override void acb(float A_0)
	{
		if (this.f.X > base.t4().X)
		{
			this.f.X = Math.Max(this.f.X - A_0, base.t4().X);
		}
	}

	// Token: 0x06000D66 RID: 3430 RVA: 0x000390C4 File Offset: 0x000372C4
	protected override void acc(float A_0)
	{
		if (this.f.Y > base.t4().Y)
		{
			this.f.Y = Math.Max(this.f.Y - A_0, base.t4().Y);
		}
	}

	// Token: 0x06000D67 RID: 3431 RVA: 0x00039114 File Offset: 0x00037314
	protected override void acd(float A_0)
	{
		if (this.f.X < base.t6().X)
		{
			this.f.X = Math.Min(this.f.X + A_0, base.t6().X);
		}
		if (this.f.Y < base.t6().Y)
		{
			this.f.Y = Math.Min(this.f.Y + A_0, base.t6().Y);
		}
	}

	// Token: 0x06000D68 RID: 3432 RVA: 0x000391A8 File Offset: 0x000373A8
	protected override void ace(float A_0)
	{
		if (this.f.Y < base.t6().Y)
		{
			this.f.Y = Math.Min(this.f.Y + A_0, base.t6().Y);
		}
	}

	// Token: 0x06000D69 RID: 3433 RVA: 0x000391F8 File Offset: 0x000373F8
	protected override void acf(float A_0)
	{
		if (this.f.X < base.t6().X)
		{
			this.f.X = Math.Min(this.f.X + A_0, base.t6().X);
		}
	}

	// Token: 0x06000D6A RID: 3434 RVA: 0x00039248 File Offset: 0x00037448
	protected override void acg(float A_0)
	{
		if (this.f.X < base.t6().X)
		{
			this.f.X = Math.Min(this.f.X + A_0, base.t6().X);
		}
		if (this.f.Y > base.t4().Y)
		{
			this.f.Y = Math.Max(this.f.Y - A_0, base.t4().Y);
		}
	}

	// Token: 0x06000D6B RID: 3435 RVA: 0x000392DC File Offset: 0x000374DC
	protected override void ach(float A_0)
	{
		if (this.f.X > base.t4().X)
		{
			this.f.X = Math.Max(this.f.X - A_0, base.t4().X);
		}
		if (this.f.Y < base.t6().Y)
		{
			this.f.Y = Math.Min(this.f.Y + A_0, base.t6().Y);
		}
	}
}
