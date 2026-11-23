using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001018 RID: 4120
[eiz("DLBPJ")]
[Serializable]
public sealed class egb : cze, ISerializable
{
	// Token: 0x06005500 RID: 21760 RVA: 0x0025A24C File Offset: 0x0025844C
	private egb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("DLBPJ:BN");
	}

	// Token: 0x06005501 RID: 21761 RVA: 0x0025A268 File Offset: 0x00258468
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DLBPJ:BN", this.a);
	}

	// Token: 0x06005502 RID: 21762 RVA: 0x0025A284 File Offset: 0x00258484
	public string a()
	{
		return this.a;
	}

	// Token: 0x06005503 RID: 21763 RVA: 0x0025A28C File Offset: 0x0025848C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005504 RID: 21764 RVA: 0x0025A298 File Offset: 0x00258498
	public egb()
	{
	}

	// Token: 0x06005505 RID: 21765 RVA: 0x0025A2A0 File Offset: 0x002584A0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (!string.IsNullOrEmpty(this.a))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				df6.a(this.a, serviceOrThrow.aqu().v());
			}
		}
	}

	// Token: 0x040022B0 RID: 8880
	private new string a;
}
