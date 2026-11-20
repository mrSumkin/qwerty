using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x0200133B RID: 4923
[eiz("SECA")]
[Serializable]
public abstract class bhv : b1z, g5, ISerializable
{
	// Token: 0x06006F91 RID: 28561 RVA: 0x002ED350 File Offset: 0x002EB550
	protected bhv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (els)A_0.GetValue("SECA:SE", typeof(els));
			this.b = (ll)A_0.GetValue("SECA:C", typeof(ll));
			this.c = (EntityAspectReference<amc, amc>)A_0.GetValue("SECA:TR", typeof(EntityAspectReference<amc, amc>));
			return;
		}
		if (base.GetType() == typeof(bhv))
		{
			this.a = (els)A_0.GetValue("_StatusEffect", typeof(els));
			this.b = (ll)A_0.GetValue("_Context", typeof(ll));
			this.c = (EntityAspectReference<amc, amc>)A_0.GetValue("_TargetRef", typeof(EntityAspectReference<amc, amc>));
			return;
		}
		this.a = (els)A_0.GetValue("StatusEffectComponentAction+_StatusEffect", typeof(els));
		this.b = (ll)A_0.GetValue("StatusEffectComponentAction+_Context", typeof(ll));
		this.c = (EntityAspectReference<amc, amc>)A_0.GetValue("StatusEffectComponentAction+_TargetRef", typeof(EntityAspectReference<amc, amc>));
	}

	// Token: 0x06006F92 RID: 28562 RVA: 0x002ED4AC File Offset: 0x002EB6AC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SECA:SE", this.a);
		info.AddValue("SECA:C", this.b);
		info.AddValue("SECA:TR", this.c);
	}

	// Token: 0x06006F93 RID: 28563 RVA: 0x002ED4F4 File Offset: 0x002EB6F4
	public els xy()
	{
		return this.a;
	}

	// Token: 0x06006F94 RID: 28564 RVA: 0x002ED4FC File Offset: 0x002EB6FC
	public void xz(els A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006F95 RID: 28565 RVA: 0x002ED508 File Offset: 0x002EB708
	public ll x0()
	{
		return this.b;
	}

	// Token: 0x06006F96 RID: 28566 RVA: 0x002ED510 File Offset: 0x002EB710
	public void x1(ll A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006F97 RID: 28567 RVA: 0x002ED51C File Offset: 0x002EB71C
	public EntityAspectReference<amc, amc> a()
	{
		return this.c;
	}

	// Token: 0x06006F98 RID: 28568 RVA: 0x002ED524 File Offset: 0x002EB724
	public void a(EntityAspectReference<amc, amc> A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006F99 RID: 28569 RVA: 0x002ED530 File Offset: 0x002EB730
	public amc x2()
	{
		if (this.c != null)
		{
			return this.c.ao();
		}
		return null;
	}

	// Token: 0x06006F9A RID: 28570 RVA: 0x002ED54C File Offset: 0x002EB74C
	public void x3(amc A_0)
	{
		if (this.c == null || this.c.ao() != A_0)
		{
			this.c = new EntityAspectReference<amc, amc>(A_0);
		}
	}

	// Token: 0x06006F9B RID: 28571 RVA: 0x002ED578 File Offset: 0x002EB778
	protected bhv()
	{
	}

	// Token: 0x04002D9A RID: 11674
	private new els a;

	// Token: 0x04002D9B RID: 11675
	private ll b;

	// Token: 0x04002D9C RID: 11676
	private EntityAspectReference<amc, amc> c;
}
