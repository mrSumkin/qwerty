using System;
using System.Runtime.Serialization;

// Token: 0x02001846 RID: 6214
[eiz("PSEOC")]
[Serializable]
public sealed class k1 : w0, ISerializable
{
	// Token: 0x06008477 RID: 33911 RVA: 0x003721E0 File Offset: 0x003703E0
	private k1(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (ar7)A_0.GetValue("PSEOC:ER", typeof(ar7));
			return;
		}
		if (base.GetType() == typeof(k1))
		{
			this.a = (ar7)A_0.GetValue("_EntityRef", typeof(ar7));
			return;
		}
		this.a = (ar7)A_0.GetValue("PlayerSeesEntityObservationCondition+_EntityRef", typeof(ar7));
	}

	// Token: 0x06008478 RID: 33912 RVA: 0x0037227C File Offset: 0x0037047C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("PSEOC:ER", this.a);
	}

	// Token: 0x06008479 RID: 33913 RVA: 0x00372290 File Offset: 0x00370490
	public k1(b0b A_0)
	{
		this.a = new ar7(A_0);
	}

	// Token: 0x0600847A RID: 33914 RVA: 0x003722A4 File Offset: 0x003704A4
	public k1(ar7 A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600847B RID: 33915 RVA: 0x003722B4 File Offset: 0x003704B4
	public bool @if(c1a A_0)
	{
		if (this.a != null && this.a.ao() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			return this.a.ao().c(serviceOrThrow.aqu().v().a().d);
		}
		return false;
	}

	// Token: 0x040032BF RID: 12991
	private ar7 a;
}
