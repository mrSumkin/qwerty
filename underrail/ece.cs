using System;

// Token: 0x02000591 RID: 1425
public sealed class ece
{
	// Token: 0x060024E7 RID: 9447 RVA: 0x000D046C File Offset: 0x000CE66C
	public string e()
	{
		return this.d;
	}

	// Token: 0x060024E8 RID: 9448 RVA: 0x000D0474 File Offset: 0x000CE674
	public c5x f()
	{
		return this.a;
	}

	// Token: 0x060024E9 RID: 9449 RVA: 0x000D047C File Offset: 0x000CE67C
	public dbi d()
	{
		return this.b;
	}

	// Token: 0x060024EA RID: 9450 RVA: 0x000D0484 File Offset: 0x000CE684
	public csy a()
	{
		return this.c;
	}

	// Token: 0x060024EB RID: 9451 RVA: 0x000D048C File Offset: 0x000CE68C
	public bool b()
	{
		return this.e;
	}

	// Token: 0x060024EC RID: 9452 RVA: 0x000D0494 File Offset: 0x000CE694
	public object c()
	{
		return this.f;
	}

	// Token: 0x060024ED RID: 9453 RVA: 0x000D04A0 File Offset: 0x000CE6A0
	public ece(string A_0, c5x A_1, dbi A_2, csy A_3, bool A_4 = false, object A_5 = null)
	{
		czh.a(A_1, "actor");
		czh.a(A_2, "container");
		this.e = A_4;
		this.c = A_3;
		this.d = A_0;
		this.a = A_1;
		this.b = A_2;
		this.f = A_5;
	}

	// Token: 0x04001566 RID: 5478
	private c5x a;

	// Token: 0x04001567 RID: 5479
	private dbi b;

	// Token: 0x04001568 RID: 5480
	private csy c;

	// Token: 0x04001569 RID: 5481
	private string d;

	// Token: 0x0400156A RID: 5482
	private bool e;

	// Token: 0x0400156B RID: 5483
	private object f;
}
