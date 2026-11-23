using System;
using System.Runtime.Serialization;

// Token: 0x02001495 RID: 5269
[eiz("USIA")]
[Serializable]
public sealed class e4y : ad5, ISerializable
{
	// Token: 0x060076B9 RID: 30393 RVA: 0x00323C8C File Offset: 0x00321E8C
	private e4y(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(e4y);
		}
	}

	// Token: 0x060076BA RID: 30394 RVA: 0x00323CB8 File Offset: 0x00321EB8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x060076BB RID: 30395 RVA: 0x00323CC4 File Offset: 0x00321EC4
	protected override m7 d6()
	{
		return m7.d;
	}

	// Token: 0x060076BC RID: 30396 RVA: 0x00323CC8 File Offset: 0x00321EC8
	public e4y(eu7 A_0, c5x A_1, object A_2) : base(A_0, A_1, A_2, false)
	{
	}

	// Token: 0x060076BD RID: 30397 RVA: 0x00323CD4 File Offset: 0x00321ED4
	public override pl d7()
	{
		return new b9z(this);
	}

	// Token: 0x060076BE RID: 30398 RVA: 0x00323CDC File Offset: 0x00321EDC
	public override boa d8(afq A_0, params evd[] A_1)
	{
		return new am3(this, A_0, A_1);
	}
}
