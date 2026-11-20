using System;
using Microsoft.Xna.Framework;

// Token: 0x020001C7 RID: 455
public abstract class a3u : c5m
{
	// Token: 0x06000D6D RID: 3437 RVA: 0x00039378 File Offset: 0x00037578
	public Vector3 t1()
	{
		return this.f;
	}

	// Token: 0x06000D6E RID: 3438 RVA: 0x00039380 File Offset: 0x00037580
	public void t2(Vector3 A_0)
	{
		this.f = A_0;
		this.uq(true, true, true);
		this.a();
	}

	// Token: 0x06000D6F RID: 3439 RVA: 0x00039398 File Offset: 0x00037598
	public Point t3()
	{
		return this.g;
	}

	// Token: 0x06000D70 RID: 3440 RVA: 0x000393A0 File Offset: 0x000375A0
	public Vector2 t4()
	{
		return this.b;
	}

	// Token: 0x06000D71 RID: 3441 RVA: 0x000393A8 File Offset: 0x000375A8
	public void t5(Vector2 A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06000D72 RID: 3442 RVA: 0x000393B4 File Offset: 0x000375B4
	public Vector2 t6()
	{
		return this.c;
	}

	// Token: 0x06000D73 RID: 3443 RVA: 0x000393BC File Offset: 0x000375BC
	public void t7(Vector2 A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06000D74 RID: 3444 RVA: 0x000393C8 File Offset: 0x000375C8
	public bool t8()
	{
		return this.a;
	}

	// Token: 0x06000D75 RID: 3445 RVA: 0x000393D0 File Offset: 0x000375D0
	public void t9(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000D76 RID: 3446 RVA: 0x000393DC File Offset: 0x000375DC
	public float ua()
	{
		return this.h;
	}

	// Token: 0x06000D77 RID: 3447 RVA: 0x000393E4 File Offset: 0x000375E4
	public void ub(float A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06000D78 RID: 3448 RVA: 0x000393F0 File Offset: 0x000375F0
	public float uc()
	{
		return this.d;
	}

	// Token: 0x06000D79 RID: 3449 RVA: 0x000393F8 File Offset: 0x000375F8
	public void ud(float A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06000D7A RID: 3450 RVA: 0x00039404 File Offset: 0x00037604
	public float ue()
	{
		return this.e;
	}

	// Token: 0x06000D7B RID: 3451 RVA: 0x0003940C File Offset: 0x0003760C
	public void uf(float A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06000D7C RID: 3452 RVA: 0x00039418 File Offset: 0x00037618
	public void ug(float A_0)
	{
		this.aca(A_0);
		this.a();
	}

	// Token: 0x06000D7D RID: 3453 RVA: 0x00039428 File Offset: 0x00037628
	public void uh(float A_0)
	{
		this.acb(A_0);
		this.a();
	}

	// Token: 0x06000D7E RID: 3454 RVA: 0x00039438 File Offset: 0x00037638
	public void ui(float A_0)
	{
		this.acc(A_0);
		this.a();
	}

	// Token: 0x06000D7F RID: 3455 RVA: 0x00039448 File Offset: 0x00037648
	public void uj(float A_0)
	{
		this.acd(A_0);
		this.a();
	}

	// Token: 0x06000D80 RID: 3456 RVA: 0x00039458 File Offset: 0x00037658
	public void uk(float A_0)
	{
		this.ace(A_0);
		this.a();
	}

	// Token: 0x06000D81 RID: 3457 RVA: 0x00039468 File Offset: 0x00037668
	public void ul(float A_0)
	{
		this.acf(A_0);
		this.a();
	}

	// Token: 0x06000D82 RID: 3458 RVA: 0x00039478 File Offset: 0x00037678
	public void um(float A_0)
	{
		this.acg(A_0);
		this.a();
	}

	// Token: 0x06000D83 RID: 3459 RVA: 0x00039488 File Offset: 0x00037688
	public void un(float A_0)
	{
		this.ach(A_0);
		this.a();
	}

	// Token: 0x06000D84 RID: 3460 RVA: 0x00039498 File Offset: 0x00037698
	public virtual void uo(float A_0)
	{
		this.h += A_0;
		this.uq(false, false, true);
	}

	// Token: 0x06000D85 RID: 3461 RVA: 0x000394B4 File Offset: 0x000376B4
	public virtual void up()
	{
		this.h = 1f;
	}

	// Token: 0x06000D86 RID: 3462 RVA: 0x000394C4 File Offset: 0x000376C4
	public void uq(bool A_0, bool A_1, bool A_2)
	{
		if (A_0)
		{
			if (this.t1().X < this.t4().X)
			{
				this.f.X = this.t4().X;
			}
			if (this.t1().X > this.t6().X)
			{
				this.f.X = this.t6().X;
			}
		}
		if (A_1)
		{
			if (this.t1().Y < this.t4().Y)
			{
				this.f.Y = this.t4().Y;
			}
			if (this.t1().Y > this.t6().Y)
			{
				this.f.Y = this.t6().Y;
			}
		}
		if (A_2)
		{
			if (this.h < this.d)
			{
				this.h = this.d;
			}
			if (this.h > this.e)
			{
				this.h = this.e;
			}
		}
		this.a();
	}

	// Token: 0x06000D87 RID: 3463
	protected abstract void aca(float A_0);

	// Token: 0x06000D88 RID: 3464
	protected abstract void acb(float A_0);

	// Token: 0x06000D89 RID: 3465
	protected abstract void acc(float A_0);

	// Token: 0x06000D8A RID: 3466
	protected abstract void acd(float A_0);

	// Token: 0x06000D8B RID: 3467
	protected abstract void ace(float A_0);

	// Token: 0x06000D8C RID: 3468
	protected abstract void acf(float A_0);

	// Token: 0x06000D8D RID: 3469
	protected abstract void acg(float A_0);

	// Token: 0x06000D8E RID: 3470
	protected abstract void ach(float A_0);

	// Token: 0x06000D8F RID: 3471 RVA: 0x000395E8 File Offset: 0x000377E8
	private void a()
	{
		this.g = new Point((int)this.f.X, (int)this.f.Y);
	}

	// Token: 0x040007E7 RID: 2023
	private bool a;

	// Token: 0x040007E8 RID: 2024
	private Vector2 b;

	// Token: 0x040007E9 RID: 2025
	private Vector2 c;

	// Token: 0x040007EA RID: 2026
	private float d = 0.5f;

	// Token: 0x040007EB RID: 2027
	private float e = 3f;

	// Token: 0x040007EC RID: 2028
	protected Vector3 f;

	// Token: 0x040007ED RID: 2029
	private Point g;

	// Token: 0x040007EE RID: 2030
	private float h = 1f;
}
