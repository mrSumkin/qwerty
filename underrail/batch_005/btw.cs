using System;
using System.Runtime.Serialization;

// Token: 0x020018A1 RID: 6305
[eiz("CUEA")]
[Serializable]
public sealed class btw : btm, ISerializable
{
	// Token: 0x060085EC RID: 34284 RVA: 0x00377D18 File Offset: 0x00375F18
	private btw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(btw);
		}
	}

	// Token: 0x060085ED RID: 34285 RVA: 0x00377D44 File Offset: 0x00375F44
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x060085EE RID: 34286 RVA: 0x00377D50 File Offset: 0x00375F50
	public btw() : base(null)
	{
	}

	// Token: 0x060085EF RID: 34287 RVA: 0x00377D5C File Offset: 0x00375F5C
	protected override bool b4(e6d A_0)
	{
		bpo.GetServiceOrThrow<ps>().akx().ae1();
		return true;
	}
}
