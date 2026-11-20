using System;
using System.Runtime.Serialization;

// Token: 0x02000527 RID: 1319
[eiz("LDFE")]
[Serializable]
public sealed class bj6 : a0x, ISerializable
{
	// Token: 0x060021E9 RID: 8681 RVA: 0x000B4824 File Offset: 0x000B2A24
	private bj6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("LDFE:M");
			return;
		}
		if (base.GetType() == typeof(bj6))
		{
			this.a = A_0.GetString("_Message");
			return;
		}
		this.a = A_0.GetString("LockDisablingFailedEvent+_Message");
	}

	// Token: 0x060021EA RID: 8682 RVA: 0x000B4894 File Offset: 0x000B2A94
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("LDFE:M", this.a);
	}

	// Token: 0x060021EB RID: 8683 RVA: 0x000B48B0 File Offset: 0x000B2AB0
	public bj6(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060021EC RID: 8684 RVA: 0x000B48C0 File Offset: 0x000B2AC0
	protected override string hk()
	{
		return this.a;
	}

	// Token: 0x04001469 RID: 5225
	private string a;
}
