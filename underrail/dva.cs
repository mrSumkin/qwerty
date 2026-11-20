using System;

// Token: 0x02000112 RID: 274
public sealed class dva : btm
{
	// Token: 0x06000684 RID: 1668 RVA: 0x0001BB20 File Offset: 0x00019D20
	public Func<Exception, btm> c()
	{
		return this.a;
	}

	// Token: 0x06000685 RID: 1669 RVA: 0x0001BB28 File Offset: 0x00019D28
	public void a(Func<Exception, btm> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x0001BB34 File Offset: 0x00019D34
	public Predicate<e6d> d()
	{
		return this.b;
	}

	// Token: 0x06000687 RID: 1671 RVA: 0x0001BB3C File Offset: 0x00019D3C
	public void a(Predicate<e6d> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x0001BB48 File Offset: 0x00019D48
	public Predicate<e6d> e()
	{
		return this.c;
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x0001BB50 File Offset: 0x00019D50
	public void b(Predicate<e6d> A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600068A RID: 1674 RVA: 0x0001BB5C File Offset: 0x00019D5C
	public Func<e6d, bool> b()
	{
		return this.d;
	}

	// Token: 0x0600068B RID: 1675 RVA: 0x0001BB64 File Offset: 0x00019D64
	public void a(Func<e6d, bool> A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600068C RID: 1676 RVA: 0x0001BB70 File Offset: 0x00019D70
	public Func<e6d, bool> a()
	{
		return this.e;
	}

	// Token: 0x0600068D RID: 1677 RVA: 0x0001BB78 File Offset: 0x00019D78
	public void b(Func<e6d, bool> A_0)
	{
		this.e = A_0;
	}

	// Token: 0x0600068E RID: 1678 RVA: 0x0001BB84 File Offset: 0x00019D84
	public dva(Func<e6d, bool> A_0 = null, Func<e6d, bool> A_1 = null, Predicate<e6d> A_2 = null, Predicate<e6d> A_3 = null, Func<Exception, btm> A_4 = null) : base(null)
	{
		this.e = A_0;
		this.d = A_1;
		this.b = A_2;
		this.c = A_3;
		this.a = A_4;
	}

	// Token: 0x0600068F RID: 1679 RVA: 0x0001BBB4 File Offset: 0x00019DB4
	protected override btm aeo(Exception A_0)
	{
		if (this.a != null)
		{
			return this.a(A_0);
		}
		return base.aeo(A_0);
	}

	// Token: 0x06000690 RID: 1680 RVA: 0x0001BBD8 File Offset: 0x00019DD8
	protected override void aep(e6d A_0)
	{
		if (this.b != null)
		{
			this.b(A_0);
		}
	}

	// Token: 0x06000691 RID: 1681 RVA: 0x0001BBF4 File Offset: 0x00019DF4
	protected override void aeq(e6d A_0)
	{
		if (this.c != null)
		{
			this.c(A_0);
		}
	}

	// Token: 0x06000692 RID: 1682 RVA: 0x0001BC10 File Offset: 0x00019E10
	protected override bool b4(e6d A_0)
	{
		if (this.d != null)
		{
			return this.d(A_0);
		}
		return base.b4(A_0);
	}

	// Token: 0x06000693 RID: 1683 RVA: 0x0001BC34 File Offset: 0x00019E34
	protected override bool aen(e6d A_0)
	{
		if (this.e != null)
		{
			return this.e(A_0);
		}
		return base.aen(A_0);
	}

	// Token: 0x0400051F RID: 1311
	private Func<Exception, btm> a;

	// Token: 0x04000520 RID: 1312
	private Predicate<e6d> b;

	// Token: 0x04000521 RID: 1313
	private Predicate<e6d> c;

	// Token: 0x04000522 RID: 1314
	private new Func<e6d, bool> d;

	// Token: 0x04000523 RID: 1315
	private new Func<e6d, bool> e;
}
