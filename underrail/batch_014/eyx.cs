using System;
using System.Runtime.Serialization;

// Token: 0x0200051F RID: 1311
[eiz("LE1")]
[Serializable]
public abstract class eyx : c47, ISerializable
{
	// Token: 0x060021C3 RID: 8643 RVA: 0x000B3FAC File Offset: 0x000B21AC
	protected eyx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (aip)A_0.GetValue("LE1:OC", typeof(aip));
			return;
		}
		if (base.GetType() == typeof(eyx))
		{
			this.a = (aip)A_0.GetValue("_ObservationConditions", typeof(aip));
			return;
		}
		this.a = (aip)A_0.GetValue("LocalEvent+_ObservationConditions", typeof(aip));
	}

	// Token: 0x060021C4 RID: 8644 RVA: 0x000B4054 File Offset: 0x000B2254
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("LE1:OC", this.a);
	}

	// Token: 0x060021C5 RID: 8645 RVA: 0x000B4070 File Offset: 0x000B2270
	public aip j()
	{
		return this.a;
	}

	// Token: 0x060021C6 RID: 8646 RVA: 0x000B4078 File Offset: 0x000B2278
	protected eyx()
	{
	}

	// Token: 0x04001462 RID: 5218
	private aip a = new aip();
}
