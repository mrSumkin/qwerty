using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x0200142C RID: 5164
[eiz("DCA")]
[Serializable]
public sealed class aro : b1z, ISerializable
{
	// Token: 0x060073C5 RID: 29637 RVA: 0x0030E718 File Offset: 0x0030C918
	private aro(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("DCA:CAR", typeof(EntityAspectReference<amc, amc>));
			return;
		}
		if (base.GetType() == typeof(aro))
		{
			this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("_CharacterAspectRef", typeof(EntityAspectReference<amc, amc>));
			return;
		}
		this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("DestealthCharacterAction+_CharacterAspectRef", typeof(EntityAspectReference<amc, amc>));
	}

	// Token: 0x060073C6 RID: 29638 RVA: 0x0030E7B4 File Offset: 0x0030C9B4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DCA:CAR", this.a);
	}

	// Token: 0x060073C7 RID: 29639 RVA: 0x0030E7D0 File Offset: 0x0030C9D0
	public aro(amc A_0)
	{
		if (A_0 != null)
		{
			this.a = new EntityAspectReference<amc, amc>(A_0);
		}
	}

	// Token: 0x060073C8 RID: 29640 RVA: 0x0030E7EC File Offset: 0x0030C9EC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a != null && this.a.ao() != null)
		{
			this.a.ao().u();
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x04002F50 RID: 12112
	private new EntityAspectReference<amc, amc> a;
}
