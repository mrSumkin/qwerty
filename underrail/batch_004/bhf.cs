using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x0200130F RID: 4879
[eiz("CSEEA")]
[a(typeof(u2))]
[Serializable]
public sealed class bhf : u2, ISerializable
{
	// Token: 0x06006D5D RID: 27997 RVA: 0x002DB9BC File Offset: 0x002D9BBC
	private bhf(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (QuickAspectAccessor<amc>)A_0.GetValue("CSEEA:CEAA", typeof(QuickAspectAccessor<amc>));
			return;
		}
		this.a = (A_0.GetValue("_CharacterEntityAspectAccessor", typeof(QuickAspectAccessor<amc>)) as QuickAspectAccessor<amc>);
	}

	// Token: 0x06006D5E RID: 27998 RVA: 0x002DBA1C File Offset: 0x002D9C1C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CSEEA:CEAA", this.a);
	}

	// Token: 0x06006D5F RID: 27999 RVA: 0x002DBA38 File Offset: 0x002D9C38
	public bhf(c5x A_0) : base(A_0)
	{
		this.a = new QuickAspectAccessor<amc>(A_0);
	}

	// Token: 0x06006D60 RID: 28000 RVA: 0x002DBA50 File Offset: 0x002D9C50
	public override List<ud> xw()
	{
		if (this.a.b == null)
		{
			this.a.b();
		}
		if (this.a.b != null && this.a.b.aa() != null && this.a.b.aa().StatusEffects != null)
		{
			return this.a.b.aa().StatusEffects.e;
		}
		return null;
	}

	// Token: 0x04002CC7 RID: 11463
	private QuickAspectAccessor<amc> a;
}
