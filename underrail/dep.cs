using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02001465 RID: 5221
[eiz("ACA1")]
[Serializable]
public sealed class dep : b1z, ISerializable
{
	// Token: 0x060075B6 RID: 30134 RVA: 0x0031D468 File Offset: 0x0031B668
	private dep(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("ACA1:SR", typeof(EntityAspectReference<amc, amc>));
			di7.ReadList<cfd>("ACA1:C", ref this.b, A_0);
			return;
		}
		if (base.GetType() == typeof(dep))
		{
			this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("_SubjectRef", typeof(EntityAspectReference<amc, amc>));
			this.b = (List<cfd>)A_0.GetValue("_Cooldowns", typeof(List<cfd>));
			return;
		}
		this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("ApplyCooldownsAction+_SubjectRef", typeof(EntityAspectReference<amc, amc>));
		this.b = (List<cfd>)A_0.GetValue("ApplyCooldownsAction+_Cooldowns", typeof(List<cfd>));
	}

	// Token: 0x060075B7 RID: 30135 RVA: 0x0031D560 File Offset: 0x0031B760
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ACA1:SR", this.a);
		di7.WriteList<cfd>("ACA1:C", this.b, info);
	}

	// Token: 0x060075B8 RID: 30136 RVA: 0x0031D58C File Offset: 0x0031B78C
	public amc a()
	{
		if (this.a != null)
		{
			return this.a.ao();
		}
		return null;
	}

	// Token: 0x060075B9 RID: 30137 RVA: 0x0031D5A8 File Offset: 0x0031B7A8
	public List<cfd> b()
	{
		return this.b;
	}

	// Token: 0x060075BA RID: 30138 RVA: 0x0031D5B0 File Offset: 0x0031B7B0
	public dep(amc A_0, params cfd[] A_1)
	{
		if (A_0 != null)
		{
			this.a = new EntityAspectReference<amc, amc>(A_0);
		}
		if (A_1 != null && A_1.Length != 0)
		{
			this.b.AddRange(A_1);
		}
	}

	// Token: 0x060075BB RID: 30139 RVA: 0x0031D5F0 File Offset: 0x0031B7F0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a() == null)
		{
			return dc4.e;
		}
		this.a().aa().Cooldowns.a(this.b);
		return dc4.c;
	}

	// Token: 0x04003028 RID: 12328
	private new EntityAspectReference<amc, amc> a;

	// Token: 0x04003029 RID: 12329
	private List<cfd> b = new List<cfd>();
}
