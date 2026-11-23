using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000295 RID: 661
[eiz("CA2")]
[Serializable]
public abstract class f7 : dvv, ISerializable
{
	// Token: 0x06001352 RID: 4946 RVA: 0x00050D9C File Offset: 0x0004EF9C
	protected f7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			di7.ReadList<auv>("CA2:A", ref this.a, A_0);
			return;
		}
		if (base.GetType() == typeof(f7))
		{
			this.a = (List<auv>)A_0.GetValue("_Actions", typeof(List<auv>));
			return;
		}
		this.a = (List<auv>)A_0.GetValue("CompositeAction+_Actions", typeof(List<auv>));
	}

	// Token: 0x06001353 RID: 4947 RVA: 0x00050E34 File Offset: 0x0004F034
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<auv>("CA2:A", this.a, info);
	}

	// Token: 0x06001354 RID: 4948 RVA: 0x00050E50 File Offset: 0x0004F050
	public List<auv> ad()
	{
		return this.a;
	}

	// Token: 0x06001355 RID: 4949 RVA: 0x00050E58 File Offset: 0x0004F058
	protected f7()
	{
	}

	// Token: 0x06001356 RID: 4950 RVA: 0x00050E6C File Offset: 0x0004F06C
	protected f7(string A_0) : base(A_0)
	{
	}

	// Token: 0x06001357 RID: 4951 RVA: 0x00050E80 File Offset: 0x0004F080
	protected f7(IEnumerable<auv> A_0)
	{
		this.a(A_0);
	}

	// Token: 0x06001358 RID: 4952 RVA: 0x00050E9C File Offset: 0x0004F09C
	protected f7(string A_0, IEnumerable<auv> A_1) : base(A_0)
	{
		this.a(A_1);
	}

	// Token: 0x06001359 RID: 4953 RVA: 0x00050EBC File Offset: 0x0004F0BC
	public override void z(cix A_0)
	{
		base.z(A_0);
		if (this.a != null)
		{
			foreach (auv auv in this.a)
			{
				if (auv != null)
				{
					auv.z(A_0);
				}
			}
		}
	}

	// Token: 0x0600135A RID: 4954 RVA: 0x00050F30 File Offset: 0x0004F130
	private void a(IEnumerable<auv> A_0)
	{
		czh.a(A_0, "actions");
		this.a.AddRange(A_0);
	}

	// Token: 0x04000A8F RID: 2703
	private new List<auv> a = new List<auv>();
}
