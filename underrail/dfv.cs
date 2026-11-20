using System;
using System.Runtime.Serialization;

// Token: 0x02000519 RID: 1305
[eiz("CSRE")]
[Serializable]
public sealed class dfv : bjs, b2h, ISerializable
{
	// Token: 0x0600219B RID: 8603 RVA: 0x000B36A8 File Offset: 0x000B18A8
	private dfv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetInt32("CSRE:A");
			return;
		}
		if (base.GetType() == typeof(dfv))
		{
			this.a = A_0.GetInt32("_Amount");
			return;
		}
		this.a = A_0.GetInt32("CharacterShieldRestoredEvent+_Amount");
	}

	// Token: 0x0600219C RID: 8604 RVA: 0x000B3718 File Offset: 0x000B1918
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CSRE:A", this.a);
	}

	// Token: 0x0600219D RID: 8605 RVA: 0x000B3734 File Offset: 0x000B1934
	public int c()
	{
		return this.a;
	}

	// Token: 0x0600219E RID: 8606 RVA: 0x000B373C File Offset: 0x000B193C
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600219F RID: 8607 RVA: 0x000B3748 File Offset: 0x000B1948
	public dfv(ap9 A_0, int A_1) : base(A_0, null)
	{
		this.a = A_1;
	}

	// Token: 0x060021A0 RID: 8608 RVA: 0x000B375C File Offset: 0x000B195C
	public ecs se()
	{
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		ecs.a.Add(dl);
		dl.a.Add(new bph(bvm.a(), string.Format("- {0} получает ", (base.h() != null) ? base.h().a() : base.i()), null));
		dl.a.Add(new bph(bvm.a(adi.x), string.Format("{0} щит.", this.a), null));
		dl.a.Add(new bph(bvm.a(), ".", null));
		return ecs;
	}

	// Token: 0x04001457 RID: 5207
	private new int a;
}
