using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02001434 RID: 5172
[eiz("ATA1")]
[Serializable]
public abstract class azp : b1z, ISerializable
{
	// Token: 0x060073F5 RID: 29685 RVA: 0x00311048 File Offset: 0x0030F248
	protected azp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("ATA1:AR", typeof(EntityAspectReference<amc, amc>));
			this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("ATA1:TR", typeof(EntityAspectReference<amc, amc>));
			return;
		}
		if (base.GetType() == typeof(azp))
		{
			this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("_AttackerRef", typeof(EntityAspectReference<amc, amc>));
			this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("_TargetRef", typeof(EntityAspectReference<amc, amc>));
			return;
		}
		this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("AttackedTargetAction+_AttackerRef", typeof(EntityAspectReference<amc, amc>));
		this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("AttackedTargetAction+_TargetRef", typeof(EntityAspectReference<amc, amc>));
	}

	// Token: 0x060073F6 RID: 29686 RVA: 0x00311144 File Offset: 0x0030F344
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ATA1:AR", this.a);
		info.AddValue("ATA1:TR", this.b);
	}

	// Token: 0x060073F7 RID: 29687 RVA: 0x00311170 File Offset: 0x0030F370
	public amc n()
	{
		if (this.a != null)
		{
			return this.a.ao();
		}
		return null;
	}

	// Token: 0x060073F8 RID: 29688 RVA: 0x0031118C File Offset: 0x0030F38C
	public amc m()
	{
		if (this.b != null)
		{
			return this.b.ao();
		}
		return null;
	}

	// Token: 0x060073F9 RID: 29689 RVA: 0x003111A8 File Offset: 0x0030F3A8
	protected azp(amc A_0, amc A_1)
	{
		this.a = new EntityAspectReference<amc, amc>(A_0);
		this.b = new EntityAspectReference<amc, amc>(A_1);
	}

	// Token: 0x04002F68 RID: 12136
	private new EntityAspectReference<amc, amc> a;

	// Token: 0x04002F69 RID: 12137
	private EntityAspectReference<amc, amc> b;
}
