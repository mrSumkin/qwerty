using System;

// Token: 0x02001B59 RID: 7001
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
internal sealed class dgg : Attribute
{
	// Token: 0x060097A0 RID: 38816 RVA: 0x003B16F4 File Offset: 0x003AF8F4
	public string a()
	{
		return this.a;
	}

	// Token: 0x060097A1 RID: 38817 RVA: 0x003B16FC File Offset: 0x003AF8FC
	public dgg(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x04003A3A RID: 14906
	private string a;
}
