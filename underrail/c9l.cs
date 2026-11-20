using System;
using System.Runtime.Serialization;

// Token: 0x020001D0 RID: 464
[eiz("EMM")]
[Serializable]
public sealed class c9l : ISerializable
{
	// Token: 0x06000DCC RID: 3532 RVA: 0x00039B54 File Offset: 0x00037D54
	private c9l(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetString("EMM:ETN");
			this.b = A_0.GetString("EMM:EMTN");
			return;
		}
		if (base.GetType() == typeof(c9l))
		{
			this.a = A_0.GetString("_EntityTypeName");
			this.b = A_0.GetString("_EntityMaterializerTypeName");
			return;
		}
		this.a = A_0.GetString("EntityMaterializationMapping+_EntityTypeName");
		this.b = A_0.GetString("EntityMaterializationMapping+_EntityMaterializerTypeName");
	}

	// Token: 0x06000DCD RID: 3533 RVA: 0x00039BF4 File Offset: 0x00037DF4
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("EMM:ETN", this.a);
		info.AddValue("EMM:EMTN", this.b);
	}

	// Token: 0x06000DCE RID: 3534 RVA: 0x00039C18 File Offset: 0x00037E18
	public string a()
	{
		return this.a;
	}

	// Token: 0x06000DCF RID: 3535 RVA: 0x00039C20 File Offset: 0x00037E20
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000DD0 RID: 3536 RVA: 0x00039C2C File Offset: 0x00037E2C
	public string b()
	{
		return this.b;
	}

	// Token: 0x06000DD1 RID: 3537 RVA: 0x00039C34 File Offset: 0x00037E34
	public void b(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06000DD2 RID: 3538 RVA: 0x00039C40 File Offset: 0x00037E40
	public c9l()
	{
	}

	// Token: 0x06000DD3 RID: 3539 RVA: 0x00039C48 File Offset: 0x00037E48
	public c9l(string A_0, string A_1)
	{
		czh.a(A_0, "entityTypeName");
		czh.a(A_1, "entityMaterializerTypeName");
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x040007FF RID: 2047
	private string a;

	// Token: 0x04000800 RID: 2048
	private string b;
}
