using System;

// Token: 0x020000F2 RID: 242
[AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
public sealed class cnn : Attribute
{
	// Token: 0x0600058D RID: 1421 RVA: 0x000181A4 File Offset: 0x000163A4
	public string b()
	{
		return this.a;
	}

	// Token: 0x0600058E RID: 1422 RVA: 0x000181AC File Offset: 0x000163AC
	public Type a()
	{
		return this.b;
	}

	// Token: 0x0600058F RID: 1423 RVA: 0x000181B4 File Offset: 0x000163B4
	public cnn(Type A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06000590 RID: 1424 RVA: 0x000181C4 File Offset: 0x000163C4
	public cnn(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x04000497 RID: 1175
	private string a;

	// Token: 0x04000498 RID: 1176
	private Type b;
}
