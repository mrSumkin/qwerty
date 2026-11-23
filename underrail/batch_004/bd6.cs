using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010EB RID: 4331
[eiz("FQJ0")]
[Serializable]
public sealed class bd6 : cze, ISerializable
{
	// Token: 0x06005B8C RID: 23436 RVA: 0x00274E00 File Offset: 0x00273000
	private bd6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetString("FQJ0:QN");
		this.a = A_0.GetBoolean("FQJ0:PE");
	}

	// Token: 0x06005B8D RID: 23437 RVA: 0x00274E34 File Offset: 0x00273034
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FQJ0:QN", this.b);
		info.AddValue("FQJ0:PE", this.a);
	}

	// Token: 0x06005B8E RID: 23438 RVA: 0x00274E60 File Offset: 0x00273060
	public string a()
	{
		return this.b;
	}

	// Token: 0x06005B8F RID: 23439 RVA: 0x00274E68 File Offset: 0x00273068
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005B90 RID: 23440 RVA: 0x00274E74 File Offset: 0x00273074
	public bool b()
	{
		return this.a;
	}

	// Token: 0x06005B91 RID: 23441 RVA: 0x00274E7C File Offset: 0x0027307C
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005B92 RID: 23442 RVA: 0x00274E88 File Offset: 0x00273088
	public bd6()
	{
	}

	// Token: 0x06005B93 RID: 23443 RVA: 0x00274E98 File Offset: 0x00273098
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		bpo.GetServiceOrThrow<cnk>().aqz().atd(this.a(), this.a);
	}

	// Token: 0x0400248F RID: 9359
	private new bool a = true;

	// Token: 0x04002490 RID: 9360
	private string b;
}
