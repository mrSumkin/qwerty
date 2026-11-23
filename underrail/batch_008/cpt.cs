using System;
using System.Runtime.Serialization;

// Token: 0x02000524 RID: 1316
[eiz("LLFE")]
[Serializable]
public sealed class cpt : a0x, ISerializable
{
	// Token: 0x060021DA RID: 8666 RVA: 0x000B467C File Offset: 0x000B287C
	private cpt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("LLFE:M");
			return;
		}
		if (base.GetType() == typeof(cpt))
		{
			this.a = A_0.GetString("_Message");
			return;
		}
		this.a = A_0.GetString("LockLockingFailedEvent+_Message");
	}

	// Token: 0x060021DB RID: 8667 RVA: 0x000B46EC File Offset: 0x000B28EC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("LLFE:M", this.a);
	}

	// Token: 0x060021DC RID: 8668 RVA: 0x000B4708 File Offset: 0x000B2908
	public cpt(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060021DD RID: 8669 RVA: 0x000B4718 File Offset: 0x000B2918
	protected override string hk()
	{
		return this.a;
	}

	// Token: 0x04001468 RID: 5224
	private string a;
}
