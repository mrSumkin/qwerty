using System;
using System.Runtime.Serialization;

// Token: 0x020018C3 RID: 6339
[eiz("FR1")]
[Serializable]
public class cky : ISerializable
{
	// Token: 0x06008684 RID: 34436 RVA: 0x0037C0DC File Offset: 0x0037A2DC
	protected cky(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (h)A_0.GetValue("FR1:A", typeof(h));
			this.b = (h?)A_0.GetValue("FR1:SL", typeof(h?));
			return;
		}
		if (base.GetType() == typeof(cky))
		{
			this.a = (h)A_0.GetValue("_Attitude", typeof(h));
			this.b = (h?)A_0.GetValue("_SupportLevel", typeof(h?));
			return;
		}
		this.a = (h)A_0.GetValue("FactionRelation+_Attitude", typeof(h));
		this.b = (h?)A_0.GetValue("FactionRelation+_SupportLevel", typeof(h?));
	}

	// Token: 0x06008685 RID: 34437 RVA: 0x0037C1D8 File Offset: 0x0037A3D8
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("FR1:A", this.a);
		info.AddValue("FR1:SL", this.b);
	}

	// Token: 0x06008686 RID: 34438 RVA: 0x0037C208 File Offset: 0x0037A408
	public cky()
	{
	}

	// Token: 0x040033CF RID: 13263
	public h a;

	// Token: 0x040033D0 RID: 13264
	public h? b;
}
