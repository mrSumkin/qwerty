using System;

// Token: 0x0200018D RID: 397
public class j : chr
{
	// Token: 0x06000BC0 RID: 3008 RVA: 0x0002FF18 File Offset: 0x0002E118
	public bool aw()
	{
		return this.a != null;
	}

	// Token: 0x06000BC1 RID: 3009 RVA: 0x0002FF24 File Offset: 0x0002E124
	public e08 ax()
	{
		return this.a;
	}

	// Token: 0x06000BC2 RID: 3010 RVA: 0x0002FF2C File Offset: 0x0002E12C
	public e08 ay()
	{
		e08 result = this.a;
		this.a = null;
		return result;
	}

	// Token: 0x06000BC3 RID: 3011 RVA: 0x0002FF3C File Offset: 0x0002E13C
	public bool az(e08 A_0)
	{
		bool result = this.a != null;
		this.a = A_0;
		return result;
	}

	// Token: 0x040006EF RID: 1775
	private e08 a;
}
