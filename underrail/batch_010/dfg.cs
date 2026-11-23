using System;
using System.Runtime.Serialization;

// Token: 0x02001930 RID: 6448
[eiz("DBSI")]
[Serializable]
public abstract class dfg : dj3, ISerializable
{
	// Token: 0x060088D4 RID: 35028 RVA: 0x00388754 File Offset: 0x00386954
	protected dfg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (cqh)A_0.GetValue("DBSI:D", typeof(cqh));
			return;
		}
		if (base.GetType() == typeof(dfg))
		{
			this.a = (cqh)A_0.GetValue("_Document", typeof(cqh));
			return;
		}
		this.a = (cqh)A_0.GetValue("DocumentBaseStorageItem+_Document", typeof(cqh));
	}

	// Token: 0x060088D5 RID: 35029 RVA: 0x003887F0 File Offset: 0x003869F0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DBSI:D", this.a);
	}

	// Token: 0x060088D6 RID: 35030 RVA: 0x0038880C File Offset: 0x00386A0C
	public cqh b()
	{
		return this.a;
	}

	// Token: 0x060088D7 RID: 35031 RVA: 0x00388818 File Offset: 0x00386A18
	public new void a(cqh A_0)
	{
		if (this.a != A_0)
		{
			this.a = A_0;
			if (this.a.Name != null)
			{
				base.g(this.pu() + " " + this.a.Name);
				return;
			}
			base.g(this.pu() + " неизвестно");
		}
	}

	// Token: 0x060088D8 RID: 35032
	public abstract string pu();

	// Token: 0x060088D9 RID: 35033 RVA: 0x00388880 File Offset: 0x00386A80
	public dfg()
	{
	}

	// Token: 0x060088DA RID: 35034 RVA: 0x00388888 File Offset: 0x00386A88
	public dfg(cqh A_0)
	{
		this.a(A_0);
	}

	// Token: 0x060088DB RID: 35035 RVA: 0x00388898 File Offset: 0x00386A98
	protected override void ai7(bk3 A_0)
	{
		base.ai7(A_0);
		dfg dfg = A_0 as dfg;
		if (dfg != null)
		{
			dfg.a(this.b());
		}
	}

	// Token: 0x04003694 RID: 13972
	private new cqh a;
}
