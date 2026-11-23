using System;
using System.Runtime.Serialization;

// Token: 0x020006D1 RID: 1745
[eiz("SSA1")]
[Serializable]
public sealed class cnu : btm, ISerializable
{
	// Token: 0x06002CF0 RID: 11504 RVA: 0x00100980 File Offset: 0x000FEB80
	private cnu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (c2g)A_0.GetValue("SSA1:L", typeof(c2g));
		this.b = (bn3)A_0.GetValue("SSA1:S", typeof(bn3));
	}

	// Token: 0x06002CF1 RID: 11505 RVA: 0x001009D8 File Offset: 0x000FEBD8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SSA1:L", this.a);
		info.AddValue("SSA1:S", this.b);
	}

	// Token: 0x06002CF2 RID: 11506 RVA: 0x00100A0C File Offset: 0x000FEC0C
	public cnu(c2g A_0, bn3 A_1) : base(null)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06002CF3 RID: 11507 RVA: 0x00100A24 File Offset: 0x000FEC24
	protected override bool b4(e6d A_0)
	{
		bpo.GetServiceOrThrow<am7>();
		return true;
	}

	// Token: 0x04001997 RID: 6551
	private c2g a;

	// Token: 0x04001998 RID: 6552
	private bn3 b;
}
