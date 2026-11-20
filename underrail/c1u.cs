using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Common;

// Token: 0x02000514 RID: 1300
[eiz("CSDE")]
[Serializable]
public sealed class c1u : bjs, b2h, ISerializable
{
	// Token: 0x0600217F RID: 8575 RVA: 0x000B2E7C File Offset: 0x000B107C
	private c1u(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadList<csk>("CSDE:D", ref this.a, A_0);
			this.b = (cwt)A_0.GetValue("CSDE:AR", typeof(cwt));
			return;
		}
		if (base.GetType() == typeof(c1u))
		{
			this.a = (List<csk>)A_0.GetValue("_Damages", typeof(List<csk>));
			this.b = (cwt)A_0.GetValue("_AttackResult", typeof(cwt));
			return;
		}
		this.a = (List<csk>)A_0.GetValue("CharacterShieldsDamageEvent+_Damages", typeof(List<csk>));
		this.b = (cwt)A_0.GetValue("CharacterShieldsDamageEvent+_AttackResult", typeof(cwt));
	}

	// Token: 0x06002180 RID: 8576 RVA: 0x000B2F68 File Offset: 0x000B1168
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<csk>("CSDE:D", this.a, info);
		info.AddValue("CSDE:AR", this.b);
	}

	// Token: 0x06002181 RID: 8577 RVA: 0x000B2F94 File Offset: 0x000B1194
	public cwt c()
	{
		return this.b;
	}

	// Token: 0x06002182 RID: 8578 RVA: 0x000B2F9C File Offset: 0x000B119C
	public List<csk> d()
	{
		return this.a;
	}

	// Token: 0x06002183 RID: 8579 RVA: 0x000B2FA4 File Offset: 0x000B11A4
	public c1u(cwt A_0, List<csk> A_1) : base((A_0 != null) ? A_0.j : null, (A_0 != null) ? A_0.i : null)
	{
		this.a = A_1;
		this.b = A_0;
	}

	// Token: 0x06002184 RID: 8580 RVA: 0x000B2FE0 File Offset: 0x000B11E0
	public override List<string> b()
	{
		if (this.b != null && !this.b.u)
		{
			return new List<string>
			{
				TimelapseTextFeeds.Combat.ToString()
			};
		}
		return new List<string>();
	}

	// Token: 0x06002185 RID: 8581 RVA: 0x000B3028 File Offset: 0x000B1228
	public ecs se()
	{
		if (this.b == null)
		{
			return null;
		}
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		ecs.a.Add(dl);
		dl.a.Add(new bph(bvm.a(), string.Format("- {0}: щит поглощает ", (base.h() != null) ? base.h().a() : base.i()), null));
		bjs.a(dl, this.a);
		dl.a.Add(new bph(bvm.a(), string.Format("{0}.", (!string.IsNullOrEmpty(this.b.v)) ? (" (" + this.b.v + ")") : ""), null));
		return ecs;
	}

	// Token: 0x04001451 RID: 5201
	private new List<csk> a;

	// Token: 0x04001452 RID: 5202
	private new cwt b;
}
