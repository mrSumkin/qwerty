using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

// Token: 0x02000485 RID: 1157
[eiz("LNF")]
[XmlRoot("LanguageInfo")]
[Serializable]
public sealed class cy8 : ISerializable
{
	// Token: 0x06001DB0 RID: 7600 RVA: 0x000A46E0 File Offset: 0x000A28E0
	private cy8(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("LNF:C");
		this.b = A_0.GetString("LNF:N");
	}

	// Token: 0x06001DB1 RID: 7601 RVA: 0x000A470C File Offset: 0x000A290C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("LNF:C", this.a);
		info.AddValue("LNF:N", this.b);
	}

	// Token: 0x06001DB2 RID: 7602 RVA: 0x000A4730 File Offset: 0x000A2930
	public string b()
	{
		return this.a;
	}

	// Token: 0x06001DB3 RID: 7603 RVA: 0x000A4738 File Offset: 0x000A2938
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001DB4 RID: 7604 RVA: 0x000A4744 File Offset: 0x000A2944
	public string a()
	{
		return this.b;
	}

	// Token: 0x06001DB5 RID: 7605 RVA: 0x000A474C File Offset: 0x000A294C
	public void b(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001DB6 RID: 7606 RVA: 0x000A4758 File Offset: 0x000A2958
	public cy8()
	{
	}

	// Token: 0x040010C3 RID: 4291
	private string a;

	// Token: 0x040010C4 RID: 4292
	private string b;
}
