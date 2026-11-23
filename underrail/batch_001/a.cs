using System;

// Token: 0x020000F4 RID: 244
[AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
public sealed class a : Attribute
{
	// Token: 0x17000030 RID: 48
	// (get) Token: 0x06000593 RID: 1427 RVA: 0x000181EC File Offset: 0x000163EC
	public Type FacadeType
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x06000594 RID: 1428 RVA: 0x000181F4 File Offset: 0x000163F4
	public a(Type A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0400049A RID: 1178
	private Type a;
}
