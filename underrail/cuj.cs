using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x0200068D RID: 1677
[eiz("IIR")]
[Serializable]
public sealed class cuj : TypedObjectReference<coh>, ISerializable
{
	// Token: 0x06002AFB RID: 11003 RVA: 0x000F95F4 File Offset: 0x000F77F4
	private cuj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (TypedObjectReference<efk>)A_0.GetValue("IIR:O", typeof(TypedObjectReference<efk>));
		this.b = (Guid?)A_0.GetValue("IIR:II", typeof(Guid?));
	}

	// Token: 0x06002AFC RID: 11004 RVA: 0x000F964C File Offset: 0x000F784C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("IIR:O", this.a);
		info.AddValue("IIR:II", this.b);
	}

	// Token: 0x06002AFD RID: 11005 RVA: 0x000F9680 File Offset: 0x000F7880
	public cuj(TypedObjectReference<efk> A_0, coh A_1)
	{
		this.a = A_0;
		if (A_1 != null)
		{
			this.b = new Guid?(A_1.Id);
		}
		base.a(A_1);
	}

	// Token: 0x06002AFE RID: 11006 RVA: 0x000F96B0 File Offset: 0x000F78B0
	protected override coh h4()
	{
		if (this.a == null || this.b == null)
		{
			return null;
		}
		if (this.a.ao() == null)
		{
			return null;
		}
		return this.a.ao().a(this.b.Value);
	}

	// Token: 0x040018AE RID: 6318
	private TypedObjectReference<efk> a;

	// Token: 0x040018AF RID: 6319
	private Guid? b;
}
