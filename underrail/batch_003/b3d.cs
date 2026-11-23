using System;

// Token: 0x02000094 RID: 148
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, Inherited = false, AllowMultiple = false)]
public sealed class b3d : Attribute
{
	// Token: 0x0600037C RID: 892 RVA: 0x00010134 File Offset: 0x0000E334
	public int a()
	{
		return this.a;
	}

	// Token: 0x0600037D RID: 893 RVA: 0x0001013C File Offset: 0x0000E33C
	public b3d(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0400040F RID: 1039
	private int a;
}
