using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B3D RID: 2877
[eiz("CVTEW")]
[Serializable]
public sealed class db4 : cze, ISerializable
{
	// Token: 0x06004231 RID: 16945 RVA: 0x0019A6D4 File Offset: 0x001988D4
	private db4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("CVTEW:C");
	}

	// Token: 0x06004232 RID: 16946 RVA: 0x0019A6F0 File Offset: 0x001988F0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CVTEW:C", this.a);
	}

	// Token: 0x06004233 RID: 16947 RVA: 0x0019A70C File Offset: 0x0019890C
	public string a()
	{
		return this.a;
	}

	// Token: 0x06004234 RID: 16948 RVA: 0x0019A714 File Offset: 0x00198914
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004235 RID: 16949 RVA: 0x0019A720 File Offset: 0x00198920
	public db4()
	{
	}

	// Token: 0x06004236 RID: 16950 RVA: 0x0019A728 File Offset: 0x00198928
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		w9.a(this.a);
	}

	// Token: 0x04001C24 RID: 7204
	private new string a;
}
