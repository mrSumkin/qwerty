using System;
using System.Runtime.Serialization;

// Token: 0x0200023E RID: 574
[eiz("LS")]
[Serializable]
public sealed class c3y : ISerializable
{
	// Token: 0x06001037 RID: 4151 RVA: 0x000435B0 File Offset: 0x000417B0
	private c3y(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (dqc)A_0.GetValue("LS:S", typeof(dqc));
			this.b = (Guid)A_0.GetValue("LS:C", typeof(Guid));
			this.c = (alr)A_0.GetValue("LS:L", typeof(alr));
			return;
		}
		if (base.GetType() == typeof(c3y))
		{
			this.a = (dqc)A_0.GetValue("<SourceType>k__BackingField", typeof(dqc));
			this.b = (Guid)A_0.GetValue("<CorrelationId>k__BackingField", typeof(Guid));
			this.c = (alr)A_0.GetValue("<LightFragment>k__BackingField", typeof(alr));
			return;
		}
		this.a = (dqc)A_0.GetValue("LightStamp+<SourceType>k__BackingField", typeof(dqc));
		this.b = (Guid)A_0.GetValue("LightStamp+<CorrelationId>k__BackingField", typeof(Guid));
		this.c = (alr)A_0.GetValue("LightStamp+<LightFragment>k__BackingField", typeof(alr));
	}

	// Token: 0x06001038 RID: 4152 RVA: 0x0004370C File Offset: 0x0004190C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("LS:S", this.a);
		info.AddValue("LS:C", this.b);
		info.AddValue("LS:L", this.c);
	}

	// Token: 0x06001039 RID: 4153 RVA: 0x0004374C File Offset: 0x0004194C
	public dqc b()
	{
		return this.a;
	}

	// Token: 0x0600103A RID: 4154 RVA: 0x00043754 File Offset: 0x00041954
	public void a(dqc A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600103B RID: 4155 RVA: 0x00043760 File Offset: 0x00041960
	public Guid c()
	{
		return this.b;
	}

	// Token: 0x0600103C RID: 4156 RVA: 0x00043768 File Offset: 0x00041968
	private void a(Guid A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600103D RID: 4157 RVA: 0x00043774 File Offset: 0x00041974
	public alr a()
	{
		return this.c;
	}

	// Token: 0x0600103E RID: 4158 RVA: 0x0004377C File Offset: 0x0004197C
	public void a(alr A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600103F RID: 4159 RVA: 0x00043788 File Offset: 0x00041988
	public c3y(Guid A_0, alr A_1, dqc A_2)
	{
		this.a(A_0);
		this.a(A_1);
		this.a(A_2);
	}

	// Token: 0x04000972 RID: 2418
	private dqc a;

	// Token: 0x04000973 RID: 2419
	private Guid b;

	// Token: 0x04000974 RID: 2420
	private alr c;
}
