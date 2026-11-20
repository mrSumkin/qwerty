using System;
using System.Runtime.Serialization;

// Token: 0x02000529 RID: 1321
[eiz("LUFE")]
[Serializable]
public sealed class v4 : a0x, ISerializable
{
	// Token: 0x060021F0 RID: 8688 RVA: 0x000B48E8 File Offset: 0x000B2AE8
	private v4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("LUFE:M");
			return;
		}
		if (base.GetType() == typeof(v4))
		{
			this.a = A_0.GetString("_Message");
			return;
		}
		this.a = A_0.GetString("LockUnlockingFailedEvent+_Message");
	}

	// Token: 0x060021F1 RID: 8689 RVA: 0x000B4958 File Offset: 0x000B2B58
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("LUFE:M", this.a);
	}

	// Token: 0x060021F2 RID: 8690 RVA: 0x000B4974 File Offset: 0x000B2B74
	public v4(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060021F3 RID: 8691 RVA: 0x000B4984 File Offset: 0x000B2B84
	protected override string hk()
	{
		return this.a;
	}

	// Token: 0x0400146A RID: 5226
	private string a;
}
