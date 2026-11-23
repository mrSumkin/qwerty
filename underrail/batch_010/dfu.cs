using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Common;

// Token: 0x02000515 RID: 1301
[eiz("CRDE")]
[Serializable]
public sealed class dfu : bjs, b2h, ISerializable
{
	// Token: 0x06002186 RID: 8582 RVA: 0x000B3100 File Offset: 0x000B1300
	private dfu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadList<csk>("CRDE:D", ref this.a, A_0);
			this.b = (cwt)A_0.GetValue("CRDE:AR", typeof(cwt));
			return;
		}
		if (base.GetType() == typeof(dfu))
		{
			this.a = (List<csk>)A_0.GetValue("_Damages", typeof(List<csk>));
			this.b = (cwt)A_0.GetValue("_AttackResult", typeof(cwt));
			return;
		}
		this.a = (List<csk>)A_0.GetValue("CharacterResistsDamageEvent+_Damages", typeof(List<csk>));
		this.b = (cwt)A_0.GetValue("CharacterResistsDamageEvent+_AttackResult", typeof(cwt));
	}

	// Token: 0x06002187 RID: 8583 RVA: 0x000B31EC File Offset: 0x000B13EC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<csk>("CRDE:D", this.a, info);
		info.AddValue("CRDE:AR", this.b);
	}

	// Token: 0x06002188 RID: 8584 RVA: 0x000B3218 File Offset: 0x000B1418
	public cwt c()
	{
		return this.b;
	}

	// Token: 0x06002189 RID: 8585 RVA: 0x000B3220 File Offset: 0x000B1420
	public List<csk> d()
	{
		return this.a;
	}

	// Token: 0x0600218A RID: 8586 RVA: 0x000B3228 File Offset: 0x000B1428
	public dfu(cwt A_0, List<csk> A_1) : base((A_0 != null) ? A_0.j : null, (A_0 != null) ? A_0.i : null)
	{
		this.a = A_1;
		this.b = A_0;
	}

	// Token: 0x0600218B RID: 8587 RVA: 0x000B3264 File Offset: 0x000B1464
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

	// Token: 0x0600218C RID: 8588 RVA: 0x000B32AC File Offset: 0x000B14AC
	public ecs se()
	{
		if (this.b == null)
		{
			return null;
		}
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		ecs.a.Add(dl);
		dl.a.Add(new bph(bvm.a(), string.Format("- {0}: броня поглощает ", (base.h() != null) ? base.h().a() : base.i()), null));
		bjs.a(dl, this.a);
		dl.a.Add(new bph(bvm.a(), string.Format("{0}.", (!string.IsNullOrEmpty(this.b.v)) ? (" (" + this.b.v + ")") : ""), null));
		return ecs;
	}

	// Token: 0x04001453 RID: 5203
	private new List<csk> a;

	// Token: 0x04001454 RID: 5204
	private new cwt b;
}
