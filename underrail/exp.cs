using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000513 RID: 1299
[eiz("CEDE")]
[Serializable]
public sealed class exp : bjs, b2h, ISerializable
{
	// Token: 0x06002179 RID: 8569 RVA: 0x000B2C7C File Offset: 0x000B0E7C
	private exp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadList<csk>("CEDE:D", ref this.a, A_0);
			this.b = (cwt)A_0.GetValue("CEDE:AR", typeof(cwt));
			return;
		}
		if (base.GetType() == typeof(exp))
		{
			this.a = (List<csk>)A_0.GetValue("_Damages", typeof(List<csk>));
			this.b = (cwt)A_0.GetValue("_AttackResult", typeof(cwt));
			return;
		}
		this.a = (List<csk>)A_0.GetValue("CharacterEvadesDamageEvent+_Damages", typeof(List<csk>));
		this.b = (cwt)A_0.GetValue("CharacterEvadesDamageEvent+_AttackResult", typeof(cwt));
	}

	// Token: 0x0600217A RID: 8570 RVA: 0x000B2D68 File Offset: 0x000B0F68
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<csk>("CEDE:D", this.a, info);
		info.AddValue("CEDE:AR", this.b);
	}

	// Token: 0x0600217B RID: 8571 RVA: 0x000B2D94 File Offset: 0x000B0F94
	public cwt c()
	{
		return this.b;
	}

	// Token: 0x0600217C RID: 8572 RVA: 0x000B2D9C File Offset: 0x000B0F9C
	public List<csk> d()
	{
		return this.a;
	}

	// Token: 0x0600217D RID: 8573 RVA: 0x000B2DA4 File Offset: 0x000B0FA4
	public exp(cwt A_0, List<csk> A_1) : base((A_0 != null) ? A_0.j : null, (A_0 != null) ? A_0.i : null)
	{
		this.a = A_1;
		this.b = A_0;
	}

	// Token: 0x0600217E RID: 8574 RVA: 0x000B2DE0 File Offset: 0x000B0FE0
	public ecs se()
	{
		if (this.b == null)
		{
			return null;
		}
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		ecs.a.Add(dl);
		dl.a.Add(new bph(bvm.a(), string.Format("- {0} уворачивается от ", (base.h() != null) ? base.h().a() : base.i()), null));
		bjs.a(dl, this.a);
		dl.a.Add(new bph(bvm.a(), ".", null));
		return ecs;
	}

	// Token: 0x0400144F RID: 5199
	private new List<csk> a;

	// Token: 0x04001450 RID: 5200
	private new cwt b;
}
