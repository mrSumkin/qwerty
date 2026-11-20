using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010BF RID: 4287
[eiz("GPBOS")]
[Serializable]
public sealed class xw : cze, ISerializable
{
	// Token: 0x06005A18 RID: 23064 RVA: 0x0026E20C File Offset: 0x0026C40C
	private xw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("GPBOS:GP");
	}

	// Token: 0x06005A19 RID: 23065 RVA: 0x0026E228 File Offset: 0x0026C428
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("GPBOS:GP", this.a);
	}

	// Token: 0x06005A1A RID: 23066 RVA: 0x0026E244 File Offset: 0x0026C444
	public string a()
	{
		return this.a;
	}

	// Token: 0x06005A1B RID: 23067 RVA: 0x0026E24C File Offset: 0x0026C44C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005A1C RID: 23068 RVA: 0x0026E258 File Offset: 0x0026C458
	public xw()
	{
	}

	// Token: 0x06005A1D RID: 23069 RVA: 0x0026E264 File Offset: 0x0026C464
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v().b() is c5x)
		{
			int num = new Random(this.a().GetHashCode() + serviceOrThrow.aqu().l()).Next(0, 101);
			serviceOrThrow.aqu().r()[this.a] = num;
		}
	}

	// Token: 0x0400241F RID: 9247
	private new string a;
}
