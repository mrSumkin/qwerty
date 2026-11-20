using System;
using System.Runtime.Serialization;

// Token: 0x02001772 RID: 6002
[eiz("SSEACA")]
[Serializable]
public sealed class mq : cvd, ISerializable
{
	// Token: 0x060080EA RID: 33002 RVA: 0x00366734 File Offset: 0x00364934
	private mq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadArray<els>("SSEACA:SE", ref this.a, A_0);
			return;
		}
		if (base.GetType() == typeof(mq))
		{
			this.a = (els[])A_0.GetValue("_StatusEffects", typeof(els[]));
			return;
		}
		this.a = (els[])A_0.GetValue("SetStatusEffectsAuraComponentAction+_StatusEffects", typeof(els[]));
	}

	// Token: 0x060080EB RID: 33003 RVA: 0x003667C0 File Offset: 0x003649C0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteArray<els>("SSEACA:SE", this.a, info);
	}

	// Token: 0x060080EC RID: 33004 RVA: 0x003667DC File Offset: 0x003649DC
	public mq(params els[] A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060080ED RID: 33005 RVA: 0x003667EC File Offset: 0x003649EC
	protected override dc4 dt()
	{
		if (this.a == null || this.a.Length == 0)
		{
			return dc4.c;
		}
		return dc4.b;
	}

	// Token: 0x060080EE RID: 33006 RVA: 0x0036680C File Offset: 0x00364A0C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.aig().f().h.b == null || base.aig().f().Zone == null)
		{
			return dc4.e;
		}
		amd a_ = new amd(base.aig().f().h.b, this.a);
		base.aig().f().Zone.ActionManager.g9(a_, atp.a);
		return dc4.c;
	}

	// Token: 0x04003258 RID: 12888
	private new els[] a;
}
