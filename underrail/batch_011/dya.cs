using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x0200142F RID: 5167
[eiz("RSA")]
[Serializable]
public sealed class dya : b1z, ISerializable
{
	// Token: 0x060073D1 RID: 29649 RVA: 0x0030EAF0 File Offset: 0x0030CCF0
	private dya(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("RSA:TR", typeof(EntityAspectReference<amc, amc>));
			this.b = A_0.GetSingle("RSA:A");
			this.c = A_0.GetBoolean("RSA:C");
			return;
		}
		if (base.GetType() == typeof(dya))
		{
			this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("_TargetRef", typeof(EntityAspectReference<amc, amc>));
			this.b = A_0.GetSingle("_Amount");
			this.c = A_0.GetBoolean("_Critical");
			return;
		}
		this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("RestoreShieldAction+_TargetRef", typeof(EntityAspectReference<amc, amc>));
		this.b = A_0.GetSingle("RestoreShieldAction+_Amount");
		this.c = A_0.GetBoolean("RestoreShieldAction+_Critical");
	}

	// Token: 0x060073D2 RID: 29650 RVA: 0x0030EBF4 File Offset: 0x0030CDF4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RSA:TR", this.a);
		info.AddValue("RSA:A", this.b);
		info.AddValue("RSA:C", this.c);
	}

	// Token: 0x060073D3 RID: 29651 RVA: 0x0030EC3C File Offset: 0x0030CE3C
	public dya(EntityAspectReference<amc, amc> A_0, float A_1, bool A_2)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
	}

	// Token: 0x060073D4 RID: 29652 RVA: 0x0030EC5C File Offset: 0x0030CE5C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a == null || this.a.ao() == null)
		{
			return dc4.e;
		}
		this.a.ao().aa().Defense.a(this.b, this.c);
		return dc4.c;
	}

	// Token: 0x04002F58 RID: 12120
	private new EntityAspectReference<amc, amc> a;

	// Token: 0x04002F59 RID: 12121
	private float b;

	// Token: 0x04002F5A RID: 12122
	private bool c;
}
