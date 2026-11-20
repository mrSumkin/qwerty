using System;

// Token: 0x02001CFC RID: 7420
public abstract class apq
{
	// Token: 0x0600A314 RID: 41748 RVA: 0x003EAA64 File Offset: 0x003E8C64
	public virtual bool c()
	{
		return false;
	}

	// Token: 0x0600A315 RID: 41749
	public abstract Type e3();

	// Token: 0x0600A316 RID: 41750
	public abstract string e4();

	// Token: 0x0600A317 RID: 41751
	public abstract string e5();

	// Token: 0x0600A318 RID: 41752
	public abstract int e6();

	// Token: 0x0600A319 RID: 41753 RVA: 0x003EAA68 File Offset: 0x003E8C68
	public int b()
	{
		return this.e6();
	}

	// Token: 0x0600A31A RID: 41754 RVA: 0x003EAA70 File Offset: 0x003E8C70
	public virtual string a()
	{
		return null;
	}

	// Token: 0x0600A31B RID: 41755 RVA: 0x003EAA74 File Offset: 0x003E8C74
	public bool a(efk A_0)
	{
		czh.a(A_0, "character");
		return A_0.Feats.c(this.e3());
	}

	// Token: 0x0600A31C RID: 41756 RVA: 0x003EAA94 File Offset: 0x003E8C94
	public virtual object[] e7()
	{
		return new object[0];
	}

	// Token: 0x0600A31D RID: 41757 RVA: 0x003EAA9C File Offset: 0x003E8C9C
	public static int a(int A_0)
	{
		return A_0 - aiy.an;
	}
}
