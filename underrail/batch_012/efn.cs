using System;
using System.Runtime.CompilerServices;

// Token: 0x020001BF RID: 447
public struct efn
{
	// Token: 0x06000D45 RID: 3397 RVA: 0x00038B6C File Offset: 0x00036D6C
	[CompilerGenerated]
	public bool b()
	{
		return this.a;
	}

	// Token: 0x06000D46 RID: 3398 RVA: 0x00038B74 File Offset: 0x00036D74
	[CompilerGenerated]
	public void d(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000D47 RID: 3399 RVA: 0x00038B80 File Offset: 0x00036D80
	[CompilerGenerated]
	public bool d()
	{
		return this.b;
	}

	// Token: 0x06000D48 RID: 3400 RVA: 0x00038B88 File Offset: 0x00036D88
	[CompilerGenerated]
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06000D49 RID: 3401 RVA: 0x00038B94 File Offset: 0x00036D94
	[CompilerGenerated]
	public bool a()
	{
		return this.c;
	}

	// Token: 0x06000D4A RID: 3402 RVA: 0x00038B9C File Offset: 0x00036D9C
	[CompilerGenerated]
	public void c(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06000D4B RID: 3403 RVA: 0x00038BA8 File Offset: 0x00036DA8
	[CompilerGenerated]
	public bool e()
	{
		return this.d;
	}

	// Token: 0x06000D4C RID: 3404 RVA: 0x00038BB0 File Offset: 0x00036DB0
	[CompilerGenerated]
	public void b(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06000D4D RID: 3405 RVA: 0x00038BBC File Offset: 0x00036DBC
	public static bool b(efn A_0, efn A_1)
	{
		return A_0.Equals(A_1);
	}

	// Token: 0x06000D4E RID: 3406 RVA: 0x00038BD4 File Offset: 0x00036DD4
	public static bool a(efn A_0, efn A_1)
	{
		return !A_0.Equals(A_1);
	}

	// Token: 0x06000D4F RID: 3407 RVA: 0x00038BF0 File Offset: 0x00036DF0
	public void c()
	{
		this.d(false);
		this.a(false);
		this.c(false);
		this.b(false);
	}

	// Token: 0x06000D50 RID: 3408 RVA: 0x00038C1C File Offset: 0x00036E1C
	public override bool Equals(object obj)
	{
		if (!(obj is efn))
		{
			return false;
		}
		efn efn = (efn)obj;
		return this.b() == efn.b() && this.d() == efn.d() && this.a() == efn.a() && this.e() == efn.e();
	}

	// Token: 0x06000D51 RID: 3409 RVA: 0x00038C84 File Offset: 0x00036E84
	public override int GetHashCode()
	{
		return this.b().GetHashCode() * 10000 + this.d().GetHashCode() * 1000 + this.a().GetHashCode() * 100 + this.e().GetHashCode() * 10;
	}

	// Token: 0x040007DC RID: 2012
	[CompilerGenerated]
	private bool a;

	// Token: 0x040007DD RID: 2013
	[CompilerGenerated]
	private bool b;

	// Token: 0x040007DE RID: 2014
	[CompilerGenerated]
	private bool c;

	// Token: 0x040007DF RID: 2015
	[CompilerGenerated]
	private bool d;
}
