using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

// Token: 0x020000E4 RID: 228
[eiz("PHR")]
[XmlRoot("Phrase")]
[Serializable]
public sealed class ehq : ISerializable
{
	// Token: 0x060004FA RID: 1274 RVA: 0x000169E8 File Offset: 0x00014BE8
	private ehq(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("PHR:K");
		this.b = A_0.GetBoolean("PHR:I");
		this.c = A_0.GetString("PHR:O");
		this.d = A_0.GetString("PHR:L");
	}

	// Token: 0x060004FB RID: 1275 RVA: 0x00016A40 File Offset: 0x00014C40
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("PHR:K", this.a);
		info.AddValue("PHR:I", this.b);
		info.AddValue("PHR:O", this.c);
		info.AddValue("PHR:L", this.d);
	}

	// Token: 0x060004FC RID: 1276 RVA: 0x00016A94 File Offset: 0x00014C94
	public string d()
	{
		return this.a;
	}

	// Token: 0x060004FD RID: 1277 RVA: 0x00016A9C File Offset: 0x00014C9C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060004FE RID: 1278 RVA: 0x00016AA8 File Offset: 0x00014CA8
	public bool a()
	{
		return this.b;
	}

	// Token: 0x060004FF RID: 1279 RVA: 0x00016AB0 File Offset: 0x00014CB0
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06000500 RID: 1280 RVA: 0x00016ABC File Offset: 0x00014CBC
	public string c()
	{
		return this.c;
	}

	// Token: 0x06000501 RID: 1281 RVA: 0x00016AC4 File Offset: 0x00014CC4
	public void b(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06000502 RID: 1282 RVA: 0x00016AD0 File Offset: 0x00014CD0
	public string b()
	{
		return this.d;
	}

	// Token: 0x06000503 RID: 1283 RVA: 0x00016AD8 File Offset: 0x00014CD8
	public void c(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06000504 RID: 1284 RVA: 0x00016AE4 File Offset: 0x00014CE4
	public ehq()
	{
	}

	// Token: 0x04000474 RID: 1140
	private string a;

	// Token: 0x04000475 RID: 1141
	private bool b;

	// Token: 0x04000476 RID: 1142
	private string c;

	// Token: 0x04000477 RID: 1143
	private string d;
}
