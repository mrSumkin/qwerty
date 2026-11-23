using System;

// Token: 0x02000217 RID: 535
public class br : IComparable<br>
{
	// Token: 0x06000EF4 RID: 3828 RVA: 0x0003E9F8 File Offset: 0x0003CBF8
	public br(ee4 A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06000EF5 RID: 3829 RVA: 0x0003EA14 File Offset: 0x0003CC14
	public br(ee4 A_0, int A_1, int A_2) : this(A_0)
	{
		this.b = A_1;
		this.c = A_2;
		this.a();
	}

	// Token: 0x06000EF6 RID: 3830 RVA: 0x0003EA34 File Offset: 0x0003CC34
	public void a()
	{
		this.a = this.b + this.c;
	}

	// Token: 0x06000EF7 RID: 3831 RVA: 0x0003EA4C File Offset: 0x0003CC4C
	public void b()
	{
		if (this.e == null)
		{
			this.b = 0;
			return;
		}
		this.b = this.a(this.e, this.f);
	}

	// Token: 0x06000EF8 RID: 3832 RVA: 0x0003EA7C File Offset: 0x0003CC7C
	public void c()
	{
		this.b();
		this.a();
	}

	// Token: 0x06000EF9 RID: 3833 RVA: 0x0003EA8C File Offset: 0x0003CC8C
	public int a(br A_0, abo? A_1)
	{
		int num;
		if (A_1 != null)
		{
			num = A_1.Value.d;
		}
		else
		{
			num = Convert.ToInt32((float)ctn.a(this.d.a, A_0.d.a) * this.h);
		}
		return A_0.b + num;
	}

	// Token: 0x06000EFA RID: 3834 RVA: 0x0003EAEC File Offset: 0x0003CCEC
	public bool b(br A_0, abo? A_1)
	{
		return this.a(A_0, A_1) < this.b;
	}

	// Token: 0x06000EFB RID: 3835 RVA: 0x0003EB08 File Offset: 0x0003CD08
	public override bool Equals(object obj)
	{
		br br = obj as br;
		return br != null && this.a(br);
	}

	// Token: 0x06000EFC RID: 3836 RVA: 0x0003EB2C File Offset: 0x0003CD2C
	public override int GetHashCode()
	{
		return this.d.GetHashCode();
	}

	// Token: 0x06000EFD RID: 3837 RVA: 0x0003EB40 File Offset: 0x0003CD40
	public bool a(br A_0)
	{
		return this.d.a(A_0.d);
	}

	// Token: 0x06000EFE RID: 3838 RVA: 0x0003EB58 File Offset: 0x0003CD58
	public int CompareTo(br other)
	{
		int num = this.a.CompareTo(other.a);
		if (num == 0)
		{
			return -1;
		}
		return num;
	}

	// Token: 0x040008F5 RID: 2293
	public int a;

	// Token: 0x040008F6 RID: 2294
	public int b;

	// Token: 0x040008F7 RID: 2295
	public int c;

	// Token: 0x040008F8 RID: 2296
	public ee4 d;

	// Token: 0x040008F9 RID: 2297
	public br e;

	// Token: 0x040008FA RID: 2298
	public abo? f;

	// Token: 0x040008FB RID: 2299
	public bool g;

	// Token: 0x040008FC RID: 2300
	public float h = 1f;
}
