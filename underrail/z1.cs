using System;

// Token: 0x020017FE RID: 6142
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public class z1 : Attribute
{
	// Token: 0x0600827F RID: 33407 RVA: 0x0036C8A0 File Offset: 0x0036AAA0
	public z1(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x04003260 RID: 12896
	public string a;
}
