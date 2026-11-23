using System;
using System.Runtime.Serialization;

// Token: 0x0200052B RID: 1323
[eiz("DE")]
[Serializable]
public abstract class cb7 : c47, ISerializable
{
	// Token: 0x060021F7 RID: 8695 RVA: 0x000B49AC File Offset: 0x000B2BAC
	protected cb7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (cqh)A_0.GetValue("DE:D", typeof(cqh));
			return;
		}
		if (base.GetType() == typeof(cb7))
		{
			this.a = (cqh)A_0.GetValue("_Document", typeof(cqh));
			return;
		}
		this.a = (cqh)A_0.GetValue("DocumentEvent+_Document", typeof(cqh));
	}

	// Token: 0x060021F8 RID: 8696 RVA: 0x000B4A48 File Offset: 0x000B2C48
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DE:D", this.a);
	}

	// Token: 0x060021F9 RID: 8697 RVA: 0x000B4A64 File Offset: 0x000B2C64
	public cqh c()
	{
		return this.a;
	}

	// Token: 0x060021FA RID: 8698 RVA: 0x000B4A6C File Offset: 0x000B2C6C
	protected cb7(cqh A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0400146B RID: 5227
	private cqh a;
}
