using System;

// Token: 0x02001455 RID: 5205
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class d1q : Attribute
{
	// Token: 0x0600751D RID: 29981 RVA: 0x0031A368 File Offset: 0x00318568
	public string a()
	{
		return this.a;
	}

	// Token: 0x0600751E RID: 29982 RVA: 0x0031A370 File Offset: 0x00318570
	public d1q(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x04002FFA RID: 12282
	private string a;
}
