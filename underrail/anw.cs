using System;
using System.Runtime.Serialization;

// Token: 0x02001851 RID: 6225
[eiz("PEA2")]
[Serializable]
public sealed class anw : b1z, ISerializable
{
	// Token: 0x060084C0 RID: 33984 RVA: 0x003732B0 File Offset: 0x003714B0
	private anw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (dli)A_0.GetValue("PEA2:E", typeof(dli));
			return;
		}
		if (base.GetType() == typeof(anw))
		{
			this.a = (dli)A_0.GetValue("_Event", typeof(dli));
			return;
		}
		this.a = (dli)A_0.GetValue("PublishEventAction+_Event", typeof(dli));
	}

	// Token: 0x060084C1 RID: 33985 RVA: 0x0037334C File Offset: 0x0037154C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PEA2:E", this.a);
	}

	// Token: 0x060084C2 RID: 33986 RVA: 0x00373368 File Offset: 0x00371568
	public anw(dli A_0)
	{
		czh.a(A_0, "e");
		this.a = A_0;
	}

	// Token: 0x060084C3 RID: 33987 RVA: 0x00373384 File Offset: 0x00371584
	protected override dc4 dt()
	{
		eta service = bpo.GetService<eta>();
		if (service != null)
		{
			service.ao6(this.a);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x060084C4 RID: 33988 RVA: 0x003733AC File Offset: 0x003715AC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x040032E0 RID: 13024
	private new dli a;
}
