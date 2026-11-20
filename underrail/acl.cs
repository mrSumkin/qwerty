using System;
using System.Runtime.Serialization;

// Token: 0x02001A52 RID: 6738
[eiz("MBE")]
[Serializable]
public sealed class acl : d3e, ISerializable
{
	// Token: 0x06009244 RID: 37444 RVA: 0x0039EFF0 File Offset: 0x0039D1F0
	private acl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(acl);
		}
	}

	// Token: 0x06009245 RID: 37445 RVA: 0x0039F01C File Offset: 0x0039D21C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06009246 RID: 37446 RVA: 0x0039F028 File Offset: 0x0039D228
	protected override void @in(ll A_0)
	{
		A_0.a().SpecialStates.d = true;
	}

	// Token: 0x06009247 RID: 37447 RVA: 0x0039F03C File Offset: 0x0039D23C
	public acl()
	{
	}

	// Token: 0x06009248 RID: 37448 RVA: 0x0039F048 File Offset: 0x0039D248
	public override d3e b3()
	{
		acl acl = new acl();
		this.xx(acl);
		return acl;
	}
}
