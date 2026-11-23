using System;

// Token: 0x02000564 RID: 1380
public sealed class b1l
{
	// Token: 0x060023C9 RID: 9161 RVA: 0x000C63C8 File Offset: 0x000C45C8
	public b1l(string A_0, object A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x060023CA RID: 9162 RVA: 0x000C63E0 File Offset: 0x000C45E0
	public override bool Equals(object obj)
	{
		b1l b1l = obj as b1l;
		return obj != null && object.Equals(this.a, b1l.a) && object.Equals(this.b, b1l.b);
	}

	// Token: 0x060023CB RID: 9163 RVA: 0x000C6428 File Offset: 0x000C4628
	public override int GetHashCode()
	{
		return ((this.a != null) ? this.a.GetHashCode() : 0) * 1000 + ((this.b != null) ? this.b.GetHashCode() : 0);
	}

	// Token: 0x040014BE RID: 5310
	public string a;

	// Token: 0x040014BF RID: 5311
	public object b;
}
