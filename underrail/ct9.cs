using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x0200142D RID: 5165
[eiz("FSEA")]
[Serializable]
public sealed class ct9 : b1z, ISerializable
{
	// Token: 0x060073C9 RID: 29641 RVA: 0x0030E81C File Offset: 0x0030CA1C
	private ct9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (EntityAspectReference<su, su>)A_0.GetValue("FSEA:TR", typeof(EntityAspectReference<su, su>));
			return;
		}
		if (base.GetType() == typeof(ct9))
		{
			this.a = (EntityAspectReference<su, su>)A_0.GetValue("_TargetRef", typeof(EntityAspectReference<su, su>));
			return;
		}
		this.a = (EntityAspectReference<su, su>)A_0.GetValue("FlashShieldEmitterAction+_TargetRef", typeof(EntityAspectReference<su, su>));
	}

	// Token: 0x060073CA RID: 29642 RVA: 0x0030E8B8 File Offset: 0x0030CAB8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FSEA:TR", this.a);
	}

	// Token: 0x060073CB RID: 29643 RVA: 0x0030E8D4 File Offset: 0x0030CAD4
	public ct9(EntityAspectReference<su, su> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060073CC RID: 29644 RVA: 0x0030E8E4 File Offset: 0x0030CAE4
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a == null || this.a.ao() == null)
		{
			return dc4.e;
		}
		this.a.ao().h();
		return dc4.c;
	}

	// Token: 0x04002F51 RID: 12113
	private new EntityAspectReference<su, su> a;
}
