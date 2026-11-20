using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001AEE RID: 6894
[eiz("SSS")]
[Serializable]
public sealed class ehp : els, ISerializable, dl2
{
	// Token: 0x0600955C RID: 38236 RVA: 0x003A9AB0 File Offset: 0x003A7CB0
	private ehp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (A_0.GetValue("SSS:P", typeof(vf)) as vf);
	}

	// Token: 0x0600955D RID: 38237 RVA: 0x003A9ADC File Offset: 0x003A7CDC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SSS:P", this.b);
	}

	// Token: 0x0600955E RID: 38238 RVA: 0x003A9AF8 File Offset: 0x003A7CF8
	public override bool oa()
	{
		return false;
	}

	// Token: 0x0600955F RID: 38239 RVA: 0x003A9B00 File Offset: 0x003A7D00
	public ehp(efk A_0, int A_1, int A_2) : base(ehp.a, "Яд (призрак)", ci8.c)
	{
		base.Duration = A_1;
		base.Icon = "Status.Poison";
		base.Stacking = axm.b;
		base.Power = A_2;
		base.TickPeriod = d0u.b;
		base.ExpiredAction = "SpiritPoisonExpiresAction";
		cwt cwt = new cwt();
		cwt.i = new ap9("Poison", (A_0 != null) ? A_0.FactionId : null);
		cwt.f.Add(new csk(DamageType.Bio, A_2));
		cwt.l = true;
		cwt.p = true;
		cwt.r = true;
		cwt.b = true;
		cwt.w = true;
		cwt.ag = true;
		this.b = new vf(cwt, cwt, null);
		base.DynamicEffects.Add(this.b);
		base.StaticEffects.Add(new cly(-(float)ezx.j)
		{
			Priority = int.MaxValue
		});
	}

	// Token: 0x06009560 RID: 38240 RVA: 0x003A9BFC File Offset: 0x003A7DFC
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/SpiritPoison", new object[]
		{
			base.Power,
			(int)(ezx.j * 100.0)
		});
	}

	// Token: 0x04003983 RID: 14723
	public new static string a = "poison:SpiritPoison";

	// Token: 0x04003984 RID: 14724
	private vf b;
}
