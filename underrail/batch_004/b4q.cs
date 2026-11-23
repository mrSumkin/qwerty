using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010A3 RID: 4259
[eiz("SQJ0")]
[Serializable]
public sealed class b4q : cze, ISerializable
{
	// Token: 0x06005953 RID: 22867 RVA: 0x0026A0B4 File Offset: 0x002682B4
	private b4q(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetString("SQJ0:QN");
		this.a = A_0.GetBoolean("SQJ0:PE");
	}

	// Token: 0x06005954 RID: 22868 RVA: 0x0026A0E8 File Offset: 0x002682E8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SQJ0:QN", this.b);
		info.AddValue("SQJ0:PE", this.a);
	}

	// Token: 0x06005955 RID: 22869 RVA: 0x0026A114 File Offset: 0x00268314
	public string a()
	{
		return this.b;
	}

	// Token: 0x06005956 RID: 22870 RVA: 0x0026A11C File Offset: 0x0026831C
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005957 RID: 22871 RVA: 0x0026A128 File Offset: 0x00268328
	public bool b()
	{
		return this.a;
	}

	// Token: 0x06005958 RID: 22872 RVA: 0x0026A130 File Offset: 0x00268330
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005959 RID: 22873 RVA: 0x0026A13C File Offset: 0x0026833C
	public b4q()
	{
	}

	// Token: 0x0600595A RID: 22874 RVA: 0x0026A14C File Offset: 0x0026834C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		bpo.GetServiceOrThrow<cnk>().aqz().atb(this.a(), this.a);
	}

	// Token: 0x040023EA RID: 9194
	private new bool a = true;

	// Token: 0x040023EB RID: 9195
	private string b;
}
