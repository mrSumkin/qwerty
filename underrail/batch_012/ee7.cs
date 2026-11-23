using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200120E RID: 4622
[eiz("CC0")]
[Serializable]
public sealed class ee7 : ya, ISerializable, l2
{
	// Token: 0x0600634B RID: 25419 RVA: 0x002ADC48 File Offset: 0x002ABE48
	protected ee7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("CC0:T", typeof(ar7)) as ar7);
	}

	// Token: 0x0600634C RID: 25420 RVA: 0x002ADC74 File Offset: 0x002ABE74
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CC0:T", this.a);
	}

	// Token: 0x0600634D RID: 25421 RVA: 0x002ADC90 File Offset: 0x002ABE90
	public c5x a()
	{
		if (this.a != null)
		{
			return this.a.ao() as c5x;
		}
		return null;
	}

	// Token: 0x0600634E RID: 25422 RVA: 0x002ADCB4 File Offset: 0x002ABEB4
	public ee7(c5x A_0)
	{
		this.a = new ar7(A_0);
		base.Name = "CaltropTrigger_" + Guid.NewGuid().ToString();
	}

	// Token: 0x0600634F RID: 25423 RVA: 0x002ADCF8 File Offset: 0x002ABEF8
	protected override void jk(b0b A_0)
	{
		base.jk(A_0);
		c5x c5x = A_0 as c5x;
		if (c5x != null && this.a != null && c5x.h.b != null && !c5x.h.b.aa().d(CharacterImmunities.Caltrops))
		{
			c5x c5x2 = this.a.ao() as c5x;
			if (c5x2 != null)
			{
				arn aspect = c5x2.GetAspect<arn>();
				if (aspect != null && aspect.b(c5x))
				{
					c7 a_ = new c7(c5x2, false, false, true, false);
					base.Area.Zone.ActionManager.g9(a_, atp.a);
					dz6.a(a_);
					base.o();
				}
			}
		}
	}

	// Token: 0x06006350 RID: 25424 RVA: 0x002ADDB4 File Offset: 0x002ABFB4
	public void jl(aud A_0)
	{
		if (this.a != null && this.a.afl() != null)
		{
			this.a = new ar7(this.a.afl().Value, A_0);
		}
	}

	// Token: 0x040029D5 RID: 10709
	internal ar7 a;
}
