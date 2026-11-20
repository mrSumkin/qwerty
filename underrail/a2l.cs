using System;

// Token: 0x020018B8 RID: 6328
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class a2l : Attribute
{
	// Token: 0x06008650 RID: 34384 RVA: 0x0037B204 File Offset: 0x00379404
	public string a()
	{
		return this.a;
	}

	// Token: 0x06008651 RID: 34385 RVA: 0x0037B20C File Offset: 0x0037940C
	public a2l(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x04003381 RID: 13185
	private string a;
}
