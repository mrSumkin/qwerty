using System;
using System.Runtime.Serialization;

// Token: 0x02001471 RID: 5233
[eiz("ACA")]
[Serializable]
public abstract class cvd : dvv, ca5, ISerializable
{
	// Token: 0x06007626 RID: 30246 RVA: 0x0031EB44 File Offset: 0x0031CD44
	protected cvd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (aty)A_0.GetValue("ACA:R", typeof(aty));
			return;
		}
		if (base.GetType() == typeof(cvd))
		{
			this.a = (aty)A_0.GetValue("_Root", typeof(aty));
			return;
		}
		this.a = (aty)A_0.GetValue("AuraComponentAction+_Root", typeof(aty));
	}

	// Token: 0x06007627 RID: 30247 RVA: 0x0031EBE0 File Offset: 0x0031CDE0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ACA:R", this.a);
	}

	// Token: 0x06007628 RID: 30248 RVA: 0x0031EBFC File Offset: 0x0031CDFC
	public aty aig()
	{
		return this.a;
	}

	// Token: 0x06007629 RID: 30249 RVA: 0x0031EC04 File Offset: 0x0031CE04
	public void aih(aty A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600762A RID: 30250 RVA: 0x0031EC10 File Offset: 0x0031CE10
	protected cvd(aty A_0)
	{
		czh.a(A_0, "root");
		this.a = A_0;
	}

	// Token: 0x0600762B RID: 30251 RVA: 0x0031EC2C File Offset: 0x0031CE2C
	protected cvd()
	{
	}

	// Token: 0x04003037 RID: 12343
	private new aty a;
}
