using System;
using System.Runtime.Serialization;

// Token: 0x020007B0 RID: 1968
[eiz("SW")]
[Serializable]
public abstract class eps : ai, ebs, ISerializable
{
	// Token: 0x06003157 RID: 12631 RVA: 0x0012EDEC File Offset: 0x0012CFEC
	protected eps(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003158 RID: 12632 RVA: 0x0012EDF8 File Offset: 0x0012CFF8
	protected eps()
	{
		base.ErrorHandling = d3s.c;
	}

	// Token: 0x06003159 RID: 12633 RVA: 0x0012EE08 File Offset: 0x0012D008
	public override btm ev(Exception A_0, btm A_1)
	{
		return new bzg(null);
	}

	// Token: 0x0600315A RID: 12634 RVA: 0x0012EE14 File Offset: 0x0012D014
	public virtual bool fe(object A_0)
	{
		bm6 bm = A_0 as bm6;
		return dz6.e() || (bm != null && bm.a8() != null && bm.a8().h.b != null && bm.a8().h.b.aa().IsInCombat);
	}

	// Token: 0x0600315B RID: 12635 RVA: 0x0012EE78 File Offset: 0x0012D078
	public virtual bool ff(object A_0)
	{
		bm6 bm = A_0 as bm6;
		return !dz6.e() && (bm == null || bm.a8() == null || bm.a8().h.b == null || !bm.a8().h.b.aa().IsInCombat);
	}
}
