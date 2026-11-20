using System;
using System.Runtime.Serialization;

// Token: 0x02001151 RID: 4433
[eiz("UAI")]
[Serializable]
public sealed class avd : ISerializable
{
	// Token: 0x06005EF4 RID: 24308 RVA: 0x00284060 File Offset: 0x00282260
	private avd(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("UAI:I");
		this.b = A_0.GetString("UAI:C");
		this.c = A_0.GetString("UAI:A");
		this.d = A_0.GetString("UAI:D");
	}

	// Token: 0x06005EF5 RID: 24309 RVA: 0x002840B8 File Offset: 0x002822B8
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("UAI:I", this.a);
		info.AddValue("UAI:C", this.b);
		info.AddValue("UAI:A", this.c);
		info.AddValue("UAI:D", this.d);
	}

	// Token: 0x06005EF6 RID: 24310 RVA: 0x0028410C File Offset: 0x0028230C
	public avd()
	{
	}

	// Token: 0x06005EF7 RID: 24311 RVA: 0x00284114 File Offset: 0x00282314
	public avd(string A_0, string A_1, string A_2, string A_3)
	{
		this.b = A_0;
		this.a = A_1;
		this.c = A_2;
		this.d = A_3;
	}

	// Token: 0x040025C7 RID: 9671
	public string a;

	// Token: 0x040025C8 RID: 9672
	public string b;

	// Token: 0x040025C9 RID: 9673
	public string c;

	// Token: 0x040025CA RID: 9674
	public string d;
}
