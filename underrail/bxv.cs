using System;
using System.Runtime.Serialization;

// Token: 0x02000501 RID: 1281
[eiz("CDEX")]
[Serializable]
public sealed class bxv : bjs, b2h, ISerializable
{
	// Token: 0x06002120 RID: 8480 RVA: 0x000B1698 File Offset: 0x000AF898
	private bxv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("CDEX:E");
	}

	// Token: 0x06002121 RID: 8481 RVA: 0x000B16B4 File Offset: 0x000AF8B4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CDEX:E", this.a);
	}

	// Token: 0x06002122 RID: 8482 RVA: 0x000B16D0 File Offset: 0x000AF8D0
	public string c()
	{
		return this.a;
	}

	// Token: 0x06002123 RID: 8483 RVA: 0x000B16D8 File Offset: 0x000AF8D8
	public bxv(ap9 A_0, string A_1) : base(A_0, null)
	{
		this.a = A_1;
	}

	// Token: 0x06002124 RID: 8484 RVA: 0x000B16EC File Offset: 0x000AF8EC
	public ecs se()
	{
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		ecs.a.Add(dl);
		dl.a.Add(new bph(bvm.a(adi.o), string.Format("- {0} уклоняется от {1}.", (base.h() != null) ? base.h().a() : base.i(), this.a), null));
		return ecs;
	}

	// Token: 0x04001441 RID: 5185
	private new string a;
}
